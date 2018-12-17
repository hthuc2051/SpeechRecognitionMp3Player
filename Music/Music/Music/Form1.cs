using AudioSwitcher.AudioApi.CoreAudio;
using F23.StringSimilarity;
using Music.thucnh.dtos;
using Music.thucnh.models;
using Music.thucnh.utils;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Music
{
    public partial class Form1 : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;
        private string username;
        private Boolean isLogin = false;
        private int countTime = 0;
        SongDAO songDAO = new SongDAO();
        AlbumDAO albumDAO = new AlbumDAO();
        PlaylistDAO playlistDAO = new PlaylistDAO();
        UserDAO userDAO = new UserDAO();
        ArtistDAO artistDAO = new ArtistDAO();

        private List<SongDTO> listSongs_Main;
        private List<SongDTO> listSongs_Search;
        private List<Label> listSongName;
        private List<Label> listPlaylistLabel = new List<Label>();
        private List<Label> listDownLoadLabel = new List<Label>();

        private List<AlbumDTO> listAlbums;
        private List<Label> listAlbumName;

        private List<ArtistDTO> listArtist;
        private List<Label> listArtistName;

        private List<PlaylistDTO> listPlaylist;
        private List<Label> listPlaylistName;
        private List<Label> listPlaylistDeleteLabel;

        private int songIndex = 0;
        private int keyControl = 0; // 0 - song | 1 - album | 2 - artis | 3 - playlist
        private int latestVolume = 0;
        private int songAddPlaylistIndex;
        private string SONG_PATH = "";
        private string SONG_IMAGE_PATH = "";
        private string ALBUM_IMAGE_PATH = "";
        private string ARTIST_IMAGE_PATH = "";
        private string PLAYLIST_IMAGE_PATH = "";
        private string LASTEST_OPEN_DETAILS_PATH = "";


        private Boolean isRecordCommand = false;
        private Boolean isRecordLyrics = false;
        private Boolean isPlaying = false;
        private Boolean fisrt = true;
        private Boolean repeatOne = false;
        private Boolean repeatRandom = false;

        WaveOutEvent player = new WaveOutEvent();

        SpeechRecognitionEngine recognitionEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;

        public Form1()
        {
            InitializeComponent();
            listSongs_Main = songDAO.loadAllSongs();



            listSongs_Search = new List<SongDTO>();
            string fol_Dir = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            string[] tokens = fol_Dir.Split(new[] { "\\Music" }, StringSplitOptions.None);
            SONG_PATH = tokens[0] + "\\Music\\MusicFol\\";
            SONG_IMAGE_PATH = tokens[0] + "\\Music\\SongImageFol\\";
            ALBUM_IMAGE_PATH = tokens[0] + "\\Music\\AlbumImageFol\\";
            ARTIST_IMAGE_PATH = tokens[0] + "\\Music\\ArtisImageFol\\";
            PLAYLIST_IMAGE_PATH = tokens[0] + "\\Music\\PlaylistImageFol\\";
            LASTEST_OPEN_DETAILS_PATH = tokens[0] + "\\Music\\latestDetails.txt";
            GrammarControl grammarControl = new GrammarControl();
            recognitionEngine.SetInputToDefaultAudioDevice();
            loadGrammar(grammarControl.getSimpleGrammar());
            fisrt = false;
            defaultPlaybackDevice.Volume = 20;
            soundControl.Value = 20;
            listSongs_Search = listSongs_Main;
            loadSongLabel();
            setUpScrollBar();

            Mp3FileReader mp3Reader = new Mp3FileReader(SONG_PATH + listSongs_Main[songIndex].LinkOpen);
            player.Init(mp3Reader);
            player.Pause();
        }

        private void loadSongLabel()
        {
            panelDisplay.Controls.Clear();
            panelDisplay.Controls.Clear();
            Label labela = new Label();

            labela.Text = "Songs";
            labela.ForeColor = System.Drawing.Color.White;
            labela.Font = new Font("Century Gothic", 25);
            labela.Width = 300;
            labela.Height = 60;
            labela.Left = 40;
            labela.Top = 10;
            panelDisplay.Controls.Add(labela);
            listSongName = new List<Label>();
            listPlaylistLabel = new List<Label>();
            listDownLoadLabel = new List<Label>();
            if (keyControl != 3)
            {
                keyControl = 0;
                SidePanel.Height = btHome.Height;
                SidePanel.Top = btHome.Top;
                for (int i = 0; i < listSongs_Search.Count; i++)
                {
                    Label label = new Label();
                    Label labelAddPlaylist = new Label();
                    Label labelDownload = new Label();
                    listPlaylistLabel.Add(labelAddPlaylist);
                    listDownLoadLabel.Add(labelDownload);
                    listSongName.Add(label);
                    var picture = new PictureBox
                    {
                        Name = "pictureBox",
                        Size = new Size(50, 50),
                        Location = new Point(40, (i + 1) * 70),
                        Image = Image.FromFile(SONG_IMAGE_PATH + listSongs_Search[i].Image)

                    };
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    label.Text = " -   " + String.Format(listSongs_Search[i].Title, i);
                    labelAddPlaylist.Text = "" + String.Format("Add Playlist", i);
                    labelDownload.Text = "" + String.Format("Download", i);
                    label.Font = new Font("Century Gothic", 12);
                    label.Click += new EventHandler(LB_Click);
                    label.Width = 350;
                    label.MouseHover += new EventHandler(LB_Hover);
                    label.MouseLeave += new EventHandler(LB_Leave);
                    label.Cursor = Cursors.Hand;
                    label.Left = 100;
                    label.Top = (i + 1) * 70 + 15;
                    label.ForeColor = System.Drawing.Color.WhiteSmoke;
                    panelDisplay.Controls.Add(label);
                    panelDisplay.Controls.Add(picture);
                    if (isLogin)
                    {

                        labelAddPlaylist.Font = new Font("Century Gothic", 8);
                        labelAddPlaylist.Click += new EventHandler(LBPLAYLIST_Click);
                        labelAddPlaylist.Width = 100;
                        labelAddPlaylist.MouseHover += new EventHandler(LB_Hover);
                        labelAddPlaylist.MouseLeave += new EventHandler(LB_Leave);
                        labelAddPlaylist.Cursor = Cursors.Hand;
                        labelAddPlaylist.Left = 640;
                        labelAddPlaylist.Top = (i + 1) * 70 + 15;
                        labelAddPlaylist.ForeColor = System.Drawing.Color.WhiteSmoke;
                        panelDisplay.Controls.Add(labelAddPlaylist);
                    }
                    labelDownload.Font = new Font("Century Gothic", 8);
                    labelDownload.Click += new EventHandler(LBDOWNLOAD_Click);
                    labelDownload.Width = 100;
                    labelDownload.MouseHover += new EventHandler(LB_Hover);
                    labelDownload.MouseLeave += new EventHandler(LB_Leave);
                    labelDownload.Cursor = Cursors.Hand;
                    labelDownload.Left = 750;
                    labelDownload.Top = (i + 1) * 70 + 15;
                    labelDownload.ForeColor = System.Drawing.Color.WhiteSmoke;
                    labelDownload.BringToFront();
                    panelDisplay.Controls.Add(labelDownload);
                }
            }
            else
            {
                for (int i = 0; i < listSongs_Search.Count; i++)
                {
                    Label label = new Label();
                    Label labelLyrics = new Label();
                    Label labelAddRemovePlaylist = new Label();
                    Label labelDownload = new Label();

                    labelAddRemovePlaylist.Text = "" + String.Format("Add Playlist", i);
                    labelDownload.Text = "" + String.Format("Download", i);
                    listPlaylistLabel.Add(labelAddRemovePlaylist);
                    listDownLoadLabel.Add(labelDownload);
                    listSongName.Add(label);
                    var picture = new PictureBox
                    {
                        Name = "pictureBox",
                        Size = new Size(50, 50),
                        Location = new Point(40, (i + 1) * 70),
                        Image = Image.FromFile(SONG_IMAGE_PATH + listSongs_Search[i].Image)

                    };
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    label.Text = " -   " + String.Format(listSongs_Search[i].Title, i);
                    labelLyrics.Text = listSongs_Search[i].Lyrics;
                    label.Font = new Font("Century Gothic", 10);
                    labelLyrics.Font = new Font("Century Gothic", 7);
                    label.Click += new EventHandler(LB_Click);
                    label.Width = 350;
                    labelLyrics.Width = 800;
                    labelLyrics.Height = 30;
                    label.MouseHover += new EventHandler(LB_Hover);
                    label.MouseLeave += new EventHandler(LB_Leave);
                    label.Cursor = Cursors.Hand;
                    label.Left = 120;
                    label.Top = (i + 1) * 70;
                    labelLyrics.Left = 100;
                    labelLyrics.Top = (i + 1) * 70 + 20;
                    label.ForeColor = System.Drawing.Color.WhiteSmoke;
                    labelLyrics.ForeColor = System.Drawing.Color.WhiteSmoke;
                    panelDisplay.Controls.Add(label);
                    panelDisplay.Controls.Add(labelLyrics);
                    panelDisplay.Controls.Add(picture);

                    if (isLogin)
                    {

                        labelAddRemovePlaylist.Font = new Font("Century Gothic", 8);
                        labelAddRemovePlaylist.Click += new EventHandler(LBPLAYLIST_Click);
                        labelAddRemovePlaylist.Width = 100;
                        labelAddRemovePlaylist.MouseHover += new EventHandler(LB_Hover);
                        labelAddRemovePlaylist.MouseLeave += new EventHandler(LB_Leave);
                        labelAddRemovePlaylist.Cursor = Cursors.Hand;
                        labelAddRemovePlaylist.Left = 640;
                        labelAddRemovePlaylist.Top = (i + 1) * 70;
                        labelAddRemovePlaylist.ForeColor = System.Drawing.Color.WhiteSmoke;
                        labelAddRemovePlaylist.BringToFront();
                        panelDisplay.Controls.Add(labelAddRemovePlaylist);
                    }
                    labelDownload.Font = new Font("Century Gothic", 8);
                    labelDownload.Click += new EventHandler(LBDOWNLOAD_Click);
                    labelDownload.Width = 100;
                    labelDownload.MouseHover += new EventHandler(LB_Hover);
                    labelDownload.MouseLeave += new EventHandler(LB_Leave);
                    labelDownload.Cursor = Cursors.Hand;
                    labelDownload.Left = 750;
                    labelDownload.Top = (i + 1) * 70;
                    labelDownload.ForeColor = System.Drawing.Color.WhiteSmoke;
                    labelDownload.BringToFront();
                    panelDisplay.Controls.Add(labelDownload);
                }
            }

        }

        private void LBDOWNLOAD_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "mp3(*.mp3)|*.mp3";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(Path.GetFullPath(sfd.FileName));
                File.Copy(SONG_PATH + listSongs_Main[songIndex].LinkOpen, sfd.FileName);
            }

        }

        private void LBPLAYLIST_Click(object sender, EventArgs e)
        {

            listPlaylist = playlistDAO.GetPlaylistsOfUser(username);
            Label label = sender as Label;
            songAddPlaylistIndex = listPlaylistLabel.IndexOf(label);
            loadSmallPlaylist();
            panelDisplay.Controls.Add(panelPlaylist);
            panelPlaylist.BringToFront();
            panelPlaylistDetails.BringToFront();
            panelPlaylist.Visible = true;
        }

        private void loadAlbumLabel()
        {
            SidePanel.Height = btAlbum.Height;
            SidePanel.Top = btAlbum.Top;
            panelDisplay.Controls.Clear();
            Label labela = new Label();
            labela.Text = "Albums";
            labela.ForeColor = System.Drawing.Color.White;
            labela.Font = new Font("Century Gothic", 25);
            labela.Width = 300;
            labela.Height = 60;
            labela.Left = 40;
            labela.Top = 10;
            panelDisplay.Controls.Add(labela);
            listAlbumName = new List<Label>();
            for (int i = 0; i < listAlbums.Count; i++)
            {
                Label label = new Label();
                listAlbumName.Add(label);
                var picture = new PictureBox
                {
                    Name = "pictureBox",
                    Size = new Size(50, 50),
                    Location = new Point(40, (i + 1) * 70),
                    Image = Image.FromFile(ALBUM_IMAGE_PATH + listAlbums[i].Image)

                };
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                label.Text = " -   " + String.Format(listAlbums[i].Name, i);
                label.Font = new Font("Century Gothic", 12);
                label.Click += new EventHandler(LB_Click);
                label.Width = 350;
                label.MouseHover += new EventHandler(LB_Hover);
                label.MouseLeave += new EventHandler(LB_Leave);
                label.Cursor = Cursors.Hand;
                label.Left = 100;
                label.Top = (i + 1) * 70 + 10;
                label.ForeColor = System.Drawing.Color.WhiteSmoke;
                panelDisplay.Controls.Add(label);
                panelDisplay.Controls.Add(picture);
            }
        }
        private void loadArtistLabel()
        {
            SidePanel.Height = btArtist.Height;
            SidePanel.Top = btArtist.Top;
            panelDisplay.Controls.Clear();
            panelDisplay.Controls.Clear();
            Label labela = new Label();
            labela.Text = "Artists";
            labela.ForeColor = System.Drawing.Color.White;
            labela.Font = new Font("Century Gothic", 25);
            labela.Width = 300;
            labela.Height = 60;
            labela.Left = 40;
            labela.Top = 10;
            panelDisplay.Controls.Add(labela);
            listArtistName = new List<Label>();
            for (int i = 0; i < listArtist.Count; i++)
            {
                Label label = new Label();
                listArtistName.Add(label);
                var picture = new PictureBox
                {
                    Name = "pictureBox",
                    Size = new Size(50, 50),
                    Location = new Point(40, (i + 1) * 70),
                    Image = Image.FromFile(ARTIST_IMAGE_PATH + listArtist[i].Image)

                };
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                label.Text = " -   " + String.Format(listArtist[i].Name, i);
                label.Font = new Font("Century Gothic", 12);
                label.Click += new EventHandler(LB_Click);
                label.Width = 350;
                label.MouseHover += new EventHandler(LB_Hover);
                label.MouseLeave += new EventHandler(LB_Leave);
                label.Cursor = Cursors.Hand;
                label.Left = 100;
                label.Top = (i + 1) * 70 + 10;
                label.ForeColor = System.Drawing.Color.WhiteSmoke;
                panelDisplay.Controls.Add(label);
                panelDisplay.Controls.Add(picture);
            }
        }
        private void loadPlaylistLabel()
        {
            SidePanel.Height = btPlaylist.Height;
            SidePanel.Top = btPlaylist.Top;
            panelDisplay.Controls.Clear();
            Label labela = new Label();
            labela.Text = "Your playlist";
            labela.ForeColor = System.Drawing.Color.White;
            labela.Font = new Font("Century Gothic", 25);
            labela.Width = 300;
            labela.Height = 60;
            labela.Left = 40;
            labela.Top = 10;
            panelDisplay.Controls.Add(labela);
            listPlaylistName = new List<Label>();
            listPlaylistDeleteLabel = new List<Label>();
            for (int i = 0; i < listPlaylist.Count; i++)
            {
                var picture = new PictureBox
                {
                    Name = "pictureBox",
                    Size = new Size(50, 50),
                    Location = new Point(40, (i + 1) * 70),
                    Image = Image.FromFile(PLAYLIST_IMAGE_PATH + listPlaylist[i].Image)

                };
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                Label label = new Label();
                Label labelDate = new Label();
                Label labelDelete = new Label();
                listPlaylistName.Add(label);
                listPlaylistDeleteLabel.Add(labelDelete);
                string lbStr = listPlaylist[i].PlaylistName + "    -     " + listPlaylist[i].DateCreate;
                label.Text = " -   " + String.Format(lbStr, i);
                label.Font = new Font("Century Gothic", 12);

                label.Click += new EventHandler(LB_Click);
                label.Width = 350;
                label.MouseHover += new EventHandler(LB_Hover);
                label.MouseLeave += new EventHandler(LB_Leave);
                label.Cursor = Cursors.Hand;
                label.Left = 100;
                labelDate.Left = 150;
                label.Top = (i + 1) * 70 + 10;
                label.ForeColor = System.Drawing.Color.WhiteSmoke;
                panelDisplay.Controls.Add(label);
                panelDisplay.Controls.Add(picture);

                labelDelete.Text = String.Format("Delete", i);
                labelDelete.Font = new Font("Century Gothic", 12);

                labelDelete.Click += new EventHandler(PLAYLISTDELETE_Click);
                labelDelete.Width = 100;
                labelDelete.MouseHover += new EventHandler(LB_Hover);
                labelDelete.MouseLeave += new EventHandler(LB_Leave);
                labelDelete.Cursor = Cursors.Hand;
                labelDelete.Left = 750;
                labelDelete.Top = (i + 1) * 70 + 10;
                labelDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
                panelDisplay.Controls.Add(labelDelete);
            }
        }

        private void PLAYLISTDELETE_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            int index = listPlaylistDeleteLabel.IndexOf(label);
            if (playlistDAO.deleteSong_PlaylistByPlayListID(listPlaylist[index].Id))
            {
                if (playlistDAO.deletePlaylist(listPlaylist[index].Id))
                {
                    MessageBox.Show("Delete successfully !");
                }
                else
                {
                    MessageBox.Show("Delete failed !");
                }
            }
            button1_Click(sender, e);
        }

        public void loadSmallPlaylist()
        {
            panelPlaylistDetails.Controls.Clear();
            listPlaylistName = new List<Label>();
            for (int i = 0; i < listPlaylist.Count; i++)
            {

                Label label = new Label();
                Label labelDate = new Label();

                listPlaylistName.Add(label);
                string lbStr = listPlaylist[i].PlaylistName + "  -   " + listPlaylist[i].DateCreate;
                label.Text = " -   " + String.Format(lbStr, i);
                label.Font = new Font("Century Gothic", 10);

                label.Click += new EventHandler(LBSMALLPLAYLIST_Click);
                label.Width = 350;
                label.MouseHover += new EventHandler(LB_Hover);
                label.MouseLeave += new EventHandler(LB_Leave);
                label.Cursor = Cursors.Hand;
                label.Left = 0;
                label.Top = (i + 1) * 20 + 5;
                label.ForeColor = System.Drawing.Color.WhiteSmoke;
                panelPlaylistDetails.Controls.Add(label);
            }
        }

        private void LBSMALLPLAYLIST_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            int index = listPlaylistName.IndexOf(label);
            Console.WriteLine(index);
            Console.WriteLine(songAddPlaylistIndex);
            Console.WriteLine(playlistDAO.checkExistedSong_Playlist(listPlaylist[index].Id, listSongs_Main[songAddPlaylistIndex].ID));
            if (!playlistDAO.checkExistedSong_Playlist(listPlaylist[index].Id, listSongs_Main[songAddPlaylistIndex].ID))
            {
                if (playlistDAO.addSong_Playlist(listPlaylist[index].Id, listSongs_Main[songAddPlaylistIndex].ID))
                {
                    MessageBox.Show("Adding successfuly");
                }
            }
            else
            {
                MessageBox.Show("This playlist is already have this song !");
            }

        }

        private void LB_Leave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = System.Drawing.Color.WhiteSmoke;
            label.Font = new Font(label.Font, FontStyle.Regular);
        }

        private void LB_Hover(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = System.Drawing.Color.WhiteSmoke;
            label.Font = new Font(label.Font, FontStyle.Bold);
        }

        protected void LB_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;

            if (keyControl == 0 || keyControl == 3)
            {
                isPlaying = true;
                progressBarSongTime.Value = 0;
                lbTimeIncre.Text = "00:00:00";
                songIndex = listSongName.IndexOf(label);
                listSongs_Main = listSongs_Search;
                player.Dispose();
                Mp3FileReader mp3Reader = new Mp3FileReader(SONG_PATH + listSongs_Main[songIndex].LinkOpen);
                player.Init(mp3Reader);
                player.Play();

                loadSongDetails();
                btPlay.Visible = false;
                btPause.Visible = true;
            }
            else if (keyControl == 1)
            {
                int indexSelected = listAlbumName.IndexOf(label);
                listSongs_Search = songDAO.getSongsByAlbumID(listAlbums[indexSelected].Id);
                loadSongLabel();
                keyControl = 0;
            }
            else if (keyControl == 2)
            {
                int indexSelected = listArtistName.IndexOf(label);
                listAlbums = albumDAO.getAlbumsByArtistID(listArtist[indexSelected].Id);
                loadAlbumLabel();
                keyControl = 1;
            }
            else if (keyControl == 4)
            {
                int indexSelected = listPlaylistName.IndexOf(label);
                listSongs_Search = songDAO.getSongsOfPlayList(listPlaylist[indexSelected].Id);
                loadSongLabel();
                keyControl = 0;
            }

        }

        private void loadGrammar(Grammar grammar)
        {
            recognitionEngine.LoadGrammarAsync(grammar);

            recognitionEngine.SpeechRecognized += recognitionEngine_SpeechRecognized;
            if (fisrt)
            {
                recognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
            }

            if (isRecordLyrics)
            {
                recognitionEngine.SpeechRecognized += recognitionEngine_SpeechRecognizedLyric;

            }

        }
        private void recognitionEngine_SpeechRecognizedLyric(object sender, SpeechRecognizedEventArgs e)
        {
            Console.WriteLine(e.Result.Text);
        }
        private void recognitionEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Console.WriteLine(e.Result.Text);

            EventArgs eventArgs = new EventArgs();
            if (e.Result.Text.Equals("sasha one"))
            {
                speechSynthesizer.SpeakAsync("Yes");
                isRecordCommand = true;
            }
            if (isRecordCommand)
            {
                string command = e.Result.Text;
                switch (command)
                {
                    case "play song":
                        btPlay_Click(sender, eventArgs);
                        isRecordCommand = false;
                        break;
                    case "next song":
                        btNext_Click(sender, eventArgs);
                        isRecordCommand = false;
                        break;
                    case "previous song":
                        btPre_Click(sender, eventArgs);
                        isRecordCommand = false;
                        break;
                    case "volume up":
                        VolUp();
                        break;
                    case "volume down":
                        VolDown();
                        break;
                    case "pause":
                        btPause_Click(sender, eventArgs);
                        break;
                    case "download":

                        break;
                    case "mute":
                        btMute_Click(sender, eventArgs);
                        break;
                }
            }

        }

        public void loadSongDetails()
        {
            timerSong.Start();
            lbSongTitle.Text = listSongs_Main[songIndex].Title;
            lbArtis.Text = listSongs_Main[songIndex].Artis.Name;
            pictureSong.Image = Image.FromFile(SONG_IMAGE_PATH + listSongs_Main[songIndex].Image);
            pictureSong.SizeMode = PictureBoxSizeMode.Zoom;
            Console.WriteLine(listSongs_Main[songIndex].Time);
            progressBarSongTime.Maximum = listSongs_Main[songIndex].Time;
            TimeSpan time = TimeSpan.FromSeconds(listSongs_Main[songIndex].Time);
            string str = time.ToString(@"hh\:mm\:ss");
            lbMaxTime.Text = str;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            if (keyControl == 0)
            {

                listSongs_Search = songDAO.searchSong(searchValue);
                loadSongLabel();
            }
            else if (keyControl == 1)
            {
                SidePanel.Height = btHome.Height;
                SidePanel.Top = btHome.Top;

                listAlbums = albumDAO.searchAlbums(searchValue);
                loadAlbumLabel();
            }
            else if (keyControl == 2)
            {
                SidePanel.Height = btAlbum.Height;
                SidePanel.Top = btAlbum.Top;
                listArtist = artistDAO.searchArtists(searchValue);
                loadArtistLabel();
            }
            else if (keyControl == 3)
            {
                var cs = new Cosine();
                List<SongDTO> listSongs_temp = songDAO.loadAllSongs();
                List<KeyVal> lyricRanking = new List<KeyVal>();
                for (int i = 0; i < listSongs_temp.Count; i++)
                {
                    KeyVal keyVal = new KeyVal(i, cs.Similarity(searchValue, listSongs_temp[i].Lyrics));
                    lyricRanking.Add(keyVal);
                }
                lyricRanking.Sort(delegate (KeyVal x, KeyVal y)
                {
                    int a = x.Value.CompareTo(y.Value);
                    a = y.Value.CompareTo(x.Value);

                    return a;
                });
                listSongs_Search = new List<SongDTO>();
                if (lyricRanking.Count >= 5)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        listSongs_Search.Add(listSongs_temp[lyricRanking[i].Id]);
                    }
                }
                loadSongLabel();
            }
            else if (keyControl == 4)
            {
                SidePanel.Height = btPlaylist.Height;
                SidePanel.Top = btPlaylist.Top;
                listPlaylist = playlistDAO.searchPlaylistsOfUser(username, searchValue);
                loadPlaylistLabel();
            }

        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                player.Play();
                isPlaying = true;
                loadSongDetails();
                btPlay.Visible = false;
                btPause.Visible = true;
            }

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void PlayerVolume()
        {
            MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
            MMDevice defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            string currVolume = "MasterPeakVolume : " + defaultDevice.AudioMeterInformation.MasterPeakValue.ToString();
            Console.WriteLine(currVolume);
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            player.Dispose();
            btPlay.Visible = false;
            btPause.Visible = true;
            progressBarSongTime.Value = 0;
            lbTimeIncre.Text = "00:00:00";
            if (repeatRandom)
            {
                int oldIndex = songIndex;
                Random rnd = new Random();
                while (oldIndex == songIndex)
                {
                    songIndex = rnd.Next(0, listSongs_Main.Count);
                }
                player.Dispose();
                Mp3FileReader mp3Reader = new Mp3FileReader(SONG_PATH + listSongs_Main[songIndex].LinkOpen);
                loadSongDetails();
                player.Init(mp3Reader);
                player.Play();
            }
            else
            {
                if (songIndex < listSongs_Main.Count - 1)
                {
                    songIndex++;
                    Mp3FileReader mp3Reader = new Mp3FileReader(SONG_PATH + listSongs_Main[songIndex].LinkOpen);
                    player.Init(mp3Reader);
                    player.Play();
                    loadSongDetails();
                }
                else
                {
                    songIndex = 0;
                    Mp3FileReader mp3Reader = new Mp3FileReader(SONG_PATH + listSongs_Main[songIndex].LinkOpen);
                    player.Init(mp3Reader);
                    player.Play();
                    loadSongDetails();
                }
            }
        }

        private void btPre_Click(object sender, EventArgs e)
        {
            player.Dispose();
            btPlay.Visible = false;
            btPause.Visible = true;
            progressBarSongTime.Value = 0;
            lbTimeIncre.Text = "00:00:00";

            if (repeatRandom)
            {
                int oldIndex = songIndex;
                Random rnd = new Random();
                while (oldIndex == songIndex)
                {
                    songIndex = rnd.Next(0, listSongs_Main.Count);
                }
                player.Dispose();
                Mp3FileReader mp3Reader = new Mp3FileReader(SONG_PATH + listSongs_Main[songIndex].LinkOpen);
                loadSongDetails();
                player.Init(mp3Reader);
                player.Play();
            }
            else
            {
                if (songIndex > 0)
                {

                    songIndex--;
                    Mp3FileReader mp3Reader = new Mp3FileReader(SONG_PATH + listSongs_Main[songIndex].LinkOpen);
                    player.Init(mp3Reader);
                    player.Play();
                    loadSongDetails();
                }
                else
                {

                    songIndex = listSongs_Main.Count - 1;
                    Mp3FileReader mp3Reader = new Mp3FileReader(SONG_PATH + listSongs_Main[songIndex].LinkOpen);
                    player.Init(mp3Reader);
                    player.Play();
                    loadSongDetails();
                }
            }
        }



        private void btAlbum_Click(object sender, EventArgs e)
        {
            keyControl = 1;
            listAlbums = albumDAO.getAllAlbums();
            loadAlbumLabel();
            isRecordLyrics = false;
            isRecordCommand = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btHome_Click(object sender, EventArgs e)
        {
            listSongs_Main = songDAO.loadAllSongs();
            listSongs_Search = listSongs_Main;
            keyControl = 0;
            loadSongLabel();
            isRecordLyrics = false;
            isRecordCommand = true;
        }

        private void btArtist_Click(object sender, EventArgs e)
        {
            isRecordLyrics = false;
            keyControl = 2;
            listArtist = artistDAO.getAllArtists();
            loadArtistLabel();
            isRecordCommand = true;

        }

        private void btLyric_Click(object sender, EventArgs e)
        {
            keyControl = 3;
            SidePanel.Height = btLyric.Height;
            SidePanel.Top = btLyric.Top;
            panelDisplay.Controls.Clear();
            panelDisplay.Controls.Clear();
            Label labela = new Label();
            labela.Text = "Results";
            labela.ForeColor = System.Drawing.Color.White;
            labela.Font = new Font("Century Gothic", 25);
            labela.Width = 300;
            labela.Height = 60;
            labela.Left = 40;
            labela.Top = 10;
            panelDisplay.Controls.Add(labela);
            isRecordCommand = false;
            isRecordLyrics = true;
            GrammarControl grammarControl = new GrammarControl();
            loadGrammar(grammarControl.searchLyricsGrammar());
            fisrt = false;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            panelDisplay.Controls.Add(panelLogin);
            panelLogin.BringToFront();
            panelLogin.Top = 130;
            panelLogin.Left = 220;
            panelLogin.Visible = true;
            isRecordLyrics = false;
        }

        private void btPause_Click(object sender, EventArgs e)
        {

            player.Pause();
            isPlaying = false;
            btPlay.Visible = true;
            btPause.Visible = false;
            timerSong.Stop();

        }



        private void btnMuteRecordVoice_Click(object sender, EventArgs e)
        {

            btnRecordVoice.Visible = true;
            btnMuteRecordVoice.Visible = false;
            isRecordCommand = false;
            isRecordLyrics = false;
        }

        private void btnRecordVoice_Click(object sender, EventArgs e)
        {
            btnRecordVoice.Visible = false;
            btnMuteRecordVoice.Visible = true;
            isRecordCommand = true;
            isRecordLyrics = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            keyControl = 4;
            SidePanel.Height = btPlaylist.Height;
            SidePanel.Top = btPlaylist.Top;
            listPlaylist = playlistDAO.GetPlaylistsOfUser(username);
            loadPlaylistLabel();
            isRecordLyrics = false;
            isRecordCommand = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadSongLabel();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            loadSongLabel();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            string password = txtPassword.Text;
            UserDTO dto = userDAO.checkLogin(username, password);
            if (dto == null)
            {
                MessageBox.Show("Invalid username or password");
            }
            else
            {
                isLogin = true;
                panelDisplay.Controls.Remove(panelLogin);
                loadSongLabel();
                btPlaylist.Visible = true;
                label1.Text = username;
                label1.Enabled = false;
            }
        }

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        private void Mute(Form form)
        {
            SendMessageW(form.Handle, WM_APPCOMMAND, form.Handle,
                (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        private void VolDown()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void VolUp()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_UP);
        }
        public void setUpScrollBar()
        {
            panelDisplay.AutoScroll = true;
        }



        private void soundControl_Scroll(object sender, EventArgs e)
        {
            defaultPlaybackDevice.Volume = soundControl.Value;
            latestVolume = soundControl.Value;
        }



        private void btNotMute_Click(object sender, EventArgs e)
        {
            btChangeToMute.Visible = false;
            ChangeToNotMute.Visible = true;
            latestVolume = soundControl.Value;
            defaultPlaybackDevice.Volume = 0;
            soundControl.Value = 0;

        }

        private void btMute_Click(object sender, EventArgs e)
        {

            btChangeToMute.Visible = true;
            ChangeToNotMute.Visible = false;
            defaultPlaybackDevice.Volume = latestVolume;
            soundControl.Value = latestVolume;
        }

        private void timerSong_Tick(object sender, EventArgs e)
        {
            TimeSpan time = TimeSpan.FromSeconds(progressBarSongTime.Value);
            string str = time.ToString(@"hh\:mm\:ss");

            progressBarSongTime.Increment(1);
            countTime = progressBarSongTime.Value;
            lbTimeIncre.Text = str;
            if (repeatOne)
            {
                if (countTime == listSongs_Main[songIndex].Time)
                {
                    player.Dispose();
                    progressBarSongTime.Value = 0;
                    Mp3FileReader mp3Reader = new Mp3FileReader(SONG_PATH + listSongs_Main[songIndex].LinkOpen);
                    player.Init(mp3Reader);
                    player.Play();
                    loadSongDetails();
                }
            }
            else if (repeatRandom)
            {
                if (countTime == listSongs_Main[songIndex].Time)
                {
                    int oldIndex = songIndex;
                    Random rnd = new Random();
                    while (oldIndex == songIndex)
                    {
                        songIndex = rnd.Next(0, listSongs_Main.Count);
                    }
                    Console.WriteLine("song Index: " + songIndex);
                    player.Dispose();
                    progressBarSongTime.Value = 0;
                    Mp3FileReader mp3Reader = new Mp3FileReader(SONG_PATH + listSongs_Main[songIndex].LinkOpen);
                    loadSongDetails();
                    player.Init(mp3Reader);
                    player.Play();
                }
            }
            else
            {
                if (countTime == listSongs_Main[songIndex].Time)
                {
                    progressBarSongTime.Value = 0;
                    btNext_Click(sender, e);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadSongLabel();
        }

        private void btAddNewPlaylist_Click(object sender, EventArgs e)
        {
            string playlistName = txtNewPlaylist.Text;
            string dateCreatePlaylist = DateTime.Now.ToString("yyyy-MM-dd");
            string image = "playlist.jpg";
            if (playlistDAO.addPlaylist(username, playlistName, dateCreatePlaylist, image))
            {
                listPlaylist = playlistDAO.GetPlaylistsOfUser(username);
                loadSmallPlaylist();
            }
        }

        private void btFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("firefox", "https://www.facebook.com/nguyenhuythuc1502");

        }

        private void btTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("firefox", "https://www.twitter.com/astralisgg");
        }

        private void btInsta_Click(object sender, EventArgs e)
        {

            Process.Start("firefox", "https://www.instagram.com/h.thuc2051/");
        }

        private void progressBarSongTime_MouseClick(object sender, MouseEventArgs e)
        {
            player.Dispose();
            int MousePosition = e.X;
            Mp3FileReader mp3Reader = new Mp3FileReader(SONG_PATH + listSongs_Main[songIndex].LinkOpen);
            int newTime = (MousePosition * listSongs_Main[songIndex].Time) / 300;
            mp3Reader.CurrentTime = TimeSpan.FromSeconds(newTime);
            progressBarSongTime.Maximum = listSongs_Main[songIndex].Time;
            try
            {
                progressBarSongTime.Value = newTime;
            }
            catch
            {
                progressBarSongTime.Value = listSongs_Main[songIndex].Time - 2;
            }
            countTime = newTime;
            player.Init(mp3Reader);
            player.Play();
        }

        private void soundControl_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(soundControl.Value);
            if (soundControl.Value == 0)
            {
                btChangeToMute.Visible = false;
                ChangeToNotMute.Visible = true;
            }
            else
            {
                btChangeToMute.Visible = true;
                ChangeToNotMute.Visible = false;
            }

        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("aa");
        }

        private void repeatRandom_Click(object sender, EventArgs e)
        {
            repeatRandom = true;
            btDisableRepeatRandom.Visible = true;
            btrepeatRandom.Visible = false;
        }

        private void repeatOne_Click(object sender, EventArgs e)
        {
            repeatOne = true;
            btrepeatOne.Visible = false;
            btDisableRepeatOne.Visible = true;
        }

        private void btDisableRepeatRandom_Click(object sender, EventArgs e)
        {
            repeatRandom = false;
            btDisableRepeatRandom.Visible = false;
            btrepeatRandom.Visible = true;
        }

        private void btDisableRepeatOne_Click(object sender, EventArgs e)
        {
            repeatOne = false;
            btrepeatOne.Visible = true;
            btDisableRepeatOne.Visible = false;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            Move_Form(Handle, e);
        }

        public static void Move_Form(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }

}

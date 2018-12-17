using Music.thucnh.dtos;
using Music.thucnh.models;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class AdminForm : Form
    {
        List<SongDTO> listSong_Main;
        List<ArtistDTO> listArtist;
        List<AlbumDTO> listAlbum;
        private SongDAO songDAO = new SongDAO();
        private AlbumDAO albumDAO = new AlbumDAO();
        private ArtistDAO artistDAO = new ArtistDAO();
        private string SONG_PATH = "";
        private string SONG_IMAGE_PATH = "";
        private Boolean addNew = false;
        Image imageFile;
        public AdminForm()
        {
            
            InitializeComponent();
            timeDateRealease.Format = DateTimePickerFormat.Custom;
            timeDateRealease.CustomFormat = "yyyy-MM-dd";
            listSong_Main = songDAO.loadAllSongs();
            listArtist = artistDAO.getAllArtists();
            listAlbum = albumDAO.getAllAlbums();
            loadCbb();
            string fol_Dir = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            string[] tokens = fol_Dir.Split(new[] { "\\Music" }, StringSplitOptions.None);
            SONG_IMAGE_PATH = tokens[0] + "\\Music\\SongImageFol\\";
            SONG_PATH = tokens[0] + "\\Music\\MusicFol\\";
            btBrowse.Enabled = false;
            foreach (DataGridViewColumn column in songsDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        public void loadCbb()
        {
            for (int i = 0; i < listArtist.Count; i++)
            {
                cbbArtist.Items.Add(listArtist[i].Name);
            }
            for (int i = 0; i < listAlbum.Count; i++)
            {
                cbbAlbum.Items.Add(listAlbum[i].Name);
            }
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void songsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.songsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.musicPlayerDataSet);

        }
        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicPlayerDataSet.Artists' table. You can move, or remove it, as needed.
            this.artistsTableAdapter.Fill(this.musicPlayerDataSet.Artists);
            // TODO: This line of code loads data into the 'musicPlayerDataSet.Albums' table. You can move, or remove it, as needed.
            this.albumsTableAdapter.Fill(this.musicPlayerDataSet.Albums);
            // TODO: This line of code loads data into the 'musicPlayerDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.musicPlayerDataSet.Users);
            // TODO: This line of code loads data into the 'musicPlayerDataSet.Songs' table. You can move, or remove it, as needed.
            this.songsTableAdapter.Fill(this.musicPlayerDataSet.Songs);
            SidePanel.Height = btSong.Height;
            SidePanel.Top = btSong.Top;
           
        }

        private void btSong_Click(object sender, EventArgs e)
        {

        }

        private void btAlbum_Click(object sender, EventArgs e)
        {
            AdminAlbumForm adminAlbumForm = new AdminAlbumForm();
            this.Controls.Clear();
            adminAlbumForm.TopLevel = false;
            this.Controls.Add(adminAlbumForm);
            adminAlbumForm.Show();
        }

        private void btArtist_Click(object sender, EventArgs e)
        {
            
            AdminArtistForm form = new AdminArtistForm();
            this.Controls.Clear();
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Show();
        }

        private void btLyric_Click(object sender, EventArgs e)
        {
            AdminUserForm form = new AdminUserForm();
            this.Controls.Clear();
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Show();
        }

        private void btPlaylist_Click(object sender, EventArgs e)
        {
            AdminPlaylistForm form = new AdminPlaylistForm();
            this.Controls.Clear();
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Show();
        }

        private void btExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            addNew = true;
            txtID.ReadOnly = false;
            btDelete.Enabled = false;
            btBrowse.Enabled = false;
            cbbAlbum.SelectedIndex = 1;
            cbbArtist.SelectedIndex = 1;
            txtID.Text = "";
            txtDownloadLink.Text = "";
            txtTitle.Text = "";
            txtLyrics.Text = "";
            btUpdate.Text = "Insert";
            imgSong.Image = Image.FromFile(SONG_IMAGE_PATH + "defaultSong.jpg");
            MessageBox.Show("Input new song's details and then click 'Insert' to browse the path");
        }

        private void songsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.Filter = "JPG(*.JPG)|*.jpg";

                if (f.ShowDialog() == DialogResult.OK)
                {
                    imageFile = Image.FromFile(f.FileName);
                    imgSong.Image = imageFile;
                    var imageName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
                    string FilePath = SONG_IMAGE_PATH + "\\" + imageName ;
                    imgSong.Image.Save(FilePath, ImageFormat.Jpeg);
                    int index = songsDataGridView.CurrentCell.RowIndex;
                    
                    songDAO.updateImg(imageName,listSong_Main[index].ID);
                } 
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            refreshUI();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (addNew)
            {
                
                if (checkValidate())
                {
                    int totalTime = 0;
                    var linkOpen = "";
                    Boolean uploadSuccess = false;
                    try
                    {
                        OpenFileDialog f = new OpenFileDialog();
                        f.Filter = "mp3(*.mp3)|*.mp3";
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            Mp3FileReader reader = new Mp3FileReader(f.FileName);
                            TimeSpan duration = reader.TotalTime;
                            totalTime = (int)Math.Round(duration.TotalSeconds);
                            linkOpen = DateTime.Now.ToString("yyyyMMddHHmmss") + ".mp3";
                            string FilePath = SONG_PATH + linkOpen ;
                            Console.WriteLine(FilePath);
                            File.Copy(f.FileName, FilePath);
                            uploadSuccess = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                    }
                    if (uploadSuccess)
                    {
                        string id = txtID.Text;
                        string downLoadLink = txtDownloadLink.Text;
                        string date = timeDateRealease.Value.ToString("yyyy-MM-dd");
                        string title = txtTitle.Text;
                        string lyrics = txtLyrics.Text;
                        string image = "defaultSong.jpg";
                        int artisSelected = cbbArtist.SelectedIndex;
                        int alBumSelected = cbbAlbum.SelectedIndex;
                        ArtistDTO artistDTO = listArtist[artisSelected];
                        AlbumDTO albumDTO = listAlbum[alBumSelected];
                        SongDTO songDTO = new SongDTO(int.Parse(id), title, lyrics, date, linkOpen, downLoadLink, artistDTO, albumDTO,image);
                        
                        if (songDAO.addSong(songDTO, totalTime)){
                            if (songDAO.addSongArtistAndAlbum(songDTO))
                            {
                                MessageBox.Show("Add new successfully");
                            }
                            else
                            {
                                songDAO.deleteSong(songDTO.ID);
                                MessageBox.Show("Occur problem ! Please try again !");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Add new failed");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Occur problem with the file ! Please try again !");
                    }
                   
                }
            }
            else
            {
                string id = txtID.Text;
                string downLoadLink = txtDownloadLink.Text;
                string date = timeDateRealease.Value.ToString("yyyy-MM-dd");
                string title = txtTitle.Text;
                string lyrics = txtLyrics.Text;
                int artisSelected = cbbArtist.SelectedIndex;
                int alBumSelected = cbbAlbum.SelectedIndex;
                ArtistDTO artistDTO = listArtist[artisSelected];
                AlbumDTO albumDTO = listAlbum[alBumSelected];
                SongDTO songDTO = new SongDTO(int.Parse(id), title, lyrics, date, downLoadLink, artistDTO, albumDTO);
                if (songDAO.updateSongs(songDTO))
                {
                    if (songDAO.updateSongAlbumArtist(songDTO))
                    {
                        MessageBox.Show("Update successfully");
                    }
                    else
                    {
                        songDAO.deleteSong(songDTO.ID);
                        MessageBox.Show("Occur problem ! Please try again !");
                    }
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
            }
            refreshUI();

        }
        public void refreshUI()
        {
            AdminForm form = new AdminForm();
            this.Controls.Clear();
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Show();
        }
        private void songsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            addNew = false;
            btDelete.Enabled = true;
            btBrowse.Enabled = true;
            txtID.ReadOnly = true;
            btUpdate.Text = "Update";
            int rowindex = songsDataGridView.CurrentCell.RowIndex;
            int columnindex = songsDataGridView.CurrentCell.ColumnIndex;

            int id = int.Parse(songsDataGridView.Rows[rowindex].Cells[0].Value.ToString());
            for (int i = 0; i < listSong_Main.Count; i++)
            {
                if (listSong_Main[i].ID == id)
                {
                    cbbArtist.SelectedIndex = cbbArtist.FindStringExact(listSong_Main[i].Artis.Name);
                    cbbAlbum.SelectedIndex = cbbAlbum.FindStringExact(listSong_Main[i].Album.Name);
                    imgSong.Image = Image.FromFile(SONG_IMAGE_PATH + listSong_Main[i].Image);
                }
            }
        }
        public Boolean checkValidate()
        {
            string id = txtID.Text;
            if (id.Length == 0)
            {
                MessageBox.Show("ID không được rỗng");
                return false;
            }
           
            return true;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int index = songsDataGridView.CurrentCell.RowIndex;
            songDAO.deleteSongAlbumArtisBySongID(listSong_Main[index].ID);
            songDAO.deleteSongPlayListBySongID(listSong_Main[index].ID);
            if (songDAO.deleteSong(listSong_Main[index].ID))
            {
                MessageBox.Show("Delete successfully !");
            }
            else
            {
                MessageBox.Show("Delete failed !");
            }
            refreshUI();
        }
    }
}

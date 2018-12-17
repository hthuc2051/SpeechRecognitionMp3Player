using Music.thucnh.dtos;
using Music.thucnh.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class AdminPlaylistForm : Form
    {


        List<PlaylistDTO> listPlayList;
        private PlaylistDAO playlistDAO = new PlaylistDAO();

        private string PLAYLIST_IMAGE_PATH = "";

        public AdminPlaylistForm()
        {
            InitializeComponent();
            listPlayList = playlistDAO.GetAllPlayList();
            string fol_Dir = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            string[] tokens = fol_Dir.Split(new[] { "\\Music" }, StringSplitOptions.None);
            PLAYLIST_IMAGE_PATH = tokens[0] + "\\Music\\PlaylistImageFol\\";
            foreach (DataGridViewColumn column in playlistDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        private void AdminPlaylistForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicPlayerDataSet.Playlists' table. You can move, or remove it, as needed.
            this.playlistsTableAdapter.Fill(this.musicPlayerDataSet.Playlists);
            SidePanel.Height = btPlaylist.Height;
            SidePanel.Top = btPlaylist.Top;

        }

        private void btSong_Click(object sender, EventArgs e)
        {
            AdminForm songFormm = new AdminForm();
            this.Controls.Clear();
            songFormm.TopLevel = false;
            this.Controls.Add(songFormm);
            songFormm.Show();
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

        private void btUser_Click(object sender, EventArgs e)
        {
            AdminUserForm form = new AdminUserForm();
            this.Controls.Clear();
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Show();
        }

      

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void txtDateCreate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtPlaylistName.Text;
            string date = timeDateCreate.Value.ToString("yyyy-MM-dd");
            if(playlistDAO.updatePlaylist(int.Parse(id), name, date))
            {
                MessageBox.Show("Update successfully");
            }
            else
            {
                MessageBox.Show("Update failed");
            }
            refreshUI();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int index = playlistDataGridView.CurrentCell.RowIndex;
            if (playlistDAO.deleteSong_PlaylistByPlayListID(listPlayList[index].Id))
            {
                if (playlistDAO.deletePlaylist(listPlayList[index].Id))
                {
                    MessageBox.Show("Delete successfully !");
                }
                else
                {
                    MessageBox.Show("Delete failed !");
                }
            }
            else
            {
                MessageBox.Show("Delete failed !");
            }

            refreshUI();
        }
        public void refreshUI()
        {
            AdminPlaylistForm form = new AdminPlaylistForm();
            this.Controls.Clear();
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Show();
        }

        private void playlistDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.ReadOnly = true;
        }
    }
}

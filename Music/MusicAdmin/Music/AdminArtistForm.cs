using Music.thucnh.dtos;
using Music.thucnh.models;
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
    public partial class AdminArtistForm : Form
    {

        List<ArtistDTO> listArtist;
        private ArtistDAO artistDAO = new ArtistDAO();

        private string ARTIST_IMAGE_PATH = "";
        private Boolean addNew = false;
        Image imageFile;

        public AdminArtistForm()
        {
            InitializeComponent();

            listArtist = artistDAO.getAllArtists();
            string fol_Dir = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            string[] tokens = fol_Dir.Split(new[] { "\\Music" }, StringSplitOptions.None);
            ARTIST_IMAGE_PATH = tokens[0] + "\\Music\\ArtisImageFol\\";
            btBrowse.Enabled = false;
            foreach (DataGridViewColumn column in artistsDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        private void AdminArtistForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicPlayerDataSet.Artists' table. You can move, or remove it, as needed.
            this.artistsTableAdapter.Fill(this.musicPlayerDataSet.Artists);
            // TODO: This line of code loads data into the 'musicPlayerDataSet.Artists' table. You can move, or remove it, as needed.
            this.artistsTableAdapter.Fill(this.musicPlayerDataSet.Artists);
            SidePanel.Height = btArtist.Height;
            SidePanel.Top = btArtist.Top;
        }

        private void artistsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

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

        }

        private void btUser_Click(object sender, EventArgs e)
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

        public void refreshUI()
        {
            AdminArtistForm form = new AdminArtistForm();
            this.Controls.Clear();
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            addNew = true;
            btDelete.Enabled = false;
            btBrowse.Enabled = false;
            imgAlbum.Image = Image.FromFile(ARTIST_IMAGE_PATH + "defaultArtistIMG.jpg");
            txtID.Text = "";
            txtName.Text = "";
            txtLabel.Text = "";
            btUpdate.Text = "Insert";
            MessageBox.Show("Let's input artist details");
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

            string id = txtID.Text;
            string name = txtName.Text;
            string label = txtLabel.Text;
            if (addNew)
            {
                if (checkValidate())
                {

                    ArtistDTO albumDTO = new ArtistDTO(int.Parse(id), name,label, "defaultArtistIMG.jpg");
                    if (artistDAO.addArtist(albumDTO))
                    {
                        MessageBox.Show("Add new successfully");
                    }
                    else
                    {
                        MessageBox.Show("Add new failed");
                    }
                }
            }
            else
            {
                ArtistDTO albumDTO = new ArtistDTO(int.Parse(id), name, label, "defaultArtistIMG.jpg");
                if (artistDAO.updateArtist(albumDTO))
                {
                    MessageBox.Show("Update successfully");
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
            }
            refreshUI();
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
            int index = artistsDataGridView.CurrentCell.RowIndex;
            artistDAO.deleteSongAlbumArtisByArtistID(listArtist[index].Id);
            
                if (artistDAO.deleteArtist(listArtist[index].Id))
                {
                    MessageBox.Show("Delete successfully !");
                }
                else
                {
                    MessageBox.Show("Delete failed !");
                }
            
            
            refreshUI();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.Filter = "JPG(*.JPG)|*.jpg";

                if (f.ShowDialog() == DialogResult.OK)
                {
                    imageFile = Image.FromFile(f.FileName);
                    imgAlbum.Image = imageFile;
                    var imageName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
                    string FilePath = ARTIST_IMAGE_PATH + "\\" + imageName;
                    imgAlbum.Image.Save(FilePath, ImageFormat.Jpeg);
                    int index = artistsDataGridView.CurrentCell.RowIndex;

                    artistDAO.updateImg(imageName, listArtist[index].Id);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            refreshUI();
        }

        private void artistsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            addNew = false;
            btDelete.Enabled = true;
            btBrowse.Enabled = true;
            txtID.ReadOnly = true;
            btUpdate.Text = "Update";
            int rowindex = artistsDataGridView.CurrentCell.RowIndex;
            int columnindex = artistsDataGridView.CurrentCell.ColumnIndex;

            int id = int.Parse(artistsDataGridView.Rows[rowindex].Cells[0].Value.ToString());
            for (int i = 0; i < listArtist.Count; i++)
            {
                if (listArtist[i].Id == id)
                {
                    imgAlbum.Image = Image.FromFile(ARTIST_IMAGE_PATH + listArtist[i].Image);
                }
            }
        }
    }
}

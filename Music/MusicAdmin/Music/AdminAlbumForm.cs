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
    public partial class AdminAlbumForm : Form
    {
        List<AlbumDTO> listAlbum;
        private AlbumDAO albumDAO = new AlbumDAO();

        private string ALBUM_IMAGE_PATH = "";
        private Boolean addNew = false;
        Image imageFile;
        public AdminAlbumForm()
        {
            InitializeComponent();

            listAlbum = albumDAO.getAllAlbums();
            string fol_Dir = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            string[] tokens = fol_Dir.Split(new[] { "\\Music" }, StringSplitOptions.None);
            ALBUM_IMAGE_PATH = tokens[0] + "\\Music\\AlbumImageFol\\";
            btBrowse.Enabled = false;
            foreach (DataGridViewColumn column in albumDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        private void AdminAlbumForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicPlayerDataSet.Albums' table. You can move, or remove it, as needed.
            this.albumsTableAdapter.Fill(this.musicPlayerDataSet.Albums);

            SidePanel.Height = btAlbum.Height;
            SidePanel.Top = btAlbum.Top;
        }

        private void btSong_Click(object sender, EventArgs e)
        {
            AdminForm adminAlbumForm = new AdminForm();
            this.Controls.Clear();
            adminAlbumForm.TopLevel = false;
            this.Controls.Add(adminAlbumForm);
            adminAlbumForm.Show();
        }

        private void btAlbum_Click(object sender, EventArgs e)
        {

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
            AdminAlbumForm form = new AdminAlbumForm();
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
            imgAlbum.Image = Image.FromFile(ALBUM_IMAGE_PATH + "albumDefault.jpg");
            txtID.Text = "";
            txtAlbumName.Text = "";
            btUpdate.Text = "Insert";
            MessageBox.Show("Let's input the album details");
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
                    string FilePath = ALBUM_IMAGE_PATH + "\\" + imageName;
                    imgAlbum.Image.Save(FilePath, ImageFormat.Jpeg);
                    int index = albumDataGridView.CurrentCell.RowIndex;

                    albumDAO.updateImg(imageName, listAlbum[index].Id);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            refreshUI();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtAlbumName.Text;
            if (addNew)
            {
                if (checkValidate())
                {
                    
                    AlbumDTO albumDTO = new AlbumDTO(int.Parse(id), name, "albumDefault.jpg");
                    if (albumDAO.addAlbum(albumDTO))
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
                AlbumDTO albumDTO = new AlbumDTO(int.Parse(id), name);
                if (albumDAO.updateAlbum(albumDTO))
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

        private void albumDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            addNew = false;
            btDelete.Enabled = true;
            btBrowse.Enabled = true;
            txtID.ReadOnly = true;
            btUpdate.Text = "Update";
            int rowindex = albumDataGridView.CurrentCell.RowIndex;
            int columnindex = albumDataGridView.CurrentCell.ColumnIndex;

            int id = int.Parse(albumDataGridView.Rows[rowindex].Cells[0].Value.ToString());
            for (int i = 0; i < listAlbum.Count; i++)
            {
                if (listAlbum[i].Id == id)
                {
                    imgAlbum.Image = Image.FromFile(ALBUM_IMAGE_PATH + listAlbum[i].Image);
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int index = albumDataGridView.CurrentCell.RowIndex;
            albumDAO.deleteSongAlbumArtisByAlbumID(listAlbum[index].Id);
                if (albumDAO.deleteAlbum(listAlbum[index].Id))
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

using Music.thucnh.dtos;
using Music.thucnh.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class AdminUserForm : Form
    {
        List<UserDTO> listUsers;
        private UserDAO userDAO = new UserDAO();
        private Boolean addNew = false;

        public AdminUserForm()
        {

            InitializeComponent();
            listUsers = userDAO.getAllUsers();

        }

        private void AdminUserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicPlayerDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.musicPlayerDataSet.Users);

            SidePanel.Height = btUser.Height;
            SidePanel.Top = btUser.Top;
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

        }

        private void btPlaylist_Click(object sender, EventArgs e)
        {
            AdminPlaylistForm form = new AdminPlaylistForm();
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
            txtUsername.ReadOnly = false;
            btDelete.Enabled = false;
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtFullName.Text = "";
            btUpdate.Text = "Insert";
            MessageBox.Show("Let's input user details");
        }
        public void refreshUI()
        {
            AdminUserForm form = new AdminUserForm();
            this.Controls.Clear();
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Show();
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = txtRole.Text;
            string fullName = txtFullName.Text;
            string dateOfBirth = timeDOB.Value.ToString("yyyy-MM-dd");
            if (addNew)
            {
                if (checkValidate())
                {
                    if (userDAO.addUser(username, password, fullName, role, dateOfBirth))
                    {
                        MessageBox.Show("Add new successfully");
                        refreshUI();
                    }
                    else
                    {
                        MessageBox.Show("Add new failed");
                    }
                }
            }
            else
            {
               
                if (userDAO.udpateUser(username, password, fullName, role, dateOfBirth))
                {
                    MessageBox.Show("Update successfully");
                    refreshUI();
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
            }
           
        }
        public Boolean checkValidate()
        {
            string id = txtUsername.Text;
            if (id.Length == 0)
            {
                MessageBox.Show("Password can't be blank");
                return false;
            }
            string password = txtPassword.Text;
            if (password.Length == 0)
            {
                MessageBox.Show("Password can't be blank");
                return false;
            }
            string role = txtRole.Text;
            if (role.Length == 0)
            {
                MessageBox.Show("Role can't be blank");
                return false;
            }

            return true;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int index = userDataGridView.CurrentCell.RowIndex;
            userDAO.deleteSong_PlaylistByUsername(listUsers[index].Username);
            userDAO.deletePlaylistOfUser(listUsers[index].Username);
            if (userDAO.deleteUser(listUsers[index].Username))
            {
                MessageBox.Show("Delete successfully !");
            }
            else
            {
                MessageBox.Show("Delete failed !");
            }
            refreshUI();
        }

        private void userDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            addNew = false;
            btDelete.Enabled = true;
            txtUsername.ReadOnly = true;
            btUpdate.Text = "Update";
        }
    }
}

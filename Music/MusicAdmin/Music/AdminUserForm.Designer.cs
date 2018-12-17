namespace Music
{
    partial class AdminUserForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUserForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iDLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.dateReleaseLabel = new System.Windows.Forms.Label();
            this.linkOpenLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSong = new System.Windows.Forms.Button();
            this.btPlaylist = new System.Windows.Forms.Button();
            this.btAlbum = new System.Windows.Forms.Button();
            this.btUser = new System.Windows.Forms.Button();
            this.btArtist = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.musicPlayerDataSet = new Music.MusicPlayerDataSet();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.linkDownLoadTextBox = new System.Windows.Forms.TextBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usersTableAdapter = new Music.MusicPlayerDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager1 = new Music.MusicPlayerDataSetTableAdapters.TableAdapterManager();
            this.lyricsLabel = new System.Windows.Forms.Label();
            this.timeDOB = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            this.iDLabel.AutoSize = true;
            this.iDLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDLabel.Location = new System.Drawing.Point(245, 77);
            this.iDLabel.Name = "iDLabel";
            this.iDLabel.Size = new System.Drawing.Size(82, 18);
            this.iDLabel.TabIndex = 18;
            this.iDLabel.Text = "Username";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(245, 111);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(79, 18);
            this.titleLabel.TabIndex = 20;
            this.titleLabel.Text = "Full name";
            // 
            // dateReleaseLabel
            // 
            this.dateReleaseLabel.AutoSize = true;
            this.dateReleaseLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReleaseLabel.Location = new System.Drawing.Point(570, 77);
            this.dateReleaseLabel.Name = "dateReleaseLabel";
            this.dateReleaseLabel.Size = new System.Drawing.Size(97, 18);
            this.dateReleaseLabel.TabIndex = 24;
            this.dateReleaseLabel.Text = "Date of birth";
            // 
            // linkOpenLabel
            // 
            this.linkOpenLabel.AutoSize = true;
            this.linkOpenLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkOpenLabel.Location = new System.Drawing.Point(570, 111);
            this.linkOpenLabel.Name = "linkOpenLabel";
            this.linkOpenLabel.Size = new System.Drawing.Size(41, 18);
            this.linkOpenLabel.TabIndex = 26;
            this.linkOpenLabel.Text = "Role";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btSong);
            this.panel1.Controls.Add(this.btPlaylist);
            this.panel1.Controls.Add(this.btAlbum);
            this.panel1.Controls.Add(this.btUser);
            this.panel1.Controls.Add(this.btArtist);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 575);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // btSong
            // 
            this.btSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSong.FlatAppearance.BorderSize = 0;
            this.btSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSong.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSong.ForeColor = System.Drawing.Color.White;
            this.btSong.Image = ((System.Drawing.Image)(resources.GetObject("btSong.Image")));
            this.btSong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSong.Location = new System.Drawing.Point(20, 54);
            this.btSong.Name = "btSong";
            this.btSong.Size = new System.Drawing.Size(174, 55);
            this.btSong.TabIndex = 29;
            this.btSong.Text = "          Songs";
            this.btSong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSong.UseVisualStyleBackColor = true;
            this.btSong.Click += new System.EventHandler(this.btSong_Click);
            // 
            // btPlaylist
            // 
            this.btPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPlaylist.FlatAppearance.BorderSize = 0;
            this.btPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlaylist.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlaylist.ForeColor = System.Drawing.Color.White;
            this.btPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btPlaylist.Image")));
            this.btPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPlaylist.Location = new System.Drawing.Point(21, 251);
            this.btPlaylist.Name = "btPlaylist";
            this.btPlaylist.Size = new System.Drawing.Size(174, 55);
            this.btPlaylist.TabIndex = 28;
            this.btPlaylist.Text = "        Playlists";
            this.btPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPlaylist.UseVisualStyleBackColor = true;
            this.btPlaylist.Click += new System.EventHandler(this.btPlaylist_Click);
            // 
            // btAlbum
            // 
            this.btAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAlbum.FlatAppearance.BorderSize = 0;
            this.btAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlbum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlbum.ForeColor = System.Drawing.Color.White;
            this.btAlbum.Image = ((System.Drawing.Image)(resources.GetObject("btAlbum.Image")));
            this.btAlbum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlbum.Location = new System.Drawing.Point(21, 105);
            this.btAlbum.Name = "btAlbum";
            this.btAlbum.Size = new System.Drawing.Size(174, 55);
            this.btAlbum.TabIndex = 25;
            this.btAlbum.Text = "        Albums";
            this.btAlbum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAlbum.UseVisualStyleBackColor = true;
            this.btAlbum.Click += new System.EventHandler(this.btAlbum_Click);
            // 
            // btUser
            // 
            this.btUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUser.FlatAppearance.BorderSize = 0;
            this.btUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUser.ForeColor = System.Drawing.Color.White;
            this.btUser.Image = ((System.Drawing.Image)(resources.GetObject("btUser.Image")));
            this.btUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUser.Location = new System.Drawing.Point(20, 201);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(174, 55);
            this.btUser.TabIndex = 27;
            this.btUser.Text = "          Users";
            this.btUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUser.UseVisualStyleBackColor = true;
            this.btUser.Click += new System.EventHandler(this.btUser_Click);
            // 
            // btArtist
            // 
            this.btArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btArtist.FlatAppearance.BorderSize = 0;
            this.btArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btArtist.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btArtist.ForeColor = System.Drawing.Color.White;
            this.btArtist.Image = ((System.Drawing.Image)(resources.GetObject("btArtist.Image")));
            this.btArtist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btArtist.Location = new System.Drawing.Point(21, 153);
            this.btArtist.Name = "btArtist";
            this.btArtist.Size = new System.Drawing.Size(174, 55);
            this.btArtist.TabIndex = 26;
            this.btArtist.Text = "         Artists";
            this.btArtist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btArtist.UseVisualStyleBackColor = true;
            this.btArtist.Click += new System.EventHandler(this.btArtist_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Green;
            this.SidePanel.Location = new System.Drawing.Point(3, 54);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(8, 55);
            this.SidePanel.TabIndex = 18;
            // 
            // musicPlayerDataSet
            // 
            this.musicPlayerDataSet.DataSetName = "MusicPlayerDataSet";
            this.musicPlayerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.userDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userDataGridView.AutoGenerateColumns = false;
            this.userDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.userDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.userDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userDataGridView.ColumnHeadersHeight = 30;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn});
            this.userDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.userDataGridView.DataSource = this.usersBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.userDataGridView.EnableHeadersVisualStyles = false;
            this.userDataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.userDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userDataGridView.Location = new System.Drawing.Point(200, 282);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowHeadersVisible = false;
            this.userDataGridView.RowHeadersWidth = 110;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.userDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.userDataGridView.RowTemplate.Height = 36;
            this.userDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userDataGridView.Size = new System.Drawing.Size(834, 273);
            this.userDataGridView.TabIndex = 18;
            this.userDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.userDataGridView_CellMouseClick);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 235;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 120;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 230;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.musicPlayerDataSet;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Username", true));
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(328, 78);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(7, 12, 7, 7);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(175, 23);
            this.txtUsername.TabIndex = 19;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "FullName", true));
            this.txtFullName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.White;
            this.txtFullName.Location = new System.Drawing.Point(328, 112);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(7);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(175, 23);
            this.txtFullName.TabIndex = 21;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(328, 145);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(7);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(175, 23);
            this.txtPassword.TabIndex = 23;
            // 
            // txtRole
            // 
            this.txtRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.txtRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRole.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Role", true));
            this.txtRole.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.ForeColor = System.Drawing.Color.White;
            this.txtRole.Location = new System.Drawing.Point(677, 111);
            this.txtRole.Margin = new System.Windows.Forms.Padding(7);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(254, 23);
            this.txtRole.TabIndex = 27;
            // 
            // linkDownLoadTextBox
            // 
            this.linkDownLoadTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.linkDownLoadTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.linkDownLoadTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDownLoadTextBox.ForeColor = System.Drawing.Color.White;
            this.linkDownLoadTextBox.Location = new System.Drawing.Point(722, 145);
            this.linkDownLoadTextBox.Margin = new System.Windows.Forms.Padding(7);
            this.linkDownLoadTextBox.Name = "linkDownLoadTextBox";
            this.linkDownLoadTextBox.Size = new System.Drawing.Size(254, 16);
            this.linkDownLoadTextBox.TabIndex = 29;
            // 
            // imageTextBox
            // 
            this.imageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.imageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imageTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageTextBox.ForeColor = System.Drawing.Color.White;
            this.imageTextBox.Location = new System.Drawing.Point(722, 178);
            this.imageTextBox.Margin = new System.Windows.Forms.Padding(7);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(254, 16);
            this.imageTextBox.TabIndex = 31;
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAdd.Location = new System.Drawing.Point(257, 229);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(73, 36);
            this.btAdd.TabIndex = 32;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btUpdate.Location = new System.Drawing.Point(362, 229);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(73, 36);
            this.btUpdate.TabIndex = 33;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btDelete.Location = new System.Drawing.Point(468, 229);
            this.btDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(73, 36);
            this.btDelete.TabIndex = 34;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel2.Controls.Add(this.btExit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 53);
            this.panel2.TabIndex = 35;
            // 
            // btExit
            // 
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Image = ((System.Drawing.Image)(resources.GetObject("btExit.Image")));
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExit.Location = new System.Drawing.Point(790, 11);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(32, 35);
            this.btExit.TabIndex = 8;
            this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sasha Administrator";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AlbumsTableAdapter = null;
            this.tableAdapterManager1.ArtistsTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Playlist_SongsTableAdapter = null;
            this.tableAdapterManager1.PlaylistsTableAdapter = null;
            this.tableAdapterManager1.Song_Album_ArtistTableAdapter = null;
            this.tableAdapterManager1.SongsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Music.MusicPlayerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = this.usersTableAdapter;
            // 
            // lyricsLabel
            // 
            this.lyricsLabel.AutoSize = true;
            this.lyricsLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lyricsLabel.Location = new System.Drawing.Point(245, 142);
            this.lyricsLabel.Name = "lyricsLabel";
            this.lyricsLabel.Size = new System.Drawing.Size(75, 18);
            this.lyricsLabel.TabIndex = 22;
            this.lyricsLabel.Text = "Password";
            // 
            // timeDOB
            // 
            this.timeDOB.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usersBindingSource, "DateOfBirth", true));
            this.timeDOB.Location = new System.Drawing.Point(677, 78);
            this.timeDOB.Name = "timeDOB";
            this.timeDOB.Size = new System.Drawing.Size(229, 20);
            this.timeDOB.TabIndex = 36;
            // 
            // AdminUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1069, 575);
            this.Controls.Add(this.timeDOB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.iDLabel);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lyricsLabel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.dateReleaseLabel);
            this.Controls.Add(this.linkOpenLabel);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.linkDownLoadTextBox);
            this.Controls.Add(this.imageTextBox);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.AdminUserForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private MusicPlayerDataSet musicPlayerDataSet;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox linkDownLoadTextBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label iDLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label dateReleaseLabel;
        private System.Windows.Forms.Label linkOpenLabel;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private MusicPlayerDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private MusicPlayerDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label lyricsLabel;
        private System.Windows.Forms.Button btSong;
        private System.Windows.Forms.Button btPlaylist;
        private System.Windows.Forms.Button btAlbum;
        private System.Windows.Forms.Button btUser;
        private System.Windows.Forms.Button btArtist;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DateTimePicker timeDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
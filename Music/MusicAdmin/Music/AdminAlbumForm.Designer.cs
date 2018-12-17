namespace Music
{
    partial class AdminAlbumForm
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
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAlbumForm));
            this.iDLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSong = new System.Windows.Forms.Button();
            this.btPlaylist = new System.Windows.Forms.Button();
            this.btAlbum = new System.Windows.Forms.Button();
            this.btUser = new System.Windows.Forms.Button();
            this.btArtist = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.musicPlayerDataSet = new Music.MusicPlayerDataSet();
            this.albumDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtID = new System.Windows.Forms.TextBox();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.lyricsTextBox = new System.Windows.Forms.TextBox();
            this.dateReleaseTextBox = new System.Windows.Forms.TextBox();
            this.linkOpenTextBox = new System.Windows.Forms.TextBox();
            this.linkDownLoadTextBox = new System.Windows.Forms.TextBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.albumsTableAdapter = new Music.MusicPlayerDataSetTableAdapters.AlbumsTableAdapter();
            this.imgAlbum = new System.Windows.Forms.PictureBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            imageLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imageLabel.Location = new System.Drawing.Point(572, 77);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(56, 18);
            imageLabel.TabIndex = 40;
            imageLabel.Text = "Image";
            // 
            // iDLabel
            // 
            this.iDLabel.AutoSize = true;
            this.iDLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDLabel.Location = new System.Drawing.Point(252, 77);
            this.iDLabel.Name = "iDLabel";
            this.iDLabel.Size = new System.Drawing.Size(23, 18);
            this.iDLabel.TabIndex = 18;
            this.iDLabel.Text = "ID";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(252, 111);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(103, 18);
            this.titleLabel.TabIndex = 20;
            this.titleLabel.Text = "Album name";
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
            this.panel1.Size = new System.Drawing.Size(200, 567);
            this.panel1.TabIndex = 17;
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
            this.btSong.Location = new System.Drawing.Point(23, 54);
            this.btSong.Name = "btSong";
            this.btSong.Size = new System.Drawing.Size(174, 55);
            this.btSong.TabIndex = 24;
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
            this.btPlaylist.Location = new System.Drawing.Point(24, 251);
            this.btPlaylist.Name = "btPlaylist";
            this.btPlaylist.Size = new System.Drawing.Size(174, 55);
            this.btPlaylist.TabIndex = 23;
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
            this.btAlbum.Location = new System.Drawing.Point(24, 105);
            this.btAlbum.Name = "btAlbum";
            this.btAlbum.Size = new System.Drawing.Size(174, 55);
            this.btAlbum.TabIndex = 20;
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
            this.btUser.Location = new System.Drawing.Point(23, 201);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(174, 55);
            this.btUser.TabIndex = 22;
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
            this.btArtist.Location = new System.Drawing.Point(24, 153);
            this.btArtist.Name = "btArtist";
            this.btArtist.Size = new System.Drawing.Size(174, 55);
            this.btArtist.TabIndex = 21;
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
            // albumDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.albumDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.albumDataGridView.AutoGenerateColumns = false;
            this.albumDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.albumDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.albumDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.albumDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.albumDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.albumDataGridView.ColumnHeadersHeight = 30;
            this.albumDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.albumDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.albumDataGridView.DataSource = this.albumsBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.albumDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.albumDataGridView.EnableHeadersVisualStyles = false;
            this.albumDataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.albumDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.albumDataGridView.Location = new System.Drawing.Point(200, 282);
            this.albumDataGridView.Name = "albumDataGridView";
            this.albumDataGridView.RowHeadersVisible = false;
            this.albumDataGridView.RowHeadersWidth = 110;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.albumDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.albumDataGridView.RowTemplate.Height = 36;
            this.albumDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.albumDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.albumDataGridView.Size = new System.Drawing.Size(834, 273);
            this.albumDataGridView.TabIndex = 18;
            this.albumDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.albumDataGridView_CellMouseClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 300;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Album\'s name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 540;
            // 
            // albumsBindingSource1
            // 
            this.albumsBindingSource1.DataMember = "Albums";
            this.albumsBindingSource1.DataSource = this.musicPlayerDataSet;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource1, "ID", true));
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(362, 77);
            this.txtID.Margin = new System.Windows.Forms.Padding(7, 12, 7, 7);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(175, 23);
            this.txtID.TabIndex = 19;
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.musicPlayerDataSet;
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.txtAlbumName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlbumName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource1, "name", true));
            this.txtAlbumName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlbumName.ForeColor = System.Drawing.Color.White;
            this.txtAlbumName.Location = new System.Drawing.Point(362, 111);
            this.txtAlbumName.Margin = new System.Windows.Forms.Padding(7);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(175, 23);
            this.txtAlbumName.TabIndex = 21;
            // 
            // lyricsTextBox
            // 
            this.lyricsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.lyricsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lyricsTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lyricsTextBox.ForeColor = System.Drawing.Color.White;
            this.lyricsTextBox.Location = new System.Drawing.Point(328, 145);
            this.lyricsTextBox.Margin = new System.Windows.Forms.Padding(7);
            this.lyricsTextBox.Name = "lyricsTextBox";
            this.lyricsTextBox.Size = new System.Drawing.Size(175, 16);
            this.lyricsTextBox.TabIndex = 23;
            // 
            // dateReleaseTextBox
            // 
            this.dateReleaseTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.dateReleaseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateReleaseTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReleaseTextBox.ForeColor = System.Drawing.Color.White;
            this.dateReleaseTextBox.Location = new System.Drawing.Point(722, 77);
            this.dateReleaseTextBox.Margin = new System.Windows.Forms.Padding(7);
            this.dateReleaseTextBox.Name = "dateReleaseTextBox";
            this.dateReleaseTextBox.Size = new System.Drawing.Size(254, 16);
            this.dateReleaseTextBox.TabIndex = 25;
            // 
            // linkOpenTextBox
            // 
            this.linkOpenTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.linkOpenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.linkOpenTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkOpenTextBox.ForeColor = System.Drawing.Color.White;
            this.linkOpenTextBox.Location = new System.Drawing.Point(722, 111);
            this.linkOpenTextBox.Margin = new System.Windows.Forms.Padding(7);
            this.linkOpenTextBox.Name = "linkOpenTextBox";
            this.linkOpenTextBox.Size = new System.Drawing.Size(254, 16);
            this.linkOpenTextBox.TabIndex = 27;
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
            this.panel2.Size = new System.Drawing.Size(834, 53);
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
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // imgAlbum
            // 
            this.imgAlbum.Location = new System.Drawing.Point(659, 77);
            this.imgAlbum.Name = "imgAlbum";
            this.imgAlbum.Size = new System.Drawing.Size(103, 101);
            this.imgAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAlbum.TabIndex = 41;
            this.imgAlbum.TabStop = false;
            // 
            // btBrowse
            // 
            this.btBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBrowse.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBrowse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBrowse.Location = new System.Drawing.Point(781, 111);
            this.btBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(73, 36);
            this.btBrowse.TabIndex = 42;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // AdminAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1034, 567);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.imgAlbum);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.iDLabel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.txtAlbumName);
            this.Controls.Add(this.lyricsTextBox);
            this.Controls.Add(this.dateReleaseTextBox);
            this.Controls.Add(this.linkOpenTextBox);
            this.Controls.Add(this.linkDownLoadTextBox);
            this.Controls.Add(this.imageTextBox);
            this.Controls.Add(this.albumDataGridView);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminAlbumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.AdminAlbumForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private MusicPlayerDataSet musicPlayerDataSet;
        private System.Windows.Forms.DataGridView albumDataGridView;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.TextBox lyricsTextBox;
        private System.Windows.Forms.TextBox dateReleaseTextBox;
        private System.Windows.Forms.TextBox linkOpenTextBox;
        private System.Windows.Forms.TextBox linkDownLoadTextBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label iDLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private MusicPlayerDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.BindingSource albumsBindingSource1;
        private System.Windows.Forms.Button btSong;
        private System.Windows.Forms.Button btPlaylist;
        private System.Windows.Forms.Button btAlbum;
        private System.Windows.Forms.Button btUser;
        private System.Windows.Forms.Button btArtist;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox imgAlbum;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
    }

}
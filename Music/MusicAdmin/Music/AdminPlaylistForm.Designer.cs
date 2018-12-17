namespace Music
{
    partial class AdminPlaylistForm
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
            System.Windows.Forms.Label dateCreateLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPlaylistForm));
            this.iDLabel = new System.Windows.Forms.Label();
            this.lyricsLabel = new System.Windows.Forms.Label();
            this.dateReleaseLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSong = new System.Windows.Forms.Button();
            this.btPlaylist = new System.Windows.Forms.Button();
            this.btAlbum = new System.Windows.Forms.Button();
            this.btUser = new System.Windows.Forms.Button();
            this.btArtist = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.musicPlayerDataSet = new Music.MusicPlayerDataSet();
            this.playlistDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playlistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playlistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicPlayerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPlaylistName = new System.Windows.Forms.TextBox();
            this.linkOpenTextBox = new System.Windows.Forms.TextBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Music.MusicPlayerDataSetTableAdapters.TableAdapterManager();
            this.songsTableAdapter = new Music.MusicPlayerDataSetTableAdapters.SongsTableAdapter();
            this.songsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playlistsTableAdapter = new Music.MusicPlayerDataSetTableAdapters.PlaylistsTableAdapter();
            this.playlistsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timeDateCreate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            dateCreateLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayerDataSetBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateCreateLabel
            // 
            dateCreateLabel.AutoSize = true;
            dateCreateLabel.Location = new System.Drawing.Point(750, 97);
            dateCreateLabel.Name = "dateCreateLabel";
            dateCreateLabel.Size = new System.Drawing.Size(0, 13);
            dateCreateLabel.TabIndex = 35;
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
            // lyricsLabel
            // 
            this.lyricsLabel.AutoSize = true;
            this.lyricsLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lyricsLabel.Location = new System.Drawing.Point(252, 124);
            this.lyricsLabel.Name = "lyricsLabel";
            this.lyricsLabel.Size = new System.Drawing.Size(102, 18);
            this.lyricsLabel.TabIndex = 22;
            this.lyricsLabel.Text = "PlaylistName";
            // 
            // dateReleaseLabel
            // 
            this.dateReleaseLabel.AutoSize = true;
            this.dateReleaseLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReleaseLabel.Location = new System.Drawing.Point(606, 77);
            this.dateReleaseLabel.Name = "dateReleaseLabel";
            this.dateReleaseLabel.Size = new System.Drawing.Size(98, 18);
            this.dateReleaseLabel.TabIndex = 24;
            this.dateReleaseLabel.Text = "Date Create";
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
            // playlistDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.playlistDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.playlistDataGridView.AutoGenerateColumns = false;
            this.playlistDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.playlistDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.playlistDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.playlistDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.playlistDataGridView.ColumnHeadersHeight = 30;
            this.playlistDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.playlistNameDataGridViewTextBoxColumn,
            this.dateCreateDataGridViewTextBoxColumn});
            this.playlistDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.playlistDataGridView.DataSource = this.playlistsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.playlistDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.playlistDataGridView.EnableHeadersVisualStyles = false;
            this.playlistDataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.playlistDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.playlistDataGridView.Location = new System.Drawing.Point(200, 282);
            this.playlistDataGridView.Name = "playlistDataGridView";
            this.playlistDataGridView.RowHeadersVisible = false;
            this.playlistDataGridView.RowHeadersWidth = 110;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.playlistDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.playlistDataGridView.RowTemplate.Height = 36;
            this.playlistDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.playlistDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.playlistDataGridView.Size = new System.Drawing.Size(834, 273);
            this.playlistDataGridView.TabIndex = 18;
            this.playlistDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.playlistDataGridView_CellMouseClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 200;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 200;
            // 
            // playlistNameDataGridViewTextBoxColumn
            // 
            this.playlistNameDataGridViewTextBoxColumn.DataPropertyName = "PlaylistName";
            this.playlistNameDataGridViewTextBoxColumn.HeaderText = "PlaylistName";
            this.playlistNameDataGridViewTextBoxColumn.Name = "playlistNameDataGridViewTextBoxColumn";
            this.playlistNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateCreateDataGridViewTextBoxColumn
            // 
            this.dateCreateDataGridViewTextBoxColumn.DataPropertyName = "dateCreate";
            this.dateCreateDataGridViewTextBoxColumn.HeaderText = "dateCreate";
            this.dateCreateDataGridViewTextBoxColumn.Name = "dateCreateDataGridViewTextBoxColumn";
            this.dateCreateDataGridViewTextBoxColumn.Width = 250;
            // 
            // playlistsBindingSource
            // 
            this.playlistsBindingSource.DataMember = "Playlists";
            this.playlistsBindingSource.DataSource = this.musicPlayerDataSetBindingSource;
            // 
            // musicPlayerDataSetBindingSource
            // 
            this.musicPlayerDataSetBindingSource.DataSource = this.musicPlayerDataSet;
            this.musicPlayerDataSetBindingSource.Position = 0;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playlistsBindingSource, "ID", true));
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(362, 79);
            this.txtID.Margin = new System.Windows.Forms.Padding(7, 12, 7, 7);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(175, 23);
            this.txtID.TabIndex = 19;
            // 
            // txtPlaylistName
            // 
            this.txtPlaylistName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.txtPlaylistName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlaylistName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playlistsBindingSource, "PlaylistName", true));
            this.txtPlaylistName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaylistName.ForeColor = System.Drawing.Color.White;
            this.txtPlaylistName.Location = new System.Drawing.Point(362, 126);
            this.txtPlaylistName.Margin = new System.Windows.Forms.Padding(7);
            this.txtPlaylistName.Name = "txtPlaylistName";
            this.txtPlaylistName.Size = new System.Drawing.Size(175, 23);
            this.txtPlaylistName.TabIndex = 23;
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
            // btUpdate
            // 
            this.btUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btUpdate.Location = new System.Drawing.Point(298, 229);
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
            this.btDelete.Location = new System.Drawing.Point(430, 229);
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
            this.panel2.Size = new System.Drawing.Size(854, 53);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlbumsTableAdapter = null;
            this.tableAdapterManager.ArtistsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Playlist_SongsTableAdapter = null;
            this.tableAdapterManager.PlaylistsTableAdapter = null;
            this.tableAdapterManager.Song_Album_ArtistTableAdapter = null;
            this.tableAdapterManager.SongsTableAdapter = this.songsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Music.MusicPlayerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // songsTableAdapter
            // 
            this.songsTableAdapter.ClearBeforeFill = true;
            // 
            // songsBindingSource
            // 
            this.songsBindingSource.DataMember = "Songs";
            this.songsBindingSource.DataSource = this.musicPlayerDataSet;
            // 
            // playlistsTableAdapter
            // 
            this.playlistsTableAdapter.ClearBeforeFill = true;
            // 
            // playlistsBindingSource1
            // 
            this.playlistsBindingSource1.DataMember = "Playlists";
            this.playlistsBindingSource1.DataSource = this.musicPlayerDataSet;
            // 
            // timeDateCreate
            // 
            this.timeDateCreate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.playlistsBindingSource, "dateCreate", true));
            this.timeDateCreate.Location = new System.Drawing.Point(733, 77);
            this.timeDateCreate.Name = "timeDateCreate";
            this.timeDateCreate.Size = new System.Drawing.Size(200, 20);
            this.timeDateCreate.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // AdminPlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1054, 575);
            this.Controls.Add(dateCreateLabel);
            this.Controls.Add(this.timeDateCreate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.iDLabel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lyricsLabel);
            this.Controls.Add(this.txtPlaylistName);
            this.Controls.Add(this.dateReleaseLabel);
            this.Controls.Add(this.linkOpenTextBox);
            this.Controls.Add(this.playlistDataGridView);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminPlaylistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.AdminPlaylistForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayerDataSetBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private MusicPlayerDataSet musicPlayerDataSet;
        private System.Windows.Forms.DataGridView playlistDataGridView;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPlaylistName;
        private System.Windows.Forms.TextBox linkOpenTextBox;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label iDLabel;
        private System.Windows.Forms.Label lyricsLabel;
        private System.Windows.Forms.Label dateReleaseLabel;
        private MusicPlayerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MusicPlayerDataSetTableAdapters.SongsTableAdapter songsTableAdapter;
        private System.Windows.Forms.BindingSource songsBindingSource;
        private System.Windows.Forms.BindingSource musicPlayerDataSetBindingSource;
        private System.Windows.Forms.BindingSource playlistsBindingSource;
        private MusicPlayerDataSetTableAdapters.PlaylistsTableAdapter playlistsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playlistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btSong;
        private System.Windows.Forms.Button btPlaylist;
        private System.Windows.Forms.Button btAlbum;
        private System.Windows.Forms.Button btUser;
        private System.Windows.Forms.Button btArtist;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.BindingSource playlistsBindingSource1;
        private System.Windows.Forms.DateTimePicker timeDateCreate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
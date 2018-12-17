namespace Music
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label lyricsLabel;
            System.Windows.Forms.Label dateReleaseLabel;
            System.Windows.Forms.Label linkOpenLabel;
            System.Windows.Forms.Label linkDownLoadLabel;
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label dateReleaseLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btPlaylist = new System.Windows.Forms.Button();
            this.btUser = new System.Windows.Forms.Button();
            this.btArtist = new System.Windows.Forms.Button();
            this.btAlbum = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSong = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.musicPlayerDataSet = new Music.MusicPlayerDataSet();
            this.songsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.songsTableAdapter = new Music.MusicPlayerDataSetTableAdapters.SongsTableAdapter();
            this.tableAdapterManager = new Music.MusicPlayerDataSetTableAdapters.TableAdapterManager();
            this.songsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtLyrics = new System.Windows.Forms.TextBox();
            this.txtDownloadLink = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Music.MusicPlayerDataSetTableAdapters.UsersTableAdapter();
            this.cbbArtist = new System.Windows.Forms.ComboBox();
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbAlbum = new System.Windows.Forms.ComboBox();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsTableAdapter = new Music.MusicPlayerDataSetTableAdapters.AlbumsTableAdapter();
            this.artistsTableAdapter = new Music.MusicPlayerDataSetTableAdapters.ArtistsTableAdapter();
            this.imgSong = new System.Windows.Forms.PictureBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.timeDateRealease = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            lyricsLabel = new System.Windows.Forms.Label();
            dateReleaseLabel = new System.Windows.Forms.Label();
            linkOpenLabel = new System.Windows.Forms.Label();
            linkDownLoadLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            dateReleaseLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(252, 77);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(23, 18);
            iDLabel.TabIndex = 18;
            iDLabel.Text = "ID";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.Location = new System.Drawing.Point(252, 111);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(36, 18);
            titleLabel.TabIndex = 20;
            titleLabel.Text = "Title";
            // 
            // lyricsLabel
            // 
            lyricsLabel.AutoSize = true;
            lyricsLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lyricsLabel.Location = new System.Drawing.Point(252, 141);
            lyricsLabel.Name = "lyricsLabel";
            lyricsLabel.Size = new System.Drawing.Size(49, 18);
            lyricsLabel.TabIndex = 22;
            lyricsLabel.Text = "Lyrics";
            // 
            // dateReleaseLabel
            // 
            dateReleaseLabel.AutoSize = true;
            dateReleaseLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateReleaseLabel.Location = new System.Drawing.Point(570, 77);
            dateReleaseLabel.Name = "dateReleaseLabel";
            dateReleaseLabel.Size = new System.Drawing.Size(106, 18);
            dateReleaseLabel.TabIndex = 24;
            dateReleaseLabel.Text = "Date Release";
            // 
            // linkOpenLabel
            // 
            linkOpenLabel.AutoSize = true;
            linkOpenLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            linkOpenLabel.Location = new System.Drawing.Point(570, 111);
            linkOpenLabel.Name = "linkOpenLabel";
            linkOpenLabel.Size = new System.Drawing.Size(56, 18);
            linkOpenLabel.TabIndex = 26;
            linkOpenLabel.Text = "Album";
            // 
            // linkDownLoadLabel
            // 
            linkDownLoadLabel.AutoSize = true;
            linkDownLoadLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            linkDownLoadLabel.Location = new System.Drawing.Point(570, 142);
            linkDownLoadLabel.Name = "linkDownLoadLabel";
            linkDownLoadLabel.Size = new System.Drawing.Size(117, 18);
            linkDownLoadLabel.TabIndex = 28;
            linkDownLoadLabel.Text = "Download Link";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imageLabel.Location = new System.Drawing.Point(570, 172);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(56, 18);
            imageLabel.TabIndex = 30;
            imageLabel.Text = "Image";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(254, 178);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 18);
            label2.TabIndex = 36;
            label2.Text = "Artists";
            // 
            // dateReleaseLabel1
            // 
            dateReleaseLabel1.AutoSize = true;
            dateReleaseLabel1.Location = new System.Drawing.Point(682, 77);
            dateReleaseLabel1.Name = "dateReleaseLabel1";
            dateReleaseLabel1.Size = new System.Drawing.Size(0, 13);
            dateReleaseLabel1.TabIndex = 40;
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
            this.btPlaylist.TabIndex = 16;
            this.btPlaylist.Text = "        Playlists";
            this.btPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPlaylist.UseVisualStyleBackColor = true;
            this.btPlaylist.Click += new System.EventHandler(this.btPlaylist_Click);
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
            this.btUser.TabIndex = 15;
            this.btUser.Text = "          Users";
            this.btUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUser.UseVisualStyleBackColor = true;
            this.btUser.Click += new System.EventHandler(this.btLyric_Click);
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
            this.btArtist.TabIndex = 14;
            this.btArtist.Text = "         Artists";
            this.btArtist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btArtist.UseVisualStyleBackColor = true;
            this.btArtist.Click += new System.EventHandler(this.btArtist_Click);
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
            this.btAlbum.TabIndex = 12;
            this.btAlbum.Text = "        Albums";
            this.btAlbum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAlbum.UseVisualStyleBackColor = true;
            this.btAlbum.Click += new System.EventHandler(this.btAlbum_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btSong);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btPlaylist);
            this.panel1.Controls.Add(this.btAlbum);
            this.panel1.Controls.Add(this.btUser);
            this.panel1.Controls.Add(this.btArtist);
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
            this.btSong.TabIndex = 19;
            this.btSong.Text = "          Songs";
            this.btSong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSong.UseVisualStyleBackColor = true;
            this.btSong.Click += new System.EventHandler(this.btSong_Click);
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
            // songsBindingSource
            // 
            this.songsBindingSource.DataMember = "Songs";
            this.songsBindingSource.DataSource = this.musicPlayerDataSet;
            // 
            // songsTableAdapter
            // 
            this.songsTableAdapter.ClearBeforeFill = true;
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
            // songsDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.songsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.songsDataGridView.AutoGenerateColumns = false;
            this.songsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.songsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.songsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.songsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.songsDataGridView.ColumnHeadersHeight = 30;
            this.songsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.songsDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.songsDataGridView.DataSource = this.songsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.songsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.songsDataGridView.EnableHeadersVisualStyles = false;
            this.songsDataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.songsDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.songsDataGridView.Location = new System.Drawing.Point(200, 282);
            this.songsDataGridView.Name = "songsDataGridView";
            this.songsDataGridView.RowHeadersVisible = false;
            this.songsDataGridView.RowHeadersWidth = 110;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.songsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.songsDataGridView.RowTemplate.Height = 36;
            this.songsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.songsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.songsDataGridView.Size = new System.Drawing.Size(834, 273);
            this.songsDataGridView.TabIndex = 18;
            this.songsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.songsDataGridView_CellMouseClick);
            this.songsDataGridView.SelectionChanged += new System.EventHandler(this.songsDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 165;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lyrics";
            this.dataGridViewTextBoxColumn3.HeaderText = "Lyrics";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 165;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dateRelease";
            this.dataGridViewTextBoxColumn4.HeaderText = "Release";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "linkOpen";
            this.dataGridViewTextBoxColumn5.HeaderText = "Link Open";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "linkDownLoad";
            this.dataGridViewTextBoxColumn6.HeaderText = "DownLoad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "image";
            this.dataGridViewTextBoxColumn7.HeaderText = "Image";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.songsBindingSource, "title", true));
            this.txtTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(328, 112);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(7);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(175, 23);
            this.txtTitle.TabIndex = 21;
            // 
            // txtLyrics
            // 
            this.txtLyrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.txtLyrics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLyrics.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.songsBindingSource, "lyrics", true));
            this.txtLyrics.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyrics.ForeColor = System.Drawing.Color.White;
            this.txtLyrics.Location = new System.Drawing.Point(328, 145);
            this.txtLyrics.Margin = new System.Windows.Forms.Padding(7);
            this.txtLyrics.Name = "txtLyrics";
            this.txtLyrics.Size = new System.Drawing.Size(175, 23);
            this.txtLyrics.TabIndex = 23;
            // 
            // txtDownloadLink
            // 
            this.txtDownloadLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.txtDownloadLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDownloadLink.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.songsBindingSource, "linkDownLoad", true));
            this.txtDownloadLink.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownloadLink.ForeColor = System.Drawing.Color.White;
            this.txtDownloadLink.Location = new System.Drawing.Point(722, 145);
            this.txtDownloadLink.Margin = new System.Windows.Forms.Padding(7);
            this.txtDownloadLink.Name = "txtDownloadLink";
            this.txtDownloadLink.Size = new System.Drawing.Size(254, 23);
            this.txtDownloadLink.TabIndex = 29;
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
            this.btAdd.Click += new System.EventHandler(this.button2_Click_1);
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
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 53);
            this.panel2.TabIndex = 35;
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
            // btExit
            // 
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Image = ((System.Drawing.Image)(resources.GetObject("btExit.Image")));
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExit.Location = new System.Drawing.Point(782, 12);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(32, 35);
            this.btExit.TabIndex = 6;
            this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click_1);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.musicPlayerDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // cbbArtist
            // 
            this.cbbArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.cbbArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbArtist.ForeColor = System.Drawing.Color.White;
            this.cbbArtist.FormattingEnabled = true;
            this.cbbArtist.Location = new System.Drawing.Point(328, 174);
            this.cbbArtist.Name = "cbbArtist";
            this.cbbArtist.Size = new System.Drawing.Size(175, 21);
            this.cbbArtist.TabIndex = 37;
            // 
            // artistsBindingSource
            // 
            this.artistsBindingSource.DataMember = "Artists";
            this.artistsBindingSource.DataSource = this.musicPlayerDataSet;
            // 
            // cbbAlbum
            // 
            this.cbbAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.cbbAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbAlbum.ForeColor = System.Drawing.Color.White;
            this.cbbAlbum.FormattingEnabled = true;
            this.cbbAlbum.Location = new System.Drawing.Point(722, 108);
            this.cbbAlbum.Name = "cbbAlbum";
            this.cbbAlbum.Size = new System.Drawing.Size(254, 21);
            this.cbbAlbum.TabIndex = 38;
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.musicPlayerDataSet;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // artistsTableAdapter
            // 
            this.artistsTableAdapter.ClearBeforeFill = true;
            // 
            // imgSong
            // 
            this.imgSong.Location = new System.Drawing.Point(722, 174);
            this.imgSong.Name = "imgSong";
            this.imgSong.Size = new System.Drawing.Size(103, 101);
            this.imgSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSong.TabIndex = 39;
            this.imgSong.TabStop = false;
            // 
            // btBrowse
            // 
            this.btBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBrowse.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBrowse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBrowse.Location = new System.Drawing.Point(846, 201);
            this.btBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(73, 36);
            this.btBrowse.TabIndex = 40;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeDateRealease
            // 
            this.timeDateRealease.CalendarForeColor = System.Drawing.SystemColors.ControlLight;
            this.timeDateRealease.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.timeDateRealease.CalendarTitleForeColor = System.Drawing.Color.Cyan;
            this.timeDateRealease.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.timeDateRealease.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.songsBindingSource, "dateRelease", true));
            this.timeDateRealease.Location = new System.Drawing.Point(722, 78);
            this.timeDateRealease.Name = "timeDateRealease";
            this.timeDateRealease.Size = new System.Drawing.Size(254, 20);
            this.timeDateRealease.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.songsBindingSource, "ID", true));
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(328, 78);
            this.txtID.Margin = new System.Windows.Forms.Padding(7, 12, 7, 7);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(175, 23);
            this.txtID.TabIndex = 19;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1054, 575);
            this.Controls.Add(dateReleaseLabel1);
            this.Controls.Add(this.timeDateRealease);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.imgSong);
            this.Controls.Add(this.cbbAlbum);
            this.Controls.Add(this.cbbArtist);
            this.Controls.Add(label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(lyricsLabel);
            this.Controls.Add(this.txtLyrics);
            this.Controls.Add(dateReleaseLabel);
            this.Controls.Add(linkOpenLabel);
            this.Controls.Add(linkDownLoadLabel);
            this.Controls.Add(this.txtDownloadLink);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.songsDataGridView);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPlaylist;
        private System.Windows.Forms.Button btUser;
        private System.Windows.Forms.Button btArtist;
        private System.Windows.Forms.Button btAlbum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSong;
        private System.Windows.Forms.Panel SidePanel;
        private MusicPlayerDataSet musicPlayerDataSet;
        private System.Windows.Forms.BindingSource songsBindingSource;
        private MusicPlayerDataSetTableAdapters.SongsTableAdapter songsTableAdapter;
        private MusicPlayerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView songsDataGridView;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtLyrics;
        private System.Windows.Forms.TextBox txtDownloadLink;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private MusicPlayerDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox cbbArtist;
        private System.Windows.Forms.ComboBox cbbAlbum;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private MusicPlayerDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.BindingSource artistsBindingSource;
        private MusicPlayerDataSetTableAdapters.ArtistsTableAdapter artistsTableAdapter;
        private System.Windows.Forms.PictureBox imgSong;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.DateTimePicker timeDateRealease;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtID;
    }
}
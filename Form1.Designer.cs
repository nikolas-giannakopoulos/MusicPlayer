namespace MusicPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.FinishTime = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.FavouriteButton = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.TitleListLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SongImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainButtonsPanel = new System.Windows.Forms.Panel();
            this.TitleLabelSong = new System.Windows.Forms.Label();
            this.GenreListLabel = new System.Windows.Forms.Label();
            this.AlbumListLabel = new System.Windows.Forms.Label();
            this.ArtistListLabel = new System.Windows.Forms.Label();
            this.AddPlaylistButton = new System.Windows.Forms.Button();
            this.AddSongButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.DateListLabel = new System.Windows.Forms.Label();
            this.PlaylistsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AllSongsGroupbox = new System.Windows.Forms.GroupBox();
            this.AllSongsButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FavouriteSongsButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Top20Button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PlaylistMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SongsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            this.DetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainButtonsPanel.SuspendLayout();
            this.PlaylistsFlowPanel.SuspendLayout();
            this.AllSongsGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.PlaylistMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ButtonsPanel.Controls.Add(this.FinishTime);
            this.ButtonsPanel.Controls.Add(this.StartTime);
            this.ButtonsPanel.Controls.Add(this.progressBar1);
            this.ButtonsPanel.Controls.Add(this.MediaPlayer);
            this.ButtonsPanel.Controls.Add(this.VolumeLabel);
            this.ButtonsPanel.Controls.Add(this.StopButton);
            this.ButtonsPanel.Controls.Add(this.VolumeBar);
            this.ButtonsPanel.Controls.Add(this.FavouriteButton);
            this.ButtonsPanel.Controls.Add(this.RandomButton);
            this.ButtonsPanel.Controls.Add(this.PreviousButton);
            this.ButtonsPanel.Controls.Add(this.NextButton);
            this.ButtonsPanel.Controls.Add(this.PlayButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 482);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(946, 65);
            this.ButtonsPanel.TabIndex = 0;
            // 
            // FinishTime
            // 
            this.FinishTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FinishTime.AutoSize = true;
            this.FinishTime.ForeColor = System.Drawing.Color.White;
            this.FinishTime.Location = new System.Drawing.Point(619, 6);
            this.FinishTime.Name = "FinishTime";
            this.FinishTime.Size = new System.Drawing.Size(28, 13);
            this.FinishTime.TabIndex = 11;
            this.FinishTime.Text = "0:00";
            this.FinishTime.Visible = false;
            // 
            // StartTime
            // 
            this.StartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartTime.AutoSize = true;
            this.StartTime.ForeColor = System.Drawing.Color.White;
            this.StartTime.Location = new System.Drawing.Point(299, 6);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(28, 13);
            this.StartTime.TabIndex = 10;
            this.StartTime.Text = "0:00";
            this.StartTime.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressBar1.Location = new System.Drawing.Point(333, 7);
            this.progressBar1.MarqueeAnimationSpeed = 1000000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(279, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Visible = false;
            this.progressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseDown);
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(76, 7);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(141, 50);
            this.MediaPlayer.TabIndex = 8;
            this.MediaPlayer.Visible = false;
            this.MediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.MediaPlayer_PlayStateChange);
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.VolumeLabel.ForeColor = System.Drawing.Color.White;
            this.VolumeLabel.Location = new System.Drawing.Point(850, 33);
            this.VolumeLabel.Margin = new System.Windows.Forms.Padding(2, 81, 2, 0);
            this.VolumeLabel.MaximumSize = new System.Drawing.Size(154, 122);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(46, 24);
            this.VolumeLabel.TabIndex = 3;
            this.VolumeLabel.Text = "50%";
            this.VolumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StopButton
            // 
            this.StopButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StopButton.BackgroundImage = global::MusicPlayer.Properties.Resources.StopButton;
            this.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.FlatAppearance.BorderSize = 0;
            this.StopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.StopButton.Location = new System.Drawing.Point(560, 25);
            this.StopButton.Margin = new System.Windows.Forms.Padding(0);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(30, 32);
            this.StopButton.TabIndex = 7;
            this.StopButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.StopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Visible = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // VolumeBar
            // 
            this.VolumeBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VolumeBar.AutoSize = false;
            this.VolumeBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VolumeBar.Location = new System.Drawing.Point(824, 12);
            this.VolumeBar.Maximum = 100;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(104, 24);
            this.VolumeBar.TabIndex = 6;
            this.VolumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeBar.Value = 50;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // FavouriteButton
            // 
            this.FavouriteButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FavouriteButton.BackgroundImage = global::MusicPlayer.Properties.Resources.FavouriteButtonImage;
            this.FavouriteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FavouriteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FavouriteButton.FlatAppearance.BorderSize = 0;
            this.FavouriteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FavouriteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavouriteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FavouriteButton.Location = new System.Drawing.Point(27, 16);
            this.FavouriteButton.Margin = new System.Windows.Forms.Padding(0);
            this.FavouriteButton.Name = "FavouriteButton";
            this.FavouriteButton.Size = new System.Drawing.Size(30, 32);
            this.FavouriteButton.TabIndex = 5;
            this.FavouriteButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.FavouriteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FavouriteButton.UseVisualStyleBackColor = true;
            this.FavouriteButton.Visible = false;
            this.FavouriteButton.Click += new System.EventHandler(this.Favourite_Button_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RandomButton.BackgroundImage = global::MusicPlayer.Properties.Resources.RandomButtonImage;
            this.RandomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RandomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomButton.FlatAppearance.BorderSize = 0;
            this.RandomButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RandomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RandomButton.Location = new System.Drawing.Point(350, 25);
            this.RandomButton.Margin = new System.Windows.Forms.Padding(0);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(30, 32);
            this.RandomButton.TabIndex = 4;
            this.RandomButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RandomButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.Random_Button_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PreviousButton.BackgroundImage = global::MusicPlayer.Properties.Resources.PreviewsButtonImage;
            this.PreviousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PreviousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousButton.Enabled = false;
            this.PreviousButton.FlatAppearance.BorderSize = 0;
            this.PreviousButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PreviousButton.Location = new System.Drawing.Point(402, 25);
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(0);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(30, 32);
            this.PreviousButton.TabIndex = 3;
            this.PreviousButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PreviousButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextButton.BackgroundImage = global::MusicPlayer.Properties.Resources.NextButtonImage;
            this.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.Enabled = false;
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NextButton.Location = new System.Drawing.Point(507, 25);
            this.NextButton.Margin = new System.Windows.Forms.Padding(0);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(30, 32);
            this.NextButton.TabIndex = 2;
            this.NextButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.NextButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayButton.BackgroundImage = global::MusicPlayer.Properties.Resources.PlayButtonImage;
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.Enabled = false;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PlayButton.Location = new System.Drawing.Point(454, 20);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(0);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(38, 41);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PlayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.Play_Button_Click);
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DetailsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DetailsPanel.Controls.Add(this.TitleListLabel);
            this.DetailsPanel.Controls.Add(this.TitleLabel);
            this.DetailsPanel.Controls.Add(this.SongImage);
            this.DetailsPanel.Controls.Add(this.pictureBox1);
            this.DetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.DetailsPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(176, 484);
            this.DetailsPanel.TabIndex = 0;
            // 
            // TitleListLabel
            // 
            this.TitleListLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleListLabel.AutoSize = true;
            this.TitleListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TitleListLabel.ForeColor = System.Drawing.Color.White;
            this.TitleListLabel.Location = new System.Drawing.Point(19, 234);
            this.TitleListLabel.Margin = new System.Windows.Forms.Padding(2, 81, 2, 0);
            this.TitleListLabel.MaximumSize = new System.Drawing.Size(154, 122);
            this.TitleListLabel.Name = "TitleListLabel";
            this.TitleListLabel.Size = new System.Drawing.Size(0, 17);
            this.TitleListLabel.TabIndex = 4;
            this.TitleListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(11, 202);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.MaximumSize = new System.Drawing.Size(154, 122);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(0, 29);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SongImage
            // 
            this.SongImage.Location = new System.Drawing.Point(11, 24);
            this.SongImage.Margin = new System.Windows.Forms.Padding(2);
            this.SongImage.Name = "SongImage";
            this.SongImage.Size = new System.Drawing.Size(154, 167);
            this.SongImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SongImage.TabIndex = 0;
            this.SongImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 462);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(9, 8);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // MainButtonsPanel
            // 
            this.MainButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainButtonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.MainButtonsPanel.Controls.Add(this.TitleLabelSong);
            this.MainButtonsPanel.Controls.Add(this.GenreListLabel);
            this.MainButtonsPanel.Controls.Add(this.AlbumListLabel);
            this.MainButtonsPanel.Controls.Add(this.ArtistListLabel);
            this.MainButtonsPanel.Controls.Add(this.AddPlaylistButton);
            this.MainButtonsPanel.Controls.Add(this.AddSongButton);
            this.MainButtonsPanel.Controls.Add(this.BackButton);
            this.MainButtonsPanel.Controls.Add(this.DateListLabel);
            this.MainButtonsPanel.Location = new System.Drawing.Point(176, 0);
            this.MainButtonsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainButtonsPanel.Name = "MainButtonsPanel";
            this.MainButtonsPanel.Size = new System.Drawing.Size(770, 89);
            this.MainButtonsPanel.TabIndex = 1;
            // 
            // TitleLabelSong
            // 
            this.TitleLabelSong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleLabelSong.AutoSize = true;
            this.TitleLabelSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TitleLabelSong.ForeColor = System.Drawing.Color.White;
            this.TitleLabelSong.Location = new System.Drawing.Point(99, 69);
            this.TitleLabelSong.Margin = new System.Windows.Forms.Padding(0);
            this.TitleLabelSong.MaximumSize = new System.Drawing.Size(154, 122);
            this.TitleLabelSong.Name = "TitleLabelSong";
            this.TitleLabelSong.Size = new System.Drawing.Size(50, 17);
            this.TitleLabelSong.TabIndex = 9;
            this.TitleLabelSong.Text = "Τίτλος";
            this.TitleLabelSong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleLabelSong.Visible = false;
            // 
            // GenreListLabel
            // 
            this.GenreListLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GenreListLabel.AutoSize = true;
            this.GenreListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.GenreListLabel.ForeColor = System.Drawing.Color.White;
            this.GenreListLabel.Location = new System.Drawing.Point(594, 69);
            this.GenreListLabel.Margin = new System.Windows.Forms.Padding(0);
            this.GenreListLabel.MaximumSize = new System.Drawing.Size(154, 122);
            this.GenreListLabel.Name = "GenreListLabel";
            this.GenreListLabel.Size = new System.Drawing.Size(44, 17);
            this.GenreListLabel.TabIndex = 8;
            this.GenreListLabel.Text = "Είδος";
            this.GenreListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GenreListLabel.Visible = false;
            // 
            // AlbumListLabel
            // 
            this.AlbumListLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AlbumListLabel.AutoSize = true;
            this.AlbumListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AlbumListLabel.ForeColor = System.Drawing.Color.White;
            this.AlbumListLabel.Location = new System.Drawing.Point(372, 69);
            this.AlbumListLabel.Margin = new System.Windows.Forms.Padding(0);
            this.AlbumListLabel.MaximumSize = new System.Drawing.Size(154, 122);
            this.AlbumListLabel.Name = "AlbumListLabel";
            this.AlbumListLabel.Size = new System.Drawing.Size(64, 17);
            this.AlbumListLabel.TabIndex = 6;
            this.AlbumListLabel.Text = "Άλμπουμ";
            this.AlbumListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AlbumListLabel.Visible = false;
            // 
            // ArtistListLabel
            // 
            this.ArtistListLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ArtistListLabel.AutoSize = true;
            this.ArtistListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ArtistListLabel.ForeColor = System.Drawing.Color.White;
            this.ArtistListLabel.Location = new System.Drawing.Point(226, 69);
            this.ArtistListLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ArtistListLabel.MaximumSize = new System.Drawing.Size(154, 122);
            this.ArtistListLabel.Name = "ArtistListLabel";
            this.ArtistListLabel.Size = new System.Drawing.Size(85, 17);
            this.ArtistListLabel.TabIndex = 5;
            this.ArtistListLabel.Text = "Καλλιτέχνης";
            this.ArtistListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ArtistListLabel.Visible = false;
            // 
            // AddPlaylistButton
            // 
            this.AddPlaylistButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPlaylistButton.BackgroundImage = global::MusicPlayer.Properties.Resources.AddListButton;
            this.AddPlaylistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddPlaylistButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPlaylistButton.FlatAppearance.BorderSize = 0;
            this.AddPlaylistButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPlaylistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddPlaylistButton.Location = new System.Drawing.Point(654, 24);
            this.AddPlaylistButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddPlaylistButton.Name = "AddPlaylistButton";
            this.AddPlaylistButton.Size = new System.Drawing.Size(38, 41);
            this.AddPlaylistButton.TabIndex = 4;
            this.AddPlaylistButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AddPlaylistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddPlaylistButton.UseVisualStyleBackColor = true;
            this.AddPlaylistButton.Click += new System.EventHandler(this.Add_Playlist);
            // 
            // AddSongButton
            // 
            this.AddSongButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSongButton.BackgroundImage = global::MusicPlayer.Properties.Resources.AddSongButton;
            this.AddSongButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddSongButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddSongButton.FlatAppearance.BorderSize = 0;
            this.AddSongButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddSongButton.Location = new System.Drawing.Point(706, 24);
            this.AddSongButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddSongButton.Name = "AddSongButton";
            this.AddSongButton.Size = new System.Drawing.Size(38, 41);
            this.AddSongButton.TabIndex = 3;
            this.AddSongButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AddSongButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddSongButton.UseVisualStyleBackColor = true;
            this.AddSongButton.Click += new System.EventHandler(this.Add_Song_Button);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.BackgroundImage = global::MusicPlayer.Properties.Resources.BackButton;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BackButton.Location = new System.Drawing.Point(12, 24);
            this.BackButton.Margin = new System.Windows.Forms.Padding(0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(38, 41);
            this.BackButton.TabIndex = 2;
            this.BackButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DateListLabel
            // 
            this.DateListLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateListLabel.AutoSize = true;
            this.DateListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DateListLabel.ForeColor = System.Drawing.Color.White;
            this.DateListLabel.Location = new System.Drawing.Point(472, 52);
            this.DateListLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DateListLabel.MaximumSize = new System.Drawing.Size(154, 122);
            this.DateListLabel.Name = "DateListLabel";
            this.DateListLabel.Size = new System.Drawing.Size(91, 34);
            this.DateListLabel.TabIndex = 7;
            this.DateListLabel.Text = "Έτος\r\nΚυκλοφορίας\r\n";
            this.DateListLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DateListLabel.Visible = false;
            // 
            // PlaylistsFlowPanel
            // 
            this.PlaylistsFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaylistsFlowPanel.AutoScroll = true;
            this.PlaylistsFlowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PlaylistsFlowPanel.Controls.Add(this.AllSongsGroupbox);
            this.PlaylistsFlowPanel.Controls.Add(this.groupBox1);
            this.PlaylistsFlowPanel.Controls.Add(this.groupBox3);
            this.PlaylistsFlowPanel.Location = new System.Drawing.Point(176, 89);
            this.PlaylistsFlowPanel.Margin = new System.Windows.Forms.Padding(2);
            this.PlaylistsFlowPanel.Name = "PlaylistsFlowPanel";
            this.PlaylistsFlowPanel.Size = new System.Drawing.Size(770, 396);
            this.PlaylistsFlowPanel.TabIndex = 4;
            // 
            // AllSongsGroupbox
            // 
            this.AllSongsGroupbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.AllSongsGroupbox.Controls.Add(this.AllSongsButton);
            this.AllSongsGroupbox.Controls.Add(this.label7);
            this.AllSongsGroupbox.Controls.Add(this.pictureBox2);
            this.AllSongsGroupbox.Location = new System.Drawing.Point(13, 13);
            this.AllSongsGroupbox.Margin = new System.Windows.Forms.Padding(13, 13, 0, 0);
            this.AllSongsGroupbox.Name = "AllSongsGroupbox";
            this.AllSongsGroupbox.Size = new System.Drawing.Size(175, 285);
            this.AllSongsGroupbox.TabIndex = 0;
            this.AllSongsGroupbox.TabStop = false;
            // 
            // AllSongsButton
            // 
            this.AllSongsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AllSongsButton.BackgroundImage = global::MusicPlayer.Properties.Resources.PlaySongButtonImage;
            this.AllSongsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AllSongsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllSongsButton.FlatAppearance.BorderSize = 0;
            this.AllSongsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AllSongsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllSongsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AllSongsButton.Location = new System.Drawing.Point(120, 230);
            this.AllSongsButton.Margin = new System.Windows.Forms.Padding(0);
            this.AllSongsButton.Name = "AllSongsButton";
            this.AllSongsButton.Size = new System.Drawing.Size(40, 40);
            this.AllSongsButton.TabIndex = 8;
            this.AllSongsButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AllSongsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AllSongsButton.UseVisualStyleBackColor = true;
            this.AllSongsButton.Click += new System.EventHandler(this.Open_Playlist);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 170);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.MaximumSize = new System.Drawing.Size(145, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 48);
            this.label7.TabIndex = 5;
            this.label7.Text = "Όλα τα κομμάτια";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::MusicPlayer.Properties.Resources.AllSongImage;
            this.pictureBox2.Location = new System.Drawing.Point(15, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.groupBox1.Controls.Add(this.FavouriteSongsButton);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Location = new System.Drawing.Point(201, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(13, 13, 0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 285);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // FavouriteSongsButton
            // 
            this.FavouriteSongsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FavouriteSongsButton.BackgroundImage = global::MusicPlayer.Properties.Resources.PlaySongButtonImage;
            this.FavouriteSongsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FavouriteSongsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FavouriteSongsButton.FlatAppearance.BorderSize = 0;
            this.FavouriteSongsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FavouriteSongsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavouriteSongsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FavouriteSongsButton.Location = new System.Drawing.Point(120, 230);
            this.FavouriteSongsButton.Margin = new System.Windows.Forms.Padding(0);
            this.FavouriteSongsButton.Name = "FavouriteSongsButton";
            this.FavouriteSongsButton.Size = new System.Drawing.Size(40, 40);
            this.FavouriteSongsButton.TabIndex = 8;
            this.FavouriteSongsButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.FavouriteSongsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FavouriteSongsButton.UseVisualStyleBackColor = true;
            this.FavouriteSongsButton.Click += new System.EventHandler(this.Open_Playlist);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(29, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.MaximumSize = new System.Drawing.Size(145, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Αγαπημένα";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::MusicPlayer.Properties.Resources.FavouriteImage;
            this.pictureBox3.Location = new System.Drawing.Point(15, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(145, 145);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.groupBox3.Controls.Add(this.Top20Button);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Location = new System.Drawing.Point(389, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(13, 13, 0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 285);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // Top20Button
            // 
            this.Top20Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Top20Button.BackgroundImage = global::MusicPlayer.Properties.Resources.PlaySongButtonImage;
            this.Top20Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Top20Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Top20Button.FlatAppearance.BorderSize = 0;
            this.Top20Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Top20Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Top20Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Top20Button.Location = new System.Drawing.Point(120, 230);
            this.Top20Button.Margin = new System.Windows.Forms.Padding(0);
            this.Top20Button.Name = "Top20Button";
            this.Top20Button.Size = new System.Drawing.Size(40, 40);
            this.Top20Button.TabIndex = 8;
            this.Top20Button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Top20Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Top20Button.UseVisualStyleBackColor = true;
            this.Top20Button.Click += new System.EventHandler(this.Open_Playlist);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(50, 170);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.MaximumSize = new System.Drawing.Size(145, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Top 20";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = global::MusicPlayer.Properties.Resources.TopSongImage;
            this.pictureBox4.Location = new System.Drawing.Point(15, 15);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(145, 145);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // PlaylistMenuStrip
            // 
            this.PlaylistMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.PlaylistMenuStrip.Name = "contextMenuStrip1";
            this.PlaylistMenuStrip.Size = new System.Drawing.Size(181, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Επεξεργασία Playlist";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.Edit_Playlist);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Διαγραφή Playlist";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.Delete_Playlist);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SongsFlowPanel
            // 
            this.SongsFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SongsFlowPanel.AutoScroll = true;
            this.SongsFlowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.SongsFlowPanel.Location = new System.Drawing.Point(176, 89);
            this.SongsFlowPanel.Name = "SongsFlowPanel";
            this.SongsFlowPanel.Size = new System.Drawing.Size(770, 396);
            this.SongsFlowPanel.TabIndex = 5;
            this.SongsFlowPanel.Resize += new System.EventHandler(this.SongsFlowPanel_Resize);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.MainButtonsPanel);
            this.Controls.Add(this.DetailsPanel);
            this.Controls.Add(this.PlaylistsFlowPanel);
            this.Controls.Add(this.SongsFlowPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(644, 393);
            this.Name = "Form1";
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            this.DetailsPanel.ResumeLayout(false);
            this.DetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainButtonsPanel.ResumeLayout(false);
            this.MainButtonsPanel.PerformLayout();
            this.PlaylistsFlowPanel.ResumeLayout(false);
            this.AllSongsGroupbox.ResumeLayout(false);
            this.AllSongsGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.PlaylistMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Panel DetailsPanel;
        private System.Windows.Forms.Button FavouriteButton;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.Panel MainButtonsPanel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddPlaylistButton;
        private System.Windows.Forms.Button AddSongButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.FlowLayoutPanel PlaylistsFlowPanel;
        private System.Windows.Forms.Label TitleListLabel;
        private System.Windows.Forms.Label ArtistListLabel;
        private System.Windows.Forms.Label DateListLabel;
        private System.Windows.Forms.Label AlbumListLabel;
        private System.Windows.Forms.Label GenreListLabel;
        private System.Windows.Forms.Label TitleLabelSong;
        private System.Windows.Forms.GroupBox AllSongsGroupbox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AllSongsButton;
        private System.Windows.Forms.ContextMenuStrip PlaylistMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FavouriteSongsButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Top20Button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        public System.Windows.Forms.PictureBox SongImage;
        private System.Windows.Forms.FlowLayoutPanel SongsFlowPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label FinishTime;
        private System.Windows.Forms.Label StartTime;
    }
}


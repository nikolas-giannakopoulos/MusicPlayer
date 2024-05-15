using AxWMPLib;
using MusicPlayer.Properties;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        SQLiteConnection connection;                                                        //
        public OpenFileDialog SongDialog = new OpenFileDialog();                            //
        Random r = new Random();                                                            //
        Song CurrentSong;                                                                   //
        bool favourite = false, random = false, play = false, favouritePlaylist = false;    //
        int index;                                                                          // Ορισμοί για χρήση απο την Form1
        public bool editPlaylistFlag = false;                                               //
        public bool editSongFlag = false;                                                   //
        public String DBNameReference;                                                      //
        public String DBPhotoReference;                                                     //
        public List<Playlist> playlists_list = new List<Playlist>();                        //
        public List<Song> song_list = new List<Song>();                                     //

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            connection = new SQLiteConnection("Data source=musicplayer.db;Version=3");
            connection.Open();

            String SongTableSQLString = "Create table if not exists Songs(" +                       //
                                        "SongID Integer primary key autoincrement," +               //
                                        "Title Text Not Null," +                                    //
                                        "Artist Text Not Null," +                                   //
                                        "Album Text," +                                             //
                                        "Date Integer," +                                           //
                                        "Genre Text," +                                             // Δημιουργία Table κομματιών
                                        "Liked Bool," +                                             // εάν δεν υπάρχει
                                        "TimesPlayed Integer," +                                    //
                                        "Photo Text," +                                             //
                                        "Path Text)";                                               //
            SQLiteCommand CreateSongCommand = new SQLiteCommand(SongTableSQLString, connection);    //
            CreateSongCommand.ExecuteNonQuery();                                                    //

            String PlaylistTableSQLString = "Create table if not exists Playlists(" +                       //
                                            "Name Text primary key," +                                      //
                                            "Photo Text)";                                                  // Δημιουργία Table playlist
            SQLiteCommand CreatePlaylistCommand = new SQLiteCommand(PlaylistTableSQLString, connection);    // εάν δεν υπάρχει
            CreatePlaylistCommand.ExecuteNonQuery();                                                        //

            String ConnectionTableSQLString = "Create table if not exists PlaylistSongConnection(" +            //
                                                 "PlaylistName integer primary key," +                          //
                                                 "SongID integer primary key," +                                // Δημιουργία Table για Connection
                                                 "foreign key (PlaylistName) references Playlists(Name)," +     // μετάξυ Tables κομματιών & playlist
                                                 "foreign key (SongID) references Songs(SongID))";              // εάν δεν υπάρχει
            SQLiteCommand CreatePlaylistSongsCommand = new SQLiteCommand(ConnectionTableSQLString, connection); //
            CreatePlaylistSongsCommand.ExecuteNonQuery();                                                       //
            connection.Close();

            Load_Playlists();   //Φόρτωση των playlist
        }
        public void Create_Playlist(String NameSource, String ImageSource) //Μέθοδος για δημιουργία playlist                                       PLAYLIST METHODS
        {                                                                                                                                        ///////////////////
            Playlist playlist = new Playlist(NameSource, ImageSource, Open_Playlist, PlaylistMenuStrip); // Δημιουργία αντικειμένου playlist
            playlists_list.Add(playlist);                                                                // και προσθήκη σε αντίστοιχη λίστα
            PlaylistsFlowPanel.Controls.Add(playlist.Box);  //Προσθήκη του Groupbox της κάθε playlist, σε FlowPanel για εμφάνιση στον χρήστη
        }

        public void Load_Playlists() //Μέθοδος για φόρτωση των playlist από τη ΒΔ
        {
            String SetPhoto;

            connection.Open();                                                                      //
            SQLiteCommand LoadCommand = new SQLiteCommand("Select * from Playlists", connection);   // Επιλογή των στοιχείων των Playlist
            SQLiteDataReader sQLiteDataReaderreader = LoadCommand.ExecuteReader();                  // απο τη βαση δεδομένων
            while (sQLiteDataReaderreader.Read())                                                 //
            {                                                                                       //
                try                                                                                 //
                {                                                                                   //
                    pictureBox1.Load(sQLiteDataReaderreader.GetString(1));                          // Προσπάθεια για φόρτωση εικόνας, διαφορετικά
                    SetPhoto = sQLiteDataReaderreader.GetString(1);                                 // τη θέτει κενή
                }                                                                                   //
                catch                                                                               //
                {                                                                                   //
                    SetPhoto = "";                                                                  //
                }                                                                                   //
                Create_Playlist(sQLiteDataReaderreader.GetString(0), SetPhoto);                     // Δημιουργία των playlist, με βάση των στοιχείων της ΒΔ
            }                                                                                       //
            connection.Close();                                                                     //
        }

        private void Open_Playlist(object sender, EventArgs e) //Μέθοδος για άνοιγμα playlist     
        {
            song_list.Clear();                  // Εκκαθάριση δεδομένων από
            SongsFlowPanel.Controls.Clear();    // προηγούμενη playlist
            Load_Songs(sender); //Φόρτωση κομματιών με βάση το αντικείμενο playlist (sender)

            SongsFlowPanel.BringToFront();      //
            BackButton.Visible = true;          //
            TitleLabelSong.Visible = true;      //
            ArtistListLabel.Visible = true;     // Αλλαγές για το UI
            DateListLabel.Visible = true;       //
            GenreListLabel.Visible = true;      //
            AlbumListLabel.Visible = true;      //
        }

        private void Add_Playlist(object sender, EventArgs e) //Μέθοδος για προσθήκη playlist     
        {
            Form3 AddPlaylistForm = new Form3(this); //Δημιουργία της Form3

            AddPlaylistForm.StartPosition = FormStartPosition.Manual;                                                               // Διάφορες μετατροπές για
            AddPlaylistForm.Location = new Point(this.Location.X + this.Width / 2 - AddPlaylistForm.Width / 2, this.Location.Y);    // τη σωστή λειτουργία του
            AddPlaylistForm.Show();                                                                                                 // του Form3
        }

        private void Edit_Playlist(object sender, EventArgs e) //Μέθοδος για επεξεργασία κομματιών
        {
            editPlaylistFlag = true;                                                                                                       // Flag & Name που χρειάζονται για τη 
            DBNameReference = ((Playlist)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag).Title.Text;  // σωστή λειτουργεία της Form2

            Form3 EditPlaylistForm = new Form3(this); //Δημιουργία της Form3

            //Επειδή η "Edit_Playlist" καλείται από το ContextMenuStrip του Groupbox του αντικειμένου, χρησιμοποιούμε τη παρακάτω διαδικασία, για να "φτάσουμε" στο αντικείμενο
            if (((Playlist)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag).Picture.ImageLocation != null) //Εαν ο χρήστης δεν έχει δωσει φώτο
            {
                EditPlaylistForm.PhotoPath = ((Playlist)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag).Picture.ImageLocation;                                  //
                EditPlaylistForm.PhotoLabel.Text = Path.GetFileName(((Playlist)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag).Picture.ImageLocation);          // Διάφορες μετατροπές για
                EditPlaylistForm.PhotoLabel.Visible = true;                                                                                                                                          // τη σωστή λειτουργία του
                EditPlaylistForm.PhotoRemoveButton.Location = new Point(EditPlaylistForm.PhotoLabel.Location.X + EditPlaylistForm.PhotoLabel.Width, EditPlaylistForm.PhotoRemoveButton.Location.Y);  // του Form3
                EditPlaylistForm.PhotoRemoveButton.Visible = true;                                                                                                                                   //
            }
            EditPlaylistForm.NameTextBox.Text = DBNameReference; // Φόρτωση του υπάρχον ονόματος στο αντίστοιχο Textbox, για επεξεργασία

            EditPlaylistForm.FinalButton.Font = new Font("Microsoft Sans Serif", 6);                                                //
            EditPlaylistForm.FinalButton.Text = "Ενημέρωση";                                                                        // Διάφορες μετατροπές για
            EditPlaylistForm.StartPosition = FormStartPosition.Manual;                                                              // τη σωστή λειτουργία του
            EditPlaylistForm.Location = new Point(this.Location.X + this.Width / 2 - EditPlaylistForm.Width / 2, this.Location.Y);  // του Form3
            EditPlaylistForm.Show();                                                                                                //
        }

        private void Delete_Playlist(object sender, EventArgs e) //Μέθοδος για διαγραφή κομματιών
        {
            if (MessageBox.Show("Θέλετε σίγουρα να διαγράψετε την συγκεκριμένή playlist ;", "Music Player", MessageBoxButtons.YesNo) == DialogResult.Yes) // Μήνυμα για επιβεβαίωση από τον χρήστη
            {
                connection.Open();                                                                                                              //
                SQLiteCommand DeleteCommand = new SQLiteCommand("Delete from Playlists where Name=@name", connection);                          // Διαγραφή της Playlist
                DeleteCommand.Parameters.AddWithValue("name", ((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl.Name);        // από το Table στη
                DeleteCommand.ExecuteNonQuery();                                                                                                // βάση δεδομένων

                SQLiteCommand DeleteConCommand = new SQLiteCommand("Delete from PlaylistSongConnection where PlaylistName=@name", connection);  // Διαγραφή της Playlist
                DeleteConCommand.Parameters.AddWithValue("name", ((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl.Name);     // από το Table των connection
                DeleteConCommand.ExecuteNonQuery();                                                                                             // στη βάση δεδομένων
                connection.Close();                                                                                                             //

                PlaylistsFlowPanel.Controls.Remove((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl);      // Αφαίρεση playlist από το
                playlists_list.Remove((Playlist)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag);   // FlowPanel & τη αντίστοιχη λίστα
            }
        }

        public void Create_Song(int id, String title, String artist, String album, Nullable<int> date, String genre, Boolean liked, int timesplayed, String photo, String path)  //Μέθοδος για δημιουργία κομματιών
        {
            Song song = new Song(id, title, artist, album, date, genre, liked, timesplayed, photo, path, Play_Song); // Δημιουργία αντικειμένου playlist
            song_list.Add(song);                                                                                    // και προσθήκη σε αντίστοιχη λίστα               SONG METHODS                    
            SongsFlowPanel.Controls.Add(song.Box);   //Προσθήκη του Groupbox του κάθε κομματιού, σε FlowPanel για εμφάνιση στον χρήστη                              ////////////////
        }
        public void Load_Songs(object sender) //Μέθοδος για φόρτωση κομματιών
        {
            String SetPhoto;
            int? SetDate;

            String WhereString = " Join PlaylistSongConnection ON Songs.SongID = PlaylistSongConnection.SongID " +    // Αρχικό string για ΒΔ σε περίπτωση
                                 "where PlaylistSongConnection.PlaylistName = @playlistname";                         // που ανοιχτεί playlist του χρήστη

            bool defaultplaylists = false;                                                                                                                   // Ρυθμίσεις σε 
            if (((Button)sender).Name == "AllSongsButton") { WhereString = ""; defaultplaylists = true; }                                                    // περίπτωση που 
            if (((Button)sender).Name == "FavouriteSongsButton") { WhereString = " where Liked = true"; defaultplaylists = true; favouritePlaylist = true; } // η playlist είναι
            if (((Button)sender).Name == "Top20Button") { WhereString = " order by TimesPlayed desc limit 20"; defaultplaylists = true; }                    // από τις αρχικές

            connection.Open();                                                                          //
            String Songs = "Select * from Songs " + WhereString;                                        //
            SQLiteCommand LoadSongs = new SQLiteCommand(Songs, connection);                             // Επιλογή των στοιχείων των κομματιών
            LoadSongs.Parameters.AddWithValue("playlistname", ((GroupBox)((Button)sender).Parent).Name);  // από τη βάση δεδομένων
            SQLiteDataReader SongsReader = LoadSongs.ExecuteReader();                                   // 

            String Songss = "Select PlaylistName from PlaylistSongConnection " +                        // Επιλογή των playlist στα οποία ανήκει 
            "where SongID = @songid";                                                                   // το κάθε κομμάτι
            SQLiteCommand LoadPlaylistSongs = new SQLiteCommand(Songss, connection);                    //

            while (SongsReader.Read())
            {
                ContextMenuStrip cms = new ContextMenuStrip();                                                                                        //
                ToolStripMenuItem Add = new ToolStripMenuItem { Name = "AddToPlaylist", Text = "Προσθήκη σε Playlist" };                              //
                ToolStripMenuItem Remove = new ToolStripMenuItem { Name = ((GroupBox)((Button)sender).Parent).Name, Text = "Αφαίρεση από Playlist" }; //
                ToolStripMenuItem Edit = new ToolStripMenuItem { Name = "EditSong", Text = "Επεξεργασία κομματιού" };                                 // Δημιουργία ContextMenu
                ToolStripMenuItem Delete = new ToolStripMenuItem { Name = "DeleteSong", Text = "Διαγραφή κομματιού" };                                // για κάθε μοναδικό κομμάτι
                Edit.Click += Edit_Song;                                                                                                              // και ορισμό μεθόδων
                Delete.Click += Delete_Song;                                                                                                          // για διάφορες ενέργειες
                Delete.Tag = cms;                                                                                                                     // 
                Remove.Click += Remove_Song;                                                                                                          //
                cms.Items.AddRange(new ToolStripItem[] { Add, Remove, Edit, Delete });                                                                //

                if (defaultplaylists) { cms.Items.Remove(Remove); }     // Εάν είναι από τις αρχικές, αφαιρεί τη δυνατότητα για αφαίρεση κομματιού απο τη playlist

                foreach (Playlist playlist in playlists_list)                                                                   //
                {                                                                                                               //
                    ToolStripMenuItem playlistitem = new ToolStripMenuItem(playlist.Title.Text) { Name = playlist.Title.Text }; // Προσθήκη κάθε playlist 
                    playlistitem.Click += Add_to_Playlist;                                                                      // στη λίστα του ConteMenu
                    playlistitem.Tag = cms;                                                                                     // για προσθήκη κομματιού σε playlist
                    Add.DropDownItems.Add(playlistitem);                                                                        //
                }                                                                                                               //

                try                                                         //
                {                                                           //
                    pictureBox1.Load(SongsReader.GetString(8));             // Εάν μπορεί να φορτωθεί η εικόνα, τη φορτώνει
                    SetPhoto = SongsReader.GetString(8);                    // διαφορετικά θέτει προεπιλεγμένη τύπου Unavailable
                }                                                           //
                catch { SetPhoto = ""; }                                     //

                try                                                         //
                {                                                           // Εάν έχει οριστεί ημερομηνία κυκλοφορίας, τη φορτώνει
                    SongsReader.GetInt32(4);                                // διαφορετικά τη θέτει null 
                    SetDate = SongsReader.GetInt32(4);                      //
                }                                                           //
                catch { SetDate = null; }                                    //

                //Δημιουργία κομματιών με τα δεδομένα της βάσης δεδομένων
                Create_Song(SongsReader.GetInt32(0), SongsReader.GetString(1), SongsReader.GetString(2), SongsReader.GetString(3), SetDate, SongsReader.GetString(5), SongsReader.GetBoolean(6), SongsReader.GetInt32(7), SetPhoto, SongsReader.GetString(9));

                LoadPlaylistSongs.Parameters.AddWithValue("songid", SongsReader.GetInt32(0));   //
                SQLiteDataReader sQLiteDataReaderreader2 = LoadPlaylistSongs.ExecuteReader();   // Με βάση το ID του κάθε κομματιού 
                while (sQLiteDataReaderreader2.Read())                                          // διαβάζει σε ποιές playlist άνήκει
                {                                                                               // το κομμάτι, και τις διαγράφει απο
                    Add.DropDownItems.RemoveByKey(sQLiteDataReaderreader2.GetString(0));        // τη επιλογή "προσθήκη στη playlist"
                }                                                                               //
                sQLiteDataReaderreader2.Close();                                                //
                song_list[song_list.Count - 1].Box.ContextMenuStrip = cms;  // Θέτει το ContexMenu, στο κομμάτι
            }
            connection.Close();
        }

        private void Play_Song(object sender, EventArgs e) //Μέθοδος για αναπαραγωγή κομματιών
        {
            CurrentSong = (Song)((Button)sender).Tag;              // Ορισμός του "CurrentSong" ως το κομμάτι που παίζει τη συγκεκριμένη στιγμή
            index = song_list.IndexOf((Song)((Button)sender).Tag); // Ορισμός του "index" ως το index του κομματιού που παίζει τη συγκεκριμένη στιγμή, στη λίστα

            try                                                         //
            {                                                           //
                SongImage.Load(((Song)((Button)sender).Tag).photo);     //
            }                                                           // Εάν μπορεί να φορτωθεί η εικόνα, τη φορτώνει
            catch                                                       // διαφορετικά θέτει προεπιλεγμένη τύπου Unavailable
            {                                                           //
                SongImage.Image = Resources.UnavailablePhoto;           //
                SongImage.Refresh();                                    //
            }                                                           //

            TitleLabel.Text = ((Song)((Button)sender).Tag).Title.Text;                                                      // Αλλαγές σε ιδιότητες για ορθή
            TitleListLabel.Location = new Point(TitleListLabel.Location.X, TitleLabel.Location.Y + TitleLabel.Height + 10); // λειτουργία του UI
            TitleListLabel.Text = ((Song)((Button)sender).Tag).Artist.Text;                                                 // 

            if (((Song)((Button)sender).Tag).liked) //Εάν το τραγούδι είναι στα αγαπημένα
            {
                FavouriteButton.BackgroundImage = Resources.FavouriteButtonClickedImage;    // Θέτει αγαπημένο το κομμάτι 
                favourite = true;                                                           // στο UI
            }
            else
            {
                FavouriteButton.BackgroundImage = Resources.FavouriteButtonImage;           // Θέτει μη αγαπημένο το
                favourite = false;                                                          // κομμάτι στο UI
            }

            ((Song)((Button)sender).Tag).timesplayed++;     // Άυξηση των φορών που έχει παιχτεί το κομμάτι κατα 1

            connection.Open();                                                  //
            String updateSQL = "Update Songs " +                                //
                               "set TimesPlayed=TimesPlayed+1 " +               //
                               "where SongID = @id";                            // Ενημερώνει την βαση δεδομένων με τη
            SQLiteCommand command = new SQLiteCommand(updateSQL, connection);   // ανανεωμένη τιμή των φορών που έχει παιχτεί
            command.Parameters.AddWithValue("id", song_list[index].ID);         // 
            command.ExecuteNonQuery();                                          //
            connection.Close();                                                 //

            song_list[index].liked = favourite;                                 // Θέτει εάν το κομμάτι είναι αγαπημένο, ή οχι

            if (File.Exists(((Song)((Button)sender).Tag).path))         //
            {                                                           //
                MediaPlayer.URL = ((Song)((Button)sender).Tag).path;    // Εάν υπάρχει το αρχείο του κομματιού
                MediaPlayer.Ctlcontrols.play();                         // ξεκινάει η αναπαραγωγή
            }                                                           //
            else
            {
                if (MessageBox.Show("Το κομμάτι δεν μπορεί να φορτωθεί, θέλετε να γινει κατάργηση;", "Music Player", MessageBoxButtons.YesNo) == DialogResult.No) //Εαν δεν μπορει να φορτωθει το κομμάτι
                {
                    ((Song)((Button)sender).Tag).PlayButton.Visible = false;    // Εάν δεν το καταργήσει ο χρήστης
                }
                else
                {
                    connection.Open();                                                                                  //
                    SQLiteCommand DeleteCommand = new SQLiteCommand("Delete from Songs where SongID=@id", connection);  // Διαγραφή του κομματιού
                    DeleteCommand.Parameters.AddWithValue("id", ((Song)((Button)sender).Tag).ID);                       // από τη βάση δεδομένων
                    DeleteCommand.ExecuteNonQuery();                                                                    //

                    SQLiteCommand DeleteConCommand = new SQLiteCommand("Delete from PlaylistSongConnection where SongID=@id", connection);  // Διαγραφή του κομματιού
                    DeleteConCommand.Parameters.AddWithValue("id", ((Song)((Button)sender).Tag).ID);                                        // απο το Table των συνδέσεων
                    DeleteConCommand.ExecuteNonQuery();                                                                                     // με τις playlist
                    connection.Close();                                                                                                     //

                    SongsFlowPanel.Controls.Remove(((Song)((Button)sender).Tag).Box);   // Αφαίρεση κομματιού απο 
                    SongsFlowPanel.Refresh();                                           // το UI και απο τη λίστα
                    song_list.Remove((Song)((Button)sender).Tag);                       //

                }
            }
        }
        private void Edit_Song(object sender, EventArgs e) //Μέθοδος για επεξεργασία κομματιών
        {
            editSongFlag = true;                                                                                                        // Flag & Name που χρειάζονται για τη 
            DBNameReference = ((Song)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag).Title.Text;   // σωστή λειτουργεία της Form2

            Form2 edit_Song_Form = new Form2(this); //Δημιουργία της Form2

            //Επειδή η "Edit_Song" καλείται από το ContextMenuStrip του Groupbox του αντικειμένου, χρησιμοποιούμε τη παρακάτω διαδικασία, για να "φτάσουμε" στο αντικείμενο
            if (((Song)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag).photo != null) //Εαν ο χρήστης δεν έχει δωσει φώτο
            {
                edit_Song_Form.PhotoPath = ((Song)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag).photo;                                               //
                edit_Song_Form.PhotoLabel.Text = Path.GetFileName(((Song)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag).photo);                       // Διάφορες μετατροπές για
                edit_Song_Form.PhotoLabel.Visible = true;                                                                                                                                   // τη σωστή λειτουργία του
                edit_Song_Form.PhotoRemoveButton.Location = new Point(edit_Song_Form.PhotoLabel.Location.X + edit_Song_Form.PhotoLabel.Width, edit_Song_Form.PhotoRemoveButton.Location.Y); // του Form2
                edit_Song_Form.PhotoRemoveButton.Visible = true;                                                                                                                            //
            }

            edit_Song_Form.NameTextBox.Text = DBNameReference;                                                                                              //
            edit_Song_Form.idcheck = ((Song)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag).ID;                        //
            edit_Song_Form.ArtistTextBox.Text = ((Song)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag).Artist.Text;    // Φόρτωση των υπάρχων στοιχείων
            edit_Song_Form.AlbumTextBox.Text = ((Song)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag).Album.Text;      // στα Textbox, για επεξεργασία
            edit_Song_Form.DateTextBox.Text = ((Song)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag).Date.Text;        //
            edit_Song_Form.GenreTextBox.Text = ((Song)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag).Genre.Text;      //

            edit_Song_Form.FinalButton.Font = new Font("Microsoft Sans Serif", 6);                                              //                           
            edit_Song_Form.FinalButton.Text = "Ενημέρωση";                                                                      // Διάφορες μετατροπές για
            edit_Song_Form.StartPosition = FormStartPosition.Manual;                                                            // τη σωστή λειτουργία του
            edit_Song_Form.Location = new Point(this.Location.X + this.Width / 2 - edit_Song_Form.Width / 2, this.Location.Y);  // του Form2
            edit_Song_Form.Show();                                                                                              //
        }

        private void Delete_Song(object sender, EventArgs e) //Μέθοδος για διαγραφή κομματιών
        {
            if (MessageBox.Show("Θέλετε σίγουρα να διαγράψετε το συγκεκριμένο κομμάτι;", "Music Player", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                connection.Open();                                                                                      // Διαγραφή του κομματιού
                SQLiteCommand DeleteCommand = new SQLiteCommand("Delete from Songs where SongID=@id", connection);      // από τη βάση δεδομένων
                //Επειδή η "Delete_Song" καλείται από το ContextMenuStrip του Groupbox του αντικειμένου, χρησιμοποιούμε τη παρακάτω διαδικασία, για να "φτάσουμε" στο αντικείμενο
                DeleteCommand.Parameters.AddWithValue("id", ((Song)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag).ID); //
                DeleteCommand.ExecuteNonQuery();                                                                                                             //

                SQLiteCommand DeleteConCommand = new SQLiteCommand("Delete from PlaylistSongConnection where SongID=@id", connection);                          // Διαγραφή του κομματιού
                DeleteConCommand.Parameters.AddWithValue("id", ((Song)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag).ID); // απο το Table των συνδέσεων
                DeleteConCommand.ExecuteNonQuery();                                                                                                             // με τις playlist
                connection.Close();                                                                                                                             //

                if (song_list[index].ID == ((Song)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag).ID)  // Εαν το τραγούδι που παίζει
                {                                                                                                                           // είναι αυτό που διαγράφετε
                    PlayButton.Enabled = false;                                 //
                    StopButton.Visible = false;                                 //
                    StartTime.Visible = false;                                  //
                    FinishTime.Visible = false;                                 //
                    progressBar1.Visible = false;                               //
                    PlayButton.BackgroundImage = Resources.PlayButtonImage;     //
                    SongImage.Image = null;                                     //
                    SongImage.Refresh();                                        // Αλλαγές για UI
                    TitleLabel.Text = "";                                       //
                    TitleListLabel.Text = "";                                   //
                    FavouriteButton.Visible = false;                            //
                    MediaPlayer.Ctlcontrols.stop();                             //
                }
                SongsFlowPanel.Controls.Remove((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl);  // Αφαίρεση του κομματιού
                SongsFlowPanel.Refresh();                                                                                       // από το UI
                song_list.Remove((Song)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag);    // και απο τη λίστα
            }
        }
        private void Add_to_Playlist(object sender, EventArgs e) //Μέθοδος για προσθήκη κομματιού σε playlist
        {
            connection.Open();                                                          //
            String insertSQL = "Insert into PlaylistSongConnection(" +                  // Δημιουργία σύνδεσης 
                                "PlaylistName,SongID) " +                               // μεταξύ playlist & κομματιού
                                "values(@playlistname,@songid)";                        // στη βάση δεδομένων
            SQLiteCommand InsertCommand = new SQLiteCommand(insertSQL, connection);     //
            InsertCommand.Parameters.AddWithValue("songid", ((Song)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Tag).SourceControl).Tag).ID.ToString());
            InsertCommand.Parameters.AddWithValue("playlistname", sender);              //
            InsertCommand.ExecuteNonQuery();                                            //
            connection.Close();                                                         //

            ((ToolStripDropDownMenu)((ToolStripMenuItem)sender).Owner).Items.RemoveByKey(sender.ToString()); //Διαγραφή της επιλογής της playlist που μόλις επιλέχθηκε
        }

        public void Add_Song_Button(object sender, EventArgs e) //Μέθοδος για προσθήκη κομματιού
        {
            SongDialog.Filter = "Audio Files |*.mp3;*wav";      //Αποδοχή μόνο ηχητικών αρχείων

            if (SongDialog.ShowDialog() == DialogResult.OK)                 // Άνοιγμα file dialog
            {                                                               //
                Form2 AddSongForm = new Form2(this);                        //
                AddSongForm.NameTextBox.Text = SongDialog.SafeFileName;     // Άνοιγμα φόρμας για 
                AddSongForm.NameTextBox.SelectAll();                        // δημιουργία κομματιού
                AddSongForm.StartPosition = FormStartPosition.Manual;       //
                AddSongForm.Location = new Point(this.Location.X + this.Width / 2 - AddSongForm.Width / 2, this.Location.Y); //
                AddSongForm.Show();                                         //
            }
        }
        private void Remove_Song(object sender, EventArgs e) //Μέθοδος για αφαίρεση κομματιού απο τη αντίστοιχη playlist
        {
            if (MessageBox.Show("Θέλετε σίγουρα να αφαιρέσετε το κομμάτι από τη Playlist ;", "Music Player", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                connection.Open();  //Διαγραφή της σύνδεσης Playlist με κομματιού
                SQLiteCommand DeleteCommand = new SQLiteCommand("Delete from PlaylistSongConnection where PlaylistName = @name and SongID= @songid", connection);
                DeleteCommand.Parameters.AddWithValue("songid", ((Song)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag).ID.ToString());
                DeleteCommand.Parameters.AddWithValue("name", ((ToolStripMenuItem)sender).Name);
                DeleteCommand.ExecuteNonQuery();
                connection.Close();

                SongsFlowPanel.Controls.Remove((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl);  // Αφαίρεση κομματιού απο 
                song_list.Remove((Song)((GroupBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Tag);    // UI και απο λίστα
                SongsFlowPanel.Refresh();                                                                                       //
            }
        }

        private void Play_Button_Click(object sender, EventArgs e) //Μέθοδος όταν πατάει το κουμπί αναπαραγωγής
        {
            play = !play;
            if (play)
            {
                this.PlayButton.BackgroundImage = Resources.PauseButtonImage;   // Αλλαγή εικόνας για UI
                MediaPlayer.Ctlcontrols.play();                                 // Ξεκινάει/συνεχίζει τη αναπαραγώγη
            }
            else
            {
                this.PlayButton.BackgroundImage = Resources.PlayButtonImage;    // Αλλαγή εικόνας για UI
                MediaPlayer.Ctlcontrols.pause();                                // διακόπτει τη αναπαραγώγη
            }
        }

        private void Random_Button_Click(object sender, EventArgs e) //Μέθοδος όταν πατάει το κουμπί τυχαίας αναπαραγωγής
        {
            random = !random;
            if (random)
            {
                RandomButton.BackgroundImage = Resources.RandomButtonClickedImage;   // Αλλαγή εικόνας για UI
            }
            else
            {
                RandomButton.BackgroundImage = Resources.RandomButtonImage;          // Αλλαγή εικόνας για UI
            }
        }

        private void Favourite_Button_Click(object sender, EventArgs e) //Μέθοδος όταν πατάει το κουμπί προσθήκης στα αγαπημένα
        {
            favourite = !favourite;

            connection.Open();                                                  //
            String updateSQL = "Update Songs " +                                //
                                "set Liked=@liked " +                           //
                                "where SongID = @id";                           // Ενημέρωση τιμής αγαπημένου, κομματιού
            SQLiteCommand command = new SQLiteCommand(updateSQL, connection);   // στη βάση δεδομένων
            command.Parameters.AddWithValue("id", CurrentSong.ID);              //
            command.Parameters.AddWithValue("liked", favourite);                //
            command.ExecuteNonQuery();                                          //
            connection.Close();                                                 //

            CurrentSong.liked = favourite;

            if (favourite)
            {
                FavouriteButton.BackgroundImage = Resources.FavouriteButtonClickedImage;   // Αλλαγή εικόνας για UI

                if (favouritePlaylist)      // Εάν είναι "ανοιχτό" το playlist των αγαπημένων, προσθήκη του τραγουδιού
                {
                    int? NewDate;                                                                  // Έλεγχος εάν έχει δωθεί
                    if (int.TryParse(CurrentSong.Date.Text, out int value)) { NewDate = value; }   // ημερομηνία κυκλοφορίας
                    else { NewDate = null; }                                                       //
                    Create_Song(CurrentSong.ID, CurrentSong.Title.Text, CurrentSong.Artist.Text, CurrentSong.Album.Text, NewDate, CurrentSong.Genre.Text, CurrentSong.liked, CurrentSong.timesplayed, CurrentSong.photo, CurrentSong.path);
                    index = song_list.Count - 1;    //Δημιουργία αντικειμένου και επιλογή του αντίστοιχου index
                }
            }
            else
            {
                FavouriteButton.BackgroundImage = Resources.FavouriteButtonImage;          // Αλλαγή εικόνας για UI

                if (favouritePlaylist)                                                     // Εάν είναι "ανοιχτό" το playlist των αγαπημένων
                {                                                                          // διαγραφή του τραγουδιού
                    try { SongsFlowPanel.Controls.Remove(song_list[index].Box); } catch { } //
                    SongsFlowPanel.Controls.Remove(CurrentSong.Box);                       //
                    song_list.Remove(CurrentSong);                                         //
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e) //Μέθοδος όταν πατάει το κουμπί επιστροφής
        {
            PlaylistsFlowPanel.BringToFront();  //
            favouritePlaylist = false;          //
            BackButton.Visible = false;         //
            TitleLabelSong.Visible = false;     // Αλλαγές στο UI
            ArtistListLabel.Visible = false;    // 
            DateListLabel.Visible = false;      //
            GenreListLabel.Visible = false;     //
            AlbumListLabel.Visible = false;     //
        }

        private void StopButton_Click(object sender, EventArgs e) //Μέθοδος όταν πατάει το κουμπί διακοπής αναπαραγωγής
        {
            PlayButton.Enabled = false;                             //
            NextButton.Enabled = false;                             //
            PreviousButton.Enabled = false;                         //
            StopButton.Visible = false;                             //
            FavouriteButton.Visible = false;                        //
            StartTime.Visible = false;                              // Αλλαγές στο UI
            FinishTime.Visible = false;                             //
            progressBar1.Visible = false;                           //
            PlayButton.BackgroundImage = Resources.PlayButtonImage; //
            SongImage.Image = null;                                 //
            SongImage.Refresh();                                    //
            TitleLabel.Text = "";                                   //
            TitleListLabel.Text = "";                               //

            MediaPlayer.Ctlcontrols.stop();                         // Διακοπή αναπαραγωγής κομματιού
        }

        private void PreviousButton_Click(object sender, EventArgs e) //Μέθοδος όταν πατάει το κουμπί προηγούμενου κομματιού
        {
            if (random)                                                                                         //
            {                                                                                                   // Εάν είναι ενεργοποιημένη η 
                int randomindex = r.Next(song_list.Count);                                                  // τυχαία αναπαραγωγή,
                while (randomindex == index && song_list.Count > 1) { randomindex = r.Next(song_list.Count); }  // επιλέγει τυχαίο κομμάτι από
                index = randomindex;                                                                            // τη λίστα
                song_list[index].PlayButton.PerformClick();                                                     //
            }                                                                                                   //
            else                                                    //
            {                                                       //
                if (index > 0)                                      // Επιλέγει το επόμενο κομμάτι
                {                                                   // και ξεκινάει η αναπαραγωγή
                    index--;                                        //
                    song_list[index].PlayButton.PerformClick();     //
                }                                                   //
            }                                                       //
        }

        private void NextButton_Click(object sender, EventArgs e) //Μέθοδος όταν πατάει το κουμπί επόμενου κομματιού
        {
            if (random)                                                                                         //
            {                                                                                                   // Εάν είναι ενεργοποιημένη η 
                int randomindex = r.Next(song_list.Count);                                                      // τυχαία αναπαραγωγή, 
                while (randomindex == index && song_list.Count > 1) { randomindex = r.Next(song_list.Count); }  // επιλέγει τυχαίο κομμάτι από
                index = randomindex;                                                                            // τη λίστα
                song_list[index].PlayButton.PerformClick();                                                     //
            }                                                                                                   //
            else
            {                                                       //
                if (index < song_list.Count - 1)                    // Εάν δεν είναι το 
                {                                                   // τελευταίο κομμάτι  
                    index++;                                        // επιλέγει το επόμενο
                    song_list[index].PlayButton.PerformClick();     // για αναπαραγωγή
                }                                                   //
                else                                                //
                {                                                   //
                    index = 0;                                      // Εαν είναι το τελευταίο
                    song_list[index].PlayButton.PerformClick();     // κομμάτι, πάει από τη αρχή
                }                                                   //
            }
        }

        private void VolumeBar_Scroll(object sender, EventArgs e) //Μέθοδος όταν πατάει τη μπάρα ήχου
        {
            VolumeLabel.Text = VolumeBar.Value.ToString() + "%";    // Αλλάζει την ένταση ήχου
            MediaPlayer.settings.volume = VolumeBar.Value;          // με βάση την μπάρα
        }

        private void progressBar1_MouseDown(object sender, MouseEventArgs e) //Μέθοδος όταν πατάει τη μπάρα χρόνου
        {
            MediaPlayer.Ctlcontrols.currentPosition = MediaPlayer.currentMedia.duration * e.X / progressBar1.Width; // Αλλάζει το χρόνο στο οποίο είναι το 
            progressBar1.Value = (int)(((((float)e.X) / progressBar1.Width) * 100));                                // τραγούδι με βάση που πάτησε στη μπάρα
        }

        private void SongsFlowPanel_Resize(object sender, EventArgs e) //Μέθοδος όταν γίνεται resize το παράθυρο
        {
            foreach (Song song in song_list)                                            //
            {                                                                           // Ταιρίαζει το πλάτος των κομματιών,
                song.Box.Size = new Size(SongsFlowPanel.Width - 20, song.Box.Height);   // με της φόρμας
            }                                                                           //
        }

        private void MediaPlayer_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e) //Μέθοδος όταν αλλάζει κατάσταση το MediaPlayer
        {
            if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying) // Εάν η κατάσταση ανανεώθηκε στο ότι ξεκίνησε να παίζει τώρα κομμάτι
            {
                progressBar1.Maximum = (int)MediaPlayer.Ctlcontrols.currentItem.duration;
                int Duration = (int)MediaPlayer.Ctlcontrols.currentItem.duration;
                FinishTime.Text = ((Duration / 60).ToString()) + ":";
                if ((Duration % 60) > 9) { FinishTime.Text += (Duration % 60).ToString(); }
                else { FinishTime.Text += "0" + (Duration % 60).ToString(); }
                timer2.Start();
                StartTime.Visible = true;
                FinishTime.Visible = true;
                progressBar1.Visible = true;
                PlayButton.Enabled = true;                                  //
                PlayButton.BackgroundImage = Resources.PauseButtonImage;    //
                NextButton.Enabled = true;                                  // Αλλαγές σε ιδιότητες για ορθή
                PreviousButton.Enabled = true;                              // λειτουργία του UI
                StopButton.Visible = true;                                  //
                FavouriteButton.Visible = true;                             //
                play = true;
            }
            else if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused) // Εάν η κατάσταση ανανεώθηκε στο ότι έγινε παύση κομματιού
            {
                timer2.Stop();
            }
            else if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped) // Εάν η κατάσταση ανανεώθηκε στο ότι έγινε διακοπή κομματιού
            {
                timer1.Stop();
                progressBar1.Value = 0;
            }
            else if(MediaPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded) // Εάν η κατάσταση ανανεώθηκε στο ότι τελείωσε το κομμάτι
            {
                if (random)                                                                                         
                {                                                                                                   
                    int randomindex = r.Next(song_list.Count);                                                      // Εάν είναι ενεργοποιημένη η 
                    while (randomindex == index && song_list.Count > 1) { randomindex = r.Next(song_list.Count); }  // τυχαία αναπαραγωγή, 
                    index = randomindex;                                                                            // επιλέγει τυχαίο κομμάτι από
                    song_list[index].PlayButton.PerformClick();                                                     // τη λίστα
                }
                else
                {   
                    if (index < song_list.Count - 1)
                    {                                                   // Εάν δεν είναι το 
                        index++;                                        // τελευταίο κομμάτι 
                        song_list[index].PlayButton.PerformClick();     // επιλέγει το επόμενο 
                        timer1.Enabled = true;                          // για αναπαραγωγή
                    }                                                   //
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e) //Μέθοδος του 1ου Timer
        {
            MediaPlayer.Ctlcontrols.play();     // Λόγω μη σωστής λειτουργίας του Windows Media Player
            timer1.Enabled = false;             // κάνει play, μέχρι να ξεκινήσει το κομμάτι
        }

        private void timer2_Tick(object sender, EventArgs e) //Μέθοδος του 2ου Timer
        {
            if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying) // Εάν η κατάσταση του Player ισούται με ότι ξεκίνησε να παίζει τώρα κομμάτι
            {
                progressBar1.Value = (int)MediaPlayer.Ctlcontrols.currentPosition;          //Θέτει τη τιμή της μπάρας, όσο είναι το τραγούδι

                int Duration = (int)MediaPlayer.Ctlcontrols.currentPosition;                //
                StartTime.Text = ((Duration / 60).ToString()) + ":";                        // Λειτουργίες, για να δουλευούν ορθά
                if ((Duration % 60) > 9) { StartTime.Text += (Duration % 60).ToString(); }  // τα Label χρόνων (λεπτών) όταν ακούγεται το τραγούδι
                else { StartTime.Text += "0" + (Duration % 60).ToString(); }                //

            }
        }
    }
}

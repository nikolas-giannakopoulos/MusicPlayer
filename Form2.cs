using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form2 : Form //Φόρμα για προσθήκη/επεξεργασία μουσικού κομματιού
    {
        SQLiteConnection connection;                        //
        Form1 form1;                                        //
        public int idcheck;                                 //
        bool success;                                       // Ορισμοί για χρήση από την Form2
        OpenFileDialog PhotoDialog = new OpenFileDialog();  //
        public String PhotoPath;                            //
        int? DateNumber;                                    //
        public Form2(Form1 form1) //Constructor της Form2, Attribute η Form1, από τη οποία κλήθηκε η Form2 
        {
            InitializeComponent(); 
            this.form1 = form1;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection("Data source=musicplayer.db;Version=3");
            form1.Enabled = false;  //Απενεργοποίηση της Form1, για να μην μπορεί να τη χρησιμοποιήσει ο χρήστης
            this.FormClosing += new FormClosingEventHandler(Form_Closing); //Ορισμός συνάρτησης, να καλείται όταν η φόρμα κλείνει
        }
        public void Photo_Choice_Button_Click(object sender, EventArgs e) //Συνάρτηση για επιλογή φωτογραφίας από τα αρχεία του χρήστη, για το κομμάτι
        {
            PhotoDialog.Filter = "Images |*.png;*jpg";                                                                          // 
            if (PhotoDialog.ShowDialog() == DialogResult.OK)                                                                    //
            {                                                                                                                   //
                PhotoLabel.Text = PhotoDialog.SafeFileName;                                                                     //
                PhotoPath = PhotoDialog.FileName;                                                                               //
                PhotoLabel.Visible = true;                                                                                      //
                PhotoRemoveButton.Location = new Point(PhotoLabel.Location.X + PhotoLabel.Width, PhotoRemoveButton.Location.Y); // FileDialog που επιλέγει τη φωτογραφία
                PhotoRemoveButton.Visible = true;                                                                               // αλλίως θέτει κενή τιμη
            }                                                                                                                   //
            else                                                                                                                //
            {                                                                                                                   //
                PhotoPath = null;                                                                                               // 
            }                                                                                                                   //
        }                                                                                                                       //

        private void Form_Closing(object sender, CancelEventArgs e) //Συνάρτηση για κλείσιμο Form2
        {
            if (success)                    //
            {                               //
                form1.Enabled = true;       // Εάν γινεί επιτυχείς εγγραφή, ενεργοποιεί ξανά τη Form1,
                form1.Focus();              // και εστιάζει σε αυτή
            }                               //
            else
            {
                if (MessageBox.Show("Θέλετε σίγουρα να ακυρώσετε την προσθήκη;", "Music Player", MessageBoxButtons.YesNo) == DialogResult.No)   //
                {                                                                                                                               //
                    e.Cancel = true;                                                                                                            //
                }                                                                                                                               // Εάν ο χρήστης θέλει να ακυρώσει τη εγγραφη
                else                                                                                                                            // πετάγετε ένα μήνυμα με Ναι/Όχι επιλογή. Εάν
                {                                                                                                                               // πατήσει όχι ακυρώνεται η ενέργεια, διαφορετικά
                    form1.Enabled = true;                                                                                                       // γίνεται ότι και πάνω
                    form1.Focus();                                                                                                              //
                }                                                                                                                               //
            }
        }

        private void Final_Button_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "" && ArtistTextBox.Text != "" && (DateTextBox.Text == "" || DateTextBox.Text == "-" || int.TryParse(DateTextBox.Text, out int value) && value < 2025)) // Έλεγχος σωστόν δεδομένων από τον χρήστη
            {
                if (form1.editSongFlag) //Εάν η φόρμα που άνοιξε, είναι για επεξεργασία κομματιού
                {
                    if (AlbumTextBox.Text == "" || AlbumTextBox.Text == "-") { AlbumTextBox.Text = null; }      //
                    if (DateTextBox.Text == "" || DateTextBox.Text == "-") { DateNumber = null; }               // Αλλαγή κάποιον τιμών για να ταιριάζουν με
                    else { DateNumber = int.Parse(DateTextBox.Text); }                                          // τη βαση δεδομενων
                    if (GenreTextBox.Text == "" || GenreTextBox.Text == "-") { GenreTextBox.Text = null; }      //

                    connection.Open();
                    String updateSQL = "Update Songs " +                                                        //           
                                        "set Title=@title, " +                                                  //
                                        "Artist = @artist, " +                                                  //
                                        "Album = @album, " +                                                    //
                                        "Date = @date, " +                                                      //
                                        "Genre = @genre, " +                                                    // 
                                        "Photo = @photo " +                                                     //
                                        "where SongID = @id";                                                   //
                    SQLiteCommand command = new SQLiteCommand(updateSQL, connection);                           //
                    command.Parameters.AddWithValue("title", NameTextBox.Text);                                 // Ενημέρωση της εγγραφής του κομματιού
                    command.Parameters.AddWithValue("artist", ArtistTextBox.Text);                              // στη βάση δεδομένων
                    command.Parameters.AddWithValue("album", AlbumTextBox.Text);                                //
                    command.Parameters.AddWithValue("date", DateNumber);                                        //
                    command.Parameters.AddWithValue("genre", GenreTextBox.Text);                                //
                    command.Parameters.AddWithValue("photo", PhotoPath);                                        //
                    command.Parameters.AddWithValue("id", idcheck);                                             //
                    command.ExecuteNonQuery();                                                                  //
                    connection.Close();                                                                         //                                                                 //

                    foreach (Song song in form1.song_list)                                                      //
                    {                                                                                           //
                        if (song.Title.Text == form1.DBNameReference)                                           //
                        {                                                                                       //
                            song.Title.Text = NameTextBox.Text;                                                 //
                            song.Artist.Text = ArtistTextBox.Text;                                              // Αλλαγή τιμών και στο αντικείμενο
                            song.Album.Text = AlbumTextBox.Text;                                                //
                            song.Date.Text = DateNumber.ToString();                                             //
                            song.Genre.Text = GenreTextBox.Text;                                                //
                            song.photo = PhotoPath;                                                             //
                            break;                                                                              //
                        }                                                                                       //
                    }
                    success = true;
                    MessageBox.Show("H playlist σας ενημερώθηκε με επιτυχία", "Music Player");
                    form1.editSongFlag = false;
                    this.Close();
                }
                else //Εάν η φόρμα που άνοιξε, είναι για καταχώρηση νέου κομματιού
                {
                    if (AlbumTextBox.Text == "") { AlbumTextBox.Text = null; }   //
                    if (DateTextBox.Text == "") { DateNumber = null; }           // Αλλαγή κάποιον τιμών για να ταιριάζουν με
                    else { DateNumber = int.Parse(DateTextBox.Text); }           // με τη βάση δεδομένων
                    if (GenreTextBox.Text == "") { GenreTextBox.Text = null; }   //

                    String insertSQL = "Insert into Songs(" +                                                               //
                                           "Title,Artist,Album,Date,Genre,Liked,TimesPlayed,Photo,Path) " +                 //
                                           "values(@title,@artist,@album,@date,@genre,@liked,@timesplayed,@photo,@path)";   //
                    connection.Open();                                                                                      //
                    SQLiteCommand command = new SQLiteCommand(insertSQL, connection);                                       //
                    command.Parameters.AddWithValue("title", NameTextBox.Text);                                             //
                    command.Parameters.AddWithValue("artist", ArtistTextBox.Text);                                          //
                    command.Parameters.AddWithValue("date", DateNumber);                                                    // Εγγραφή του κομματιού
                    command.Parameters.AddWithValue("album", AlbumTextBox.Text);                                            // στη βαση δεδομενων
                    command.Parameters.AddWithValue("genre", GenreTextBox.Text);                                            //
                    command.Parameters.AddWithValue("liked", false);                                                        //
                    command.Parameters.AddWithValue("timesplayed", 0);                                                      //
                    command.Parameters.AddWithValue("photo", PhotoPath);                                                    //
                    command.Parameters.AddWithValue("path", form1.SongDialog.FileName);                                     //
                    command.ExecuteNonQuery();                                                                              //
                    connection.Close();                                                                                     //

                    MessageBox.Show("Το μουσικό κομμάτι σας καταχωρήθηκε με επιτυχία", "Music Player");
                    success = true;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Τα στοιχεία δεν είναι έγκυρα", "Music Player");
            }
        }
        private void Cancel_Button_Click(object sender, EventArgs e) //Κουμπί για κλείσιμο φόρμας 
        {
            this.Close();
        }

        private void PhotoRemoveButton_Click(object sender, EventArgs e) //Κουμπί για αφαίρεση φωτογραφίας που εχει/ειχε επιλεχθεί
        {
            PhotoLabel.Visible = false;
            PhotoRemoveButton.Visible = false;
            PhotoPath = null;
        }
    }
}

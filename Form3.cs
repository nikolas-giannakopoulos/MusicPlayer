using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form3 : Form //Φόρμα για προσθήκη/επεξεργασία playlist
    {
        SQLiteConnection connection;                        //
        Form1 form1;                                        //
        bool success;                                       // Ορισμοί για χρήση απο την Form3
        OpenFileDialog PhotoDialog = new OpenFileDialog();  //
        public String PhotoPath = "";                       //
        public Form3(Form1 form1) //Constructor της Form2, Attribute η Form1, από τη οποία κλήθηκε η Form3 
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection("Data source=musicplayer.db;Version=3");
            form1.Enabled = false; //Απενεργοποίηση της Form1, για να μην μπορεί να τη χρησιμοποιήσει ο χρήστης
            this.FormClosing += new FormClosingEventHandler(Form_Closing); //Ορισμός συνάρτησης, να καλείται όταν η φόρμα κλείνει
        }
        private void Form_Closing(object sender, CancelEventArgs e) //Συνάρτηση για κλείσιμο Form3
        {
            if (success)                //
            {                           //
                form1.Enabled = true;   // Εάν γινεί επιτυχής εγγραφή, ενεργοποιεί ξανά τη Form1,
                form1.Focus();          // και εστιαζει σε αυτη
            }                           //
            else
            {                                                                                                                                   //
                if (MessageBox.Show("Θέλετε σίγουρα να ακυρώσετε την προσθήκη;", "Music Player", MessageBoxButtons.YesNo) == DialogResult.No)   //
                {                                                                                                                               //
                    e.Cancel = true;                                                                                                            // Εάν ο χρήστης θέλει να ακυρώσει τη εγγραφη
                }                                                                                                                               // πετάγετε ένα μήνυμα με Ναι/Όχι επιλογή. Εάν
                else                                                                                                                            // πατήσει όχι ακυρώνεται η ενέργεια, διαφορετικά
                {
                    form1.editPlaylistFlag = false;                                                                                             // γίνεται ότι και πάνω
                    form1.Enabled = true;                                                                                                       //
                    form1.Focus();                                                                                                              //
                }                                                                                                                               //
            }                                                                                                                                   //
        }

        private void FinalButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "") // Έλεγχος σωστόν δεδομένων από τον χρήστη
            {
                if (form1.editPlaylistFlag) //Εάν η φόρμα που άνοιξε, είναι για επεξεργασία playlist
                {
                    bool flag = true;                                                                           //
                    foreach (Playlist playlist in form1.playlists_list)                                         //
                    {                                                                                           //
                        if (playlist.Title.Text == NameTextBox.Text && NameTextBox.Text!=form1.DBNameReference) //
                        {                                                                                       //  Ελέγχει εάν υπαρχει ήδη playlist με
                            MessageBox.Show("Το συγκεκριμένο όνομα ανήκει σε διαφορετική Playlist");            //  το συγκεκριμένο όνομα, και πετάει 
                            flag = false;                                                                       //  αντίστοιχο μήνυμα
                            break;                                                                              //
                        }                                                                                       //
                    }                                                                                           //

                    if (flag) {                                                                 
                        connection.Open();                                                          //
                        String updateSQL = "Update Playlists " +                                    //
                                           "set Name=@name, " +                                     //
                                           "Photo=@photo " +                                        //
                                           "where Name=@defaultname";                               // Ενημέρωση της εγγραφής της playlist
                        SQLiteCommand command = new SQLiteCommand(updateSQL, connection);           // στη βάση δεδομένων
                        command.Parameters.AddWithValue("name", NameTextBox.Text);                  //
                        command.Parameters.AddWithValue("photo", PhotoPath);                        //
                        command.Parameters.AddWithValue("defaultname", form1.DBNameReference);      //
                        command.ExecuteNonQuery();                                                  //

                        String UpdateConSQL = "Update PlaylistSongConnection " +                    //
                                              "set PlaylistName=@name " +                           //
                                              "where PlaylistName=@defaultname";                    // Ενημέρωση της εγγραφής της playlist
                        SQLiteCommand command2 = new SQLiteCommand(UpdateConSQL, connection);       // στη βαση δεδομενων για τη συνδεση μεταξυ των
                        command2.Parameters.AddWithValue("name", NameTextBox.Text);                 // δυο Table (κομματιων & playlist)
                        command2.Parameters.AddWithValue("defaultname", form1.DBNameReference);     //
                        command2.ExecuteNonQuery();                                                 //
                        connection.Close();                                                         //

                        foreach (Playlist playlist in form1.playlists_list)                         //
                        {                                                                           //
                            if (playlist.Title.Text == form1.DBNameReference)                       //
                            {                                                                       //
                                playlist.Title.Text = NameTextBox.Text;                             // Αλλαγή τιμών και στο αντικείμενο
                                if (PhotoPath != "")                                                //
                                {                                                                   // Εάν έχει δωθεί εικόνα τη φορτώνει
                                    playlist.Picture.Load(PhotoPath);                               // διαφορετικά θέτει προκαθορισμένη 
                                }                                                                   // τύπου unavailable
                                else                                                                //
                                {                                                                   //
                                    playlist.Picture.Image = Properties.Resources.UnavailablePhoto; //
                                    playlist.Picture.Refresh();                                     //
                                }                                                                   //
                                break;                                                              //
                            }                                                                       //
                        }                                                                           //

                        success = true;                                                         
                        MessageBox.Show("H playlist σας ενημερώθηκε με επιτυχία", "Music Player");
                        form1.editPlaylistFlag = false;
                        this.Close();
                    }
                }
                else //Εάν η φόρμα που άνοιξε, είναι για καταχώρηση νέας playlist
                {
                    bool flag = true;                                                   //
                    foreach (Playlist playlist in form1.playlists_list)                 //
                    {                                                                   //
                        if (playlist.Title.Text == NameTextBox.Text)                    // Ελέγχει εάν υπαρχει ήδη playlist με
                        {                                                               // το συγκεκριμένο όνομα, και πετάει 
                            MessageBox.Show("Υπάρχει ήδη Playlist με αυτό το όνομα");   // αντίστοιχο μήνυμα
                            flag = false;                                               //
                            break;                                                      //
                        }                                                               //
                    }                                                                   //

                    if (flag)                                                                   
                    {
                        connection.Open();                                                              //
                        String insertSQL = "Insert into Playlists(" +                                   //
                                           "Name,Photo) " +                                             //
                                           "values(@name,@photo)";                                      //
                        SQLiteCommand command = new SQLiteCommand(insertSQL, connection);               // Εγγραφή playlist 
                        command.Parameters.AddWithValue("name", NameTextBox.Text);                      // στη βαση δεδομένων
                        command.Parameters.AddWithValue("photo", PhotoPath);                            //
                        command.ExecuteNonQuery();                                                      //
                        MessageBox.Show("H playlist σας καταχωρήθηκε με επιτυχία", "Music Player");     //
                        connection.Close();                                                             //
                        
                        success = true;                                                                 //
                        form1.Create_Playlist(NameTextBox.Text, PhotoPath);                            // Δημιουργία Playlist (αντικειμένου) με τα στοιχεία
                        this.Close();                                                                   // στη Form1
                    }
                }
            }
            else
            {
                MessageBox.Show("Τα στοιχεία δεν είναι έγκυρα", "Music Player");
            }
            
        }


        public void PhotoButton_Click(object sender, EventArgs e)                                                               //
        {                                                                                                                       //
            PhotoDialog.Filter = "Images |*.png;*jpg";                                                                          //
            if (PhotoDialog.ShowDialog() == DialogResult.OK)                                                                    //
            {                                                                                                                   //
                PhotoLabel.Text = PhotoDialog.SafeFileName;                                                                     //
                PhotoPath = PhotoDialog.FileName;                                                                               // 
                PhotoLabel.Visible = true;                                                                                      // OpenFileDialog που επιλέγει τη φωτογραφία
                PhotoRemoveButton.Location = new Point(PhotoLabel.Location.X + PhotoLabel.Width, PhotoRemoveButton.Location.Y); // αλλιώς κενη τιμή
                PhotoRemoveButton.Visible = true;                                                                               //
            }                                                                                                                   //
            else                                                                                                                //
            {                                                                                                                   //
                PhotoPath = "";                                                                                                 //
            }                                                                                                                   //
        }                                                                                                                       //

        private void CancelButton_Click(object sender, EventArgs e) //Κουμπί για κλείσιμο φόρμας 
        {
            this.Close();                                               
        }                                                               

        private void PhotoRemoveButton_Click(object sender, EventArgs e) //Κουμπί για αφαίρεση φωτογραφίας που εχει/ειχε επιλεχθεί
        {
            PhotoLabel.Visible = false;
            PhotoRemoveButton.Visible = false;
            PhotoPath = "";
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicPlayer
{
    public class Song
    {
        public int ID;                           // Το SongID του κομματιού, για τον εντοπισμό στη βάση δεδομένων
        public Label Title = new Label();        // Ο τίτλος του κομματιού
        public Label Artist = new Label();       // Ο καλλιτέχνης του κομματιού
        public Label Album = new Label();        // Το άλμπουμ του κομματιόυ (όχι απαραίτητη καταχώρηση απο τον χρήστη)
        public Label Date = new Label();         // Η ημερομηνία κυκλοφορίας του κομματιόυ (όχι απαραίτητη καταχώρηση απο τον χρήστη)
        public Label Genre = new Label();        // Το είδος μουσικής του κομματιόυ (όχι απαραίτητη καταχώρηση απο τον χρήστη)
        public bool liked;                       // Boolean εάν ο χρήστης έχει βάλει το κομμάτι στα αγαπημένα
        public int timesplayed;                  // Πόσες φορές έχει πεχτεί ένα κομμάτι, για τη υλοποιήση της Top Songs playlist
        public String photo;                     // Η τοποθεσία του αρχείου της εικόνας του κομματιού, στα αρχεία του υπολογιστή
        public String path;                      // Η τοποθεσία του αρχείου του κομματιού, στα αρχεία του υπολογιστή
        public Button PlayButton = new Button(); // Το κουμπί για αναπαραγωγή του κομματιού

        public GroupBox Box = new GroupBox();    //

        public Song(int ID,String title, String artist, String album, Nullable<int> date, String genre, Boolean liked, int timesplayed, String photo, String path, EventHandler PlayButtonClick) //Constructor του κομματιού
        {
            this.ID = ID;                    // Ταύτιση του ID της κλάσης, με το Attribute
            this.liked = liked;              // Ταύτιση του liked της κλάσης, με το Attribute
            this.path = path;                // Ταύτιση του path της κλάσης, με το Attribute
            this.timesplayed = timesplayed;  // Ταύτιση του timesplayed της κλάσης, με το Attribute
            this.photo = photo;              // Ταύτιση του photo της κλάσης, με το Attribute

            this.Box.Tag = this;                              //
            this.Box.Size = new Size(750, 30);                // Αρχικοποίηση του groupbox
            this.Box.Margin = new Padding(10, 5, 3, 3);       //
            this.Box.BackColor = Color.FromArgb(35, 35, 35);  //

            this.Title.Text = title;                                   //
            this.Title.ForeColor = Color.White;                        //
            this.Title.Location = new Point(31, 0);                    //
            this.Title.Size = new Size(151, 30);                       // Αρχικοποίηση του label τίτλου
            this.Title.TextAlign = ContentAlignment.MiddleCenter;      //
            this.Title.Anchor = AnchorStyles.Top;                      //
            this.Title.Font = new Font("Microsoft Sans Serif", 11);    //
            this.Box.Controls.Add(this.Title);                         // Προσθήκη στα controls του Groupbox

            this.Artist.Text = artist;                                 //
            this.Artist.ForeColor = Color.White;                       //
            this.Artist.Location = new Point(182, 0);                  //
            this.Artist.Size = new Size(148, 30);                      // Αρχικοποίηση του label καλλιτέχνη
            this.Artist.TextAlign = ContentAlignment.MiddleCenter;     //
            this.Artist.Anchor = AnchorStyles.Top;                     //
            this.Artist.Font = new Font("Microsoft Sans Serif", 11);   //
            this.Box.Controls.Add(this.Artist);                        // Προσθήκη στα controls του Groupbox

            String albumTest = "-";                                    // Εάν έχει δώσει τιμή ο χρήστης, εμφανίζεται αυτή
            if (album != "") albumTest = album;                        // διαφορετικά εμφαν΄ζεται παύλα (-)

            this.Album.Text = albumTest;                               //
            this.Album.ForeColor = Color.White;                        //
            this.Album.Location = new Point(330, 0);                   //
            this.Album.Size = new Size(125, 30);                       // Αρχικοποίηση του label άλμπουμ
            this.Album.TextAlign = ContentAlignment.MiddleCenter;      //
            this.Album.Anchor = AnchorStyles.Top;                      //
            this.Album.Font = new Font("Microsoft Sans Serif", 11);    //
            this.Box.Controls.Add(this.Album);                         // Προσθήκη στα controls του Groupbox

            String dateTest = "-";                                     // Εάν έχει δώσει τιμή ο χρήστης, εμφανίζεται αυτή
            if (date != null) dateTest = date.ToString();              // διαφορετικά εμφαν΄ζεται παύλα (-)

            this.Date.Text = dateTest;                                 //
            this.Date.ForeColor = Color.White;                         //
            this.Date.Location = new Point(455, 0);                    //
            this.Date.Size = new Size(98, 30);                         // Αρχικοποίηση του label ημερομηνίας κυκλοφορίας
            this.Date.TextAlign = ContentAlignment.MiddleCenter;       //
            this.Date.Anchor = AnchorStyles.Top;                       //
            this.Date.Font = new Font("Microsoft Sans Serif", 11);     //
            this.Box.Controls.Add(this.Date);                          // Προσθήκη στα controls του Groupbox

            String genreTest = "-";                                    // Εάν έχει δώσει τιμή ο χρήστης, εμφανίζεται αυτή
            if (genre != "") genreTest = genre;                        // διαφορετικά εμφαν΄ζεται παύλα (-)

            this.Genre.Text = genreTest;                               //
            this.Genre.ForeColor = Color.White;                        //
            this.Genre.Location = new Point(551, 0);                   //
            this.Genre.Size = new Size(116, 30);                       // Αρχικοποίηση του label είδους μουσικής
            this.Genre.TextAlign = ContentAlignment.MiddleCenter;      //
            this.Genre.Anchor = AnchorStyles.Top;                      //
            this.Genre.Font = new Font("Microsoft Sans Serif", 11);    //
            this.Box.Controls.Add(this.Genre);                         // Προσθήκη στα controls του Groupbox

            this.PlayButton.Name = title;                                            //
            this.PlayButton.Size = new Size(30, 30);                                 //
            this.PlayButton.Padding = new Padding(2, 2, 2, 2);                       //
            this.PlayButton.Location = new Point(0, 0);                              //
            this.PlayButton.Text = "";                                               //
            this.PlayButton.Click += PlayButtonClick;                                //
            this.PlayButton.BackgroundImageLayout = ImageLayout.Zoom;                // Αρχικοποίηση του κουμπιού αναπαραγωγής κομματιού
            this.PlayButton.BackgroundImage = Properties.Resources.PlayButtonImage;  //
            this.PlayButton.FlatStyle = FlatStyle.Flat;                              //
            this.PlayButton.FlatAppearance.BorderSize = 0;                           //
            this.PlayButton.FlatAppearance.MouseDownBackColor = Color.Black;         //
            this.PlayButton.Cursor = Cursors.Hand;                                   //
            this.PlayButton.Tag = this;                                              // Ορισμός του Tag του κουμπιού ως το αντίστοιχα αντικείμενο
            this.Box.Controls.Add(this.PlayButton);                                  // Προσθήκη στα controls του Groupbox
        }
    }
}

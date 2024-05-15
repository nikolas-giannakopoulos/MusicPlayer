using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicPlayer
{
    public class Playlist
    {
        public GroupBox Box = new GroupBox();           // GroupBox για "κουτι" playlist
        public PictureBox Picture = new PictureBox();   // Η εικόνα της playlist
        public Label Title = new Label();               // Ο τίτλος της playlist
        public Button Open_Button = new Button();       // To κουμπί για "άνοιγμα" της playlist

        public Playlist(String NameSource, String ImageSource, EventHandler OpenButtonClick, ContextMenuStrip PlaylistContextMenuStrip)  //Constructor της Playist
        {
            this.Box.Name = NameSource;                             //
            this.Box.ContextMenuStrip = PlaylistContextMenuStrip;   //
            this.Box.Tag = this;                                    //      
            this.Box.Size = new Size(175, 285);                     //  Αρχικοποίηση ιδιοτήτων του Groupbox
            this.Box.BackColor = Color.FromArgb(35, 35, 35);        //
            this.Box.Text = "";                                     //
            this.Box.Margin = new Padding(13, 13, 0, 0);            //

            if (ImageSource!="")                                            //
            {                                                               //
                this.Picture.Load(ImageSource);                             //
            }                                                               // Ελέγχει εάν υπάρχει διαθέσιμη φωτογραφία
            else                                                            // Αλλιώς ορίζει default εικόνα τύπου unavailable
            {                                                               // 
                this.Picture.Image = Properties.Resources.UnavailablePhoto; //
                this.Picture.Refresh();                                     //
            }                                                               //
            
            this.Picture.Location = new Point(15, 15);                      //
            this.Picture.Size = new Size(145, 145);                         // Αρχικοποίηση ιδιοτήτων της εικόνας
            this.Picture.SizeMode = PictureBoxSizeMode.StretchImage;        //
            this.Box.Controls.Add(this.Picture);                            // Προσθήκη στα controls του Groupbox

            this.Title.Text = NameSource;                                           //
            this.Title.TextAlign = ContentAlignment.MiddleCenter;
            this.Title.ForeColor = Color.White;                                     //
            this.Title.Location = new Point(10, 160);                               //
            this.Title.MaximumSize = new Size(145, 75);                             // Αρχικοποίηση ιδιοτήτων του τίτλου
            this.Title.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold); //
            this.Title.AutoSize = true;                                             //

            this.Box.Controls.Add(this.Title);                                      // Προσθήκη στα controls του Groupbox

            this.Open_Button.Size = new Size(40, 40);                                                           //
            this.Open_Button.Tag = this;                                                                        //
            this.Open_Button.Location = new Point(120, 230);                                                    //
            this.Open_Button.Click += OpenButtonClick;                                                          //
            this.Open_Button.BackgroundImageLayout = ImageLayout.Zoom;                                          //
            this.Open_Button.BackgroundImage = Properties.Resources.PlaySongButtonImage;                        // Αρχικοποίηση ιδιοτήτων του κουμπιού "ανοίγματος" playlist
            this.Open_Button.FlatStyle = FlatStyle.Flat;                                                        //
            this.Open_Button.FlatAppearance.BorderSize = 0;                                                     //
            this.Open_Button.FlatAppearance.MouseDownBackColor = Color.Black;                                   //
            this.Open_Button.Cursor = Cursors.Hand;                                                             //
            this.Box.Controls.Add(this.Open_Button);                                                            // Προσθήκη στα controls του Groupbox
        }
    }
}

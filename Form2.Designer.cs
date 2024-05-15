namespace MusicPlayer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ArtistTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AlbumTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PhotoButton = new System.Windows.Forms.Button();
            this.PhotoLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FinalButton = new System.Windows.Forms.Button();
            this.PhotoRemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Όνομα*";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NameTextBox.Location = new System.Drawing.Point(101, 47);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameTextBox.MaxLength = 20;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(98, 23);
            this.NameTextBox.TabIndex = 1;
            // 
            // ArtistTextBox
            // 
            this.ArtistTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ArtistTextBox.Location = new System.Drawing.Point(101, 102);
            this.ArtistTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ArtistTextBox.MaxLength = 20;
            this.ArtistTextBox.Name = "ArtistTextBox";
            this.ArtistTextBox.Size = new System.Drawing.Size(98, 23);
            this.ArtistTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Καλλιτέχνης*";
            // 
            // AlbumTextBox
            // 
            this.AlbumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AlbumTextBox.Location = new System.Drawing.Point(101, 161);
            this.AlbumTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AlbumTextBox.MaxLength = 20;
            this.AlbumTextBox.Name = "AlbumTextBox";
            this.AlbumTextBox.Size = new System.Drawing.Size(98, 23);
            this.AlbumTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(98, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Άλμπουμ";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DateTextBox.Location = new System.Drawing.Point(101, 219);
            this.DateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DateTextBox.MaxLength = 4;
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(98, 23);
            this.DateTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(98, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Έτος κυκλοφορίας";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.GenreTextBox.Location = new System.Drawing.Point(101, 277);
            this.GenreTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GenreTextBox.MaxLength = 20;
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(98, 23);
            this.GenreTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(98, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Είδος";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(98, 314);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Φωτογραφία";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PhotoButton
            // 
            this.PhotoButton.ForeColor = System.Drawing.Color.Black;
            this.PhotoButton.Location = new System.Drawing.Point(101, 336);
            this.PhotoButton.Margin = new System.Windows.Forms.Padding(2);
            this.PhotoButton.Name = "PhotoButton";
            this.PhotoButton.Size = new System.Drawing.Size(56, 22);
            this.PhotoButton.TabIndex = 11;
            this.PhotoButton.Text = "Επιλογή";
            this.PhotoButton.UseVisualStyleBackColor = true;
            this.PhotoButton.Click += new System.EventHandler(this.Photo_Choice_Button_Click);
            // 
            // PhotoLabel
            // 
            this.PhotoLabel.AutoSize = true;
            this.PhotoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PhotoLabel.ForeColor = System.Drawing.Color.White;
            this.PhotoLabel.Location = new System.Drawing.Point(162, 339);
            this.PhotoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhotoLabel.MaximumSize = new System.Drawing.Size(122, 15);
            this.PhotoLabel.Name = "PhotoLabel";
            this.PhotoLabel.Size = new System.Drawing.Size(79, 15);
            this.PhotoLabel.TabIndex = 12;
            this.PhotoLabel.Text = "Φωτογραφία";
            this.PhotoLabel.Visible = false;
            // 
            // CancelButton
            // 
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(154, 402);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(67, 26);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Ακύρωση";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // FinalButton
            // 
            this.FinalButton.ForeColor = System.Drawing.Color.Black;
            this.FinalButton.Location = new System.Drawing.Point(78, 402);
            this.FinalButton.Margin = new System.Windows.Forms.Padding(2);
            this.FinalButton.Name = "FinalButton";
            this.FinalButton.Size = new System.Drawing.Size(67, 26);
            this.FinalButton.TabIndex = 15;
            this.FinalButton.Text = "Προσθήκη";
            this.FinalButton.UseVisualStyleBackColor = true;
            this.FinalButton.Click += new System.EventHandler(this.Final_Button_Click);
            // 
            // PhotoRemoveButton
            // 
            this.PhotoRemoveButton.FlatAppearance.BorderSize = 0;
            this.PhotoRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PhotoRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PhotoRemoveButton.ForeColor = System.Drawing.Color.Red;
            this.PhotoRemoveButton.Location = new System.Drawing.Point(232, 336);
            this.PhotoRemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.PhotoRemoveButton.Name = "PhotoRemoveButton";
            this.PhotoRemoveButton.Size = new System.Drawing.Size(20, 21);
            this.PhotoRemoveButton.TabIndex = 16;
            this.PhotoRemoveButton.Text = "✖";
            this.PhotoRemoveButton.UseVisualStyleBackColor = true;
            this.PhotoRemoveButton.Visible = false;
            this.PhotoRemoveButton.Click += new System.EventHandler(this.PhotoRemoveButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(312, 444);
            this.Controls.Add(this.PhotoRemoveButton);
            this.Controls.Add(this.FinalButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PhotoLabel);
            this.Controls.Add(this.PhotoButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AlbumTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ArtistTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(328, 483);
            this.MinimumSize = new System.Drawing.Size(328, 483);
            this.Name = "Form2";
            this.Text = "Add Song";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.TextBox ArtistTextBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox AlbumTextBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button PhotoButton;
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.Label PhotoLabel;
        public System.Windows.Forms.Button PhotoRemoveButton;
        public System.Windows.Forms.Button FinalButton;
    }
}
namespace MusicPlayer
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PhotoRemoveButton = new System.Windows.Forms.Button();
            this.FinalButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PhotoLabel = new System.Windows.Forms.Label();
            this.PhotoButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NameTextBox.Location = new System.Drawing.Point(101, 38);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameTextBox.MaxLength = 20;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(98, 23);
            this.NameTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Όνομα*";
            // 
            // PhotoRemoveButton
            // 
            this.PhotoRemoveButton.FlatAppearance.BorderSize = 0;
            this.PhotoRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PhotoRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PhotoRemoveButton.ForeColor = System.Drawing.Color.Red;
            this.PhotoRemoveButton.Location = new System.Drawing.Point(231, 96);
            this.PhotoRemoveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PhotoRemoveButton.Name = "PhotoRemoveButton";
            this.PhotoRemoveButton.Size = new System.Drawing.Size(20, 21);
            this.PhotoRemoveButton.TabIndex = 22;
            this.PhotoRemoveButton.Text = "✖";
            this.PhotoRemoveButton.UseVisualStyleBackColor = true;
            this.PhotoRemoveButton.Visible = false;
            this.PhotoRemoveButton.Click += new System.EventHandler(this.PhotoRemoveButton_Click);
            // 
            // FinalButton
            // 
            this.FinalButton.ForeColor = System.Drawing.Color.Black;
            this.FinalButton.Location = new System.Drawing.Point(77, 156);
            this.FinalButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FinalButton.Name = "FinalButton";
            this.FinalButton.Size = new System.Drawing.Size(67, 26);
            this.FinalButton.TabIndex = 21;
            this.FinalButton.Text = "Προσθήκη";
            this.FinalButton.UseVisualStyleBackColor = true;
            this.FinalButton.Click += new System.EventHandler(this.FinalButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(153, 156);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(67, 26);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Ακύρωση";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PhotoLabel
            // 
            this.PhotoLabel.AutoSize = true;
            this.PhotoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PhotoLabel.ForeColor = System.Drawing.Color.White;
            this.PhotoLabel.Location = new System.Drawing.Point(161, 99);
            this.PhotoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhotoLabel.MaximumSize = new System.Drawing.Size(122, 15);
            this.PhotoLabel.Name = "PhotoLabel";
            this.PhotoLabel.Size = new System.Drawing.Size(79, 15);
            this.PhotoLabel.TabIndex = 19;
            this.PhotoLabel.Text = "Φωτογραφία";
            this.PhotoLabel.Visible = false;
            // 
            // PhotoButton
            // 
            this.PhotoButton.ForeColor = System.Drawing.Color.Black;
            this.PhotoButton.Location = new System.Drawing.Point(100, 96);
            this.PhotoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PhotoButton.Name = "PhotoButton";
            this.PhotoButton.Size = new System.Drawing.Size(56, 22);
            this.PhotoButton.TabIndex = 18;
            this.PhotoButton.Text = "Επιλογή";
            this.PhotoButton.UseVisualStyleBackColor = true;
            this.PhotoButton.Click += new System.EventHandler(this.PhotoButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(97, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Φωτογραφία";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(311, 194);
            this.Controls.Add(this.PhotoRemoveButton);
            this.Controls.Add(this.FinalButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PhotoLabel);
            this.Controls.Add(this.PhotoButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(327, 233);
            this.MinimumSize = new System.Drawing.Size(327, 233);
            this.Name = "Form3";
            this.Text = "Add Playlist";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button PhotoButton;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button PhotoRemoveButton;
        public System.Windows.Forms.Label PhotoLabel;
        public System.Windows.Forms.Button FinalButton;
    }
}
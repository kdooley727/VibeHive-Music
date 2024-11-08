namespace Main_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_MusicRental = new Button();
            btn_EventTicket = new Button();
            btn_Albums = new Button();
            SuspendLayout();
            // 
            // btn_MusicRental
            // 
            btn_MusicRental.Location = new Point(109, 71);
            btn_MusicRental.Name = "btn_MusicRental";
            btn_MusicRental.Size = new Size(94, 23);
            btn_MusicRental.TabIndex = 0;
            btn_MusicRental.Text = "Music Rental";
            btn_MusicRental.UseVisualStyleBackColor = true;
            btn_MusicRental.Click += btn_MusicRental_Click;
            // 
            // btn_EventTicket
            // 
            btn_EventTicket.Location = new Point(109, 142);
            btn_EventTicket.Name = "btn_EventTicket";
            btn_EventTicket.Size = new Size(94, 23);
            btn_EventTicket.TabIndex = 1;
            btn_EventTicket.Text = "Event/Tickets";
            btn_EventTicket.TextAlign = ContentAlignment.MiddleLeft;
            btn_EventTicket.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_EventTicket.UseVisualStyleBackColor = true;
            btn_EventTicket.Click += btn_EventTicket_Click;
            // 
            // btn_Albums
            // 
            btn_Albums.Location = new Point(109, 214);
            btn_Albums.Name = "btn_Albums";
            btn_Albums.Size = new Size(94, 23);
            btn_Albums.TabIndex = 2;
            btn_Albums.Text = "Albums";
            btn_Albums.UseVisualStyleBackColor = true;
            btn_Albums.Click += btn_Albums_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Albums);
            Controls.Add(btn_EventTicket);
            Controls.Add(btn_MusicRental);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_MusicRental;
        private Button btn_EventTicket;
        private Button btn_Albums;
    }
}

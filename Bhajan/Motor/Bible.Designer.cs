

using Bhajan_.Classess;

namespace Bhajan.Motor
{
    partial class Bible
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bible));
            this.Btn_Play = new System.Windows.Forms.Button();
            this.SelectChapter = new System.Windows.Forms.ComboBox();
            this.Btn_Info = new System.Windows.Forms.Button();
            this.Btn_FullScreen = new System.Windows.Forms.Button();
            this.SelectVerse = new System.Windows.Forms.ComboBox();
            this.Book3 = new System.Windows.Forms.Label();
            this.Book1 = new System.Windows.Forms.Label();
            this.LocalVerseView = new System.Windows.Forms.TextBox();
            this.NumberOfVersesToDisplay = new System.Windows.Forms.TrackBar();
            this.Btn_StopPlaying = new System.Windows.Forms.Button();
            this.Btn_Previous = new System.Windows.Forms.Button();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.label_Bhajan_Sangraha = new System.Windows.Forms.Label();
            this.Btn_BackToHome = new System.Windows.Forms.Button();
            this.SelectBook = new Bhajan_.Classess.MyCustomComboBox();
            this.Check_WithBackground = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfVersesToDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Play
            // 
            this.Btn_Play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Play.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Play.BackgroundImage")));
            this.Btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Play.FlatAppearance.BorderSize = 0;
            this.Btn_Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Btn_Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Play.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Play.Location = new System.Drawing.Point(691, 94);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(136, 96);
            this.Btn_Play.TabIndex = 28;
            this.Btn_Play.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Play.UseVisualStyleBackColor = false;
            this.Btn_Play.Click += new System.EventHandler(this.Play_Click);
            this.Btn_Play.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnSpecialKeyPress);
            // 
            // SelectChapter
            // 
            this.SelectChapter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectChapter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectChapter.DropDownHeight = 250;
            this.SelectChapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectChapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectChapter.FormattingEnabled = true;
            this.SelectChapter.IntegralHeight = false;
            this.SelectChapter.Location = new System.Drawing.Point(68, 145);
            this.SelectChapter.Name = "SelectChapter";
            this.SelectChapter.Size = new System.Drawing.Size(144, 33);
            this.SelectChapter.TabIndex = 27;
            this.SelectChapter.SelectedIndexChanged += new System.EventHandler(this.SelectChapter_SelectedIndexChanged);
            this.SelectChapter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnSpecialKeyPress);
            // 
            // Btn_Info
            // 
            this.Btn_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Info.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Info.BackgroundImage")));
            this.Btn_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Info.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Info.Location = new System.Drawing.Point(9, 528);
            this.Btn_Info.Name = "Btn_Info";
            this.Btn_Info.Size = new System.Drawing.Size(60, 60);
            this.Btn_Info.TabIndex = 23;
            this.Btn_Info.UseVisualStyleBackColor = false;
            this.Btn_Info.Click += new System.EventHandler(this.Btn_Info_Click);
            this.Btn_Info.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnSpecialKeyPress);
            // 
            // Btn_FullScreen
            // 
            this.Btn_FullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_FullScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_FullScreen.BackgroundImage")));
            this.Btn_FullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_FullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_FullScreen.Image = ((System.Drawing.Image)(resources.GetObject("Btn_FullScreen.Image")));
            this.Btn_FullScreen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_FullScreen.Location = new System.Drawing.Point(836, 539);
            this.Btn_FullScreen.Name = "Btn_FullScreen";
            this.Btn_FullScreen.Size = new System.Drawing.Size(50, 50);
            this.Btn_FullScreen.TabIndex = 22;
            this.Btn_FullScreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_FullScreen.UseVisualStyleBackColor = true;
            this.Btn_FullScreen.Click += new System.EventHandler(this.Btn_FullScreen_Click);
            this.Btn_FullScreen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnSpecialKeyPress);
            // 
            // SelectVerse
            // 
            this.SelectVerse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectVerse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectVerse.DropDownHeight = 250;
            this.SelectVerse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectVerse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectVerse.FormattingEnabled = true;
            this.SelectVerse.IntegralHeight = false;
            this.SelectVerse.Location = new System.Drawing.Point(226, 145);
            this.SelectVerse.Name = "SelectVerse";
            this.SelectVerse.Size = new System.Drawing.Size(144, 33);
            this.SelectVerse.TabIndex = 29;
            this.SelectVerse.SelectedIndexChanged += new System.EventHandler(this.SelectVerse_SelectedIndexChanged);
            this.SelectVerse.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnSpecialKeyPress);
            // 
            // Book3
            // 
            this.Book3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Book3.AutoSize = true;
            this.Book3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Book3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Book3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Book3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book3.ForeColor = System.Drawing.Color.Gray;
            this.Book3.Image = ((System.Drawing.Image)(resources.GetObject("Book3.Image")));
            this.Book3.Location = new System.Drawing.Point(460, 402);
            this.Book3.Name = "Book3";
            this.Book3.Size = new System.Drawing.Size(134, 187);
            this.Book3.TabIndex = 31;
            this.Book3.Text = "📖\r\n\r\n  Holy  \r\n  Bible  \r\nNIV";
            this.Book3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Book3.Click += new System.EventHandler(this.Book3_Click);
            // 
            // Book1
            // 
            this.Book1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Book1.AutoSize = true;
            this.Book1.BackColor = System.Drawing.Color.Maroon;
            this.Book1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Book1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Book1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book1.ForeColor = System.Drawing.Color.White;
            this.Book1.Image = ((System.Drawing.Image)(resources.GetObject("Book1.Image")));
            this.Book1.Location = new System.Drawing.Point(321, 402);
            this.Book1.Name = "Book1";
            this.Book1.Size = new System.Drawing.Size(133, 187);
            this.Book1.TabIndex = 30;
            this.Book1.Text = "✔️\r\n\r\n   पवित्र   \r\n   बाइबल   \r\n\r\n";
            this.Book1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Book1.Click += new System.EventHandler(this.Book1_Click);
            // 
            // LocalVerseView
            // 
            this.LocalVerseView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocalVerseView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LocalVerseView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalVerseView.Location = new System.Drawing.Point(67, 196);
            this.LocalVerseView.Multiline = true;
            this.LocalVerseView.Name = "LocalVerseView";
            this.LocalVerseView.ReadOnly = true;
            this.LocalVerseView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LocalVerseView.Size = new System.Drawing.Size(760, 181);
            this.LocalVerseView.TabIndex = 32;
            this.LocalVerseView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LocalVerseView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnSpecialKeyPress);
            // 
            // NumberOfVersesToDisplay
            // 
            this.NumberOfVersesToDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberOfVersesToDisplay.BackColor = System.Drawing.Color.Gray;
            this.NumberOfVersesToDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumberOfVersesToDisplay.LargeChange = 1;
            this.NumberOfVersesToDisplay.Location = new System.Drawing.Point(530, 145);
            this.NumberOfVersesToDisplay.Maximum = 3;
            this.NumberOfVersesToDisplay.Minimum = 1;
            this.NumberOfVersesToDisplay.Name = "NumberOfVersesToDisplay";
            this.NumberOfVersesToDisplay.Size = new System.Drawing.Size(144, 45);
            this.NumberOfVersesToDisplay.TabIndex = 33;
            this.NumberOfVersesToDisplay.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.NumberOfVersesToDisplay.Value = 1;
            this.NumberOfVersesToDisplay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnSpecialKeyPress);
            // 
            // Btn_StopPlaying
            // 
            this.Btn_StopPlaying.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_StopPlaying.BackColor = System.Drawing.Color.Transparent;
            this.Btn_StopPlaying.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_StopPlaying.BackgroundImage")));
            this.Btn_StopPlaying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_StopPlaying.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_StopPlaying.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_StopPlaying.Location = new System.Drawing.Point(425, 525);
            this.Btn_StopPlaying.Name = "Btn_StopPlaying";
            this.Btn_StopPlaying.Size = new System.Drawing.Size(50, 50);
            this.Btn_StopPlaying.TabIndex = 37;
            this.Btn_StopPlaying.UseVisualStyleBackColor = false;
            this.Btn_StopPlaying.Visible = false;
            this.Btn_StopPlaying.Click += new System.EventHandler(this.Btn_StopPlaying_Click);
            // 
            // Btn_Previous
            // 
            this.Btn_Previous.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Previous.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Previous.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Previous.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Previous.BackgroundImage")));
            this.Btn_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Previous.FlatAppearance.BorderSize = 0;
            this.Btn_Previous.Location = new System.Drawing.Point(335, 513);
            this.Btn_Previous.Name = "Btn_Previous";
            this.Btn_Previous.Size = new System.Drawing.Size(75, 75);
            this.Btn_Previous.TabIndex = 35;
            this.Btn_Previous.UseVisualStyleBackColor = false;
            this.Btn_Previous.Visible = false;
            this.Btn_Previous.Click += new System.EventHandler(this.Btn_Previous_Click);
            // 
            // Btn_Next
            // 
            this.Btn_Next.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Next.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Next.BackgroundImage")));
            this.Btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Next.FlatAppearance.BorderSize = 0;
            this.Btn_Next.Location = new System.Drawing.Point(492, 513);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(75, 75);
            this.Btn_Next.TabIndex = 34;
            this.Btn_Next.UseVisualStyleBackColor = false;
            this.Btn_Next.Visible = false;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // label_Bhajan_Sangraha
            // 
            this.label_Bhajan_Sangraha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Bhajan_Sangraha.AutoSize = true;
            this.label_Bhajan_Sangraha.BackColor = System.Drawing.Color.Transparent;
            this.label_Bhajan_Sangraha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bhajan_Sangraha.ForeColor = System.Drawing.Color.White;
            this.label_Bhajan_Sangraha.Location = new System.Drawing.Point(382, 148);
            this.label_Bhajan_Sangraha.Name = "label_Bhajan_Sangraha";
            this.label_Bhajan_Sangraha.Size = new System.Drawing.Size(134, 31);
            this.label_Bhajan_Sangraha.TabIndex = 38;
            this.label_Bhajan_Sangraha.Text = "पदको संख्य :";
            // 
            // Btn_BackToHome
            // 
            this.Btn_BackToHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_BackToHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_BackToHome.BackgroundImage")));
            this.Btn_BackToHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_BackToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_BackToHome.Image = ((System.Drawing.Image)(resources.GetObject("Btn_BackToHome.Image")));
            this.Btn_BackToHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_BackToHome.Location = new System.Drawing.Point(848, 3);
            this.Btn_BackToHome.Name = "Btn_BackToHome";
            this.Btn_BackToHome.Size = new System.Drawing.Size(44, 44);
            this.Btn_BackToHome.TabIndex = 41;
            this.Btn_BackToHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_BackToHome.UseVisualStyleBackColor = true;
            this.Btn_BackToHome.Click += new System.EventHandler(this.Btn_BackToHome_Click);
            // 
            // SelectBook
            // 
            this.SelectBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectBook.BackColor = System.Drawing.Color.LightGray;
            this.SelectBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectBook.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SelectBook.DropDownHeight = 250;
            this.SelectBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectBook.FormattingEnabled = true;
            this.SelectBook.IntegralHeight = false;
            this.SelectBook.Location = new System.Drawing.Point(67, 95);
            this.SelectBook.Name = "SelectBook";
            this.SelectBook.Size = new System.Drawing.Size(387, 32);
            this.SelectBook.TabIndex = 24;
            this.SelectBook.SelectedIndexChanged += new System.EventHandler(this.SelectBook_SelectedIndexChanged);
            this.SelectBook.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnSpecialKeyPress);
            // 
            // Check_WithBackground
            // 
            this.Check_WithBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Check_WithBackground.AutoSize = true;
            this.Check_WithBackground.BackColor = System.Drawing.Color.Transparent;
            this.Check_WithBackground.Checked = true;
            this.Check_WithBackground.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Check_WithBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_WithBackground.ForeColor = System.Drawing.Color.White;
            this.Check_WithBackground.Location = new System.Drawing.Point(466, 95);
            this.Check_WithBackground.Name = "Check_WithBackground";
            this.Check_WithBackground.Size = new System.Drawing.Size(208, 35);
            this.Check_WithBackground.TabIndex = 42;
            this.Check_WithBackground.Text = "पृष्ठभूमिमा छविहरू";
            this.Check_WithBackground.UseVisualStyleBackColor = false;
            // 
            // Bible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 600);
            this.Controls.Add(this.Check_WithBackground);
            this.Controls.Add(this.Btn_BackToHome);
            this.Controls.Add(this.label_Bhajan_Sangraha);
            this.Controls.Add(this.Btn_StopPlaying);
            this.Controls.Add(this.Btn_Previous);
            this.Controls.Add(this.Btn_Next);
            this.Controls.Add(this.NumberOfVersesToDisplay);
            this.Controls.Add(this.LocalVerseView);
            this.Controls.Add(this.Book3);
            this.Controls.Add(this.Book1);
            this.Controls.Add(this.SelectVerse);
            this.Controls.Add(this.Btn_Play);
            this.Controls.Add(this.SelectChapter);
            this.Controls.Add(this.SelectBook);
            this.Controls.Add(this.Btn_Info);
            this.Controls.Add(this.Btn_FullScreen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bible";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "बाइबल - Bible";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bible_Home_FormClosing);
            this.Load += new System.EventHandler(this.Bible_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnSpecialKeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfVersesToDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Play;
        private System.Windows.Forms.Button Btn_Info;
        private System.Windows.Forms.Button Btn_FullScreen;
        private System.Windows.Forms.Label Book3;
        private System.Windows.Forms.Label Book1;
        private System.Windows.Forms.TextBox LocalVerseView;
        private System.Windows.Forms.TrackBar NumberOfVersesToDisplay;
        private System.Windows.Forms.Button Btn_StopPlaying;
        private System.Windows.Forms.Button Btn_Previous;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Label label_Bhajan_Sangraha;
        private System.Windows.Forms.ComboBox SelectChapter;
        private MyCustomComboBox SelectBook;
        private System.Windows.Forms.ComboBox SelectVerse;
        private System.Windows.Forms.Button Btn_BackToHome;
        private System.Windows.Forms.CheckBox Check_WithBackground;
    }
}
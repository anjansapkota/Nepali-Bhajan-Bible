namespace Bhajan.Motor
{
    partial class CustomDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDisplay));
            this.CustomInfoBox = new System.Windows.Forms.RichTextBox();
            this.Btn_AddImage = new System.Windows.Forms.Button();
            this.Btn_Play = new System.Windows.Forms.Button();
            this.ImageNameAdded = new System.Windows.Forms.Label();
            this.ComboTextAlign = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_BackToHome = new System.Windows.Forms.Button();
            this.LabelUnicodeLink = new System.Windows.Forms.LinkLabel();
            this.Btn_FullScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomInfoBox
            // 
            this.CustomInfoBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomInfoBox.BackColor = System.Drawing.Color.Linen;
            this.CustomInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomInfoBox.Location = new System.Drawing.Point(58, 204);
            this.CustomInfoBox.Margin = new System.Windows.Forms.Padding(10);
            this.CustomInfoBox.Name = "CustomInfoBox";
            this.CustomInfoBox.Size = new System.Drawing.Size(776, 194);
            this.CustomInfoBox.TabIndex = 0;
            this.CustomInfoBox.Text = "";
            this.CustomInfoBox.TextChanged += new System.EventHandler(this.CustomInfoBox_TextChanged);
            this.CustomInfoBox.GotFocus += new System.EventHandler(this.RemoveText);
            this.CustomInfoBox.LostFocus += new System.EventHandler(this.AddText);
            // 
            // Btn_AddImage
            // 
            this.Btn_AddImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_AddImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_AddImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddImage.Location = new System.Drawing.Point(67, 413);
            this.Btn_AddImage.Name = "Btn_AddImage";
            this.Btn_AddImage.Size = new System.Drawing.Size(221, 30);
            this.Btn_AddImage.TabIndex = 1;
            this.Btn_AddImage.Text = "Background - पृष्ठभूमि ";
            this.Btn_AddImage.UseVisualStyleBackColor = false;
            this.Btn_AddImage.Click += new System.EventHandler(this.Button_Add_BG_Click);
            // 
            // Btn_Play
            // 
            this.Btn_Play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Play.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Play.BackgroundImage")));
            this.Btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Play.Location = new System.Drawing.Point(730, 413);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(104, 105);
            this.Btn_Play.TabIndex = 2;
            this.Btn_Play.UseVisualStyleBackColor = false;
            this.Btn_Play.Click += new System.EventHandler(this.Btn_Play_Click);
            // 
            // ImageNameAdded
            // 
            this.ImageNameAdded.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageNameAdded.AutoSize = true;
            this.ImageNameAdded.BackColor = System.Drawing.Color.Transparent;
            this.ImageNameAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageNameAdded.ForeColor = System.Drawing.Color.White;
            this.ImageNameAdded.Location = new System.Drawing.Point(76, 454);
            this.ImageNameAdded.Name = "ImageNameAdded";
            this.ImageNameAdded.Size = new System.Drawing.Size(111, 20);
            this.ImageNameAdded.TabIndex = 3;
            this.ImageNameAdded.Text = "ImageAdded";
            this.ImageNameAdded.Visible = false;
            // 
            // ComboTextAlign
            // 
            this.ComboTextAlign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboTextAlign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboTextAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTextAlign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTextAlign.FormattingEnabled = true;
            this.ComboTextAlign.Items.AddRange(new object[] {
            "Left |  बायाँ",
            "Center | बिचमा",
            "Right | दायाँ "});
            this.ComboTextAlign.Location = new System.Drawing.Point(294, 413);
            this.ComboTextAlign.Name = "ComboTextAlign";
            this.ComboTextAlign.Size = new System.Drawing.Size(197, 28);
            this.ComboTextAlign.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(67, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Remove | हटाउनुहोस्";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Stop.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Stop.BackgroundImage")));
            this.Btn_Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Stop.Location = new System.Drawing.Point(730, 413);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(104, 105);
            this.Btn_Stop.TabIndex = 6;
            this.Btn_Stop.UseVisualStyleBackColor = false;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 96);
            this.label1.TabIndex = 7;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Btn_BackToHome
            // 
            this.Btn_BackToHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_BackToHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_BackToHome.BackgroundImage")));
            this.Btn_BackToHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_BackToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_BackToHome.Image = ((System.Drawing.Image)(resources.GetObject("Btn_BackToHome.Image")));
            this.Btn_BackToHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_BackToHome.Location = new System.Drawing.Point(846, 2);
            this.Btn_BackToHome.Name = "Btn_BackToHome";
            this.Btn_BackToHome.Size = new System.Drawing.Size(44, 44);
            this.Btn_BackToHome.TabIndex = 41;
            this.Btn_BackToHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_BackToHome.UseVisualStyleBackColor = true;
            this.Btn_BackToHome.Click += new System.EventHandler(this.Btn_BackToHome_Click);
            // 
            // LabelUnicodeLink
            // 
            this.LabelUnicodeLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelUnicodeLink.AutoSize = true;
            this.LabelUnicodeLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelUnicodeLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUnicodeLink.Location = new System.Drawing.Point(381, 113);
            this.LabelUnicodeLink.Name = "LabelUnicodeLink";
            this.LabelUnicodeLink.Size = new System.Drawing.Size(276, 24);
            this.LabelUnicodeLink.TabIndex = 42;
            this.LabelUnicodeLink.TabStop = true;
            this.LabelUnicodeLink.Text = "नेपाली टाइप गर्ना युनिकोड प्रयोग गार्नुहोला";
            this.LabelUnicodeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelUnicodeLink_LinkClicked);
            // 
            // Btn_FullScreen
            // 
            this.Btn_FullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_FullScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_FullScreen.BackgroundImage")));
            this.Btn_FullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_FullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_FullScreen.Image = ((System.Drawing.Image)(resources.GetObject("Btn_FullScreen.Image")));
            this.Btn_FullScreen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_FullScreen.Location = new System.Drawing.Point(840, 504);
            this.Btn_FullScreen.Name = "Btn_FullScreen";
            this.Btn_FullScreen.Size = new System.Drawing.Size(50, 50);
            this.Btn_FullScreen.TabIndex = 44;
            this.Btn_FullScreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_FullScreen.UseVisualStyleBackColor = true;
            this.Btn_FullScreen.Click += new System.EventHandler(this.Btn_FullScreen_Click);
            // 
            // CustomDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 556);
            this.Controls.Add(this.Btn_FullScreen);
            this.Controls.Add(this.LabelUnicodeLink);
            this.Controls.Add(this.Btn_BackToHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ComboTextAlign);
            this.Controls.Add(this.ImageNameAdded);
            this.Controls.Add(this.Btn_Play);
            this.Controls.Add(this.Btn_AddImage);
            this.Controls.Add(this.CustomInfoBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "जानकारी प्रदर्शन - Information Display";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActiveFormClosing);
            this.Load += new System.EventHandler(this.CustomDisplay_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnSpecialKeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CustomInfoBox;
        private System.Windows.Forms.Button Btn_AddImage;
        private System.Windows.Forms.Button Btn_Play;
        private System.Windows.Forms.Label ImageNameAdded;
        private System.Windows.Forms.ComboBox ComboTextAlign;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_BackToHome;
        private System.Windows.Forms.LinkLabel LabelUnicodeLink;
        private System.Windows.Forms.Button Btn_FullScreen;
    }
}
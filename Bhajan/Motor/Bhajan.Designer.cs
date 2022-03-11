using System.Windows.Forms;

namespace Bhajan
{
    partial class Bhajan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bhajan));
            this.Btn_FullScreen = new System.Windows.Forms.Button();
            this.Btn_Info = new System.Windows.Forms.Button();
            this.SelectHymBookCat = new System.Windows.Forms.ComboBox();
            this.Txt_SearchByTitle = new System.Windows.Forms.ComboBox();
            this.Txt_SearchByNum = new System.Windows.Forms.ComboBox();
            this.ComboLanguage = new System.Windows.Forms.ComboBox();
            this.label_Bhajan_Sangraha = new System.Windows.Forms.Label();
            this.label_Number = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_language = new System.Windows.Forms.Label();
            this.Book1 = new System.Windows.Forms.Label();
            this.Book3 = new System.Windows.Forms.Label();
            this.Btn_Play = new System.Windows.Forms.Button();
            this.Btn_GoBackKeepPlaying = new System.Windows.Forms.Button();
            this.Btn_Previous = new System.Windows.Forms.Button();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Btn_StopPlaying = new System.Windows.Forms.Button();
            this.Btn_ViewControls = new System.Windows.Forms.Button();
            this.Btn_BackToHome = new System.Windows.Forms.Button();
            this.Check_WithBackground = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Btn_FullScreen
            // 
            this.Btn_FullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_FullScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_FullScreen.BackgroundImage")));
            this.Btn_FullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_FullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_FullScreen.Image = ((System.Drawing.Image)(resources.GetObject("Btn_FullScreen.Image")));
            this.Btn_FullScreen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_FullScreen.Location = new System.Drawing.Point(833, 538);
            this.Btn_FullScreen.Name = "Btn_FullScreen";
            this.Btn_FullScreen.Size = new System.Drawing.Size(50, 50);
            this.Btn_FullScreen.TabIndex = 2;
            this.Btn_FullScreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_FullScreen.UseVisualStyleBackColor = true;
            this.Btn_FullScreen.Click += new System.EventHandler(this.Btn_FullScreen_Click);
            // 
            // Btn_Info
            // 
            this.Btn_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Info.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Info.BackgroundImage")));
            this.Btn_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Info.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Info.Location = new System.Drawing.Point(12, 528);
            this.Btn_Info.Name = "Btn_Info";
            this.Btn_Info.Size = new System.Drawing.Size(60, 60);
            this.Btn_Info.TabIndex = 7;
            this.Btn_Info.UseVisualStyleBackColor = false;
            this.Btn_Info.Click += new System.EventHandler(this.ShowSoftwareInfo);
            this.Btn_Info.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnSpecialKeyPress);
            // 
            // SelectHymBookCat
            // 
            this.SelectHymBookCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectHymBookCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectHymBookCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectHymBookCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectHymBookCat.FormattingEnabled = true;
            this.SelectHymBookCat.Items.AddRange(new object[] {
            "भजन (ने.ख्री.भ)",
            "कोरस",
            "बाल गीत"});
            this.SelectHymBookCat.Location = new System.Drawing.Point(261, 123);
            this.SelectHymBookCat.Name = "SelectHymBookCat";
            this.SelectHymBookCat.Size = new System.Drawing.Size(140, 33);
            this.SelectHymBookCat.TabIndex = 8;
            this.SelectHymBookCat.SelectedIndexChanged += new System.EventHandler(this.SelectHymBookCat_SelectedIndexChanged);
            // 
            // Txt_SearchByTitle
            // 
            this.Txt_SearchByTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_SearchByTitle.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.Txt_SearchByTitle.DropDownHeight = 250;
            this.Txt_SearchByTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SearchByTitle.FormattingEnabled = true;
            this.Txt_SearchByTitle.IntegralHeight = false;
            this.Txt_SearchByTitle.Location = new System.Drawing.Point(141, 163);
            this.Txt_SearchByTitle.Name = "Txt_SearchByTitle";
            this.Txt_SearchByTitle.Size = new System.Drawing.Size(611, 33);
            this.Txt_SearchByTitle.TabIndex = 11;
            this.Txt_SearchByTitle.SelectedIndexChanged += new System.EventHandler(this.Txt_SearchByTitle_TextChanged);
            this.Txt_SearchByTitle.TextUpdate += new System.EventHandler(this.Txt_SearchByTitle_OnTextUpdate);
            // 
            // Txt_SearchByNum
            // 
            this.Txt_SearchByNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_SearchByNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_SearchByNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Txt_SearchByNum.DropDownHeight = 250;
            this.Txt_SearchByNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SearchByNum.FormattingEnabled = true;
            this.Txt_SearchByNum.IntegralHeight = false;
            this.Txt_SearchByNum.Location = new System.Drawing.Point(141, 123);
            this.Txt_SearchByNum.Name = "Txt_SearchByNum";
            this.Txt_SearchByNum.Size = new System.Drawing.Size(114, 33);
            this.Txt_SearchByNum.TabIndex = 12;
            this.Txt_SearchByNum.SelectedIndexChanged += new System.EventHandler(this.Txt_SearchByNum_TextChanged);
            this.Txt_SearchByNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_SearchByNum_KeyPress);
            // 
            // ComboLanguage
            // 
            this.ComboLanguage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboLanguage.FormattingEnabled = true;
            this.ComboLanguage.Items.AddRange(new object[] {
            "भजन",
            "Bhajan",
            "दुबै/Both"});
            this.ComboLanguage.Location = new System.Drawing.Point(407, 124);
            this.ComboLanguage.Name = "ComboLanguage";
            this.ComboLanguage.Size = new System.Drawing.Size(106, 33);
            this.ComboLanguage.TabIndex = 13;
            // 
            // label_Bhajan_Sangraha
            // 
            this.label_Bhajan_Sangraha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Bhajan_Sangraha.AutoSize = true;
            this.label_Bhajan_Sangraha.BackColor = System.Drawing.Color.Transparent;
            this.label_Bhajan_Sangraha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bhajan_Sangraha.ForeColor = System.Drawing.Color.White;
            this.label_Bhajan_Sangraha.Location = new System.Drawing.Point(273, 89);
            this.label_Bhajan_Sangraha.Name = "label_Bhajan_Sangraha";
            this.label_Bhajan_Sangraha.Size = new System.Drawing.Size(118, 31);
            this.label_Bhajan_Sangraha.TabIndex = 14;
            this.label_Bhajan_Sangraha.Text = "भजन संग्रह";
            // 
            // label_Number
            // 
            this.label_Number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Number.AutoSize = true;
            this.label_Number.BackColor = System.Drawing.Color.Transparent;
            this.label_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Number.ForeColor = System.Drawing.Color.White;
            this.label_Number.Location = new System.Drawing.Point(67, 120);
            this.label_Number.Name = "label_Number";
            this.label_Number.Size = new System.Drawing.Size(68, 31);
            this.label_Number.TabIndex = 15;
            this.label_Number.Text = "संख्या";
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(61, 163);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(74, 31);
            this.label_title.TabIndex = 16;
            this.label_title.Text = "शीर्षक";
            // 
            // label_language
            // 
            this.label_language.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_language.AutoSize = true;
            this.label_language.BackColor = System.Drawing.Color.Transparent;
            this.label_language.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_language.ForeColor = System.Drawing.Color.White;
            this.label_language.Location = new System.Drawing.Point(428, 90);
            this.label_language.Name = "label_language";
            this.label_language.Size = new System.Drawing.Size(63, 31);
            this.label_language.TabIndex = 17;
            this.label_language.Text = "अक्षर";
            // 
            // Book1
            // 
            this.Book1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Book1.AutoSize = true;
            this.Book1.BackColor = System.Drawing.Color.Maroon;
            this.Book1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Book1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Book1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book1.ForeColor = System.Drawing.Color.White;
            this.Book1.Image = ((System.Drawing.Image)(resources.GetObject("Book1.Image")));
            this.Book1.Location = new System.Drawing.Point(327, 414);
            this.Book1.Name = "Book1";
            this.Book1.Size = new System.Drawing.Size(128, 176);
            this.Book1.TabIndex = 18;
            this.Book1.Text = "✔️\r\n\r\nनेपाली\r\n ख्रीष्टीय भजन \r\n\r\n\r\n";
            this.Book1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Book1.Click += new System.EventHandler(this.Book1_Click);
            // 
            // Book3
            // 
            this.Book3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Book3.AutoSize = true;
            this.Book3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Book3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Book3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Book3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book3.ForeColor = System.Drawing.Color.Gray;
            this.Book3.Image = ((System.Drawing.Image)(resources.GetObject("Book3.Image")));
            this.Book3.Location = new System.Drawing.Point(472, 414);
            this.Book3.Name = "Book3";
            this.Book3.Size = new System.Drawing.Size(129, 176);
            this.Book3.TabIndex = 20;
            this.Book3.Text = "📖\r\n\r\n English  \r\nSDA \r\n  Hymnal  \r\n\r\n";
            this.Book3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Book3.Click += new System.EventHandler(this.Book3_Click);
            // 
            // Btn_Play
            // 
            this.Btn_Play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Play.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Play.BackgroundImage")));
            this.Btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Play.FlatAppearance.BorderSize = 0;
            this.Btn_Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Play.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Play.Location = new System.Drawing.Point(756, 120);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(126, 116);
            this.Btn_Play.TabIndex = 21;
            this.Btn_Play.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Play.UseVisualStyleBackColor = false;
            this.Btn_Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Btn_GoBackKeepPlaying
            // 
            this.Btn_GoBackKeepPlaying.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_GoBackKeepPlaying.BackColor = System.Drawing.Color.Transparent;
            this.Btn_GoBackKeepPlaying.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_GoBackKeepPlaying.BackgroundImage")));
            this.Btn_GoBackKeepPlaying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_GoBackKeepPlaying.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_GoBackKeepPlaying.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_GoBackKeepPlaying.Location = new System.Drawing.Point(414, 510);
            this.Btn_GoBackKeepPlaying.Name = "Btn_GoBackKeepPlaying";
            this.Btn_GoBackKeepPlaying.Size = new System.Drawing.Size(50, 50);
            this.Btn_GoBackKeepPlaying.TabIndex = 25;
            this.Btn_GoBackKeepPlaying.UseVisualStyleBackColor = false;
            this.Btn_GoBackKeepPlaying.Visible = false;
            this.Btn_GoBackKeepPlaying.Click += new System.EventHandler(this.Btn_GoBackKeepPlaying_Click);
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
            this.Btn_Previous.Location = new System.Drawing.Point(330, 497);
            this.Btn_Previous.Name = "Btn_Previous";
            this.Btn_Previous.Size = new System.Drawing.Size(75, 75);
            this.Btn_Previous.TabIndex = 24;
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
            this.Btn_Next.Location = new System.Drawing.Point(535, 497);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(75, 75);
            this.Btn_Next.TabIndex = 23;
            this.Btn_Next.UseVisualStyleBackColor = false;
            this.Btn_Next.Visible = false;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // Btn_StopPlaying
            // 
            this.Btn_StopPlaying.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_StopPlaying.BackColor = System.Drawing.Color.Transparent;
            this.Btn_StopPlaying.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_StopPlaying.BackgroundImage")));
            this.Btn_StopPlaying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_StopPlaying.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_StopPlaying.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_StopPlaying.Location = new System.Drawing.Point(475, 510);
            this.Btn_StopPlaying.Name = "Btn_StopPlaying";
            this.Btn_StopPlaying.Size = new System.Drawing.Size(50, 50);
            this.Btn_StopPlaying.TabIndex = 26;
            this.Btn_StopPlaying.UseVisualStyleBackColor = false;
            this.Btn_StopPlaying.Visible = false;
            this.Btn_StopPlaying.Click += new System.EventHandler(this.Btn_StopPlaying_Click);
            // 
            // Btn_ViewControls
            // 
            this.Btn_ViewControls.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_ViewControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_ViewControls.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ViewControls.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_ViewControls.BackgroundImage")));
            this.Btn_ViewControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_ViewControls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ViewControls.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_ViewControls.FlatAppearance.BorderSize = 5;
            this.Btn_ViewControls.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Btn_ViewControls.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_ViewControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ViewControls.Location = new System.Drawing.Point(330, 432);
            this.Btn_ViewControls.Name = "Btn_ViewControls";
            this.Btn_ViewControls.Size = new System.Drawing.Size(267, 158);
            this.Btn_ViewControls.TabIndex = 27;
            this.Btn_ViewControls.UseVisualStyleBackColor = false;
            this.Btn_ViewControls.Visible = false;
            this.Btn_ViewControls.Click += new System.EventHandler(this.Btn_ViewControls_Click);
            // 
            // Btn_BackToHome
            // 
            this.Btn_BackToHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_BackToHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_BackToHome.BackgroundImage")));
            this.Btn_BackToHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_BackToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_BackToHome.Image = ((System.Drawing.Image)(resources.GetObject("Btn_BackToHome.Image")));
            this.Btn_BackToHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_BackToHome.Location = new System.Drawing.Point(846, 5);
            this.Btn_BackToHome.Name = "Btn_BackToHome";
            this.Btn_BackToHome.Size = new System.Drawing.Size(44, 44);
            this.Btn_BackToHome.TabIndex = 40;
            this.Btn_BackToHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_BackToHome.UseVisualStyleBackColor = true;
            this.Btn_BackToHome.Click += new System.EventHandler(this.Btn_BackToHome_Click);
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
            this.Check_WithBackground.Location = new System.Drawing.Point(535, 116);
            this.Check_WithBackground.Name = "Check_WithBackground";
            this.Check_WithBackground.Size = new System.Drawing.Size(208, 35);
            this.Check_WithBackground.TabIndex = 41;
            this.Check_WithBackground.Text = "पृष्ठभूमिमा छविहरू";
            this.Check_WithBackground.UseVisualStyleBackColor = false;
            // 
            // Bhajan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 600);
            this.Controls.Add(this.Check_WithBackground);
            this.Controls.Add(this.Btn_BackToHome);
            this.Controls.Add(this.Btn_ViewControls);
            this.Controls.Add(this.Btn_StopPlaying);
            this.Controls.Add(this.Btn_GoBackKeepPlaying);
            this.Controls.Add(this.Btn_Previous);
            this.Controls.Add(this.Btn_Next);
            this.Controls.Add(this.Btn_Play);
            this.Controls.Add(this.Book3);
            this.Controls.Add(this.Book1);
            this.Controls.Add(this.label_language);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_Number);
            this.Controls.Add(this.label_Bhajan_Sangraha);
            this.Controls.Add(this.ComboLanguage);
            this.Controls.Add(this.Txt_SearchByNum);
            this.Controls.Add(this.Txt_SearchByTitle);
            this.Controls.Add(this.SelectHymBookCat);
            this.Controls.Add(this.Btn_Info);
            this.Controls.Add(this.Btn_FullScreen);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bhajan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "भजन किताब - Hymnal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bhajan_Home_FormClosing);
            this.Load += new System.EventHandler(this.Bhajan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_FullScreen;
        private System.Windows.Forms.Button Btn_Info;
        private ComboBox SelectHymBookCat;
        private System.Windows.Forms.ComboBox Txt_SearchByTitle;
        private System.Windows.Forms.ComboBox Txt_SearchByNum;
        private System.Windows.Forms.ComboBox ComboLanguage;
        private System.Windows.Forms.Label label_Bhajan_Sangraha;
        private System.Windows.Forms.Label label_Number;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_language;
        private System.Windows.Forms.Label Book1;
        private System.Windows.Forms.Label Book3;
        private Button Btn_Play;
        private Button Btn_GoBackKeepPlaying;
        private Button Btn_Previous;
        private Button Btn_Next;
        private Button Btn_StopPlaying;
        private Button Btn_ViewControls;
        private Button Btn_BackToHome;
        private CheckBox Check_WithBackground;
    }
}


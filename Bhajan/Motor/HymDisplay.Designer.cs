using System.Drawing;
using System.Windows.Forms;

namespace Bhajan.Motor
{
    partial class HymDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HymDisplay));
            this.Btn_FullScreen2 = new System.Windows.Forms.Button();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Btn_Previous = new System.Windows.Forms.Button();
            this.Btn_Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_FullScreen2
            // 
            this.Btn_FullScreen2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_FullScreen2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_FullScreen2.BackgroundImage")));
            this.Btn_FullScreen2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_FullScreen2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_FullScreen2.Image = ((System.Drawing.Image)(resources.GetObject("Btn_FullScreen2.Image")));
            this.Btn_FullScreen2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_FullScreen2.Location = new System.Drawing.Point(833, 538);
            this.Btn_FullScreen2.Name = "Btn_FullScreen2";
            this.Btn_FullScreen2.Size = new System.Drawing.Size(50, 50);
            this.Btn_FullScreen2.TabIndex = 3;
            this.Btn_FullScreen2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_FullScreen2.UseVisualStyleBackColor = true;
            this.Btn_FullScreen2.Click += new System.EventHandler(this.Btn_FullScreen_Click);
            this.Btn_FullScreen2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnSpecialKeyPress);
            // 
            // Btn_Next
            // 
            this.Btn_Next.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Next.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Next.BackgroundImage")));
            this.Btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Next.Location = new System.Drawing.Point(498, 513);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(75, 75);
            this.Btn_Next.TabIndex = 4;
            this.Btn_Next.UseVisualStyleBackColor = false;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            this.Btn_Next.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnSpecialKeyPress);
            // 
            // Btn_Previous
            // 
            this.Btn_Previous.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Previous.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Previous.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Previous.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Previous.BackgroundImage")));
            this.Btn_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Previous.Location = new System.Drawing.Point(314, 513);
            this.Btn_Previous.Name = "Btn_Previous";
            this.Btn_Previous.Size = new System.Drawing.Size(75, 75);
            this.Btn_Previous.TabIndex = 5;
            this.Btn_Previous.UseVisualStyleBackColor = false;
            this.Btn_Previous.Click += new System.EventHandler(this.Btn_Previous_Click);
            this.Btn_Previous.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnSpecialKeyPress);
            // 
            // Btn_Home
            // 
            this.Btn_Home.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Home.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Home.BackgroundImage")));
            this.Btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Home.Location = new System.Drawing.Point(404, 513);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(75, 75);
            this.Btn_Home.TabIndex = 6;
            this.Btn_Home.UseVisualStyleBackColor = false;
            this.Btn_Home.Click += new System.EventHandler(this.GoBackToHome);
            this.Btn_Home.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnSpecialKeyPress);
            // 
            // HymDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 600);
            this.Controls.Add(this.Btn_Home);
            this.Controls.Add(this.Btn_Previous);
            this.Controls.Add(this.Btn_Next);
            this.Controls.Add(this.Btn_FullScreen2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HymDisplay";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "भजन प्रदर्शन - Hymn Display";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HymDisplay_FormClosed);
            this.Load += new System.EventHandler(this.HymDisplay_Load);
            this.SizeChanged += new System.EventHandler(this.OnScreenSizeChanges);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnSpecialKeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_FullScreen2;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Button Btn_Previous;
        private System.Windows.Forms.Button Btn_Home;
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption, string texttofill)
        {
            if (!string.IsNullOrEmpty(texttofill))
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 200 + (70 * (texttofill.Split('\n')).Length),
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                textBox.Font = new Font("Arial", 14);
                textBox.AutoSize = false;
                textBox.Multiline = true;
                textBox.ScrollBars = ScrollBars.Both;
                textBox.Height = 60 + 20 * (texttofill.Split('\n')).Length;
                textBox.Text = texttofill.Replace("\n", System.Environment.NewLine);
                Button confirmation = new Button() { Text = texttofill=="password" ? "Confirm Password": "Confirm Change", Width = 100, DialogResult = DialogResult.OK };
                confirmation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                confirmation.Location = new System.Drawing.Point(prompt.Width - 150, prompt.Height - 100);
                confirmation.Click += (sender, e) => { prompt.Close(); };
                //Button copy = new Button() { Text = "Copy Text", Width = 100 };
                //copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                //copy.Location = new System.Drawing.Point(prompt.Width - 250, prompt.Height - 100);
                //copy.Click += (sender, e) => { Clipboard.SetText(textBox.Text); textBox.Select(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                //prompt.AcceptButton = confirmation;
                prompt.BringToFront();
                prompt.TopMost = true;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "Leave the text as is";
            }
            else
            {
                return null;
            }
        }
    }
}
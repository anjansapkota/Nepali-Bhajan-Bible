using Bhajan.Classess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bhajan.Motor
{
    public partial class CustomDisplay : Form
    {
        bool showingcontrols = false;
        GA ga = new GA();
        public string path_img = "";
        public CustomDisplay()
        {
            InitializeComponent();
        }

        private void Button_Add_BG_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1 = new OpenFileDialog()
            {
                Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF",
                Title = "Open image file - फोटो छान्नु होस"
            };
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                path_img = file;
                ImageNameAdded.Text = Path.GetFileName(file);
                ImageNameAdded.Visible = true;
                button1.Visible = true;
            }
        }

        private void CustomInfoBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (CustomInfoBox.Text == "Enter text here...... यहाँ टाइप गर्नुहोस्........")
            {
                CustomInfoBox.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CustomInfoBox.Text))
                CustomInfoBox.Text = "Enter text here...... यहाँ टाइप गर्नुहोस्........";
        }

        private void Btn_Play_Click(object sender, EventArgs e)
        {
            string text = CustomInfoBox.Text;
            if (text== "Enter text here...... यहाँ टाइप गर्नुहोस्........")
            {
                text = "";
            }
            if (string.IsNullOrEmpty(text) && string.IsNullOrEmpty(path_img))
            {

            }
            else
            {

                CustomInformationDisplay cd = new CustomInformationDisplay();
                var textalign = ComboTextAlign.SelectedIndex;
                var font = CustomInfoBox.SelectionFont.FontFamily;
                cd.PrintInformation(text, path_img, textalign, font);
                ShowControls();
                ga.StartGA("CustomInformation", "Displayed", null);
            }
        }

        private void CustomDisplay_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            AddText(null, null);
            HideSlidesControls();
            ComboTextAlign.SelectedIndex = 0;
            CustomInfoBox.Font = new Font(KokilaFont.GetKokila(), 14, FontStyle.Regular);
            Cursor = Cursors.Default;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
              (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

            ga.StartGA("CustomInformation", "Started", null);
            Btn_Play.Focus();
            ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
            MenuItem menuItem = new MenuItem("Cut");
            menuItem.Click += new EventHandler(CutAction);
            contextMenu.MenuItems.Add(menuItem);
            menuItem = new MenuItem("Copy");
            menuItem.Click += new EventHandler(CopyAction);
            contextMenu.MenuItems.Add(menuItem);
            menuItem = new MenuItem("Paste");
            menuItem.Click += new EventHandler(PasteAction);
            contextMenu.MenuItems.Add(menuItem);
            CustomInfoBox.ContextMenu = contextMenu;
        }
        void CutAction(object sender, EventArgs e)
        {
            CustomInfoBox.Cut();
        }

        void CopyAction(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Rtf, CustomInfoBox.SelectedRtf);
            Clipboard.Clear();
        }

        void PasteAction(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                CustomInfoBox.SelectedRtf
                    = Clipboard.GetData(DataFormats.Rtf).ToString();
            }
            else
            {
                CustomInfoBox.Text = Clipboard.GetText();
            }
        }
        internal void HideSlidesControls()
        {
            Form cd_home = Application.OpenForms[1];
            showingcontrols = false;
            cd_home.Controls["Btn_Play"].Visible = true;
            cd_home.Controls["Btn_Stop"].Visible = false;
        }
        
        internal void ShowControls()
        {
            showingcontrols = true;
            Btn_Play.Visible = false;
            Btn_Stop.Visible = true;
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 2 && Application.OpenForms[2].Name == "CustomInformationDisplay")
            {
                var OpenHymWindow = Application.OpenForms[2];
                var btn = (Button)OpenHymWindow.Controls["Btn_Home"];
                btn.PerformClick();
            }
            HideSlidesControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            path_img = null;
            ImageNameAdded.Text = null;
            ImageNameAdded.Visible = false;
            button1.Visible = false;
        }

        private void ActiveFormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count > 2)
            {
                for (int i = 2; i < Application.OpenForms.Count; i++)
                {
                    Application.OpenForms[i].Close();
                }
            }
            Application.OpenForms[0].Show();
            Application.OpenForms[0].BringToFront();
        }

        private void OnSpecialKeyPress(object sender, KeyEventArgs e)
        {
            if (showingcontrols)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    Btn_Stop_Click(sender, e);
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void Btn_BackToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_FullScreen_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.None)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
            }
            else
            {
                Screen screen = Screen.FromControl(this);
                if (screen != null)
                    this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void LabelUnicodeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process myProcess = new Process();
            // true is the default, but it is important not to set it to false
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = "https://www.ashesh.com.np/nepali-unicode.php";
            myProcess.Start();
        }
    }
}

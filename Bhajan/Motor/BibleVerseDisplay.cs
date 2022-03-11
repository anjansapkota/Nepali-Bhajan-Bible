using Bhajan.Classess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace Bhajan.Motor
{
    public partial class BibleVerseDisplay : Form
    {
        private static string language = "";
        public BibleVerseDisplay()
        {
            InitializeComponent();
        }

        private void BibleVerseDisplay_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
        }

        private void OnScreenSizeChanges(object sender, EventArgs e)
        {
            UpdateVerseTextDisplay(sender, e, null);
        }
        private void Btn_FullScreen_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.None)
            {
                //this.TopMost = true;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
            }
            else
            {
                //this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                UpdateVerseTextDisplay(sender, e, null);
            }
        }

        public void Btn_Previous_Click(object sender, EventArgs e)
        {
            Form bible_home = Application.OpenForms[1];
            var trackbar = (TrackBar)bible_home.Controls["NumberOfVersesToDisplay"];
            var next_verse = BibleMapper.PreviousVerses(trackbar.Value, language);
            UpdateVerseTextDisplay(sender, e, next_verse);
        }
        public void Btn_Next_Click(object sender, EventArgs e)
        {
            Form bible_home = Application.OpenForms[1];
            var trackbar = (TrackBar)bible_home.Controls["NumberOfVersesToDisplay"];
            var next_verse = BibleMapper.NextVerses(trackbar.Value, language);
            UpdateVerseTextDisplay(sender, e, next_verse);
        }

        public void GoBackToHome(object sender, EventArgs e)
        {
            Form bible_home = Application.OpenForms[1];
            this.Close();
            bible_home.Show();
            bible_home.BringToFront();
            bible_home.Controls["SelectVerse"].Focus();
        }



        private void OnSpecialKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Btn_Previous_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Right)
            {
                Btn_Next_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                GoBackToHome(sender, e);
            }
            else
            {
                e.Handled = true;
            }
        }

        public void UpdateVerseTextDisplay(object sender, EventArgs e, string text)
        {
            try
            {
                var VersesTextOnDisplay = this.Controls["VersesTextOnDisplay"];
                if (VersesTextOnDisplay != null)
                {
                    VersesTextOnDisplay.ForeColor = Color.FromArgb(0, 0, 0, 138);
                    if (!string.IsNullOrEmpty(text))
                    {
                        VersesTextOnDisplay.Text = text;
                    }
                    if (this.WindowState == FormWindowState.Normal)
                    {
                        int y = Convert.ToInt32((Height - VersesTextOnDisplay.Height) / 3);
                        int x = Convert.ToInt32((Width - VersesTextOnDisplay.Width) / 2);
                        var fontsizemaker = 20;
                        while (x < 60 || y < 60)
                        {
                            VersesTextOnDisplay.Font = new Font(KokilaFont.GetKokila(), Width / fontsizemaker++, FontStyle.Bold);
                            y = Convert.ToInt32((Height - VersesTextOnDisplay.Height) / 3);
                            x = Convert.ToInt32((Width - VersesTextOnDisplay.Width) / 2);
                        }
                        VersesTextOnDisplay.Location = new Point(x, y);
                    }

                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        int y = Convert.ToInt32((Height - Height) / 3);
                        int x = Convert.ToInt32((Width - Width) / 2);
                        var fontsizemaker = 20;
                        while (x < 60 || y < 60)
                        {
                            VersesTextOnDisplay.Font = new Font(KokilaFont.GetKokila(), Width / fontsizemaker++, FontStyle.Bold);
                            y = Convert.ToInt32((Height - VersesTextOnDisplay.Height) / 3);
                            x = Convert.ToInt32((Width - VersesTextOnDisplay.Width) / 2);
                        }
                        VersesTextOnDisplay.Location = new Point(x, y);
                    }
                }
            }
            catch { }
        }

        internal void PrintVerses(int num_of_verses, string lang, bool WithBackground)
        {
            while (Application.OpenForms.Count > 2)
            {
                Application.OpenForms[(Application.OpenForms.Count) - 1].Close();
            }
            this.DoubleBuffered = true;
            var ActiveScreen = Screen.PrimaryScreen;
            if (true)
            {
                BibleVerseDisplay aa = new BibleVerseDisplay();
                if (Screen.AllScreens.Count() >= 2)
                {
                    ActiveScreen = Screen.AllScreens[1];
                    aa.StartPosition = FormStartPosition.Manual;
                    aa.Location = Screen.AllScreens[1].WorkingArea.Location;
                }
                var Width = ActiveScreen.WorkingArea.Width;
                var Height = ActiveScreen.WorkingArea.Height;
                aa.Show();
                if (WithBackground)
                {
                    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HymDisplay));
                    Random r = new Random();
                    string imagefile = "DSC" + r.Next(1, 38).ToString();
                    aa.BackgroundImage = (System.Drawing.Image)resources.GetObject(imagefile); //Image.FromFile("D:\\Images\\Unclassified\\June-Nov 2021\\DSC_8487.jpg");
                    aa.BackgroundImageLayout = ImageLayout.Stretch;
                }
                aa.TopMost = true;
                aa.BackColor = SystemColors.Window;
                language = lang;
                var Verses_Text = BibleMapper.NextVerses(num_of_verses, lang);
                SingleClickLabel VersesTextOnDisplay = new SingleClickLabel()
                {
                    Name = "VersesTextOnDisplay",
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font(KokilaFont.GetKokila(), Width / 20, FontStyle.Bold),
                    ForeColor = Color.FromArgb(255, 0, 0, 139),
                    BackColor = Color.FromArgb(220, 255, 255, 255),
                    Padding = new Padding(25, 25, 25, 25),
                    Text = Verses_Text
                };
                aa.Controls.Add(VersesTextOnDisplay);
                int y = Convert.ToInt32((Height - VersesTextOnDisplay.Height) / 3);
                int x = Convert.ToInt32((Width - VersesTextOnDisplay.Width) / 2);
                if (x < 30 || y < 30)
                {
                    var fontsizemaker = 20;
                    while (x < 60 || y < 60)
                    {
                        VersesTextOnDisplay.Font = new Font(KokilaFont.GetKokila(), Width / fontsizemaker++, FontStyle.Bold);
                        y = Convert.ToInt32((Height - VersesTextOnDisplay.Height) / 3);
                        x = Convert.ToInt32((Width - VersesTextOnDisplay.Width) / 2);
                    }
                }
                //VersesTextOnDisplay.Text = Verses_Text;
                VersesTextOnDisplay.Location = new Point(x, y);
                ContextMenu cm = new ContextMenu();
                cm.MenuItems.Add(new MenuItem("Copy Verse - पद टिपनुहोस्", (sender, e) => { Clipboard.SetText(VersesTextOnDisplay.Text); }));
                VersesTextOnDisplay.ContextMenu = cm;
                VersesTextOnDisplay.Show();
                UpdateVerseTextDisplay(null, null, null);
                PreventSleep();
            }
            else { }
        }

        private void VerseDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Bible h = new Bible();
            h.HideSlidesControls(true);
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

        [FlagsAttribute]
        public enum EXECUTION_STATE : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
            // Legacy flag, should not be used.
            // ES_USER_PRESENT = 0x00000004
        }

        void PreventSleep()
        {
            // Prevent Idle-to-Sleep (monitor not affected) (see note above)
            SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_AWAYMODE_REQUIRED);
        }

        private class SingleClickLabel : Label
        {
            protected override CreateParams CreateParams
            {
                get
                {
                    new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();

                    CreateParams cp = base.CreateParams;
                    cp.ClassStyle &= ~0x0008;
                    cp.ClassName = null;

                    return cp;
                }
            }
        }
    }
}

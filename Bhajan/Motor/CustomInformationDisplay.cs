using Bhajan.Classess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhajan.Motor
{
    public partial class CustomInformationDisplay : Form
    {
        public CustomInformationDisplay()
        {
            InitializeComponent();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Form cd_home = Application.OpenForms[1];
            this.Close();
            cd_home.Show();
            cd_home.BringToFront();
        }

        private void Btn_FullScreen2_Click(object sender, EventArgs e)
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
                this.WindowState = FormWindowState.Maximized;
                UpdateCustomMsgTextDisplay(sender, e, null);
            }
        }
        private void OnSpecialKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                GoBackToHome(sender, e);
            }
            else
            {
                e.Handled = true;
            }
        }
        private void OnScreenSizeChanges(object sender, EventArgs e)
        {
            UpdateCustomMsgTextDisplay(sender, e, null);
        }
        private void Display_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
            Form cd_home = Application.OpenForms[1];
        }

        public void GoBackToHome(object sender, EventArgs e)
        {
            Form cd_home = Application.OpenForms[1];
            this.Close();
            cd_home.Show();
            cd_home.BringToFront();
        }

        public void UpdateCustomMsgTextDisplay(object sender, EventArgs e, string text)
        {
            try
            {
                var CustomInformationDisplay = this.Controls["TextOnDisplay"];
                if (CustomInformationDisplay != null)
                {
                    var Font = CustomInformationDisplay.Font.FontFamily.Name;
                    CustomInformationDisplay.ForeColor = Color.FromArgb(0, 0, 0, 138);
                    if (!string.IsNullOrEmpty(text))
                    {
                        CustomInformationDisplay.Text = text;
                    }
                    if (this.WindowState == FormWindowState.Normal)
                    {
                        int y = Convert.ToInt32((Height - CustomInformationDisplay.Height) / 3);
                        int x = Convert.ToInt32((Width - CustomInformationDisplay.Width) / 2);
                        var fontsizemaker = 20;
                        while (x < 60 || y < 60)
                        {
                            CustomInformationDisplay.Font = new Font(Font, Width / fontsizemaker++, FontStyle.Bold);
                            y = Convert.ToInt32((Height - CustomInformationDisplay.Height) / 3);
                            x = Convert.ToInt32((Width - CustomInformationDisplay.Width) / 2);
                        }
                        CustomInformationDisplay.Location = new Point(x, y);
                    }

                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        int y = Convert.ToInt32((Height - Height) / 3);
                        int x = Convert.ToInt32((Width - Width) / 2);
                        var fontsizemaker = 20;
                        while (x < 60 || y < 60)
                        {
                            CustomInformationDisplay.Font = new Font(Font, Width / fontsizemaker++, FontStyle.Bold);
                            y = Convert.ToInt32((Height - CustomInformationDisplay.Height) / 3);
                            x = Convert.ToInt32((Width - CustomInformationDisplay.Width) / 2);
                        }
                        CustomInformationDisplay.Location = new Point(x, y);
                    }
                }
            }
            catch { }
        }

        internal void PrintInformation(string text, string path_img, int text_align, FontFamily font)
        {
            while (Application.OpenForms.Count > 2)
            {
                Application.OpenForms[(Application.OpenForms.Count) - 1].Close();
            }
            this.DoubleBuffered = true;
            var ActiveScreen = Screen.PrimaryScreen;
            if (true)
            {
                CustomInformationDisplay aa = new CustomInformationDisplay();
                if (Screen.AllScreens.Count() >= 2)
                {
                    ActiveScreen = Screen.AllScreens[1];
                    aa.StartPosition = FormStartPosition.Manual;
                    aa.Location = Screen.AllScreens[1].WorkingArea.Location;
                }
                var Width = ActiveScreen.WorkingArea.Width;
                var Height = ActiveScreen.WorkingArea.Height;
                aa.Show();
                if (File.Exists(path_img))
                {
                    aa.BackgroundImage = Image.FromFile(path_img);
                    aa.BackgroundImageLayout = ImageLayout.Zoom;
                }
                aa.TopMost = true;
                aa.BackColor = SystemColors.Window;
                if (!string.IsNullOrEmpty(text))
                {
                    SingleClickLabel VersesTextOnDisplay = new SingleClickLabel()
                    {
                        Name = "TextOnDisplay",
                        AutoSize = true,
                        Font = new Font(font.Name, Width / 20, FontStyle.Bold),
                        ForeColor = Color.FromArgb(255, 0, 0, 139),
                        BackColor = Color.FromArgb(220, 255, 255, 255),
                        Padding = new Padding(25, 25, 25, 25),
                        Text = text,
                    };

                    if (text_align == 0)
                    {
                        VersesTextOnDisplay.TextAlign = ContentAlignment.MiddleLeft;
                    }
                    else if (text_align == 1)
                    {
                        VersesTextOnDisplay.TextAlign = ContentAlignment.MiddleCenter;
                    }
                    else
                    {
                        VersesTextOnDisplay.TextAlign = ContentAlignment.MiddleRight;
                    }

                    aa.Controls.Add(VersesTextOnDisplay);
                    int y = Convert.ToInt32((Height - VersesTextOnDisplay.Height) / 3);
                    int x = Convert.ToInt32((Width - VersesTextOnDisplay.Width) / 2);
                    if (x < 30 || y < 30)
                    {
                        var fontsizemaker = 20;
                        while (x < 60 || y < 60)
                        {
                            VersesTextOnDisplay.Font = new Font(font.Name, Width / fontsizemaker++, FontStyle.Bold);
                            y = Convert.ToInt32((Height - VersesTextOnDisplay.Height) / 3);
                            x = Convert.ToInt32((Width - VersesTextOnDisplay.Width) / 2);
                        }
                    }
                    VersesTextOnDisplay.Location = new Point(x, y);
                    VersesTextOnDisplay.Show();
                }
                UpdateCustomMsgTextDisplay(null, null, null);
                PreventSleep();
            }
            else { }
        }

        private void Display_FormClosed(object sender, FormClosedEventArgs e)
        {
            CustomDisplay h = new CustomDisplay();
            h.HideSlidesControls();
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

        private void CustomInformationDisplay_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
        }
    }
}

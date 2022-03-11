using Bhajan.Classess;
using Bhajan.Motor;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Bhajan
{
    public partial class Home : Form
    {
        private bool ShowWelcome = false;
        public Home()
        {
            InitializeComponent();
            Cursor = Cursors.WaitCursor;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.FormBorderStyle = FormBorderStyle.None;
            TimeZoneInfo localZone = TimeZoneInfo.Local;
            GA ga = new GA();
            ga.StartGA("Home", "AppStarted " + localZone.DisplayName, null);
            Timer t = new Timer();
            t.Interval = 500;
            t.Tick += (xx, yy) =>
            {
                t.Stop();
                KokilaFont kokila = new KokilaFont();
                Copyright.Text += System.Environment.NewLine + "Version: " + UpdatesChecker.GetVersion();
                if (!ShowWelcome)
                {
                    Timer timer = new Timer();
                    timer.Interval = 2000;
                    timer.Tick += (aa, bb) => { ShowWelcomeMessage(aa); };
                    timer.Start();
                    ShowWelcome = true;
                }
                else
                {
                    showAllItems();
                }
            };
            t.Start();
        }

        private void Bible_Opener_Click(object sender, EventArgs e)
        {
            this.Hide();
            var bible_home = new Bible();
            bible_home.Show();
        }
        private void Bhajan_Opener_Click(object sender, EventArgs e)
        {
            this.Hide();
            var bhajan_home = new Bhajan();
            bhajan_home.Show();
        }

        internal static void showAllItems()
        {
            var home = Application.OpenForms[0];
            home.Controls["WelcomeMessage"].Visible = false;
            home.Controls["Bible_Opener"].Visible = true;
            home.Controls["Bhajan_Opener"].Visible = true;
            home.Controls["Btn_Extras"].Visible = true;
            home.Controls["Btn_Info"].Visible = true;
            home.Controls["Btn_TutorialLink"].Visible = true;
        }
        internal static void HideAllItems()
        {
            var home = Application.OpenForms[0];
            home.Controls["WelcomeMessage"].Visible = false;
            home.Controls["Bible_Opener"].Visible = false;
            home.Controls["Bhajan_Opener"].Visible = false;
            home.Controls["Btn_Extras"].Visible = false;
        }
        
        public void HideAllItemsForDownload()
        {
            var home = Application.OpenForms[0];
            home.Controls["WelcomeMessage"].Visible = false;
            home.Controls["Bible_Opener"].Visible = false;
            home.Controls["Bhajan_Opener"].Visible = false;
            home.Controls["Btn_Extras"].Visible = false;
            home.Controls["Btn_Info"].Visible = false;
            home.Controls["Btn_TutorialLink"].Visible = false;
            home.Controls["UpdateDownloadprogressBar"].Visible = true;
            home.Controls["LabelUpdateDownloadprogress"].Visible = true;
            home.Controls["LabelUpdateDownloadMessage"].Visible = true;
        }

        public static bool welcome = false;
        public void ShowWelcomeMessage(object sender)
        {
            if (!welcome)
            {
                welcome = true;
            }
            else
            {
                showAllItems();
                ((Timer)sender).Stop();
                this.Cursor = Cursors.Default;
                if (CheckSurveyInfo())
                {
                    UpdatesChecker updatecheck = new UpdatesChecker();
                    updatecheck.UpdateCheck();
                }
            }
        }

        internal bool CheckSurveyInfo()
        {
            GAID gaid = GA.PrepareClientID();
            if (!gaid.NewUserInfoProvided)
            {
                var nus = new NewUserSurvey();
                nus.Show();
                HideAllItems();
                return false;
            }
            else
            {
                if (!gaid.GeoCordinatesCollected)
                {
                    GA.GetLocationData();
                }
                else if (!gaid.NewUserInfoSentToTheServer)
                {
                    GA.saveGAID();
                }
            }
            return true;
        }

        private void Btn_Info_Click(object sender, EventArgs e)
        {
            this.Refresh();
            DialogResult result = MessageBox.Show(SoftwareInfo.softwareinfo,
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2);
        }

        private void Btn_Extras_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cd = new CustomDisplay();
            cd.Show();
        }

        private void Btn_TutorialLink_Click(object sender, EventArgs e)
        {
            try
            {
                Process myProcess = new Process();
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "https://youtu.be/oxEFnlrC6do";
                myProcess.Start();
                ((Form)sender).Close();
            }
            catch { }
        }

        private void Btn_TutorialLink_MouseEnter(object sender, EventArgs e)
        {
            TooltipYoutube.Visible = true;
        }

        private void Btn_TutorialLink_MouseLeave(object sender, EventArgs e)
        {
            TooltipYoutube.Visible = false;
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
    }
}

using Bhajan.Classess;
using Bhajan.Models;
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
    public partial class HymDisplay : Form
    {
        private static string language;
        public HymDisplay()
        {
            InitializeComponent();
        }

        private void HymDisplay_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
            Form bhajan_home = Application.OpenForms[1];
            bhajan_home.Controls["Btn_ViewControls"].Visible = true;
            language = bhajan_home.Controls["ComboLanguage"].Text;
        }

        private void OnScreenSizeChanges(object sender, EventArgs e)
        {
            UpdateHymTextDisplay(sender, e, null);
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
                UpdateHymTextDisplay(sender, e, null);
            }
        }

        public void Btn_Previous_Click(object sender, EventArgs e)
        {
            var prev_verse = HymMapper.PreviousVerse(language);
            UpdateHymTextDisplay(sender, e, prev_verse);
        }
        public void Btn_Next_Click(object sender, EventArgs e)
        {
            var next_verse = HymMapper.NextVerse(language);
            UpdateHymTextDisplay(sender, e, next_verse);
        }

        public void GoBackToHome(object sender, EventArgs e)
        {
            Form bhajan_home = Application.OpenForms[1];
            this.Close();
            bhajan_home.Show();
            bhajan_home.BringToFront();
            bhajan_home.Controls["Txt_SearchByNum"].Focus();
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

        private void OnClickHym_Click(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog("Password", "Provide the password first.", "password");
            if (promptValue == "ANJANSDA7")
            {

                var HymTextOnDisplay = this.Controls["HymTextOnDisplay"];
                var lastslide = HymMapper.last_slide;
                string text_to_edit = "";
                if (lastslide == 0)
                {
                    text_to_edit = HymMapper.activehym.Title;
                    promptValue = Prompt.ShowDialog("Edit Title", "Please edit the Title here.", text_to_edit);
                    if (promptValue != "Leave the text as is" && text_to_edit != promptValue)
                    {
                        if (!string.IsNullOrEmpty(promptValue)) { }
                        HymMapper.activehym.Title = promptValue;
                        Bhajan h = new Bhajan();
                        h.ShowNumbersAndTitlesOfHyms();
                    }
                    promptValue = "";
                    text_to_edit = HymMapper.activehym.Description;
                    if (!string.IsNullOrEmpty(text_to_edit))
                    {
                        promptValue = Prompt.ShowDialog("Edit Description", "Please edit the description of the hym here.", text_to_edit);
                    }
                    if (promptValue != "Leave the text as is" && text_to_edit != promptValue)
                    {
                        if (!string.IsNullOrEmpty(promptValue))
                        {
                            HymMapper.activehym.Description = promptValue;
                        }
                    }
                    promptValue = "";
                    text_to_edit = HymMapper.activehym.Number.ToString();
                    if (!string.IsNullOrEmpty(text_to_edit))
                    {
                        promptValue = Prompt.ShowDialog("Edit hym number", "Please edit the hym number here.", text_to_edit);
                    }
                    if (promptValue != "Leave the text as is" && text_to_edit != promptValue)
                    {
                        if (!string.IsNullOrEmpty(promptValue))
                        {
                            var otherhymwithsamenumber = (from _Hym in HymMapper.ActiveHymnal
                                                          where _Hym.Number == Convert.ToInt32(promptValue)
                                                          select _Hym).FirstOrDefault();
                            otherhymwithsamenumber.Number = HymMapper.activehym.Number;
                            HymMapper.activehym.Number = Convert.ToInt32(promptValue);
                            HymMapper.ActiveHymnal = HymMapper.ActiveHymnal.OrderBy(o => o.Number).ToList();
                        }
                    }
                }
                else
                {
                    if (language == "भजन")
                    {
                        Stanza stanza_to_edit = (from stanza in HymMapper.activehym.stanzas
                                        where stanza.SlideNumbers.Contains(lastslide)
                                        select stanza).FirstOrDefault();
                        text_to_edit = stanza_to_edit.StanzaText;
                        promptValue = Prompt.ShowDialog("Edit Hym Lines", "Please edit the hym lines here.", text_to_edit);
                        if (promptValue != "Leave the text as is" && text_to_edit != promptValue)
                        {
                            if (!string.IsNullOrEmpty(promptValue))
                            {
                                stanza_to_edit.StanzaText = promptValue;
                            }
                            else
                            {                                
                                HymMapper.activehym.stanzas.Remove(stanza_to_edit);
                                MappingFunctions.ReArrangeHymSlidesAndStanzas(language, HymMapper.activehym);
                            }
                        }
                    }
                    else if (language == "Bhajan")
                    {
                        Stanza stanza_to_edit = (from stanza in HymMapper.activehym.stanzas
                                                 where stanza.SlideNumbers.Contains(lastslide)
                                                 select stanza).FirstOrDefault();
                        text_to_edit = stanza_to_edit.StanzaTextRomanized;
                        promptValue = Prompt.ShowDialog("Edit Hym Lines", "Please edit the hym lines here.", text_to_edit);
                        if (promptValue != "Leave the text as is" && text_to_edit != promptValue)
                        {
                            if (!string.IsNullOrEmpty(promptValue))
                            {
                                stanza_to_edit.StanzaTextRomanized = promptValue;
                            }
                            else
                            {                                
                                HymMapper.activehym.stanzas.Remove(stanza_to_edit);
                                MappingFunctions.ReArrangeHymSlidesAndStanzas(language, HymMapper.activehym);
                            }
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Euta Language ma matrai editing garna milcha, \r\n please go back and select only one text style, \r\n not both.",
                        "Ooops!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button2);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            // Closes the parent form.
                            this.Close();
                        }
                    }
                }
            }
        }
        public void UpdateHymTextDisplay(object sender, EventArgs e, string text)
        {
            try
            {
                var HymTextOnDisplay = this.Controls["HymTextOnDisplay"];
                if (HymTextOnDisplay != null)
                {
                    HymTextOnDisplay.ForeColor = Color.FromArgb(0, 0, 0, 138);
                    if (!string.IsNullOrEmpty(text))
                    {
                        HymTextOnDisplay.Text = text;
                    }
                    if (this.WindowState == FormWindowState.Normal)
                    {
                        int y = Convert.ToInt32((Height - HymTextOnDisplay.Height) / 3);
                        int x = Convert.ToInt32((Width - HymTextOnDisplay.Width) / 2);
                        var fontsizemaker = 20;
                        while (x < 60 || y < 60)
                        {
                            HymTextOnDisplay.Font = new Font(KokilaFont.GetKokila(), Width / fontsizemaker++, FontStyle.Bold);
                            y = Convert.ToInt32((Height - HymTextOnDisplay.Height) / 3);
                            x = Convert.ToInt32((Width - HymTextOnDisplay.Width) / 2);
                        }
                        HymTextOnDisplay.Location = new Point(x, y);
                    }

                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        int y = Convert.ToInt32((Height - Height) / 3);
                        int x = Convert.ToInt32((Width - Width) / 2);
                        var fontsizemaker = 20;
                        while (x < 60 || y < 60)
                        {
                            HymTextOnDisplay.Font = new Font(KokilaFont.GetKokila(), Width / fontsizemaker++, FontStyle.Bold);
                            y = Convert.ToInt32((Height - HymTextOnDisplay.Height) / 3);
                            x = Convert.ToInt32((Width - HymTextOnDisplay.Width) / 2);
                        }
                        HymTextOnDisplay.Location = new Point(x, y);
                    }
                }
            }
            catch { }
        }

        internal void PrintHym(Hym hym, bool WithBackground)
        {
            while(Application.OpenForms.Count > 2)
            {
                Application.OpenForms[(Application.OpenForms.Count) - 1].Close();
            }
            this.DoubleBuffered = true;
            var ActiveScreen = Screen.PrimaryScreen;
            if (hym != null)
            {
                HymDisplay aa = new HymDisplay();
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
                var Hym_Text = HymMapper.StartHym(language);
                SingleClickLabel HymTextOnDisplay = new SingleClickLabel()
                {
                    Name = "HymTextOnDisplay",
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font(KokilaFont.GetKokila(), Width / 20, FontStyle.Bold),
                    ForeColor = Color.FromArgb(255, 0, 0, 139),
                    BackColor = Color.FromArgb(220, 255, 255, 255),
                    Padding = new Padding(25, 25, 25, 25),
                    Text = Hym_Text
                };
                aa.Controls.Add(HymTextOnDisplay);
                int y = Convert.ToInt32((Height - HymTextOnDisplay.Height) / 3);
                int x = Convert.ToInt32((Width - HymTextOnDisplay.Width) / 2);
                if (x < 30 || y < 30)
                {
                    var fontsizemaker = 20;
                    while (x < 60 || y < 60)
                    {
                        HymTextOnDisplay.Font = new Font(KokilaFont.GetKokila(), Width / fontsizemaker++ , FontStyle.Bold);
                        y = Convert.ToInt32((Height - HymTextOnDisplay.Height) / 3);
                        x = Convert.ToInt32((Width - HymTextOnDisplay.Width) / 2);
                    }
                }
                HymTextOnDisplay.Text = Hym_Text;
                HymTextOnDisplay.Location = new Point(x, y);
                ContextMenu cm = new ContextMenu();
                cm.MenuItems.Add(new MenuItem("Edit", new EventHandler(OnClickHym_Click)));
                //HymTextOnDisplay.DoubleClick += new EventHandler(OnClickHym_Click);
                HymTextOnDisplay.ContextMenu = cm;
                HymTextOnDisplay.Show();
                UpdateHymTextDisplay(null, null, null);
                PreventSleep();
            }
            else { }
        }

        private void HymDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Bhajan h = new Bhajan();
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

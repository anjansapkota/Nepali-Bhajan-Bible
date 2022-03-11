using Bhajan.Classess;
using Bhajan.Models;
using Bhajan.Motor;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhajan
{
    public partial class Bhajan : Form
    {
        public static bool dev = false;
        public static string dev_inserted_text = "";
        public static string ActiveHymBook = "";
        private static Hym  SelectedHym = null;
        private static List<string> ActiveHymListNames;
        public static List<Button> SlideNumbersButtons = new List<Button> ();
        public static bool showingcontrols = false;
        GA ga = new GA();
        public Bhajan()
        {
            InitializeComponent();
            Cursor = Cursors.WaitCursor;
        }

        private void Bhajan_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.FormBorderStyle = FormBorderStyle.None;
            Timer t = new Timer();
            t.Interval = 500;
            t.Tick += (xx, yy) => {
                t.Stop();
                if (string.IsNullOrEmpty(SelectHymBookCat.SelectedItem == null ? "" : SelectHymBookCat.SelectedItem.ToString()))
                {
                    SelectHymBookCat.SelectedItem = "भजन (ने.ख्री.भ)";
                    ComboLanguage.SelectedItem = "भजन";
                    ActiveHymBook = "Nepali";
                }
                ga.StartGA("Bhajan", "Bhajan Started", null);
                this.Cursor = Cursors.Default;
            };
            t.Start();
        }

        private void Btn_FullScreen_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.None)
            {
                Txt_SearchByTitle.Size = new System.Drawing.Size(611, 33);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
            }
            else
            {
                Screen screen = Screen.FromControl(this);
                if(screen!=null)
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Txt_SearchByNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = Txt_SearchByNum.Text;
                HymMapper mapper = new HymMapper();
                var hym = mapper.FindHymByNumber(Convert.ToInt32(txt));
                Txt_SearchByTitle.SelectedItem = (string.IsNullOrEmpty(hym.Title.ToString()) ? "" : hym.TitleRomanized.ToString() + " 🎵 ") + hym.Title.ToString();
                SelectedHym = hym;
            }
            catch
            {

            }
        }
        private void Txt_SearchByTitle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = Txt_SearchByTitle.Text;
                if (!string.IsNullOrEmpty(txt))
                {
                    HymMapper mapper = new HymMapper();
                    string title = txt.Split(new string[] { " 🎵 " }, StringSplitOptions.None)[0];
                    Hym hym = mapper.FindHymByTitle(title);
                    Txt_SearchByNum.SelectedItem = hym.Number.ToString();
                    SelectedHym = hym;
                }
            }
            catch
            {

            }
        }

        private void Txt_SearchByNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }
        private void Txt_SearchByTitle_OnTextUpdate(object sender, EventArgs e)
        {
            var original_input_text = Txt_SearchByTitle.Text;
            Txt_SearchByTitle.AutoCompleteMode = AutoCompleteMode.None;
            Txt_SearchByTitle.AutoCompleteSource = AutoCompleteSource.None;
            var searched_text = Txt_SearchByTitle.Text.ToUpper();
            if (!string.IsNullOrEmpty(searched_text))
            {
                //var filteredList = (from a in ActiveHymListNames
                //                    where a.ToString().ToUpper().Contains(searched_text)
                //                    select a).ToList();


                //very complex select --I'm happy
                var filteredList = new List<string>();
                if (ActiveHymBook == "English SDA")
                {
                    filteredList = (from h in HymMapper.ActiveHymnal
                                    where h.stanzas.Any(ss => ss.StanzaTextRomanized.ToUpper().Contains(searched_text))
                                    select h.TitleRomanized.ToString()).ToList();
                }
                else
                {
                    filteredList = (from h in HymMapper.ActiveHymnal
                                    where h.stanzas.Any(ss => ss.StanzaText.ToUpper().Contains(searched_text) || ss.StanzaTextRomanized.ToUpper().Contains(searched_text))
                                    select (string.IsNullOrEmpty(h.Title.ToString()) ? "" : h.TitleRomanized.ToString() + " 🎵 ") + h.Title.ToString()).ToList();
                }


                if (filteredList.Count > 0)
                {

                    System.Object[] ItemObject = new System.Object[filteredList.Count()];
                    for (int i = 0; i < filteredList.Count(); i++)
                    {
                        ItemObject[i] = filteredList[i].ToString();
                    }
                    Txt_SearchByTitle.DataSource = null;
                    Txt_SearchByTitle.DataSource = ItemObject;
                    Txt_SearchByTitle.DroppedDown = true;
                    Txt_SearchByTitle.Text = original_input_text;
                    Txt_SearchByTitle.SelectionStart = original_input_text.Length;
                    Txt_SearchByTitle.SelectionLength = 0;
                    Cursor.Current = Cursors.Default;
                }
            }
            else if (string.IsNullOrEmpty(searched_text) && Txt_SearchByTitle.Items.Count != ActiveHymListNames.Count())
            {
                Txt_SearchByTitle.DroppedDown = false;
                System.Object[] ItemObject = new System.Object[ActiveHymListNames.Count()];
                for (int i = 0; i < ActiveHymListNames.Count(); i++)
                {
                    ItemObject[i] = ActiveHymListNames[i].ToString();
                }
                Txt_SearchByTitle.DataSource = ItemObject;
                Txt_SearchByTitle.Text = original_input_text;
                Txt_SearchByTitle.DroppedDown = true;
                Txt_SearchByTitle.SelectionStart = original_input_text.Length;
                Txt_SearchByTitle.SelectionLength = 0;
                Cursor.Current = Cursors.Default;
            }
        }
        private void ShowSoftwareInfo(object sender, EventArgs e)
        {
            dev = true;
            dev_inserted_text = "";
            this.Refresh();
            DialogResult result = MessageBox.Show(SoftwareInfo.softwareinfo,
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2);

        }

        private void OnSpecialKeyPress(object sender, KeyEventArgs e)
        {
            if (showingcontrols)
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
                    Btn_StopPlaying_Click(sender, e);
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (dev && dev_inserted_text.Length < 10)
                {
                    dev_inserted_text += e.KeyValue;
                    if (dev_inserted_text == "6578746578")
                    {
                        AddHymsView add_hym_view = new AddHymsView();
                        add_hym_view.Show();
                        dev_inserted_text = "";
                    }
                }
                else
                {
                    e.Handled = true;
                    dev_inserted_text = "";
                    dev = false;
                }
            }
        }

        public void  ShowNumbersAndTitlesOfHyms()
        {
            List<Hym> hymnal = HymMapper.ActiveHymnal;
            var numbers = (from h in hymnal select h.Number.ToString()).ToList();
            System.Object[] ItemObject = new System.Object[numbers.Count()];
            for (int i = 0; i < numbers.Count(); i++)
            {
                ItemObject[i] = numbers[i].ToString();
            }
            Txt_SearchByNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            Txt_SearchByNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            Txt_SearchByNum.Items.Clear();
            Txt_SearchByNum.Items.AddRange(ItemObject);
            //
            var titles = (from h in hymnal select (string.IsNullOrEmpty(h.Title.ToString()) ?"" : h.TitleRomanized.ToString() + " 🎵 ") + h.Title.ToString()).ToList();
            ActiveHymListNames = titles;
            System.Object[] ItemObject2 = new System.Object[titles.Count()];
            for (int i = 0; i < titles.Count(); i++)
            {
                ItemObject2[i] = titles[i].ToString();
            }
            Txt_SearchByTitle.DataSource = null;
            Txt_SearchByTitle.Items.Clear();
            Txt_SearchByTitle.Items.AddRange(ItemObject2);
            Txt_SearchByTitle.DataSource = ItemObject2;
            Txt_SearchByTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            Txt_SearchByTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            Txt_SearchByNum.SelectedIndex = 0;
            Txt_SearchByTitle.SelectedIndex = 0;
        }

        private void SelectHymBookCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedItem = SelectHymBookCat.SelectedItem.ToString();
            if (SelectedItem == "भजन (ने.ख्री.भ)")
            {
                Txt_SearchByNum.SelectedItem = null;
                Txt_SearchByTitle.SelectedItem = null;
                HymMapper.ChooseHymnal(1);
                ShowNumbersAndTitlesOfHyms();
            }
            else if (SelectedItem == "कोरस")
            {
                Txt_SearchByNum.SelectedItem = null;
                Txt_SearchByTitle.SelectedItem = null;
                HymMapper.ChooseHymnal(2);
                ShowNumbersAndTitlesOfHyms();
            }
            else if (SelectedItem == "बाल गीत")
            {
                Txt_SearchByNum.SelectedItem = null;
                Txt_SearchByTitle.SelectedItem = null;
                HymMapper.ChooseHymnal(3);
                ShowNumbersAndTitlesOfHyms();
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if(SelectedHym != null)
            {
                HymDisplay h = new HymDisplay();
                h.PrintHym(SelectedHym, Check_WithBackground.Checked);
                ShowSlidesControls();
            }
            ga.StartGA("Bhajan", ActiveHymBook + " Hym Displayed" + " - " + SelectedHym.Number + " - " + SelectedHym.TitleRomanized, SelectedHym.Number);
        }

        private void Book1_Click(object sender, EventArgs e)
        {
            if (Book1.Text.Contains("📖"))
            {
                Book1.Text = Book1.Text.Replace("📖", "✔️");
                Book3.Text = Book3.Text.Replace("✔️", "📖");
                Book1.ForeColor = Color.White;
                Book3.ForeColor = Color.Gray;
                SelectHymBookCat.Items.Clear();
                SelectHymBookCat.Items.Add("भजन (ने.ख्री.भ)");
                SelectHymBookCat.Items.Add("कोरस");
                SelectHymBookCat.Items.Add("बाल गीत");
                SelectHymBookCat.SelectedIndex = 0;
                ComboLanguage.Enabled = true;
                ComboLanguage.SelectedItem = "भजन";

                label_Bhajan_Sangraha.Visible = true;
                label_Number.Visible = true;
                label_title.Visible = true;
                label_language.Visible = true;
                HymMapper.ChooseHymnal(1);
                ShowNumbersAndTitlesOfHyms();
                ActiveHymBook = "Nepali";
            }

        }

        private void Book3_Click(object sender, EventArgs e)
        {
            if (Book3.Text.Contains("📖"))
            {
                Book1.Text = Book1.Text.Replace("✔️", "📖");
                Book3.Text = Book3.Text.Replace("📖", "✔️");
                Book1.ForeColor = Color.Gray;
                Book3.ForeColor = Color.White;
                SelectHymBookCat.Items.Clear();
                SelectHymBookCat.Items.Add("SDA Hymnal");
                SelectHymBookCat.SelectedItem = "SDA Hymnal";
                ComboLanguage.SelectedItem = "Bhajan";
                ComboLanguage.Enabled = false;

                label_Bhajan_Sangraha.Visible = false;
                label_Number.Visible = false;
                label_title.Visible = false;
                label_language.Visible = false;

                HymMapper.ChooseHymnal(6);
                ShowNumbersAndTitlesOfHyms();
                ActiveHymBook = "English SDA";
            }
        }
        private void Btn_Previous_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 2 && Application.OpenForms[2].Name == "HymDisplay")
            {
                var OpenHymWindow = Application.OpenForms[2];
                var previousbtn = (Button)OpenHymWindow.Controls["Btn_Previous"];
                previousbtn.PerformClick();
            }
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 2 && Application.OpenForms[2].Name == "HymDisplay")
            {
                var OpenHymWindow = Application.OpenForms[2];
                var btn = (Button)OpenHymWindow.Controls["Btn_Next"];
                btn.PerformClick();
            }
        }

        private void Btn_StopPlaying_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 2 && Application.OpenForms[2].Name == "HymDisplay")
            {
                var OpenHymWindow = Application.OpenForms[2];
                var btn = (Button)OpenHymWindow.Controls["Btn_Home"];
                btn.PerformClick();
            }
            Btn_ViewControls.Visible = false;
            HideSlidesControls(true);
        }

        private void Btn_GoBackKeepPlaying_Click(object sender, EventArgs e)
        {
            Btn_ViewControls.Visible = true;
            HideSlidesControls(false);
        }

        public void HideSlidesControls(bool issongstopping)
        {
            var bhajan_home = Application.OpenForms[1];
            showingcontrols = false;
            //buttons
            bhajan_home.Controls["Btn_StopPlaying"].Visible = false;
            bhajan_home.Controls["Btn_GoBackKeepPlaying"].Visible = false;
            bhajan_home.Controls["Btn_Next"].Visible = false;
            bhajan_home.Controls["Btn_Previous"].Visible = false;

            if (issongstopping)
            {
                bhajan_home.Controls["Btn_ViewControls"].Visible = false;
                if (SlideNumbersButtons.Count > 0)
                {
                    foreach (Button b in SlideNumbersButtons)
                    {
                        bhajan_home.Controls.Remove(b);
                    }
                }
                bhajan_home.Controls["Book1"].Visible = true;
                //OpenHymWindow.Controls["Book2"].Visible = true;
                bhajan_home.Controls["Book3"].Visible = true;
                SlideNumbersButtons.Clear();

            }
            else
            {
                foreach (Button b in SlideNumbersButtons)
                {
                    b.Visible = false;
                }
            }
            //HomeStuff
            bhajan_home.Controls["SelectHymBookCat"].Visible = true;
            bhajan_home.Controls["ComboLanguage"].Visible = true;
            bhajan_home.Controls["Txt_SearchByNum"].Visible = true;
            bhajan_home.Controls["Txt_SearchByTitle"].Visible = true;
            bhajan_home.Controls["Btn_Play"].Visible = true;
            bhajan_home.Controls["Btn_Info"].Visible = true;
            bhajan_home.Controls["label_Bhajan_Sangraha"].Visible = true;
            bhajan_home.Controls["label_language"].Visible = true;
            bhajan_home.Controls["label_Number"].Visible = true;
            bhajan_home.Controls["label_title"].Visible = true;
            bhajan_home.Controls["Check_WithBackground"].Visible = true;
            //SlideButtons
        }
        
        public void ShowSlidesControls()
        {
            showingcontrols = true;
            var OpenHymWindow = Application.OpenForms[1];
            //buttons
            OpenHymWindow.Controls["Btn_StopPlaying"].Visible = true;
            OpenHymWindow.Controls["Btn_GoBackKeepPlaying"].Visible = true;
            OpenHymWindow.Controls["Btn_Next"].Visible = true;
            OpenHymWindow.Controls["Btn_Previous"].Visible = true;

            OpenHymWindow.Controls["Btn_ViewControls"].Visible = false;
            //HomeStuff
            OpenHymWindow.Controls["SelectHymBookCat"].Visible = false;
            OpenHymWindow.Controls["ComboLanguage"].Visible = false;
            OpenHymWindow.Controls["Txt_SearchByNum"].Visible = false;
            OpenHymWindow.Controls["Txt_SearchByTitle"].Visible = false;
            OpenHymWindow.Controls["Btn_Play"].Visible = false;
            OpenHymWindow.Controls["Btn_Info"].Visible = false;
            OpenHymWindow.Controls["label_Bhajan_Sangraha"].Visible = false;
            OpenHymWindow.Controls["label_language"].Visible = false;
            OpenHymWindow.Controls["label_Number"].Visible = false;
            OpenHymWindow.Controls["label_title"].Visible = false;
            OpenHymWindow.Controls["Book1"].Visible = false;
            //OpenHymWindow.Controls["Book2"].Visible = false;
            OpenHymWindow.Controls["Book3"].Visible = false;
            OpenHymWindow.Controls["Check_WithBackground"].Visible = false;
            DisplayButtonsForStanzas();
            foreach (Button b in SlideNumbersButtons)
            {
                b.Visible = true;
            }
        }

        private Button GetButtonsWithGeneralAttributes(string name, int sizetimes_big)
        {
            Button temp_button = new Button();
            temp_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.None)));
            temp_button.Cursor = System.Windows.Forms.Cursors.Hand;
            temp_button.Name = name;
            temp_button.Size = new System.Drawing.Size(50 * sizetimes_big, 50 * sizetimes_big);
            temp_button.Visible = false;
            temp_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            temp_button.UseVisualStyleBackColor = true;
            temp_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            temp_button.TextAlign = ContentAlignment.MiddleCenter;
            temp_button.Font = new Font("Arial", Width / 25);
            temp_button.ForeColor = Color.FromArgb(255, 0, 0, 139);
            temp_button.BackColor = Color.FromArgb(200, 255, 255, 255);
            temp_button.Click += new EventHandler(ChangeStanzaTo);
            return temp_button;
        }

        private void Btn_ViewControls_Click(object sender, EventArgs e)
        {
            ShowSlidesControls();
        }

        private void DisplayButtonsForStanzas()
        {
            if (SlideNumbersButtons.Count == 0)
            {
                int row = 1, col = 1;
                int buttonsizetimes = 3;
                var slides = (from stanza in SelectedHym.stanzas
                              where stanza.IsChorus == false && stanza.IsExtendedToPrevoius == false
                              select stanza.SlideNumbers).ToList();
                int magnifier = slides.Count();
                if(magnifier < 4)
                {
                    magnifier = 4;
                }
                int startWidth = 0;

                if (slides.Count() > 8) {
                    buttonsizetimes = 2;
                    startWidth = (Width - 4 * 150) / 2;
                }
                else if (slides.Count() > 4)
                {
                    startWidth = (Width - 4 * 150) / 2;
                }
                else
                {
                    startWidth = (Width - slides.Count() * 150) / 2;
                }
                int h = Height / magnifier;
                int w = startWidth;
                foreach (List<int> sub_slide_list in slides)
                {
                    foreach (int s in sub_slide_list)
                    {
                        if (col > 1)
                        {
                            w = w + 150;
                        }
                        var Button = GetButtonsWithGeneralAttributes("Stanza" + s.ToString(), buttonsizetimes);
                        Button.Text = (SlideNumbersButtons.Count + 1).ToString();
                        Button.Location = new Point(w, h);
                        SlideNumbersButtons.Add(Button);
                        this.Controls.Add(Button);
                        if (col == 4)
                        {
                            row++;
                            col = 1;
                            w = startWidth;
                            h = 10 + h + buttonsizetimes * 50;
                        }
                        else
                        {
                            col++;
                        }
                    }
                }
            }
        }

        private void ChangeStanzaTo(object sender, EventArgs e)
        {
            var sendingbutton = (Button)sender;
            var lastslide = Convert.ToInt32(sendingbutton.Name.Replace("Stanza", ""));
            HymMapper.last_slide = lastslide-1;
            Btn_Next_Click(sender, e);
        }

        private void Bhajan_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            dev = false;
            dev_inserted_text = "";
            SelectedHym = null;
            ActiveHymListNames =new List<string>();
            SlideNumbersButtons = new List<Button>();
            showingcontrols = false;
            if(Application.OpenForms.Count > 2)
            {
                for(int i = 2; i < Application.OpenForms.Count; i++)
                {
                    Application.OpenForms[i].Close();
                }
            }
            Application.OpenForms[0].Show();
            Application.OpenForms[0].BringToFront();
        }

        private void Btn_BackToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

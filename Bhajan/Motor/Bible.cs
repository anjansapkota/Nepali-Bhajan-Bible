using Bhajan.Classess;
using Bhajan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhajan.Motor
{
    public partial class Bible : Form
    {
        private static bool AreBooksMapped = false;
        internal static int activebook = -1;
        internal static int activechapter = -1;
        internal static int activeverse = -1;
        internal static bool NepaliActive = true;
        internal static bool EnglishActive = false;
        internal static bool showingcontrols = false;
        GA ga = new GA();
        public Bible()
        {
            InitializeComponent();
            Cursor = Cursors.WaitCursor;
        }

        private void Bible_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Timer t = new Timer();
            t.Interval = 500;
            t.Tick += (xx, yy) => {
                t.Stop();
                LoadNepaliBible();
                ga.StartGA("Bible", "Bible Started", null);
                this.Cursor = Cursors.Default;
            };
            t.Start();
        }

        private void LoadNepaliBible()
        {
            BibleMapper mapper = new BibleMapper();
            BibleMapper.MapBibles();
            ShowCombos(0,0);
        }
        private void Play_Click(object sender, EventArgs e)
        {
            if (NepaliActive || EnglishActive)
            {
                if (SelectVerse.SelectedIndex >= 0)
                {
                    BibleMapper.ForNext_ActiveBook_Pos = activebook;
                    BibleMapper.ForNext_ActiveChapter_Pos = activechapter;
                    BibleMapper.ForNext_ActiveVerse_Pos = activeverse;
                    BibleMapper.ForPrev_ActiveBook_Pos = activebook;
                    BibleMapper.ForPrev_ActiveChapter_Pos = activechapter;
                    BibleMapper.ForPrev_ActiveVerse_Pos = activeverse;
                    BibleVerseDisplay b = new BibleVerseDisplay();
                    b.PrintVerses(NumberOfVersesToDisplay.Value, GetLanguage(), Check_WithBackground.Checked);
                    ShowSlidesControls();
                    ga.StartGA("Bible", GetLanguage() + " Bible Displayed" + " - " + BibleMapper.BooksEnglish[activebook] + " - " + (activechapter + 1).ToString() + " - " + (activeverse + 1).ToString(), null);
                    this.Focus();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("कृपया पहिले एउटा बाइबल छान्नुहोस्। \r\n Please select a bible first.",
                    "कुन बाइबल? Which Bible?",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2
                    );
            }
        }

        private string GetLanguage()
        {
            if (EnglishActive && NepaliActive)
            {
                return "BOTH";
            } 
            else if (EnglishActive && !NepaliActive) {
                return "EN";
            }
            else if (!EnglishActive && NepaliActive) {
                return "NP";
            }
            return "";
        }
        private string GetPreviewVerse()
        {
            string verse_preview = "";
            if (EnglishActive && NepaliActive & SelectVerse.SelectedIndex >= 0)
            {
                verse_preview = LocalVerseView.Text = BibleMapper.NepaliBible.Book[activebook].Chapter[activechapter].Verse[activeverse].Verse;
                verse_preview += System.Environment.NewLine + "-------------------------" + System.Environment.NewLine;
                verse_preview += LocalVerseView.Text = BibleMapper.EnglishBible.Book[activebook].Chapter[activechapter].Verse[activeverse].Verse;
                return verse_preview;
            } 
            else if (EnglishActive && !NepaliActive && SelectVerse.SelectedIndex >= 0) {
                verse_preview = LocalVerseView.Text = BibleMapper.EnglishBible.Book[activebook].Chapter[activechapter].Verse[activeverse].Verse;
                return verse_preview;
            }
            else if (!EnglishActive && NepaliActive && SelectVerse.SelectedIndex >= 0) {
                verse_preview = LocalVerseView.Text = BibleMapper.NepaliBible.Book[activebook].Chapter[activechapter].Verse[activeverse].Verse;
                return verse_preview;
            }
            return "";
        }
        private void ShowCombos(int book_pos, int chapter_pos)
        {
            Bible_W_AllChapters bible = BibleMapper.NepaliBible;
            if (!AreBooksMapped)
            {
                System.Object[] ItemObject_Books = new System.Object[BibleMapper.BooksNepali.Count()];
                for (int i = 0; i < BibleMapper.BooksNepali.Count(); i++)
                {
                    ItemObject_Books[i] = BibleMapper.BooksNepali[i].ToString() + " 🗞 " + BibleMapper.BooksEnglish[i].ToString();
                }
                SelectBook.Items.Clear();
                SelectBook.Items.AddRange(ItemObject_Books);
                SelectBook.DataSource = ItemObject_Books;
                SelectBook.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
                SelectBook.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
                SelectBook.SelectedIndex = 0;
                SelectChapter.Items.Clear();
                SelectVerse.Items.Clear();
                AreBooksMapped = true;
                ShowCombos(0, -1);
            }
            else
            {
                if (book_pos != activebook && book_pos >=0)
                {
                    activebook = book_pos;
                    var numbers = bible.Book[book_pos].Chapter.Count();
                    System.Object[] ItemObject_Chapter = new System.Object[numbers];
                    for (int i = 1; i <= numbers; i++)
                    {
                        ItemObject_Chapter[i-1] = BibleMapper.ConvertNumberToNepali(i) + " # " + i.ToString();
                    }
                    SelectChapter.Items.Clear();
                    SelectChapter.Items.AddRange(ItemObject_Chapter);
                }

                if (chapter_pos != activechapter && book_pos >= 0 && chapter_pos >= 0)
                {
                    activechapter = chapter_pos;
                    var numbers = bible.Book[book_pos].Chapter[chapter_pos].Verse.Count();
                    System.Object[] ItemObject_Verse = new System.Object[numbers];
                    for (int i = 1; i <= numbers; i++)
                    {
                        ItemObject_Verse[i-1] = BibleMapper.ConvertNumberToNepali(i) + " # " + i.ToString();
                    }
                    SelectVerse.Items.Clear();
                    SelectVerse.Items.AddRange(ItemObject_Verse);
                }
            }
        }

        private void Bible_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            AreBooksMapped = false;
            activebook = -1;
            activechapter = -1;
            activeverse = -1;
            NepaliActive = true;
            EnglishActive = false;
            showingcontrols = false;
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

        private void SelectBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedBook = SelectBook.SelectedItem.ToString();
            int book_position = SelectBook.Items.IndexOf(SelectedBook);
            ShowCombos(book_position, 0);
        }

        private void SelectChapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedBook = SelectBook.SelectedItem.ToString();
            int book_position = SelectBook.Items.IndexOf(SelectedBook);
            string SelectedChapter = SelectChapter.SelectedItem.ToString();
            int chapter_position = SelectChapter.Items.IndexOf(SelectedChapter);
            ShowCombos(book_position, chapter_position);
        }

        private void SelectVerse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectChapter.SelectedItem != null)
            {
                string SelectedBook = SelectBook.SelectedItem.ToString();
                activebook = SelectBook.Items.IndexOf(SelectedBook);
                string SelectedChapter = SelectChapter.SelectedItem.ToString();
                activechapter = SelectChapter.Items.IndexOf(SelectedChapter);
                string SelectedVerse = SelectVerse.SelectedItem.ToString();
                activeverse = SelectVerse.Items.IndexOf(SelectedVerse);
                LocalVerseView.Text = GetPreviewVerse();
            }
        }
        private void Book1_Click(object sender, EventArgs e)
        {
            if (NepaliActive)
            {
                Book1.Text = Book1.Text.Replace("✔️", "📖");
                Book1.ForeColor = Color.Gray;
                NepaliActive = false;
                LocalVerseView.Text = GetPreviewVerse();
            }
            else
            {
                Book1.Text = Book1.Text.Replace("📖", "✔️");
                Book1.ForeColor = Color.White;
                NepaliActive = true;
                LocalVerseView.Text = GetPreviewVerse();
            }
        }

        private void Book3_Click(object sender, EventArgs e)
        {
            if (EnglishActive)
            {
                Book3.Text = Book3.Text.Replace("✔️", "📖");
                Book3.ForeColor = Color.Gray;
                EnglishActive = false;
                LocalVerseView.Text = GetPreviewVerse();
            }
            else
            {
                Book3.Text = Book3.Text.Replace("📖", "✔️");
                Book3.ForeColor = Color.White;
                EnglishActive = true;
                LocalVerseView.Text = GetPreviewVerse();
            }
        }

        private void Btn_Previous_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 2 && Application.OpenForms[2].Name == "BibleVerseDisplay")
            {
                var OpenHymWindow = Application.OpenForms[2];
                var previousbtn = (Button)OpenHymWindow.Controls["Btn_Previous"];
                previousbtn.PerformClick();
            }
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 2 && Application.OpenForms[2].Name == "BibleVerseDisplay")
            {
                var OpenHymWindow = Application.OpenForms[2];
                var btn = (Button)OpenHymWindow.Controls["Btn_Next"];
                btn.PerformClick();
            }
        }

        private void Btn_StopPlaying_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 2 && Application.OpenForms[2].Name == "BibleVerseDisplay")
            {
                var OpenHymWindow = Application.OpenForms[2];
                var btn = (Button)OpenHymWindow.Controls["Btn_Home"];
                btn.PerformClick();
            }
            HideSlidesControls(true);
        }

        public void HideSlidesControls(bool IsDisplayingVerse)
        {
            showingcontrols = false;
            var bible_home = Application.OpenForms[1];
            //buttons
            bible_home.Controls["Btn_StopPlaying"].Visible = false;
            bible_home.Controls["Btn_Next"].Visible = false;
            bible_home.Controls["Btn_Previous"].Visible = false;
            //books
            bible_home.Controls["Book1"].Visible = true;
            bible_home.Controls["Book3"].Visible = true;
        }

        public void ShowSlidesControls()
        {
            showingcontrols = true;
            var bible_home = Application.OpenForms[1];
            //buttons
            bible_home.Controls["Btn_StopPlaying"].Visible = true;
            bible_home.Controls["Btn_Next"].Visible = true;
            bible_home.Controls["Btn_Previous"].Visible = true;
            //books
            bible_home.Controls["Book1"].Visible = false;
            bible_home.Controls["Book3"].Visible = false;
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

        private void OnSpecialKeyPress(object sender, KeyEventArgs e)
        {
            if (showingcontrols)
            {

                if (e.KeyCode == Keys.Left)
                {
                    Btn_Previous_Click(sender, e);
                    Btn_Play.Focus();
                }
                else if (e.KeyCode == Keys.Right)
                {
                    Btn_Next_Click(sender, e);
                    Btn_Play.Focus();
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    Btn_StopPlaying_Click(sender, e);
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }
            }
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

        private void Btn_BackToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

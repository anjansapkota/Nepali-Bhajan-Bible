using Bhajan.Classess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bhajan.Motor
{
    public partial class AddHymsView : Form
    {
        public AddHymsView()
        {
            InitializeComponent();
        }

        private void AddHymsView_Load(object sender, EventArgs e)
        {

        }
        private void WhenFormCloses(object sender, EventArgs e)
        {
            Bhajan.dev = false;
            Bhajan.dev_inserted_text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string  Editors_Name = Editor_Name.Text;
            if (!string.IsNullOrEmpty(Editors_Name))
            {
                button1.Enabled = false;
                Regex r = new Regex("(?:[^a-z0-9 ]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
                Editors_Name = r.Replace(Editors_Name, String.Empty);
                HymMapper.ArrangeHymnals(Editors_Name);
                DialogResult result = MessageBox.Show("Thankyou for helping out!",
                    "Ooops!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    // Closes the parent form.
                    this.Close();
                    button1.Enabled = true;
                }
            }
        }
    }
}

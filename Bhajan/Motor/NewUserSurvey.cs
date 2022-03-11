using Bhajan.Classess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhajan.Motor
{
    public partial class NewUserSurvey : Form
    {
        private static bool IsFilled = false;
        public NewUserSurvey()
        {
            InitializeComponent();
        }

        private void NewUserSurvey_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
            this.CenterToScreen();
            this.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(Survey_ChurchName.Text) ||
                string.IsNullOrEmpty(Survey_ChurchDenomination.Text) ||
                string.IsNullOrEmpty(Survey_Town.Text) ||
                string.IsNullOrEmpty(Survey_State.Text) ||
                string.IsNullOrEmpty(Survey_Country.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(Survey_SharedBy.SelectedItem.ToString()))
            {
                DialogResult result = MessageBox.Show("Please fill out this form properly to activate the software. This is only once for completion of the installation process. \r\n सफ्टवेयर सक्रिय गर्न कृपया यो फारम भर्नुहोस्। यो स्थापना प्रक्रिया पूरा गर्न एक पटक मात्र मात्र भरिनेछ।",
                "Activation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            }
            else
            {
                GA.gaid.Surveyinfo = new Surveyinfo()
                {
                    cid = GA.gaid.MachineID.Substring(0, GA.gaid.MachineID.Length > 32 ? 32: GA.gaid.MachineID.Length),
                    name=Survey_ChurchName.Text,
                    denomination=Survey_ChurchDenomination.Text,
                    city=Survey_Town.Text,
                    country=Survey_Country.SelectedItem.ToString().Contains("Nepal") ? "Nepal" : Survey_Country.SelectedItem.ToString(),
                    state=Survey_State.Text,
                    SharedBySource=MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(Survey_SharedBy.SelectedItem.ToString().Split('|')[1]),                       
                };
                GA.GetLocationData();
                IsFilled = true;
                GA.gaid.NewUserInfoProvided = true;
                GA.saveGAID();
                Home.showAllItems();
                this.Close();
                UpdatesChecker updatecheck = new UpdatesChecker();
                updatecheck.UpdateCheck();
                DialogResult result = MessageBox.Show("Activation Succcessful!. \r\n सफ्टवेयर सक्रिय भयो।",
                "Activation Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2);
            }
        }

        private void NewUserSurvey_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsFilled)
            {
                MessageBox.Show("कृपया पहिले सफ्टवेयर सक्रिय गर्नुहोस्। Please activate the software first.",
                    "Activation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
                e.Cancel = true;
            }
        }
    }
}

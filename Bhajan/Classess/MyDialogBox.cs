using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhajan.Classess
{
    public static class MyDialogBox
    {
        public static string ShowDialog(string title,  string message, bool extrabutton, string buttonname, string link)
        {
            if (!string.IsNullOrEmpty(message))
            {
                Form prompt = new Form()
                {
                    //Width = 500,
                    //Height = 200 + (70 * (message.Split('\n')).Length),
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = title,
                    StartPosition = FormStartPosition.CenterScreen,
                    Font = new Font("Comic Sans MS", 14)
                };
                Label textBox = new Label() {
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = message.Replace("\n", System.Environment.NewLine),
                    Padding = new Padding(0, 0, 0, 0),
                    MaximumSize = new Size(800, 600)
                };
                textBox.Location = new System.Drawing.Point(textBox.Location.X, 15);

                textBox.BorderStyle = BorderStyle.None;
                Button confirmation = new Button() { Font = new Font("Comic Sans MS", 8),  Text = !extrabutton ? "OK" : buttonname, Height = 50, DialogResult = DialogResult.OK };
                confirmation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                prompt.Height = prompt.ClientSize.Height + 100;
                confirmation.Location = new System.Drawing.Point(Convert.ToInt32(prompt.ClientSize.Width/2 - confirmation.Width/2), Convert.ToInt32(prompt.Height - 100));
                
                confirmation.AutoSize = true; 
                confirmation.Anchor = (AnchorStyles)(AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
                if (extrabutton)
                {
                    confirmation.Click += (sender, e) => {
                        try
                        {
                            Process myProcess = new Process();
                            // true is the default, but it is important not to set it to false
                            myProcess.StartInfo.UseShellExecute = true;
                            myProcess.StartInfo.FileName = link;
                            myProcess.Start();
                            ((Form)sender).Close();
                        }
                        catch { }

                    };
                }
                else
                {
                    confirmation.Click += (sender, e) => { prompt.Close(); };
                }
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;
                prompt.BringToFront();
                prompt.AutoSize = true;
                prompt.TopMost = true;
                prompt.ShowInTaskbar = false;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "Leave the text as is";
            }
            else
            {
                return null;
            }
        }
        
        public static string ShowSoftwareInfo(string title,  string message, bool extrabutton, string buttonname, string link)
        {
            if (!string.IsNullOrEmpty(message))
            {
                Form prompt = new Form()
                {
                    //Width = 500,
                    //Height = 200 + (70 * (message.Split('\n')).Length),
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = title,
                    StartPosition = FormStartPosition.CenterScreen,
                    Font = new Font("Comic Sans MS", 12)
                };
                Label textBox = new Label() {
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = message.Replace("\n", System.Environment.NewLine),
                    Padding = new Padding(0, 0, 0, 0)
                };
                //textBox.Height = 60 + 20 * (message.Split('\n')).Length;
                textBox.BorderStyle = BorderStyle.None;
                Button confirmation = new Button() { Font = new Font("Comic Sans MS", 8), Text = !extrabutton ? "OK" : buttonname, Width = 100, Height = 50, DialogResult = DialogResult.OK };
                confirmation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                confirmation.Location = new System.Drawing.Point(prompt.Width - 150, prompt.Height - 150);
                if (extrabutton)
                {
                    confirmation.Click += (sender, e) => {
                        try
                        {
                            Process myProcess = new Process();
                            // true is the default, but it is important not to set it to false
                            myProcess.StartInfo.UseShellExecute = true;
                            myProcess.StartInfo.FileName = link;
                            myProcess.Start();
                            ((Form)sender).Close();
                        }
                        catch { }

                    };
                }
                else
                {
                    confirmation.Click += (sender, e) => { prompt.Close(); };
                }
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;
                prompt.BringToFront();
                prompt.AutoSize = true;
                prompt.TopMost = true;
                prompt.ShowInTaskbar = false;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "Leave the text as is";
            }
            else
            {
                return null;
            }
        }
    }
}

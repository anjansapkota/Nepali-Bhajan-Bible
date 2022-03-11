using System.Diagnostics;
using System.Windows.Forms;

namespace UpdaterNBB.Classes
{
    public partial class UpdateInstaller
    {
        public bool InstallAppNow(string destFile, string running_application_path)
        {

            Process process = new Process();
            process.StartInfo.FileName = "msiexec.exe";
            process.StartInfo.WorkingDirectory = @"C:\temp\";
            process.StartInfo.Arguments = "/i " + destFile + " /passive /norestart ALLUSERS=1";
            process.Start();
            process.WaitForExit();
            Process.Start(running_application_path);
            Application.Exit();
            return true;
        }
    }
}

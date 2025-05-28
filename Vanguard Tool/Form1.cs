using System.Diagnostics;

namespace Vanguard_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunCommand(string command)
        {
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", "/c " + command)
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                Verb = "runas" // Runs as administrator (will prompt)
            };

            try
            {
                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    if (!string.IsNullOrEmpty(error))
                        MessageBox.Show("Error:\n" + error);
                    else
                        MessageBox.Show("Done:\n" + output);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to run command:\n" + ex.Message);
            }
        }

        private void disableStart_Click(object sender, EventArgs e)
        {
            RunCommand("sc config vgc start= disabled & sc config vgk start= disabled");
            UpdateVanguardStatus();
        }

        private void disableStartAndKill_Click(object sender, EventArgs e)
        {
            RunCommand("sc config vgc start= disabled & sc config vgk start= disabled & net stop vgc & net stop vgk & taskkill /IM vgtray.exe");
            UpdateVanguardStatus();
        }

        private void Kill_Click(object sender, EventArgs e)
        {
            RunCommand("net stop vgc & net stop vgk & taskkill /IM vgtray.exe");
            UpdateVanguardStatus();
        }

        private void enableStart_Click(object sender, EventArgs e)
        {
            RunCommand("sc config vgc start= demand & sc config vgk start= system");
            UpdateVanguardStatus();
        }

        private void restartComputer_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to restart your computer now?",
                "Confirm Restart",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                RunCommand("shutdown /r /f /t 00");
            }
            else
            {
                MessageBox.Show("Restart cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

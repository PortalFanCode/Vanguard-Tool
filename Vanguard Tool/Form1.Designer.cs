using System.Diagnostics;
using System.Windows.Forms;

namespace Vanguard_Tool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            KillButton = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            DisableStartAndKillButton = new Button();
            DisableStartButton = new Button();
            EnableStartButton = new Button();
            RestartComputerButton = new Button();
            TableLayout = new TableLayoutPanel();
            Label1 = new Label();
            statusLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            TableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // KillButton
            // 
            KillButton.Anchor = AnchorStyles.None;
            KillButton.Location = new Point(205, 10);
            KillButton.Name = "KillButton";
            KillButton.Size = new Size(190, 23);
            KillButton.TabIndex = 4;
            KillButton.Text = "Kill";
            KillButton.UseVisualStyleBackColor = true;
            KillButton.Click += Kill_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // DisableStartAndKillButton
            // 
            DisableStartAndKillButton.Anchor = AnchorStyles.None;
            DisableStartAndKillButton.Location = new Point(5, 54);
            DisableStartAndKillButton.Name = "DisableStartAndKillButton";
            DisableStartAndKillButton.Size = new Size(190, 23);
            DisableStartAndKillButton.TabIndex = 5;
            DisableStartAndKillButton.Text = "Disable Start and Kill";
            DisableStartAndKillButton.UseVisualStyleBackColor = true;
            DisableStartAndKillButton.Click += disableStartAndKill_Click;
            // 
            // DisableStartButton
            // 
            DisableStartButton.Anchor = AnchorStyles.None;
            DisableStartButton.Location = new Point(5, 10);
            DisableStartButton.Name = "DisableStartButton";
            DisableStartButton.Size = new Size(190, 23);
            DisableStartButton.TabIndex = 6;
            DisableStartButton.Text = "Disable Start";
            DisableStartButton.UseVisualStyleBackColor = true;
            DisableStartButton.Click += disableStart_Click;
            DisableStartButton.Resize += Form1_Resize;
            // 
            // EnableStartButton
            // 
            EnableStartButton.Anchor = AnchorStyles.None;
            EnableStartButton.Location = new Point(5, 142);
            EnableStartButton.Name = "EnableStartButton";
            EnableStartButton.Size = new Size(190, 23);
            EnableStartButton.TabIndex = 7;
            EnableStartButton.Text = "Enable Start";
            EnableStartButton.UseVisualStyleBackColor = true;
            EnableStartButton.Click += enableStart_Click;
            // 
            // RestartComputerButton
            // 
            RestartComputerButton.Anchor = AnchorStyles.None;
            RestartComputerButton.Location = new Point(205, 142);
            RestartComputerButton.Name = "RestartComputerButton";
            RestartComputerButton.Size = new Size(190, 23);
            RestartComputerButton.TabIndex = 8;
            RestartComputerButton.Text = "Restart Computer";
            RestartComputerButton.UseVisualStyleBackColor = true;
            RestartComputerButton.Click += restartComputer_Click;
            // 
            // TableLayout
            // 
            TableLayout.ColumnCount = 2;
            TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayout.Controls.Add(RestartComputerButton, 1, 3);
            TableLayout.Controls.Add(EnableStartButton, 0, 3);
            TableLayout.Controls.Add(Label1, 0, 4);
            TableLayout.Controls.Add(statusLabel, 1, 4);
            TableLayout.Controls.Add(KillButton, 1, 0);
            TableLayout.Controls.Add(DisableStartAndKillButton, 0, 1);
            TableLayout.Controls.Add(DisableStartButton, 0, 0);
            TableLayout.Location = new Point(185, 214);
            TableLayout.Name = "TableLayout";
            TableLayout.RowCount = 5;
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TableLayout.Size = new Size(400, 216);
            TableLayout.TabIndex = 9;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.None;
            Label1.AutoSize = true;
            Label1.Location = new Point(52, 188);
            Label1.Name = "Label1";
            Label1.Size = new Size(95, 15);
            Label1.TabIndex = 9;
            Label1.Text = "Vanguard Status:";
            // 
            // statusLabel
            // 
            statusLabel.Anchor = AnchorStyles.None;
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(253, 188);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(94, 15);
            statusLabel.TabIndex = 10;
            statusLabel.Text = "Reading Status...";
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(761, 664);
            Controls.Add(TableLayout);
            Name = "Form1";
            Text = "Vanguard Tool";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            TableLayout.ResumeLayout(false);
            TableLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FileSystemWatcher fileSystemWatcher1;
        private Button KillButton;
        private Button EnableStartButton;
        private Button DisableStartButton;
        private Button DisableStartAndKillButton;
        private Button RestartComputerButton;
        private TableLayoutPanel TableLayout;


        private void Form1_Load(object sender, EventArgs e)
        {
            Form1_Resize(sender, e);
            UpdateVanguardStatus();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            TableLayout.Left = (this.ClientSize.Width - TableLayout.Width) / 2;
            TableLayout.Top = (this.ClientSize.Height - TableLayout.Height) / 2;
        }

        private Label Label1;
        private Label statusLabel;

        private bool IsServiceRunning(string serviceName)
        {
            ProcessStartInfo psi = new ProcessStartInfo("sc", $"query {serviceName}")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process proc = Process.Start(psi))
            {
                string output = proc.StandardOutput.ReadToEnd();
                proc.WaitForExit();
                return output.Contains("RUNNING");
            }
        }

        private void UpdateVanguardStatus()
        {
            bool vgkRunning = IsServiceRunning("vgk");

            if (vgkRunning)
                statusLabel.Text = "ENABLED";
            else
                statusLabel.Text = "DISABLED";
        }
    }
}

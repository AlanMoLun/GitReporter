using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace GitReporter
{
    public partial class Form1 : Form
    {
        bool isShowing = false;

        public Form1()
        {
            InitializeComponent();
            dtpFrom.Value = DateTime.Today.AddDays(-7);
        }

        private void btnIterate_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DirectoryInfo root = new DirectoryInfo(dialog.FileName);
                foreach(DirectoryInfo dr in root.GetDirectories())
                {
                    if (!dr.Name.StartsWith("."))
                    {
                        DataRow r = tblRepos.NewRow();
                        r["Name"] = dr.Name;
                        r["Path"] = dr.FullName;
                        tblRepos.Rows.Add(r);
                    }
                }
            }
        }

        private void btnAddRepos_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DirectoryInfo dr;
                foreach (string file in dialog.FileNames)
                {
                    dr = new DirectoryInfo(file);
                    DataRow r = tblRepos.NewRow();
                    r["Name"] = dr.Name;
                    r["Path"] = dr.FullName;
                    tblRepos.Rows.Add(r);
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtOutputFileFolder.Text = dialog.FileName;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tblRepos.Rows.Clear();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            pgb1.Maximum = tblRepos.Rows.Count;
            pgb1.Visible = true;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "cmd.exe";

            string gitCmd = "";
            string echoCmd = "";
            string repos = "";
            string author = txtAuthor.Text;
            string fromDate = dtpFrom.Value.ToString("yyyy-MM-dd 00:00:00");
            string toDate = dtpTo.Value.ToString("yyyy-MM-dd 23:59:59");
            string outputFileName = txtOutputFileFolder.Text + "\\git_report_" + dtpFrom.Value.ToString("yyyyMMdd") + "_to_" + dtpTo.Value.ToString("yyyyMMdd") + ".txt";
            string header = "";
            string result = "";

            if (File.Exists(outputFileName))
            {
                File.Delete(outputFileName);
            }

            using (StreamWriter file = new StreamWriter(outputFileName))
            {
                file.WriteLine("Git Report From " + dtpFrom.Value.ToString("yyyy-MM-dd") + " to " + dtpTo.Value.ToString("yyyy-MM-dd"));
                foreach (DataRow row in tblRepos.Rows)
                {
                    //pgbIncrement(1);
                    pgb1.Value++;
                    // /C means carries out with the process command, otherwise it will stop running.
                    echoCmd = "/C echo [" + row["Name"].ToString() + "]";
                    gitCmd = "/C";

                    // Get repos path
                    repos = row["Path"].ToString();

                    if (!(string.IsNullOrEmpty(repos) || string.IsNullOrEmpty(author)))
                    {
                        gitCmd += " git -C \"" + repos + "\"";
                        gitCmd += " log --author=\"" + author + "\" --since=\"" + fromDate + "\" --until=\"" + toDate + "\" --no-merges --reverse --format=\" * % s\"";

                        // Get project name as header
                        startInfo.Arguments = echoCmd;
                        process.StartInfo = startInfo;
                        process.Start();
                        header = process.StandardOutput.ReadToEnd();
                        process.WaitForExit();

                        // Get git log info
                        startInfo.Arguments = gitCmd;
                        process.StartInfo = startInfo;
                        process.Start();
                        result = process.StandardOutput.ReadToEnd();
                        process.WaitForExit();

                        // Write to output file
                        if (!string.IsNullOrEmpty(result))
                        {
                            file.Write(header);
                            file.Write(result);
                            file.WriteLine();
                        }
                    }
                }
            }

            if (File.Exists(outputFileName))
            {
                System.Diagnostics.Process.Start(outputFileName);
            }

            pgb1.Visible = false;
        }
    }
}

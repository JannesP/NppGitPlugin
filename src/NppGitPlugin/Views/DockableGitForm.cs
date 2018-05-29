using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibGit2Sharp;
using NppGitPlugin.Utility;

namespace NppGitPlugin.Views
{
    public partial class DockableGitForm : Form
    {
        private Repository _repo;
        private FileSystemWatcher _fsw;
        public DockableGitForm()
        {
            InitializeComponent();
        }

        public void FileChanged()
        {
            Reset();
            string currFile = NppHelper.GetCurrentFilePath();
            if (string.IsNullOrWhiteSpace(currFile)) return;
            string path = Path.GetDirectoryName(currFile);
            string repoDir = GitHelper.GetRepoDirForDirectory(path);
            if (repoDir != null)
            {
                labelGitRepoPath.Text = repoDir;
                _repo = new Repository(repoDir);
                RefreshChanges();
                _fsw = new FileSystemWatcher(repoDir + @"\..\");
                _fsw.Changed += _fsw_Changed;
                panelGitControls.Enabled = true;
            }
        }

        private void _fsw_Changed(object sender, FileSystemEventArgs e)
        {
            RefreshChanges();
        }

        private void Reset()
        {
            labelGitRepoPath.Text = "Can't find repo for current path.";
            panelGitControls.Enabled = false;

            consoleControlGit.ClearOutput();

            DisposeResources();
        }

        private void DisposeResources()
        {
            _repo?.Dispose();
            _repo = null;
            _fsw?.Dispose();
            _fsw = null;
        }

        public void RefreshChanges()
        {
            if (_repo == null) return;
            RepositoryStatus rs = _repo.RetrieveStatus(new StatusOptions {IncludeIgnored = false});
            int c = rs.Count();
            labelChanges.Text = $"{c} changes";
            //yeee not gonna deal with merging
            buttonPull.Enabled = c == 0;
            buttonCommit.Enabled = c != 0;
            
        }

        private void DockableGitForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                FileChanged();
            }
            else
            {
                Reset();
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            DisposeResources();
            base.OnClosed(e);
        }

        private void buttonPull_Click(object sender, EventArgs e)
        {
            if (_repo == null) return;
            consoleControlGit.ClearOutput();
            consoleControlGit.StartProcess("git", $"-C \"{_repo.Info.WorkingDirectory.TrimEnd('\\')}\" pull");
        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {
            /*
             * This is a serious commit that is totally not for testing!
!! seriously!!
             */
            if (_repo == null) return;
            Commands.Stage(_repo, "*");
            consoleControlGit.ClearOutput();
            consoleControlGit.StartProcess("git", $"-C \"{_repo.Info.WorkingDirectory.TrimEnd('\\')}\" commit -m \"{textBoxCommitMessage.Text}\"");
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            if (_repo == null) return;
            consoleControlGit.ClearOutput();
            consoleControlGit.StartProcess("git", $"-C \"{_repo.Info.WorkingDirectory.TrimEnd('\\')}\" push");
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            FileChanged();
        }
    }
}

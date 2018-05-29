using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibGit2Sharp;

namespace NppGitPlugin.Utility
{
    class GitHelper
    {
        public static GitHelper Instance => _instance.Value;
        private static Lazy<GitHelper> _instance = new Lazy<GitHelper>(() => new GitHelper());

        public static string GetRepoDirForDirectory(string dir)
        {
            string repoDir = Repository.Discover(dir);
            if (repoDir == null) return null;
            return Repository.IsValid(repoDir) ? repoDir : null;
        }

        public static Repository GetRepoObject(string dir)
        {
            dir = Repository.Discover(dir);
            return !Repository.IsValid(dir) ? null : new Repository(dir);
        }

        private static Process CmdGit(string directory, string command)
        {
            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("git", command);
            psi.WorkingDirectory = directory;
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.CreateNoWindow = false;
            p.StartInfo = psi;
            p.Start();
            return p;
        }

        public static Process CmdCommit(string directory, string message)
        {
            message = message.Replace('"', '\'');
            return CmdGit(directory, $"commit -m \"{message}\"");
        }

        public static Process CmdPull(string directory)
        {
            return CmdGit(directory, "pull");
        }

        public static Process CmdPush(string directory)
        {
            return CmdGit(directory, "push");
        }
    }
}

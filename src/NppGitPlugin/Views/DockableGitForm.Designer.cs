namespace NppGitPlugin.Views
{
    partial class DockableGitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelGitRepoPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelChanges = new System.Windows.Forms.Label();
            this.buttonCommit = new System.Windows.Forms.Button();
            this.buttonPush = new System.Windows.Forms.Button();
            this.buttonPull = new System.Windows.Forms.Button();
            this.textBoxCommitMessage = new System.Windows.Forms.TextBox();
            this.panelGitControls = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.consoleControlGit = new global::ConsoleControl.ConsoleControl();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panelGitControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGitRepoPath
            // 
            this.labelGitRepoPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGitRepoPath.Location = new System.Drawing.Point(12, 33);
            this.labelGitRepoPath.Name = "labelGitRepoPath";
            this.labelGitRepoPath.Size = new System.Drawing.Size(284, 13);
            this.labelGitRepoPath.TabIndex = 1;
            this.labelGitRepoPath.Text = "labelGitRepoPath";
            this.labelGitRepoPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current git repo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount of changes:";
            // 
            // labelChanges
            // 
            this.labelChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChanges.Location = new System.Drawing.Point(4, 29);
            this.labelChanges.Name = "labelChanges";
            this.labelChanges.Size = new System.Drawing.Size(277, 16);
            this.labelChanges.TabIndex = 4;
            this.labelChanges.Text = "labelChanges";
            this.labelChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCommit
            // 
            this.buttonCommit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCommit.Location = new System.Drawing.Point(4, 128);
            this.buttonCommit.Name = "buttonCommit";
            this.buttonCommit.Size = new System.Drawing.Size(277, 23);
            this.buttonCommit.TabIndex = 5;
            this.buttonCommit.Text = "Stage All and Commit";
            this.buttonCommit.UseVisualStyleBackColor = true;
            this.buttonCommit.Click += new System.EventHandler(this.buttonCommit_Click);
            // 
            // buttonPush
            // 
            this.buttonPush.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPush.Location = new System.Drawing.Point(4, 157);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(277, 23);
            this.buttonPush.TabIndex = 6;
            this.buttonPush.Text = "Push";
            this.buttonPush.UseVisualStyleBackColor = true;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            // 
            // buttonPull
            // 
            this.buttonPull.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPull.Location = new System.Drawing.Point(3, 48);
            this.buttonPull.Name = "buttonPull";
            this.buttonPull.Size = new System.Drawing.Size(278, 23);
            this.buttonPull.TabIndex = 7;
            this.buttonPull.Text = "Pull";
            this.buttonPull.UseVisualStyleBackColor = true;
            this.buttonPull.Click += new System.EventHandler(this.buttonPull_Click);
            // 
            // textBoxCommitMessage
            // 
            this.textBoxCommitMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommitMessage.Location = new System.Drawing.Point(4, 77);
            this.textBoxCommitMessage.Multiline = true;
            this.textBoxCommitMessage.Name = "textBoxCommitMessage";
            this.textBoxCommitMessage.Size = new System.Drawing.Size(277, 45);
            this.textBoxCommitMessage.TabIndex = 8;
            // 
            // panelGitControls
            // 
            this.panelGitControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGitControls.Controls.Add(this.label3);
            this.panelGitControls.Controls.Add(this.consoleControlGit);
            this.panelGitControls.Controls.Add(this.label2);
            this.panelGitControls.Controls.Add(this.textBoxCommitMessage);
            this.panelGitControls.Controls.Add(this.labelChanges);
            this.panelGitControls.Controls.Add(this.buttonPull);
            this.panelGitControls.Controls.Add(this.buttonCommit);
            this.panelGitControls.Controls.Add(this.buttonPush);
            this.panelGitControls.Location = new System.Drawing.Point(12, 59);
            this.panelGitControls.Name = "panelGitControls";
            this.panelGitControls.Size = new System.Drawing.Size(284, 453);
            this.panelGitControls.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Git Status:";
            // 
            // consoleControlGit
            // 
            this.consoleControlGit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleControlGit.IsInputEnabled = true;
            this.consoleControlGit.Location = new System.Drawing.Point(3, 203);
            this.consoleControlGit.Name = "consoleControlGit";
            this.consoleControlGit.SendKeyboardCommandsToProcess = false;
            this.consoleControlGit.ShowDiagnostics = false;
            this.consoleControlGit.Size = new System.Drawing.Size(278, 247);
            this.consoleControlGit.TabIndex = 9;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Location = new System.Drawing.Point(221, 9);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // DockableGitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 524);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.panelGitControls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGitRepoPath);
            this.Name = "DockableGitForm";
            this.ShowIcon = false;
            this.Text = "Git Plugin";
            this.VisibleChanged += new System.EventHandler(this.DockableGitForm_VisibleChanged);
            this.panelGitControls.ResumeLayout(false);
            this.panelGitControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelGitRepoPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelChanges;
        private System.Windows.Forms.Button buttonCommit;
        private System.Windows.Forms.Button buttonPush;
        private System.Windows.Forms.Button buttonPull;
        private System.Windows.Forms.TextBox textBoxCommitMessage;
        private System.Windows.Forms.Panel panelGitControls;
        private System.Windows.Forms.Label label3;
        private global::ConsoleControl.ConsoleControl consoleControlGit;
        private System.Windows.Forms.Button buttonRefresh;
    }
}
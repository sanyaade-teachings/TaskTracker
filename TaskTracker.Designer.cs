namespace TaskTracker {
    partial class TaskTracker {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Tabs = new System.Windows.Forms.TabControl();
            this.TaskPage = new System.Windows.Forms.TabPage();
            this.TaskListBox = new System.Windows.Forms.ListBox();
            this.TaskInputBox = new System.Windows.Forms.TextBox();
            this.NotePage = new System.Windows.Forms.TabPage();
            this.NoteListBox = new System.Windows.Forms.ListBox();
            this.NoteInputBox = new System.Windows.Forms.TextBox();
            this.LogPage = new System.Windows.Forms.TabPage();
            this.LogListBox = new System.Windows.Forms.ListBox();
            this.LogInputBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.TaskPage.SuspendLayout();
            this.NotePage.SuspendLayout();
            this.LogPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.TaskPage);
            this.Tabs.Controls.Add(this.NotePage);
            this.Tabs.Controls.Add(this.LogPage);
            this.Tabs.Location = new System.Drawing.Point(9, 8);
            this.Tabs.Margin = new System.Windows.Forms.Padding(2);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(347, 500);
            this.Tabs.TabIndex = 0;
            // 
            // TaskPage
            // 
            this.TaskPage.Controls.Add(this.TaskListBox);
            this.TaskPage.Controls.Add(this.TaskInputBox);
            this.TaskPage.Location = new System.Drawing.Point(4, 26);
            this.TaskPage.Margin = new System.Windows.Forms.Padding(2);
            this.TaskPage.Name = "TaskPage";
            this.TaskPage.Padding = new System.Windows.Forms.Padding(2);
            this.TaskPage.Size = new System.Drawing.Size(339, 470);
            this.TaskPage.TabIndex = 0;
            this.TaskPage.Text = "Tasks";
            this.TaskPage.UseVisualStyleBackColor = true;
            // 
            // TaskListBox
            // 
            this.TaskListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskListBox.FormattingEnabled = true;
            this.TaskListBox.IntegralHeight = false;
            this.TaskListBox.ItemHeight = 17;
            this.TaskListBox.Location = new System.Drawing.Point(5, 34);
            this.TaskListBox.Margin = new System.Windows.Forms.Padding(2);
            this.TaskListBox.Name = "TaskListBox";
            this.TaskListBox.Size = new System.Drawing.Size(330, 432);
            this.TaskListBox.TabIndex = 1;
            this.TaskListBox.SelectedIndexChanged += new System.EventHandler(this.TaskListBox_SelectedIndexChanged);
            this.TaskListBox.DoubleClick += new System.EventHandler(this.TaskListBox_DoubleClick);
            // 
            // TaskInputBox
            // 
            this.TaskInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskInputBox.Location = new System.Drawing.Point(5, 5);
            this.TaskInputBox.Margin = new System.Windows.Forms.Padding(2);
            this.TaskInputBox.Name = "TaskInputBox";
            this.TaskInputBox.Size = new System.Drawing.Size(330, 25);
            this.TaskInputBox.TabIndex = 0;
            this.TaskInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TaskInputBox_KeyPress);
            // 
            // NotePage
            // 
            this.NotePage.Controls.Add(this.NoteListBox);
            this.NotePage.Controls.Add(this.NoteInputBox);
            this.NotePage.Location = new System.Drawing.Point(4, 26);
            this.NotePage.Margin = new System.Windows.Forms.Padding(2);
            this.NotePage.Name = "NotePage";
            this.NotePage.Padding = new System.Windows.Forms.Padding(2);
            this.NotePage.Size = new System.Drawing.Size(339, 470);
            this.NotePage.TabIndex = 1;
            this.NotePage.Text = "Notes";
            this.NotePage.UseVisualStyleBackColor = true;
            // 
            // NoteListBox
            // 
            this.NoteListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteListBox.FormattingEnabled = true;
            this.NoteListBox.IntegralHeight = false;
            this.NoteListBox.ItemHeight = 17;
            this.NoteListBox.Location = new System.Drawing.Point(4, 34);
            this.NoteListBox.Margin = new System.Windows.Forms.Padding(2);
            this.NoteListBox.Name = "NoteListBox";
            this.NoteListBox.Size = new System.Drawing.Size(331, 432);
            this.NoteListBox.TabIndex = 3;
            this.NoteListBox.SelectedIndexChanged += new System.EventHandler(this.NoteListBox_SelectedIndexChanged);
            this.NoteListBox.DoubleClick += new System.EventHandler(this.NoteListBox_DoubleClick);
            // 
            // NoteInputBox
            // 
            this.NoteInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteInputBox.Location = new System.Drawing.Point(4, 4);
            this.NoteInputBox.Margin = new System.Windows.Forms.Padding(2);
            this.NoteInputBox.Name = "NoteInputBox";
            this.NoteInputBox.Size = new System.Drawing.Size(331, 25);
            this.NoteInputBox.TabIndex = 2;
            this.NoteInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoteTextBox_KeyPress);
            // 
            // LogPage
            // 
            this.LogPage.Controls.Add(this.LogListBox);
            this.LogPage.Controls.Add(this.LogInputBox);
            this.LogPage.Location = new System.Drawing.Point(4, 26);
            this.LogPage.Margin = new System.Windows.Forms.Padding(2);
            this.LogPage.Name = "LogPage";
            this.LogPage.Padding = new System.Windows.Forms.Padding(2);
            this.LogPage.Size = new System.Drawing.Size(339, 470);
            this.LogPage.TabIndex = 2;
            this.LogPage.Text = "Log";
            this.LogPage.UseVisualStyleBackColor = true;
            // 
            // LogListBox
            // 
            this.LogListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LogListBox.FormattingEnabled = true;
            this.LogListBox.IntegralHeight = false;
            this.LogListBox.ItemHeight = 17;
            this.LogListBox.Location = new System.Drawing.Point(4, 34);
            this.LogListBox.Margin = new System.Windows.Forms.Padding(2);
            this.LogListBox.Name = "LogListBox";
            this.LogListBox.Size = new System.Drawing.Size(331, 432);
            this.LogListBox.TabIndex = 3;
            this.LogListBox.SelectedIndexChanged += new System.EventHandler(this.LogListBox_SelectedIndexChanged);
            this.LogListBox.DoubleClick += new System.EventHandler(this.LogListBox_DoubleClick);
            // 
            // LogInputBox
            // 
            this.LogInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LogInputBox.Location = new System.Drawing.Point(4, 4);
            this.LogInputBox.Margin = new System.Windows.Forms.Padding(2);
            this.LogInputBox.Name = "LogInputBox";
            this.LogInputBox.Size = new System.Drawing.Size(331, 25);
            this.LogInputBox.TabIndex = 2;
            this.LogInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LogTextBox_KeyPress);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.Location = new System.Drawing.Point(307, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(46, 17);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "CLOSE";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TaskTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(365, 516);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Tabs);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TaskTracker";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Task Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskTracker_FormClosing);
            this.Tabs.ResumeLayout(false);
            this.TaskPage.ResumeLayout(false);
            this.TaskPage.PerformLayout();
            this.NotePage.ResumeLayout(false);
            this.NotePage.PerformLayout();
            this.LogPage.ResumeLayout(false);
            this.LogPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage TaskPage;
        private System.Windows.Forms.TabPage NotePage;
        private System.Windows.Forms.TabPage LogPage;
        private System.Windows.Forms.ListBox TaskListBox;
        private System.Windows.Forms.TextBox TaskInputBox;
        private System.Windows.Forms.ListBox NoteListBox;
        private System.Windows.Forms.TextBox NoteInputBox;
        private System.Windows.Forms.ListBox LogListBox;
        private System.Windows.Forms.TextBox LogInputBox;
        private System.Windows.Forms.Label CloseButton;
    }
}


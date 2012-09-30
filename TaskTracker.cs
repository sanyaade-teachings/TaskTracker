using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace TaskTracker {

    public partial class TaskTracker : Form {
        [DllImport("user32.dll")]
        static extern bool RegisterHotKey(IntPtr hwnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hwnd);

        public const int MOD_WIN = 8;
        public const int WM_HOTKEY = 0x312;


        string Garbage;
        public class ExitApp : Exception {
        }

        public TaskTracker() {
            InitializeComponent();
            if (!RegisterHotKey(Handle, 0, MOD_WIN, (uint)Keys.N)) {
                MessageBox.Show("Could not register Win + N");
                throw new ExitApp();
            }
            MinimizeBox = false;
            MaximizeBox = false;
            Open();
            ActiveControl = TaskInputBox;
        }

        protected override void WndProc(ref Message m) {
            if (m.Msg == WM_HOTKEY) {
                Visible = true;
                SetForegroundWindow(this.Handle);
                m.Result = (IntPtr)0;
            } else if (m.Msg == 0x112 && m.WParam == (IntPtr)0xf020)
                Visible = false;
            else
                base.WndProc(ref m);
        }



        void Save() {
            using (StreamWriter f = new StreamWriter("log.tasks", false, Encoding.UTF8)) {
                f.WriteLine("TASKS");
                foreach (object task in TaskListBox.Items)
                    f.WriteLine("\t" + task);

                f.WriteLine("NOTES");
                foreach (object note in NoteListBox.Items)
                    f.WriteLine("\t" + note);

                f.WriteLine("LOG");
                foreach (object log in LogListBox.Items)
                    f.WriteLine("\t" + log);

                if (Garbage != null)
                    f.Write(Garbage);
            }
        }

        void Open() {
            try {
                ListBox to = null;
                StringBuilder garbage = new StringBuilder();
                foreach (string _line in File.ReadAllLines("log.tasks", Encoding.UTF8)) {
                    string line = _line.TrimStart();
                    if (line.StartsWith("#"))
                        break;
                    if (line == _line) {
                        switch (line.Trim().ToUpper()) {
                            case "TASKS":
                                to = TaskListBox;
                                break;
                            case "NOTES":
                                to = NoteListBox;
                                break;
                            case "LOG":
                                to = LogListBox;
                                break;
                            default:
                                to = null;
                                garbage.AppendLine(line);
                                break;
                        }
                    } else if (to != null)
                        to.Items.Add(line);
                    else
                        garbage.AppendLine(_line);
                }
                Garbage = garbage.ToString();
            } catch (FileNotFoundException) {
            }
        }

        void AddLog(string text) {
            LogListBox.Items.Add(string.Format("[{0} {1}] {2}",
                DateTime.Now.ToShortDateString(),
                DateTime.Now.ToShortTimeString(),
                text));
            Save();
        }

        private void TaskInputBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '\r') {
                TaskListBox.Items.Insert(TaskListBox.SelectedIndex + 1, TaskInputBox.Text);
                TaskListBox.SelectedIndex++;
                TaskInputBox.Clear();
                Save();
            }
        }

        private void NoteTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '\r') {
                NoteListBox.Items.Insert(NoteListBox.SelectedIndex + 1, NoteInputBox.Text);
                NoteListBox.SelectedIndex++;
                NoteInputBox.Clear();
                Save();
            }
        }

        private void LogTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '\r') {
                AddLog(LogInputBox.Text);
                LogInputBox.Clear();
                Save();
            }
        }
        private void TaskListBox_DoubleClick(object sender, EventArgs e) {
            if (TaskListBox.SelectedIndex >= 0) {
                AddLog(string.Format("Checked task “{0}”", TaskListBox.SelectedItem.ToString()));
                TaskListBox.Items.RemoveAt(TaskListBox.SelectedIndex);
                TaskInputBox.Focus();
                Save();
            }
        }

        private void NoteListBox_DoubleClick(object sender, EventArgs e) {
            if (NoteListBox.SelectedIndex >= 0) {
                AddLog(string.Format("Checked note “{0}”", NoteListBox.SelectedItem.ToString()));
                NoteListBox.Items.RemoveAt(NoteListBox.SelectedIndex);
                NoteInputBox.Focus();
                Save();
            }
        }

        private void LogListBox_DoubleClick(object sender, EventArgs e) {
            if (LogListBox.SelectedIndex >= 0) {
                LogListBox.Items.RemoveAt(LogListBox.SelectedIndex);
                LogInputBox.Focus();
                Save();
            }
        }

        private void TaskListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (TaskListBox.SelectedIndex >= 0) {
                TaskInputBox.Text = TaskListBox.SelectedItem.ToString();
                TaskInputBox.Focus();
            }
        }

        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (NoteListBox.SelectedIndex >= 0) {
                NoteInputBox.Text = NoteListBox.SelectedItem.ToString();
                NoteInputBox.Focus();
            }
        }

        private void LogListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (LogListBox.SelectedIndex >= 0) {
                string s = LogListBox.SelectedItem.ToString();
                LogInputBox.Text = s.Substring(s.IndexOf(']') + 2);
                LogInputBox.Focus();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void TaskTracker_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                Visible = false;
            }
        }
    }
}

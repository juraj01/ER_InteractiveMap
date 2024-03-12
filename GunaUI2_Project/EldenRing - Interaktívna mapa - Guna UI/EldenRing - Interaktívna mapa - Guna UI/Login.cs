using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EldenRing___Interaktívna_mapa___Guna_UI
{
    public partial class Login : Form
    {

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCHITTEST = 0x84;
        private const int HTBOTTOMRIGHT = 0x11;
        private const int HTBOTTOMLEFT = 0x10;

        private bool isDragging = false;
        private Point lastCursorPosition;
        bool IsValidEmail = false;
        string name;
        string email;
        string password;
        const int _spacer = 9;

        public Login()
        {
            InitializeComponent();
            InitializeFormSettings();

            this.UpperBorderPanel.MouseDown += UpperBorderPanel_MouseDown;
            this.UpperBorderPanel.MouseMove += UpperBorderPanel_MouseMove;
            this.UpperBorderPanel.MouseUp += UpperBorderPanel_MouseUp;
            this.NameTextBox.Click += NameTextBox_Click;
            this.PasswordTextBox.Click += PasswordTextBox_Click;
            this.EmailTextBox.Click += EmailTextBox_Click;
        }

        private void InitializeFormSettings()
        {
            //Form settings:
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.MinimumSize = new Size(1091, 708);
        }

        private void InitializeEventHandlers()
        {
            //UpperBorderPanel event handlers:
            this.UpperBorderPanel.MouseDown += UpperBorderPanel_MouseDown;
            this.UpperBorderPanel.MouseMove += UpperBorderPanel_MouseMove;
            this.UpperBorderPanel.MouseUp += UpperBorderPanel_MouseUp;
            //TextBoxes event handlers:
            this.NameTextBox.Click += TextBox_Click;
            this.PasswordTextBox.Click += TextBox_Click;
            this.EmailTextBox.Click += TextBox_Click;
            //Buttons event handlers:
            this.MinimalizeButton.Click += MinimalizeButton_Click;
            this.MaximalizeButton.Click += MaximalizeButton_Click;
            this.ExitButton.Click += ExitButton_Click;
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            textbox?.Clear();
        }
        

        protected override void WndProc(ref Message m)
        {
            int msg = m.Msg;

            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                Point pos = PointToClient(Cursor.Position);

                if (pos.X >= ClientSize.Width - 16 && pos.Y >= ClientSize.Height - 1)
                {
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                }
                else if (pos.X <= 16 && pos.Y <= ClientSize.Height -1)
                {
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                }
            }
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, (IntPtr)0xf012, IntPtr.Zero);
            }
        }

        protected override void OnResizeBegin(EventArgs e)
        {
            base.OnResizeBegin(e);
            this.SuspendLayout();
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            this.ResumeLayout();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_Click(object sender, EventArgs e)
        {
            this.NameTextBox.Text = "";
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_Click(object sender, EventArgs e)
        {
            this.EmailTextBox.Text = "";
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            this.PasswordTextBox.Text = "";
        }

        private void MinimalizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaximalizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void UpperBorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPosition = Cursor.Position;
            }
        }
        private void UpperBorderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = new Point(Cursor.Position.X - lastCursorPosition.X, Cursor.Position.Y - lastCursorPosition.Y);
                this.Location = new Point(this.Location.X + delta.X, this.Location.Y + delta.Y);
                lastCursorPosition = Cursor.Position;

                if (e.Y > UpperBorderPanel.Height / 2)
                {
                    this.WindowState = FormWindowState.Normal;
                }

                else if (this.Top <= 0 && e.Y < UpperBorderPanel.Height / 2)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
            }
        }
        private void UpperBorderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }
}

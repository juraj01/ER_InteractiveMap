using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Text;

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
        const int _spacer = 9;

        public Login()
        {
            InitializeComponent();
            InitializeFormSettings();
            InitializeEventHandlers();

            PasswordTextBox.UseSystemPasswordChar = true;
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
            //Buttons event handlers:
            this.MinimalizeButton.Click += MinimalizeButton_Click;
            this.MaximalizeButton.Click += MaximalizeButton_Click;
            this.ExitButton.Click += ExitButton_Click;

        }
        private void NameBoxSize(object sender, EventArgs e)
        {
            NameTextBox.Width = this.Width / 4;
            NameTextBox.Height = this.Height / 19;
        }


        protected override void WndProc(ref Message m)
        {
            int msg = m.Msg;

            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                Point pos = PointToClient(Cursor.Position);

                if (pos.X >= ClientSize.Width - 16 && pos.Y >= ClientSize.Height - 9)
                {
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                }
                else if (pos.X <= 16 && pos.Y <= ClientSize.Height -1)
                {
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                }
            }
        }

        //handling of begining of resize:
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, (IntPtr)0xf012, IntPtr.Zero);
            }
        }
        //Suspending form when resizing:
        protected override void OnResizeBegin(EventArgs e)
        {
            base.OnResizeBegin(e);
            this.SuspendLayout();
        }
        //Resuming form when resizing ends:
        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            this.ResumeLayout();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = NameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            connecttomysql connectLogin = new connecttomysql();

            if (username == null || password == null)
            {
                MessageBox.Show("Fall all blank boxes");
            }
            else 
            {
                if (connectLogin.IsValueExistsName("users", "name", username))
                {
                    if (connectLogin.IsValueExistsLogin("users", "name", "password", username, password))
                    {
                        MessageBox.Show("Login was successfull");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password doesn't match your username");
                    }
                }
                else
                {
                    MessageBox.Show("Username doesn't exist");
                }
            }
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.FormClosed += Register_FormClosed;
            register.Show();
            this.Hide();
        }
        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        //top bar logic
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
            /*if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }*/
            this.WindowState = (this.WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
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

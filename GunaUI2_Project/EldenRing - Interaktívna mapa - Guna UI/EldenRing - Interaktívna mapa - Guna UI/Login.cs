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
        private MessagePopUp _message;

        public Login()
        {
            InitializeComponent();
            InitializeFormSettings();
            InitializeEventHandlers();

            PasswordTextBox.UseSystemPasswordChar = true;
            //_message = new MessagePopUp();
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
            //Resize event handler:
            this.Resize += Form_Resize;

        }

        private void Form_Resize(object sender, EventArgs e)
        {
            // Calculate new sizes for textboxes and buttons
            int buttonWidth = this.ClientSize.Width / 8; 
            int buttonHeight = this.ClientSize.Height / 22; 
            int textBoxWidth = this.ClientSize.Width / 4; 
            int textBoxHeight = this.ClientSize.Height / 21;

            //float buttonFontSize = buttonHeight / 3;
            //float textBoxFontSize = textBoxHeight / 3;

            // Resizing Login/Register buttons and textboxes
            LoginButton.Size = new Size(buttonWidth, buttonHeight);
            //LoginButton.Font = new Font(LoginButton.Font.FontFamily, buttonFontSize);
            RegisterButton.Size = new Size(buttonWidth, buttonHeight);
            //RegisterButton.Font = new Font(RegisterButton.Font.FontFamily, buttonFontSize);
            NameTextBox.Size = new Size(textBoxWidth, textBoxHeight);
            //NameTextBox.Font = new Font(NameTextBox.Font.FontFamily, textBoxFontSize);
            PasswordTextBox.Size = new Size(textBoxWidth, textBoxHeight);
            //PasswordTextBox.Font = new Font(PasswordTextBox.Font.FontFamily, textBoxFontSize);
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

            if (username == null && password == null)
            {
                //System.Windows.Forms.MessageBox.Show("Fill all blank boxes");
                _message = new MessagePopUp();
                _message.Show();
                _message.ShowMessage("Fill all blank boxes");
            }
            else 
            {
                if (username != null && connectLogin.IsValueExistsName("users", "name", username))
                {
                    if (connectLogin.IsValueExistsLogin("users", "name", "password", username, password))
                    {
                        //System.Windows.Forms.MessageBox.Show("Login was successfull");
                        _message = new MessagePopUp();
                        _message.Show();
                        _message.ShowMessage("Login was successfull");
                        this.Close();
                        //Main main = new Main();
                        //main.Show();
                    }
                    else
                    {
                        //System.Windows.Forms.MessageBox.Show("Password doesn't match your username");
                        _message = new MessagePopUp();
                        _message.Show();
                        _message.ShowMessage("Password doesn't match your username");
                    }
                }
                else
                {
                    //System.Windows.Forms.MessageBox.Show("Username doesn't exist");
                    _message = new MessagePopUp();
                    _message.Show();
                    _message.ShowMessage("Username doesn't exist");
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

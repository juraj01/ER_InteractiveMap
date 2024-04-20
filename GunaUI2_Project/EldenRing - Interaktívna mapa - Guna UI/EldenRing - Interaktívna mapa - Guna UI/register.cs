using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Diagnostics;
using MySqlConnector;
using Mysqlx;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.CompilerServices;

namespace EldenRing___Interaktívna_mapa___Guna_UI
{

    public partial class Register : Form
    {
        private string confirmationPassword;
        private string username;
        private string password;
        private bool isDragging = false;
        private Point lastCursorPosition;
        private MessageSuccess _Success;
        private MessageError _Error;
        public Register()
        {
            InitializeComponent();
            InitializeEventHandlers();

            PasswordTextBox.UseSystemPasswordChar = true;
            ConfirmPasswordTextBox.UseSystemPasswordChar = true;
        }

        private void InitializeEventHandlers()
        {
            //UpperBorderPanel event handlers:
            this.UpperBorderPanel.MouseDown += UpperBorderPanel_MouseDown;
            this.UpperBorderPanel.MouseMove += UpperBorderPanel_MouseMove;
            this.UpperBorderPanel.MouseUp += UpperBorderPanel_MouseUp; 
        } 

       
        public bool IsUsernameValid(string username)
        {
             string pattern = @"^[a-zA-Z0-9]*$";
             return Regex.IsMatch(username, pattern);
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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            username = UsernameTextBox.Text.Trim();
            //string email = EmailTextBox.Text.Trim();
            password = PasswordTextBox.Text.Trim();
            confirmationPassword = ConfirmPasswordTextBox.Text.Trim();

            connecttomysql connectRegister = new connecttomysql();

            if (username == null || password == null || confirmationPassword == null)
            {
                //System.Windows.Forms.MessageBox.Show("Fill all blank boxes");
                _Error = new MessageError();
                _Error.Show();
                _Error.ShowMessage("Fill all blank boxes");
            }
            else if (username != null && username.Length >= 4)
            {
                if (connectRegister.IsValueExistsName("users", "name", username))
                {
                    //System.Windows.Forms.MessageBox.Show("This username already exist");
                    _Error = new MessageError();
                    _Error.Show();
                    _Error.ShowMessage("This username already exist");
                }
                else
                {
                    if (IsUsernameValid(username))
                    {
                        if (password != null && password.Length >= 8)
                        {
                            if (password == confirmationPassword)
                            {
                                connectRegister.InsertDataIntoUsers(username, password);
                                _Success = new MessageSuccess();
                                //_Success.Size = ;
                                _Success.Show();
                                _Success.ShowMessage("Registration was successfull");
                                //System.Windows.Forms.MessageBox.Show("Registration was successfull");
                                this.Close();
                            }
                            else
                            {
                                //System.Windows.Forms.MessageBox.Show("Your password and confirmation password don't match");
                                _Error = new MessageError();
                                _Error.Show();
                                _Error.ShowMessage("Your password and confirmation password don't match");
                            }
                        }
                        else
                        {
                            //System.Windows.Forms.MessageBox.Show("You forgot to enter your password or your password is less than 8 characters long");
                            _Error = new MessageError();
                            _Error.Show();
                            _Error.ShowMessage("Password must be at least 8 characters long");
                        }
                    }
                    else
                    {
                        //System.Windows.Forms.MessageBox.Show("Username cannot contain special characters");
                        _Error = new MessageError();
                        _Error.Show();
                        _Error.ShowMessage("Username cannot contain special characters");
                    }
                }
            }
            else
            {
                //System.Windows.Forms.MessageBox.Show("You forgot to enter your username or your username is less than 4 letters long");
                _Error = new MessageError();
                _Error.Show();
                _Error.ShowMessage("Username must be at least 4 letters long");
            }
            
        }

        private void RegistrationLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
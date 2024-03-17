using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace EldenRing___Interaktívna_mapa___Guna_UI
{

    public partial class Register : Form
    {
        private bool isDragging = false;
        private Point lastCursorPosition;
        public Register()
        {
            InitializeComponent();
            InitializeEventHandlers();

            PasswordTextBox.UseSystemPasswordChar = true;
            ConfirmPasswordTextBox.UseSystemPasswordChar = true;
        }

        private void InitializeEventHandlers()
        {
            //TextBoxes event handlers:
            this.UsernameTextBox.Click += NameTextBox_Click;
            this.PasswordTextBox.Click += PasswordTextBox_Click;
            //this.EmailTextBox.Click += EmailTextBox_Click;
            this.ConfirmPasswordTextBox.Click += ConfirmPasswordTextBox_Click;
            //UpperBorderPanel event handlers:
            this.UpperBorderPanel.MouseDown += UpperBorderPanel_MouseDown;
            this.UpperBorderPanel.MouseMove += UpperBorderPanel_MouseMove;
            this.UpperBorderPanel.MouseUp += UpperBorderPanel_MouseUp;
            //Buttons event handlers:
            this.MinimalizeButton.Click += MinimalizeButton_Click;
            this.ExitButton.Click += ExitButton_Click;
            this.RegisterButton.Click += RegisterButton_Click;
            
        } 

        public class UsernameValidation
        {
            public bool IsUsernameValid(string username)
            {
                string pattern = @"^[a-zA-Z0-9]*$";
                return Regex.IsMatch(username, pattern);
            }
        }

        private void NameTextBox_Click(object sender, EventArgs e)
        {
            this.UsernameTextBox.Text = "";
        }
        /*private void EmailTextBox_Click(object sender, EventArgs e)
        {
            this.EmailTextBox.Text = " ";
        }*/
        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            this.PasswordTextBox.Text = "";
        }
        private void ConfirmPasswordTextBox_Click(object sender, EventArgs e)
        {
            this.ConfirmPasswordTextBox.Text = "";
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
            UsernameValidation validation = new UsernameValidation();
            string username = UsernameTextBox.Text.Trim();
            //string email = EmailTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            RegistrationService dbManager = new RegistrationService("Server=localhost;UID=root;Database=registrationdatabase");

            if (this.UsernameTextBox.Text != null)
            {
                if (this.UsernameTextBox.Text.Length >= 4)
                {
                    if (validation.IsUsernameValid(username))
                    {
                        if (this.PasswordTextBox.Text != null)
                        {
                            if (this.PasswordTextBox.Text.Length >= 8)
                            {
                                if (this.PasswordTextBox.Text == this.ConfirmPasswordTextBox.Text)
                                {
                                    dbManager.RegisterUser(username, password);
                                }
                                else
                                {
                                    MessageBox.Show("Your password and confirmation password don't match");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Your password should be at lest 8 characters long");
                            }
                        }
                        else
                        {
                            MessageBox.Show("You forgot to enter your password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username cannot contain special characters");
                    }
                }
                else
                {
                    MessageBox.Show("Enter username that is at least 4 letters long");
                }
            }
            else
            {
                MessageBox.Show("You forgot to enter your username");
            }
        }

        private void RegistrationLabel_Click(object sender, EventArgs e)
        {

        }
    }
    
    public class RegistrationService
    {
        private readonly string connectionString;

        public RegistrationService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void RegisterUser(string username, string password)
        {
            // Pripravenie príkazu pre vloženie nového používateľa do databázy
            //string insertCommand = $"INSERT INTO users (username, password) VALUES (@username, @password)";
            string insertCommand = $"INSERT INTO users (username, password) VALUES('{username}', '{password}');";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertCommand, connection))
                {
                    // Nastavenie hodnôt parametrov
                    //command.Parameters.AddWithValue("@username", username);
                    //command.Parameters.AddWithValue("@password", password);

                    try
                    {
                        // Otvorenie spojenia a vykonanie príkazu
                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine("User was successfully registered.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured: " + ex.ToString());
                    }
                }
            }
        }
    }
}

/*using System;
using System.Data.SqlClient;

namespace RegistraciaDatabazy
{
    class Register
    {
        static void Main(string[] args)
        {
            // Pripojenie k databaze
            SqlConnection connection = new SqlConnection("Server=YourServerName;Database=YourDatabaseName;Integrated Security=True;");
            try
            {
                connection.Open();

                // Vytvorenie registračnej tabuľky, ak neexistuje
                SqlCommand createTableCommand = new SqlCommand("CREATE TABLE IF NOT EXISTS Registrations (ID INT IDENTITY(1,1) PRIMARY KEY, Username NVARCHAR(50), Email NVARCHAR(50), Password NVARCHAR(50))", connection);
                createTableCommand.ExecuteNonQuery();

                // Vloženie nového záznamu do registračnej tabuľky
                string username = "TestUser";
                string email = "testuser@example.com";
                string password = "TestPassword"; // Môžete použiť bezpečnějšie spôsoby uchovávania hesiel, ako je hašovanie.
                SqlCommand insertCommand = new SqlCommand("INSERT INTO Registrations (Username, Email, Password) VALUES (@Username, @Email, @Password)", connection);
                insertCommand.Parameters.AddWithValue("@Username", username);
                insertCommand.Parameters.AddWithValue("@Email", email);
                insertCommand.Parameters.AddWithValue("@Password", password);
                insertCommand.ExecuteNonQuery();

                Console.WriteLine("Registracia bola úspešne vykonaná.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Chyba: " + ex.Message);
            }
            finally
            {
                // Uzavretie pripojenia k databáze
                connection.Close();
            }

            Console.ReadLine();
        }
    }
}*/


/*public class DatabaseManager
    {
        private string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=registrationdatabase";

        public bool RegisterUser(string username, string email, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(MySQLConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO users (username, password) VALUES (@username, @password)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        //command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // If rows were affected then registration was successfull
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false; // Registration failed
                }
            }
        }
    }*/
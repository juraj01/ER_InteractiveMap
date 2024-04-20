using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace EldenRing___Interaktívna_mapa___Guna_UI
{
    public partial class MessagePopUp : Form
    {

        private bool isDragging = false;
        private Point lastCursorPosition;


        public MessagePopUp()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            //UpperBorderPanel event handlers:
            this.UpperBorderPanel.MouseDown += UpperBorderPanel_MouseDown;
            this.UpperBorderPanel.MouseMove += UpperBorderPanel_MouseMove;
            this.UpperBorderPanel.MouseUp += UpperBorderPanel_MouseUp;
            this.Ok.Click += Ok_Click;

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

        internal void ShowMessage(string message)
        {
            this.MessageLabel.Text = message;
            this.Visible = true;
            //this.ShowDialog();
        }

       
        
        private void MessagePopUp_Load(object sender, EventArgs e)
        {
            /*PrivateFontCollection pfc = new PrivateFontCollection();
             //pfc.AddFontFile("E:CustomFont.ttf");
             foreach (Control C in this.Controls)
             {
                 C.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
             }*/
            int labelTop = (this.Height - MessageLabel.Height) / 2;
            MessageLabel.Top = labelTop;
            int labelLeft = (this.Width - MessageLabel.Width) / 2;
            MessageLabel.Left = labelLeft;

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    




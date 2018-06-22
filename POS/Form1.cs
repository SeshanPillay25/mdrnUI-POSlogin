using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.OleDb;


namespace POS
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,     // x-coordinate of upper-left corner
    int nTopRect,      // y-coordinate of upper-left corner
    int nRightRect,    // x-coordinate of lower-right corner
    int nBottomRect,   // y-coordinate of lower-right corner
    int nWidthEllipse, // height of ellipse
    int nHeightEllipse // width of ellipse
);
        SqlConnection con = new SqlConnection();
        public Form1()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=yourpcnamehere\\servernamehere;Initial Catalog=POSdb;Integrated Security=True";
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=yourpcnamehere\\servernamehere;Initial Catalog=POSdb;Integrated Security=True");
            con.Open();

            {
            }
            var materialTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.Transparent;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(usernameTextbox.Text == string.Empty))
                {
                    if (!(passwordTextbox.Text == string.Empty))
                    {
                        String str = "Data Source=yourpcnamehere\\servernamehere;Initial Catalog=POSdb;Integrated Security=True";

                        String query = "select * from Login where Username Like '" + usernameTextbox.Text + "'and password Like '" + this.passwordTextbox.Text + "'";

                        SqlConnection con = new SqlConnection(str);
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader dbr;

                        con.Open(); // Opened connection
                        dbr = cmd.ExecuteReader();
                        int count = 0;
                        while (dbr.Read())
                        {
                            count = count + 1;
                        }
                        if (count == 1)
                        {
                            MessageBox.Show("Login Successful!");
                            this.Hide();
                            Form2 f2 = new Form2();
                            f2.ShowDialog();
                        }
                        // Tried to take everything into account here
                        else if (count > 1)
                        {
                            MessageBox.Show("Duplicate username and password", "login page");
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username and password", "login page");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mind entering your password? please :(", "login page");
                    }
                }
                else
                {
                    MessageBox.Show("Now why would you leave the field empty?, fill it in!", "login page");
                }
                con.Close(); // Closed connection
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

        }
    }
}

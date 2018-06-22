using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();               
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            homeControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            homeControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            other1.BringToFront();
                       
            
        }

        private void exitFormButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void linkedinButton_Click(object sender, EventArgs e)
        {
            // My professional profile
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/seshan-pillay-04009814a/");
        }

        private void twitterButton_Click(object sender, EventArgs e)
        {
            // Don't judge my twitter handle or my content okay
            System.Diagnostics.Process.Start("https://twitter.com/ArcticGh0st");
        }

        private void homeControl1_Load(object sender, EventArgs e)
        {

        }
    }
}

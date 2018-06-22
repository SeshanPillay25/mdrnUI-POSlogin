using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.OleDb;


namespace POS
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();

        }
        decimal total = 0;
        private void HomeControl_Load(object sender, EventArgs e)
        {
            var dataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
        }

        private void bunifuMaterialTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            this.Item_codeTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);
        }
            public  void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                var select = "SELECT * FROM Itemdb WHERE Item_code LIKE '" + Item_codeTextbox.Text + "'";
                var c = new SqlConnection("Data Source=yourpcnamehere\\servernamehere;Initial Catalog=POSdb;Integrated Security=True");
                var dataAdapter = new SqlDataAdapter(select, c);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                bunifuCustomDataGrid1.ReadOnly = true;
                bunifuCustomDataGrid1.DataSource = ds.Tables[0];
            }
        }

        private void Item_codeTextbox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            total += (decimal)bunifuCustomDataGrid1.Rows[0].Cells[2].Value;
            totalLabel.Text = "R" + Convert.ToString(total);
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Enabled == true)
            {
                MessageBox.Show("Why would you even enable something called 'SARS mode', now you're gonna get taxed !!!");
                total += 35;
            }

        }
    }
    }
    


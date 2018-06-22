using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Other : UserControl
    {
        public Other()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            bunifuProgressBar1.Value = r.Next(1, 100);
            bunifuProgressBar2.Value = r.Next(1, 100);
            bunifuProgressBar3.Value = r.Next(1, 100);
        }
    }
}

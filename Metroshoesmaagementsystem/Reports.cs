using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metroshoesmaagementsystem
{
    public partial class Reports : System.Windows.Forms.Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mostly_sold_items mostly_Sold_Items = new Mostly_sold_items();
            mostly_Sold_Items.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Leastsolditemsreport leastsolditemsreport = new Leastsolditemsreport();
            leastsolditemsreport.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Total_stock total_Stock = new Total_stock();
            total_Stock.ShowDialog();
        }
    }
}

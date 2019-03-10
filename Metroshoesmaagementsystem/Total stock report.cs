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
    public partial class Total_stock : Form
    {
        public Total_stock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Flat chappals", 150);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Wedges", 150);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Shoes", 100);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Sleepers",200);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Sandals",100);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Trainers",50);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Brogues",50);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Loafer",200);
            
        }
    }
}

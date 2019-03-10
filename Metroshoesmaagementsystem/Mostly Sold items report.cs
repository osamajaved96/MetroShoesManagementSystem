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
    public partial class Mostly_sold_items : System.Windows.Forms.Form
    {
        public Mostly_sold_items()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Flat chappals", 1000);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Wedges", 800);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Shoes", 400);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Sleepers", 480);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Sandals", 850);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Trainers", 800);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Brogues", 400);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Loafer", 850);
        }
    }
}

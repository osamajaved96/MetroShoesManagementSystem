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
    public partial class Leastsolditemsreport : Form
    {
        public Leastsolditemsreport()
        {
            InitializeComponent();
        }

        private void Leastsolditemsreport_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Lace ups", 10);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Canvas shoes", 80);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Wellington boots", 40);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Flip flops", 48);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Court shoes", 10);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Ankle boots", 48);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Calf boots", 85);
            this.chart1.Series["Mostly Sold items"].Points.AddXY("Leather long boots", 85);
        }
    }
}

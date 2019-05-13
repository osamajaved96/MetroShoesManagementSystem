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
    public partial class computerOperator : System.Windows.Forms.Form
    {
        public computerOperator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Generate_bill generateBill = new Generate_bill();
            generateBill.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            login mainScr = new login();
            mainScr.ShowDialog();
        }

        private void computerOperator_Load(object sender, EventArgs e)
        {

        }
    }
}

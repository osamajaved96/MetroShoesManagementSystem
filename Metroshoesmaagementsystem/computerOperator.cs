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
            Addsales addSales = new Addsales();
            addSales.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Generate_bill generateBill = new Generate_bill();
            generateBill.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Addashoe addShoes = new Addashoe();
            addShoes.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Shoe_search shoe_Search = new Shoe_search();
            shoe_Search.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainscreen mainScr = new Mainscreen();
            mainScr.ShowDialog();
        }

        private void computerOperator_Load(object sender, EventArgs e)
        {

        }
    }
}

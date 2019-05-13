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
    public partial class login : System.Windows.Forms.Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "operator" && textBox2.Text == "metroshoesopr")
            {
                this.Hide();
                computerOperator compOpr = new computerOperator();
                compOpr.ShowDialog();
            }
            else if (textBox1.Text == "manager" && textBox2.Text == "metroshoesmgr")
            {
                this.Hide();
                Manager mgr = new Manager();
                mgr.ShowDialog();
            }
            else if(textBox1.Text != "manager" && textBox2.Text != "metroshoesmgr" || textBox1.Text != "operator" && textBox2.Text != "metroshoesopr")
            {
                MessageBox.Show("Incorrect Username/password! Please enter correct username and password!", "login Incorrect!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mainscreen_Load(object sender, EventArgs e)
        {

        }
    }
}

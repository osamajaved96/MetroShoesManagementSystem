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
    public partial class Expenditure_records : System.Windows.Forms.Form
    {
        public Expenditure_records()
        {
            InitializeComponent();
        }

        private void Expenditure_records_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Monthly_expense monthly_Expense = new Monthly_expense();
            monthly_Expense.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Daily_expense daily_Expense = new Daily_expense();
            daily_Expense.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Weekly_expense weekly_Expense = new Weekly_expense();
            weekly_Expense.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Yearly_expense yearly_Expense = new Yearly_expense();
            yearly_Expense.ShowDialog();
        }
    }
}

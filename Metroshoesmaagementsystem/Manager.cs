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
    public partial class Manager : System.Windows.Forms.Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_management user_Management = new User_management();
            user_Management.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainscreen mainScr = new Mainscreen();
            mainScr.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Generate_bill generateBill = new Generate_bill();
            generateBill.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculate_payrolls_and_incentives attendance = new calculate_payrolls_and_incentives();
            attendance.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search_sales_record search_Sales_Record = new Search_sales_record();
            search_Sales_Record.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Shoe_search shoe_Search = new Shoe_search();
            shoe_Search.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Addashoe addShoes = new Addashoe();
            addShoes.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employee_Attendance employee_Attendance = new Employee_Attendance();
            employee_Attendance.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Expenditure_records expenditure_Records = new Expenditure_records();
            expenditure_Records.ShowDialog();
        }
    }
}

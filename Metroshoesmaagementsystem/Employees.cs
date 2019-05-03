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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            dataGridView1.DataSource = emp.list_all();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            string employee_ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Employee emp = new Employee();
            emp.get(int.Parse(employee_ID));
            textBox1.Text = emp.full_name;
            textBox2.Text = emp.phone;
            textBox3.Text = emp.address;
            textBox4.Text = emp.scale.ToString();
            textBox5.Text = emp.salary;
            textBox6.Text = emp.user_ID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.delete(1);
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.update();
        }
    }
}
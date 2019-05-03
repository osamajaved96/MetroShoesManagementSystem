using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metroshoesmaagementsystem
{
    class Employee
    {
        public int employee_ID;
        public string full_name;
        public string phone;
        public string address;
        public int scale;
        public string salary;
        public int user_ID;

        public string conString = "Server=OSAMAJAVED-PC\\SQLEXPRESS;Database=MSMSdatabase;Integrated Security=True";
        SqlConnection sqlCon;

        public Employee()
        {
            sqlCon = new SqlConnection();
            sqlCon.Open();
        }

        public DataTable list_all()
        {
            DataTable Employees_DT = new DataTable();
            try
            {
                string queryString = "SELECT * FROM employee";

                SqlDataAdapter SDA = new SqlDataAdapter(queryString, sqlCon);

                SDA.Fill(Employees_DT);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return Employees_DT;
        }

        public Employee get(int ID)
        {
            string queryString = "SELECT * FROM employee WHERE employee_ID = '"+ID+"'";

            SqlDataAdapter SDA = new SqlDataAdapter(queryString, sqlCon);
            DataTable Employees_DT = new DataTable();
            SDA.Fill(Employees_DT);

            full_name = Employees_DT.Rows[0]["full_name"].ToString().Trim();
            phone = Employees_DT.Rows[0]["phone"].ToString().Trim();
            address = Employees_DT.Rows[0]["address"].ToString().Trim();
            scale = int.Parse(Employees_DT.Rows[0]["scale"].ToString());
            salary = Employees_DT.Rows[0]["salary"].ToString().Trim();
            user_ID = int.Parse(Employees_DT.Rows[0]["user_ID"].ToString());

            return this;
        }
        public int delete(int ID)
        {
            string queryString = "DELETE FROM employee WHERE employee_ID = '"+ID+"'";
            SqlCommand SC = new SqlCommand(queryString, sqlCon);
            try
            {
                SC.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ID;
        }
        public void update()
        {
            string queryString = "UPDATE employee SET full_name = '"+full_name+"', phone = '"+phone+"', address = '"+address+"', scale = '"+scale+"', salary = '"+salary+"', user_ID = '"+user_ID+"'";
            SqlCommand SC = new SqlCommand(queryString, sqlCon);
            try
            {
                SC.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void closeConnection()
        {
            sqlCon.Close();
        }
    }
}


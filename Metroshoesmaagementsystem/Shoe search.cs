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
    public partial class Shoe_search : System.Windows.Forms.Form
    {
        public Shoe_search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shoe_search_results shoe_Search_Results = new Shoe_search_results();
            shoe_Search_Results.ShowDialog();
        }
    }
}
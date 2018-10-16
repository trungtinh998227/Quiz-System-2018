using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_System_2018
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void rbRemem_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trung\Documents\Quiz_Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter Sda = new SqlDataAdapter("select count(*) from LOGIN where USERNAME='"+txbLogin+"'and PASSWORD='"+txbPass+"'",conn);

        }
    }
}

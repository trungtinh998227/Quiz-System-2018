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
    public partial class Quiz_config_student : Form
    {
        string userName = "";
        SqlConnection conn;
        SqlDataAdapter adapter;
        public Quiz_config_student(string UserName)
        {
            InitializeComponent();
            userName = UserName;
        }



        private void Quiz_config_student_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trung\Desktop\Quiz-System-2018\Quiz-System-2018\Quiz-System-2018\Quiz_System_DB.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string str = "SELECT Name FROM DANHSACH WHERE UserName='"+userName+"'";
            SqlDataReader reader = new SqlCommand(str, conn).ExecuteReader();
            while (reader.Read())
            {
                lbName.Text = reader.GetValue(0).ToString();
            }
            conn.Close();
            label8.ForeColor = System.Drawing.Color.Red;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntStart_Click(object sender, EventArgs e)
        {
            conn.Open();
            string check = "SELECT DISTINCT MaMon FROM DETHI WHERE MaMon='" + txbIDcourse.Text+"'";
            SqlDataReader read = new SqlCommand(check, conn).ExecuteReader();
            if (read.Read())
            {
                Quiz_Form QF = new Quiz_Form(txbIDcourse.Text);
                this.Hide();
                QF.ShowDialog();
                this.Show();
            }else
            {
                MessageBox.Show("Sai mã môn học, vui lòng nhập lại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            conn.Close();
        }
    }
}

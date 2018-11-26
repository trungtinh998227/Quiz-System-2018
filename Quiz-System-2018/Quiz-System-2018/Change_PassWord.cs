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
    public partial class Change_PassWord : Form
    {
        string UserName = "";
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        public Change_PassWord(string userName)
        {
            InitializeComponent();
            UserName = userName;
        }

        private void Change_PassWord_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trung\Desktop\Quiz-System-2018\Quiz-System-2018\Quiz-System-2018\Quiz_System_DB.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            conn.Open();
            string oldPass = "";
            if (txbCheckPass.Text==""||txbNewPass.Text==""||txbOldPass.Text=="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            SqlDataReader reader = new SqlCommand("SELECT Password FROM LOGIN WHERE UserName='"+UserName+"'", conn).ExecuteReader();
            if (reader.Read())
            {
                oldPass = reader.GetValue(0).ToString().Trim();
            }
            conn.Close();
            if (!oldPass.Equals(txbOldPass.Text.Trim()))
            {
                MessageBox.Show("Nhập sai mật khẩu cũ. Vui lòng nhập lại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (!txbNewPass.Text.Equals(txbCheckPass.Text))
            {
                
                MessageBox.Show("Mật khẩu không khớp. Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                conn.Open();
                adapter = new SqlDataAdapter("UPDATE LOGIN SET Password='"+txbNewPass.Text+"'WHERE UserName='"+UserName+"'",conn);
                MessageBox.Show("Đổi mật khẩu thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                adapter.SelectCommand.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

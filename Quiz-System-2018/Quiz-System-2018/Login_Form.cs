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
        //Tạo biến lưu lại thông tin dùng cho form Giảng viên và Sinh viên
        string UserName;
        public string MyUsername
        {
            get { return UserName; }
            set { UserName = value; }
        }


        public Login_Form()
        {
            InitializeComponent();
        }

        private void bntLogin_Click(object sender, EventArgs e) 
        {
            MyUsername = txbLogin.Text;
            string checkUserNameAdmin = "Admin";
            string checkUserNameGV = "GV";
            string checkUserNameSV = "SV";

            //Kiểm tra xem đã nhập đủ username vs pass chưa
            
            // Kiểm tra xem đã đăng nhập đúng chưa
            try
            {
                string myConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trung\Desktop\Quiz-System-2018\Quiz-System-2018\Quiz-System-2018\Quiz_System_DB.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection myConn = new SqlConnection(myConnection);
                SqlCommand SelectCommand = new SqlCommand("select * from [dbo].[LOGIN] where Username = '" + this.txbLogin.Text + "' and Password = '" + this.txbPass.Text + "';", myConn);
                SqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int check = 0; 
                while (myReader.Read())
                {
                    if (txbLogin.Text == checkUserNameAdmin)
                    {
                        check = 1;
                    }
                    if (txbLogin.Text.Substring(0,2) == checkUserNameGV)
                    {
                        check = 2;
                    }
                    if(txbLogin.Text.Substring(0,2) == checkUserNameSV)
                        check = 3;
                }

                if (check == 1)
                {
                    Admin ad = new Admin();
                    this.Hide();
                    ad.ShowDialog();
                    this.Show();
                }
                else if (check == 2)
                {
                    this.Hide();
                    Quiz_config_teacher GV = new Quiz_config_teacher(MyUsername);
                    GV.ShowDialog();
                    this.Show();                }
                else if (check == 3)
                {
                    this.Hide();
                    Quiz_config_student SV = new Quiz_config_student();
                    SV.ShowDialog();
                    this.Show();
                }
                else if (txbLogin.Text == "" && txbPass.Text == "")
                {
                    MessageBox.Show("Vui lòng điền thông tin đăng nhập!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txbPass.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txbLogin.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //thiết lập kiểu thoát ứng dụng
        private void Login_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn thật sự muốn thoát?","Thông Báo",MessageBoxButtons.OKCancel)!= System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}

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
    public partial class Quiz_config_teacher : Form
    {
        string checkUser;
        public Quiz_config_teacher(string value)
        {
            InitializeComponent();
            checkUser = value;
        }
        //Mở kết nỗi database
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private SqlCommandBuilder builder;
        private DataTable dataTable;
        
        
        
        //Form dành cho giảng viên, load đầu tiên khi giảng viên đăng nhập thành công
        private void Quiz_config_teacher_Load(object sender, EventArgs e)
        {
            //Login_Form getValues = new Login_Form();
            //MessageBox.Show(checkUser);
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trung\Desktop\Quiz-System-2018\Quiz-System-2018\Quiz-System-2018\Quiz_System_DB.mdf;Integrated Security=True;Connect Timeout=30");
        }
        private void cbNameCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string strMon = "SELECT TENMON FROM MON Where UserName = '"+checkUser+"'";
            }
            catch
            {
                MessageBox.Show("ComboBox Load Error", "Thông báo!");
            }
        }
    }
}

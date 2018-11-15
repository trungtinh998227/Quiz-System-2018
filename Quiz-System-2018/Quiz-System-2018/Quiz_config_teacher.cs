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
        string checkPass;
        public Quiz_config_teacher(string value,string values)
        {
            InitializeComponent();
            checkUser = value;
            checkPass = values;
        }


        //Mở kết nỗi database
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private SqlCommandBuilder builder;
        private DataTable dataTable;
        
        
        
        //Form dành cho giảng viên, load đầu tiên khi giảng viên đăng nhập thành công
        private void Quiz_config_teacher_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trung\Desktop\Quiz-System-2018\Quiz-System-2018\Quiz-System-2018\Quiz_System_DB.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                //Load TENMON từ db vào combobox
                conn.Open();
                string strMon = "SELECT TENMON FROM MON Where UserName = '" + checkUser + "'";
                SqlDataReader reader = new SqlCommand(strMon, conn).ExecuteReader();
                while (reader.Read())
                {
                    cbNameCourse.Items.Add(reader.GetValue(0).ToString());
                }
                reader.Close();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("ComboBox Load Error", "Thông báo!");
            }
        }
        private void cbNameCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                if(cbNameCourse.SelectedItem.ToString().Equals("Other..."))
                {
                    MessageBox.Show("Load form add new MON");
                    //Load form thêm MÔN giảng dạy cho giảng viên \
                    newMon addMon = new newMon();
                    this.Hide();
                    addMon.ShowDialog();
                    this.Show();
                }
                else
                {
                    bntAddCoures.Enabled = true;
                    cbLevelQue.Enabled = true;
                    DataTable dbtGV = new DataTable();
                    //Lấy mã môn học từ dữ liệu
                    conn.Open();
                    string ID = "SELECT * FROM MON WHERE TenMon = N'" + cbNameCourse.SelectedItem.ToString() + "' and  UserName='" + checkUser + "'";
                    adapter = new SqlDataAdapter(ID, conn);
                    adapter.SelectCommand.ExecuteNonQuery();
                    adapter.Fill(dbtGV);
                    //MessageBox.Show(txbIDCourse.Text = reader.GetValue(0).ToString());
                    txbIDCourse.Text = dbtGV.Rows[0][0].ToString();
                    conn.Close();
                }
                
            }
            catch
            {
                MessageBox.Show(txbIDCourse.Text);
            }
        }
    }
}

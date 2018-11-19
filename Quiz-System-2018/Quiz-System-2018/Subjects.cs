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
    public partial class Subjects : Form
    {
        string IdCourse="";
        string NameCourse = "";

        //Mở kết nỗi database
        private SqlConnection conn;
        private SqlDataAdapter adapter;


        public Subjects(string idCourse,string nameCourse)
        {
            InitializeComponent();
            IdCourse = idCourse;
            NameCourse = nameCourse;
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            txbNameCourse.Text = IdCourse;
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trung\Desktop\Quiz-System-2018\Quiz-System-2018\Quiz-System-2018\Quiz_System_DB.mdf;Integrated Security=True;Connect Timeout=30");
            //Đổ dữ liệu vào combobox mã đề thi

            conn.Open();
            string getSubject = "SELECT DISTINCT MaDeThi FROM DETHI WHERE DETHI.MaMon='" + IdCourse.Trim()+"'";
            SqlDataReader read = new SqlCommand(getSubject, conn).ExecuteReader();
            while (read.Read())
            {
                cbSubject.Items.Add(read.GetValue(0).ToString());
            }
            conn.Close();
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = cbSubject.SelectedItem.ToString();
            conn.Open();
            string gridShow = "SELECT CauHoi as 'Câu Hỏi',DapAn1 as 'Đáp án 1',DapAn2 as 'Đáp án 2',DapAn3 as 'Đáp án 3',DapAn4 as 'Đáp án 4',DapAnDung as 'Đáp án đúng' FROM DETHI WHERE MaDeThi='" + str.Trim()+"'";
            adapter = new SqlDataAdapter(gridShow, conn);
            adapter.SelectCommand.ExecuteNonQuery();
            DataTable dtb = new DataTable();
            adapter.Fill(dtb);
            dataSubGrid.DataSource = dtb;

            string numOfQues = "SELECT COUNT(*) FROM DETHI WHERE MaDeThi='" + str.Trim() + "'";
            SqlDataReader read = new SqlCommand(numOfQues, conn).ExecuteReader();
            while (read.Read())
            {
                txbNumOfAns.Text = read.GetValue(0).ToString();
            }
            conn.Close();
        }
    }
}

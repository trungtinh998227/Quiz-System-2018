using System;
using System.Collections;
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
    
    public partial class Quiz_Form : Form
    {
        //Countdown timer
        int h=0, m=0, s=0;
        string IdCourse = "";
        //Lấy dữ liệu từ DB
        SqlDataAdapter adapter;
        SqlConnection conn;
        public Quiz_Form(string passing)
        {
            InitializeComponent();
            IdCourse = passing;
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            s = s - 1;
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }
            if (m == -1)
            {
                h = h - 1;
                m = 59;
            }
            if (h == 0 && m == 0 && s == 0)
            {
                timer.Stop();
                MessageBox.Show("Đã hết thời gian làm bài", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            lbHour.Text = Convert.ToString(h);
            lbMinute.Text = Convert.ToString(m);
            lbSecond.Text = Convert.ToString(s);
        }

        //Lấy câu hỏi tử DB
        private List<string> Load_Ques(string IdSub)
        {
            List<string> list = new List<string>();
            conn.Open();
            string getQues = "SELECT CauHoi FROM DETHI WHERE MaDeThi='"+IdSub+"'";
            SqlDataReader rd = new SqlCommand(getQues, conn).ExecuteReader();
            while (rd.Read())
            {
                list.Add(rd.GetValue(0).ToString());
            }
            conn.Close();


            return list;
        }
        private void Quiz_Form_Load(object sender, EventArgs e)
        {
            
            int index = 0;
            string IdSub = "";
            timer.Start();
            List<string> list = new List<string>();
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trung\Desktop\Quiz-System-2018\Quiz-System-2018\Quiz-System-2018\Quiz_System_DB.mdf;Integrated Security=True;Connect Timeout=30");

            //Lấy mã đề thi ngãu nhiêns
            conn.Open();
            string getIdSub = "SELECT DISTINCT MaDeThi FROM DETHI WHERE MaMon='"+IdCourse+"'";
            SqlDataReader rd = new SqlCommand(getIdSub, conn).ExecuteReader();
            while (rd.Read())
            {
                list.Add(rd.GetValue(0).ToString());
            }
            rd.Close();
            conn.Close();
            //Lấy ngẫu nhiên 1 đề từ bộ đề
            Random rn = new Random();
            index = rn.Next(list.Count);
            IdSub = list[index];
            
            conn.Open();
            string getTime = "SELECT Time FROM THOIGIANTHI WHERE MaDeThi='"+IdSub+"'";
            SqlDataReader read = new SqlCommand(getTime, conn).ExecuteReader();
            MessageBox.Show(getTime);
            if (read.Read())
            {
                int time = Convert.ToInt32(read.GetValue(0).ToString());
                MessageBox.Show("" + time);
                Standardized_Time(time);
            }
            conn.Close();
        }
        private void Standardized_Time(int time)
        {
                h = time / 60;
                m = time % 60;
                s = 0;
        }
    }
}

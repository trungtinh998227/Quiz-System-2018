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
    
    public partial class Quiz_Form : Form
    {
        //Countdown timer
        int h, m, s;
        string IdSub = "BMODYN";
        //Lấy dữ liệu từ DB
        SqlDataAdapter adapter;
        SqlConnection conn;
        public Quiz_Form()
        {
            InitializeComponent();
            //IdSub = passing;
        }

        /*private void timer_Tick(object sender, EventArgs e)
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
        }*/

        public int OnTimeEvent { get; private set; }

        private void Quiz_Form_Load(object sender, EventArgs e)
        {
            //timer.Start();
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trung\Desktop\Quiz-System-2018\Quiz-System-2018\Quiz-System-2018\Quiz_System_DB.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string getTime = "SELECT DISTINCT Time FROM THOIGIANTHI WHERE MaDeThi='"+IdSub+"'";
            SqlDataReader read = new SqlCommand(getTime, conn).ExecuteReader();
            //int time = Convert.ToInt32(read.GetValue(0).ToString());
            //MessageBox.Show(""+time);
            conn.Close();
            txbQuestion.Text="Demo thử xem thế nào thôi";
        }
    }
}

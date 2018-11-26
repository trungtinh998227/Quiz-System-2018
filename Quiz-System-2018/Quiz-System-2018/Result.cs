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
    public partial class Result : Form
    {
        //Mở kết nỗi database
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trung\Desktop\Quiz-System-2018\Quiz-System-2018\Quiz-System-2018\Quiz_System_DB.mdf;Integrated Security=True;Connect Timeout=30");
            pnResult.Controls.Clear();
            conn.Open();
            SqlDataReader reader = new SqlCommand("SELECT DapAn FROM KETQUA", conn).ExecuteReader();
            List<string> checkAns = new List<string>();
            while (reader.Read())
            {
                checkAns.Add(reader.GetValue(0).ToString());
            }
            int x = 85, y = 18;
            for(int i = 0; i < checkAns.Count; i++)
            {
                Label lb = new Label();
                if (checkAns[i] == "")
                {
                    lb.Text = "Câu  " + (i + 1) + " chưa trả lời.";
                }
                else
                {
                    lb.Text = "Câu  " + (i + 1) + " đã trả lời.";
                }
                lb.Location = new Point(x,y);
                y = y + 25;
                lb.AutoSize = true;
                pnResult.Controls.Add(lb);
            }
            conn.Close();
        }

        private void bntOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form Lg = new Login_Form();
            Lg.Show();
        }
    }
}

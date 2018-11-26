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
        string IdSub = "";
        int limit = 0;//Giới hạn số lượng câu hỏi tối đa
        //Lấy dữ liệu từ DB
        SqlDataAdapter adapter;
        SqlConnection conn;
        int status;
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
                DialogResult res = MessageBox.Show("Đã hết thời gian làm bài", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    Result rs = new Result();
                    rs.Show();
                    this.Close();
                }
            }
            lbHour.Text = Convert.ToString(h);
            lbMinute.Text = Convert.ToString(m);
            lbSecond.Text = Convert.ToString(s);
        }

        //Lấy câu hỏi tử DB
        private string Load_Ques(string IdSub,int index)
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
            limit = list.Count;
            return list[index];
        }
        //Lấy đáp án đưa lên lable
        private void Load_Ans(string ID, int INDEX)
        {
            conn.Open();
            string getAns = "SELECT DapAn1,DapAn2,DapAn3,DapAn4 FROM DETHI WHERE MaDeThi='"+ID+"'";
            adapter = new SqlDataAdapter(getAns, conn);
            adapter.SelectCommand.ExecuteNonQuery();
            DataTable dtb = new DataTable();
            adapter.Fill(dtb);
               string A = dtb.Rows[INDEX][0].ToString();
            
               string B = dtb.Rows[INDEX][1].ToString();
            
               string C = dtb.Rows[INDEX][2].ToString();
           
               string D = dtb.Rows[INDEX][3].ToString();
            if (C == "")
            {
                label3.Visible = false;
                rdbC.Visible = false;
            }
            else
            {
                label3.Visible = true;
                rdbC.Visible = true;
            }
            if(D=="")
            {
                label4.Visible = false;
                rdbD.Visible = false;
            }
            else
            {
                label4.Visible = true;
                rdbD.Visible = true;
            }
            label1.Text = A;
            label2.Text = B;
            label3.Text = C;
            label4.Text = D;
            conn.Close();
        }

        private void bntRevious_Click(object sender, EventArgs e)
        {
            load(status);
            if (status == 0)
            {
                bntRevious.Enabled = false;
            }
            else
            {
                status--;
                txbQuestion.Text = Load_Ques(IdSub, status);
                Load_Ans(IdSub, status);
            }
            
        }

        private void load(int stt)
        {
            //Kiểm tra câu hỏi đã trả lời hay chưa
            conn.Open();
            adapter = new SqlDataAdapter("SELECT DapAn,MaCauHoi FROM KETQUA WHERE MaDeThi='" + IdSub + "'", conn);
            adapter.SelectCommand.ExecuteNonQuery();
            DataTable dtb = new DataTable();
            adapter.Fill(dtb);
            string rs = "";
            if (dtb.Rows[stt][0].ToString() == "")
            {
                if (rdbA.Checked == true)
                {
                    rs = "Đáp án 1";
                }
                else if (rdbB.Checked == true)
                {
                    rs = "Đáp án 2";
                }
                else if (rdbC.Checked == true)
                {
                    rs = "Đáp án 3";
                }
                else if (rdbD.Checked==true)
                {
                    rs = "Đáp án 4";
                }

            }
            else
            {
                rs = dtb.Rows[stt][0].ToString();
                if (rs.Equals("Đáp án 1", StringComparison.InvariantCultureIgnoreCase))
                {
                    rdbA.Checked = true;
                }
                else if (rs.Equals("Đáp án 2", StringComparison.InvariantCultureIgnoreCase))
                {
                    rdbB.Checked = true;
                }
                else if (rs.Equals("Đáp án 3", StringComparison.InvariantCultureIgnoreCase))
                {
                    rdbC.Checked = true;
                }
                else
                {
                    rdbD.Checked = true;
                }
            }
            adapter = new SqlDataAdapter("UPDATE KETQUA SET DapAn=N'" + rs + "'WHERE MaCauHoi='" + dtb.Rows[status][1].ToString() + "'", conn);
            adapter.SelectCommand.ExecuteNonQuery();
            conn.Close();
            
        }

        private void bntNext_Click(object sender, EventArgs e)
        {
            load(status);
            
            bntRevious.Enabled = true;
            if (status == limit-1)
            {
                DialogResult res = MessageBox.Show("Bạn có muốn chuyển đến trang nộp bài. Lưu ý: Bạn không thể quay lại làm bài.","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    load(status-1);
                    this.Hide();
                    Result rs = new Result();
                    rs.Show();
                    
                }
            }
            else
            {
                status++;
                txbQuestion.Text = Load_Ques(IdSub, status);
                Load_Ans(IdSub, status);
            }
            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;

        }

        private void Quiz_Form_Load(object sender, EventArgs e)
        {
            

            int index = 0;
            timer.Start();
            List<string> list = new List<string>();
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trung\Desktop\Quiz-System-2018\Quiz-System-2018\Quiz-System-2018\Quiz_System_DB.mdf;Integrated Security=True;Connect Timeout=30");

            //Lấy mã đề thi ngãu nhiên
            conn.Open();
            adapter = new SqlDataAdapter("DELETE FROM KETQUA",conn);
            adapter.SelectCommand.ExecuteNonQuery();
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

            //Đưa toàn bộ câu hỏi của đề thi nào DB KETQUA
            List<string> list_Ques = new List<string>();
            conn.Open();
            string putQues = "SELECT MaCaUHoi FROM DETHI WHERE MaDeThi='" + IdSub + "'";
            SqlDataReader dr = new SqlCommand(putQues, conn).ExecuteReader();
            while (dr.Read())
            {
                list_Ques.Add(dr.GetValue(0).ToString());
            }
            conn.Close();
            //Chuyển mã câu hỏi vào DB
            conn.Open();
            for(int i = 0; i < list_Ques.Count; i++)
            {
                //
                adapter = new SqlDataAdapter("INSERT INTO KETQUA (MaDeThi,MaCaUHoi) VALUES('" + IdSub + "','" + list_Ques[i] + "')", conn);
                adapter.SelectCommand.ExecuteNonQuery();
            }  
            conn.Close();

            conn.Open();
            string getTime = "SELECT Time FROM THOIGIANTHI WHERE MaDeThi='"+IdSub+"'";
            SqlDataReader read = new SqlCommand(getTime, conn).ExecuteReader();
            if (read.Read())
            {
                int time = Convert.ToInt32(read.GetValue(0).ToString());
                Standardized_Time(time);
            }
            conn.Close();
            txbQuestion.Text = Load_Ques(IdSub, status);
            Load_Ans(IdSub, status);

            conn.Open();
            string counter = "SELECT COUNT(*) FROM DETHI WHERE MaDeThi='"+IdSub+"'";
            SqlDataReader r= new SqlCommand(counter, conn).ExecuteReader();
            if (r.Read())
            {
                int NumOfQues = Convert.ToInt32(r.GetValue(0).ToString());
                Panel_1.Controls.Clear();
                int x = 24, y = 0;
                int break_line = 0;
                for (int i = 0; i < NumOfQues; i++)
                {
                    if (break_line % 4 == 0)
                    {
                        y = y + 34;
                        x = 24;
                    }
                    Button ans = new Button();
                    ans.Name = i.ToString();
                    ans.Location = new Point(x,y);
                    break_line++;
                    x += 41;
                    ans.Text = (i + 1).ToString();
                    ans.Size = new Size(35,28);
                    ans.Click += new EventHandler(Ans_click);
                    Panel_1.Controls.Add(ans);
                }
            }
            conn.Close();

        }
        private void Ans_click(object sender, EventArgs e)
        {
            Button bnt = sender as Button;
            Load_Ans(IdSub,Convert.ToInt32(bnt.Name.ToString()));
            txbQuestion.Text = Load_Ques(IdSub, Convert.ToInt32(bnt.Name.ToString()));
            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;
            load(Convert.ToInt32(bnt.Name.ToString()));
        }

        private void Standardized_Time(int time)
        {
                h = time / 60;
                m = time % 60;
                s = 0;
        }
    }
}

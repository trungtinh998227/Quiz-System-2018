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

namespace Quiz_System_2018{
    public partial class Answer : Form
    {
        string getidQues="";
        string getidMon = "";
        int NumofAns = 0;

        //Biến toàn cục dùng cho load db
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable dtQues;
        //Load data from DAPAN to gridview
        private void load_grid()
        {
            //Lấy dữ liệu đưa lên datagridview
            conn.Open();
            string str = "SELECT CauHoi as N'Câu hỏi', DapAn1 as N'Đáp án 1',DapAn2 as N'Đáp án 2',DapAn3 as N'Đáp án 3',DapAn4 as N'Đáp án 4' FROM CAUHOI,DAPAN WHERE CAUHOI.MaCauHoi = DAPAN.MaCauHoi AND DAPAN.MaMon = CAUHOI.MaMon AND CAUHOI.MaCauHoi='"+getidQues+"'AND CAUHOI.MaMon='"+getidMon+"'";
            //MessageBox.Show(str);
            adapter = new SqlDataAdapter(str, conn);
            adapter.Fill(dtQues = new DataTable());
            gridAnswer.DataSource = dtQues;

            //Lấy câu hỏi đưa vào textbox câu hỏi
            string getQues = "SELECT CauHoi FROM CAUHOI where MaCauHoi='" + getidQues + "'AND MaMon='"+getidMon+"'";
            SqlDataReader read = new SqlCommand(getQues, conn).ExecuteReader();
            while (read.Read())
            {
                txbQues.Text = read.GetValue(0).ToString();
            }
            conn.Close();
        }

        public Answer(string ques,int num,string idMon)
        {
            getidQues = ques;
            getidMon = idMon;
            NumofAns = num;
            InitializeComponent();
        }

        private void Answer_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trung\Desktop\Quiz-System-2018\Quiz-System-2018\Quiz-System-2018\Quiz_System_DB.mdf;Integrated Security=True;Connect Timeout=30");
                
                load_grid();
                
                //Ứng với số đáp án sẽ hiện số câu trả lời khác nhau
                if (NumofAns == 2)
                {
                    txb3.Text = null;
                    txb4.Text = null;
                    cbTrueAns.Items.Clear();//Làm sạch combobox
                    txb1.Visible = true;
                    lb1.Visible = true;
                    txb2.Visible = true;
                    lb2.Visible = true;
                    cbTrueAns.Items.Add("Đáp án 1");//Thêm giá trị ứng với số đáp án
                    cbTrueAns.Items.Add("Đáp án 2");
                }
                if (NumofAns == 3)
                {
                    txb4.Text = null;
                    cbTrueAns.Items.Clear();
                    txb1.Visible = true;
                    lb1.Visible = true;
                    txb2.Visible = true;
                    lb2.Visible = true;
                    txb3.Visible = true;
                    lb3.Visible = true;
                    cbTrueAns.Items.Add("Đáp án 1");
                    cbTrueAns.Items.Add("Đáp án 2");
                    cbTrueAns.Items.Add("Đáp án 3");
                }
                if (NumofAns == 4)
                {
                    cbTrueAns.Items.Clear();
                    txb1.Visible = true;
                    lb1.Visible = true;
                    txb2.Visible = true;
                    lb2.Visible = true;
                    txb3.Visible = true;
                    lb3.Visible = true;
                    txb4.Visible = true;
                    lb4.Visible = true;
                    cbTrueAns.Items.Add("Đáp án 1");
                    cbTrueAns.Items.Add("Đáp án 2");
                    cbTrueAns.Items.Add("Đáp án 3");
                    cbTrueAns.Items.Add("Đáp án 4");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi rồi anh ơi, xem lại ");
            }
            
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Cập nhật dữ liệu đáp án vào DB
                conn.Open();
                string updateAns = "update DAPAN set DapAn1=N'" + txb1.Text + "',DapAn2=N'" + txb2.Text + "',DapAn3=N'" + txb3.Text + "',DapAn4=N'" + txb4.Text + "',DapAnDung='"+cbTrueAns.SelectedItem.ToString().Trim()+"' WHERE MaCauHoi='" + getidQues.Trim() + "' AND MaMon='" + getidMon.Trim() + "'";

                adapter = new SqlDataAdapter(updateAns, conn);
                adapter.SelectCommand.ExecuteNonQuery();
                conn.Close();
                load_grid();
            }
            catch
            {
                MessageBox.Show("Cập nhật sai gì kìa anh ^^");
            }
            
            
        }
    }
}

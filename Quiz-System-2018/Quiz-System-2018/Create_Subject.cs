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
    public partial class Create_Subject : Form
    {
        string idCourse = "";
        string nameCourse = "";
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataTable dtb;
        public Create_Subject(string IDcourse, string NameCourse)
        {
            InitializeComponent();
            idCourse = IDcourse;
            nameCourse = NameCourse;
        }

        private void bntCreate_Click(object sender, EventArgs e)
        {
            int numOfEA=0;
            int numOfMD=0;
            int numOfDF=0;
            int numOfSubject=0;

            if (txbDF.Text==""||txbEA.Text==""||txbMD.Text==""||txbNumOfSubj.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
            else
            {
                //Biến lưu lại số lượng câu hỏi theo cấp độ khó
                numOfEA = Convert.ToInt16(txbEA.Text);
                numOfMD = Convert.ToInt16(txbMD.Text);
                numOfDF = Convert.ToInt16(txbDF.Text);
                //Biến lưu lại số bộ đề
                numOfSubject = Convert.ToInt16(txbNumOfSubj.Text);
            }
            try
            {
                for(int i=0;i< numOfSubject; i++)
                {
                    string idsub = Create_Id_Subject();
                    Create_Random_Questions("EA","502041",idsub,numOfEA);//Tạo đề thi vói số lượng câu hỏi dễ
                    Create_Random_Questions("MD", "502041",idsub, numOfMD);//Tạo đề thi vói số lượng câu hỏi Trung bính
                    Create_Random_Questions("DF", "502041",idsub, numOfDF);//Tạo đề thi vói số lượng câu hỏi Khó   
                }
                MessageBox.Show("Đã tạo thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Lỗi nữa rồi");
            }
        }
        //Tạo mã đề thi ngẫu nhiên
        private string Create_Id_Subject()
        {
            const String Letters= "abcdefghijklmnopqrstuvwsyz";
            char[] Alphanumeric = (Letters + Letters.ToUpper()).ToCharArray();
            try
            {
                StringBuilder result = new StringBuilder();
                Random rn = new Random();
                for(int i = 0; i < 6; i++)
                {
                    result.Append(Alphanumeric[rn.Next(Alphanumeric.Length)]);                  
                }
                return result.ToString();
            }
            catch
            {
                MessageBox.Show("Không tạo được mã đề thi");
            }
            return "";
        }
        //Lấy ngẫu nhiên câu hỏi theo số lượng và độ khó
        private void Create_Random_Questions(string levelQues,string IDcourse,string IDsubject ,int num)
        {
            try
            {
                conn.Open();
                string getQues = "SELECT CauHoi,DapAn1,DapAn2,DapAn3,DapAn4,DapAnDung,CAUHOI.MaCauHoi FROM CAUHOI,DAPAN WHERE CAUHOI.MaCauHoi=DAPAN.MaCauHoi AND CAUHOI.MaMon=DAPAN.MaMon AND CAUHOI.MaCauHoi like '" + levelQues + "%" + "'AND CAUHOI.MaMon= '" + IDcourse + "'";
                adapter = new SqlDataAdapter(getQues, conn);
                adapter.SelectCommand.ExecuteNonQuery();
                dtb = new DataTable();
                adapter.Fill(dtb);
                conn.Close();
                //Lấy câu hỏi RANdom đưa vào dữ liệu
                Random rn = new Random();
                for (int i=0; i < num; i++)
                {
                    conn.Open();
                    int getIdQues = rn.Next(num);
                    string str = "INSERT INTO DETHI VALUES ('" + IDsubject + "','"+IDcourse+"','"+dtb.Rows[getIdQues][0]+"','"+dtb.Rows[getIdQues][1]+"','"+dtb.Rows[getIdQues][2]+"','"+ dtb.Rows[getIdQues][3] + "','"+ dtb.Rows[getIdQues][4] + "','"+ dtb.Rows[getIdQues][5] + "','"+ dtb.Rows[getIdQues][6] + "')";
                    adapter = new SqlDataAdapter(str,conn);
                    adapter.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show("Không tạo được câu hỏi");
            }
           
        }


        private void Create_Subject_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trung\Desktop\Quiz-System-2018\Quiz-System-2018\Quiz-System-2018\Quiz_System_DB.mdf;Integrated Security=True;Connect Timeout=30");
            txbIdCourse.Text = idCourse;
            txbNameCourse.Text = nameCourse;
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

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
        string checkUser;//biến nhận Username từ LOGIN_FORM
        string checkPass;//biến nhận PASS từ LOGIN_FORM
        string Question="";
        public Quiz_config_teacher(string value, string values)
        {
            InitializeComponent();
            checkUser = value;
            checkPass = values;
        }
        public string passingQues
        {
            get { return Question; }
            set { Question=value; }
        }

        //Mở kết nỗi database
        private SqlConnection conn;
        private SqlDataAdapter adapter;

        private void load_cbNameCourse()
        {
            cbNameCourse.Items.Clear();
            conn.Open();
            string strMon = "SELECT TENMON FROM MON Where UserName = '" + checkUser + "'";
            SqlDataReader reader = new SqlCommand(strMon, conn).ExecuteReader();
            while (reader.Read())
            {
                cbNameCourse.Items.Add(reader.GetValue(0).ToString());
            }
            cbNameCourse.Items.Add("Other...");
            reader.Close();
            conn.Close();
        }

        //Form dành cho giảng viên, load đầu tiên khi giảng viên đăng nhập thành công
        private void Quiz_config_teacher_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trung\Desktop\Quiz-System-2018\Quiz-System-2018\Quiz-System-2018\Quiz_System_DB.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                //Load TENMON từ db vào combobox
                load_cbNameCourse();
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
                    //Load form thêm MÔN giảng dạy cho giảng viên \
                    newMon addMon = new newMon(checkUser,checkPass);
                    this.Hide();
                    addMon.ShowDialog();
                    this.Show();
                    load_cbNameCourse();
                }
                else
                {
                    cbLevelQue.Enabled = true;
                    DataTable dbtGV = new DataTable();
                    //Lấy mã môn học từ dữ liệu
                    conn.Open();
                    string ID = "SELECT * FROM MON WHERE TenMon = N'" + cbNameCourse.SelectedItem.ToString() + "' and  UserName='" + checkUser + "'";
                    adapter = new SqlDataAdapter(ID, conn);
                    adapter.SelectCommand.ExecuteNonQuery();
                    adapter.Fill(dbtGV);
                    txbIDCourse.Text = dbtGV.Rows[0][0].ToString();

                    //Lấy câu hỏi của môn học đưa lên gridview

                    DataTable dtb = new DataTable();
                    string loadgrid = "SELECT MaCauHoi as N'Mã câu hỏi', MaMon as N'Mã môn', CauHoi as N'Câu hỏi', SoDapAn as N'Số đáp án' from CAUHOI WHERE MaMon='"+dbtGV.Rows[0][0].ToString()+"'";
                    adapter = new SqlDataAdapter(loadgrid,conn);
                    adapter.SelectCommand.ExecuteNonQuery();
                    adapter.Fill(dtb);
                    griListQue.DataSource = dtb;
                    conn.Close();
                }
                
            }
            catch
            {
                MessageBox.Show("Lỗi rồi kìa anh ơi");
            }
        }
        //Biến để lưu ID câu hỏi mới và chuyển vào db
        string newIdQues = "";
        string saveId = "";
        //Tạo ID tự động tăng
        private void create_NewIdQuestion(string Str)
        {
            int count = 0;//Biến đếm số lượng câu hỏi, theo loại câu hỏi
            conn.Open();
            DataTable eaTbd = new DataTable();
            string eaQues = "SELECT COUNT (*) FROM CAUHOI WHERE Loai = '"+saveId+"'";
            adapter = new SqlDataAdapter(eaQues, conn);
            adapter.Fill(eaTbd);
            count = Convert.ToInt16(eaTbd.Rows[0][0].ToString());
            count++;
            if (count > 0 && count < 10)
            {
                txbIdQues.Text = Str + "000" + count;
                newIdQues = Str + "000" + count;
            }
            else if (count > 9 && count < 100)
            {
                txbIdQues.Text = Str + "00" + count;
                newIdQues = Str + "00" + count;
            }
            else if (count > 99 && count < 1000)
            {
                txbIdQues.Text = Str + "0" + count;
                newIdQues = Str + "0" + count;
            }
            else
            {
                txbIdQues.Text = Str + count;
                newIdQues = Str + count;
            }
            conn.Close();
        }
        private void cbLevelQue_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbAskQues.Enabled = true;// Cho phép người dùng nhập câu hỏi
            try //chọn độ khó cho câu hỏi
            {   
                if (cbLevelQue.SelectedItem.ToString().Equals("Dễ"))
                {
                    saveId = "Dê";
                    create_NewIdQuestion("EA");
                    
                }
                else if(cbLevelQue.SelectedItem.ToString().Equals("Trung bình"))
                {
                    saveId = "Trung bình";
                    create_NewIdQuestion("MD");
                }
                else
                {
                    saveId = "Khó";
                    create_NewIdQuestion("DF");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi gì rồi anh ơi","Thông báo");
            }
        }

        private void bntEdit_Click(object sender, EventArgs e)
        {
            Question = txbAskQues.Text;
            int number = Convert.ToInt16(cbNumOfAns.Text);
            Answer newAns = new Answer(Question,number);
        }
    }
}

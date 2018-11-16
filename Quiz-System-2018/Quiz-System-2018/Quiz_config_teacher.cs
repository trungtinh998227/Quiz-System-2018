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
        string IDQuestion="";
        public Quiz_config_teacher(string value, string values)
        {
            InitializeComponent();
            checkUser = value;
            checkPass = values;
        }
        public string passingQues
        {
            get { return IDQuestion; }
            set { IDQuestion=value; }
        }

        //Mở kết nỗi database
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataTable dbtGV;


        //đổ dữ liệu vào combobox
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

        private void load_grid()// Load dữ liệu CauHoi lên Griview
        {
            try
            {
                conn.Open();
                DataTable dtb = new DataTable();
                string loadgrid = "SELECT MaCauHoi as N'Mã câu hỏi', MaMon as N'Mã môn', CauHoi as N'Câu hỏi', SoDapAn as N'Số đáp án' from CAUHOI WHERE MaMon='" + txbIDCourse.Text + "'";
                adapter = new SqlDataAdapter(loadgrid, conn);
                adapter.SelectCommand.ExecuteNonQuery();
                adapter.Fill(dtb);
                griListQue.DataSource = dtb;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối rồi kìa anh");
            }
            
        }

        //Form dành cho giảng viên, load đầu tiên khi giảng viên đăng nhập thành công
        private void Quiz_config_teacher_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trung\Desktop\Quiz-System-2018\Quiz-System-2018\Quiz-System-2018\Quiz_System_DB.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                //Load TENMON từ db vào combobox
                load_cbNameCourse();
                bntClick.Enabled = true;
            }
            catch
            {
                MessageBox.Show("ComboBox Load Error", "Thông báo!");
            }
        }

        private void cbNameCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbIdQues.Text = "";
            cbLevelQue.Text = "";
            txbAskQues.Text = "";
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
                    dbtGV = new DataTable();
                    //Lấy mã môn học từ dữ liệu
                    conn.Open();
                    string ID = "SELECT * FROM MON WHERE TenMon = N'" + cbNameCourse.SelectedItem.ToString() + "' and  UserName='" + checkUser + "'";
                    adapter = new SqlDataAdapter(ID, conn);
                    adapter.SelectCommand.ExecuteNonQuery();
                    adapter.Fill(dbtGV);
                    txbIDCourse.Text = dbtGV.Rows[0][0].ToString();
                    conn.Close();
                    //Lấy câu hỏi của môn học đưa lên gridview
                    load_grid();
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
            string eaQues = "SELECT COUNT (*) FROM CAUHOI WHERE Loai = '"+saveId+"'And MaMon='"+txbIDCourse.Text+"'";
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
            try
            {
                IDQuestion = txbIdQues.Text;
                int number = Convert.ToInt16(cbNumOfAns.Text);
                conn.Open();
                //thêm ID câu hỏi vào DB đáp án

                string addIdQues = "INSERT into DAPAN (MaCauHoi,MaMon) VALUES ('" + IDQuestion + "','"+txbIDCourse.Text+"') ";
                //MessageBox.Show("Chạy rồi");
                adapter = new SqlDataAdapter(addIdQues, conn);
                adapter.SelectCommand.ExecuteNonQuery();

                //thêm dữ liệu nhập vào DB CAUHOI
                string check_style_level = cbLevelQue.SelectedItem.ToString();
                string addQues = "";
                if (check_style_level.Equals("Dễ"))
                {
                    addQues = "INSERT into CAUHOI VALUES ('" + IDQuestion + "','" + txbIDCourse.Text + "',N'" + txbAskQues.Text + "','" + cbNumOfAns.Text + "',N'Dê')";
                }
                else
                {
                    addQues = "INSERT into CAUHOI VALUES ('" + IDQuestion + "','" + txbIDCourse.Text + "',N'" + txbAskQues.Text + "','" + cbNumOfAns.Text + "',N'" + check_style_level + "')";
                }
                    //MessageBox.Show(addQues);
                    adapter = new SqlDataAdapter(addQues, conn);
                    adapter.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    load_grid();
                    //MessageBox.Show("chạy");
                    bntClick.Enabled = false;
                    //MessageBox.Show("chạy");
                    Answer newAns = new Answer(IDQuestion, number,txbIDCourse.Text);
                    this.Hide();
                    newAns.ShowDialog();
                    this.Show();
            }
            catch
            {
                MessageBox.Show("Lỗi nữa kìa anh");
            }   
        }

        private void griListQue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            txbIdQues.Text = "";
            cbLevelQue.Text = "";
            txbAskQues.Text = "";
            bntClick.Enabled = true;
            cbNumOfAns.Text = "";
        }
    }
}

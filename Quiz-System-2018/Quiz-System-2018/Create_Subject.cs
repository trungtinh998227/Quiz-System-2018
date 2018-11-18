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
        public Create_Subject(string IDcourse, string NameCourse)
        {
            InitializeComponent();
            idCourse = IDcourse;
            nameCourse = NameCourse;
        }

        private void bntCreate_Click(object sender, EventArgs e)
        {
            //Biến lưu lại số lượng câu hỏi theo cấp độ khó
            int numOfEA = Convert.ToInt16(txbEA.Text);
            int numOfMD = Convert.ToInt16(txbMD.Text);
            int numOfDF = Convert.ToInt16(txbDF.Text);
            //Biến lưu lại số bộ đề
            int numOfSubject = Convert.ToInt16(txbNumOfSubj.Text);
            try
            {
                

                
                



            }
            catch
            {
                MessageBox.Show("Lỗi nữa rồi");
            }
        }

        private void Create_Subject_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trung\Desktop\Quiz-System-2018\Quiz-System-2018\Quiz-System-2018\Quiz_System_DB.mdf;Integrated Security=True;Connect Timeout=30");
            txbIdCourse.Text = idCourse;
            txbNameCourse.Text = nameCourse;
        }
    }
}

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
    public partial class newMon : Form
    {
        string checkPass;
        string getUSER;
        SqlDataAdapter adapter;
        public newMon(string user ,string value)
        {
            getUSER = user;
            checkPass = value;
            InitializeComponent();
        }
        SqlConnection conn;
        DataTable dtID ;

        private void bntOK_Click(object sender, EventArgs e)
        {
            try
            {
                if(txbName.Text=="" && txbID.Text == "" && txbPass.Text=="")
                {
                    MessageBox.Show("Vui lòng điền thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txbID.Text == "" )
                {
                    MessageBox.Show("Vui lòng điền mã môn !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(txbName.Text == "")
                {
                    MessageBox.Show("Vui lòng điền tên môn !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txbPass.Text=="") {
                    MessageBox.Show("Vui lòng nhập mật khẩu !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (checkPass.Equals(txbPass.Text))
                    {
                        MessageBox.Show("đúng pas");
                        conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trung\Desktop\Quiz-System-2018\Quiz-System-2018\Quiz-System-2018\Quiz_System_DB.mdf;Integrated Security=True;Connect Timeout=30");
                        conn.Open();
                        //Kiểm tra môn đã có trong DB hay chưa
                        string checkID = "SELECT MaMon FROM MON WHERE UserName = '"+getUSER+"'";
                        Boolean ck_ID = false;
                        SqlCommand command = new SqlCommand(checkID, conn);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            if (reader.GetValue(0).ToString().Equals(txbID.Text))
                            {
                                ck_ID = true;
                                MessageBox.Show("Môn học đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                            else continue;
                        }
                        reader.Close();
                        if (!ck_ID)
                        {
                            //Thêm môn mới vào dữ liệu
                            string addMON = "INSERT INTO MON VALUES ('" + txbID.Text + "',N'" + txbName.Text + "','" + getUSER + "')";
                            adapter = new SqlDataAdapter(addMON, conn);
                            adapter.SelectCommand.ExecuteNonQuery();
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập lại mật khẩu !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Anh ơi lỗi gì đó rồi kìa","Thông báo!");
            }
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
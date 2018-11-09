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
    public partial class Admin : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private SqlCommandBuilder builder;
        private DataTable dataTable;
        public Admin()
        {
            InitializeComponent();
            dataTable = new DataTable();
        }
        void loadGrid()
        {
            //Xóa dữ liệu trong GridView thông qua dataTable
            dataTable.Clear();
            try
            {
                adapter = new SqlDataAdapter("select LOGIN.UserName, Password, Name, Khoa, Loai from LOGIN, DANHSACH where DANHSACH.UserName=LOGIN.UserName", conn);
                //Lấy dữ liệu từ database chứa vào trong table
                adapter.Fill(dataTable);
                //Đưa dữ liệu từ table lên gridview
                Gridview1.DataSource = dataTable;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OKCancel);
            }
            
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            cbStyle.Text = "Giảng Viên";
            bntDelete.Enabled = true;
            bntEdit.Enabled = true;
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trung\Desktop\Quiz-System-2018\Quiz-System-2018\Quiz-System-2018\Quiz_System_DB.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            loadGrid();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int indexRow;
        private void Gridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = Gridview1.Rows[indexRow];
            txbUsername.Text = row.Cells[0].Value.ToString();
            // Không cho phép chỉnh sửa Style của admin
            if (txbUsername.Text == "Admin")
            {
                cbStyle.Enabled = false;
            }
            else cbStyle.Enabled = true;

            txbName.Text = row.Cells[2].Value.ToString();
            cbStyle.Text = row.Cells[4].Value.ToString();
            txbKhoa.Text = row.Cells[3].Value.ToString();
            
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void bntFormat_Click(object sender, EventArgs e)
        {
            txbUsername.Text = "";
            txbName.Text = "";
            txbKhoa.Text = "";
        }

        private void bntEdit_Click(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();
                string compareID = txbUsername.Text;
                //where (select UserName from DANH SACH)
                string newData = "update DANHSACH set Name='N"+txbName.Text+ "',Khoa=N'" + txbKhoa.Text + "',Loai=N'" + cbStyle.Text + "'where DANHSACH.UserName='"+compareID+"'";
                adapter = new SqlDataAdapter(newData,conn);
                adapter.SelectCommand.ExecuteNonQuery();
                DataGridViewRow newRowData = Gridview1.Rows[indexRow];
                //Tên
                newRowData.Cells[2].Value = txbName.Text;
                //Loai
                newRowData.Cells[4].Value = cbStyle.Text;
                //Khoa
                newRowData.Cells[3].Value = txbKhoa.Text;
                conn.Close();
                MessageBox.Show("Cập nhật thông tin thành công","Thông báo!",MessageBoxButtons.OKCancel);
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string cmdDelete = "delete from LOGIN where UserName='"+txbUsername.Text+"'";
                adapter = new SqlDataAdapter(cmdDelete,conn);
                adapter.SelectCommand.ExecuteNonQuery();
                //Gridview1 = new DataGridView();
                loadGrid();
            }
            catch
            {
                MessageBox.Show("Lỗi","Thông báo");
            }
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {

        }

        private void cbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
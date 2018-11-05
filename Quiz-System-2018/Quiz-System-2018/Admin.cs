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

        private void Admin_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trung\Desktop\Quiz-System-2018\Quiz-System-2018\Quiz-System-2018\Quiz_System_DB.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            adapter = new SqlDataAdapter("select * from LOGIN", conn);
            builder = new SqlCommandBuilder(adapter);
            //Lấy dữ liệu từ database chứa vào trong table
            adapter.Fill(dataTable);
            //Đưa dữ liệu từ table lên gridview
            Gridview1.DataSource = dataTable;
            conn.Close();
        }
    }
}
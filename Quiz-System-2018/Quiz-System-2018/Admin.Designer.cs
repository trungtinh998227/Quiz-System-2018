namespace Quiz_System_2018
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bntFormat = new System.Windows.Forms.Button();
            this.bntEdit = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbKhoa = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Log_out = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Gridview1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Controls.Add(this.cbStyle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.bntFormat);
            this.groupBox1.Controls.Add(this.bntEdit);
            this.groupBox1.Controls.Add(this.bntDelete);
            this.groupBox1.Controls.Add(this.bntAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbName);
            this.groupBox1.Controls.Add(this.txbKhoa);
            this.groupBox1.Controls.Add(this.txbUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(279, 277);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm dữ liệu:";
            // 
            // cbStyle
            // 
            this.cbStyle.BackColor = System.Drawing.SystemColors.Control;
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Items.AddRange(new object[] {
            "Giảng viên",
            "Sinh viên"});
            this.cbStyle.Location = new System.Drawing.Point(84, 60);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(181, 23);
            this.cbStyle.TabIndex = 10;
            this.cbStyle.SelectedIndexChanged += new System.EventHandler(this.cbStyle_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Loại    :";
            // 
            // bntFormat
            // 
            this.bntFormat.Location = new System.Drawing.Point(154, 221);
            this.bntFormat.Name = "bntFormat";
            this.bntFormat.Size = new System.Drawing.Size(75, 22);
            this.bntFormat.TabIndex = 8;
            this.bntFormat.Text = "Định dạng";
            this.bntFormat.UseVisualStyleBackColor = true;
            this.bntFormat.Click += new System.EventHandler(this.bntFormat_Click);
            // 
            // bntEdit
            // 
            this.bntEdit.Enabled = false;
            this.bntEdit.Location = new System.Drawing.Point(47, 221);
            this.bntEdit.Name = "bntEdit";
            this.bntEdit.Size = new System.Drawing.Size(75, 22);
            this.bntEdit.TabIndex = 7;
            this.bntEdit.Text = "Cập nhật";
            this.bntEdit.UseVisualStyleBackColor = true;
            this.bntEdit.Click += new System.EventHandler(this.bntEdit_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Enabled = false;
            this.bntDelete.Location = new System.Drawing.Point(154, 185);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 22);
            this.bntDelete.TabIndex = 6;
            this.bntDelete.Text = "Xóa";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // bntAdd
            // 
            this.bntAdd.Enabled = false;
            this.bntAdd.Location = new System.Drawing.Point(47, 185);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 22);
            this.bntAdd.TabIndex = 5;
            this.bntAdd.Text = "Thêm";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khoa  :";
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.Color.White;
            this.txbName.Location = new System.Drawing.Point(84, 94);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(181, 21);
            this.txbName.TabIndex = 3;
            // 
            // txbKhoa
            // 
            this.txbKhoa.Location = new System.Drawing.Point(84, 129);
            this.txbKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbKhoa.Name = "txbKhoa";
            this.txbKhoa.Size = new System.Drawing.Size(181, 21);
            this.txbKhoa.TabIndex = 3;
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUsername.Enabled = false;
            this.txbUsername.Location = new System.Drawing.Point(84, 28);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(181, 21);
            this.txbUsername.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Log_out});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1138, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "Đăng xuất";
            // 
            // Log_out
            // 
            this.Log_out.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Log_out.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.Log_out.Name = "Log_out";
            this.Log_out.Size = new System.Drawing.Size(112, 20);
            this.Log_out.Text = "Quản lý tài khoản";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // Gridview1
            // 
            this.Gridview1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.Gridview1.AllowUserToAddRows = false;
            this.Gridview1.AllowUserToDeleteRows = false;
            this.Gridview1.AllowUserToResizeColumns = false;
            this.Gridview1.AllowUserToResizeRows = false;
            this.Gridview1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gridview1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Gridview1.BackgroundColor = System.Drawing.Color.Aqua;
            this.Gridview1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gridview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Gridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridview1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.Gridview1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Gridview1.Location = new System.Drawing.Point(299, 27);
            this.Gridview1.Name = "Gridview1";
            this.Gridview1.RowHeadersVisible = false;
            this.Gridview1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Gridview1.Size = new System.Drawing.Size(820, 278);
            this.Gridview1.TabIndex = 3;
            this.Gridview1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridview1_CellClick);
            this.Gridview1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridview1_CellClick);
            this.Gridview1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridview1_CellClick);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 317);
            this.Controls.Add(this.Gridview1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản trị viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntFormat;
        private System.Windows.Forms.Button bntEdit;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbKhoa;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Log_out;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.DataGridView Gridview1;
    }
}
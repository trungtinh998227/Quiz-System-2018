namespace Quiz_System_2018
{
    partial class Quiz_config_teacher
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIDCourse = new System.Windows.Forms.TextBox();
            this.cbNameCourse = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.griListQue = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbLevelQue = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbNumOfAns = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bntEdit = new System.Windows.Forms.Button();
            this.bntClick = new System.Windows.Forms.Button();
            this.bntDel = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.txbAskQues = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbIdQues = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quiz_System_DBDataSet = new Quiz_System_2018.Quiz_System_DBDataSet();
            this.quizSystemDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizSystemDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quizSystemDBDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoĐềThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemBộĐềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Subject = new System.Windows.Forms.ToolStripMenuItem();
            this.UserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griListQue)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_System_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizSystemDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizSystemDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizSystemDBDataSetBindingSource2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Môn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Môn:";
            // 
            // txbIDCourse
            // 
            this.txbIDCourse.Enabled = false;
            this.txbIDCourse.Location = new System.Drawing.Point(87, 24);
            this.txbIDCourse.Name = "txbIDCourse";
            this.txbIDCourse.ReadOnly = true;
            this.txbIDCourse.Size = new System.Drawing.Size(155, 20);
            this.txbIDCourse.TabIndex = 2;
            // 
            // cbNameCourse
            // 
            this.cbNameCourse.FormattingEnabled = true;
            this.cbNameCourse.Items.AddRange(new object[] {
            "Other..."});
            this.cbNameCourse.Location = new System.Drawing.Point(86, 56);
            this.cbNameCourse.Name = "cbNameCourse";
            this.cbNameCourse.Size = new System.Drawing.Size(156, 21);
            this.cbNameCourse.TabIndex = 3;
            this.cbNameCourse.SelectedIndexChanged += new System.EventHandler(this.cbNameCourse_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.txbIDCourse);
            this.groupBox1.Controls.Add(this.cbNameCourse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(16, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 97);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin môn thi";
            // 
            // griListQue
            // 
            this.griListQue.AllowUserToAddRows = false;
            this.griListQue.AllowUserToDeleteRows = false;
            this.griListQue.AllowUserToResizeColumns = false;
            this.griListQue.AllowUserToResizeRows = false;
            this.griListQue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.griListQue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.griListQue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.griListQue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griListQue.Location = new System.Drawing.Point(391, 25);
            this.griListQue.Name = "griListQue";
            this.griListQue.RowHeadersVisible = false;
            this.griListQue.Size = new System.Drawing.Size(397, 406);
            this.griListQue.TabIndex = 5;
            this.griListQue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.griListQue_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Linen;
            this.groupBox2.Controls.Add(this.cbLevelQue);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbNumOfAns);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.bntEdit);
            this.groupBox2.Controls.Add(this.bntClick);
            this.groupBox2.Controls.Add(this.bntDel);
            this.groupBox2.Controls.Add(this.bntAdd);
            this.groupBox2.Controls.Add(this.txbAskQues);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txbIdQues);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 295);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm câu hỏi";
            // 
            // cbLevelQue
            // 
            this.cbLevelQue.Enabled = false;
            this.cbLevelQue.FormattingEnabled = true;
            this.cbLevelQue.Items.AddRange(new object[] {
            "Dễ",
            "Trung bình",
            "Khó"});
            this.cbLevelQue.Location = new System.Drawing.Point(260, 32);
            this.cbLevelQue.Name = "cbLevelQue";
            this.cbLevelQue.Size = new System.Drawing.Size(103, 21);
            this.cbLevelQue.TabIndex = 11;
            this.cbLevelQue.SelectedIndexChanged += new System.EventHandler(this.cbLevelQue_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Độ khó:";
            // 
            // cbNumOfAns
            // 
            this.cbNumOfAns.FormattingEnabled = true;
            this.cbNumOfAns.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.cbNumOfAns.Location = new System.Drawing.Point(102, 190);
            this.cbNumOfAns.Name = "cbNumOfAns";
            this.cbNumOfAns.Size = new System.Drawing.Size(92, 21);
            this.cbNumOfAns.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số câu trả lời:";
            // 
            // bntEdit
            // 
            this.bntEdit.Enabled = false;
            this.bntEdit.Location = new System.Drawing.Point(260, 248);
            this.bntEdit.Name = "bntEdit";
            this.bntEdit.Size = new System.Drawing.Size(75, 23);
            this.bntEdit.TabIndex = 5;
            this.bntEdit.Text = "Sửa";
            this.bntEdit.UseVisualStyleBackColor = true;
            this.bntEdit.Click += new System.EventHandler(this.bntEdit_Click_1);
            // 
            // bntClick
            // 
            this.bntClick.Enabled = false;
            this.bntClick.Location = new System.Drawing.Point(209, 190);
            this.bntClick.Name = "bntClick";
            this.bntClick.Size = new System.Drawing.Size(75, 23);
            this.bntClick.TabIndex = 2;
            this.bntClick.Text = "Chọn";
            this.bntClick.UseVisualStyleBackColor = true;
            this.bntClick.Click += new System.EventHandler(this.bntEdit_Click);
            // 
            // bntDel
            // 
            this.bntDel.Enabled = false;
            this.bntDel.Location = new System.Drawing.Point(149, 248);
            this.bntDel.Name = "bntDel";
            this.bntDel.Size = new System.Drawing.Size(75, 23);
            this.bntDel.TabIndex = 4;
            this.bntDel.Text = "Xóa";
            this.bntDel.UseVisualStyleBackColor = true;
            this.bntDel.Click += new System.EventHandler(this.bntDel_Click);
            // 
            // bntAdd
            // 
            this.bntAdd.Enabled = false;
            this.bntAdd.Location = new System.Drawing.Point(36, 248);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 3;
            this.bntAdd.Text = "Thêm";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // txbAskQues
            // 
            this.txbAskQues.Enabled = false;
            this.txbAskQues.Location = new System.Drawing.Point(101, 77);
            this.txbAskQues.Multiline = true;
            this.txbAskQues.Name = "txbAskQues";
            this.txbAskQues.Size = new System.Drawing.Size(262, 86);
            this.txbAskQues.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Câu hỏi:";
            // 
            // txbIdQues
            // 
            this.txbIdQues.Location = new System.Drawing.Point(101, 33);
            this.txbIdQues.Name = "txbIdQues";
            this.txbIdQues.ReadOnly = true;
            this.txbIdQues.Size = new System.Drawing.Size(88, 20);
            this.txbIdQues.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã câu hỏi:";
            // 
            // quiz_System_DBDataSet
            // 
            this.quiz_System_DBDataSet.DataSetName = "Quiz_System_DBDataSet";
            this.quiz_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quizSystemDBDataSetBindingSource
            // 
            this.quizSystemDBDataSetBindingSource.AllowNew = true;
            this.quizSystemDBDataSetBindingSource.DataSource = this.quiz_System_DBDataSet;
            this.quizSystemDBDataSetBindingSource.Position = 0;
            // 
            // quizSystemDBDataSetBindingSource1
            // 
            this.quizSystemDBDataSetBindingSource1.DataSource = this.quiz_System_DBDataSet;
            this.quizSystemDBDataSetBindingSource1.Position = 0;
            // 
            // quizSystemDBDataSetBindingSource2
            // 
            this.quizSystemDBDataSetBindingSource2.DataSource = this.quiz_System_DBDataSet;
            this.quizSystemDBDataSetBindingSource2.Position = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.UserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoĐềThiToolStripMenuItem,
            this.xemBộĐềToolStripMenuItem,
            this.Menu_Subject});
            this.quảnLýToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý đề";
            // 
            // tạoĐềThiToolStripMenuItem
            // 
            this.tạoĐềThiToolStripMenuItem.Name = "tạoĐềThiToolStripMenuItem";
            this.tạoĐềThiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tạoĐềThiToolStripMenuItem.Text = "Tạo đề thi";
            this.tạoĐềThiToolStripMenuItem.Click += new System.EventHandler(this.tạoĐềThiToolStripMenuItem_Click);
            // 
            // xemBộĐềToolStripMenuItem
            // 
            this.xemBộĐềToolStripMenuItem.Name = "xemBộĐềToolStripMenuItem";
            this.xemBộĐềToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xemBộĐềToolStripMenuItem.Text = "Xem bộ đề";
            this.xemBộĐềToolStripMenuItem.Click += new System.EventHandler(this.xemBộĐềToolStripMenuItem_Click);
            // 
            // Menu_Subject
            // 
            this.Menu_Subject.Name = "Menu_Subject";
            this.Menu_Subject.Size = new System.Drawing.Size(180, 22);
            this.Menu_Subject.Text = "Xóa bộ đề";
            this.Menu_Subject.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_Subject_DropDownItemClicked);
            // 
            // UserToolStripMenuItem
            // 
            this.UserToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.UserToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserToolStripMenuItem.Name = "UserToolStripMenuItem";
            this.UserToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.UserToolStripMenuItem.Text = "Tài khoản";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // Quiz_config_teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.griListQue);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Quiz_config_teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giảng viên";
            this.Load += new System.EventHandler(this.Quiz_config_teacher_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griListQue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_System_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizSystemDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizSystemDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizSystemDBDataSetBindingSource2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbIDCourse;
        private System.Windows.Forms.ComboBox cbNameCourse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView griListQue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbAskQues;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbIdQues;
        private System.Windows.Forms.ComboBox cbNumOfAns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntEdit;
        private System.Windows.Forms.Button bntClick;
        private System.Windows.Forms.Button bntDel;
        private System.Windows.Forms.Button bntAdd;
        private Quiz_System_DBDataSet quiz_System_DBDataSet;
        private System.Windows.Forms.BindingSource quizSystemDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource quizSystemDBDataSetBindingSource1;
        private System.Windows.Forms.BindingSource quizSystemDBDataSetBindingSource2;
        private System.Windows.Forms.ComboBox cbLevelQue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoĐềThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemBộĐềToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Subject;
    }
}
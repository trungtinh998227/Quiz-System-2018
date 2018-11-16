namespace Quiz_System_2018
{
    partial class Answer
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
            this.gridAnswer = new System.Windows.Forms.DataGridView();
            this.txbQues = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTrueAns = new System.Windows.Forms.ComboBox();
            this.txb4 = new System.Windows.Forms.TextBox();
            this.txb3 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntExit = new System.Windows.Forms.Button();
            this.bntUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnswer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridAnswer
            // 
            this.gridAnswer.AllowUserToAddRows = false;
            this.gridAnswer.AllowUserToDeleteRows = false;
            this.gridAnswer.AllowUserToResizeColumns = false;
            this.gridAnswer.AllowUserToResizeRows = false;
            this.gridAnswer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAnswer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.gridAnswer.BackgroundColor = System.Drawing.Color.Azure;
            this.gridAnswer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAnswer.Location = new System.Drawing.Point(254, 31);
            this.gridAnswer.Name = "gridAnswer";
            this.gridAnswer.RowHeadersVisible = false;
            this.gridAnswer.Size = new System.Drawing.Size(574, 133);
            this.gridAnswer.TabIndex = 2;
            // 
            // txbQues
            // 
            this.txbQues.BackColor = System.Drawing.Color.Azure;
            this.txbQues.Enabled = false;
            this.txbQues.Location = new System.Drawing.Point(12, 31);
            this.txbQues.Multiline = true;
            this.txbQues.Name = "txbQues";
            this.txbQues.Size = new System.Drawing.Size(230, 133);
            this.txbQues.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bntExit);
            this.groupBox1.Controls.Add(this.bntUpdate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbQues);
            this.groupBox1.Controls.Add(this.gridAnswer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 377);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbTrueAns);
            this.groupBox2.Controls.Add(this.txb4);
            this.groupBox2.Controls.Add(this.txb3);
            this.groupBox2.Controls.Add(this.txb2);
            this.groupBox2.Controls.Add(this.txb1);
            this.groupBox2.Controls.Add(this.lb2);
            this.groupBox2.Controls.Add(this.lb3);
            this.groupBox2.Controls.Add(this.lb1);
            this.groupBox2.Controls.Add(this.lb4);
            this.groupBox2.Location = new System.Drawing.Point(254, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 195);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkCyan;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(463, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Đáp án đúng:";
            // 
            // cbTrueAns
            // 
            this.cbTrueAns.FormattingEnabled = true;
            this.cbTrueAns.Location = new System.Drawing.Point(466, 81);
            this.cbTrueAns.Name = "cbTrueAns";
            this.cbTrueAns.Size = new System.Drawing.Size(96, 21);
            this.cbTrueAns.TabIndex = 5;
            // 
            // txb4
            // 
            this.txb4.Location = new System.Drawing.Point(78, 159);
            this.txb4.Multiline = true;
            this.txb4.Name = "txb4";
            this.txb4.Size = new System.Drawing.Size(365, 24);
            this.txb4.TabIndex = 4;
            this.txb4.Visible = false;
            // 
            // txb3
            // 
            this.txb3.Location = new System.Drawing.Point(78, 110);
            this.txb3.Multiline = true;
            this.txb3.Name = "txb3";
            this.txb3.Size = new System.Drawing.Size(365, 24);
            this.txb3.TabIndex = 3;
            this.txb3.Visible = false;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(78, 63);
            this.txb2.Multiline = true;
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(365, 24);
            this.txb2.TabIndex = 2;
            this.txb2.Visible = false;
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(78, 19);
            this.txb1.Multiline = true;
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(365, 24);
            this.txb1.TabIndex = 1;
            this.txb1.Visible = false;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.Color.DarkCyan;
            this.lb2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.Color.Cornsilk;
            this.lb2.Location = new System.Drawing.Point(15, 70);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(57, 15);
            this.lb2.TabIndex = 8;
            this.lb2.Text = "Đáp án 2:";
            this.lb2.Visible = false;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.BackColor = System.Drawing.Color.DarkCyan;
            this.lb3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.ForeColor = System.Drawing.Color.Cornsilk;
            this.lb3.Location = new System.Drawing.Point(15, 116);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(57, 15);
            this.lb3.TabIndex = 8;
            this.lb3.Text = "Đáp án 3:";
            this.lb3.Visible = false;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.DarkCyan;
            this.lb1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Cornsilk;
            this.lb1.Location = new System.Drawing.Point(15, 25);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(57, 15);
            this.lb1.TabIndex = 8;
            this.lb1.Text = "Đáp án 1:";
            this.lb1.Visible = false;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.BackColor = System.Drawing.Color.DarkCyan;
            this.lb4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.ForeColor = System.Drawing.Color.Cornsilk;
            this.lb4.Location = new System.Drawing.Point(15, 162);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(57, 15);
            this.lb4.TabIndex = 8;
            this.lb4.Text = "Đáp án 4:";
            this.lb4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(250, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đáp án:";
            // 
            // bntExit
            // 
            this.bntExit.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExit.Location = new System.Drawing.Point(138, 253);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(91, 36);
            this.bntExit.TabIndex = 7;
            this.bntExit.Text = "Thoát";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // bntUpdate
            // 
            this.bntUpdate.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntUpdate.Location = new System.Drawing.Point(29, 253);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Size = new System.Drawing.Size(91, 36);
            this.bntUpdate.TabIndex = 6;
            this.bntUpdate.Text = "Cập nhật";
            this.bntUpdate.UseVisualStyleBackColor = true;
            this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Câu hỏi:";
            // 
            // Answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 377);
            this.Controls.Add(this.groupBox1);
            this.Name = "Answer";
            this.Text = "Đáp án";
            this.Load += new System.EventHandler(this.Answer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAnswer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridAnswer;
        private System.Windows.Forms.TextBox txbQues;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.Button bntUpdate;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txb4;
        private System.Windows.Forms.TextBox txb3;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTrueAns;
    }
}
namespace Quiz_System_2018
{
    partial class Subjects
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntExit = new System.Windows.Forms.Button();
            this.dataSubGrid = new System.Windows.Forms.DataGridView();
            this.txbNameCourse = new System.Windows.Forms.TextBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNumOfAns = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSubGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.txbNumOfAns);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bntExit);
            this.groupBox1.Controls.Add(this.dataSubGrid);
            this.groupBox1.Controls.Add(this.txbNameCourse);
            this.groupBox1.Controls.Add(this.cbSubject);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(529, 339);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(75, 30);
            this.bntExit.TabIndex = 4;
            this.bntExit.Text = "Thoát";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // dataSubGrid
            // 
            this.dataSubGrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataSubGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSubGrid.Location = new System.Drawing.Point(9, 60);
            this.dataSubGrid.Name = "dataSubGrid";
            this.dataSubGrid.RowHeadersVisible = false;
            this.dataSubGrid.Size = new System.Drawing.Size(626, 263);
            this.dataSubGrid.TabIndex = 3;
            // 
            // txbNameCourse
            // 
            this.txbNameCourse.Enabled = false;
            this.txbNameCourse.Location = new System.Drawing.Point(52, 21);
            this.txbNameCourse.Name = "txbNameCourse";
            this.txbNameCourse.Size = new System.Drawing.Size(225, 22);
            this.txbNameCourse.TabIndex = 2;
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(390, 21);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(208, 23);
            this.cbSubject.TabIndex = 1;
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Môn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đề:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số câu hỏi:";
            // 
            // txbNumOfAns
            // 
            this.txbNumOfAns.Enabled = false;
            this.txbNumOfAns.Location = new System.Drawing.Point(351, 343);
            this.txbNumOfAns.Name = "txbNumOfAns";
            this.txbNumOfAns.Size = new System.Drawing.Size(100, 22);
            this.txbNumOfAns.TabIndex = 6;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 410);
            this.Controls.Add(this.groupBox1);
            this.Name = "Subjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem đề";
            this.Load += new System.EventHandler(this.Subjects_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSubGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataSubGrid;
        private System.Windows.Forms.TextBox txbNameCourse;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.TextBox txbNumOfAns;
        private System.Windows.Forms.Label label3;
    }
}
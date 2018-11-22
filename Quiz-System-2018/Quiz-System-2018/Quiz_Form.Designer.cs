namespace Quiz_System_2018
{
    partial class Quiz_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbQuestion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.quiz_System_DBDataSet1 = new Quiz_System_2018.Quiz_System_DBDataSet();
            this.bntNext = new System.Windows.Forms.Button();
            this.bntRevious = new System.Windows.Forms.Button();
            this.g = new System.Windows.Forms.GroupBox();
            this.txbTimer = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_System_DBDataSet1)).BeginInit();
            this.g.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txbQuestion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbD);
            this.groupBox1.Controls.Add(this.rdbC);
            this.groupBox1.Controls.Add(this.rdbB);
            this.groupBox1.Controls.Add(this.rdbA);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(231, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thi trắc nghiệm";
            // 
            // txbQuestion
            // 
            this.txbQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbQuestion.BackColor = System.Drawing.Color.White;
            this.txbQuestion.Enabled = false;
            this.txbQuestion.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txbQuestion.Location = new System.Drawing.Point(9, 21);
            this.txbQuestion.Multiline = true;
            this.txbQuestion.Name = "txbQuestion";
            this.txbQuestion.ReadOnly = true;
            this.txbQuestion.Size = new System.Drawing.Size(549, 198);
            this.txbQuestion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "label1";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "label1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "label1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // rdbD
            // 
            this.rdbD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbD.AutoSize = true;
            this.rdbD.Location = new System.Drawing.Point(42, 362);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(34, 19);
            this.rdbD.TabIndex = 4;
            this.rdbD.TabStop = true;
            this.rdbD.Text = "D";
            this.rdbD.UseVisualStyleBackColor = true;
            // 
            // rdbC
            // 
            this.rdbC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbC.AutoSize = true;
            this.rdbC.Location = new System.Drawing.Point(42, 319);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(34, 19);
            this.rdbC.TabIndex = 3;
            this.rdbC.TabStop = true;
            this.rdbC.Text = "C";
            this.rdbC.UseVisualStyleBackColor = true;
            // 
            // rdbB
            // 
            this.rdbB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbB.AutoSize = true;
            this.rdbB.Location = new System.Drawing.Point(42, 278);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(34, 19);
            this.rdbB.TabIndex = 2;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "B";
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // rdbA
            // 
            this.rdbA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbA.AutoSize = true;
            this.rdbA.Location = new System.Drawing.Point(42, 237);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(34, 19);
            this.rdbA.TabIndex = 1;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "A";
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // quiz_System_DBDataSet1
            // 
            this.quiz_System_DBDataSet1.DataSetName = "Quiz_System_DBDataSet";
            this.quiz_System_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bntNext
            // 
            this.bntNext.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNext.Location = new System.Drawing.Point(644, 412);
            this.bntNext.Name = "bntNext";
            this.bntNext.Size = new System.Drawing.Size(75, 23);
            this.bntNext.TabIndex = 1;
            this.bntNext.Text = "Câu tiếp";
            this.bntNext.UseVisualStyleBackColor = true;
            // 
            // bntRevious
            // 
            this.bntRevious.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntRevious.Location = new System.Drawing.Point(472, 412);
            this.bntRevious.Name = "bntRevious";
            this.bntRevious.Size = new System.Drawing.Size(75, 23);
            this.bntRevious.TabIndex = 1;
            this.bntRevious.Text = "Câu trước";
            this.bntRevious.UseVisualStyleBackColor = true;
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.Color.Cornsilk;
            this.g.Controls.Add(this.txbTimer);
            this.g.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.ForeColor = System.Drawing.Color.Blue;
            this.g.Location = new System.Drawing.Point(9, 12);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(215, 79);
            this.g.TabIndex = 6;
            this.g.TabStop = false;
            this.g.Text = "Thời gian làm bài:";
            // 
            // txbTimer
            // 
            this.txbTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTimer.BackColor = System.Drawing.Color.Cornsilk;
            this.txbTimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTimer.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimer.ForeColor = System.Drawing.Color.Red;
            this.txbTimer.Location = new System.Drawing.Point(6, 23);
            this.txbTimer.Name = "txbTimer";
            this.txbTimer.Size = new System.Drawing.Size(203, 43);
            this.txbTimer.TabIndex = 0;
            this.txbTimer.Text = "00:00:00";
            this.txbTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(9, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 300);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Câu hỏi:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 269);
            this.panel1.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // Quiz_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 447);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.g);
            this.Controls.Add(this.bntRevious);
            this.Controls.Add(this.bntNext);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Quiz_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả lời câu hỏi";
            this.Load += new System.EventHandler(this.Quiz_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_System_DBDataSet1)).EndInit();
            this.g.ResumeLayout(false);
            this.g.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbD;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbA;
        private Quiz_System_DBDataSet quiz_System_DBDataSet1;
        private System.Windows.Forms.TextBox txbQuestion;
        private System.Windows.Forms.Button bntNext;
        private System.Windows.Forms.Button bntRevious;
        private System.Windows.Forms.GroupBox g;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer;
    }
}
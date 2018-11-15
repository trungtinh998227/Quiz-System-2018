using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_System_2018
{
    public partial class Answer : Form
    {
        string getQues="";
        int NumofAns = 0;
        public Answer(string ques,int num)
        {
            getQues = ques;
            NumofAns = num;
            InitializeComponent();
        }

    }
}

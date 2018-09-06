using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMaterial
{
    public partial class Student_Answers : UserControl
    {
        public Student_Answers()
        {
            InitializeComponent();
        }



        private void Student_Answers_Load(object sender, EventArgs e)
        {
            this.studentAnswerTableAdapter.Fill(this.studentAnswerGridView.StudentAnswer);
        }
    }
}

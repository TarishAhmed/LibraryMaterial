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
    public partial class QuestionList : UserControl
    {
        public QuestionList()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void QuestionList_Load(object sender, EventArgs e)
        {
            try
            {
                this.questionTableAdapter.Fill(this.libraryDataSet.Question);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.questionTableAdapter.Fill(this.libraryDataSet.Question);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}

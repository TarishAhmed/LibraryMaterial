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
    public partial class Student_List : UserControl
    {
        public Student_List()
        {
            InitializeComponent();
        }



        private void Student_List_Load(object sender, EventArgs e)
        {
            try
            {
                this.studentLoginTableAdapter.Fill(this.libraryDataSet.StudentLogin);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            int currentColumnIndex = dataGridView1.CurrentCell.ColumnIndex;
            int Qn=0;

                Qn = Convert.ToInt32(dataGridView1.CurrentRow.Cells["qnoDataGridViewTextBoxColumn"].Value);

            try
            {

                string dbString = ConfigurationManager.ConnectionStrings["LibraryMaterial.Properties.Settings.LibraryConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(dbString);
                connection = new SqlConnection(dbString);
                connection.Open();
                SqlCommand command = new SqlCommand("delete from Question WHERE Qno=@Qn", connection);
                command.Parameters.AddWithValue("@Qn", Qn);
                int i = command.ExecuteNonQuery();
                connection.Close();
                dataGridView1.Update();
                dataGridView1.Refresh();

            }
            catch (Exception) { }
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

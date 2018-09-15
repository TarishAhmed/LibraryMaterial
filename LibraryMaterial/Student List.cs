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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            int currentColumnIndex = dataGridView1.CurrentCell.ColumnIndex;
            int Marks = 0;
            string Roll = "";
            if (currentColumnIndex == dataGridView1.Columns.Count - 1)
            {
                currentColumnIndex = 1;

                Roll = dataGridView1[currentColumnIndex, currentRowIndex].Value.ToString();

                currentColumnIndex = 4;

                Marks = Convert.ToInt32(dataGridView1[currentColumnIndex, currentRowIndex].Value);

                //HERE YOU CAN WRITE YOUR LOGIC TO SAVE THE DATA IN DATABASE
            }

            try
            {
              
                    string dbString = ConfigurationManager.ConnectionStrings["LibraryMaterial.Properties.Settings.LibraryConnectionString"].ConnectionString;
                    SqlConnection connection = new SqlConnection(dbString);
                    connection = new SqlConnection(dbString);
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE StudentLogin SET Total_Mark=@mar WHERE Roll_No=@rol", connection);
                    command.Parameters.AddWithValue("@mar", Marks);
                    command.Parameters.AddWithValue("@rol", Roll);
                    int i = command.ExecuteNonQuery();
                    command.ExecuteNonQuery();
                    connection.Close();
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                
            }
            catch (Exception) { }
            try
            {
                studentLoginTableAdapter.Fill(libraryDataSet.StudentLogin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                studentLoginTableAdapter.Fill(libraryDataSet.StudentLogin);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}

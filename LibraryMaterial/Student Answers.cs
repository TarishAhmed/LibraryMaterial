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
    public partial class Student_Answers : UserControl
    {
        public Student_Answers()
        {
            InitializeComponent();
        }



        private void Student_Answers_Load(object sender, EventArgs e)
        {
            try
            {
                studentAnswerTableAdapter.Fill(libraryDataSet1.StudentAnswer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            metroButton2.Enabled = false;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int chk = Convert.ToInt32(textBox1.Text);
            try
            {
                if (textBox1.Text != "" || textBox1.Text != null )
                {

                    metroButton2.Enabled = true;
                }
            }
            catch (Exception)
            {
                
            }
            if (textBox1.Text == "" || textBox1.Text == null)
            {
                metroButton2.Enabled = false;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                studentAnswerTableAdapter.Fill(libraryDataSet1.StudentAnswer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            int currentColumnIndex = dataGridView1.CurrentCell.ColumnIndex;
            int Marks = 0;
            string Roll = "";
            int Qn = 0;
            int newmark = Convert.ToInt32(textBox1.Text);
            if (currentColumnIndex == dataGridView1.Columns.Count - 1)
            {
                currentColumnIndex = 1;

                Roll = dataGridView1[currentColumnIndex, currentRowIndex].Value.ToString();

                currentColumnIndex = 3;

                Qn = Convert.ToInt32(dataGridView1[currentColumnIndex, currentRowIndex].Value);

                currentColumnIndex = 4;

                Marks = Convert.ToInt32(dataGridView1[currentColumnIndex, currentRowIndex].Value);

                //HERE YOU CAN WRITE YOUR LOGIC TO SAVE THE DATA IN DATABASE
            }

            try
            {
                if (newmark > 0 && newmark < 100)
                {
                    string dbString = ConfigurationManager.ConnectionStrings["LibraryMaterial.Properties.Settings.LibraryConnectionString"].ConnectionString;
                    SqlConnection connection = new SqlConnection(dbString);
                    connection = new SqlConnection(dbString);
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE StudentAnswer SET Mark_Obtained=@totmarksa WHERE Qno=@qnosa AND Roll_No=@rollsa", connection);
                    command.Parameters.AddWithValue("@totmarksa", newmark);
                    command.Parameters.AddWithValue("@rollsa", Roll);
                    command.Parameters.AddWithValue("@qnosa", Qn);
                    int i = command.ExecuteNonQuery();
                    command.CommandText = "UPDATE StudentLogin SET Total_Mark=Total_Mark-@oldmar+@mar WHERE Roll_No=@rol";
                    command.Parameters.AddWithValue("@mar", newmark);
                    command.Parameters.AddWithValue("@oldmar", Marks);
                    command.Parameters.AddWithValue("@rol", Roll);
                    command.ExecuteNonQuery();
                    connection.Close();
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                    textBox1.Text = "";
                }
            }
            catch (Exception) { }
            try
            {
                studentAnswerTableAdapter.Fill(libraryDataSet1.StudentAnswer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }


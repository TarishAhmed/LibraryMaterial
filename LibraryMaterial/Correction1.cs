using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryMaterial.LibraryDataSetTableAdapters;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace LibraryMaterial
{
    public partial class Correction1 : UserControl
    {
        StudentAnswerTableAdapter rollno_list = new StudentAnswerTableAdapter();
        public Correction1()
        {
            InitializeComponent();
            try
            {
                studentAnswerTableAdapter.GetCorrectionRoll(libraryDataSet.StudentAnswer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void Correction1_Load(object sender, EventArgs e)
        {

        }

        private void list_roll_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select_roll = list_roll.GetItemText(list_roll.SelectedItem);

            try
            {
                listBox_Qno.DataSource = rollno_list.GetQnoFROMRoll(select_roll);
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void listBox_Qno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listBox_Qno.GetItemText(listBox_Qno.SelectedItem);
            try
            {
                string dbString = ConfigurationManager.ConnectionStrings["LibraryMaterial.Properties.Settings.LibraryConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(dbString);

                connection = new SqlConnection(dbString);
                connection.Open();
                SqlCommand command = new SqlCommand("Select Question.Question, StudentAnswer.Answer, Question.Picture, Question.Mark_Available from Question INNER JOIN StudentAnswer ON Question.Qno=StudentAnswer.Qno where StudentAnswer.Qno=@zip", connection);
                command.Parameters.AddWithValue("@zip", text);
                using (SqlDataReader Answerreader = command.ExecuteReader())
                {
                    if (Answerreader.Read())
                    {
                        txt_question.Text = Answerreader.GetString(0);
                        txt_answer.Text = Answerreader.GetString(1);
                        if (Answerreader["Picture"] != DBNull.Value)
                        {
                            pictureBox1.Image = byteArrayToImage((byte[])Answerreader["Picture"]);
                            metroLabel3.Visible = true;
                        }
                        else
                        {
                            pictureBox1.Image = null;
                            metroLabel3.Visible = false;
                        }
                        txt_markalot.Text = (Answerreader["Mark_Available"].ToString());
                    }
                }
                connection.Close();
            }
            catch (Exception) { }
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            string select_roll = list_roll.GetItemText(list_roll.SelectedItem);
            try
            {
                string dbString = ConfigurationManager.ConnectionStrings["LibraryMaterial.Properties.Settings.LibraryConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(dbString);
                connection = new SqlConnection(dbString);
                connection.Open();
                double f = Convert.ToDouble(txt_markscor.Text);
                int j = Convert.ToInt32(listBox_Qno.GetItemText(listBox_Qno.SelectedItem));
                string k = list_roll.GetItemText(list_roll.SelectedItem).ToString();
                SqlCommand command = new SqlCommand("UPDATE StudentAnswer SET Mark_Obtained=@mark WHERE Qno=@qno AND Roll_No=@roll", connection);
                command.Parameters.AddWithValue("@mark", f);
                command.Parameters.AddWithValue("@qno", j);
                command.Parameters.AddWithValue("@roll", k);
                command.CommandType = CommandType.Text;
                int i = command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Mark Entered");
                txt_markscor.Text = "";
                listBox_Qno.DataSource = rollno_list.GetQnoFROMRoll(select_roll);
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }
    }
}

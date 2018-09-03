using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace LibraryMaterial
{
    public partial class Correction : UserControl
    {
        public Correction()
        {
            InitializeComponent();
        }


        List<String> Qno = new List<String>();
        SqlConnection connection;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\App_Data\\Library.mdf;Integrated Security = True; Connect Timeout = 30";
        private void Correction_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            using (connection)
            {
                List<String> Roll = new List<String>();
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT DISTINCT(Roll_No) FROM StudentAnswer WHERE Mark_Obtained IS NULL;", connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Roll.Add(reader.GetString(0));
                    }
                }
                list_roll.DataSource = Roll;
                connection.Close();
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }


        private void list_roll_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = list_roll.GetItemText(list_roll.SelectedItem);
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("Select Qno from StudentAnswer where Roll_No=@zip", connection);
            command.Parameters.AddWithValue("@zip", text);
            using (SqlDataReader Qnoreader = command.ExecuteReader())
            {
                while (Qnoreader.Read())
                {
                    Qno.Add(Qnoreader.GetInt32(0).ToString());
                }

            }
            listBox_questionno.DataSource = Qno;
            connection.Close();
        }

        private void listBox_questionno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listBox_questionno.GetItemText(listBox_questionno.SelectedItem);
            connection = new SqlConnection(connectionString);
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
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("UPDATE StudentAnswer SET Mark_Obtained=@mark WHERE Qno=@qno", connection);
            command.Parameters.AddWithValue("@mark", txt_markscor.Text);
            command.Parameters.AddWithValue("@qno", listBox_questionno.GetItemText(listBox_questionno.SelectedItem));
            command.CommandType = CommandType.Text;
            int i = command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Mark Entered");
            txt_markscor.Text = "";
        }
    }
}

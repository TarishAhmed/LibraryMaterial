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
using System.Configuration;
using LibraryMaterial.LibraryDataSetTableAdapters;


namespace LibraryMaterial
{
    public partial class AnswerQuestion : UserControl
    {
        
        QuestionTableAdapter qnolist = new QuestionTableAdapter();
        public AnswerQuestion()
        {
            InitializeComponent();
            try
            {
                listBox_questionno.DataSource = qnolist.GetDataBy(DateTime.Now.ToString(),Student_Login.roll_No);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            if(pictureBox1.Image==null)
            {
                metroLabel3.Visible = false;
            }
            else
            {
                metroLabel3.Visible = true;
            }

        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string dbString = ConfigurationManager.ConnectionStrings["LibraryMaterial.Properties.Settings.LibraryConnectionString"].ConnectionString;
            string select_Qno = listBox_questionno.GetItemText(listBox_questionno.SelectedItem);
            SqlConnection con = new SqlConnection(dbString);
            con.Open();
            SqlCommand command = new SqlCommand("Select Question,Picture from Question where Qno=@zip",con);
            command.Parameters.AddWithValue("@zip", select_Qno);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if(reader.Read())
                {
                    txt_question.Text = String.Format("{0}",reader["Question"]);
                    if(reader["Picture"]!=DBNull.Value)
                    {
                        pictureBox1.Image = byteArrayToImage((byte[])reader["Picture"]);
                        metroLabel3.Visible = true;
                    }
                    else
                    {
                        pictureBox1.Image = null;
                        metroLabel3.Visible = false;
                    }
                }
            }
            con.Close();
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void AnswerQuestion_Load(object sender, EventArgs e)
        {
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string dbString = ConfigurationManager.ConnectionStrings["LibraryMaterial.Properties.Settings.LibraryConnectionString"].ConnectionString;
            string select_Qno = listBox_questionno.GetItemText(listBox_questionno.SelectedItem);
            if (txt_answer.Text != "")
            {
                SqlConnection con = new SqlConnection(dbString);
                SqlCommand cmd;
                con.Open();
                string s = "insert into StudentAnswer(Roll_No,Answer,Qno) values(@p1,@p2,@p3)";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@p1", Student_Login.roll_No);
                cmd.Parameters.AddWithValue("@p2", txt_answer.Text);
                cmd.Parameters.AddWithValue("@p3", select_Qno);
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Answer Posted!");
                pictureBox1.Image = null;
                metroLabel3.Visible = false;
                txt_answer.Text = null;
                txt_question.Text = null;
                listBox_questionno.DataSource = qnolist.GetDataBy(DateTime.Now.ToString(), Student_Login.roll_No);

            }
        }
    }
}

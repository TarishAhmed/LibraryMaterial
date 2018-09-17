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

namespace LibraryMaterial
{
    
    public partial class PostQuestion : UserControl
    {

        //string filename;
       
        
        public PostQuestion()
        {
            InitializeComponent();
        }

        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PostQuestion_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            var dbString = ConfigurationManager.ConnectionStrings["LibraryMaterial.Properties.Settings.LibraryConnectionString"].ConnectionString;
            try
            {

                if (Convert.ToInt32(metroTextBox2.Text) >= 0 && Convert.ToInt32(metroTextBox2.Text) <= 50)
                {

                    SqlConnection con = new SqlConnection(dbString);
                    SqlCommand cmd;
                    con.Open();
                    string s;
                    if (pictureBox1.Image != null)
                    { s = "insert into Question (Question,Mark_Available,Picture,PostDate) values(@p1,@p2,@p4,@p3)"; }
                    else
                    { s = "insert into Question (Question,Mark_Available,PostDate) values(@p1,@p2,@p3)"; }
                    cmd = new SqlCommand(s, con);
                    cmd.Parameters.AddWithValue("@p1", metroTextBox1.Text);
                    cmd.Parameters.AddWithValue("@p2", Convert.ToInt32(metroTextBox2.Text));
                    cmd.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
                    if (pictureBox1.Image != null)
                        cmd.Parameters.AddWithValue("@p4", ConvertImageToBinary(pictureBox1.Image));
                    cmd.CommandType = CommandType.Text;
                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Question Added!");
                    metroTextBox1.Text = null;
                    metroTextBox2.Text = null;
                    pictureBox1.Image = null;
                }
                else
                {
                    MessageBox.Show("Check Marks Entered!");
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error :" +  ae);
                metroTextBox1.Text = null;
                metroTextBox2.Text = null;
                pictureBox1.Image = null;
            }


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string filename;
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(filename);
                }
            }
        }
        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        
    }
}

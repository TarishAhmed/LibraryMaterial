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
using System.Configuration;

namespace LibraryMaterial
{
    public partial class Ranking : UserControl
    {
        public Ranking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Label[] labels = new Label[5];

            string dbString = ConfigurationManager.ConnectionStrings["LibraryMaterial.Properties.Settings.LibraryConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(dbString);
            int i = 0;
            connection = new SqlConnection(dbString);
            connection.Open();
            SqlCommand command = new SqlCommand("Select TOP 10 Roll_No,Name,Total_Mark from StudentLogin ORDER BY Total_Mark DESC;", connection);
            using (SqlDataReader ranker = command.ExecuteReader())
            {
                while(ranker.Read())
                {
                    //Create label
                    Label Roll = new Label();
                    Label Name = new Label();
                    Label Mark = new Label();
                    Roll.Text = ranker["Roll_No"].ToString();
                    //Position label on screen
                    Roll.Left = 50;
                    Roll.Top = (i + 1) * 40;
                    Roll.Size = new Size(120, 20);
                    //Add controls to form
                    panel2.Controls.Add(Roll);
                    Name.Text = ranker["Name"].ToString();
                    if(Name.Text==Student_Login.name)
                    {
                        Name.ForeColor = Color.DarkSalmon;
                        Name.Size = new Size(200,40);
                    }
                    //Position label on screen
                    Name.Left = 280;
                    Name.Top = (i + 1) * 40;
                    Name.Size = new Size(200, 20);
                    //Add controls to form
                    panel2.Controls.Add(Name);
                    Mark.Text = ranker["Total_Mark"].ToString();
                    //Position label on screen
                    Mark.Left = 620;
                    Mark.Top = (i + 1) * 40;
                    Mark.Size = new Size(200, 20);
                    //Add controls to form
                    panel2.Controls.Add(Mark);
                    i++;
                }
            }

        }

        private void Ranking_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class Marks : UserControl
    {
        public Marks()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string dbString = ConfigurationManager.ConnectionStrings["LibraryMaterial.Properties.Settings.LibraryConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(dbString);
            con.Open();
            SqlCommand command = new SqlCommand("Select Total_Mark from StudentLogin where Roll_No=@rolm", con);
            command.Parameters.AddWithValue("@rolm", Student_Login.roll_No);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    metroLabel2.Text = String.Format("{0}", reader["Total_Mark"]);
                }
            }
            con.Close();
        }
    }
}

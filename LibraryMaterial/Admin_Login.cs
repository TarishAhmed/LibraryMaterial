using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace LibraryMaterial
{
    public partial class Admin_Login : MaterialForm
    {
        public static string User;
        public Admin_Login()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey500, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
            button1.MouseEnter += new EventHandler(button1_MouseEnter);
            button1.MouseLeave += new EventHandler(button1_MouseLeave);
        }
        void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.Image = ((System.Drawing.Image)(Properties.Resources.student_active));

        }
        void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.Image = ((System.Drawing.Image)(Properties.Resources.student_inactive));
        }
        private void Admin_Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Login studentlog = new Student_Login();
            studentlog.ShowDialog();
            this.Dispose();

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["LibraryMaterial.Properties.Settings.LibraryConnectionString"].ConnectionString;
                con.Open();
                string username = materialSingleLineTextField1.Text;
                string password = materialSingleLineTextField2.Text;
                SqlCommand cmd = new SqlCommand("select UserName,Password from AdminLogin where UserName='" + username + "' and Password='" + password + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        User = String.Format("{0}", reader["UserName"]);
                    }
                }
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    Admin_Panel admin = new Admin_Panel();
                    admin.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Invalid Login Credentials");
                }
                con.Close();
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

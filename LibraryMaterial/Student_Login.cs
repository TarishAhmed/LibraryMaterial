using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace LibraryMaterial
{
    public partial class Student_Login : MaterialForm
    {
        public static string roll_No;
        public static string name;

        public Student_Login()
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
            this.button1.Image = ((System.Drawing.Image)(Properties.Resources.admin_active));
            
        }
        void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.Image = ((System.Drawing.Image)(Properties.Resources.admin_inactive));
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login adminlog = new Admin_Login();
            adminlog.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\taris\\source\\repos\\LibraryMaterial\\LibraryMaterial\\Library.mdf;Integrated Security=True;Connect Timeout=30";
            con.Open();
            string student = metroTextBox1.Text;
            SqlCommand cmd = new SqlCommand("select Roll_No,Name from StudentLogin where Roll_No='" + metroTextBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    roll_No = String.Format("{0}", reader["Roll_No"]);
                    name = String.Format("{0}", reader["Name"]);
                }
            }
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                StudentPanel studentDialog = new StudentPanel();
                studentDialog.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login Credentials");
            }
            con.Close();
        }
    }
}

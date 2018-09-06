using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryMaterial
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            button1.MouseEnter += new EventHandler(button1_MouseEnter);
            button1.MouseLeave += new EventHandler(button1_MouseLeave);
            bunifuFlatButton1.MouseDown += new EventHandler(bunifuFlatButton1_MouseEnter);
            label1.ForeColor = Color.FromArgb(0, 105, 92);
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            metroLabel1.Text = Admin_Login.User;
        }
        private void bunifuFlatButton1_MouseEnter(object sender, EventArgs e)
        {
            bunifuFlatButton1.BackColor = Color.Red;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Image = ((System.Drawing.Image)(Properties.Resources.cross_active));
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = ((System.Drawing.Image)(Properties.Resources.cross_inactive));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bunifuFlatButton1_MouseDown(object sender, EventArgs e)
        {
            bunifuFlatButton1.BackColor = Color.Red;
        }

        private void postQuestion1_Load(object sender, EventArgs e)
        {
            postQuestion1.Show();
            correction1.Hide();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            postQuestion1.Show();
            correction1.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            postQuestion1.Hide();
            correction1.Show();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            postQuestion1.Hide();
            correction1.Hide();
        }
    }
}

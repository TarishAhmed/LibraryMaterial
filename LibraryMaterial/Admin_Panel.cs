using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryMaterial
{
    public partial class Admin_Panel : Form
    {
        
        public Admin_Panel()
        {
            InitializeComponent();
            
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Image = ((System.Drawing.Image)(Properties.Resources.cross_active));
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = ((System.Drawing.Image)(Properties.Resources.cross_inactive));
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            button1.MouseEnter += new EventHandler(button1_MouseEnter);
            button1.MouseLeave += new EventHandler(button1_MouseLeave);
            metroLabel1.Text = Admin_Login.User;
            postQuestion1.Show();
            correction11.Hide();
            student_List1.Hide();
            student_Answers1.Hide();
            ranking1.Hide();
            questionList1.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            postQuestion1.Hide();
            correction11.Show();
            student_List1.Hide();
            student_Answers1.Hide();
            ranking1.Hide();
            questionList1.Hide();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            postQuestion1.Hide();
            correction11.Hide();
            student_List1.Hide();
            student_Answers1.Show();
            ranking1.Hide();
            questionList1.Hide();


        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            postQuestion1.Hide();
            correction11.Hide();
            student_List1.Show();
            student_Answers1.Hide();
            ranking1.Hide();
            questionList1.Hide();
        }

        private void postQuestion1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            postQuestion1.Show();
            correction11.Hide();
            student_List1.Hide();
            student_Answers1.Hide();
            ranking1.Hide();
            questionList1.Hide();
        }

        private void correction11_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login Adminlog = new Admin_Login();
            Adminlog.ShowDialog();
            this.Dispose();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            postQuestion1.Hide();
            correction11.Hide();
            student_List1.Hide();
            student_Answers1.Hide();
            ranking1.Show();
            questionList1.Hide();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            postQuestion1.Hide();
            correction11.Hide();
            student_List1.Hide();
            student_Answers1.Hide();
            ranking1.Hide();
            questionList1.Show();
        }
    }
}

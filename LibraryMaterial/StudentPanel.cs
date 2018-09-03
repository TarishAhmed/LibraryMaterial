using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Bunifu;
using Bunifu.Framework;

namespace LibraryMaterial
{
    public partial class StudentPanel : Form
    {
        
        public StudentPanel()
        {
            InitializeComponent();
            panel3.BackColor= Color.FromArgb(255, 152, 0);
            button1.MouseEnter += new EventHandler(button1_MouseEnter);
            button1.MouseLeave += new EventHandler(button1_MouseLeave);
            bunifuFlatButton1.MouseDown += new EventHandler(bunifuFlatButton1_MouseEnter);
            label1.ForeColor= Color.FromArgb(0, 105, 92);
            metroLabel1.Text = Student_Login.roll_No;
            metroLabel2.Text = Student_Login.name;
        }

        private void bunifuFlatButton1_MouseEnter(object sender, EventArgs e)
        {
            bunifuFlatButton1.BackColor = Color.Red;
        }

        private void button1_MouseEnter(object sender,EventArgs e)
        {
            button1.Image = ((System.Drawing.Image)(Properties.Resources.cross_active));
        }
        private void button1_MouseLeave(object sender,EventArgs e)
        {
            button1.Image = ((System.Drawing.Image)(Properties.Resources.cross_inactive));
        }
        private void StudentPanel_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void bunifuFlatButton1_MouseDown(object sender, EventArgs e)
        {
            bunifuFlatButton1.BackColor = Color.Red;
        }

        

        private void answerQuestion1_Load(object sender, EventArgs e)
        {

        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            answerQuestion1.Show();
        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            answerQuestion1.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            answerQuestion1.Hide();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}

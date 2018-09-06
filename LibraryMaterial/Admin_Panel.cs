using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            button1.MouseEnter += new EventHandler(button1_MouseEnter);
            button1.MouseLeave += new EventHandler(button1_MouseLeave);
            label1.ForeColor = Color.FromArgb(0, 105, 92);
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
            metroLabel1.Text = Admin_Login.User;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Error_Application
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            AdminLogin student = new AdminLogin();
            student.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //AdminLogin login = new AdminLogin();
            //login.Show();
            //this.Hide();
            //frmUser user = new frmUser();
            //user.Show();
            //this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //frmAdmin admin = new frmAdmin();
            //admin.Show();
            //this.Hide();
            AdminLogin admin = new AdminLogin();
            admin.Show();
            this.Hide();
        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
            AdminLogin lecturer = new AdminLogin();
            lecturer.Show();
            this.Hide();
        }
    }
}

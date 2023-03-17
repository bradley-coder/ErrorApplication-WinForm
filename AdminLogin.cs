using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using BLL;
using System.Text.RegularExpressions;

namespace Error_Application
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();
        Administrator admin = new Administrator();
        public static DataTable dtLogg = null;
        //gets email and password from user,determines if they are either a admin,lecturer,student and takes user to appropriate form
        private void btnLogin_Click(object sender, EventArgs e)
        {
            dtLogg = bll.GetLogin(txtUserName.Text, txtPassword.Text);
            string role = dtLogg.Rows[0]["RoleDescription"].ToString();
            if (dtLogg.Rows.Count > 0)
            {
                if (role == "Administrator")
                {
                    frmAdmin admin = new frmAdmin();
                    admin.Show();
                    this.Hide();
                }
                else if (role=="Student")
                {
                    frmStudent student = new frmStudent();
                    student.Show();
                    this.Hide();
                }
                else if(role=="Lecturer")
                {
                    frmLecturer lecturer = new frmLecturer();
                    lecturer.Show();
                    this.Hide();
                }
            }
            else
            {
                lblIncorrect.Visible=true;//Create error message 
            }
        }
        //when clicked goes back to start form 
        private void button1_Click(object sender, EventArgs e)
        {
            frmStart start = new frmStart();
            start.Show();
            this.Hide();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            
        }
        //Prevent User Entering nothing
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserName.Text))/*||(!Regex.IsMatch(txtUserName.Text,@"^([\w\.\-]+)((\.(\w){2,3})+)$")))*/
            {
                e.Cancel = true;
                txtUserName.Focus();
                erpEmail.SetError(txtUserName, "Please Enter Email Address!");
            }
            else
            {
                e.Cancel = false;
                erpEmail.SetError(txtUserName, null);
            }
        }
        //Prevent empty fields
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                erpPassword.SetError(txtPassword, "Please Enter Password!");
            }
            else
            {
                e.Cancel = false;
                erpPassword.SetError(txtPassword, null);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

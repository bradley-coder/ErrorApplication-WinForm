using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DAL;
using System.Drawing.Printing;


namespace Error_Application
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();
        Administrator administrator = new Administrator();
        DataTable dt = AdminLogin.dtLogg;

        //Adds User
        private void btnAdd_Click(object sender, EventArgs e)
        {
            administrator.UserName = txtUserName.Text;
            administrator.SurName = txtSurName.Text;
            administrator.Email = txtEmail.Text;
            administrator.Password = txtPassword.Text;
            administrator.RoleID = int.Parse(cmbRole.SelectedValue.ToString());
            //administrator.UserStatus = cmbUserStatus.SelectedItem;
            int x = bll.InsertUser(administrator);
            if (x > 0)
            {
                MessageBox.Show(x + "Registered successfully!");
            }
            Clear();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            
            dgvViewUser.DataSource = bll.GetUser();
        }
        //displays current user,Clears textBoxes,Displays user in DataGridview,Adds Information to comboBoxes
        private void frmUser_Load(object sender, EventArgs e)
        {
            lblAccount.Text = dt.Rows[0]["UserName"].ToString() + "," + dt.Rows[0]["SurName"].ToString() + "(" + dt.Rows[0]["RoleDescription"].ToString() + ")";
            Clear();
            dgvViewUser.DataSource = bll.GetUser();
            cmbRole.DataSource = bll.GetRole();
            cmbRole.DisplayMember = "RoleDescription";
            cmbRole.ValueMember = "RoleID";
            
        }
        //Goes Back to Admin Page
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            admin.Show();
            this.Hide();
        }
        //Select
        private void dgvViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtSurName.Enabled = false;
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            if (dgvViewUser.SelectedRows.Count > 0)
            {
                txtUserName.Text = dgvViewUser.SelectedRows[0].Cells["UserName"].Value.ToString();
                txtSurName.Text = dgvViewUser.SelectedRows[0].Cells["SurName"].Value.ToString();
                txtEmail.Text = dgvViewUser.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Enabled = false;
                cmbRole.Text = dgvViewUser.SelectedRows[0].Cells["RoleDescription"].Value.ToString();
            }
            
        }
        //Update User
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Administrator administrator = new Administrator();
            administrator.UserID = int.Parse(dgvViewUser.SelectedRows[0].Cells["UserID"].Value.ToString());
            administrator.RoleID = int.Parse(cmbRole.SelectedValue.ToString());
            administrator.Email = txtEmail.Text;
            int x = bll.UpdateUser(administrator);
            if(x>0)
            {
                MessageBox.Show(x+ "User Updated Successfully");
                //Clear();
                //RefreshDgv();
            }
            
        }
        public void Clear()
        {
            txtUserName.Text = "";
            txtSurName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtPassword.Enabled = true;
        }
        //Refresh
        public void RefreshDgv()
        {
            dgvViewUser.DataSource = bll.GetUser();
        }

        private void dgvViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //Delete User
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();
            admin.UserID = int.Parse(dgvViewUser.SelectedRows[0].Cells["UserID"].Value.ToString());
            int x = bll.DeleteUser(admin);
            if(x>0)
            {
                MessageBox.Show("User Deleted Permanently!");
                Clear();
                this.RefreshDgv();
            }

        }
        //Print as Pdf
        private void btnPdf_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog(); 
            PrintDocument printDocument = new PrintDocument(); 
            printDialog.Document = printDocument; 
            printDocument.PrintPage += printDocument1_PrintPage; 
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgvViewUser.Width, this.dgvViewUser.Height);

            dgvViewUser.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvViewUser.Width, this.dgvViewUser.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        //Prevent Blank Entry
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider.SetError(txtUserName, "Please Enter User Name!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtUserName, null);
            }
        }
        //Prevent Blank Entry
        private void txtSurName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSurName.Text))
            {
                e.Cancel = true;
                txtSurName.Focus();
                errorProvider.SetError(txtSurName, "Please Enter SurName!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtSurName, null);
            }
        }
        //Prevent Blank Entry
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider.SetError(txtEmail, "Please Enter Email!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEmail, null);
            }
        }
        //Prevent Blank Entry
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider.SetError(txtPassword, "Please Enter Password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPassword, null);
            }
        }
    }
}

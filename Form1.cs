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
using System.Drawing.Printing;

namespace Error_Application
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bussiness = new BussinessLogicLayer();        
        static DataTable dt = AdminLogin.dtLogg;
        public int StudentID;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt = AdminLogin.dtLogg;
            StudentID = int.Parse(dt.Rows[0]["UserID"].ToString());
            Error error = new Error();
            error.ErrorDescription = txtErrorAdd.Text;
            error.StudentID = StudentID;
            error.ProgLanguageID = int.Parse(cmbProgLanguageAdd.SelectedValue.ToString());
            error.ModuleTopicID = int.Parse(cmbModuleTopicAdd.SelectedValue.ToString());
            error.ErrorStatus =cmbErrorStatus.SelectedItem.ToString();
            int x = bussiness.InsertError(error);
            if(x>0)
            {
                MessageBox.Show(x + "Added");
                this.RefreshDgv();
            }
        }
        public void RefreshDgv()
        {
            dgvError.DataSource = bussiness.ReadError();
        }
        //Adds to Topic comboBox from ModuleTopic table
        public void TopicModule()
        {
            cmbModuleTopicAdd.DataSource = bussiness.GetModuleTopic();
            cmbModuleTopicAdd.DisplayMember = "Description";
            cmbModuleTopicAdd.ValueMember = "ModuleTopicID";
        }
        //Adds to Status comboBox
        public void Status()
        {
            cmbErrorStatus.Items.Add("New");
            cmbErrorStatus.Items.Add("Pending");
            cmbErrorStatus.Items.Add("Solved");
        }
        //Adds Programming Language to comboBox
        public void ProgLang()
        {
            cmbProgLanguageAdd.DataSource = bussiness.GetProgLanguage();
            cmbProgLanguageAdd.DisplayMember = "ProgLanguageDescription";
            cmbProgLanguageAdd.ValueMember = "ProgLanguageID";
        }
        //loads current user,and comboBoxes
        private void frmStudent_Load(object sender, EventArgs e)
        {
            lblAccount.Text = dt.Rows[0]["UserName"].ToString() + "," + dt.Rows[0]["SurName"].ToString() + "(" + dt.Rows[0]["RoleDescription"].ToString() + ")";
            dgvError.DataSource = bussiness.GetErrorSolution();
            TopicModule();
            Status();
            ProgLang();
            LoadProgForError();
        }
        //View Error
        private void btnView_Click(object sender, EventArgs e)
        {
            dgvError.DataSource=bussiness.ReadError();           
        }
        //Sign Out
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            dt = null;
            AdminLogin login = new AdminLogin();
            login.Show();
            this.Hide();
        }
        //Update ErrorStatus
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Error error = new Error();
            error.ErrorID = int.Parse(dgvError.SelectedRows[0].Cells["ErrorID"].Value.ToString());
            error.ErrorStatus = cmbErrorStatus.SelectedItem.ToString();
            int x = bussiness.UpdateError(error);
            if (x > 0)
            {
                MessageBox.Show(x + "Error Updated Successfully");
            }
            else
            {
                MessageBox.Show(x + "Failed");
            }
            dgvError.DataSource = bussiness.ReadError();
        }
        //Delete Error
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Error error = new Error();
            error.ErrorID = int.Parse(dgvError.SelectedRows[0].Cells["ErrorID"].Value.ToString());
            int x = bussiness.DeleteError(error);
            if (x > 0)
            {
                MessageBox.Show("Error Details Deleted Permanently!");
                dgvError.DataSource = bussiness.ReadError();
            }
        }
        //View ErrorSolution
        private void btnViewSolutions_Click(object sender, EventArgs e)
        {
            dgvError.DataSource = bussiness.GetErrorSolution();
        }
        //Print Report
        private void btnPrint_Click(object sender, EventArgs e)
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
        //Print Report
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgvError.Width, this.dgvError.Height);
            dgvError.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvError.Width, this.dgvError.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        //loads programming languages to comboBox
        public void LoadProgForError()
        {
            cmbProgLanguage.DataSource = bussiness.GetProgLanguage();
            cmbProgLanguage.DisplayMember = "ProgLanguageDescription";
            cmbProgLanguage.ValueMember = "ProgLanguageID";
        }
        //Selects Programming Language
        private void cmbProgLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {           
            int progID;
            Int32.TryParse(cmbProgLanguage.SelectedValue.ToString(), out progID);
            dgvError.DataSource = bussiness.GetErrorByProg(progID);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvError.DataSource = bussiness.CountQuestions();
        }

        private void txtErrorAdd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtErrorAdd.Text))
            {
                e.Cancel = true;
                txtErrorAdd.Focus();
                erpDescription.SetError(txtErrorAdd, "Please Enter Description!");
            }
            else
            {
                e.Cancel = false;
                erpDescription.SetError(txtErrorAdd, null);
            }
        }
    }
}

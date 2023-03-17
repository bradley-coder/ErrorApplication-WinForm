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
    public partial class frmLecturer : Form
    {
        public frmLecturer()
        {
            InitializeComponent();
        }
        DataTable dt=AdminLogin.dtLogg;
        BussinessLogicLayer bll = new BussinessLogicLayer();
        public int LecturerID;
        private void frmLecturer_Load(object sender, EventArgs e)
        {
            lblAccount.Text = dt.Rows[0]["UserName"].ToString() + "," + dt.Rows[0]["SurName"].ToString() + "(" + dt.Rows[0]["RoleDescription"].ToString() + ")";
            SolutionCmb();
            Errorcmb();
        }

        private void btnAddSolution_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt = AdminLogin.dtLogg;
            LecturerID = int.Parse(dt.Rows[0]["UserID"].ToString());
            Solution solution = new Solution();
            solution.SolutionDescription = txtSolutionDesc.Text;
            solution.LecturerID = LecturerID;
            int x = bll.InsertSolution(solution);
            if (x > 0)
            {
                MessageBox.Show(x + "Added");          
            }
            dgvView.DataSource = bll.GetSolution();
        }

        private void btnViewSolution_Click(object sender, EventArgs e)
        {
            dgvView.DataSource = bll.GetSolution();
        }

        private void btnListError_Click(object sender, EventArgs e)
        {
            dgvErrorSolution.DataSource = bll.ReadError();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            dt = null;
            AdminLogin login = new AdminLogin();
            login.Show();
            this.Hide();
        }

        private void btnUpdateSolution_Click(object sender, EventArgs e)
        {
            Solution solution = new Solution();
            solution.SolutionID = int.Parse(dgvView.SelectedRows[0].Cells["SolutionID"].Value.ToString());
            solution.SolutionDescription = txtSolutionDesc.Text;
            int x = bll.UpdateSolution(solution);
            if (x > 0)
            {
                MessageBox.Show(x + "Solution Updated Successfully");
            }
            else
            {
                MessageBox.Show(x + "Failed");
            }
            dgvView.DataSource = bll.GetSolution();
        }

        private void btnDeleteSolution_Click(object sender, EventArgs e)
        {
            Solution solution = new Solution();
            solution.SolutionID = int.Parse(dgvView.SelectedRows[0].Cells["SolutionID"].Value.ToString());
            int x = bll.DeleteSolution(solution);
            if (x > 0)
            {
                MessageBox.Show("Solution Description Deleted Permanently!");
                dgvView.DataSource = bll.GetSolution();
            }
        }
        public void SolutionCmb()
        {
            cmbSolutionDesc.DataSource = bll.GetSolution();
            cmbSolutionDesc.DisplayMember = "SolutionDescription";
            cmbSolutionDesc.ValueMember = "SolutionID";
        }
        public void Errorcmb()
        {
            cmbErrorDesc.DataSource = bll.ReadError();
            cmbErrorDesc.DisplayMember = "ErrorDescription";
            cmbErrorDesc.ValueMember = "ErrorID";
        }

        private void btnAddErrorSolution_Click(object sender, EventArgs e)
        {
            ErrorSolution es = new ErrorSolution();           
            es.ErrorID = int.Parse(cmbErrorDesc.SelectedValue.ToString());
            es.SolutionID = int.Parse(cmbSolutionDesc.SelectedValue.ToString());
            es.SolutionDate = dtpSolutionDate.Text;
            int x = bll.InsertErrorSolution(es);
            if (x > 0)
            {
                MessageBox.Show(x + "Added Successfully");              
            }
            dgvErrorSolution.DataSource = bll.GetErrorSolution();
        }

        private void btnViewErrorSolution_Click(object sender, EventArgs e)
        {
            dgvErrorSolution.DataSource = bll.GetErrorSolution();
        }

        private void btnUpdateErrorSolution_Click(object sender, EventArgs e)
        {
            ErrorSolution errorSolution = new ErrorSolution();
            errorSolution.ErrorSolutionID = int.Parse(dgvErrorSolution.SelectedRows[0].Cells["ErrorSolutionID"].Value.ToString());
            errorSolution.ErrorID = int.Parse(cmbErrorDesc.SelectedValue.ToString());
            errorSolution.SolutionID = int.Parse(cmbSolutionDesc.SelectedValue.ToString());
            errorSolution.SolutionDate = dtpSolutionDate.Text;
            int x = bll.UpdateErrorSolution(errorSolution);
            if (x > 0)
            {
                MessageBox.Show(x + "Error Solution Updated Successfully");
            }
            else
            {
                MessageBox.Show(x + "Failed");
            }
            dgvErrorSolution.DataSource = bll.GetErrorSolution();
        }

        private void btnDeleteErrorSolution_Click(object sender, EventArgs e)
        {
            ErrorSolution errorSolution = new ErrorSolution();
            errorSolution.ErrorSolutionID = int.Parse(dgvErrorSolution.SelectedRows[0].Cells["ErrorSolutionID"].Value.ToString());
            int x = bll.DeleteErrorSolution(errorSolution);
            if (x > 0)
            {
                MessageBox.Show("Error and Solution Deleted Permanently!");
                dgvErrorSolution.DataSource = bll.GetErrorSolution();
            }
        }

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
            Bitmap bm = new Bitmap(this.dgvErrorSolution.Width, this.dgvErrorSolution.Height);
            dgvErrorSolution.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvErrorSolution.Width, this.dgvErrorSolution.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void txtSolutionDesc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSolutionDesc.Text))
            {
                e.Cancel = true;
                txtSolutionDesc.Focus();
                errorProvider.SetError(txtSolutionDesc, "Please Enter Solution Description!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtSolutionDesc, null);
            }
        }
    }
}

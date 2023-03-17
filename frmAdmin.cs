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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        DataTable dt = AdminLogin.dtLogg;
        BussinessLogicLayer bll = new BussinessLogicLayer();
        Role role = new Role();
        ProgLanguage prog = new ProgLanguage();
        //lists current user,adds items to combobox for users to choose from
        private void frmAdmin_Load(object sender, EventArgs e)
        {           
            //displays current users information
            label3.Text = dt.Rows[0]["UserName"].ToString() + "," + dt.Rows[0]["SurName"].ToString() + "(" + dt.Rows[0]["RoleDescription"].ToString() + ")";
            //adds items to role comboBox
            cmbRoleDescription.Items.Add("Administrator");
            cmbRoleDescription.Items.Add("Lecturer");
            cmbRoleDescription.Items.Add("Student");
            //Adds items to year comboBox
            cmbYear.Items.Add("First Year");
            cmbYear.Items.Add("Second Year");
            cmbYear.Items.Add("Third Year");
            cmbYear.Items.Add("Fourth Year");
            //YearDescription combobox
            cmbYearDescription.DataSource = bll.GetYear();
            cmbYearDescription.DisplayMember = "YearDescription";
            cmbYearDescription.ValueMember = "YearID";
            //Module Topic ComboBoxes
            ModTopTopic();
            ModTopModule();
            
        }
        //Add Role
        private void btnAdd_Click(object sender, EventArgs e)
        {
            role.RoleDescription = cmbRoleDescription.Text;
            int x = bll.InsertRole(role);
            if (x > 0)
            {
                MessageBox.Show(x + "Added");
            }
            else
            {
                MessageBox.Show(x+"Failed");
            }
            dgvView.DataSource = bll.GetRole();
        }
        //sign out button gives other users a chance to login
        private void btnBack_Click(object sender, EventArgs e)
        {
            dt = null;
            AdminLogin login = new AdminLogin();
            login.Show();
            this.Hide();           
        }
        //list all the roles in datagridview thats been added
        private void btnList_Click(object sender, EventArgs e)
        {
            dgvView.DataSource = bll.GetRole();
        }
        //Goes to registration form
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmUser user = new frmUser();
            user.Show();
            this.Hide();
        }
        //Adding Programming Language
        private void btnAddLanguage_Click(object sender, EventArgs e)
        {
            prog.ProgLanguageDescription = txtProgLang.Text;
            int x = bll.InsertProgLang(prog);
            if (x > 0)
            {
                MessageBox.Show(x + "Programming Language Added");
            }
            else
            {
                MessageBox.Show(x + "Failed");
            }
            dgvView.DataSource = bll.GetProgLanguage();
        }
        //List Programming Languages
        private void btnViewLanguage_Click(object sender, EventArgs e)
        {
            dgvView.DataSource = bll.GetProgLanguage();
        }
        //Update Role
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.RoleID = int.Parse(dgvView.SelectedRows[0].Cells["RoleID"].Value.ToString());
            role.RoleDescription = cmbRoleDescription.SelectedItem.ToString();
            int x = bll.UpdateRole(role);
            if (x > 0)
            {
                MessageBox.Show(x + "Role Updated Successfully");
            }
            else
            {
                MessageBox.Show(x + "Failed");
            }
            dgvView.DataSource = bll.GetRole();
        }
        //Delete Role
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.RoleID = int.Parse(dgvView.SelectedRows[0].Cells["RoleID"].Value.ToString());
            int x = bll.DeleteRole(role);
            if (x > 0)
            {
                MessageBox.Show("Role Deleted Permanently!");
                dgvView.DataSource = bll.GetRole();
            }
        }
        
        //Update Programming Language
        private void btnUpdateLanguage_Click(object sender, EventArgs e)
        {
            ProgLanguage prog = new ProgLanguage();
            prog.ProgLanguageID= int.Parse(dgvView.SelectedRows[0].Cells["ProgLanguageID"].Value.ToString());
            prog.ProgLanguageDescription = txtProgLang.Text;
            int x = bll.UpdateProgLang(prog);
            if (x > 0)
            {
                MessageBox.Show(x + "Programming Language Updated Successfully");
            }
            else
            {
                MessageBox.Show(x + "Failed");
            }
            dgvView.DataSource = bll.GetProgLanguage();
        }
        //Delete Language
        private void btnDeleteLang_Click(object sender, EventArgs e)
        {
            ProgLanguage prog = new ProgLanguage();
            prog.ProgLanguageID = int.Parse(dgvView.SelectedRows[0].Cells["ProgLanguageID"].Value.ToString());
            int x = bll.DeleteProgLang(prog);
            if (x > 0)
            {
                MessageBox.Show("Programming Language Deleted Permanently!");
                dgvView.DataSource = bll.GetProgLanguage();
            }
        }
        //Add Year
        private void btnYear_Click(object sender, EventArgs e)
        {
            Year year=new Year();
            year.YearDescription = cmbYear.Text;
            int x = bll.InsertYear(year);
            if(x>0)
            {
                MessageBox.Show("Year Added");
            }

            dgvView.DataSource = bll.GetYear();
        }
        //View Year
        private void btnViewYear_Click(object sender, EventArgs e)
        {
            dgvView.DataSource = bll.GetYear();
        }
        //Update Year
        private void btnUpdateYear_Click(object sender, EventArgs e)
        {
            Year year = new Year();
            year.YearID = int.Parse(dgvView.SelectedRows[0].Cells["YearID"].Value.ToString());
            year.YearDescription = cmbYear.SelectedItem.ToString();
            int x = bll.UpdateYear(year);
            if (x > 0)
            {
                MessageBox.Show(x + "Year Updated Successfully");
            }
            else
            {
                MessageBox.Show(x + "Failed");
            }
            dgvView.DataSource = bll.GetYear();
        }
        //Delete Year
        private void btnDeleteYear_Click(object sender, EventArgs e)
        {
            Year year = new Year();
            year.YearID = int.Parse(dgvView.SelectedRows[0].Cells["YearID"].Value.ToString());
            int x = bll.DeleteYear(year);
            if (x > 0)
            {
                MessageBox.Show(x+"Year Deleted Permanently!");
                dgvView.DataSource = bll.GetYear();
            }
        }
        //Add Topic
        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            Topic topic = new Topic();
            topic.TopicDescription = txtTopic.Text;
            int x = bll.InsertTopic(topic);
            if (x > 0)
            {
                MessageBox.Show(x + "Topic Added");
                dgvView.DataSource = bll.GetTopic();
            }
            else
            {
                MessageBox.Show(x + "Failed");
            }
            
        }
        //View Topic
        private void btnViewTopic_Click(object sender, EventArgs e)
        {
            dgvView.DataSource = bll.GetTopic();
        }
        //Update Topic
        private void btnUpdateTopic_Click(object sender, EventArgs e)
        {
            Topic topic = new Topic();
            topic.TopicID = int.Parse(dgvView.SelectedRows[0].Cells["TopicID"].Value.ToString());
            topic.TopicDescription = txtTopic.Text;
            int x = bll.UpdateTopic(topic);
            if (x > 0)
            {
                MessageBox.Show(x + "Topic Updated Successfully");
            }
            else
            {
                MessageBox.Show(x + "Failed");
            }
            dgvView.DataSource = bll.GetTopic();
        }
        //Delete Topic
        private void btnDeleteTopic_Click(object sender, EventArgs e)
        {
            Topic topic = new Topic();
            topic.TopicID = int.Parse(dgvView.SelectedRows[0].Cells["TopicID"].Value.ToString());
            int x = bll.DeleteTopic(topic);
            if (x > 0)
            {
                MessageBox.Show(x + "Topic Deleted Permanently!");
                dgvView.DataSource = bll.GetTopic();
            }
        }
        //disables other textboxes,comboBoxes in form.Prevents user from entering the wrong information
        public void ClearForTopic()
        {
            cmbRoleDescription.Enabled = false;
            cmbYear.Enabled = false;
            txtProgLang.Enabled = false;
        }
        //Add Module
        private void btnAddMod_Click(object sender, EventArgs e)
        {
            Module module = new Module();
            module.ModuleDescription = txtModuleDes.Text;
            module.YearID = int.Parse(cmbYearDescription.SelectedValue.ToString());
            int x = bll.InsertModule(module);
            if (x > 0)
            {
                MessageBox.Show(x + "Module Added");
                dgvView.DataSource = bll.GetModule();
            }
            else
            {
                MessageBox.Show(x + "Failed");
            }
        }
        //View Module
        private void btnViewMod_Click(object sender, EventArgs e)
        {
            dgvView.DataSource = bll.GetModule();
        }
        //Update Module
        private void btnUpdateMod_Click(object sender, EventArgs e)
        {
            Module mod = new Module();
            mod.ModuleID = int.Parse(dgvView.SelectedRows[0].Cells["ModuleID"].Value.ToString());            
            mod.ModuleDescription = txtModuleDes.Text;
            mod.YearID = int.Parse(cmbYearDescription.SelectedValue.ToString());
            int x = bll.UpdateModule(mod);
            if (x > 0)
            {
                MessageBox.Show(x + "Module Updated Successfully");
            }
            else
            {
                MessageBox.Show(x + "Failed");
            }
            dgvView.DataSource = bll.GetModule();
        }
        //Delete Module
        private void btnDeleteMod_Click(object sender, EventArgs e)
        {
            Module mod = new Module();
            mod.ModuleID= int.Parse(dgvView.SelectedRows[0].Cells["ModuleID"].Value.ToString());
            int x = bll.DeleteModule(mod);
            if (x > 0)
            {
                MessageBox.Show("Module Deleted Permanently!");
                dgvView.DataSource = bll.GetModule();
            }
        }
        //gets,loads information to comboBox Module(moduleTopic)
        public void ModTopModule()
        {
            cmbModDes.DataSource = bll.GetModule();
            cmbModDes.DisplayMember = "ModuleDescription";
            cmbModDes.ValueMember = "ModuleID";
        }
        //gets,loads information to comboBox Topic(moduleTopic)
        public void ModTopTopic()
        {
            cmbTopicDes.DataSource = bll.GetTopic();
            cmbTopicDes.DisplayMember = "TopicDescription";
            cmbTopicDes.ValueMember = "TopicID";
        }
        //Add ModuleTopic
        private void btnAddModTop_Click(object sender, EventArgs e)
        {
            ModuleTopic tm = new ModuleTopic();
            tm.ModuleID = int.Parse(cmbModDes.SelectedValue.ToString());
            tm.TopicID = int.Parse(cmbTopicDes.SelectedValue.ToString());
            int x = bll.InsertModuleTopic(tm);
            if (x > 0)
            {
                MessageBox.Show(x + "Module Added");
                dgvView.DataSource = bll.GetModuleTopic();
            }
            else
            {
                MessageBox.Show(x + "Failed");
            }
        }
        //List ModuleTopic
        private void btnListModTop_Click(object sender, EventArgs e)
        {
            dgvView.DataSource = bll.GetModuleTopic();
        }
        //Update ModuleTopic
        private void btnUpdateModTop_Click(object sender, EventArgs e)
        {
            ModuleTopic moduleTopic = new ModuleTopic();
            moduleTopic.ModuleTopicID = int.Parse(dgvView.SelectedRows[0].Cells["ModuleTopicID"].Value.ToString());
            moduleTopic.ModuleID = int.Parse(cmbModDes.SelectedValue.ToString());
            moduleTopic.TopicID = int.Parse(cmbTopicDes.SelectedValue.ToString());
            int x = bll.UpdateModuleTopic(moduleTopic);
            if (x > 0)
            {
                MessageBox.Show(x + "Module Topic Updated Successfully");
            }
            else
            {
                MessageBox.Show(x + "Failed");
            }
            dgvView.DataSource = bll.GetModuleTopic();
        }
        //Delete ModuleTopic
        private void btnDeleteModTop_Click(object sender, EventArgs e)
        {
            ModuleTopic moduleTopic = new ModuleTopic();
            moduleTopic.ModuleTopicID = int.Parse(dgvView.SelectedRows[0].Cells["ModuleTopicID"].Value.ToString());
            int x = bll.DeleteModuleTopic(moduleTopic);
            if (x > 0)
            {
                MessageBox.Show("Module and Topic Deleted Permanently!");
                dgvView.DataSource = bll.GetModuleTopic();
            }
        }
        //Print Report as Pdf
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
        //Print Report as Pdf
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgvView.Width, this.dgvView.Height);
            dgvView.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvView.Width, this.dgvView.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        //Goes to Report form
        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport();
            report.Show();
            this.Hide();
        }
        //Prevent user from entering Blank
        private void txtProgLang_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtProgLang.Text))
            {
                e.Cancel = true;
                txtProgLang.Focus();
                errorProvider.SetError(txtProgLang, "Please Enter Programming Language!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtProgLang, null);
            }
        }
        //Prevent user from entering Blank
        private void txtTopic_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTopic.Text))
            {
                e.Cancel = true;
                txtTopic.Focus();
                errorProvider.SetError(txtTopic, "Please Enter Topic!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtTopic, null);
            }
        }
        //Prevent user from entering Blank
        private void txtModuleDes_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtModuleDes.Text))
            {
                e.Cancel = true;
                txtModuleDes.Focus();
                errorProvider.SetError(txtModuleDes, "Please Enter Module!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtModuleDes, null);
            }
        }
    }
}

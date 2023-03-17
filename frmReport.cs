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

namespace Error_Application
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }
        DataTable dt = AdminLogin.dtLogg;
        BussinessLogicLayer bll = new BussinessLogicLayer();

        private void frmReport_Load(object sender, EventArgs e)
        {
            lblAccount.Text = dt.Rows[0]["UserName"].ToString() + "," + dt.Rows[0]["SurName"].ToString() + "(" + dt.Rows[0]["RoleDescription"].ToString() + ")";
            LoadModule();
            LoadTopic();
        }
        public void LoadModule()
        {
            cmbModule.DataSource = bll.GetModule();
            cmbModule.DisplayMember = "ModuleDescription";
            cmbModule.ValueMember = "ModuleID";
        }

        private void cmbModule_SelectedIndexChanged(object sender, EventArgs e)
        {          
            int modID;
            Int32.TryParse(cmbModule.SelectedValue.ToString(), out modID);
            dgvTopic.DataSource = bll.GetTopicByModule(modID);
        }
        public void LoadTopic()
        {
            cmbTopic.DataSource = bll.GetTopic();
            cmbTopic.DisplayMember = "TopicDescription";
            cmbTopic.ValueMember = "TopicID";
        }

        private void cmbTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            int topicID;
            Int32.TryParse(cmbTopic.SelectedValue.ToString(), out topicID);
            dgvError.DataSource = bll.GetErrorByTopic(topicID);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            admin.Show();
            this.Hide();
        }
    }
}

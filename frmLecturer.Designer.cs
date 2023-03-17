namespace Error_Application
{
    partial class frmLecturer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSolutionDesc = new System.Windows.Forms.TextBox();
            this.btnAddSolution = new System.Windows.Forms.Button();
            this.btnViewSolution = new System.Windows.Forms.Button();
            this.btnUpdateSolution = new System.Windows.Forms.Button();
            this.btnDeleteSolution = new System.Windows.Forms.Button();
            this.btnListError = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpSolutionDate = new System.Windows.Forms.DateTimePicker();
            this.cmbErrorDesc = new System.Windows.Forms.ComboBox();
            this.cmbSolutionDesc = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvErrorSolution = new System.Windows.Forms.DataGridView();
            this.btnAddErrorSolution = new System.Windows.Forms.Button();
            this.btnViewErrorSolution = new System.Windows.Forms.Button();
            this.btnUpdateErrorSolution = new System.Windows.Forms.Button();
            this.btnDeleteErrorSolution = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorSolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvView);
            this.groupBox1.Location = new System.Drawing.Point(419, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Solution";
            // 
            // dgvView
            // 
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(6, 19);
            this.dgvView.Name = "dgvView";
            this.dgvView.Size = new System.Drawing.Size(357, 230);
            this.dgvView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPdf);
            this.groupBox2.Controls.Add(this.btnDeleteErrorSolution);
            this.groupBox2.Controls.Add(this.btnUpdateErrorSolution);
            this.groupBox2.Controls.Add(this.btnViewErrorSolution);
            this.groupBox2.Controls.Add(this.btnAddErrorSolution);
            this.groupBox2.Controls.Add(this.cmbSolutionDesc);
            this.groupBox2.Controls.Add(this.btnSignOut);
            this.groupBox2.Controls.Add(this.cmbErrorDesc);
            this.groupBox2.Controls.Add(this.dtpSolutionDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnListError);
            this.groupBox2.Controls.Add(this.btnDeleteSolution);
            this.groupBox2.Controls.Add(this.btnUpdateSolution);
            this.groupBox2.Controls.Add(this.btnViewSolution);
            this.groupBox2.Controls.Add(this.btnAddSolution);
            this.groupBox2.Controls.Add(this.txtSolutionDesc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblAccount);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 257);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add,Insert,View,Delete";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(285, 2);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(35, 13);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Solution Description:";
            // 
            // txtSolutionDesc
            // 
            this.txtSolutionDesc.Location = new System.Drawing.Point(133, 24);
            this.txtSolutionDesc.Name = "txtSolutionDesc";
            this.txtSolutionDesc.Size = new System.Drawing.Size(201, 20);
            this.txtSolutionDesc.TabIndex = 4;
            this.txtSolutionDesc.Validating += new System.ComponentModel.CancelEventHandler(this.txtSolutionDesc_Validating);
            // 
            // btnAddSolution
            // 
            this.btnAddSolution.BackColor = System.Drawing.Color.LightCoral;
            this.btnAddSolution.Location = new System.Drawing.Point(6, 49);
            this.btnAddSolution.Name = "btnAddSolution";
            this.btnAddSolution.Size = new System.Drawing.Size(75, 23);
            this.btnAddSolution.TabIndex = 5;
            this.btnAddSolution.Text = "Add Solution";
            this.btnAddSolution.UseVisualStyleBackColor = false;
            this.btnAddSolution.Click += new System.EventHandler(this.btnAddSolution_Click);
            // 
            // btnViewSolution
            // 
            this.btnViewSolution.BackColor = System.Drawing.Color.LightCoral;
            this.btnViewSolution.Location = new System.Drawing.Point(90, 49);
            this.btnViewSolution.Name = "btnViewSolution";
            this.btnViewSolution.Size = new System.Drawing.Size(87, 23);
            this.btnViewSolution.TabIndex = 6;
            this.btnViewSolution.Text = "View Solution";
            this.btnViewSolution.UseVisualStyleBackColor = false;
            this.btnViewSolution.Click += new System.EventHandler(this.btnViewSolution_Click);
            // 
            // btnUpdateSolution
            // 
            this.btnUpdateSolution.BackColor = System.Drawing.Color.LightCoral;
            this.btnUpdateSolution.Location = new System.Drawing.Point(183, 50);
            this.btnUpdateSolution.Name = "btnUpdateSolution";
            this.btnUpdateSolution.Size = new System.Drawing.Size(99, 23);
            this.btnUpdateSolution.TabIndex = 7;
            this.btnUpdateSolution.Text = "Update Solution";
            this.btnUpdateSolution.UseVisualStyleBackColor = false;
            this.btnUpdateSolution.Click += new System.EventHandler(this.btnUpdateSolution_Click);
            // 
            // btnDeleteSolution
            // 
            this.btnDeleteSolution.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteSolution.Location = new System.Drawing.Point(298, 50);
            this.btnDeleteSolution.Name = "btnDeleteSolution";
            this.btnDeleteSolution.Size = new System.Drawing.Size(89, 23);
            this.btnDeleteSolution.TabIndex = 8;
            this.btnDeleteSolution.Text = "Delete Solution";
            this.btnDeleteSolution.UseVisualStyleBackColor = false;
            this.btnDeleteSolution.Click += new System.EventHandler(this.btnDeleteSolution_Click);
            // 
            // btnListError
            // 
            this.btnListError.BackColor = System.Drawing.Color.Coral;
            this.btnListError.Location = new System.Drawing.Point(340, 22);
            this.btnListError.Name = "btnListError";
            this.btnListError.Size = new System.Drawing.Size(61, 23);
            this.btnListError.TabIndex = 9;
            this.btnListError.Text = "List Error";
            this.btnListError.UseVisualStyleBackColor = false;
            this.btnListError.Click += new System.EventHandler(this.btnListError_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Red;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(326, 228);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(75, 23);
            this.btnSignOut.TabIndex = 10;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Error Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Solution Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Solution Date:";
            // 
            // dtpSolutionDate
            // 
            this.dtpSolutionDate.Location = new System.Drawing.Point(145, 190);
            this.dtpSolutionDate.Name = "dtpSolutionDate";
            this.dtpSolutionDate.Size = new System.Drawing.Size(200, 20);
            this.dtpSolutionDate.TabIndex = 13;
            // 
            // cmbErrorDesc
            // 
            this.cmbErrorDesc.FormattingEnabled = true;
            this.cmbErrorDesc.Location = new System.Drawing.Point(145, 107);
            this.cmbErrorDesc.Name = "cmbErrorDesc";
            this.cmbErrorDesc.Size = new System.Drawing.Size(200, 21);
            this.cmbErrorDesc.TabIndex = 14;
            // 
            // cmbSolutionDesc
            // 
            this.cmbSolutionDesc.FormattingEnabled = true;
            this.cmbSolutionDesc.Location = new System.Drawing.Point(145, 150);
            this.cmbSolutionDesc.Name = "cmbSolutionDesc";
            this.cmbSolutionDesc.Size = new System.Drawing.Size(200, 21);
            this.cmbSolutionDesc.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvErrorSolution);
            this.groupBox3.Location = new System.Drawing.Point(6, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(782, 177);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View Error and ErrorSolution";
            // 
            // dgvErrorSolution
            // 
            this.dgvErrorSolution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrorSolution.Location = new System.Drawing.Point(9, 19);
            this.dgvErrorSolution.Name = "dgvErrorSolution";
            this.dgvErrorSolution.Size = new System.Drawing.Size(767, 152);
            this.dgvErrorSolution.TabIndex = 0;
            // 
            // btnAddErrorSolution
            // 
            this.btnAddErrorSolution.BackColor = System.Drawing.Color.Firebrick;
            this.btnAddErrorSolution.Location = new System.Drawing.Point(9, 228);
            this.btnAddErrorSolution.Name = "btnAddErrorSolution";
            this.btnAddErrorSolution.Size = new System.Drawing.Size(61, 23);
            this.btnAddErrorSolution.TabIndex = 16;
            this.btnAddErrorSolution.Text = "Add";
            this.btnAddErrorSolution.UseVisualStyleBackColor = false;
            this.btnAddErrorSolution.Click += new System.EventHandler(this.btnAddErrorSolution_Click);
            // 
            // btnViewErrorSolution
            // 
            this.btnViewErrorSolution.BackColor = System.Drawing.Color.Firebrick;
            this.btnViewErrorSolution.Location = new System.Drawing.Point(76, 228);
            this.btnViewErrorSolution.Name = "btnViewErrorSolution";
            this.btnViewErrorSolution.Size = new System.Drawing.Size(66, 23);
            this.btnViewErrorSolution.TabIndex = 17;
            this.btnViewErrorSolution.Text = "View";
            this.btnViewErrorSolution.UseVisualStyleBackColor = false;
            this.btnViewErrorSolution.Click += new System.EventHandler(this.btnViewErrorSolution_Click);
            // 
            // btnUpdateErrorSolution
            // 
            this.btnUpdateErrorSolution.BackColor = System.Drawing.Color.Firebrick;
            this.btnUpdateErrorSolution.Location = new System.Drawing.Point(148, 228);
            this.btnUpdateErrorSolution.Name = "btnUpdateErrorSolution";
            this.btnUpdateErrorSolution.Size = new System.Drawing.Size(67, 23);
            this.btnUpdateErrorSolution.TabIndex = 18;
            this.btnUpdateErrorSolution.Text = "Update";
            this.btnUpdateErrorSolution.UseVisualStyleBackColor = false;
            this.btnUpdateErrorSolution.Click += new System.EventHandler(this.btnUpdateErrorSolution_Click);
            // 
            // btnDeleteErrorSolution
            // 
            this.btnDeleteErrorSolution.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteErrorSolution.Location = new System.Drawing.Point(221, 228);
            this.btnDeleteErrorSolution.Name = "btnDeleteErrorSolution";
            this.btnDeleteErrorSolution.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteErrorSolution.TabIndex = 19;
            this.btnDeleteErrorSolution.Text = "Delete";
            this.btnDeleteErrorSolution.UseVisualStyleBackColor = false;
            this.btnDeleteErrorSolution.Click += new System.EventHandler(this.btnDeleteErrorSolution_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPdf.Location = new System.Drawing.Point(165, 78);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(131, 23);
            this.btnPdf.TabIndex = 20;
            this.btnPdf.Text = "Pdf Print Report";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLecturer";
            this.Text = "frmLecturer";
            this.Load += new System.EventHandler(this.frmLecturer_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorSolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSolutionDesc;
        private System.Windows.Forms.Button btnDeleteSolution;
        private System.Windows.Forms.Button btnUpdateSolution;
        private System.Windows.Forms.Button btnViewSolution;
        private System.Windows.Forms.Button btnAddSolution;
        private System.Windows.Forms.Button btnListError;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.ComboBox cmbSolutionDesc;
        private System.Windows.Forms.ComboBox cmbErrorDesc;
        private System.Windows.Forms.DateTimePicker dtpSolutionDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvErrorSolution;
        private System.Windows.Forms.Button btnDeleteErrorSolution;
        private System.Windows.Forms.Button btnUpdateErrorSolution;
        private System.Windows.Forms.Button btnViewErrorSolution;
        private System.Windows.Forms.Button btnAddErrorSolution;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
namespace Error_Application
{
    partial class frmStudent
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbErrorStatus = new System.Windows.Forms.ComboBox();
            this.cmbModuleTopicAdd = new System.Windows.Forms.ComboBox();
            this.cmbProgLanguageAdd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.txtErrorAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewSolutions = new System.Windows.Forms.Button();
            this.cmbProgLanguage = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvError = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.erpDescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvError)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbErrorStatus);
            this.groupBox1.Controls.Add(this.cmbModuleTopicAdd);
            this.groupBox1.Controls.Add(this.cmbProgLanguageAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.lblAccount);
            this.groupBox1.Controls.Add(this.btnSignOut);
            this.groupBox1.Controls.Add(this.txtErrorAdd);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Error Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Module and Topic:";
            // 
            // cmbErrorStatus
            // 
            this.cmbErrorStatus.FormattingEnabled = true;
            this.cmbErrorStatus.Location = new System.Drawing.Point(137, 208);
            this.cmbErrorStatus.Name = "cmbErrorStatus";
            this.cmbErrorStatus.Size = new System.Drawing.Size(239, 21);
            this.cmbErrorStatus.TabIndex = 16;
            // 
            // cmbModuleTopicAdd
            // 
            this.cmbModuleTopicAdd.FormattingEnabled = true;
            this.cmbModuleTopicAdd.Location = new System.Drawing.Point(137, 160);
            this.cmbModuleTopicAdd.Name = "cmbModuleTopicAdd";
            this.cmbModuleTopicAdd.Size = new System.Drawing.Size(239, 21);
            this.cmbModuleTopicAdd.TabIndex = 15;
            // 
            // cmbProgLanguageAdd
            // 
            this.cmbProgLanguageAdd.FormattingEnabled = true;
            this.cmbProgLanguageAdd.Location = new System.Drawing.Point(137, 104);
            this.cmbProgLanguageAdd.Name = "cmbProgLanguageAdd";
            this.cmbProgLanguageAdd.Size = new System.Drawing.Size(239, 21);
            this.cmbProgLanguageAdd.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Programming Language:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Bisque;
            this.btnDelete.Location = new System.Drawing.Point(407, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Bisque;
            this.btnUpdate.Location = new System.Drawing.Point(407, 129);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(275, 5);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(35, 13);
            this.lblAccount.TabIndex = 10;
            this.lblAccount.Text = "label3";
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Crimson;
            this.btnSignOut.Location = new System.Drawing.Point(6, 19);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(75, 23);
            this.btnSignOut.TabIndex = 9;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // txtErrorAdd
            // 
            this.txtErrorAdd.Location = new System.Drawing.Point(137, 60);
            this.txtErrorAdd.Name = "txtErrorAdd";
            this.txtErrorAdd.Size = new System.Drawing.Size(239, 20);
            this.txtErrorAdd.TabIndex = 8;
            this.txtErrorAdd.Validating += new System.ComponentModel.CancelEventHandler(this.txtErrorAdd_Validating);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Bisque;
            this.btnAdd.Location = new System.Drawing.Point(407, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Bisque;
            this.btnView.Location = new System.Drawing.Point(407, 85);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Error Description:";
            // 
            // btnViewSolutions
            // 
            this.btnViewSolutions.BackColor = System.Drawing.Color.Bisque;
            this.btnViewSolutions.Location = new System.Drawing.Point(186, 255);
            this.btnViewSolutions.Name = "btnViewSolutions";
            this.btnViewSolutions.Size = new System.Drawing.Size(150, 23);
            this.btnViewSolutions.TabIndex = 19;
            this.btnViewSolutions.Text = "View Errors and Solutions";
            this.btnViewSolutions.UseVisualStyleBackColor = false;
            this.btnViewSolutions.Click += new System.EventHandler(this.btnViewSolutions_Click);
            // 
            // cmbProgLanguage
            // 
            this.cmbProgLanguage.FormattingEnabled = true;
            this.cmbProgLanguage.Location = new System.Drawing.Point(11, 77);
            this.cmbProgLanguage.Name = "cmbProgLanguage";
            this.cmbProgLanguage.Size = new System.Drawing.Size(306, 21);
            this.cmbProgLanguage.TabIndex = 2;
            this.cmbProgLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbProgLanguage_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvError);
            this.groupBox2.Location = new System.Drawing.Point(4, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(898, 177);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Errors and Solutions";
            // 
            // dgvError
            // 
            this.dgvError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvError.Location = new System.Drawing.Point(6, 19);
            this.dgvError.Name = "dgvError";
            this.dgvError.Size = new System.Drawing.Size(838, 152);
            this.dgvError.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbProgLanguage);
            this.groupBox3.Location = new System.Drawing.Point(498, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 196);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Bisque;
            this.btnPrint.Location = new System.Drawing.Point(342, 255);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 23);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "Pdf Print Error and Solutions";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Programming Language:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Location = new System.Drawing.Point(522, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Programming Language Most ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // erpDescription
            // 
            this.erpDescription.ContainerControl = this;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(822, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnViewSolutions);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStudent";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvError)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpDescription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtErrorAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProgLanguage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvError;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ComboBox cmbProgLanguageAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbErrorStatus;
        private System.Windows.Forms.ComboBox cmbModuleTopicAdd;
        private System.Windows.Forms.Button btnViewSolutions;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider erpDescription;
    }
}


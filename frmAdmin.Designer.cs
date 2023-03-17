namespace Error_Application
{
    partial class frmAdmin
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRoleDescription = new System.Windows.Forms.ComboBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteTopic = new System.Windows.Forms.Button();
            this.btnUpdateTopic = new System.Windows.Forms.Button();
            this.btnViewTopic = new System.Windows.Forms.Button();
            this.btnAddTopic = new System.Windows.Forms.Button();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteYear = new System.Windows.Forms.Button();
            this.btnUpdateYear = new System.Windows.Forms.Button();
            this.btnViewYear = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProgLang = new System.Windows.Forms.TextBox();
            this.btnDeleteLang = new System.Windows.Forms.Button();
            this.btnUpdateLanguage = new System.Windows.Forms.Button();
            this.btnViewLanguage = new System.Windows.Forms.Button();
            this.btnAddLanguage = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeleteMod = new System.Windows.Forms.Button();
            this.btnUpdateMod = new System.Windows.Forms.Button();
            this.btnViewMod = new System.Windows.Forms.Button();
            this.btnAddMod = new System.Windows.Forms.Button();
            this.cmbYearDescription = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModuleDes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDeleteModTop = new System.Windows.Forms.Button();
            this.btnUpdateModTop = new System.Windows.Forms.Button();
            this.btnListModTop = new System.Windows.Forms.Button();
            this.btnAddModTop = new System.Windows.Forms.Button();
            this.cmbTopicDes = new System.Windows.Forms.ComboBox();
            this.cmbModDes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(392, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Role";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvView);
            this.groupBox1.Location = new System.Drawing.Point(6, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Information";
            // 
            // dgvView
            // 
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(6, 19);
            this.dgvView.Name = "dgvView";
            this.dgvView.Size = new System.Drawing.Size(803, 126);
            this.dgvView.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(554, 34);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Role";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(473, 34);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "List Role";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(651, 34);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Role";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(747, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<<<Sign Out";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter RoleDescription:";
            // 
            // cmbRoleDescription
            // 
            this.cmbRoleDescription.FormattingEnabled = true;
            this.cmbRoleDescription.Location = new System.Drawing.Point(172, 36);
            this.cmbRoleDescription.Name = "cmbRoleDescription";
            this.cmbRoleDescription.Size = new System.Drawing.Size(205, 21);
            this.cmbRoleDescription.TabIndex = 7;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(347, 9);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(0, 13);
            this.lblAccount.TabIndex = 8;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRegister.Location = new System.Drawing.Point(44, 10);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(122, 23);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Click here to Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter Programming Language:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteTopic);
            this.groupBox2.Controls.Add(this.btnUpdateTopic);
            this.groupBox2.Controls.Add(this.btnViewTopic);
            this.groupBox2.Controls.Add(this.btnAddTopic);
            this.groupBox2.Controls.Add(this.txtTopic);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnDeleteYear);
            this.groupBox2.Controls.Add(this.btnUpdateYear);
            this.groupBox2.Controls.Add(this.btnViewYear);
            this.groupBox2.Controls.Add(this.btnYear);
            this.groupBox2.Controls.Add(this.cmbYear);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtProgLang);
            this.groupBox2.Controls.Add(this.btnDeleteLang);
            this.groupBox2.Controls.Add(this.btnUpdateLanguage);
            this.groupBox2.Controls.Add(this.btnViewLanguage);
            this.groupBox2.Controls.Add(this.btnAddLanguage);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnRegister);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbRoleDescription);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnList);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(12, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 162);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Admin";
            // 
            // btnDeleteTopic
            // 
            this.btnDeleteTopic.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDeleteTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTopic.Location = new System.Drawing.Point(651, 135);
            this.btnDeleteTopic.Name = "btnDeleteTopic";
            this.btnDeleteTopic.Size = new System.Drawing.Size(76, 23);
            this.btnDeleteTopic.TabIndex = 29;
            this.btnDeleteTopic.Text = "Delete Topic";
            this.btnDeleteTopic.UseVisualStyleBackColor = false;
            this.btnDeleteTopic.Click += new System.EventHandler(this.btnDeleteTopic_Click);
            // 
            // btnUpdateTopic
            // 
            this.btnUpdateTopic.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnUpdateTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTopic.Location = new System.Drawing.Point(554, 136);
            this.btnUpdateTopic.Name = "btnUpdateTopic";
            this.btnUpdateTopic.Size = new System.Drawing.Size(91, 23);
            this.btnUpdateTopic.TabIndex = 28;
            this.btnUpdateTopic.Text = "Update Topic";
            this.btnUpdateTopic.UseVisualStyleBackColor = false;
            this.btnUpdateTopic.Click += new System.EventHandler(this.btnUpdateTopic_Click);
            // 
            // btnViewTopic
            // 
            this.btnViewTopic.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnViewTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTopic.Location = new System.Drawing.Point(473, 136);
            this.btnViewTopic.Name = "btnViewTopic";
            this.btnViewTopic.Size = new System.Drawing.Size(76, 23);
            this.btnViewTopic.TabIndex = 27;
            this.btnViewTopic.Text = "View Topic";
            this.btnViewTopic.UseVisualStyleBackColor = false;
            this.btnViewTopic.Click += new System.EventHandler(this.btnViewTopic_Click);
            // 
            // btnAddTopic
            // 
            this.btnAddTopic.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAddTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTopic.Location = new System.Drawing.Point(392, 136);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.Size = new System.Drawing.Size(75, 23);
            this.btnAddTopic.TabIndex = 26;
            this.btnAddTopic.Text = "Add Topic";
            this.btnAddTopic.UseVisualStyleBackColor = false;
            this.btnAddTopic.Click += new System.EventHandler(this.btnAddTopic_Click);
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(172, 136);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(205, 20);
            this.txtTopic.TabIndex = 25;
            this.txtTopic.Validating += new System.ComponentModel.CancelEventHandler(this.txtTopic_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Enter Topic:";
            // 
            // btnDeleteYear
            // 
            this.btnDeleteYear.BackColor = System.Drawing.Color.Orchid;
            this.btnDeleteYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteYear.Location = new System.Drawing.Point(651, 103);
            this.btnDeleteYear.Name = "btnDeleteYear";
            this.btnDeleteYear.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteYear.TabIndex = 23;
            this.btnDeleteYear.Text = "Delete Year";
            this.btnDeleteYear.UseVisualStyleBackColor = false;
            this.btnDeleteYear.Click += new System.EventHandler(this.btnDeleteYear_Click);
            // 
            // btnUpdateYear
            // 
            this.btnUpdateYear.BackColor = System.Drawing.Color.Orchid;
            this.btnUpdateYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateYear.Location = new System.Drawing.Point(555, 103);
            this.btnUpdateYear.Name = "btnUpdateYear";
            this.btnUpdateYear.Size = new System.Drawing.Size(90, 23);
            this.btnUpdateYear.TabIndex = 22;
            this.btnUpdateYear.Text = "Update Year";
            this.btnUpdateYear.UseVisualStyleBackColor = false;
            this.btnUpdateYear.Click += new System.EventHandler(this.btnUpdateYear_Click);
            // 
            // btnViewYear
            // 
            this.btnViewYear.BackColor = System.Drawing.Color.Orchid;
            this.btnViewYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewYear.Location = new System.Drawing.Point(474, 103);
            this.btnViewYear.Name = "btnViewYear";
            this.btnViewYear.Size = new System.Drawing.Size(75, 23);
            this.btnViewYear.TabIndex = 21;
            this.btnViewYear.Text = "View Year";
            this.btnViewYear.UseVisualStyleBackColor = false;
            this.btnViewYear.Click += new System.EventHandler(this.btnViewYear_Click);
            // 
            // btnYear
            // 
            this.btnYear.BackColor = System.Drawing.Color.Orchid;
            this.btnYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYear.Location = new System.Drawing.Point(392, 103);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(75, 23);
            this.btnYear.TabIndex = 20;
            this.btnYear.Text = "Add Year";
            this.btnYear.UseVisualStyleBackColor = false;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(172, 106);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(205, 21);
            this.cmbYear.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Enter Year Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            // 
            // txtProgLang
            // 
            this.txtProgLang.Location = new System.Drawing.Point(172, 74);
            this.txtProgLang.Name = "txtProgLang";
            this.txtProgLang.Size = new System.Drawing.Size(205, 20);
            this.txtProgLang.TabIndex = 16;
            this.txtProgLang.Validating += new System.ComponentModel.CancelEventHandler(this.txtProgLang_Validating);
            // 
            // btnDeleteLang
            // 
            this.btnDeleteLang.BackColor = System.Drawing.Color.Thistle;
            this.btnDeleteLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLang.Location = new System.Drawing.Point(651, 74);
            this.btnDeleteLang.Name = "btnDeleteLang";
            this.btnDeleteLang.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteLang.TabIndex = 15;
            this.btnDeleteLang.Text = "Delete";
            this.btnDeleteLang.UseVisualStyleBackColor = false;
            this.btnDeleteLang.Click += new System.EventHandler(this.btnDeleteLang_Click);
            // 
            // btnUpdateLanguage
            // 
            this.btnUpdateLanguage.BackColor = System.Drawing.Color.Thistle;
            this.btnUpdateLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLanguage.Location = new System.Drawing.Point(554, 74);
            this.btnUpdateLanguage.Name = "btnUpdateLanguage";
            this.btnUpdateLanguage.Size = new System.Drawing.Size(91, 23);
            this.btnUpdateLanguage.TabIndex = 14;
            this.btnUpdateLanguage.Text = "Update";
            this.btnUpdateLanguage.UseVisualStyleBackColor = false;
            this.btnUpdateLanguage.Click += new System.EventHandler(this.btnUpdateLanguage_Click);
            // 
            // btnViewLanguage
            // 
            this.btnViewLanguage.BackColor = System.Drawing.Color.Thistle;
            this.btnViewLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLanguage.Location = new System.Drawing.Point(474, 74);
            this.btnViewLanguage.Name = "btnViewLanguage";
            this.btnViewLanguage.Size = new System.Drawing.Size(75, 23);
            this.btnViewLanguage.TabIndex = 13;
            this.btnViewLanguage.Text = "View";
            this.btnViewLanguage.UseVisualStyleBackColor = false;
            this.btnViewLanguage.Click += new System.EventHandler(this.btnViewLanguage_Click);
            // 
            // btnAddLanguage
            // 
            this.btnAddLanguage.BackColor = System.Drawing.Color.Thistle;
            this.btnAddLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLanguage.Location = new System.Drawing.Point(392, 74);
            this.btnAddLanguage.Name = "btnAddLanguage";
            this.btnAddLanguage.Size = new System.Drawing.Size(75, 23);
            this.btnAddLanguage.TabIndex = 12;
            this.btnAddLanguage.Text = "Add";
            this.btnAddLanguage.UseVisualStyleBackColor = false;
            this.btnAddLanguage.Click += new System.EventHandler(this.btnAddLanguage_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeleteMod);
            this.groupBox3.Controls.Add(this.btnUpdateMod);
            this.groupBox3.Controls.Add(this.btnViewMod);
            this.groupBox3.Controls.Add(this.btnAddMod);
            this.groupBox3.Controls.Add(this.cmbYearDescription);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtModuleDes);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(404, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 145);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enter Module Information";
            // 
            // btnDeleteMod
            // 
            this.btnDeleteMod.BackColor = System.Drawing.Color.DeepPink;
            this.btnDeleteMod.Location = new System.Drawing.Point(309, 116);
            this.btnDeleteMod.Name = "btnDeleteMod";
            this.btnDeleteMod.Size = new System.Drawing.Size(86, 23);
            this.btnDeleteMod.TabIndex = 41;
            this.btnDeleteMod.Text = "Delete Module";
            this.btnDeleteMod.UseVisualStyleBackColor = false;
            this.btnDeleteMod.Click += new System.EventHandler(this.btnDeleteMod_Click);
            // 
            // btnUpdateMod
            // 
            this.btnUpdateMod.BackColor = System.Drawing.Color.DeepPink;
            this.btnUpdateMod.Location = new System.Drawing.Point(225, 78);
            this.btnUpdateMod.Name = "btnUpdateMod";
            this.btnUpdateMod.Size = new System.Drawing.Size(88, 23);
            this.btnUpdateMod.TabIndex = 40;
            this.btnUpdateMod.Text = "Update Module";
            this.btnUpdateMod.UseVisualStyleBackColor = false;
            this.btnUpdateMod.Click += new System.EventHandler(this.btnUpdateMod_Click);
            // 
            // btnViewMod
            // 
            this.btnViewMod.BackColor = System.Drawing.Color.DeepPink;
            this.btnViewMod.Location = new System.Drawing.Point(309, 49);
            this.btnViewMod.Name = "btnViewMod";
            this.btnViewMod.Size = new System.Drawing.Size(86, 23);
            this.btnViewMod.TabIndex = 39;
            this.btnViewMod.Text = "View Module";
            this.btnViewMod.UseVisualStyleBackColor = false;
            this.btnViewMod.Click += new System.EventHandler(this.btnViewMod_Click);
            // 
            // btnAddMod
            // 
            this.btnAddMod.BackColor = System.Drawing.Color.DeepPink;
            this.btnAddMod.Location = new System.Drawing.Point(225, 20);
            this.btnAddMod.Name = "btnAddMod";
            this.btnAddMod.Size = new System.Drawing.Size(88, 23);
            this.btnAddMod.TabIndex = 38;
            this.btnAddMod.Text = "Add Module";
            this.btnAddMod.UseVisualStyleBackColor = false;
            this.btnAddMod.Click += new System.EventHandler(this.btnAddMod_Click);
            // 
            // cmbYearDescription
            // 
            this.cmbYearDescription.FormattingEnabled = true;
            this.cmbYearDescription.Location = new System.Drawing.Point(12, 87);
            this.cmbYearDescription.Name = "cmbYearDescription";
            this.cmbYearDescription.Size = new System.Drawing.Size(202, 21);
            this.cmbYearDescription.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Enter Year Description:";
            // 
            // txtModuleDes
            // 
            this.txtModuleDes.Location = new System.Drawing.Point(9, 43);
            this.txtModuleDes.Name = "txtModuleDes";
            this.txtModuleDes.Size = new System.Drawing.Size(205, 20);
            this.txtModuleDes.TabIndex = 35;
            this.txtModuleDes.Validating += new System.ComponentModel.CancelEventHandler(this.txtModuleDes_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Enter Module Description:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReport);
            this.groupBox4.Controls.Add(this.btnDeleteModTop);
            this.groupBox4.Controls.Add(this.btnUpdateModTop);
            this.groupBox4.Controls.Add(this.btnListModTop);
            this.groupBox4.Controls.Add(this.btnAddModTop);
            this.groupBox4.Controls.Add(this.cmbTopicDes);
            this.groupBox4.Controls.Add(this.cmbModDes);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(12, 172);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(386, 159);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ModuleTopic Information";
            // 
            // btnDeleteModTop
            // 
            this.btnDeleteModTop.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDeleteModTop.Location = new System.Drawing.Point(302, 130);
            this.btnDeleteModTop.Name = "btnDeleteModTop";
            this.btnDeleteModTop.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteModTop.TabIndex = 7;
            this.btnDeleteModTop.Text = "Delete";
            this.btnDeleteModTop.UseVisualStyleBackColor = false;
            this.btnDeleteModTop.Click += new System.EventHandler(this.btnDeleteModTop_Click);
            // 
            // btnUpdateModTop
            // 
            this.btnUpdateModTop.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnUpdateModTop.Location = new System.Drawing.Point(202, 130);
            this.btnUpdateModTop.Name = "btnUpdateModTop";
            this.btnUpdateModTop.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateModTop.TabIndex = 6;
            this.btnUpdateModTop.Text = "Update";
            this.btnUpdateModTop.UseVisualStyleBackColor = false;
            this.btnUpdateModTop.Click += new System.EventHandler(this.btnUpdateModTop_Click);
            // 
            // btnListModTop
            // 
            this.btnListModTop.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnListModTop.Location = new System.Drawing.Point(106, 130);
            this.btnListModTop.Name = "btnListModTop";
            this.btnListModTop.Size = new System.Drawing.Size(75, 23);
            this.btnListModTop.TabIndex = 5;
            this.btnListModTop.Text = "List";
            this.btnListModTop.UseVisualStyleBackColor = false;
            this.btnListModTop.Click += new System.EventHandler(this.btnListModTop_Click);
            // 
            // btnAddModTop
            // 
            this.btnAddModTop.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnAddModTop.Location = new System.Drawing.Point(9, 130);
            this.btnAddModTop.Name = "btnAddModTop";
            this.btnAddModTop.Size = new System.Drawing.Size(75, 23);
            this.btnAddModTop.TabIndex = 4;
            this.btnAddModTop.Text = "Add";
            this.btnAddModTop.UseVisualStyleBackColor = false;
            this.btnAddModTop.Click += new System.EventHandler(this.btnAddModTop_Click);
            // 
            // cmbTopicDes
            // 
            this.cmbTopicDes.FormattingEnabled = true;
            this.cmbTopicDes.Location = new System.Drawing.Point(172, 83);
            this.cmbTopicDes.Name = "cmbTopicDes";
            this.cmbTopicDes.Size = new System.Drawing.Size(184, 21);
            this.cmbTopicDes.TabIndex = 3;
            // 
            // cmbModDes
            // 
            this.cmbModDes.FormattingEnabled = true;
            this.cmbModDes.Location = new System.Drawing.Point(172, 49);
            this.cmbModDes.Name = "cmbModDes";
            this.cmbModDes.Size = new System.Drawing.Size(184, 21);
            this.cmbModDes.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Topic Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Module Description:";
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.Fuchsia;
            this.btnPdf.Location = new System.Drawing.Point(765, 40);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(57, 59);
            this.btnPdf.TabIndex = 36;
            this.btnPdf.Text = "Print Report as PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnReport.Location = new System.Drawing.Point(281, 19);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "Reports";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(827, 491);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoleDescription;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteLang;
        private System.Windows.Forms.Button btnUpdateLanguage;
        private System.Windows.Forms.Button btnViewLanguage;
        private System.Windows.Forms.Button btnAddLanguage;
        private System.Windows.Forms.TextBox txtProgLang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteYear;
        private System.Windows.Forms.Button btnUpdateYear;
        private System.Windows.Forms.Button btnViewYear;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteTopic;
        private System.Windows.Forms.Button btnUpdateTopic;
        private System.Windows.Forms.Button btnViewTopic;
        private System.Windows.Forms.Button btnAddTopic;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeleteMod;
        private System.Windows.Forms.Button btnUpdateMod;
        private System.Windows.Forms.Button btnViewMod;
        private System.Windows.Forms.Button btnAddMod;
        private System.Windows.Forms.ComboBox cmbYearDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModuleDes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeleteModTop;
        private System.Windows.Forms.Button btnUpdateModTop;
        private System.Windows.Forms.Button btnListModTop;
        private System.Windows.Forms.Button btnAddModTop;
        private System.Windows.Forms.ComboBox cmbTopicDes;
        private System.Windows.Forms.ComboBox cmbModDes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
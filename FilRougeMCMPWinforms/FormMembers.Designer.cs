
namespace FilRougeMCMPWinforms
{
    partial class FormMembers
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
            this.mcmpDataSet = new FilRougeMCMPWinforms.mcmpDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new FilRougeMCMPWinforms.mcmpDataSetTableAdapters.usersTableAdapter();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnResetSelection = new System.Windows.Forms.Button();
            this.dateTimePickerDoBLimitEnd = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerDoBlimitbeginning = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFilterMembers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isactiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.remembertokenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilepicDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isorganizerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxStreetNr = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTelephoneNr = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.BtnProfilePic = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxIsOrganizer = new System.Windows.Forms.CheckBox();
            this.pictureBoxUserProfilePic = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mcmpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // mcmpDataSet
            // 
            this.mcmpDataSet.DataSetName = "mcmpDataSet";
            this.mcmpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.mcmpDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.btnResetSelection, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.dateTimePickerDoBLimitEnd, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.label13, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.dateTimePickerDoBlimitbeginning, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxFilterMembers, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(923, 76);
            this.tableLayoutPanel4.TabIndex = 16;
            // 
            // btnResetSelection
            // 
            this.btnResetSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnResetSelection.Location = new System.Drawing.Point(799, 25);
            this.btnResetSelection.Name = "btnResetSelection";
            this.btnResetSelection.Size = new System.Drawing.Size(121, 26);
            this.btnResetSelection.TabIndex = 15;
            this.btnResetSelection.Text = "&Rétablir";
            this.btnResetSelection.UseVisualStyleBackColor = true;
            this.btnResetSelection.Click += new System.EventHandler(this.btnResetSelection_Click);
            // 
            // dateTimePickerDoBLimitEnd
            // 
            this.dateTimePickerDoBLimitEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDoBLimitEnd.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerDoBLimitEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerDoBLimitEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDoBLimitEnd.Location = new System.Drawing.Point(675, 25);
            this.dateTimePickerDoBLimitEnd.MinDate = new System.DateTime(2022, 2, 17, 0, 0, 0, 0);
            this.dateTimePickerDoBLimitEnd.Name = "dateTimePickerDoBLimitEnd";
            this.dateTimePickerDoBLimitEnd.Size = new System.Drawing.Size(118, 26);
            this.dateTimePickerDoBLimitEnd.TabIndex = 19;
            this.dateTimePickerDoBLimitEnd.ValueChanged += new System.EventHandler(this.dateTimePickerDoBLimitEnd_ValueChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(644, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "et";
            // 
            // dateTimePickerDoBlimitbeginning
            // 
            this.dateTimePickerDoBlimitbeginning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDoBlimitbeginning.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerDoBlimitbeginning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerDoBlimitbeginning.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDoBlimitbeginning.Location = new System.Drawing.Point(520, 25);
            this.dateTimePickerDoBlimitbeginning.MaxDate = new System.DateTime(2022, 2, 17, 0, 0, 0, 0);
            this.dateTimePickerDoBlimitbeginning.Name = "dateTimePickerDoBlimitbeginning";
            this.dateTimePickerDoBlimitbeginning.Size = new System.Drawing.Size(118, 26);
            this.dateTimePickerDoBlimitbeginning.TabIndex = 17;
            this.dateTimePickerDoBlimitbeginning.Value = new System.DateTime(2022, 2, 17, 0, 0, 0, 0);
            this.dateTimePickerDoBlimitbeginning.ValueChanged += new System.EventHandler(this.dateTimePickerDoBlimitbeginning_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(325, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Date de naissance entre";
            // 
            // textBoxFilterMembers
            // 
            this.textBoxFilterMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFilterMembers.Location = new System.Drawing.Point(201, 25);
            this.textBoxFilterMembers.Name = "textBoxFilterMembers";
            this.textBoxFilterMembers.Size = new System.Drawing.Size(118, 26);
            this.textBoxFilterMembers.TabIndex = 14;
            this.textBoxFilterMembers.TextChanged += new System.EventHandler(this.textBoxFilterMembers_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rechercher un adhérent : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(3, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 316);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des adhérents :";
            // 
            // isactiveDataGridViewCheckBoxColumn
            // 
            this.isactiveDataGridViewCheckBoxColumn.DataPropertyName = "is_active";
            this.isactiveDataGridViewCheckBoxColumn.HeaderText = "is_active";
            this.isactiveDataGridViewCheckBoxColumn.Name = "isactiveDataGridViewCheckBoxColumn";
            this.isactiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isactiveDataGridViewCheckBoxColumn.Visible = false;
            // 
            // remembertokenDataGridViewTextBoxColumn
            // 
            this.remembertokenDataGridViewTextBoxColumn.DataPropertyName = "remember_token";
            this.remembertokenDataGridViewTextBoxColumn.HeaderText = "remember_token";
            this.remembertokenDataGridViewTextBoxColumn.Name = "remembertokenDataGridViewTextBoxColumn";
            this.remembertokenDataGridViewTextBoxColumn.ReadOnly = true;
            this.remembertokenDataGridViewTextBoxColumn.Visible = false;
            // 
            // updatedatDataGridViewTextBoxColumn
            // 
            this.updatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.HeaderText = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.Name = "updatedatDataGridViewTextBoxColumn";
            this.updatedatDataGridViewTextBoxColumn.ReadOnly = true;
            this.updatedatDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdatDataGridViewTextBoxColumn.Visible = false;
            // 
            // telephonenumberDataGridViewTextBoxColumn
            // 
            this.telephonenumberDataGridViewTextBoxColumn.DataPropertyName = "telephone_number";
            this.telephonenumberDataGridViewTextBoxColumn.HeaderText = "telephone_number";
            this.telephonenumberDataGridViewTextBoxColumn.Name = "telephonenumberDataGridViewTextBoxColumn";
            this.telephonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.telephonenumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryDataGridViewTextBoxColumn.Visible = false;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Visible = false;
            // 
            // zipcodeDataGridViewTextBoxColumn
            // 
            this.zipcodeDataGridViewTextBoxColumn.DataPropertyName = "zip_code";
            this.zipcodeDataGridViewTextBoxColumn.HeaderText = "zip_code";
            this.zipcodeDataGridViewTextBoxColumn.Name = "zipcodeDataGridViewTextBoxColumn";
            this.zipcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.zipcodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // streetnameDataGridViewTextBoxColumn
            // 
            this.streetnameDataGridViewTextBoxColumn.DataPropertyName = "street_name";
            this.streetnameDataGridViewTextBoxColumn.HeaderText = "street_name";
            this.streetnameDataGridViewTextBoxColumn.Name = "streetnameDataGridViewTextBoxColumn";
            this.streetnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // streetnumberDataGridViewTextBoxColumn
            // 
            this.streetnumberDataGridViewTextBoxColumn.DataPropertyName = "street_number";
            this.streetnumberDataGridViewTextBoxColumn.HeaderText = "street_number";
            this.streetnumberDataGridViewTextBoxColumn.Name = "streetnumberDataGridViewTextBoxColumn";
            this.streetnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetnumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // profilepicDataGridViewImageColumn
            // 
            this.profilepicDataGridViewImageColumn.DataPropertyName = "profile_pic";
            this.profilepicDataGridViewImageColumn.HeaderText = "profile_pic";
            this.profilepicDataGridViewImageColumn.Name = "profilepicDataGridViewImageColumn";
            this.profilepicDataGridViewImageColumn.ReadOnly = true;
            this.profilepicDataGridViewImageColumn.Visible = false;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.ReadOnly = true;
            this.dobDataGridViewTextBoxColumn.Visible = false;
            // 
            // isorganizerDataGridViewCheckBoxColumn
            // 
            this.isorganizerDataGridViewCheckBoxColumn.DataPropertyName = "is_organizer";
            this.isorganizerDataGridViewCheckBoxColumn.HeaderText = "is_organizer";
            this.isorganizerDataGridViewCheckBoxColumn.Name = "isorganizerDataGridViewCheckBoxColumn";
            this.isorganizerDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isorganizerDataGridViewCheckBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 119.797F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.FillWeight = 119.797F;
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 119.797F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 40.60914F;
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.isorganizerDataGridViewCheckBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.profilepicDataGridViewImageColumn,
            this.streetnumberDataGridViewTextBoxColumn,
            this.streetnameDataGridViewTextBoxColumn,
            this.zipcodeDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.telephonenumberDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.updatedatDataGridViewTextBoxColumn,
            this.remembertokenDataGridViewTextBoxColumn,
            this.isactiveDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(917, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnUpdate, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.06135F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.5092F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.78527F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.521472F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(929, 815);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dateTimePickerDOB, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.textBoxStreetNr, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBoxAddress, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBoxZipCode, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.textBoxCity, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.textFirstName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxEmail, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxTelephoneNr, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxCountry, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxIsActive, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnProfilePic, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxIsOrganizer, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxUserProfilePic, 2, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 407);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(923, 359);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDOB.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerDOB.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usersBindingSource, "dob", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(104, 103);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(291, 26);
            this.dateTimePickerDOB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(17, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date de naissance";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(24, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "N° de rue";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(30, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(4, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Code postal";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(60, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ville";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(55, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Pays";
            // 
            // textBoxStreetNr
            // 
            this.textBoxStreetNr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "street_number", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxStreetNr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStreetNr.Location = new System.Drawing.Point(104, 139);
            this.textBoxStreetNr.Name = "textBoxStreetNr";
            this.textBoxStreetNr.Size = new System.Drawing.Size(291, 26);
            this.textBoxStreetNr.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "street_name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAddress.Location = new System.Drawing.Point(104, 171);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(291, 26);
            this.textBoxAddress.TabIndex = 6;
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "zip_code", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxZipCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxZipCode.Location = new System.Drawing.Point(104, 203);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(291, 26);
            this.textBoxZipCode.TabIndex = 7;
            // 
            // textBoxCity
            // 
            this.textBoxCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "city", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCity.Location = new System.Drawing.Point(104, 235);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(291, 26);
            this.textBoxCity.TabIndex = 8;
            // 
            // textFirstName
            // 
            this.textFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "firstname", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textFirstName.Location = new System.Drawing.Point(104, 35);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(291, 26);
            this.textFirstName.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "email", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEmail.Location = new System.Drawing.Point(104, 67);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(291, 26);
            this.textBoxEmail.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(56, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nom";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(34, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Prénom";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(50, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Email";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(461, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Numéro de téléphone";
            // 
            // textBoxTelephoneNr
            // 
            this.textBoxTelephoneNr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "telephone_number", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxTelephoneNr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTelephoneNr.Location = new System.Drawing.Point(629, 3);
            this.textBoxTelephoneNr.Name = "textBoxTelephoneNr";
            this.textBoxTelephoneNr.Size = new System.Drawing.Size(291, 26);
            this.textBoxTelephoneNr.TabIndex = 10;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "country", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxCountry.Location = new System.Drawing.Point(104, 298);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(291, 26);
            this.textBoxCountry.TabIndex = 9;
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersBindingSource, "is_active", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.checkBoxIsActive.Location = new System.Drawing.Point(629, 67);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(88, 24);
            this.checkBoxIsActive.TabIndex = 13;
            this.checkBoxIsActive.Text = "Est Actif";
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // BtnProfilePic
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.BtnProfilePic, 2);
            this.BtnProfilePic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnProfilePic.Location = new System.Drawing.Point(401, 99);
            this.BtnProfilePic.Name = "BtnProfilePic";
            this.BtnProfilePic.Size = new System.Drawing.Size(519, 34);
            this.BtnProfilePic.TabIndex = 21;
            this.BtnProfilePic.Text = "Ajouter/Changer la photo de profil";
            this.BtnProfilePic.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(104, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(291, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // checkBoxIsOrganizer
            // 
            this.checkBoxIsOrganizer.AutoSize = true;
            this.checkBoxIsOrganizer.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersBindingSource, "is_organizer", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.checkBoxIsOrganizer.Location = new System.Drawing.Point(629, 35);
            this.checkBoxIsOrganizer.Name = "checkBoxIsOrganizer";
            this.checkBoxIsOrganizer.Size = new System.Drawing.Size(212, 24);
            this.checkBoxIsOrganizer.TabIndex = 12;
            this.checkBoxIsOrganizer.Text = "Est un membre du bureau";
            this.checkBoxIsOrganizer.UseVisualStyleBackColor = true;
            // 
            // pictureBoxUserProfilePic
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.pictureBoxUserProfilePic, 2);
            this.pictureBoxUserProfilePic.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.usersBindingSource, "profile_pic", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.pictureBoxUserProfilePic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxUserProfilePic.Location = new System.Drawing.Point(401, 139);
            this.pictureBoxUserProfilePic.Name = "pictureBoxUserProfilePic";
            this.tableLayoutPanel2.SetRowSpan(this.pictureBoxUserProfilePic, 5);
            this.pictureBoxUserProfilePic.Size = new System.Drawing.Size(519, 217);
            this.pictureBoxUserProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUserProfilePic.TabIndex = 22;
            this.pictureBoxUserProfilePic.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(3, 772);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(923, 40);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "&Enregistrer les modifications";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // FormMembers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(929, 815);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMembers";
            this.Text = "Form Members";
            this.Load += new System.EventHandler(this.FormMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mcmpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private mcmpDataSet mcmpDataSet;
        private mcmpDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnResetSelection;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoBLimitEnd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoBlimitbeginning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFilterMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isorganizerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn profilepicDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remembertokenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isactiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxStreetNr;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxTelephoneNr;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.Button BtnProfilePic;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxIsOrganizer;
        private System.Windows.Forms.PictureBox pictureBoxUserProfilePic;
    }
}
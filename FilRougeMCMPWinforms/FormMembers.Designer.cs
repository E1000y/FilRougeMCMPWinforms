
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isorganizerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilepicDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.streetnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remembertokenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isactiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxIsOrganizer = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.textBoxTelephoneNr = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.usersTableAdapter = new FilRougeMCMPWinforms.mcmpDataSetTableAdapters.usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mcmpDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcmpDataSet
            // 
            this.mcmpDataSet.DataSetName = "mcmpDataSet";
            this.mcmpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.448276F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.34483F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.37931F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.103448F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(798, 725);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.dateTimePicker1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(792, 47);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rechercher un adhérent : ";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(141, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(334, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Date de naissance";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker1.Location = new System.Drawing.Point(517, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 690);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(792, 32);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(3, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "&Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 300);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des adhérents :";
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(786, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 40.60914F;
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 119.797F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.FillWeight = 119.797F;
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 119.797F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isorganizerDataGridViewCheckBoxColumn
            // 
            this.isorganizerDataGridViewCheckBoxColumn.DataPropertyName = "is_organizer";
            this.isorganizerDataGridViewCheckBoxColumn.HeaderText = "is_organizer";
            this.isorganizerDataGridViewCheckBoxColumn.Name = "isorganizerDataGridViewCheckBoxColumn";
            this.isorganizerDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isorganizerDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.ReadOnly = true;
            this.dobDataGridViewTextBoxColumn.Visible = false;
            // 
            // profilepicDataGridViewImageColumn
            // 
            this.profilepicDataGridViewImageColumn.DataPropertyName = "profile_pic";
            this.profilepicDataGridViewImageColumn.HeaderText = "profile_pic";
            this.profilepicDataGridViewImageColumn.Name = "profilepicDataGridViewImageColumn";
            this.profilepicDataGridViewImageColumn.ReadOnly = true;
            this.profilepicDataGridViewImageColumn.Visible = false;
            // 
            // streetnumberDataGridViewTextBoxColumn
            // 
            this.streetnumberDataGridViewTextBoxColumn.DataPropertyName = "street_number";
            this.streetnumberDataGridViewTextBoxColumn.HeaderText = "street_number";
            this.streetnumberDataGridViewTextBoxColumn.Name = "streetnumberDataGridViewTextBoxColumn";
            this.streetnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetnumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // streetnameDataGridViewTextBoxColumn
            // 
            this.streetnameDataGridViewTextBoxColumn.DataPropertyName = "street_name";
            this.streetnameDataGridViewTextBoxColumn.HeaderText = "street_name";
            this.streetnameDataGridViewTextBoxColumn.Name = "streetnameDataGridViewTextBoxColumn";
            this.streetnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // zipcodeDataGridViewTextBoxColumn
            // 
            this.zipcodeDataGridViewTextBoxColumn.DataPropertyName = "zip_code";
            this.zipcodeDataGridViewTextBoxColumn.HeaderText = "zip_code";
            this.zipcodeDataGridViewTextBoxColumn.Name = "zipcodeDataGridViewTextBoxColumn";
            this.zipcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.zipcodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Visible = false;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryDataGridViewTextBoxColumn.Visible = false;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // telephonenumberDataGridViewTextBoxColumn
            // 
            this.telephonenumberDataGridViewTextBoxColumn.DataPropertyName = "telephone_number";
            this.telephonenumberDataGridViewTextBoxColumn.HeaderText = "telephone_number";
            this.telephonenumberDataGridViewTextBoxColumn.Name = "telephonenumberDataGridViewTextBoxColumn";
            this.telephonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.telephonenumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdatDataGridViewTextBoxColumn.Visible = false;
            // 
            // updatedatDataGridViewTextBoxColumn
            // 
            this.updatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.HeaderText = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.Name = "updatedatDataGridViewTextBoxColumn";
            this.updatedatDataGridViewTextBoxColumn.ReadOnly = true;
            this.updatedatDataGridViewTextBoxColumn.Visible = false;
            // 
            // remembertokenDataGridViewTextBoxColumn
            // 
            this.remembertokenDataGridViewTextBoxColumn.DataPropertyName = "remember_token";
            this.remembertokenDataGridViewTextBoxColumn.HeaderText = "remember_token";
            this.remembertokenDataGridViewTextBoxColumn.Name = "remembertokenDataGridViewTextBoxColumn";
            this.remembertokenDataGridViewTextBoxColumn.ReadOnly = true;
            this.remembertokenDataGridViewTextBoxColumn.Visible = false;
            // 
            // isactiveDataGridViewCheckBoxColumn
            // 
            this.isactiveDataGridViewCheckBoxColumn.DataPropertyName = "is_active";
            this.isactiveDataGridViewCheckBoxColumn.HeaderText = "is_active";
            this.isactiveDataGridViewCheckBoxColumn.Name = "isactiveDataGridViewCheckBoxColumn";
            this.isactiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isactiveDataGridViewCheckBoxColumn.Visible = false;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.mcmpDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(792, 322);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Détail d\'un adhérent";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
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
            this.tableLayoutPanel2.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textFirstName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxEmail, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxIsOrganizer, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxIsActive, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBoxTelephoneNr, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxCountry, 1, 8);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 231);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerDOB.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerDOB.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usersBindingSource, "dob", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(105, 81);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDOB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date de naissance";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "N° de rue";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Code postal";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ville";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Pays";
            // 
            // textBoxStreetNr
            // 
            this.textBoxStreetNr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxStreetNr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "street_number", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxStreetNr.Location = new System.Drawing.Point(105, 107);
            this.textBoxStreetNr.Name = "textBoxStreetNr";
            this.textBoxStreetNr.Size = new System.Drawing.Size(100, 20);
            this.textBoxStreetNr.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "street_name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxAddress.Location = new System.Drawing.Point(105, 133);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(257, 20);
            this.textBoxAddress.TabIndex = 6;
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxZipCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "zip_code", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxZipCode.Location = new System.Drawing.Point(105, 159);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxZipCode.TabIndex = 7;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "city", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxCity.Location = new System.Drawing.Point(105, 185);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxName.Location = new System.Drawing.Point(105, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textFirstName
            // 
            this.textFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "firstname", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textFirstName.Location = new System.Drawing.Point(105, 29);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(100, 20);
            this.textFirstName.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "email", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxEmail.Location = new System.Drawing.Point(105, 55);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nom";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Prénom";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Email";
            // 
            // checkBoxIsOrganizer
            // 
            this.checkBoxIsOrganizer.AutoSize = true;
            this.checkBoxIsOrganizer.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersBindingSource, "is_organizer", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.checkBoxIsOrganizer.Location = new System.Drawing.Point(483, 81);
            this.checkBoxIsOrganizer.Name = "checkBoxIsOrganizer";
            this.checkBoxIsOrganizer.Size = new System.Drawing.Size(147, 17);
            this.checkBoxIsOrganizer.TabIndex = 12;
            this.checkBoxIsOrganizer.Text = "Est un membre du bureau";
            this.checkBoxIsOrganizer.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(368, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Numéro de téléphone";
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersBindingSource, "is_active", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.checkBoxIsActive.Location = new System.Drawing.Point(483, 107);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(65, 17);
            this.checkBoxIsActive.TabIndex = 13;
            this.checkBoxIsActive.Text = "Est Actif";
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // textBoxTelephoneNr
            // 
            this.textBoxTelephoneNr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "telephone_number", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxTelephoneNr.Location = new System.Drawing.Point(483, 3);
            this.textBoxTelephoneNr.Name = "textBoxTelephoneNr";
            this.textBoxTelephoneNr.Size = new System.Drawing.Size(147, 20);
            this.textBoxTelephoneNr.TabIndex = 10;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "country", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxCountry.Location = new System.Drawing.Point(105, 211);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountry.TabIndex = 9;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // FormMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 725);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(798, 725);
            this.Name = "FormMembers";
            this.Text = "Form Members";
            this.Load += new System.EventHandler(this.FormMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mcmpDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private mcmpDataSet mcmpDataSet;
        private mcmpDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.TextBox textBoxStreetNr;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.CheckBox checkBoxIsOrganizer;
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
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.TextBox textBoxTelephoneNr;
    }
}
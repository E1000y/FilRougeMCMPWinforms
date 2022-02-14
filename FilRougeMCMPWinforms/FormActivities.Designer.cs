
namespace FilRougeMCMPWinforms
{
    partial class FormActivities
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxFilterActivity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.OutingsGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idactivityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activitynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activitydescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activitydestinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activitygpspointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activitydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicletypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activitypicDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.activitydurationdaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mcmpDataSet = new FilRougeMCMPWinforms.mcmpDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxVehicleType = new System.Windows.Forms.TextBox();
            this.textBoxUserRate = new System.Windows.Forms.TextBox();
            this.textBoxGuestRate = new System.Windows.Forms.TextBox();
            this.textBoxActivityDurationDays = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBoxActivityImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.BtnAddActivity = new System.Windows.Forms.Button();
            this.BtnUpdateActivity = new System.Windows.Forms.Button();
            this.BtnDeleteActivity = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxGPS = new System.Windows.Forms.TextBox();
            this.dateTimePickerSearchActivity = new System.Windows.Forms.DateTimePicker();
            this.textBoxOrganizerName = new System.Windows.Forms.TextBox();
            this.usersOrganizersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNameActivity = new System.Windows.Forms.TextBox();
            this.dtpDateActivity = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.activityTableAdapter = new FilRougeMCMPWinforms.mcmpDataSetTableAdapters.activityTableAdapter();
            this.usersOrganizersTableAdapter = new FilRougeMCMPWinforms.mcmpDataSetTableAdapters.usersOrganizersTableAdapter();
            this.activityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.OutingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcmpDataSet)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActivityImage)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersOrganizersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.80723F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.19277F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 414F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxFilterActivity, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OutingsGroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDescription, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxVehicleType, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxUserRate, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGuestRate, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBoxActivityDurationDays, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerSearchActivity, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxOrganizerName, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNameActivity, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpDateActivity, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(798, 725);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxFilterActivity
            // 
            this.textBoxFilterActivity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxFilterActivity.Location = new System.Drawing.Point(125, 3);
            this.textBoxFilterActivity.Name = "textBoxFilterActivity";
            this.textBoxFilterActivity.Size = new System.Drawing.Size(255, 20);
            this.textBoxFilterActivity.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Recherchez une sortie";
            // 
            // OutingsGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.OutingsGroupBox, 3);
            this.OutingsGroupBox.Controls.Add(this.dataGridView1);
            this.OutingsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutingsGroupBox.Location = new System.Drawing.Point(3, 29);
            this.OutingsGroupBox.Name = "OutingsGroupBox";
            this.OutingsGroupBox.Size = new System.Drawing.Size(792, 132);
            this.OutingsGroupBox.TabIndex = 1;
            this.OutingsGroupBox.TabStop = false;
            this.OutingsGroupBox.Text = "Afficher les sorties";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idactivityDataGridViewTextBoxColumn,
            this.activitynameDataGridViewTextBoxColumn,
            this.activitydescriptionDataGridViewTextBoxColumn,
            this.activitydestinationDataGridViewTextBoxColumn,
            this.activitygpspointDataGridViewTextBoxColumn,
            this.activitydateDataGridViewTextBoxColumn,
            this.userrateDataGridViewTextBoxColumn,
            this.guestrateDataGridViewTextBoxColumn,
            this.vehicletypeDataGridViewTextBoxColumn,
            this.activitypicDataGridViewImageColumn,
            this.activitydurationdaysDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.activityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(786, 108);
            this.dataGridView1.TabIndex = 0;
            // 
            // idactivityDataGridViewTextBoxColumn
            // 
            this.idactivityDataGridViewTextBoxColumn.DataPropertyName = "id_activity";
            this.idactivityDataGridViewTextBoxColumn.FillWeight = 44.67005F;
            this.idactivityDataGridViewTextBoxColumn.HeaderText = "id Sortie";
            this.idactivityDataGridViewTextBoxColumn.Name = "idactivityDataGridViewTextBoxColumn";
            this.idactivityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activitynameDataGridViewTextBoxColumn
            // 
            this.activitynameDataGridViewTextBoxColumn.DataPropertyName = "activity_name";
            this.activitynameDataGridViewTextBoxColumn.FillWeight = 118.4433F;
            this.activitynameDataGridViewTextBoxColumn.HeaderText = "Nom de la Sortie";
            this.activitynameDataGridViewTextBoxColumn.Name = "activitynameDataGridViewTextBoxColumn";
            this.activitynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activitydescriptionDataGridViewTextBoxColumn
            // 
            this.activitydescriptionDataGridViewTextBoxColumn.DataPropertyName = "activity_description";
            this.activitydescriptionDataGridViewTextBoxColumn.HeaderText = "Description de la Sortie";
            this.activitydescriptionDataGridViewTextBoxColumn.Name = "activitydescriptionDataGridViewTextBoxColumn";
            this.activitydescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.activitydescriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // activitydestinationDataGridViewTextBoxColumn
            // 
            this.activitydestinationDataGridViewTextBoxColumn.DataPropertyName = "activity_destination";
            this.activitydestinationDataGridViewTextBoxColumn.HeaderText = "activity_destination";
            this.activitydestinationDataGridViewTextBoxColumn.Name = "activitydestinationDataGridViewTextBoxColumn";
            this.activitydestinationDataGridViewTextBoxColumn.ReadOnly = true;
            this.activitydestinationDataGridViewTextBoxColumn.Visible = false;
            // 
            // activitygpspointDataGridViewTextBoxColumn
            // 
            this.activitygpspointDataGridViewTextBoxColumn.DataPropertyName = "activity_gps_point";
            this.activitygpspointDataGridViewTextBoxColumn.HeaderText = "activity_gps_point";
            this.activitygpspointDataGridViewTextBoxColumn.Name = "activitygpspointDataGridViewTextBoxColumn";
            this.activitygpspointDataGridViewTextBoxColumn.ReadOnly = true;
            this.activitygpspointDataGridViewTextBoxColumn.Visible = false;
            // 
            // activitydateDataGridViewTextBoxColumn
            // 
            this.activitydateDataGridViewTextBoxColumn.DataPropertyName = "activity_date";
            this.activitydateDataGridViewTextBoxColumn.FillWeight = 118.4433F;
            this.activitydateDataGridViewTextBoxColumn.HeaderText = "Date de la Sortie";
            this.activitydateDataGridViewTextBoxColumn.Name = "activitydateDataGridViewTextBoxColumn";
            this.activitydateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userrateDataGridViewTextBoxColumn
            // 
            this.userrateDataGridViewTextBoxColumn.DataPropertyName = "user_rate";
            this.userrateDataGridViewTextBoxColumn.HeaderText = "user_rate";
            this.userrateDataGridViewTextBoxColumn.Name = "userrateDataGridViewTextBoxColumn";
            this.userrateDataGridViewTextBoxColumn.ReadOnly = true;
            this.userrateDataGridViewTextBoxColumn.Visible = false;
            // 
            // guestrateDataGridViewTextBoxColumn
            // 
            this.guestrateDataGridViewTextBoxColumn.DataPropertyName = "guest_rate";
            this.guestrateDataGridViewTextBoxColumn.HeaderText = "guest_rate";
            this.guestrateDataGridViewTextBoxColumn.Name = "guestrateDataGridViewTextBoxColumn";
            this.guestrateDataGridViewTextBoxColumn.ReadOnly = true;
            this.guestrateDataGridViewTextBoxColumn.Visible = false;
            // 
            // vehicletypeDataGridViewTextBoxColumn
            // 
            this.vehicletypeDataGridViewTextBoxColumn.DataPropertyName = "vehicle_type";
            this.vehicletypeDataGridViewTextBoxColumn.HeaderText = "vehicle_type";
            this.vehicletypeDataGridViewTextBoxColumn.Name = "vehicletypeDataGridViewTextBoxColumn";
            this.vehicletypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicletypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // activitypicDataGridViewImageColumn
            // 
            this.activitypicDataGridViewImageColumn.DataPropertyName = "activity_pic";
            this.activitypicDataGridViewImageColumn.HeaderText = "activity_pic";
            this.activitypicDataGridViewImageColumn.Name = "activitypicDataGridViewImageColumn";
            this.activitypicDataGridViewImageColumn.ReadOnly = true;
            this.activitypicDataGridViewImageColumn.Visible = false;
            // 
            // activitydurationdaysDataGridViewTextBoxColumn
            // 
            this.activitydurationdaysDataGridViewTextBoxColumn.DataPropertyName = "activity_duration_days";
            this.activitydurationdaysDataGridViewTextBoxColumn.HeaderText = "activity_duration_days";
            this.activitydurationdaysDataGridViewTextBoxColumn.Name = "activitydurationdaysDataGridViewTextBoxColumn";
            this.activitydurationdaysDataGridViewTextBoxColumn.ReadOnly = true;
            this.activitydurationdaysDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 118.4433F;
            this.idDataGridViewTextBoxColumn.HeaderText = "id de l\'Organisateur";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataMember = "activity";
            this.activityBindingSource.DataSource = this.mcmpDataSet;
            this.activityBindingSource.CurrentChanged += new System.EventHandler(this.activityBindingSource_CurrentChanged);
            // 
            // mcmpDataSet
            // 
            this.mcmpDataSet.DataSetName = "mcmpDataSet";
            this.mcmpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "type de véhicule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "tarif adhérents";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "tarif invités";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Durée de l\'activité";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Organisateur";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "activity_description", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxDescription.Location = new System.Drawing.Point(125, 219);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(255, 93);
            this.textBoxDescription.TabIndex = 10;
            // 
            // textBoxVehicleType
            // 
            this.textBoxVehicleType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "vehicle_type", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxVehicleType.Location = new System.Drawing.Point(125, 318);
            this.textBoxVehicleType.Name = "textBoxVehicleType";
            this.textBoxVehicleType.Size = new System.Drawing.Size(100, 20);
            this.textBoxVehicleType.TabIndex = 11;
            // 
            // textBoxUserRate
            // 
            this.textBoxUserRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "user_rate", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxUserRate.Location = new System.Drawing.Point(125, 344);
            this.textBoxUserRate.Name = "textBoxUserRate";
            this.textBoxUserRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserRate.TabIndex = 12;
            // 
            // textBoxGuestRate
            // 
            this.textBoxGuestRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "guest_rate", true));
            this.textBoxGuestRate.Location = new System.Drawing.Point(125, 370);
            this.textBoxGuestRate.Name = "textBoxGuestRate";
            this.textBoxGuestRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxGuestRate.TabIndex = 13;
            // 
            // textBoxActivityDurationDays
            // 
            this.textBoxActivityDurationDays.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "activity_duration_days", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N1"));
            this.textBoxActivityDurationDays.Location = new System.Drawing.Point(125, 430);
            this.textBoxActivityDurationDays.Name = "textBoxActivityDurationDays";
            this.textBoxActivityDurationDays.Size = new System.Drawing.Size(100, 20);
            this.textBoxActivityDurationDays.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxActivityImage);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(386, 219);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel1, 4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(409, 205);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Photo de l\'activité";
            // 
            // pictureBoxActivityImage
            // 
            this.pictureBoxActivityImage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.activityBindingSource, "activity_pic", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.pictureBoxActivityImage.Location = new System.Drawing.Point(100, 3);
            this.pictureBoxActivityImage.Name = "pictureBoxActivityImage";
            this.pictureBoxActivityImage.Size = new System.Drawing.Size(286, 201);
            this.pictureBoxActivityImage.TabIndex = 1;
            this.pictureBoxActivityImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnClearFields);
            this.flowLayoutPanel2.Controls.Add(this.BtnAddActivity);
            this.flowLayoutPanel2.Controls.Add(this.BtnUpdateActivity);
            this.flowLayoutPanel2.Controls.Add(this.BtnDeleteActivity);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(386, 481);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(409, 241);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(3, 3);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(52, 53);
            this.btnClearFields.TabIndex = 4;
            this.btnClearFields.Text = "Vider les champs";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // BtnAddActivity
            // 
            this.BtnAddActivity.Location = new System.Drawing.Point(61, 3);
            this.BtnAddActivity.Name = "BtnAddActivity";
            this.BtnAddActivity.Size = new System.Drawing.Size(107, 53);
            this.BtnAddActivity.TabIndex = 1;
            this.BtnAddActivity.Text = "&Ajouter une nouvelle activité";
            this.BtnAddActivity.UseVisualStyleBackColor = true;
            this.BtnAddActivity.Click += new System.EventHandler(this.BtnAddActivity_Click);
            // 
            // BtnUpdateActivity
            // 
            this.BtnUpdateActivity.Location = new System.Drawing.Point(174, 3);
            this.BtnUpdateActivity.Name = "BtnUpdateActivity";
            this.BtnUpdateActivity.Size = new System.Drawing.Size(107, 53);
            this.BtnUpdateActivity.TabIndex = 2;
            this.BtnUpdateActivity.Text = "&Modifier l\'activité";
            this.BtnUpdateActivity.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteActivity
            // 
            this.BtnDeleteActivity.Location = new System.Drawing.Point(287, 3);
            this.BtnDeleteActivity.Name = "BtnDeleteActivity";
            this.BtnDeleteActivity.Size = new System.Drawing.Size(107, 53);
            this.BtnDeleteActivity.TabIndex = 3;
            this.BtnDeleteActivity.Text = "&Supprimer l\'activité";
            this.BtnDeleteActivity.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label8);
            this.flowLayoutPanel3.Controls.Add(this.textBoxGPS);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(386, 430);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(409, 45);
            this.flowLayoutPanel3.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Point GPS RDV";
            // 
            // textBoxGPS
            // 
            this.textBoxGPS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxGPS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "activity_gps_point", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxGPS.Location = new System.Drawing.Point(91, 3);
            this.textBoxGPS.Name = "textBoxGPS";
            this.textBoxGPS.Size = new System.Drawing.Size(100, 20);
            this.textBoxGPS.TabIndex = 1;
            // 
            // dateTimePickerSearchActivity
            // 
            this.dateTimePickerSearchActivity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerSearchActivity.Location = new System.Drawing.Point(386, 3);
            this.dateTimePickerSearchActivity.Name = "dateTimePickerSearchActivity";
            this.dateTimePickerSearchActivity.Size = new System.Drawing.Size(203, 20);
            this.dateTimePickerSearchActivity.TabIndex = 21;
            // 
            // textBoxOrganizerName
            // 
            this.textBoxOrganizerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersOrganizersBindingSource, "name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxOrganizerName.Location = new System.Drawing.Point(125, 481);
            this.textBoxOrganizerName.Name = "textBoxOrganizerName";
            this.textBoxOrganizerName.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrganizerName.TabIndex = 22;
            this.textBoxOrganizerName.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // usersOrganizersBindingSource
            // 
            this.usersOrganizersBindingSource.DataMember = "usersOrganizers";
            this.usersOrganizersBindingSource.DataSource = this.mcmpDataSet;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Nom de la sortie";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Date de la sortie";
            // 
            // textBoxNameActivity
            // 
            this.textBoxNameActivity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "activity_name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxNameActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNameActivity.Location = new System.Drawing.Point(125, 167);
            this.textBoxNameActivity.Name = "textBoxNameActivity";
            this.textBoxNameActivity.Size = new System.Drawing.Size(255, 20);
            this.textBoxNameActivity.TabIndex = 24;
            // 
            // dtpDateActivity
            // 
            this.dtpDateActivity.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.activityBindingSource, "activity_date", true));
            this.dtpDateActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDateActivity.Location = new System.Drawing.Point(125, 193);
            this.dtpDateActivity.Name = "dtpDateActivity";
            this.dtpDateActivity.Size = new System.Drawing.Size(255, 20);
            this.dtpDateActivity.TabIndex = 25;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // activityTableAdapter
            // 
            this.activityTableAdapter.ClearBeforeFill = true;
            // 
            // usersOrganizersTableAdapter
            // 
            this.usersOrganizersTableAdapter.ClearBeforeFill = true;
            // 
            // activityBindingSource1
            // 
            this.activityBindingSource1.DataMember = "activity";
            this.activityBindingSource1.DataSource = this.mcmpDataSet;
            // 
            // FormActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 725);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormActivities";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormOutings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.OutingsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcmpDataSet)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActivityImage)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersOrganizersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxVehicleType;
        private System.Windows.Forms.TextBox textBoxUserRate;
        private System.Windows.Forms.TextBox textBoxGuestRate;
        private System.Windows.Forms.TextBox textBoxActivityDurationDays;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBoxActivityImage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxGPS;
        private System.Windows.Forms.ImageList imageList1;
        private mcmpDataSet mcmpDataSet;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private mcmpDataSetTableAdapters.activityTableAdapter activityTableAdapter;
        private System.Windows.Forms.TextBox textBoxFilterActivity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearchActivity;
        private System.Windows.Forms.TextBox textBoxOrganizerName;
        private System.Windows.Forms.Button BtnAddActivity;
        private System.Windows.Forms.Button BtnUpdateActivity;
        private System.Windows.Forms.Button BtnDeleteActivity;
        private System.Windows.Forms.BindingSource usersOrganizersBindingSource;
        private mcmpDataSetTableAdapters.usersOrganizersTableAdapter usersOrganizersTableAdapter;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNameActivity;
        private System.Windows.Forms.DateTimePicker dtpDateActivity;
        private System.Windows.Forms.BindingSource activityBindingSource1;
        private System.Windows.Forms.GroupBox OutingsGroupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idactivityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activitynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activitydescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activitydestinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activitygpspointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activitydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicletypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn activitypicDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activitydurationdaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}
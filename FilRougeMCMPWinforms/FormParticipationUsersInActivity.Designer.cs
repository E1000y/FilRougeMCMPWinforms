
namespace FilRougeMCMPWinforms
{
    partial class FormParticipationUsersInActivity
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewActivities = new System.Windows.Forms.DataGridView();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersbyActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityTableAdapter = new FilRougeMCMPWinforms.mcmpDataSetTableAdapters.activityTableAdapter();
            this.usersbyActivityTableAdapter = new FilRougeMCMPWinforms.mcmpDataSetTableAdapters.usersbyActivityTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcmpDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersbyActivityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 736);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewActivities);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 730);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorties";
            // 
            // dataGridViewActivities
            // 
            this.dataGridViewActivities.AllowUserToAddRows = false;
            this.dataGridViewActivities.AllowUserToDeleteRows = false;
            this.dataGridViewActivities.AutoGenerateColumns = false;
            this.dataGridViewActivities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActivities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewActivities.DataSource = this.activityBindingSource;
            this.dataGridViewActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewActivities.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewActivities.Name = "dataGridViewActivities";
            this.dataGridViewActivities.ReadOnly = true;
            this.dataGridViewActivities.RowHeadersVisible = false;
            this.dataGridViewActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActivities.Size = new System.Drawing.Size(379, 711);
            this.dataGridViewActivities.TabIndex = 0;
            this.dataGridViewActivities.SelectionChanged += new System.EventHandler(this.dataGridViewActivities_SelectionChanged);
            // 
            // idactivityDataGridViewTextBoxColumn
            // 
            this.idactivityDataGridViewTextBoxColumn.DataPropertyName = "id_activity";
            this.idactivityDataGridViewTextBoxColumn.HeaderText = "id_activity";
            this.idactivityDataGridViewTextBoxColumn.Name = "idactivityDataGridViewTextBoxColumn";
            this.idactivityDataGridViewTextBoxColumn.ReadOnly = true;
            this.idactivityDataGridViewTextBoxColumn.Visible = false;
            // 
            // activitynameDataGridViewTextBoxColumn
            // 
            this.activitynameDataGridViewTextBoxColumn.DataPropertyName = "activity_name";
            this.activitynameDataGridViewTextBoxColumn.HeaderText = "activity_name";
            this.activitynameDataGridViewTextBoxColumn.Name = "activitynameDataGridViewTextBoxColumn";
            this.activitynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activitydescriptionDataGridViewTextBoxColumn
            // 
            this.activitydescriptionDataGridViewTextBoxColumn.DataPropertyName = "activity_description";
            this.activitydescriptionDataGridViewTextBoxColumn.HeaderText = "activity_description";
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
            this.activitydateDataGridViewTextBoxColumn.HeaderText = "activity_date";
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
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataMember = "activity";
            this.activityBindingSource.DataSource = this.mcmpDataSet;
            // 
            // mcmpDataSet
            // 
            this.mcmpDataSet.DataSetName = "mcmpDataSet";
            this.mcmpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewMembers);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(394, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 730);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Participants";
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.AllowUserToAddRows = false;
            this.dataGridViewMembers.AllowUserToDeleteRows = false;
            this.dataGridViewMembers.AutoGenerateColumns = false;
            this.dataGridViewMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn});
            this.dataGridViewMembers.DataSource = this.usersbyActivityBindingSource;
            this.dataGridViewMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMembers.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.ReadOnly = true;
            this.dataGridViewMembers.RowHeadersVisible = false;
            this.dataGridViewMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMembers.Size = new System.Drawing.Size(379, 711);
            this.dataGridViewMembers.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersbyActivityBindingSource
            // 
            this.usersbyActivityBindingSource.DataMember = "usersbyActivity";
            this.usersbyActivityBindingSource.DataSource = this.mcmpDataSet;
            // 
            // activityTableAdapter
            // 
            this.activityTableAdapter.ClearBeforeFill = true;
            // 
            // usersbyActivityTableAdapter
            // 
            this.usersbyActivityTableAdapter.ClearBeforeFill = true;
            // 
            // FormParticipationUsersInActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 736);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(798, 775);
            this.Name = "FormParticipationUsersInActivity";
            this.Text = "FormParticipationUsersInActivity";
            this.Load += new System.EventHandler(this.FormParticipationUsersInActivity_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcmpDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersbyActivityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewMembers;
        private System.Windows.Forms.DataGridView dataGridViewActivities;
        private mcmpDataSet mcmpDataSet;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private mcmpDataSetTableAdapters.activityTableAdapter activityTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usersbyActivityBindingSource;
        private mcmpDataSetTableAdapters.usersbyActivityTableAdapter usersbyActivityTableAdapter;
    }
}
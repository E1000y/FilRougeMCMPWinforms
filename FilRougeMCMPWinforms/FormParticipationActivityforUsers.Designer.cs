
namespace FilRougeMCMPWinforms
{
    partial class FormParticipationActivityforUsers
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
            this.tableLayoutPanelParticipation = new System.Windows.Forms.TableLayoutPanel();
            this.GroupBoxMember = new System.Windows.Forms.GroupBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mcmpDataSet = new FilRougeMCMPWinforms.mcmpDataSet();
            this.groupBoxActivity = new System.Windows.Forms.GroupBox();
            this.dataGridViewActivities = new System.Windows.Forms.DataGridView();
            this.activitynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activitydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentYearActivitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new FilRougeMCMPWinforms.mcmpDataSetTableAdapters.usersTableAdapter();
            this.currentYearActivitiesTableAdapter = new FilRougeMCMPWinforms.mcmpDataSetTableAdapters.CurrentYearActivitiesTableAdapter();
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
            this.tableLayoutPanelParticipation.SuspendLayout();
            this.GroupBoxMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcmpDataSet)).BeginInit();
            this.groupBoxActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentYearActivitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelParticipation
            // 
            this.tableLayoutPanelParticipation.ColumnCount = 2;
            this.tableLayoutPanelParticipation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.tableLayoutPanelParticipation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.tableLayoutPanelParticipation.Controls.Add(this.GroupBoxMember, 0, 0);
            this.tableLayoutPanelParticipation.Controls.Add(this.groupBoxActivity, 1, 0);
            this.tableLayoutPanelParticipation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelParticipation.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelParticipation.Name = "tableLayoutPanelParticipation";
            this.tableLayoutPanelParticipation.RowCount = 1;
            this.tableLayoutPanelParticipation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 439F));
            this.tableLayoutPanelParticipation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelParticipation.Size = new System.Drawing.Size(804, 568);
            this.tableLayoutPanelParticipation.TabIndex = 0;
            // 
            // GroupBoxMember
            // 
            this.GroupBoxMember.Controls.Add(this.dataGridViewUsers);
            this.GroupBoxMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxMember.Location = new System.Drawing.Point(3, 3);
            this.GroupBoxMember.Name = "GroupBoxMember";
            this.GroupBoxMember.Size = new System.Drawing.Size(400, 562);
            this.GroupBoxMember.TabIndex = 0;
            this.GroupBoxMember.TabStop = false;
            this.GroupBoxMember.Text = "Adhérents";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoGenerateColumns = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewUsers.DataSource = this.usersBindingSource;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(394, 543);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.SelectionChanged += new System.EventHandler(this.dataGridViewUsers_SelectionChanged);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.mcmpDataSet;
            // 
            // mcmpDataSet
            // 
            this.mcmpDataSet.DataSetName = "mcmpDataSet";
            this.mcmpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBoxActivity
            // 
            this.groupBoxActivity.Controls.Add(this.dataGridViewActivities);
            this.groupBoxActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxActivity.Location = new System.Drawing.Point(409, 3);
            this.groupBoxActivity.Name = "groupBoxActivity";
            this.groupBoxActivity.Size = new System.Drawing.Size(392, 562);
            this.groupBoxActivity.TabIndex = 1;
            this.groupBoxActivity.TabStop = false;
            this.groupBoxActivity.Text = "Sorties";
            // 
            // dataGridViewActivities
            // 
            this.dataGridViewActivities.AllowUserToAddRows = false;
            this.dataGridViewActivities.AllowUserToDeleteRows = false;
            this.dataGridViewActivities.AutoGenerateColumns = false;
            this.dataGridViewActivities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActivities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activitynameDataGridViewTextBoxColumn,
            this.activitydateDataGridViewTextBoxColumn});
            this.dataGridViewActivities.DataSource = this.currentYearActivitiesBindingSource;
            this.dataGridViewActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewActivities.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewActivities.Name = "dataGridViewActivities";
            this.dataGridViewActivities.ReadOnly = true;
            this.dataGridViewActivities.RowHeadersVisible = false;
            this.dataGridViewActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActivities.Size = new System.Drawing.Size(386, 543);
            this.dataGridViewActivities.TabIndex = 1;
            // 
            // activitynameDataGridViewTextBoxColumn
            // 
            this.activitynameDataGridViewTextBoxColumn.DataPropertyName = "activity_name";
            this.activitynameDataGridViewTextBoxColumn.HeaderText = "Nom de l\'activité";
            this.activitynameDataGridViewTextBoxColumn.Name = "activitynameDataGridViewTextBoxColumn";
            this.activitynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activitydateDataGridViewTextBoxColumn
            // 
            this.activitydateDataGridViewTextBoxColumn.DataPropertyName = "activity_date";
            this.activitydateDataGridViewTextBoxColumn.HeaderText = "Date de l\'activité";
            this.activitydateDataGridViewTextBoxColumn.Name = "activitydateDataGridViewTextBoxColumn";
            this.activitydateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentYearActivitiesBindingSource
            // 
            this.currentYearActivitiesBindingSource.DataMember = "CurrentYearActivities";
            this.currentYearActivitiesBindingSource.DataSource = this.mcmpDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // currentYearActivitiesTableAdapter
            // 
            this.currentYearActivitiesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 73.85786F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.FillWeight = 73.85786F;
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 152.2843F;
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
            // FormParticipationActivityforUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 568);
            this.Controls.Add(this.tableLayoutPanelParticipation);
            this.Name = "FormParticipationActivityforUsers";
            this.Text = "FormParticipation";
            this.Load += new System.EventHandler(this.FormParticipation_Load);
            this.tableLayoutPanelParticipation.ResumeLayout(false);
            this.GroupBoxMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcmpDataSet)).EndInit();
            this.groupBoxActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentYearActivitiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelParticipation;
        private System.Windows.Forms.GroupBox GroupBoxMember;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.GroupBox groupBoxActivity;
        private System.Windows.Forms.DataGridView dataGridViewActivities;
        private mcmpDataSet mcmpDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private mcmpDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn activitynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activitydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource currentYearActivitiesBindingSource;
        private mcmpDataSetTableAdapters.CurrentYearActivitiesTableAdapter currentYearActivitiesTableAdapter;
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
    }
}
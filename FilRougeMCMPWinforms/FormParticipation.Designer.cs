
namespace FilRougeMCMPWinforms
{
    partial class FormParticipation
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
            this.GroupBoxMember = new System.Windows.Forms.GroupBox();
            this.groupBoxActivity = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mcmpDataSet = new FilRougeMCMPWinforms.mcmpDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new FilRougeMCMPWinforms.mcmpDataSetTableAdapters.usersTableAdapter();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.GroupBoxMember.SuspendLayout();
            this.groupBoxActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcmpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.tableLayoutPanel1.Controls.Add(this.GroupBoxMember, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxActivity, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 413F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 568);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GroupBoxMember
            // 
            this.GroupBoxMember.Controls.Add(this.dataGridView2);
            this.GroupBoxMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxMember.Location = new System.Drawing.Point(3, 3);
            this.GroupBoxMember.Name = "GroupBoxMember";
            this.GroupBoxMember.Size = new System.Drawing.Size(400, 562);
            this.GroupBoxMember.TabIndex = 0;
            this.GroupBoxMember.TabStop = false;
            this.GroupBoxMember.Text = "Adhérents";
            // 
            // groupBoxActivity
            // 
            this.groupBoxActivity.Controls.Add(this.dataGridView1);
            this.groupBoxActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxActivity.Location = new System.Drawing.Point(409, 3);
            this.groupBoxActivity.Name = "groupBoxActivity";
            this.groupBoxActivity.Size = new System.Drawing.Size(392, 562);
            this.groupBoxActivity.TabIndex = 1;
            this.groupBoxActivity.TabStop = false;
            this.groupBoxActivity.Text = "Sorties";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(386, 543);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView2.DataSource = this.usersBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(394, 543);
            this.dataGridView2.TabIndex = 0;
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // isorganizerDataGridViewCheckBoxColumn
            // 
            this.isorganizerDataGridViewCheckBoxColumn.DataPropertyName = "is_organizer";
            this.isorganizerDataGridViewCheckBoxColumn.HeaderText = "is_organizer";
            this.isorganizerDataGridViewCheckBoxColumn.Name = "isorganizerDataGridViewCheckBoxColumn";
            this.isorganizerDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.Visible = false;
            // 
            // profilepicDataGridViewImageColumn
            // 
            this.profilepicDataGridViewImageColumn.DataPropertyName = "profile_pic";
            this.profilepicDataGridViewImageColumn.HeaderText = "profile_pic";
            this.profilepicDataGridViewImageColumn.Name = "profilepicDataGridViewImageColumn";
            this.profilepicDataGridViewImageColumn.Visible = false;
            // 
            // streetnumberDataGridViewTextBoxColumn
            // 
            this.streetnumberDataGridViewTextBoxColumn.DataPropertyName = "street_number";
            this.streetnumberDataGridViewTextBoxColumn.HeaderText = "street_number";
            this.streetnumberDataGridViewTextBoxColumn.Name = "streetnumberDataGridViewTextBoxColumn";
            this.streetnumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // streetnameDataGridViewTextBoxColumn
            // 
            this.streetnameDataGridViewTextBoxColumn.DataPropertyName = "street_name";
            this.streetnameDataGridViewTextBoxColumn.HeaderText = "street_name";
            this.streetnameDataGridViewTextBoxColumn.Name = "streetnameDataGridViewTextBoxColumn";
            this.streetnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // zipcodeDataGridViewTextBoxColumn
            // 
            this.zipcodeDataGridViewTextBoxColumn.DataPropertyName = "zip_code";
            this.zipcodeDataGridViewTextBoxColumn.HeaderText = "zip_code";
            this.zipcodeDataGridViewTextBoxColumn.Name = "zipcodeDataGridViewTextBoxColumn";
            this.zipcodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Visible = false;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.Visible = false;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // telephonenumberDataGridViewTextBoxColumn
            // 
            this.telephonenumberDataGridViewTextBoxColumn.DataPropertyName = "telephone_number";
            this.telephonenumberDataGridViewTextBoxColumn.HeaderText = "telephone_number";
            this.telephonenumberDataGridViewTextBoxColumn.Name = "telephonenumberDataGridViewTextBoxColumn";
            this.telephonenumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.Visible = false;
            // 
            // updatedatDataGridViewTextBoxColumn
            // 
            this.updatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.HeaderText = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.Name = "updatedatDataGridViewTextBoxColumn";
            this.updatedatDataGridViewTextBoxColumn.Visible = false;
            // 
            // remembertokenDataGridViewTextBoxColumn
            // 
            this.remembertokenDataGridViewTextBoxColumn.DataPropertyName = "remember_token";
            this.remembertokenDataGridViewTextBoxColumn.HeaderText = "remember_token";
            this.remembertokenDataGridViewTextBoxColumn.Name = "remembertokenDataGridViewTextBoxColumn";
            this.remembertokenDataGridViewTextBoxColumn.Visible = false;
            // 
            // isactiveDataGridViewCheckBoxColumn
            // 
            this.isactiveDataGridViewCheckBoxColumn.DataPropertyName = "is_active";
            this.isactiveDataGridViewCheckBoxColumn.HeaderText = "is_active";
            this.isactiveDataGridViewCheckBoxColumn.Name = "isactiveDataGridViewCheckBoxColumn";
            this.isactiveDataGridViewCheckBoxColumn.Visible = false;
            // 
            // FormParticipation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 568);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormParticipation";
            this.Text = "FormParticipation";
            this.Load += new System.EventHandler(this.FormParticipation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GroupBoxMember.ResumeLayout(false);
            this.groupBoxActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcmpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox GroupBoxMember;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBoxActivity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mcmpDataSet mcmpDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private mcmpDataSetTableAdapters.usersTableAdapter usersTableAdapter;
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
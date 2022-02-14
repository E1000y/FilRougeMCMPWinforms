
namespace FilRougeMCMPWinforms
{
    partial class FormTokens
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jetonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.banquejetonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mcmpDataSet = new FilRougeMCMPWinforms.mcmpDataSet();
            this.BtnGenerateToken = new System.Windows.Forms.Button();
            this.banquejetonTableAdapter = new FilRougeMCMPWinforms.mcmpDataSetTableAdapters.banquejetonTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banquejetonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcmpDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnGenerateToken, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 686);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jetonDataGridViewTextBoxColumn,
            this.etatDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.banquejetonBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(159, 117);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(463, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // jetonDataGridViewTextBoxColumn
            // 
            this.jetonDataGridViewTextBoxColumn.DataPropertyName = "jeton";
            this.jetonDataGridViewTextBoxColumn.HeaderText = "jeton";
            this.jetonDataGridViewTextBoxColumn.Name = "jetonDataGridViewTextBoxColumn";
            // 
            // etatDataGridViewCheckBoxColumn
            // 
            this.etatDataGridViewCheckBoxColumn.DataPropertyName = "etat";
            this.etatDataGridViewCheckBoxColumn.HeaderText = "etat";
            this.etatDataGridViewCheckBoxColumn.Name = "etatDataGridViewCheckBoxColumn";
            // 
            // banquejetonBindingSource
            // 
            this.banquejetonBindingSource.DataMember = "banquejeton";
            this.banquejetonBindingSource.DataSource = this.mcmpDataSet;
            // 
            // mcmpDataSet
            // 
            this.mcmpDataSet.DataSetName = "mcmpDataSet";
            this.mcmpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnGenerateToken
            // 
            this.BtnGenerateToken.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGenerateToken.Location = new System.Drawing.Point(159, 459);
            this.BtnGenerateToken.Name = "BtnGenerateToken";
            this.BtnGenerateToken.Size = new System.Drawing.Size(463, 108);
            this.BtnGenerateToken.TabIndex = 1;
            this.BtnGenerateToken.Text = "Générer un jeton";
            this.BtnGenerateToken.UseVisualStyleBackColor = true;
            this.BtnGenerateToken.Click += new System.EventHandler(this.BtnGenerateToken_Click);
            // 
            // banquejetonTableAdapter
            // 
            this.banquejetonTableAdapter.ClearBeforeFill = true;
            // 
            // FormTokens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 686);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(798, 725);
            this.Name = "FormTokens";
            this.Text = "Jetons";
            this.Load += new System.EventHandler(this.FormTokens_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banquejetonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcmpDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private mcmpDataSet mcmpDataSet;
        private System.Windows.Forms.BindingSource banquejetonBindingSource;
        private mcmpDataSetTableAdapters.banquejetonTableAdapter banquejetonTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jetonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn etatDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button BtnGenerateToken;
    }
}
﻿
namespace FilRougeMCMPWinforms
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.BtnJetons = new System.Windows.Forms.Button();
            this.OutingsPanel = new System.Windows.Forms.Panel();
            this.BtnDisplayParticipations = new System.Windows.Forms.Button();
            this.BtnDisplayOutings = new System.Windows.Forms.Button();
            this.BtnOutings = new System.Windows.Forms.Button();
            this.BtnMembers = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SideMenuPanel.SuspendLayout();
            this.OutingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.AutoScroll = true;
            this.SideMenuPanel.BackColor = System.Drawing.Color.Black;
            this.SideMenuPanel.Controls.Add(this.BtnJetons);
            this.SideMenuPanel.Controls.Add(this.OutingsPanel);
            this.SideMenuPanel.Controls.Add(this.BtnOutings);
            this.SideMenuPanel.Controls.Add(this.BtnMembers);
            this.SideMenuPanel.Controls.Add(this.LogoPanel);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(293, 815);
            this.SideMenuPanel.TabIndex = 0;
            // 
            // BtnJetons
            // 
            this.BtnJetons.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnJetons.FlatAppearance.BorderSize = 0;
            this.BtnJetons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJetons.ForeColor = System.Drawing.SystemColors.Menu;
            this.BtnJetons.Location = new System.Drawing.Point(0, 309);
            this.BtnJetons.Name = "BtnJetons";
            this.BtnJetons.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnJetons.Size = new System.Drawing.Size(293, 39);
            this.BtnJetons.TabIndex = 5;
            this.BtnJetons.Text = "Jetons";
            this.BtnJetons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnJetons.UseVisualStyleBackColor = true;
            this.BtnJetons.Click += new System.EventHandler(this.BtnJetons_Click);
            // 
            // OutingsPanel
            // 
            this.OutingsPanel.BackColor = System.Drawing.Color.Crimson;
            this.OutingsPanel.Controls.Add(this.button1);
            this.OutingsPanel.Controls.Add(this.BtnDisplayParticipations);
            this.OutingsPanel.Controls.Add(this.BtnDisplayOutings);
            this.OutingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutingsPanel.Location = new System.Drawing.Point(0, 178);
            this.OutingsPanel.Name = "OutingsPanel";
            this.OutingsPanel.Size = new System.Drawing.Size(293, 131);
            this.OutingsPanel.TabIndex = 4;
            // 
            // BtnDisplayParticipations
            // 
            this.BtnDisplayParticipations.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDisplayParticipations.FlatAppearance.BorderSize = 0;
            this.BtnDisplayParticipations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDisplayParticipations.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnDisplayParticipations.Location = new System.Drawing.Point(0, 36);
            this.BtnDisplayParticipations.Name = "BtnDisplayParticipations";
            this.BtnDisplayParticipations.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.BtnDisplayParticipations.Size = new System.Drawing.Size(293, 36);
            this.BtnDisplayParticipations.TabIndex = 1;
            this.BtnDisplayParticipations.Text = "Membres inscrits";
            this.BtnDisplayParticipations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDisplayParticipations.UseVisualStyleBackColor = true;
            this.BtnDisplayParticipations.Click += new System.EventHandler(this.BtnDisplayParticipations_Click);
            // 
            // BtnDisplayOutings
            // 
            this.BtnDisplayOutings.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDisplayOutings.FlatAppearance.BorderSize = 0;
            this.BtnDisplayOutings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDisplayOutings.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnDisplayOutings.Location = new System.Drawing.Point(0, 0);
            this.BtnDisplayOutings.Name = "BtnDisplayOutings";
            this.BtnDisplayOutings.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.BtnDisplayOutings.Size = new System.Drawing.Size(293, 36);
            this.BtnDisplayOutings.TabIndex = 0;
            this.BtnDisplayOutings.Text = "Toutes les sorties";
            this.BtnDisplayOutings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDisplayOutings.UseVisualStyleBackColor = true;
            this.BtnDisplayOutings.Click += new System.EventHandler(this.DisplayOutings_Click);
            // 
            // BtnOutings
            // 
            this.BtnOutings.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOutings.FlatAppearance.BorderSize = 0;
            this.BtnOutings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOutings.ForeColor = System.Drawing.SystemColors.Menu;
            this.BtnOutings.Location = new System.Drawing.Point(0, 139);
            this.BtnOutings.Name = "BtnOutings";
            this.BtnOutings.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnOutings.Size = new System.Drawing.Size(293, 39);
            this.BtnOutings.TabIndex = 3;
            this.BtnOutings.Text = "Sorties";
            this.BtnOutings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOutings.UseVisualStyleBackColor = true;
            this.BtnOutings.Click += new System.EventHandler(this.BtnOutings_Click);
            // 
            // BtnMembers
            // 
            this.BtnMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMembers.FlatAppearance.BorderSize = 0;
            this.BtnMembers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.BtnMembers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.BtnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMembers.ForeColor = System.Drawing.SystemColors.Menu;
            this.BtnMembers.Location = new System.Drawing.Point(0, 100);
            this.BtnMembers.Name = "BtnMembers";
            this.BtnMembers.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnMembers.Size = new System.Drawing.Size(293, 39);
            this.BtnMembers.TabIndex = 1;
            this.BtnMembers.Text = "Membres";
            this.BtnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMembers.UseVisualStyleBackColor = true;
            this.BtnMembers.Click += new System.EventHandler(this.BtnMembers_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(293, 100);
            this.LogoPanel.TabIndex = 0;
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(293, 0);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(929, 815);
            this.ChildFormPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(0, 72);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(293, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Membres inscrits";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1222, 815);
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.SideMenuPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SideMenuPanel.ResumeLayout(false);
            this.OutingsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Button BtnMembers;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Button BtnJetons;
        private System.Windows.Forms.Panel OutingsPanel;
        private System.Windows.Forms.Button BtnDisplayParticipations;
        private System.Windows.Forms.Button BtnDisplayOutings;
        private System.Windows.Forms.Button BtnOutings;
        private System.Windows.Forms.Panel ChildFormPanel;
        private System.Windows.Forms.Button button1;
    }
}


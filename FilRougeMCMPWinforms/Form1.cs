using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilRougeMCMPWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;

            LogoPanel.Visible = true;
            SideMenuPanel.Visible = true;
            OutingsPanel.Visible = false;
        }

        private void hideSubMenu()
        {
            if (OutingsPanel.Visible)
            {
                OutingsPanel.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void BtnMembers_Click(object sender, EventArgs e)
        {
            Form formMembers = new FormMembers();
            openChildForm(formMembers);
            BtnMembers.BackColor = Color.Crimson;
            BtnJetons.BackColor = Color.Black;
            
            
            hideSubMenu();
        }

        private void BtnOutings_Click(object sender, EventArgs e)
        {
            showSubMenu(OutingsPanel);
            BtnMembers.BackColor = Color.Black;
            BtnJetons.BackColor = Color.Black;
        }

        private void DisplayOutings_Click(object sender, EventArgs e)
        {
            Form FormActivities = new FormActivities();
            openChildForm(FormActivities);
            BtnDisplayOutings.BackColor = Color.Transparent;


           // hideSubMenu();
        }

      

        private void BtnJetons_Click(object sender, EventArgs e)
        {
            Form formTokens = new FormTokens();
            openChildForm(formTokens);
            BtnMembers.BackColor = Color.Black;
            BtnOutings.BackColor = Color.Black;
            BtnJetons.BackColor = Color.Crimson;
            
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(childForm);
            ChildFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnDisplayParticipations_Click(object sender, EventArgs e)
        {
            Form formParticipation = new FormParticipationActivityforUsers();
            openChildForm(formParticipation);

        }

        private void BtnDisplayParticipationsByOuting_Click(object sender, EventArgs e)
        {
            Form formParticipationByOuting = new FormParticipationUsersInActivity();
            openChildForm(formParticipationByOuting);
        }
    }
}

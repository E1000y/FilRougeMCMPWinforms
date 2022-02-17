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
    public partial class FormParticipation : Form
    {
        public FormParticipation()
        {
            InitializeComponent();
        }

        private void FormParticipation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'mcmpDataSet.users'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.usersTableAdapter.Fill(this.mcmpDataSet.users);

        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {

            if (usersBindingSource.Current != null)
            {
                mcmpDataSet.usersRow usersRow = (mcmpDataSet.usersRow)((DataRowView) usersBindingSource.Current).Row;

                currentYearActivitiesTableAdapter.Fill(mcmpDataSet.CurrentYearActivities, usersRow.id); 

              


            }

        }
    }
}

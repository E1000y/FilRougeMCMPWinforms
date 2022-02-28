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
    public partial class FormParticipationUsersInActivity : Form
    {
        public FormParticipationUsersInActivity()
        {
            InitializeComponent();
        }

        private void FormParticipationUsersInActivity_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'mcmpDataSet.activity'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.activityTableAdapter.Fill(this.mcmpDataSet.activity);

        }

        private void dataGridViewActivities_SelectionChanged(object sender, EventArgs e)
        {
            if (activityBindingSource.Current != null)
            {
                DataRowView ObjectDRV = (DataRowView) activityBindingSource.Current;
                mcmpDataSet.activityRow activityRow = (mcmpDataSet.activityRow)ObjectDRV.Row;

                this.usersbyActivityTableAdapter.Fill(this.mcmpDataSet.usersbyActivity, activityRow.id_activity);

            }
        }
    }
}

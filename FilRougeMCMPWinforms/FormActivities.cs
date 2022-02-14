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
    public partial class FormActivities : Form
    {
        public FormActivities()
        {
            InitializeComponent();
        }

        private void FormOutings_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'mcmpDataSet.activity'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.activityTableAdapter.Fill(this.mcmpDataSet.activity);

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void activityBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (activityBindingSource.Current != null)
            {
                DataRowView objectDRV = (DataRowView)activityBindingSource.Current;
                mcmpDataSet.activityRow activityRow = (mcmpDataSet.activityRow)objectDRV.Row;

                int idActivity = activityRow.id_activity;


                usersOrganizersTableAdapter.FillInOrganizerName(mcmpDataSet.usersOrganizers, idActivity);
            }


        }

        private void BtnAddActivity_Click(object sender, EventArgs e)
        {
            if (activityBindingSource.Current != null)
            {
                DataRowView objectCurrentActivity = (DataRowView)activityBindingSource.Current;
                mcmpDataSet.activityRow activityRow = (mcmpDataSet.activityRow) objectCurrentActivity.Row;





            }



        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            textBoxNameActivity.Text = "";
            dtpDateActivity.Value = DateTime.Today;
            textBoxDescription.Text = "";
            textBoxVehicleType.Text = "";
            textBoxGuestRate.Text = "";
            textBoxUserRate.Text = "";
            textBoxActivityDurationDays.Text = "0";
            textBoxOrganizerName.Text = "";
            pictureBoxActivityImage.Image = null;
            textBoxGPS.Text = "";


        }
    }
}

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
            // TODO: cette ligne de code charge les données dans la table 'mcmpDataSet.vactivityfulltableorganizername'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vactivityfulltableorganizernameTableAdapter.Fill(this.mcmpDataSet.vactivityfulltableorganizername);


            // TODO: cette ligne de code charge les données dans la table 'mcmpDataSet.users'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.usersTableAdapter.Fill(this.mcmpDataSet.users);
            // TODO: cette ligne de code charge les données dans la table 'mcmpDataSet.Organizers'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.organizersTableAdapter.Fill(this.mcmpDataSet.Organizers);
            // TODO: cette ligne de code charge les données dans la table 'mcmpDataSet1.Organizers'. Vous pouvez la déplacer ou la supprimer selon les besoins.


            //this.activityTableAdapter.Fill(this.mcmpDataSet.activity);

        }



        private void activityBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (activityBindingSource.Current != null)
            {
                DataRowView objectDRV = (DataRowView)activityBindingSource.Current;
                mcmpDataSet.activityRow activityRow = (mcmpDataSet.activityRow)objectDRV.Row;

                int idActivity = activityRow.id_activity;


                //usersOrganizersTableAdapter.FillInOrganizerName(mcmpDataSet.usersOrganizers, idActivity);


            }


        }

        private void BtnAddActivity_Click(object sender, EventArgs e)
        {
            if (vactivityfulltableorganizernameBindingSource.Current != null)
            {
                DataRowView objectDRV = (DataRowView)vactivityfulltableorganizernameBindingSource.Current;
                mcmpDataSet.vactivityfulltableorganizernameRow vactivityorgaRow = (mcmpDataSet.vactivityfulltableorganizernameRow)objectDRV.Row;

                String DestinationActivity = textBoxActivityDestination.Text;
                String NameActivity = textBoxNameActivity.Text;
                DateTime DateActivity = dtpDateActivity.Value;
                String DescriptionActivity = textBoxDescription.Text;
                String VehicleType = textBoxVehicleType.Text;
                decimal? UsersRate = String.IsNullOrWhiteSpace(textBoxUserRate.Text) ? 0 : Decimal.Parse(textBoxUserRate.Text);
                decimal? GuestsRate = String.IsNullOrWhiteSpace(textBoxGuestRate.Text) ? 0 : Decimal.Parse(textBoxGuestRate.Text);
                decimal? ActivityDuration = String.IsNullOrWhiteSpace(textBoxActivityDurationDays.Text) ? 0 : Decimal.Parse(textBoxActivityDurationDays.Text);
                int idOrganizer = (int)comboBoxOrganizerName.SelectedValue;
                String GPSpoint = textBoxGPS.Text;

                /*int IdActivityDuWhere = vactivityorgaRow.id_activity;
                int IdOrganizerDuWhere = vactivityorgaRow.id;
                String ActivityNameDuWhere = vactivityorgaRow.activity_name;
                String ActivityDescriptionDuWhere = vactivityorgaRow.activity_description;
                String ActivityDestinationDuWhere = vactivityorgaRow.activity_destination;
                String ActivityGPSPointDuWhere = vactivityorgaRow.activity_gps_point;
                DateTime? ActivityDateDuWhere = vactivityorgaRow.activity_date;
                decimal? UserRateDuWhere = vactivityorgaRow.user_rate;
                decimal? GuestRateDuWhere = vactivityorgaRow.guest_rate;
                String VehicleTypeDuWhere = vactivityorgaRow.vehicle_type;
                decimal? ActivityDurationDaysDuWhere = vactivityorgaRow.activity_duration_days;*/



                activityTableAdapter.Insert(NameActivity, DescriptionActivity, DestinationActivity, GPSpoint, DateActivity, UsersRate, GuestsRate, VehicleType, ActivityDuration, idOrganizer);


                this.vactivityfulltableorganizernameTableAdapter.Fill(this.mcmpDataSet.vactivityfulltableorganizername);

                this.vactivityfulltableorganizernameBindingSource.Position = this.vactivityfulltableorganizernameBindingSource.Find("id_activity", activityTableAdapter.Adapter.InsertCommand.LastInsertedId);

            }



        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            textBoxActivityDestination.Text = "";
            textBoxNameActivity.Text = "";
            dtpDateActivity.Value = DateTime.Today;
            textBoxDescription.Text = "";
            textBoxVehicleType.Text = "";
            textBoxGuestRate.Text = "";
            textBoxUserRate.Text = "";
            textBoxActivityDurationDays.Text = null;
            comboBoxOrganizerName.Text = "";
            pictureBoxActivityImage.Image = null;
            textBoxGPS.Text = "";


        }

        private void BtnUpdateActivity_Click(object sender, EventArgs e)
        {
            if (vactivityfulltableorganizernameBindingSource.Current != null)
            {
                DataRowView objectDRV = (DataRowView)vactivityfulltableorganizernameBindingSource.Current;
                mcmpDataSet.vactivityfulltableorganizernameRow vactivityorgaRow = (mcmpDataSet.vactivityfulltableorganizernameRow)objectDRV.Row;

                String DestinationActivity = textBoxActivityDestination.Text;
                String NameActivity = textBoxNameActivity.Text;
                DateTime DateActivity = dtpDateActivity.Value;
                String DescriptionActivity = textBoxDescription.Text;
                String VehicleType = textBoxVehicleType.Text;
                decimal? UsersRate = String.IsNullOrEmpty(textBoxUserRate.Text) ? 0 : Decimal.Parse(textBoxUserRate.Text);
                decimal? GuestsRate = String.IsNullOrEmpty(textBoxGuestRate.Text) ? 0 : Decimal.Parse(textBoxGuestRate.Text);
                decimal? ActivityDuration = String.IsNullOrEmpty(textBoxActivityDurationDays.Text) ? 0 : Decimal.Parse(textBoxActivityDurationDays.Text);
                int idOrganizer = (int)comboBoxOrganizerName.SelectedValue;
                String GPSpoint = textBoxGPS.Text;

                int IdActivityDuWhere = vactivityorgaRow.id_activity;
                int IdOrganizerDuWhere = vactivityorgaRow.id;
                String ActivityNameDuWhere = vactivityorgaRow.activity_name;
                String ActivityDescriptionDuWhere = vactivityorgaRow.activity_description;
                String ActivityDestinationDuWhere = vactivityorgaRow.activity_destination;
                String ActivityGPSPointDuWhere = vactivityorgaRow.activity_gps_point;
                DateTime? ActivityDateDuWhere = vactivityorgaRow.activity_date;
                decimal? UserRateDuWhere = vactivityorgaRow.user_rate;
                decimal? GuestRateDuWhere = vactivityorgaRow.guest_rate;
                String VehicleTypeDuWhere = vactivityorgaRow.vehicle_type;
                decimal? ActivityDurationDaysDuWhere = vactivityorgaRow.activity_duration_days;



                activityTableAdapter.Update(NameActivity, DescriptionActivity, DestinationActivity, GPSpoint, DateActivity, UsersRate, GuestsRate, VehicleType, ActivityDuration, idOrganizer, IdActivityDuWhere, IdOrganizerDuWhere, ActivityNameDuWhere, ActivityDescriptionDuWhere, ActivityDestinationDuWhere, ActivityGPSPointDuWhere, ActivityDateDuWhere, UserRateDuWhere, GuestRateDuWhere, VehicleTypeDuWhere, ActivityDurationDaysDuWhere);


                this.vactivityfulltableorganizernameTableAdapter.Fill(this.mcmpDataSet.vactivityfulltableorganizername);
                this.vactivityfulltableorganizernameBindingSource.Position = vactivityfulltableorganizernameBindingSource.Find("activity_name", NameActivity);

            }
        }

        private void textBoxUserRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.'))
            {
                e.KeyChar = ',';
            }
        }

        private void BtnDeleteActivity_Click(object sender, EventArgs e)
        {
            if (vactivityfulltableorganizernameBindingSource.Current != null)
            {
                DataRowView objectDRV = (DataRowView)vactivityfulltableorganizernameBindingSource.Current;
                mcmpDataSet.vactivityfulltableorganizernameRow vactivityorgaRow = (mcmpDataSet.vactivityfulltableorganizernameRow)objectDRV.Row;



                this.activityTableAdapter.Delete(vactivityorgaRow.id_activity, vactivityorgaRow.id, vactivityorgaRow.activity_name, vactivityorgaRow.activity_description, vactivityorgaRow.activity_destination, vactivityorgaRow.activity_gps_point, vactivityorgaRow.activity_date, vactivityorgaRow.user_rate, vactivityorgaRow.guest_rate, vactivityorgaRow.vehicle_type, vactivityorgaRow.activity_duration_days);

                this.vactivityfulltableorganizernameTableAdapter.Fill(this.mcmpDataSet.vactivityfulltableorganizername);


            }

        }



        private void textBoxFilterActivity_KeyPress(object sender, KeyPressEventArgs e)
        {
            vactivityfulltableorganizernameBindingSource.Filter = $" activity_name LIKE '%{textBoxFilterActivity.Text}%' OR activity_description LIKE '%{textBoxFilterActivity.Text}%' OR activity_destination LIKE '%{textBoxFilterActivity.Text}%'";
        }

        private void dateTimePickerBeginDate_ValueChanged(object sender, EventArgs e)
        {
        

            if (dateTimePickerBeginDate != null)
            {
                //activiteBindingSource2.Filter = "dateActivite = #" + dateTimePickerDtSortie.Text + "#";
                vactivityfulltableorganizernameBindingSource.Filter = @"activity_date > #" + dateTimePickerBeginDate.Text + "# AND activity_date < #"+ dateTimePickerEndDate.Text+ "#";

            }



        }

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {


            if (dateTimePickerEndDate != null)
            {
                //activiteBindingSource2.Filter = "dateActivite = #" + dateTimePickerDtSortie.Text + "#";
                vactivityfulltableorganizernameBindingSource.Filter = @"activity_date > #" + dateTimePickerBeginDate.Text + "# AND activity_date < #" + dateTimePickerEndDate.Text + "#";

            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dateTimePickerBeginDate.Value = DateTime.Today;
            dateTimePickerEndDate.Value = DateTime.Today;
            vactivityfulltableorganizernameBindingSource.RemoveFilter();
        }

        private void textBoxGPS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=(char)Keys.Back && e.KeyChar != '.' && e.KeyChar !=',')
            {
                e.Handled = true;
            }
        }
    }
}

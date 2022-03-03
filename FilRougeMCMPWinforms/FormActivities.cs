using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace FilRougeMCMPWinforms
{
    public partial class FormActivities : Form
    {

        public FormActivities()
        {
            InitializeComponent();
            //dateTimePickerBeginDate.Value = DateTime.Today.AddYears(-50); quoi faire avec ça, ça marche pas en datetime.today
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

            byte[] tableauImageOctets;
            using (MemoryStream objStream = new MemoryStream())
            {

                if (pictureBoxActivityImage.Image != null)
                {
                    pictureBoxActivityImage.Image.Save(objStream, ImageFormat.Jpeg);
                    tableauImageOctets = objStream.ToArray();
                }
                else
                {
                    tableauImageOctets = null;
                }
               
                

            }


            
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


                activityTableAdapter.Insert(NameActivity, DescriptionActivity, DestinationActivity, GPSpoint, DateActivity, UsersRate, GuestsRate, VehicleType, tableauImageOctets, ActivityDuration, idOrganizer);


                this.vactivityfulltableorganizernameTableAdapter.Fill(this.mcmpDataSet.vactivityfulltableorganizername);

                this.vactivityfulltableorganizernameBindingSource.Position = this.vactivityfulltableorganizernameBindingSource.Find("id_activity", activityTableAdapter.Adapter.InsertCommand.LastInsertedId);

            



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

            byte[] tableauImageOctets;
            using (MemoryStream objStream = new MemoryStream())
            {
                if (pictureBoxActivityImage.Image != null)
                {
                    pictureBoxActivityImage.Image.Save(objStream, ImageFormat.Jpeg);
                    tableauImageOctets = objStream.ToArray();
                }
                else
                {
                    tableauImageOctets = null;
                }
            }
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

                activityTableAdapter.Update(NameActivity, DescriptionActivity, DestinationActivity, GPSpoint, DateActivity, UsersRate, GuestsRate, VehicleType, tableauImageOctets, ActivityDuration, idOrganizer, IdActivityDuWhere, IdOrganizerDuWhere, ActivityNameDuWhere, ActivityDescriptionDuWhere, ActivityDestinationDuWhere, ActivityGPSPointDuWhere, ActivityDateDuWhere, UserRateDuWhere, GuestRateDuWhere, VehicleTypeDuWhere, ActivityDurationDaysDuWhere);

               /* TODO revoir ceci
                * 
                * activityTableAdapter.Update(NameActivity, DescriptionActivity, DestinationActivity, GPSpoint, DateActivity, UsersRate, GuestsRate, VehicleType, ActivityDuration, idOrganizer, IdActivityDuWhere, IdOrganizerDuWhere, ActivityNameDuWhere, ActivityDescriptionDuWhere, ActivityDestinationDuWhere, ActivityGPSPointDuWhere, ActivityDateDuWhere, UserRateDuWhere, GuestRateDuWhere, VehicleTypeDuWhere, ActivityDurationDaysDuWhere);
               */

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
            if (vactivityfulltableorganizernameBindingSource.Current != null && participateBindingSource != null)
            {
                DataRowView objectDRV = (DataRowView)vactivityfulltableorganizernameBindingSource.Current;
                mcmpDataSet.vactivityfulltableorganizernameRow vactivityorgaRow = (mcmpDataSet.vactivityfulltableorganizernameRow)objectDRV.Row;

                //BUG : on a une erreur là car le BindingSource de participate est null forcément car on n'a pas de datagridview correspondant au participatebindingsource




                DialogResult dr = MessageBox.Show("Voulez-vous vraiment supprimer cette ligne?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                    using (TransactionScope objtransaction = new TransactionScope())
                    {


                        //TODO : Supprimer les inscriptions dans la table participate (le rajouter dans l'interface), inscrire tout ça dans une transaction 
                        int np = this.participateTableAdapter.DeleteActivity(vactivityorgaRow.id_activity);

                        
                        /*
                         * 
                         * DELETE FROM activity
                            WHERE        (id_activity = @pIdActivityDuWhere) 
                            AND (activity_name IS NULL OR activity_name = @pActivityNameDuWhere) 
                            AND (activity_description IS NULL OR activity_description = @pActivityDescriptionDuWhere) 
                            AND (activity_destination IS NULL OR activity_destination = @pActivityDestinationDuWhere) 
                            AND (activity_gps_point IS NULL OR activity_gps_point = @pActivityGPSPointDuWhere) 
                            AND (activity_date IS NULL OR activity_date = @pActivityDateDuWhere) 
                            AND (user_rate IS NULL OR user_rate = @pUserRateDuWhere) 
                            AND (guest_rate IS NULL OR guest_rate = @pGuestRateDuWhere) 
                            AND (vehicle_type IS NULL OR vehicle_type = @pVehicleTypeDuWhere) 
                            AND (activity_duration_days IS NULL OR activity_duration_days = @pActivityDurationDaysDuWhere) 
                            AND (id = @pIdOrganizerDuWhere)
                         * 
                         */


                        int n = this.activityTableAdapter.Delete(vactivityorgaRow.id_activity, vactivityorgaRow.id, vactivityorgaRow.activity_name, vactivityorgaRow.activity_description, vactivityorgaRow.activity_destination, vactivityorgaRow.activity_gps_point, vactivityorgaRow.activity_date, vactivityorgaRow.user_rate, vactivityorgaRow.guest_rate, vactivityorgaRow.vehicle_type, vactivityorgaRow.activity_duration_days);

                        this.vactivityfulltableorganizernameTableAdapter.Fill(this.mcmpDataSet.vactivityfulltableorganizername);

                        MessageBox.Show(n + "lignes supprimées");

                        if (n == 0)
                        {
                            MessageBox.Show("La transaction ne s'est pas déroulée correctement");
                        }
                        else
                        {
                            objtransaction.Complete();
                        }


                    }
                    MySqlConnection.ClearAllPools();
                }
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
                vactivityfulltableorganizernameBindingSource.Filter = @"activity_date > #" + dateTimePickerBeginDate.Text + "# AND activity_date < #" + dateTimePickerEndDate.Text + "#";

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
            dateTimePickerBeginDate.Value = DateTime.Today.AddYears(-1);
            dateTimePickerEndDate.Value = DateTime.Today.AddYears(+1);
            vactivityfulltableorganizernameBindingSource.RemoveFilter();
        }

        private void textBoxGPS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void btnChangePic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog objOpenfiledialog = new OpenFileDialog())
            {
                objOpenfiledialog.InitialDirectory = "C:\\Users\\cda5pani\\Pictures";
                objOpenfiledialog.Filter = "Image files | *.jpg; *.jpeg; *.png";
                DialogResult dr = objOpenfiledialog.ShowDialog();

                if (dr == DialogResult.OK)
                {

                    MessageBox.Show(objOpenfiledialog.FileName);
                    pictureBoxActivityImage.Load(objOpenfiledialog.FileName);

                    
                }
            }

        }
    }
}

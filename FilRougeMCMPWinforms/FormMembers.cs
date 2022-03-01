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
    public partial class FormMembers : Form
    {
        public FormMembers()
        {
            InitializeComponent();

            
        }

        private void FormMembers_Load(object sender, EventArgs e)
        {

            // TODO: cette ligne de code charge les données dans la table 'mcmpDataSet.users'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            RefreshTable();

        }

        private void RefreshTable()
        {
            this.usersTableAdapter.Fill(this.mcmpDataSet.users);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (usersBindingSource.Current != null)
            {
                DataRowView objectDRVMembers = (DataRowView)usersBindingSource.Current;
                mcmpDataSet.usersRow UsersRow = (mcmpDataSet.usersRow)objectDRVMembers.Row;



                String name = textBoxName.Text;
                String firstName = textFirstName.Text;
                String email = textBoxEmail.Text;
                byte IsOrganizer = (checkBoxIsOrganizer.Checked) ? (Byte)1 : (Byte)0;
                DateTime? DoB = dateTimePickerDOB.Value;
                byte[] profilePic = (byte[])null;
                String StreetNr = textBoxStreetNr.Text;
                String StreetName = textBoxAddress.Text;
                String ZipCode = textBoxZipCode.Text;
                String City = textBoxCity.Text;
                String Country = textBoxCountry.Text;


                String TelephoneNr = textBoxTelephoneNr.Text;
                DateTime? created_at = UsersRow.Iscreated_atNull() ? null : (DateTime?)UsersRow.created_at;
                DateTime? updated_at = UsersRow.Isupdated_atNull() ? null : (DateTime?)UsersRow.updated_at;
                String remember_token = null;
                Byte isActive = checkBoxIsActive.Checked ? (Byte)1 : (Byte)0;

                DateTime? crea_at = UsersRow.Iscreated_atNull() ? null : (DateTime?)UsersRow.created_at;
                DateTime? upda_at = UsersRow.Isupdated_atNull() ? null : (DateTime?)UsersRow.updated_at;
                String remem_tok = (UsersRow.Isremember_tokenNull()) ? null : UsersRow.remember_token;
                byte is_actDuWhere = (UsersRow.is_active)? (byte) 1 : (byte) 0;


                String NameduWhere = (UsersRow.IsnameNull()) ? null : UsersRow.name;
                String firstNameduWhere = (UsersRow.IsfirstnameNull()) ? null : UsersRow.firstname;
                String emailDuWhere = (UsersRow.IsemailNull()) ? null : UsersRow.email;
                byte isOrganizerduWhere = (UsersRow.is_organizer) ? (byte) 1 :(byte) 0;
                DateTime? DoBduWhere = UsersRow.IsdobNull() ? null : (DateTime?)UsersRow.dob;
                
                String StreetNrDuWhere = UsersRow.Isstreet_numberNull() ? null : UsersRow.street_number;
                String StreetNameDuWhere = UsersRow.Isstreet_nameNull() ? null : UsersRow.street_name;
                String ZipCodeDuWhere = UsersRow.Iszip_codeNull() ? null : UsersRow.zip_code;
                String CityduWhere = UsersRow.IscityNull() ? null : UsersRow.city;
                String CountryduWhere = UsersRow.IscountryNull() ? null : UsersRow.country;
                String TelephoneNumberduWhere = UsersRow.Istelephone_numberNull() ? null : UsersRow.telephone_number;


                /*
UPDATE       users
SET                name = @pName, firstname = @pFirstName, email = @pEmail, is_organizer = @pIsOrganizer, dob = @pDoB, profile_pic = @pProfilePic, street_number = @pStreetNr, street_name = @pStreetName, zip_code = @pZipCode, city = @pCity, country = @pCountry, telephone_number = @pTelephoneNr, 
                         created_at = @pCreatedAt, updated_at = @pUpdatedAt, remember_token = @pRememberToken, is_active = @pIsActive
WHERE        (id = @pUsersRowId) AND (created_at IS NULL OR
                         created_at = @pCrea_at) AND (updated_at IS NULL OR
                         updated_at = @pUpda_at) AND (remember_token IS NULL OR
                         remember_token = @pUsersRowremembertoken) AND (is_active = @pUsersRowisActive) AND (name IS NULL OR
                         name = @pUsersRowname) AND (firstname IS NULL OR
                         firstname = @pUsersRowFirstName) AND (email IS NULL OR
                         email = @pUsersRowEmail) AND (is_organizer IS NULL OR
                         is_organizer = @pUsersRowIsOrganizer) AND (dob IS NULL OR
                         dob = @pUsersRowDoB) AND (street_number IS NULL OR
                         street_number = @pUsersRowStreetNr) AND (street_name IS NULL OR
                         street_name = @pUsersRowStreetName) AND (zip_code IS NULL OR
                         zip_code = @pUsersRowZipCode) AND (city IS NULL OR
                         city = @pUsersRowCity) AND (country IS NULL OR
                         country = @pUsersRowCountry) AND (telephone_number IS NULL OR
                         telephone_number = @pUsersRowTelephoneNr)*/

                int id = UsersRow.id;

              

                int n = usersTableAdapter.UpdateQuery(name, firstName, email, IsOrganizer, DoB, StreetNr, StreetName, ZipCode, City, Country, TelephoneNr, created_at, updated_at, remember_token, isActive, UsersRow.id, crea_at, upda_at, remem_tok, is_actDuWhere, NameduWhere, firstNameduWhere, emailDuWhere, isOrganizerduWhere, DoBduWhere, StreetNrDuWhere, StreetNameDuWhere, ZipCodeDuWhere, CityduWhere, CountryduWhere, TelephoneNumberduWhere);

                /* usersTableAdapter.UpdateQuery(name, firstName, email, IsOrganizer, DoB, StreetNr, StreetName, ZipCode, City, Country, TelephoneNr, created_at, updated_at, remember_token, isActive, UsersRow.id, crea_at, upda_at, remem_tok, is_act, NameduWhere, firstNameduWhere, emailDuWhere, isOrganizerduWhere, DoBduWhere, StreetNrDuWhere, StreetNameDuWhere, ZipCodeDuWhere, CityduWhere, CountryduWhere, TelephoneNumberduWhere);*/

                MessageBox.Show(n + " éléments modifiés");


                RefreshTable();

                usersBindingSource.Position = usersBindingSource.Find("Id", id);
            }
        }

        private void textBoxFilterMembers_TextChanged(object sender, EventArgs e)
        {
            /*
             private void textBoxFilterActivity_KeyPress(object sender, KeyPressEventArgs e)
        {
            vactivityfulltableorganizernameBindingSource.Filter = $" activity_name LIKE '%{textBoxFilterActivity.Text}%' OR activity_description LIKE '%{textBoxFilterActivity.Text}%' OR activity_destination LIKE '%{textBoxFilterActivity.Text}%'";
        }
             */

            usersBindingSource.Filter = $"name LIKE '%{textBoxFilterMembers.Text}%' OR firstname LIKE '%{textBoxFilterMembers.Text}%' ";

        }

        private void btnResetSelection_Click(object sender, EventArgs e)
        {

            /*dateTimePickerBeginDate.Value = DateTime.Today;
            dateTimePickerEndDate.Value = DateTime.Today;
            vactivityfulltableorganizernameBindingSource.RemoveFilter();*/

            dateTimePickerDoBlimitbeginning.Value = DateTime.Today.AddYears(-70);
            dateTimePickerDoBLimitEnd.Value = DateTime.Today.AddDays(-50);

            textBoxFilterMembers.Text = "";
            
            usersBindingSource.RemoveFilter();
        }

        private void dateTimePickerDoBlimitbeginning_ValueChanged(object sender, EventArgs e)
        {

            dateTimePickerDoBLimitEnd.MinDate = dateTimePickerDoBlimitbeginning.Value.AddYears(1);

            usersBindingSource.Filter = $"dob> #{dateTimePickerDoBlimitbeginning.Text}# and dob< #{dateTimePickerDoBLimitEnd.Text}# ";
        }

        private void dateTimePickerDoBLimitEnd_ValueChanged(object sender, EventArgs e)
        {
            usersBindingSource.Filter = $"dob> #{dateTimePickerDoBlimitbeginning.Text}# and dob< #{dateTimePickerDoBLimitEnd.Text}# ";
        }
    }
}

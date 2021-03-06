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



        private void btnUpdate_Click(object sender, EventArgs e)
        {

            byte[] tableauProfilePicOctets;
            using (MemoryStream objStream = new MemoryStream())
            {
                if (pictureBoxUserProfilePic.Image != null)
                {
                    pictureBoxUserProfilePic.Image.Save(objStream, ImageFormat.Jpeg);
                    tableauProfilePicOctets = objStream.ToArray();
                }
                else
                {
                    tableauProfilePicOctets = null;
                }
            }


            if (usersBindingSource.Current != null)
            {
                DataRowView objectDRVMembers = (DataRowView)usersBindingSource.Current;
                mcmpDataSet.usersRow UsersRow = (mcmpDataSet.usersRow)objectDRVMembers.Row;



                String Name = textBoxName.Text;
                String firstName = textFirstName.Text;
                String email = textBoxEmail.Text;
                byte IsOrganizer = (checkBoxIsOrganizer.Checked) ? (Byte)1 : (Byte)0;
                DateTime? DoB = dateTimePickerDOB.Value;
                byte[] profilePic = tableauProfilePicOctets;
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
                byte? isOrganizerduWhere = (UsersRow.Isis_organizerNull())? null : ((UsersRow.is_organizer) ? (byte?)1 : (byte?)0);
                DateTime? DoBduWhere = UsersRow.IsdobNull() ? null : (DateTime?)UsersRow.dob;
                
                String StreetNrDuWhere = UsersRow.Isstreet_numberNull() ? null : UsersRow.street_number;
                String StreetNameDuWhere = UsersRow.Isstreet_nameNull() ? null : UsersRow.street_name;
                String ZipCodeDuWhere = UsersRow.Iszip_codeNull() ? null : UsersRow.zip_code;
                String CityduWhere = UsersRow.IscityNull() ? null : UsersRow.city;
                String CountryduWhere = UsersRow.IscountryNull() ? null : UsersRow.country;
                String TelephoneNumberduWhere = UsersRow.Istelephone_numberNull() ? null : UsersRow.telephone_number;

                byte[] ProfilePicDuWhere = UsersRow.Isprofile_picNull() ? null : (byte[]) UsersRow.profile_pic;


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


                /*UPDATE       users
SET                name = @pName, firstname = @pFirstName, email = @pEmail, is_organizer = @pIsOrganizer, dob = @pDoB, street_number = @pStreetNr, street_name = @pStreetName, zip_code = @pZipCode, city = @pCity, 
                         country = @pCountry, telephone_number = @pTelephoneNr, created_at = @pCreatedAt, updated_at = @pUpdatedAt, remember_token = @pRememberToken, is_active = @pIsActive, profile_pic = @pProfilePic
WHERE        (id = @pUsersRowId) AND (is_active = @pUsersRowisActive) AND (created_at IS NULL OR
                         created_at = @pCrea_at) AND (updated_at IS NULL OR
                         updated_at = @pUpda_at) AND (remember_token IS NULL OR
                         remember_token = @pUsersRowremembertoken) AND (name IS NULL OR
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
                         telephone_number = @pUsersRowTelephoneNr) AND (profile_pic IS NULL OR
                         profile_pic = @pProfilePic)*/



                int id = UsersRow.id;

                /*int n = usersTableAdapter.UpdateQuery(name, firstName, email, IsOrganizer, DoB, StreetNr, StreetName, ZipCode, City, Country, TelephoneNr, created_at, updated_at, remember_token, isActive, UsersRow.id, crea_at, upda_at, remem_tok, is_actDuWhere, NameduWhere, firstNameduWhere, emailDuWhere, isOrganizerduWhere, DoBduWhere, StreetNrDuWhere, StreetNameDuWhere, ZipCodeDuWhere, CityduWhere, CountryduWhere, TelephoneNumberduWhere);*/




                int n = usersTableAdapter.Update(Name, firstName, email, IsOrganizer, DoB, StreetNr, StreetName, ZipCode, City, Country, TelephoneNr, created_at, updated_at, remember_token, isActive, tableauProfilePicOctets, UsersRow.id, UsersRow.is_active, crea_at, upda_at, remem_tok, NameduWhere, firstNameduWhere, emailDuWhere, isOrganizerduWhere, DoBduWhere, StreetNrDuWhere, StreetNameDuWhere, ZipCodeDuWhere, CityduWhere, CountryduWhere, TelephoneNumberduWhere);






                /*int n = usersTableAdapter.UpdateQuery(name, firstName, email, IsOrganizer, DoB, StreetNr, StreetName, ZipCode, City, Country, TelephoneNr, created_at, updated_at, remember_token, isActive, UsersRow.id, crea_at, upda_at, remem_tok, is_actDuWhere, NameduWhere, firstNameduWhere, emailDuWhere, isOrganizerduWhere, DoBduWhere, StreetNrDuWhere, StreetNameDuWhere, ZipCodeDuWhere, CityduWhere, CountryduWhere, TelephoneNumberduWhere);*/

                /* usersTableAdapter.UpdateQuery(name, firstName, email, IsOrganizer, DoB, StreetNr, StreetName, ZipCode, City, Country, TelephoneNr, created_at, updated_at, remember_token, isActive, UsersRow.id, crea_at, upda_at, remem_tok, is_act, NameduWhere, firstNameduWhere, emailDuWhere, isOrganizerduWhere, DoBduWhere, StreetNrDuWhere, StreetNameDuWhere, ZipCodeDuWhere, CityduWhere, CountryduWhere, TelephoneNumberduWhere);*/

                MessageBox.Show(n + " éléments modifiés");


                RefreshTable();

                usersBindingSource.Position = usersBindingSource.Find("Id", id);
            }
        }

        private void textBoxFilterMembers_TextChanged(object sender, EventArgs e)
        {
        
            usersBindingSource.Filter = $"name LIKE '%{textBoxFilterMembers.Text}%' OR firstname LIKE '%{textBoxFilterMembers.Text}%' ";

        }

        private void btnResetSelection_Click(object sender, EventArgs e)
        {

            /*dateTimePickerBeginDate.Value = DateTime.Today;
            dateTimePickerEndDate.Value = DateTime.Today;
            vactivityfulltableorganizernameBindingSource.RemoveFilter();*/

            dateTimePickerDoBlimitbeginning.Value = DateTime.Today.AddYears(-80);
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

        private void BtnProfilePic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog objOpenfiledialog = new OpenFileDialog())
            {
                objOpenfiledialog.InitialDirectory = "C:\\Users\\cda5pani\\Pictures";
                objOpenfiledialog.Filter = "Image files | *.jpg; *.jpeg; *.png";
                DialogResult dr = objOpenfiledialog.ShowDialog();

                if (dr == DialogResult.OK)
                {

                    MessageBox.Show(objOpenfiledialog.FileName);
                    pictureBoxUserProfilePic.Load(objOpenfiledialog.FileName);


                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FormTokens : Form
    {
        public FormTokens()
        {
            InitializeComponent();
        }

        private void FormTokens_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'mcmpDataSet.banquejeton'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            RefreshTableJeton();

        }

        private void BtnGenerateToken_Click(object sender, EventArgs e)
        {

            Guid g = Guid.NewGuid();

            String token = g.ToString().Substring(1, 13);

            MessageBox.Show(token);

            int etat = 1;

            this.banquejetonTableAdapter.Insert(token, etat);
            RefreshTableJeton();
        }

        private void RefreshTableJeton()
        {
            this.banquejetonTableAdapter.Fill(this.mcmpDataSet.banquejeton);
        }
    }
}

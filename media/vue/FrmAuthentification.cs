using media.controleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media.vue
{
    public partial class FrmAuthentification : Form
    {
        Controle controle;

        /// <summary>
        /// frame auth
        /// </summary>
        /// <param name="controle"></param>
        public FrmAuthentification(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        /// <summary>
        /// gestion de la connexion sur le clique button se connecter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (!txtUtilisateur.Text.Equals("") && !txtPwd.Text.Equals(""))
            {
                if (!controle.VerifierAuthentification(txtUtilisateur.Text, txtPwd.Text))
                {
                    MessageBox.Show("Utilisateur et/ou mot de passe incorrecte.", "Information");
                    txtUtilisateur.Text = "";
                    txtPwd.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }
}

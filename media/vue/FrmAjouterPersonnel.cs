using media.controleur;
using media.modele;
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
    public partial class FrmAjouterPersonnel : Form
    {

        /// <summary>
        /// instance de controle
        /// </summary>
        private Controle controle;
        /// <summary>
        /// false ou true : permet de savoir si une modification est en cours ou non
        /// </summary>
        private Boolean modification = false;
        /// <summary>
        /// id du personnel que l'on modifie
        /// </summary>
        private int idPersonnelModifier;
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="controle"></param>
        public FrmAjouterPersonnel(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }






        /// <summary>
        /// modifier le personnel en recuperant les informations
        /// </summary>
        /// <param name="personnel"></param>

        public void ModifierPersonnel(Personnel personnel)
        {
            if (!(personnel is null))
            {
                modification = true;
                idPersonnelModifier = personnel.IdPersonnel;
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cboService.SelectedIndex = cboService.FindStringExact(personnel.Service);
            }
        }

    }
}

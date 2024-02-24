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
        /// objet pour les services
        /// </summary>
        BindingSource bdgServices = new BindingSource();
        /// <summary>
        /// id du personnel
        /// </summary>
        private int idPersonnelAModifier;
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="controle"></param>
        public FrmAjouterPersonnel(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            RemplirServices();
        }

        /// <summary>
        /// permet de preremlplir les services 
        /// </summary>
        public void RemplirServices()
        {
            List<Service> lesServices = controle.RecupererLesServices();
            bdgServices.DataSource = lesServices;
            cboService.DataSource = bdgServices;
            if (cboService.Items.Count > 0)
            {
                cboService.SelectedIndex = 0;
            }
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

        /// <summary>
        /// vider les champs
        /// </summary>
        public void ViderLesChamps()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtMail.Text = "";
            txtTel.Text = "";
            if (cboService.Items.Count > 0)
            {
                cboService.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// permet d'enregister le personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtMail.Text.Equals("") && !txtTel.Text.Equals("") && cboService.SelectedIndex != -1)
            {
                Service leService = (Service)bdgServices.List[bdgServices.Position];
                if (modification)
                {
                    Personnel personnelAModifier = new Personnel(idPersonnelAModifier, leService.IdService, txtNom.Text, txtPrenom.Text, leService.Nom, txtTel.Text, txtMail.Text);

                    if (MessageBox.Show("Souhaitez-vous confirmer la modification?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        controle.UpdatePersonnel(personnelAModifier);
                        modification = false;
                    }
                    else
                    {
                        controle.FermerFrameAjoutPersonnel();
                    }
                }
                else
                {
                    int idPersonnel = 0;
                    Personnel lePersonnel = new Personnel(idPersonnel, leService.IdService, txtNom.Text, txtPrenom.Text, leService.Nom, txtTel.Text, txtMail.Text);
                    controle.AddPersonnel(lePersonnel);
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doient être remplis.", "Information");
            }
        }

        /// <summary>
        /// permet de d'annuler l'affichage d'un nouveau personnel a ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            controle.FermerFrameAjoutPersonnel();

        }
    }
}

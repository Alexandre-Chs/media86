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

namespace media
{
    public partial class FrmPersonnel : Form
    {
        /// <summary>
        /// instance de la classe Controle
        /// </summary>
        private Controle controle;
        /// <summary>
        /// Objet pour gérer la liste du personnel.
        /// </summary>
        BindingSource bdgPersonnel = new BindingSource();


        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="controle"></param>
        public FrmPersonnel(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            RemplirPersonnel();
        }

        public void RemplirPersonnel()
        {
            List<Personnel> lePersonnel = controle.RecupererLePersonnel();
            bdgPersonnel.DataSource = lePersonnel;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.Columns["idservice"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        /// <summary>
        /// bouton pour ajouter du personnel, amene vers une autre frame
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPers_Click(object sender, EventArgs e)
        {
            controle.AjouterPersonnel();
        }

        /// <summary>
        /// permet de modifier le personnel selectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnModifierPers_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                controle.ModifierPersonnel(personnel);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un membre du personnel.", "Information");
            }
        }


        /// <summary>
        /// permet de supprimer le personnel selectionne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerPers_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Confirmez-vous la suppression de " + personnel.Prenom + " " + personnel.Nom + " de la liste?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<Absence> absences = controle.RecupererLesAbs(personnel);
                    foreach (Absence absence in absences)
                    {
                        controle.SupAbsence(absence, personnel);
                    }
                    controle.SupPersonnel(personnel);
                    RemplirPersonnel();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un personnel.", "Information");
            }
        }
    }
}

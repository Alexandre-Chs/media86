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
    public partial class FrmAjouterAbs : Form
    {
        /// <summary>
        /// instance de controle
        /// </summary>
        private Controle controle;
        /// <summary>
        /// instance de la classe personnel
        /// </summary>
        private Personnel personnelAbsence;
        /// <summary>
        /// get et set de personne 
        /// </summary>
        public Personnel PersonnelAbsence { get => personnelAbsence; set => personnelAbsence = value; }
        /// <summary>
        ///savoir si true/false la modification a lieu ou non
        /// </summary>
        private bool modificationAbsence = false;
        /// <summary>
        /// instance de Absence
        /// </summary>
        private Absence absenceAModifier;
        /// <summary>
        /// objet pour les raisons de l'absence
        /// </summary>
        BindingSource bdgRaisons = new BindingSource();
        public FrmAjouterAbs(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            RemplirRaisons();
        }
        /// <summary>
        /// remplir automatiquement les raisons de l'absence
        /// </summary>
        public void RemplirRaisons()
        {
            bdgRaisons.DataSource = controle.GetLesRaisons();
            cboRaison.DataSource = bdgRaisons;
            if (cboRaison.Items.Count > 0)
            {
                cboRaison.SelectedIndex = 0;
            }
        }
        /// <summary>
        /// modifier l'absence
        /// </summary>
        /// <param name="absence"></param>
        /// <param name="personnel"></param>
        public void ModifierAbsence(Absence absence, Personnel personnel)
        {
            if (!(absence is null))
            {
                modificationAbsence = true;
                absenceAModifier = absence;
                personnelAbsence = personnel;
                dtpDebut.Value = DateTime.Parse(absence.DateDebut);
                dtpFin.Value = DateTime.Parse(absence.DateFin);
                cboRaison.SelectedIndex = cboRaison.FindStringExact(absence.Motif);
            }
        }


        /// <summary>
        /// remet a zero les champs
        /// </summary>
        public void ReinitialiserLesChamps()
        {
            dtpDebut.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
            if (cboRaison.Items.Count > 0)
            {
                cboRaison.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// permet d'enregister la nouvelle absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!dtpDebut.Value.Equals("") && !dtpFin.Value.Equals("") && cboRaison.SelectedIndex != -1)
            {
                if (dtpDebut.Value.Date <= dtpFin.Value.Date)
                {
                    Raison motif = (Raison)bdgRaisons.List[bdgRaisons.Position];
                    Absence nouvelleAbsence = new Absence((int)personnelAbsence.IdPersonnel, ((DateTime)dtpDebut.Value).ToString("yyyy-MM-dd"), (int)motif.IdMotif, (string)motif.Libelle, ((DateTime)dtpFin.Value).ToString("yyyy-MM-dd"));
                    if (modificationAbsence)
                    {
                        if ((MessageBox.Show("Souhaitez-vous confirmer la modification?", "Confirmation de modification", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                        {
                            modificationAbsence = false;
                            controle.UpdateAbsence(absenceAModifier, nouvelleAbsence, personnelAbsence);
                        }
                        else
                        {
                            controle.FermerFrameAbsence(personnelAbsence);
                        }
                    }
                    else
                    {
                        controle.AddAbsence(nouvelleAbsence, personnelAbsence);
                    }
                }
                else
                {
                    MessageBox.Show("La date de fin de l'absence ne peut être inférieure à la date de début.", "Information");
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }
}

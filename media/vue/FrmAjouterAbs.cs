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






        public FrmAjouterAbs(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
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
    }
}

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
    public partial class FrmAbsences : Form
    {
        /// <summary>
        /// instance de la classe Controle
        /// </summary>
        private Controle controle;
        /// <summary>
        /// Instance de personnel
        /// </summary>
        private Personnel personnelAbsence;
        /// <summary>
        /// obj pour les absences
        /// </summary>
 

        BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="controle"></param>
        public FrmAbsences(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }




        /// <summary>
        /// remplir les absences dans la frame
        /// </summary>
        /// <param name="personnel"></param>
        public void RemplirListeAbsences(Personnel personnel)
        {
            personnelAbsence = personnel;
            List<Absence> lesAbsences = controle.RecupererLesAbs(personnel);
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = false;
            dgvAbsences.Columns["idmotif"].Visible = false;
            dgvAbsences.Columns["datedebut"].HeaderText = "Date début";
            dgvAbsences.Columns["datefin"].HeaderText = "Date fin";
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

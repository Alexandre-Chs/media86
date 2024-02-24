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
    }
}

using media.dal;
using media.vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.controleur
{
    public class Controle
    {

        /// <summary>
        /// Vue interface absences
        /// </summary>
        FrmAbsences frmAbsences;
        /// <summary>
        /// Vue interface absences
        /// </summary>
        FrmAjouterAbs frmAjouterAbs;
        /// <summary>
        /// Vue ajouter le personnel
        /// </summary>
        FrmAjouterPersonnel frmAjouterPersonnel;
        /// <summary>
        /// Vue pour l'auth
        /// </summary>
        FrmAuthentification frmAuthentification;
        /// <summary>
        /// Vue pour le personnel
        /// </summary>
        FrmPersonnel frmPersonnel;


        public Controle()
        {
            frmPersonnel = new FrmPersonnel(this);
            frmAjouterPersonnel = new FrmAjouterPersonnel(this);
            frmAjouterAbs = new FrmAjouterAbs(this);
            frmAbsences = new FrmAbsences(this);
            frmAuthentification = new FrmAuthentification(this);
            frmAuthentification.ShowDialog();
        }

        public bool VerifierAuthentification(string utilisateur, string motdepasse)
        {
            if (Access.Authentification(utilisateur, motdepasse))
            {
                frmAuthentification.Hide();
                frmPersonnel.ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

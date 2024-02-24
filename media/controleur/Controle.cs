using media.dal;
using media.modele;
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


        /// <summary>
        /// setup les vues
        /// </summary>
        public Controle()
        {
            frmPersonnel = new FrmPersonnel(this);
            frmAjouterPersonnel = new FrmAjouterPersonnel(this);
            frmAjouterAbs = new FrmAjouterAbs(this);
            frmAbsences = new FrmAbsences(this);
            frmAuthentification = new FrmAuthentification(this);
            frmAuthentification.ShowDialog();
        }
        /// <summary>
        /// verifier l'user avec l'interface visuel
        /// </summary>
        /// <param name="utilisateur"></param>
        /// <param name="motdepasse"></param>
        /// <returns></returns>
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

        /// <summary>
        /// permet de récuperer le personnel
        /// </summary>
        /// <returns></returns>
        public List<Personnel> RecupererLePersonnel()
        {
            return Access.RecupererLePers();
        }


        /// <summary>
        /// 
        /// permet d'ouvrir la frame ajout du personnel
        /// </summary>
        public void AjouterPersonnel()
        {
            frmAjouterPersonnel.Text = "Ajouter personnel";
            frmAjouterPersonnel.ShowDialog();
        }


        /// <summary>
        /// difference entre ajouter et modifier : modifier donne directement les infos de la personne à modifier.
        /// </summary>
        /// <param name="personnel"></param>
        public void ModifierPersonnel(Personnel personnel)
        {
            frmAjouterPersonnel.Text = "Modifier personnel";
            frmAjouterPersonnel.ModifierPersonnel(personnel);
            frmAjouterPersonnel.ShowDialog();
        }


    }
}

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


            /// <summary>
            /// permet de recuperer les absences
            /// </summary>
            /// <param name="personnel"></param>
            /// <returns></returns>
        public List<Absence> RecupererLesAbs(Personnel personnel)
        {
            return Access.RecupererLesAbs(personnel);
        }

        /// <summary>
        /// permet de supprimer une absence
        /// </summary>
        /// <param name="absence"></param>
        /// <param name="personnelAbsence"></param>
        public void SupAbsence(Absence absence, Personnel personnelAbsence)
        {
            Access.SupAbsence(absence, personnelAbsence);
        }



        /// <summary>
        /// permet de supprimer un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void SupPersonnel(Personnel personnel)
        {
            Access.SupPersonnel(personnel);
        }

        /// <summary>
        /// voir les absences
        /// </summary>
        /// <param name="personnel"></param>
        public void ShowAbsence(Personnel personnel)
        {
            frmAbsences.RemplirListeAbsences(personnel);
            frmAbsences.Text = "MediaTek86 - Absences " + personnel.Prenom + " " + personnel.Nom;
            frmAbsences.ShowDialog();
        }



        /// <summary>
        /// ajouter une absence
        /// </summary>
        /// <param name="personnelAbsence"></param>
        public void AjouterAbsence(Personnel personnelAbsence)
        {
            frmAjouterAbs.Text = "Ajouter absence";
            frmAjouterAbs.PersonnelAbsence = personnelAbsence;
            frmAjouterAbs.ShowDialog();
        }

        /// <summary>
        /// permet de modifer l'absence
        /// </summary>
        /// <param name="absence"></param>
        /// <param name="personnel"></param>
        public void ModifierAbsence(Absence absence, Personnel personnel)
        {
            frmAjouterAbs.Text = "Modifier absence";
            frmAjouterAbs.ModifierAbsence(absence, personnel);
            frmAjouterAbs.ShowDialog();
        }

        /// <summary>
        /// retour vers personnel en fermant la frame absence
        /// </summary>
        public void FermerAbsences()
        {
            frmAbsences.Hide();
        }



        /// <summary>
        /// permet d'avoir les raisons d'une absence
        /// </summary>
        /// <returns></returns>

        public List<Raison> GetLesRaisons()
        {
            return Access.GetLesRaisons();
        }



        /// <summary>
        /// permet d'update une absence
        /// </summary>
        /// <param name="absenceAModifier"></param>
        /// <param name="nouvelleAbsence"></param>
        /// <param name="personnel"></param>
        public void UpdateAbsence(Absence absenceAModifier, Absence nouvelleAbsence, Personnel personnel)
        {
            Access.UpdateAbsence(absenceAModifier, nouvelleAbsence);
            FermerFrameAbsence(personnel);
        }

        /// <summary>
        /// permet de fermer la frame absence
        /// </summary>
        /// <param name="personnelAbsence"></param>
        public void FermerFrameAbsence(Personnel personnelAbsence)
        {
            frmAjouterAbs.ReinitialiserLesChamps();
            frmAbsences.RemplirListeAbsences(personnelAbsence);
            frmAjouterAbs.Hide();
        }

        /// <summary>
        /// permet de modifier un membre du personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void UpdatePersonnel(Personnel personnel)
        {
            Access.UpdatePersonnel(personnel);
            FermerFrameAjoutPersonnel();
        }



        /// <summary>
        /// ferme la frame personnel ajout
        /// </summary>
        public void FermerFrameAjoutPersonnel()
        {
            frmAjouterPersonnel.ViderLesChamps();
            frmAjouterPersonnel.Hide();
            frmPersonnel.RemplirPersonnel();
        }


        /// <summary>
        /// methode qui permet de fermer la vue et d'initialiser des
        /// </summary>
        /// <param name="absence"></param>
        /// <param name="personnelAbsence"></param>
        public void AddAbsence(Absence absence, Personnel personnelAbsence)
        {
            Access.AddAbsence(absence);
            FermerFrameAbsence(personnelAbsence);
        }


        /// <summary>
        /// permet d'ajouter un personnel 
        /// </summary>
        /// <param name="personnel"></param>
        public void AddPersonnel(Personnel personnel)
        {
            Access.AddPersonnel(personnel);
            FermerFrameAjoutPersonnel();
        }

        public List<Service> RecupererLesServices()
        {
            return Access.RecupererLesServices();
        }
    }
}

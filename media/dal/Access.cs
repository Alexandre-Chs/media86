using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using media.modele;

namespace media.dal
{
    public class Access
    {
        /// <summary>
        /// nom de connexion à la bdd
        /// </summary>
        private static readonly string connectionName = "server=localhost;user id=root; password=; database=mediatek; Sslmode=none";

        /// <summary>
        /// gère l'auth sur la vue auth
        /// </summary>
        /// <param name="utilisateur"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static Boolean Authentification(string utilisateur, string pwd)
        {
            string req = "SELECT * FROM responsable where login=@login and pwd=@pwd;";
            BddManager cursor = BddManager.GetInstance(connectionName);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", utilisateur);
            parameters.Add("@pwd", GetStringSha256Hash(pwd).ToLower());
            cursor.ReqSelect(req, parameters);

            if (cursor.Read())
            {
                cursor.Close();
                return true;
            }
            else
            {
                cursor.Close();
                return false;
            }
        }

        /// <summary>
        /// Méthode qui retourne le hash d'une chaîne passé en entrée.
        /// </summary>
        /// <param name="motdepasse">La chaine dont on veut récupérer un hash.</param>
        /// <returns>Le hash de la chaîne passé en entrée.</returns>
        private static string GetStringSha256Hash(string motdepasse)
        {
            if (string.IsNullOrEmpty(motdepasse)) return string.Empty;
            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(motdepasse);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }


        /// <summary>
        /// recuperer le personnel
        /// </summary>
        /// <returns></returns>
        public static List<Personnel> RecupererLePers()
        {
            List<Personnel> lePersonnel = new List<Personnel>();
            string req = "select p.idpersonnel as idpersonnel, p.idservice as idservice, p.nom as nom, p.prenom as prenom, s.nom as service, p.tel as tel, p.mail as mail ";
            req += "from personnel p join service s on p.idservice = s.idservice order by nom, prenom;";
            BddManager curseur = BddManager.GetInstance(connectionName);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                lePersonnel.Add(new Personnel((int)curseur.Field("idpersonnel"), (int)curseur.Field("idservice"), (string)curseur.Field("nom"), (string)curseur.Field("prenom"), (string)curseur.Field("service"), (string)curseur.Field("tel"), (string)curseur.Field("mail")));
            }
            curseur.Close();
            return lePersonnel;
        }



        /// <summary>
        /// permet de recuperer les absences
        /// </summary>
        /// <param name="personnel"></param>
        /// <returns></returns>
        public static List<Absence> RecupererLesAbs(Personnel personnel)
        {
            List<Absence> lesAbsences = new List<Absence>();
            string req = "select a.datedebut, a.idmotif as 'idmotif', m.libelle as 'motif', a.datefin from absence a join motif m on a.idmotif = m.idmotif ";
            req += "where idpersonnel = @idpersonnel order by datedebut desc;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            BddManager curseur = BddManager.GetInstance(connectionName);
            curseur.ReqSelect(req, parameters);
            while (curseur.Read())
            {
                string dateDebut = ((DateTime)curseur.Field("datedebut")).ToString("dd/MM/yyyy");
                string dateFin = ((DateTime)curseur.Field("datefin")).ToString("dd/MM/yyyy");
                Absence absence = new Absence((int)personnel.IdPersonnel, dateDebut, (int)curseur.Field("idmotif"), (string)curseur.Field("motif"), dateFin); lesAbsences.Add(absence);
            }
            curseur.Close();
            return lesAbsences;
        }




        /// <summary>
        /// supprime une absence
        /// </summary>
        /// <param name="absence"></param>
        /// <param name="personnelAbsence"></param>
        public static void SupAbsence(Absence absence, Personnel personnelAbsence)
        {
            string dateDebut = DateTime.Parse(absence.DateDebut).ToString("yyyy-MM-dd");
            string req = "delete from absence where idpersonnel = @idpersonnel and DATE(datedebut) = @datedebut;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnelAbsence.IdPersonnel);
            parameters.Add("@datedebut", dateDebut);
            BddManager connection = BddManager.GetInstance(connectionName);
            connection.ReqUpdate(req, parameters);
            connection.Close();
        }


        /// <summary>
        /// permet de supprimer un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public static void SupPersonnel(Personnel personnel)
        {
            string req = "delete from personnel where idpersonnel = @idpersonnel";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            BddManager connection = BddManager.GetInstance(connectionName);
            connection.ReqUpdate(req, parameters);
            connection.Close();
        }




        /// <summary>
        /// permet de recuperer les raisons dans la table motif de la bdd
        /// </summary>
        /// <returns></returns>
        public static List<Raison> GetLesRaisons()
        {
            List<Raison> lesMotifs = new List<Raison>();
            string req = "select * from motif order by idmotif";
            BddManager curseur = BddManager.GetInstance(connectionName);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Raison motif = new Raison((int)curseur.Field("idmotif"), (string)curseur.Field("libelle"));
                lesMotifs.Add(motif);
            }
            curseur.Close();
            return lesMotifs;
        }




        /// <summary>
        /// permet d'update une absence dans la bdd
        /// </summary>
        /// <param name="absenceAModifier"></param>
        /// <param name="nouvelleAbsence"></param>
        public static void UpdateAbsence(Absence absenceAModifier, Absence nouvelleAbsence)
        {
            string ancienneDateDebut = DateTime.Parse(absenceAModifier.DateDebut).ToString("yyyy-MM-dd");
            string req = "update absence set datedebut = @nouveaudatedebut, idmotif = @idmotif, datefin = @datefin ";
            req += "where idpersonnel = @idpersonnel and DATE(datedebut) = @anciennedatedebut;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nouveaudatedebut", nouvelleAbsence.DateDebut);
            parameters.Add("idmotif", nouvelleAbsence.IdMotif);
            parameters.Add("datefin", nouvelleAbsence.DateFin);
            parameters.Add("idpersonnel", absenceAModifier.IdPersonnel);
            parameters.Add("@anciennedatedebut", ancienneDateDebut);
            BddManager connection = BddManager.GetInstance(connectionName);
            connection.ReqUpdate(req, parameters);
            connection.Close();
        }



        /// <summary>
        /// ajouter abs dans la bdd
        /// </summary>
        /// <param name="absence"></param>
        public static void AddAbsence(Absence absence)
        {
            string req = "insert into absence(idpersonnel, datedebut, idmotif, datefin) ";
            req += "values(@idpersonnel, @datedebut, @idmotif, @datefin);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.IdPersonnel);
            parameters.Add("@datedebut", absence.DateDebut);
            parameters.Add("@idmotif", absence.IdMotif);
            parameters.Add("@datefin", absence.DateFin);
            BddManager connection = BddManager.GetInstance(connectionName);
            connection.ReqUpdate(req, parameters);
            connection.Close();
        }

        /// <summary>
        /// permet de recuperer les services dans la bdd
        /// </summary>
        /// <returns></returns>
        public static List<Service> RecupererLesServices()
        {
            List<Service> lesServices = new List<Service>();
            string req = "select * from service order by idservice";
            BddManager curseur = BddManager.GetInstance(connectionName);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Service service = new Service((int)curseur.Field("idservice"), (string)curseur.Field("nom"));
                lesServices.Add(service);
            }
            curseur.Close();
            return lesServices;
        }

        /// <summary>
        /// modifier le personnel dans la bdd
        /// </summary>
        /// <param name="personnel"></param>
        public static void UpdatePersonnel(Personnel personnel)
        {
            string req = "update personnel set idservice = @idservice, nom = @nom, prenom = @prenom, tel = @tel, mail = @mail ";
            req += "where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            parameters.Add("@idservice", personnel.IdService);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            BddManager connection = BddManager.GetInstance(connectionName);
            connection.ReqUpdate(req, parameters);
            connection.Close();
        }




        /// <summary>
        /// permet de rajouter du personnel dans la bdd
        /// </summary>
        /// <param name="personnel"></param>
        public static void AddPersonnel(Personnel personnel)
        {
            string req = "insert into personnel(idpersonnel, idservice, nom, prenom, tel, mail) ";
            req += "values(@idpersonnel, @idservice, @nom, @prenom, @tel, @mail);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            parameters.Add("@idservice", personnel.IdService);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            BddManager connection = BddManager.GetInstance(connectionName);
            connection.ReqUpdate(req, parameters);
            connection.Close();
        }
    }
}


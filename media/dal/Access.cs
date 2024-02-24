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

    }
}


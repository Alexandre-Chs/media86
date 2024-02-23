using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace media.dal
{
    public class Access
    {
        /// <summary>
        /// nom de connexion à la bdd
        /// </summary>
        private static readonly string connectionName = "server=localhost;user id=root; password=; database=mediatek; Sslmode=none";

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
    }
}


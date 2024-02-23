using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace media.dal
{
    class BddManager
    {
        /// <summary>
        /// instance unique de la classe
        /// </summary>
        private static BddManager instance = null;
        /// <summary>
        /// objet de connexion à la BDD à partir d'une chaîne de connexion
        /// </summary>
        private readonly MySqlConnection connection;
        /// <summary>
        /// obj qui contient le result d'une requete SQL select
        /// </summary>
        private MySqlDataReader reader;
        /// <summary>
        /// obj qui exect les requetes sql
        /// </summary>
        private MySqlCommand command;
        /// <summary>
        /// Constructeur pour créer la connexion à la BDD et l'ouvrir
        /// </summary>
        /// <param name="stringConnect">chaine de connexion</param>
        private BddManager(string stringConnect)
        {
            connection = new MySqlConnection(stringConnect);
            connection.Open();
        }

        /// <summary>
        /// Création d'une seule instance de la classe
        /// </summary>
        /// <param name="stringConnect">chaine de connexion</param>
        /// <returns>instance unique de la classe</returns>
        public static BddManager GetInstance(string stringConnect)
        {
            if (instance == null)
            {
                instance = new BddManager(stringConnect);
            }
            return instance;
        }

        /// <summary>
        /// methode qui lit la ligne du curseur
        /// </summary>
        /// <returns></returns>
        public Boolean Read()
        {
            if (reader is null)
            {
                return false;
            }
            try
            {
                return reader.Read();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Methode qui ferme le curseur
        /// </summary>
        public void Close()
        {
            if (!(reader is null))
            {
                reader.Close();
            }
        }

        /// <summary>
        /// Méthode qui gère les requêtes SQL 'select'.
        /// </summary>
        /// <param name="chaineRequete">Châine requête SQL 'select'.</param>
        /// <param name="parameters">Dictionnaire qui contient les paramètres.</param>
        public void ReqSelect(string chaineRequete, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(chaineRequete, connection);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                reader = command.ExecuteReader();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.modele
{
    public class Service
    {
        /// <summary>
        /// idService de la table 'service'
        /// </summary>
        private int idService;
        /// <summary>
        /// nom de la table 'service'
        /// </summary>
        private string nom;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="idService">idService du service.</param>
        /// <param name="nom">Nom du service.</param>
        public Service(int idService, string nom)
        {
            this.idService = idService;
            this.nom = nom;
        }

        /// <summary>
        /// get de idservice
        /// </summary>
        public int IdService { get => idService; }
        /// <summary>
        /// get de nom
        /// </summary>
        public string Nom { get => nom; }

        /// <summary>
        /// methode toString()
        /// </summary>
        /// <returns>Le nom du service.</returns>
        public override string ToString()
        {
            return nom;
        }
    }
}

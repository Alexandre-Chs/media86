using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.modele
{
    public class Personnel
    {
        /// <summary>
        /// idPersonnel de la table 'personnel'
        /// </summary>
        private int idPersonnel;
        /// <summary>
        /// idService de la table 'personnel'
        /// </summary>
        private int idService;
        /// <summary>
        /// libellé service de la table 'service'
        /// </summary>
        private string service;
        /// <summary>
        /// nom de la table 'personnel'
        /// </summary>
        private string nom;
        /// <summary>
        /// prenom de la table 'personnel'
        /// </summary>
        private string prenom;
        /// <summary>
        /// tel de la table 'personnel'
        /// </summary>
        private string tel;
        /// <summary>
        /// mail de la table 'personnel'
        /// </summary>
        private string mail;

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="idPersonnel">idPersonnel du membre du personnel.</param>
        /// <param name="idService">idService du membre du personnel.</param>
        /// <param name="nom">Nom du membre du personnel.</param>
        /// <param name="prenom">Prénom du membre du personnel.</param>
        /// <param name="service">Service du membre du personnel.</param>
        /// <param name="tel">Téléphone du membre du personnel.</param>
        /// <param name="mail">Adresse mail du membre du personnel.</param>
        public Personnel(int idPersonnel, int idService, string nom, string prenom, string service, string tel, string mail)
        {
            this.idPersonnel = idPersonnel;
            this.idService = idService;
            this.nom = nom;
            this.prenom = prenom;
            this.service = service;
            this.tel = tel;
            this.mail = mail;
        }

        /// <summary>
        /// get et set sur idpersonnel
        /// </summary>
        public int IdPersonnel { get => idPersonnel; set => idPersonnel = value; }
        /// <summary>
        /// get et set sur idservice 
        /// </summary>
        public int IdService { get => idService; set => idService = value; }
        /// <summary>
        /// get et set de nom
        /// </summary>
        public string Nom { get => nom; set => nom = value; }
        /// <summary>
        /// get et set de prenom
        /// </summary>
        public string Prenom { get => prenom; set => prenom = value; }
        /// <summary>
        /// get et set de service
        /// </summary>
        public string Service { get => service; set => service = value; }
        /// <summary>
        /// get et set de tel
        /// </summary>
        public string Tel { get => tel; set => tel = value; }
        /// <summary>
        /// get et set de mail
        /// </summary>
        public string Mail { get => mail; set => mail = value; }
    }
}

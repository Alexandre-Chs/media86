using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.modele
{
    public class Absence
    {
        /// <summary>
        /// idPersonnel de la table 'absence'
        /// </summary>
        private int idPersonnel;
        /// <summary>
        /// dateDebut de la table 'absence'
        /// </summary>
        private string dateDebut;
        /// <summary>
        /// idmotif de la table 'absence'
        /// </summary>
        private int idMotif;
        /// <summary>
        /// libelle motif de la table 'motif'
        /// </summary>
        private string motif;
        /// <summary>
        /// dateFin de la table 'absence'
        /// </summary>
        private string dateFin;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="idPersonnel">idPersonnel du membre du personnel.</param>
        /// <param name="dateDebut">La date de début de l'absence.</param>
        /// <param name="idMotif">idMotif de l'absence.</param>
        /// <param name="motif">Libellé motif de l'absence.</param>
        /// <param name="dateFin">La date de fin de l'absence.</param>
        public Absence(int idPersonnel, string dateDebut, int idMotif, string motif, string dateFin)
        {
            this.idPersonnel = idPersonnel;
            this.dateDebut = dateDebut;
            this.idMotif = idMotif;
            this.motif = motif;
            this.dateFin = dateFin;
        }

        /// <summary>
        /// get et set de idpersonnel
        /// </summary>
        public int IdPersonnel { get => idPersonnel; set => idPersonnel = value; }
        /// <summary>
        /// get et set de date debut
        /// </summary>
        public string DateDebut { get => dateDebut; set => dateDebut = value; }
        /// <summary>
        /// get et set de idmotif
        /// </summary>
        public int IdMotif { get => idMotif; set => idMotif = value; }
        /// <summary>
        /// get et set de datefin
        /// </summary>
        public string DateFin { get => dateFin; set => dateFin = value; }
        /// <summary>
        /// get et set de motif
        /// </summary>
        public string Motif { get => motif; set => motif = value; }
    }
}

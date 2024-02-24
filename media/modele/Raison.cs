using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.modele
{
    public class Raison
    {
        /// <summary>
        /// iidRaison de la table motif
        /// </summary>
        private int idMotif;
        /// <summary>
        /// libellé de la table motif 
        /// </summary>
        private string libelle;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="idMotif">idMotif du raison.</param>
        /// <param name="libelle">Libellé du raison.</param>
        public Raison(int idMotif, string libelle)
        {
            this.idMotif = idMotif;
            this.libelle = libelle;
        }

        /// <summary>
        ///get de idmotif
        /// </summary>
        public int IdMotif { get => idMotif; }
        /// <summary>
        /// get de libelle
        /// </summary>
        public string Libelle { get => libelle; }

        /// <summary>
        ///methode toString()
        /// </summary>
        /// <returns>Le libellé du raison.</returns>
        public override string ToString()
        {
            return libelle;
        }
    }
}

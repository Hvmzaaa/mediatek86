using System;

namespace mediatek86.modele
{
    /// <summary>
    /// Classe métier représentant une absence
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Récupère ou définit l'identifiant du personnel concerné
        /// </summary>
        public int IdPersonnel { get; set; }

        /// <summary>
        /// Récupère ou définit la date de début de l'absence
        /// </summary>
        public DateTime DateDebut { get; set; }

        /// <summary>
        /// Récupère ou définit l'identifiant du motif d'absence
        /// </summary>
        public int IdMotif { get; set; }

        /// <summary>
        /// Récupère ou définit le libellé du motif d'absence
        /// </summary>
        public string Motif { get; set; }

        /// <summary>
        /// Constructeur pour valoriser les propriétés d'une absence
        /// </summary>
        public Absence(int idPersonnel, DateTime dateDebut, int idMotif, string motif)
        {
            this.IdPersonnel = idPersonnel;
            this.DateDebut = dateDebut;
            this.IdMotif = idMotif;
            this.Motif = motif;
        }
    }
}
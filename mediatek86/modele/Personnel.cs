using System;

namespace mediatek86.modele
{
    /// <summary>
    /// Classe métier représentant un membre du personnel
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Récupère ou définit l'identifiant du personnel
        /// </summary>
        public int IdPersonnel { get; set; }

        /// <summary>
        /// Récupère ou définit le nom du personnel
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Récupère ou définit le prénom du personnel
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Récupère ou définit le numéro de téléphone
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// Récupère ou définit l'adresse email
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Récupère ou définit l'identifiant du service associé
        /// </summary>
        public int IdService { get; set; }

        /// <summary>
        /// Récupère ou définit le nom du service associé
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// Constructeur pour valoriser les propriétés du personnel
        /// </summary>
        public Personnel(int idPersonnel, string nom, string prenom, string tel, string mail, int idService, string service)
        {
            this.IdPersonnel = idPersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.IdService = idService;
            this.Service = service;
        }
    }
}
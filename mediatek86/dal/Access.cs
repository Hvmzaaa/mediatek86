using System;
using mediatek86.bddmanager;

namespace mediatek86.dal
{
    /// <summary>
    /// Classe de base pour l'accès aux données
    /// </summary>
    public class Access
    {
        /// <summary>
        /// Chaîne de connexion à la base de données
        /// </summary>
        private static readonly string connectionString = "server=localhost;user id=root;password=;database=mediatek86;";

        /// <summary>
        /// Instance unique du gestionnaire de base de données
        /// </summary>
        protected static BddManager bddManager;

        /// <summary>
        /// Constructeur qui initialise la connexion si ce n'est pas déjà fait
        /// </summary>
        public Access()
        {
            if (bddManager == null)
            {
                bddManager = BddManager.GetInstance();
                bddManager.ReqUpdate(connectionString);
            }
        }
    }
}
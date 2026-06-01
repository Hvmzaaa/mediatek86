using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Contrôle les identifiants de connexion d'un responsable
        /// </summary>
        /// <param name="login">Login saisi</param>
        /// <param name="pwd">Mot de passe saisi</param>
        /// <returns>True si les identifiants sont corrects, False sinon</returns>
        public bool ControlerConnexion(string login, string pwd)
        {
            string req = "select * from responsable where login = @login and pwd = SHA2(@pwd, 256)";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@login", login },
                { "@pwd", pwd }
            };
            try
            {
                bddManager.ReqSelect(req, parameters);
                if (bddManager.Read())
                {
                    bddManager.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            bddManager.Close();
            return false;
        }
    }
}
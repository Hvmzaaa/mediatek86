using System;
using mediatek86.dal;
using mediatek86.vue;

namespace mediatek86.controleur
{
    /// <summary>
    /// Contrôleur général de l'application
    /// </summary>
    public class Controle
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Fenêtre de connexion
        /// </summary>
        private FrmLogin frmLogin;

        /// <summary>
        /// Constructeur de la classe qui initialise les accès aux données et lance l'authentification
        /// </summary>
        public Controle()
        {
            access = new Access();
            LanceApplication();
        }

        /// <summary>
        /// Lance la fenêtre de connexion
        /// </summary>
        private void LanceApplication()
        {
            frmLogin = new FrmLogin(this);
            frmLogin.ShowDialog();
        }

        /// <summary>
        /// Demande la vérification des identifiants et ouvre l'application si OK
        /// </summary>
        /// <param name="login">Login de l'utilisateur</param>
        /// <param name="pwd">Mot de passe de l'utilisateur</param>
        /// <returns>True si connexion réussie</returns>
        public bool ControlerConnexion(string login, string pwd)
        {
            if (access.ControlerConnexion(login, pwd))
            {
                frmLogin.Hide();
                // C'est ici qu'on ouvrira plus tard la fenêtre FrmPersonnel !
                return true;
            }
            return false;
        }
    }
}
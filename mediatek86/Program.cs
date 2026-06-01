using System;
using System.Windows.Forms;
using mediatek86.controleur;

namespace mediatek86
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Lancement du contrôleur général au lieu de la vue directe
            new Controle();
        }
    }
}
using System;
using System.Windows.Forms;
using mediatek86.controleur;

namespace mediatek86.vue
{
    /// <summary>
    /// Fenêtre de connexion à l'application
    /// </summary>
    public partial class FrmLogin : Form
    {
        /// <summary>
        /// Instance du contrôleur général
        /// </summary>
        private readonly Controle controle;

        /// <summary>
        /// Constructeur de la fenêtre de connexion
        /// </summary>
        /// <param name="controle">Instance du contrôleur passée en paramètre</param>
        public FrmLogin(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;

            // Masque les caractères saisis dans le champ mot de passe
            txtPwd.PasswordChar = '*';
        }

        /// <summary>
        /// Événement lors du clic sur le bouton "se connecter"
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtLogin.Text.Equals("") && !txtPwd.Text.Equals(""))
            {
                if (!controle.ControlerConnexion(txtLogin.Text, txtPwd.Text))
                {
                    MessageBox.Show("Identifiants incorrects ou utilisateur non autorisé.", "Alerte");
                    txtPwd.Text = "";
                    txtLogin.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }
    }
}
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace mediatek86.bddmanager
{
    /// <summary>
    /// Gestionnaire de connexion avec la base de données
    /// </summary>
    public class BddManager
    {
        /// <summary>
        /// Instance unique de la classe (Singleton)
        /// </summary>
        private static BddManager instance = null;

        /// <summary>
        /// Objet de connexion à la base de données
        /// </summary>
        private MySqlConnection connection;

        /// <summary>
        /// Objet d'exécution des commandes SQL
        /// </summary>
        private MySqlCommand command;

        /// <summary>
        /// Objet de lecture des résultats de requêtes SELECT
        /// </summary>
        private MySqlDataReader reader;

        /// <summary>
        /// Constructeur privé pour le Singleton
        /// </summary>
        private BddManager()
        {
        }

        /// <summary>
        /// Méthode permettant d'obtenir l'instance unique de la classe
        /// </summary>
        /// <returns>Instance unique de BddManager</returns>
        public static BddManager GetInstance()
        {
            if (instance == null)
            {
                instance = new BddManager();
            }
            return instance;
        }

        /// <summary>
        /// Initialisation de la chaîne de connexion
        /// </summary>
        /// <param name="connectionString">Chaîne de connexion</param>
        public void ReqUpdate(string connectionString)
        {
            try
            {
                connection = new MySqlConnection(connectionString);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Exécution d'une requête de type SELECT
        /// </summary>
        /// <param name="stringQuery">Requête SQL</param>
        /// <param name="parameters">Dictionnaire des paramètres</param>
        public void ReqSelect(string stringQuery, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(stringQuery, connection);
                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Connection.Open();
                reader = command.ExecuteReader();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Exécution d'une requête de type INSERT, UPDATE, DELETE
        /// </summary>
        /// <param name="stringQuery">Requête SQL</param>
        /// <param name="parameters">Dictionnaire des paramètres</param>
        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(stringQuery, connection);
                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Tente de lire la ligne suivante du résultat d'une requête SELECT
        /// </summary>
        /// <returns>True si une ligne a pu être lue, False sinon</returns>
        public bool Read()
        {
            if (reader != null)
            {
                return reader.Read();
            }
            return false;
        }

        /// <summary>
        /// Récupère la valeur d'un champ de la ligne lue
        /// </summary>
        /// <param name="nameField">Nom du champ</param>
        /// <returns>Valeur du champ</returns>
        public object Field(string nameField)
        {
            if (reader != null)
            {
                return reader[nameField];
            }
            return null;
        }

        /// <summary>
        /// Fermeture du lecteur (reader) et de la connexion
        /// </summary>
        public void Close()
        {
            if (reader != null)
            {
                reader.Close();
            }
            if (connection != null)
            {
                connection.Close();
            }
        }
    }
}
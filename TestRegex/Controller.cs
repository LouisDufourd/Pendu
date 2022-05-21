using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace TestRegex
{
    internal class Controller
    {
        private SQLiteConnection sqLiteConn;

        public Controller()
        {

        }

        public List<string> read()
        {
            List<string> words = new List<string>();
            sqLiteConn = new SQLiteConnection("Data Source=dictionnaire.db");
            try
            {
                sqLiteConn.Open();
            } catch (Exception e)
            {
               Console.WriteLine("Erreur lors de l'ouverture du fichier" + Environment.NewLine + e.Message);
            }
            SQLiteCommand cmd;
            cmd = new SQLiteCommand("SELECT word FROM lexique_english WHERE lenght >= 3 AND lenght <= 10", sqLiteConn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                words.Add(reader["word"].ToString());
            }
            
            return words;
        }
    }
}

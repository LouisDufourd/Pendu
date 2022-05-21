using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendu
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
                MessageBox.Show("Erreur lors de l'ouverture du fichier" + Environment.NewLine + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            SQLiteCommand cmd;
            cmd = new SQLiteCommand("SELECT word FROM LexiqueEnglish WHERE lenght >= 3 AND lenght <= 10", sqLiteConn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                words.Add(reader["word"].ToString());
            }
            
            return words;
        }
    }
}

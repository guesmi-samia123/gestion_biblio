using gestion_commande.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commande.controllers
{
    class JournaleController
    {
        public List<Journale> listejournale = new List<Journale>();
        public Boolean isloaded = false;
        public JournaleController journaleineCtr;
        public JournaleController getInstance()
        {
            if (journaleineCtr == null)
            {
                journaleineCtr = new JournaleController();

            }
            return journaleineCtr;
        }
        public void load_journale()
        {
            connexion cnx = new connexion();
            cnx.connecter();
            SqlDataReader reader = cnx.RDD("select * from maggazine2");
            while (reader.Read())
            {
                Journale journale = new Journale();
                
                journale.NUMERO = (string)reader.GetValue(1);
                journale.AUTEUR = (string)reader.GetValue(3);
                journale.DISPONIBLE = (String)reader.GetValue(2);
                journale.DATE_PUBLICATION = (DateTime)reader.GetValue(4);
                listejournale.Add(journale);
            }
            reader.Close();
        }
    }
}

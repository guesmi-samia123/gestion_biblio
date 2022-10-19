using gestion_commande.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commande.controllers
{
    class MagazineController
    {
        public List<Magazine> listemagazine = new List<Magazine>();
        public Boolean isloaded = false;
        public MagazineController magazineCtr;
        public MagazineController getInstance()
        {
            if (magazineCtr == null)
            {
                magazineCtr = new MagazineController();

            }
            return magazineCtr;
        }
        public void load_magazine()
        {
            connexion cnx = new connexion();
            cnx.connecter();
            SqlDataReader reader = cnx.RDD("select * from journnale2");
            while (reader.Read())
            {
                Magazine magazine = new Magazine();
                magazine.TITRE = (string)reader.GetValue(2);
                magazine.NUMERO = (string)reader.GetValue(1);
                magazine.FREQUENCE_APP = (int)reader.GetValue(3);
                magazine.DISPONIBLE = (String)reader.GetValue(4);
                listemagazine.Add(magazine);
            }
            reader.Close();
        }
    }
}

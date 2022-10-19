using gestion_commande.model;
using gestion_commande.pl;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commande.controllers
{
    class UserController
    {
        public List<user> listuser = new List<user>();
        public Boolean isloaded = false;
        //public list<LigneFacture> listelignefact = new List<LigneFacture>();
        public UserController userContrl;
        public UserController getInstance()
        {
            if (userContrl == null)
            {
                userContrl = new UserController();

            }
            return userContrl;
        }
        public void verifLogin(string username, string password)
        {
            connexion cnx = new connexion();
            cnx.connecter();
            SqlDataReader reader = cnx.RDD("select * from utilisateur where username= '" +username+ "'and password='" +password+ "'");
            while (reader.Read())
            {
                user u = new user();
                u.Id = (int)reader.GetValue(0);
                u.UAERNAME = (string)reader.GetValue(1);
                u.ROLE = (string)reader.GetValue(5);
                listuser.Add(u);
            }
            reader.Close();
        }

        
    }
    
}

using gestion_commande.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commande.controllers
{
    class clientController
    {
        public List<Client> listeclt = new List<Client>();
        public Boolean isloaded = false;
        //public list<LigneFacture> listelignefact = new List<LigneFacture>();
        public clientController clado;
        public clientController getInstance()
        {
            if (clado == null)
            {
                clado = new clientController();

            }
            return clado;
        }
        public void load_client()
        {
            connexion cnx = new connexion();
            cnx.connecter();
            SqlDataReader reader = cnx.RDD("select * from client2");
            while (reader.Read())
            {
                Client client = new Client();
                client.Id = (int)reader.GetValue(0);
                client.Nom = (string)reader.GetValue(1);
                client.Prenom = (string)reader.GetValue(2);
                client.Adresse = (string)reader.GetValue(3);
                client.Tel = (string)reader.GetValue(4);
               
                
                
                listeclt.Add(client);
            }

            reader.Close();


        }
        public void load_clientById(int id)
        {
            connexion cnx = new connexion();
            cnx.connecter();
            SqlDataReader reader = cnx.RDD("select * from client2 where id_clt=" +id);
            while (reader.Read())
            {
                Client client = new Client();
                client.Id = (int)reader.GetValue(0);
                client.Nom = (string)reader.GetValue(1);
                client.Prenom = (string)reader.GetValue(2);
                client.Adresse = (string)reader.GetValue(3);
                client.Tel = (string)reader.GetValue(4);
                client.Codepostal = (string)reader.GetValue(5);

                listeclt.Add(client);
            }

            reader.Close();


        }
    }
}

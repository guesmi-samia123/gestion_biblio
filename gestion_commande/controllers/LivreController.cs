using gestion_commande.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commande.controllers
{
    class LivreController
    {
        public List<Livre> listelivre = new List<Livre>();
        public Boolean isloaded = false;
        public LivreController livreCtr;
        public LivreController getInstance()
        {
            if (livreCtr == null)
            {
                livreCtr = new LivreController();

            }
            return livreCtr;
        }
        public void load_livre()
        {
            connexion cnx = new connexion();
            cnx.connecter();
            SqlDataReader reader = cnx.RDD("select * from livre");
            while (reader.Read())
            {
                Livre livre = new Livre();
                livre.Id = (int)reader.GetValue(0);
                livre.TITRE = (string)reader.GetValue(1);
                livre.AUTEUR = (string)reader.GetValue(2);
                livre.EDITEUR = (string)reader.GetValue(3);
                livre.NUMERO = (string)reader.GetValue(4);
                livre.DATE_EDITION = (DateTime)reader.GetValue(5);
                livre.DISPONIBLE = (string)reader.GetValue(6);
                livre.NB_PAGES= (string)reader.GetValue(9);
                livre.DESCRIPTION= (string)reader.GetValue(8);
                livre.IMAGE = (byte[])reader.GetValue(7);
                listelivre.Add(livre);
            }
            reader.Close();
        }
        public void load_livreById(int id)
        {
            connexion cnx = new connexion();
            cnx.connecter();
            SqlDataReader reader = cnx.RDD("select * from livre where id_livre=" + id);
            while (reader.Read())
            {
                Livre livre = new Livre();
                livre.Id = (int)reader.GetValue(0);
                livre.TITRE = (string)reader.GetValue(1);
                livre.AUTEUR = (string)reader.GetValue(2);
                livre.EDITEUR = (string)reader.GetValue(3);
                livre.NUMERO = (string)reader.GetValue(4);
                livre.DATE_EDITION = (DateTime)reader.GetValue(5);
                livre.DISPONIBLE = (string)reader.GetValue(6);
                livre.NB_PAGES = (string)reader.GetValue(9);
                livre.DESCRIPTION = (string)reader.GetValue(8);
                livre.IMAGE = (byte[])reader.GetValue(7);
                listelivre.Add(livre);
            }

            reader.Close();


        }
        public void searshLivre(string textbox)
        {
            connexion cnx = new connexion();
            cnx.connecter();
            SqlDataReader reader = cnx.RDD("select * from livre where titre LIKE '%" +textbox+ "%'");
            while (reader.Read())
            {
                Livre livre = new Livre();
                livre.Id = (int)reader.GetValue(0);
                livre.TITRE = (string)reader.GetValue(1);
                livre.AUTEUR = (string)reader.GetValue(2);
                livre.EDITEUR = (string)reader.GetValue(3);
                livre.NUMERO = (string)reader.GetValue(4);
                livre.DATE_EDITION = (DateTime)reader.GetValue(5);
                livre.DISPONIBLE = (string)reader.GetValue(6);
                livre.NB_PAGES = (string)reader.GetValue(9);
                livre.DESCRIPTION = (string)reader.GetValue(8);
                listelivre.Add(livre);
            }
            reader.Close();
            
        }
        public void updatedispo(int id)
        {
            connexion cnx = new connexion();
            SqlCommand cmd = new SqlCommand("update livre set disponible=0 where id_livre=" + id);
            cnx.ExecuteCommand(cmd);
           
        }


    }
}
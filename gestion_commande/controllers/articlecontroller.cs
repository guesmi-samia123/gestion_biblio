using gestion_commande.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commande.controllers
{
    class articlecontroller
    {
        public List<Article> listeart = new List<Article>();
        public Boolean isloaded = false;
        //public list<LigneFacture> listelignefact = new List<LigneFacture>();
        public articlecontroller articleDao;
        public articlecontroller getInstance()
        {
            if (articleDao == null)
            {
                articleDao = new articlecontroller();

            }
            return articleDao;
        }
        public void load_article()
        {
            connexion cnx = new connexion();
            cnx.connecter();
            SqlDataReader reader = cnx.RDD("select * from article2");
            while (reader.Read())
            {
                Article article = new Article();
                article.Id = (int)reader.GetValue(0);
                article.Code = (string)reader.GetValue(1);
                article.Des = (string)reader.GetValue(2);
                article.Pu = (double)reader.GetValue(3);
                article.Rayon = (string)reader.GetValue(4);
                article.Ssrayon = (string)reader.GetValue(5);



                listeart.Add(article);
            }

            reader.Close();


        }
        public void load_aticleById(int id)
        {
            connexion cnx = new connexion();
            cnx.connecter();
            SqlDataReader reader = cnx.RDD("select * from article2 where id_article=" + id);
            while (reader.Read())
            {
                Article art = new Article();

                art.Id = (int)reader.GetValue(0);
                art.Code = (string)reader.GetValue(1);
                art.Des = (string)reader.GetValue(2);
                art.Pu = (double)reader.GetValue(3);
                art.Rayon = (string)reader.GetValue(4);
                art.Ssrayon = (string)reader.GetValue(5);




                listeart.Add(art);
            }

            reader.Close();


        }
    }
}

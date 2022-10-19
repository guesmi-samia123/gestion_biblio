using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commande.controllers
{
    class LivreEmpreinteController
    {
        public List<livreEmpreinte> lista = new List<livreEmpreinte>();
        public Boolean isloaded = false;
        //public list<LigneFacture> listelignefact = new List<LigneFacture>();
        public LivreEmpreinteController livEmpContr;
        public LivreEmpreinteController getInstance()
        {
            if (livEmpContr == null)
            {
                livEmpContr = new LivreEmpreinteController();

            }
            return livEmpContr;
        }

        public void load_Empreinte(int id_user)
        {
            connexion cnx = new connexion();
            cnx.connecter();

            SqlDataReader reader = cnx.RDD("SELECT * FROM empreinte e, livre l where e.id_doc = l.id_livre and e.id_user = " + id_user);
            while (reader.Read())
            {
                livreEmpreinte empreinte = new livreEmpreinte();
                empreinte.ID_EMPREINTE = (int)reader.GetValue(0);
                empreinte.Id_USER = (int)reader.GetValue(1);
                empreinte.ID_DOC = (int)reader.GetValue(2);
                empreinte.DATE_DEBUT = (DateTime)reader.GetValue(3);
                empreinte.DATE_FIN = (DateTime)reader.GetValue(4);
                empreinte.ETAT_EMP = (string)reader.GetValue(6);
                empreinte.TYPE_DOC = (string)reader.GetValue(5);
                empreinte.TITRE= (string)reader.GetValue(8);
                empreinte.AUTEUR = (string)reader.GetValue(9);
                lista.Add(empreinte);
            }
            reader.Close();
        }
        public void searshEmp(string textbox , int id_user)
        {
            connexion cnx = new connexion();
            cnx.connecter();
            SqlDataReader reader = cnx.RDD("select * from empreinte e, livre l where e.id_doc = l.id_livre and e.etat_emprinte = '" + textbox + "' and e.id_user = " + id_user);
            while (reader.Read())
            {
                livreEmpreinte empreinte = new livreEmpreinte();
                empreinte.ID_EMPREINTE = (int)reader.GetValue(0);
                empreinte.Id_USER = (int)reader.GetValue(1);
                empreinte.ID_DOC = (int)reader.GetValue(2);
                empreinte.DATE_DEBUT = (DateTime)reader.GetValue(3);
                empreinte.DATE_FIN = (DateTime)reader.GetValue(4);
                empreinte.ETAT_EMP = (string)reader.GetValue(6);
                empreinte.TYPE_DOC = (string)reader.GetValue(5);
                empreinte.TITRE = (string)reader.GetValue(8);
                empreinte.AUTEUR = (string)reader.GetValue(9);
                lista.Add(empreinte);
            }
            reader.Close();

        }
    }
}

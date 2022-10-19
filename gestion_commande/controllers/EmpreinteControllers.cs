using gestion_commande.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commande.controllers
{
    class EmpreinteControllers
    {
        public List<Empreinte> listeEmp = new List<Empreinte>();
        public List<Livre> listeEmpivre = new List<Livre>();
        
        public Boolean isloaded = false;
        //public list<LigneFacture> listelignefact = new List<LigneFacture>();
        public EmpreinteControllers empreinteContrl;
        public EmpreinteControllers getInstance()
        {
            if (empreinteContrl == null)
            {
                empreinteContrl = new EmpreinteControllers();

            }
            return empreinteContrl;
        }
        public void insertEmprente(Empreinte empreinte)
        { 
        connexion cnx = new connexion();
            
            SqlCommand cmd = new SqlCommand("insert into empreinte values (@id_user , @id_doc,@date_debut,@date_fin,@type_doc,@etat_empreinte)");
        cmd.Parameters.AddWithValue("@id_user", empreinte.Id_USER);
            cmd.Parameters.AddWithValue("@id_doc", empreinte.Id_DOC);
            cmd.Parameters.AddWithValue("@date_debut", empreinte.DATE_DEBUT);
            cmd.Parameters.AddWithValue("@date_fin", empreinte.DATE_DEBUT);
            cmd.Parameters.AddWithValue("@type_doc", empreinte.TYPE_DOC);
            cmd.Parameters.AddWithValue("@etat_empreinte", empreinte.ETAT_EMP);
            
            cnx.ExecuteCommand(cmd);
            
               
        }
        
    }
}

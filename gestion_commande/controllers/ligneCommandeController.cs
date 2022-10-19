using gestion_commande.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commande.controllers
{
    class ligneCommandeController
    {
        public List<LigneCommande> listeclt = new List<LigneCommande>();
        public Boolean isloaded = false;

        public ligneCommandeController Lcmd;
        public ligneCommandeController getInstance()
        {
            if (Lcmd == null)
            {
                Lcmd = new ligneCommandeController();

            }
            return Lcmd;
        }
        public void insertLigneCommande(LigneCommande ligneCmd)
        {

            connexion cnx = new connexion();
           
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            SqlParameter pm_qt = new SqlParameter("@quantite", SqlDbType.Float);
            SqlParameter pm_id_cmd = new SqlParameter("@commande", SqlDbType.Int);
            SqlParameter pm_id_art = new SqlParameter("@article", SqlDbType.Int);
            


            cmd.CommandText = "insert into ligneCommande2(quantite,id_article,id_cmd)values(@quantite,@article,@commande)";
            pm_qt.Value = ligneCmd.Quantite;
            pm_id_cmd.Value = ligneCmd.Id_cmd;
            pm_id_art.Value = ligneCmd.Id_article;
            


           // cmd.Parameters.Add(pm_qt.Value = ligneCmd.Quantite);

            cmd.Parameters.Add(pm_qt);
            cmd.Parameters.Add(pm_id_cmd);
            cmd.Parameters.Add(pm_id_art);
            cnx.ExecuteCommand(cmd);

        }
    }
}

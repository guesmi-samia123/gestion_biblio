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
    class CommandeController
    {
        public List<Commande> listeclt = new List<Commande>();
        public Boolean isloaded = false;
        
        public CommandeController cmd;
        public CommandeController getInstance()
        {
            if (cmd == null)
            {
                cmd = new CommandeController();

            }
            return cmd;
        }
        public void insertCommande(Commande commande)
        {

            connexion cnx = new connexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            SqlParameter pm_num = new SqlParameter("@numero", SqlDbType.VarChar);
            SqlParameter pm_adr = new SqlParameter("@adresse", SqlDbType.VarChar);
            SqlParameter pm_date = new SqlParameter("@date", SqlDbType.DateTime);
            SqlParameter pm_client = new SqlParameter("@client", SqlDbType.Int);
            

            cmd.CommandText = "insert into commande2(num_cmd,date,adr_livraison,id_client)values(@numero,@date,@adresse,@client)";
            pm_num.Value = commande.Num;
            pm_adr.Value = commande.Adrliv;
            pm_date.Value = commande.Date;
            pm_client.Value = commande.Client;


            cmd.Parameters.Add(pm_num);
            cmd.Parameters.Add(pm_date);
            cmd.Parameters.Add(pm_adr);
            cmd.Parameters.Add(pm_client);
            

            cnx.ExecuteCommand(cmd);
           
        }
       
        //public int findmaxidcmd()
        

    }
}

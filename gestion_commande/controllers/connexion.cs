using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace gestion_commande.controllers
{
    class connexion
    {
        public SqlConnection conn = new SqlConnection("database=gestionCommande;server=DESKTOP-I2EDPNT;User ID=sa;pwd=pass");

        public void connecter()
        {
            conn.Open();

        }
        public SqlConnection recnx()
        {
            
            return conn;
        }

        public void ExecuteCommand(SqlCommand cmd)
        {
            cmd.Connection = conn;
            conn.Open();
            
             cmd.ExecuteNonQuery() ;
            conn.Close();
        }
        
        public SqlDataReader RDD(string cmdch)
        {
            SqlCommand command = new SqlCommand(cmdch);
            command.Connection = conn;
            return command.ExecuteReader();



        }


    }
}

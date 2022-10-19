using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commande.model
{
    class LigneCommande
    {
        //private int id;
        private double qt;
        private int id_article;
        private int id_cmd;
        

        public int Id { get; set; }

        public double Quantite { get => qt; set => qt = value; }
        public int Id_article { get => id_article; set => id_article = value; }
        public int Id_cmd { get => id_cmd; set => id_cmd = value; }
      
    }
}

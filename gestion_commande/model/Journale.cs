using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commande.model
{
    class Journale
    {
        private int id;
        private string titre;
        private DateTime date_publication;
        private string auteur;  
        private string disponible;
        private string numero;

        public string TITRE { get => titre; set => titre = value; }
        public DateTime DATE_PUBLICATION { get => date_publication; set => date_publication = value; }
        public string AUTEUR { get => auteur; set => auteur = value; }
        public string DISPONIBLE { get => disponible; set => disponible = value; }
        public string NUMERO { get => numero; set => numero = value; }
        public int Id { get => id; set => id = value; }
        
        
        

    }
}

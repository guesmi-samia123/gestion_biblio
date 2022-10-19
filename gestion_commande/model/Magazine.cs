using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commande.model
{
    class Magazine
    {
        private int id;
        private string titre;
        private string disponible;
        private string numero;
        private int frequence_app;
        public string TITRE { get => titre; set => titre = value; }
        public string DISPONIBLE { get => disponible; set => disponible = value; }
        public string NUMERO { get => numero; set => numero = value; }
        public int Id { get => id; set => id = value; }
        public int FREQUENCE_APP { get => frequence_app; set => frequence_app = value; }
    }
}

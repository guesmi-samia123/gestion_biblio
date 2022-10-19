using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commande.model
{
    class Livre
    {
        private int id;
        private string titre;
        private DateTime date_edition;
        private string auteur;
        private string editeur;
        private string disponible;
        private string numero;
        private string nb_pages;
        private string description;
        private byte[] image;

        public string TITRE { get => titre; set => titre = value; }
        public DateTime DATE_EDITION { get => date_edition; set => date_edition = value; }
        public string AUTEUR { get => auteur; set => auteur = value; }
        public string EDITEUR { get => editeur; set => editeur = value; }
        public string DISPONIBLE { get => disponible; set => disponible = value; }
        public string NUMERO { get => numero; set => numero = value; }
        public int Id { get => id; set => id = value; }
        public string NB_PAGES { get => nb_pages; set => nb_pages = value; }
        public string DESCRIPTION { get => description; set => description = value; }
        public byte[] IMAGE { get => image; set => image = value; }

    }
}

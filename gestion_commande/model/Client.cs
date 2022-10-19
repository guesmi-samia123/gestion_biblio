using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commande.model
{
    class Client
    {
        private int id;
        private string nom;
        private string prenom;
        private string adresse;
        private string tel;
        private string codepostal;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Codepostal { get => codepostal; set => codepostal = value; }
    }
}

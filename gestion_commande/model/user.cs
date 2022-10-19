using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commande.model
{
    class user
    {
        private int id;
        private string username;
        private string date_nais;
        private string adresse;
        private string tel;
        private string role;
        private string login;
        private string paswword;
        private string cin;


        public int Id { get => id; set => id = value; }
        public string UAERNAME { get => username; set => username = value; }
        public string DATE_NAIS { get => date_nais; set => date_nais = value; }
        public string ADRESSE { get => adresse; set => adresse = value; }
        public string TEL { get => tel; set => tel = value; }
        public string LOGIN { get => login; set => login = value; }
        public string PASSWORD { get => paswword; set => paswword = value; }
        public string ROLE { get => role; set => role = value; }
        public string CIN { get => cin; set => cin = value; }
    }
}

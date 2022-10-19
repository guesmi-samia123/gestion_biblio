using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commande.controllers
{
    class livreEmpreinte
    {
        private int id_user;
        private string titre;
        private string auteur;
        private int id_doc;
        private int id_empreinte;
        private DateTime date_debut;
        private DateTime date_fin;
        private string etat_emp;
        private string type_doc;

        public string TITRE { get => titre; set => titre = value; }
        public string AUTEUR { get => auteur; set => auteur = value; }
        public int ID_DOC { get => id_doc; set => id_doc = value; }
        public int ID_EMPREINTE { get => id_empreinte; set => id_empreinte = value; }
        public int Id_USER { get => id_user; set => id_user = value; }
        public DateTime DATE_DEBUT { get => date_debut; set => date_debut = value; }
        public DateTime DATE_FIN { get => date_fin; set => date_fin = value; }
        public string ETAT_EMP { get => etat_emp; set => etat_emp = value; }
        public string TYPE_DOC { get => type_doc; set => type_doc = value; }



    }
}

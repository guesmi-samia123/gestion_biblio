 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commande.model
{
    class Article
    {
        private int id;
        private string des;
        private double pu;
        private string rayon;
        private string ssrayon;
        private string code;

        public int Id { get => id; set => id = value; }
        public string Code { get => code; set => code = value; }
        public string Des { get => des; set => des = value; }
        public double Pu { get => pu; set => pu = value; }
        public string Rayon { get => rayon; set => rayon = value; }
        public string Ssrayon { get => ssrayon; set => ssrayon = value; }
    }
}

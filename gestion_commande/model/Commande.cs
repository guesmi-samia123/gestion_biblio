using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commande.model
{
    class Commande
    {
        private int IDCMD;
        private string num;
        private DateTime date;
        private string adrliv;
        private int client;

        public int IDCMD1 { get => IDCMD; set => IDCMD = value; }
        public string Num { get => num; set => num = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Adrliv { get => adrliv; set => adrliv = value; }
        public int Client { get => client; set => client = value; }
    }
}

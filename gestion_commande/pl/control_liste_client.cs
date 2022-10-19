using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_commande.pl
{
    public partial class control_liste_client : Form
    {
        public static control_liste_client userClient;
        //creer instance de usercontrole
        public static control_liste_client Instance
        {
            get
            {
                if(userClient==null)
                {
                    userClient = new control_liste_client();
                }
                return userClient;
            }
        
        }
        public control_liste_client()
        {
            InitializeComponent();
        }

        private void control_liste_client_Load(object sender, EventArgs e)
        {

        }
    }
}

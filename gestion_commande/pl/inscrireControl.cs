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
    public partial class inscrireControl : UserControl
    {
        public inscrireControl()
        {
            InitializeComponent();
        }
        public static inscrireControl inscrire;
        //creer instance de usercontrole
        public static inscrireControl Instance
        {
            get
            {
                if (inscrire == null)
                {
                    inscrire = new inscrireControl();
                }
                return inscrire;
            }
        }
        private void inscrireControl_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (!connecter.guna2Panel2.Controls.Contains(loginControl.Instance))
            {
                connecter.guna2Panel2.Controls.Add(loginControl.Instance);
                loginControl.Instance.Dock = DockStyle.Fill;
                loginControl.Instance.BringToFront();
            }
            else
            {
                loginControl.Instance.BringToFront();
            }
        }
    }
}

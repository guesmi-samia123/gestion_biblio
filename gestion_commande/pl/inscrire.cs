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
    public partial class inscrire : Form
    {
        public inscrire()
        {
            InitializeComponent();
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

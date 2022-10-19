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
    public partial class connecter : Form
    {
        public connecter()
        {
            InitializeComponent();
        }

        private void connecter_Load(object sender, EventArgs e)
        {
            
        }

        private void connecter_Load_1(object sender, EventArgs e)
        {
            if (!guna2Panel2.Controls.Contains(loginControl.Instance))
            {
                guna2Panel2.Controls.Add(loginControl.Instance);
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

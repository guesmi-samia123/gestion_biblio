using gestion_commande.controllers;
using gestion_commande.model;
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
    public partial class loginControl : UserControl
    {
        public loginControl()
        {
            InitializeComponent();
        }
        public static loginControl login;
        //creer instance de usercontrole
        public static loginControl Instance
        {
            get
            {
                if (login == null)
                {
                    login = new loginControl();
                }
                return login;
            }
        }
        private void loginControl_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (!connecter.guna2Panel2.Controls.Contains(inscrireControl.Instance))
            {
                connecter.guna2Panel2.Controls.Add(inscrireControl.Instance);
                inscrireControl.Instance.Dock = DockStyle.Fill;
                inscrireControl.Instance.BringToFront();
            }
            else
            {
                inscrireControl.Instance.BringToFront();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(username.Text=="" || guna2TextBox3.Text=="")
            {
                MessageBox.Show("Vous devez remplir les champs avant");
            }
            else
            {
            UserController userContrl = new UserController();
            userContrl.verifLogin(username.Text, guna2TextBox3.Text);
            List<user> liste = userContrl.listuser;
            if (liste.Count == 0)
            {
                MessageBox.Show("Mot de pass incorrect");
                username.Text = "";
                guna2TextBox3.Text = "";
            }
            else
            {
                Home holil = new Home(liste[0].Id , liste[0].UAERNAME, liste[0].ROLE );
                holil.Show();


            }
            }

        }
    }
}

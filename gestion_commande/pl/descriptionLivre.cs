using gestion_commande.controllers;
using gestion_commande.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_commande.pl
{
    public partial class descriptionLivre : UserControl
    {
        public static int id_livre;
        public static string type_livre;
        public static string disp;

        public descriptionLivre(int id_livre, string type_livre, string dispo)
        {
            InitializeComponent();
            descriptionLivre.id_livre = id_livre;
            descriptionLivre.type_livre = type_livre;
            descriptionLivre.disp = dispo;
        }

        public static descriptionLivre descControl;
        //creer instance de usercontrole
        public static descriptionLivre Instance
        {
            get
            {
                if (descControl == null)
                {
                    descControl = new descriptionLivre(id_livre, type_livre, disp);
                }
                return descControl;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void descriptionLivre_Load(object sender, EventArgs e)
        {
            date_debut.Visible = false;
            date_fin.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            ok.Visible = false;

            LivreController livreCtr = new LivreController();
             livreCtr.load_livreById(id_livre);


             List<Livre> listlivre = livreCtr.listelivre;
             //   int i = 0;
             // foreach (Livre liv in listlivre)
             for (int i = 0; i < listlivre.Count; i++)
             {
                 num_live.Text = listlivre[i].NUMERO;
                 titre.Text = listlivre[i].TITRE;
                 auteur.Text = listlivre[i].AUTEUR;
                 editeur.Text = listlivre[i].EDITEUR;
                 date_e.Text = listlivre[i].DATE_EDITION.ToString();
                 dispo.Text = listlivre[i].DISPONIBLE;
                 description.Text = listlivre[i].DESCRIPTION;
                 nb_page.Text = listlivre[i].NB_PAGES;
            
            //img_livre.DataBindings.Add("Image", listlivre[i].IMAGE, "imgae");
            connexion cnx = new connexion();
                SqlConnection cnx1 = cnx.recnx();
                cnx.connecter();
            SqlDataAdapter dAdapter = new SqlDataAdapter(new SqlCommand("SELECT imgae FROM livre where id_livre="+ id_livre, cnx1));
            DataSet dSet = new DataSet();
            dAdapter.Fill(dSet);

            if (dSet.Tables[0].Rows.Count == 1)
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(dSet.Tables[0].Rows[0]["imgae"]);
                MemoryStream mem = new MemoryStream(data);
                img_livre.Image = Image.FromStream(mem);
            }


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Home.guna2Panel5.Controls.Clear();
           Home.guna2Panel5.Controls.Contains(DocumentsControl.Instance);
            
                Home.guna2Panel5.Controls.Add(DocumentsControl.Instance);
                DocumentsControl.Instance.Dock = DockStyle.Fill;
                DocumentsControl.Instance.BringToFront();
            
           

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LivreController l = new LivreController();
            Empreinte empreinte = new Empreinte();
            empreinte.Id_USER = Home.id_user;
            empreinte.Id_DOC = id_livre;
            empreinte.DATE_DEBUT = date_debut.Value;
            empreinte.DATE_DEBUT = date_fin.Value;
            empreinte.ETAT_EMP = "encours";
            empreinte.TYPE_DOC = type_livre;
            EmpreinteControllers empreinteControllers = new EmpreinteControllers();
            if(disp=="1")
            { 
            empreinteControllers.insertEmprente(empreinte);
            l.updatedispo(id_livre);
            MessageBox.Show("empreinte effectuer avec succes");
            Home.guna2Panel5.Controls.Clear();
            Home.guna2Panel5.Controls.Add(historiqueControl.Instance);
            historiqueControl.Instance.Dock = DockStyle.Fill;
            historiqueControl.Instance.BringToFront();
            }
            else
            {
                MessageBox.Show("livre non disponible à empreinter");
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            date_debut.Visible = true;
            date_fin.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            ok.Visible = true;
        }
    }
}

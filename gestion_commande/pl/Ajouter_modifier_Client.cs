using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using gestion_commande.controllers;
using System.Data.SqlClient;

namespace gestion_commande.pl
{
    public partial class Ajouter_modifier_Client : Form
    {

        public Ajouter_modifier_Client()
        {
            InitializeComponent();
        }
        public static Ajouter_modifier_Client ajmu;
        //creer instance de usercontrole
        public static Ajouter_modifier_Client Instance
        {
            get
            {
                if (ajmu == null)
                {
                    ajmu = new Ajouter_modifier_Client();
                }
                return ajmu;
            }
        }

        String testObligatoire()
        {
            if (num.Text == "")
                return ("vous devez ajouter le nom clients !");
            if (auteur.Text == "")
                return ("vous devez ajouter l'adresse clients !");
            if (titre.Text == "")
                return ("vous devez ajouter le prenom clients !");
            if (editeur.Text == "")
                return ("vous devez ajouter le cose postale de clients !");
            if (date_e.Text == "")
                return ("vous devez ajouter le numero telephone de clients !");
            
            else return null;
        }
        private void nom_clt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_actialiser_Click(object sender, EventArgs e)
        {
           // Home home = new Home(1);
           // home.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar<48 || e.KeyChar>57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
                e.Handled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajouter_modifier_Client_Load(object sender, EventArgs e)
        {

        }

        private void btn_enrg_Click(object sender, EventArgs e)
        {
            //if (testObligatoire() != null)
            //MessageBox.Show(testObligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] Tb = new byte[fs.Length];
            br.Read(Tb, 0, Tb.Length);
            connexion cnx = new connexion();
            SqlCommand cmd = new SqlCommand("insert into livre values (@titre , @auteur,@editeur,@numero,@date_edition,@disponible,@image,@description,@nb_pages)" );
            cmd.Parameters.AddWithValue("@titre", titre.Text);
            cmd.Parameters.AddWithValue("@auteur", auteur.Text);
            cmd.Parameters.AddWithValue("@editeur", editeur.Text);
            cmd.Parameters.AddWithValue("@numero", num.Text);
            cmd.Parameters.AddWithValue("@date_edition", date_e.Value);
            cmd.Parameters.AddWithValue("@disponible", dispo.Text);
            cmd.Parameters.AddWithValue("@image", Tb);
            cmd.Parameters.AddWithValue("@description", description.Text);
            cmd.Parameters.AddWithValue("@nb_pages", nb_page.Text);
            cnx.ExecuteCommand(cmd);
            
                MessageBox.Show("Ajouté avec succés");

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        OpenFileDialog ofd = new OpenFileDialog();
        DialogResult dresult = new DialogResult(); 
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dresult = DialogResult.No;
            ofd.Filter = "Les fichiers (*.jpg, *.jpeg, *.png, *.gif, *.bmp) | *.jpg; *.jpeg; *.png; *.gif; *.bmp ";
            ofd.Title = "Choisir une image";
            if (ofd.ShowDialog()== DialogResult.OK)
            {

                dresult = DialogResult.OK;
                picture.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}

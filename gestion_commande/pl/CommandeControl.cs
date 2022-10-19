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
    public partial class CommandeControl : UserControl
    {
        public static CommandeControl commandcontrol;
        //creer instance de usercontrole
        public static CommandeControl Instance
        {
            get
            {
                if (commandcontrol == null)
                {
                    commandcontrol = new CommandeControl();
                }
                return commandcontrol;
            }
        }

        public CommandeControl()
        {
            InitializeComponent();
        }

        private void Commande_Load(object sender, EventArgs e)
        {
            clientController client = new clientController();
            articlecontroller art = new articlecontroller();
            art.load_article();
            client.load_client();
            List<Article> listart = art.listeart;
            List<Client> listecltt = client.listeclt;
            foreach (Client clt in listecltt)
            {
                combClt.DataSource = listecltt;
                combClt.DisplayMember = "nom";
                combClt.ValueMember = "id";
                
            }
            foreach (Article article in listart)
            {
                combArt.DataSource = listart;
                combArt.DisplayMember = "des";
                combArt.ValueMember = "id";
                

            }





        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void combClt_SelectedIndexChanged(object sender, EventArgs e)
        {
            clientController client = new clientController();
          client.load_clientById(combClt.SelectedIndex + 1);
            //MessageBox.Show(""+combClt.SelectedIndex);
            List<Client> listecltt = client.listeclt;
            foreach (Client clt in listecltt)
            {
                adrClt.Text = clt.Adresse;
                codePostal.Text = clt.Codepostal;
                telephpne.Text = clt.Tel;

            }
        }

        private void combArt_SelectedIndexChanged(object sender, EventArgs e)
        {
            articlecontroller article = new articlecontroller();
            article.load_aticleById(combArt.SelectedIndex + 1);
            List<Article> listart = article.listeart;
            foreach (Article art in listart)
            {
                code.Text = art.Code;
                designation.Text = art.Des;
                prixU.Text = art.Pu.ToString();

            }
        }

        private void btn_enrg_Click(object sender, EventArgs e)
        {
            /*dgvlignecmd.Rows.Add();
            dgvlignecmd.Rows[0].Cells[1].Value = num_cmd.Text;
            dgvlignecmd.Rows[0].Cells[2].Value = designation.Text;
            dgvlignecmd.Rows[0].Cells[3].Value = qt.Text;*/
            if(dgvlignecmd.RowCount==0)
            {
                dgvlignecmd.Rows.Add();
                dgvlignecmd.Rows[0].Cells[1].Value = num_cmd.Text;
                dgvlignecmd.Rows[0].Cells[2].Value = designation.Text;
                dgvlignecmd.Rows[0].Cells[3].Value = qt.Text;
                dgvlignecmd.Rows[0].Cells[4].Value = combArt.SelectedIndex +1;
                dgvlignecmd.Rows[0].Cells[5].Value = combClt.SelectedIndex + 1;

            }
            else
            {
                dgvlignecmd.Rows.Add();
                dgvlignecmd.Rows[dgvlignecmd.RowCount - 1].Cells[1].Value = num_cmd.Text;
                dgvlignecmd.Rows[dgvlignecmd.RowCount - 1].Cells[2].Value = designation.Text;
                dgvlignecmd.Rows[dgvlignecmd.RowCount - 1].Cells[3].Value = qt.Text;
                dgvlignecmd.Rows[dgvlignecmd.RowCount - 1].Cells[4].Value = combArt.SelectedIndex + 1;
                dgvlignecmd.Rows[dgvlignecmd.RowCount - 1].Cells[4].Value = combClt.SelectedIndex + 1;

            }
            code.Text = "";
            designation.Text = "";
            qt.Text="";
            prixU.Text = "";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            model.Commande cmd = new model.Commande();
            CommandeController cmdCtrl = new CommandeController();
            ligneCommandeController ligCmdCtrl = new ligneCommandeController();
            cmd.Num = num_cmd.Text;
            cmd.Adrliv = adrliv.Text;
            cmd.Date = dateTimePicker1.Value;
            cmd.Client = combClt.SelectedIndex + 1;

            
            cmdCtrl.insertCommande(cmd);
            for (int i = 0; i < dgvlignecmd.Rows.Count; i++)
            {
                // dataGridView1.CurrentRow.Cells["COIL_NO"].Value.ToString()
                // MessageBox.Show("", dgvlignecmd.Rows[0].Cells["id_article"].Value.ToString() +dgvlignecmd.Rows[0].Cells["cmd"].Value.ToString() + dgvlignecmd.Rows[0].Cells["quantite"].Value.ToString() + dgvlignecmd.Rows[0].Cells["article"].Value.ToString());
                //MessageBox.Show("", dgvlignecmd.Rows[0].Cells["id_article"].Value.ToString());
                LigneCommande lg = new LigneCommande();
                lg.Id_cmd = int.Parse(dgvlignecmd.Rows[i].Cells["id_cmd"].Value.ToString());
                lg.Id_article = int.Parse(dgvlignecmd.Rows[i].Cells["id_article"].Value.ToString());
                lg.Quantite = float.Parse(dgvlignecmd.Rows[i].Cells["quantite"].Value.ToString());


                ligCmdCtrl.insertLigneCommande(lg);

            } 
             num_cmd.Text = "";
             adrliv.Text = "";
             adrClt.Text = "";
             codePostal.Text = "";
             telephpne.Text = "";
             dgvlignecmd.Rows.Clear();

        }

        private void btn_actialiser_Click(object sender, EventArgs e)
        {
            //Home home = new Home(1);
           // home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + combClt.SelectedValue);
        }
    }
}

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
    public partial class UserControl1 : UserControl
    {
        public static UserControl1 userClient;
        //creer instance de usercontrole
        public static UserControl1 Instance
        {
            get
            {
                if (userClient == null)
                {
                    userClient = new UserControl1();
                }
                return userClient;
            }

        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            /*dgvClient.Rows.Add();
            dgvClient.Rows[0].Cells[1].Value = "ameni";
            dgvClient.Rows[0].Cells[2].Value = "guesmi";
            dgvClient.Rows[0].Cells[3].Value = "sfax";
            dgvClient.Rows[0].Cells[4].Value = "3010";
            dgvClient.Rows[0].Cells[5].Value = "20234798";*/
        }

        private void textRecherch_Enter(object sender, EventArgs e)
        {
            if(textRecherch.Text== "Recherche")
            {
                textRecherch.Text = "";
                textRecherch.ForeColor = Color.Black;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter_modifier_Client formAjMoClt = new Ajouter_modifier_Client();
            formAjMoClt.ShowDialog();
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {

        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            Ajouter_modifier_Client formAjMoClt = new Ajouter_modifier_Client();
            formAjMoClt.label6.Text = "Modifier Clients";
            formAjMoClt.btn_enrg.Text = "Modifier";
            formAjMoClt.btn_actialiser.Visible = false;
            formAjMoClt.ShowDialog();
        }

        private void textRecherch_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void btn_ajout_Click(object sender, EventArgs e)
        {
            Ajouter_modifier_Client formAjMoClt = new Ajouter_modifier_Client();
            formAjMoClt.ShowDialog();
        }*/
    }
}

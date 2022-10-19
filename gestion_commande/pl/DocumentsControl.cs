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
using System.Data.SqlClient;

namespace gestion_commande.pl
{
    public partial class DocumentsControl : UserControl
    {
        public DocumentsControl()
        {
            InitializeComponent();
        }

        
        public static DocumentsControl docContrl;
        //creer instance de usercontrole
        public static DocumentsControl Instance
        {
            get
            {
                if (docContrl == null)
                {
                    docContrl = new DocumentsControl();
                }
                return docContrl;
            }

        }
        private void DocumentsControl_Load(object sender, EventArgs e)
        {
            dg_livre.Visible = false;
            dg_magazine.Visible = false;
            dg_article.Visible = false;
        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.FromArgb(94, 148, 255);
            guna2Button1.ForeColor = Color.White;
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.ForeColor = Color.Gray;
            guna2Button6.FillColor = Color.Transparent;
            guna2Button6.ForeColor = Color.Gray;
        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.ForeColor = Color.Gray;
            guna2Button6.FillColor = Color.Transparent;
            guna2Button6.ForeColor = Color.Gray;
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.ForeColor = Color.Gray;
        }

        private void guna2Button2_MouseEnter(object sender, EventArgs e)
        {
            guna2Button2.FillColor = Color.FromArgb(94, 148, 255);
            guna2Button2.ForeColor = Color.White;
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.ForeColor = Color.Gray;
            guna2Button6.FillColor = Color.Transparent;
            guna2Button6.ForeColor = Color.Gray;
        }

        private void guna2Button2_MouseLeave(object sender, EventArgs e)
        {
            guna2Button6.FillColor = Color.Transparent;
            guna2Button6.ForeColor = Color.Gray;
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.ForeColor = Color.Gray;
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.ForeColor = Color.Gray;
        }

        private void guna2Button6_MouseEnter(object sender, EventArgs e)
        {
            guna2Button6.FillColor = Color.FromArgb(94, 148, 255);
            guna2Button6.ForeColor = Color.White;
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.ForeColor = Color.Gray;
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.ForeColor = Color.Gray;
        }

        private void guna2Button6_MouseLeave(object sender, EventArgs e)
        {
            guna2Button6.FillColor = Color.Transparent;
            guna2Button6.ForeColor = Color.Gray;
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.ForeColor = Color.Gray;
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.ForeColor = Color.Gray;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dg_livre.Visible = true;
            dg_article.Visible = false;
            dg_magazine.Visible = false;

            LivreController livreCtr = new LivreController();
            livreCtr.load_livre();

            List<Livre> listlivre = livreCtr.listelivre;
         //   int i = 0;
           // foreach (Livre liv in listlivre)
                for(int i =0;i< listlivre.Count ; i++)
            {
                dg_livre.Rows.Add();
                dg_livre.Rows[i].Cells[0].Value = listlivre[i].NUMERO;
                dg_livre.Rows[i].Cells[1].Value = listlivre[i].TITRE;
                dg_livre.Rows[i].Cells[2].Value = listlivre[i].AUTEUR;
                dg_livre.Rows[i].Cells[3].Value = listlivre[i].EDITEUR;
                dg_livre.Rows[i].Cells[4].Value = listlivre[i].DATE_EDITION;
                dg_livre.Rows[i].Cells[5].Value = listlivre[i].DISPONIBLE;
                dg_livre.Rows[i].Cells[6].Value = listlivre[i].Id;
                if (listlivre[i].DISPONIBLE.Equals("0"))
                {
                    dg_livre.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
                }
            }

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            dg_livre.Visible = false;
            dg_article.Visible = false;
            dg_magazine.Visible = true;

            MagazineController listmagacontr = new MagazineController();
            listmagacontr.load_magazine();

            List<Magazine> listmag= listmagacontr.listemagazine;
            //   int i = 0;
            // foreach (Livre liv in listlivre)
            for (int i = 0; i < listmag.Count; i++)
            {
                dg_magazine.Rows.Add();
                dg_magazine.Rows[i].Cells[0].Value = listmag[i].NUMERO;
                dg_magazine.Rows[i].Cells[3].Value = listmag[i].TITRE;
                dg_magazine.Rows[i].Cells[2].Value = listmag[i].FREQUENCE_APP;
                dg_magazine.Rows[i].Cells[1].Value = listmag[i].DISPONIBLE;
                
                if (listmag[i].DISPONIBLE.Equals("0"))
                {
                    dg_magazine.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            dg_livre.Visible = false;
            dg_article.Visible = true;
            dg_magazine.Visible = false;

            JournaleController listjournContr = new JournaleController();
            listjournContr.load_journale();

            List<Journale> listJournalee = listjournContr.listejournale;
            //   int i = 0;
            // foreach (Livre liv in listlivre)
            for (int i = 0; i < listJournalee.Count; i++)
            {
                dg_article.Rows.Add();
                dg_article.Rows[i].Cells[0].Value = listJournalee[i].NUMERO;
                dg_article.Rows[i].Cells[1].Value = listJournalee[i].AUTEUR;
                dg_article.Rows[i].Cells[2].Value = listJournalee[i].DATE_PUBLICATION;
                dg_article.Rows[i].Cells[3].Value = listJournalee[i].DISPONIBLE;

                if (listJournalee[i].DISPONIBLE.Equals("0"))
                {
                    dg_article.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
                }
            }
        }

        private void dg_magazine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_livre_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
           


        }

        private void dg_livre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }

        private void dg_livre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            descriptionLivre dscliv = new descriptionLivre((int)dg_livre.CurrentRow.Cells[6].Value,"livre", (string)dg_livre.CurrentRow.Cells[5].Value);
            // MessageBox.Show("", (string)dg_livre.CurrentRow.Cells[6].Value.ToString());
            if (!Home.guna2Panel5.Controls.Contains(dscliv))
            {
               Home.guna2Panel5.Controls.Add(dscliv);
                dscliv.Dock = DockStyle.Fill;
                dscliv.BringToFront();
            }
            else
            {
                dscliv.BringToFront();
            }
        }
        private void searchlivre(string reg)
        {
            

        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            dg_livre.Rows.Clear();
            LivreController livreCtr = new LivreController();
            livreCtr.searshLivre(search_livre.Text);
            List<Livre> listlivre = livreCtr.listelivre;
            // foreach (Livre liv in listlivre)
            for (int i = 0; i < listlivre.Count; i++)
            {
                dg_livre.Rows.Add();
                dg_livre.Rows[i].Cells[0].Value = listlivre[i].NUMERO;
                dg_livre.Rows[i].Cells[1].Value = listlivre[i].TITRE;
                dg_livre.Rows[i].Cells[2].Value = listlivre[i].AUTEUR;
                dg_livre.Rows[i].Cells[3].Value = listlivre[i].EDITEUR;
                dg_livre.Rows[i].Cells[4].Value = listlivre[i].DATE_EDITION;
                dg_livre.Rows[i].Cells[5].Value = listlivre[i].DISPONIBLE;
                dg_livre.Rows[i].Cells[6].Value = listlivre[i].Id;
                if (listlivre[i].DISPONIBLE.Equals("0"))
                {
                    dg_livre.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
                }
                
            }
           
        }
    }
}


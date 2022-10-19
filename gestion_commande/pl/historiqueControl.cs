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
    public partial class historiqueControl : UserControl
    {
        public historiqueControl()
        {
            InitializeComponent();
        }
        public static historiqueControl historiqControl;
        //creer instance de usercontrole
        public static historiqueControl Instance
        {
            get
            {
                if (historiqControl == null)
                {
                    historiqControl = new historiqueControl();
                }
                return historiqControl;
            }
        }
        private void historiqueControl_Load(object sender, EventArgs e)
        {
            LivreEmpreinteController livreempcontrl = new LivreEmpreinteController();
            livreempcontrl.load_Empreinte(Home.id_user);

            List<livreEmpreinte> listell = livreempcontrl.lista;
            //   int i = 0;
            // foreach (Livre liv in listlivre)
            for (int i = 0; i < listell.Count; i++)
            {
                dg_liv_emp.Rows.Add();
                dg_liv_emp.Rows[i].Cells[0].Value = listell[i].TITRE;
                dg_liv_emp.Rows[i].Cells[1].Value = listell[i].AUTEUR;
                dg_liv_emp.Rows[i].Cells[2].Value = listell[i].DATE_DEBUT;
                dg_liv_emp.Rows[i].Cells[3].Value = listell[i].DATE_FIN;
                dg_liv_emp.Rows[i].Cells[4].Value = listell[i].TYPE_DOC;
                dg_liv_emp.Rows[i].Cells[5].Value = listell[i].ETAT_EMP;
                if (listell[i].ETAT_EMP.Equals("epuisé"))
                {
                    dg_liv_emp.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                }
            }






        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(guna2ComboBox1.SelectedItem.ToString());
            dg_liv_emp.Rows.Clear();
            LivreEmpreinteController em = new LivreEmpreinteController();
            em.searshEmp(guna2ComboBox1.SelectedItem.ToString(), Home.id_user);

            List<livreEmpreinte> listell = em.lista;
            // foreach (Livre liv in listlivre)
            for (int i = 0; i < listell.Count; i++)
            {
                dg_liv_emp.Rows.Add();
                dg_liv_emp.Rows[i].Cells[0].Value = listell[i].TITRE;
                dg_liv_emp.Rows[i].Cells[1].Value = listell[i].AUTEUR;
                dg_liv_emp.Rows[i].Cells[2].Value = listell[i].DATE_DEBUT;
                dg_liv_emp.Rows[i].Cells[3].Value = listell[i].DATE_FIN;
                dg_liv_emp.Rows[i].Cells[4].Value = listell[i].TYPE_DOC;
                dg_liv_emp.Rows[i].Cells[5].Value = listell[i].ETAT_EMP;
                if (listell[i].ETAT_EMP.Equals("Epuisé    "))
                {
                    dg_liv_emp.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                }

            }


        }
    }
}






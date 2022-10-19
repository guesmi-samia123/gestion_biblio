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
    public partial class Home : Form
    {
        public static int id_user;
        public static string username_user;
        public static string role_user;
        public Home(int id , string u_n, string r_u)
        {
            InitializeComponent();
            id_user = id;
            username_user = u_n;
            role_user = r_u;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel5.Controls.Clear();
            if (!guna2Panel5.Controls.Contains(DocumentsControl.Instance))
            {
          guna2Panel5.Controls.Add(DocumentsControl.Instance);
                DocumentsControl.Instance.Dock = DockStyle.Fill;
                DocumentsControl.Instance.BringToFront();
            }
            else
            {
                CommandeControl.Instance.BringToFront();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
           panel3.Visible = false;
            user_name.Text = username_user.ToString();
            if(role_user== "adherent  ")
            {
                guna2Button4.Visible = false;
                //guna2Button3.Location.X =0;426;

                
            }
            
         


        }
        private void guna2Button6_MouseLeave(object sender, EventArgs e)
        {
            

        }

        private void guna2Button6_MouseEnter(object sender, EventArgs e)
        {

           


        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void guna2Button2_MouseEnter(object sender, EventArgs e)
        {

            
        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
          

        }

        private void guna2Button2_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void guna2Button6_MouseHover(object sender, EventArgs e)
        {

        }

        private void guna2Button2_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void user_name_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Panel5.Controls.Clear();
            if (!guna2Panel5.Controls.Contains(historiqueControl.Instance))
            {
                guna2Panel5.Controls.Add(historiqueControl.Instance);
                historiqueControl.Instance.Dock = DockStyle.Fill;
                historiqueControl.Instance.BringToFront();
            }
            else
            {
                historiqueControl.Instance.BringToFront();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2Panel5.Controls.Clear();
            if (!guna2Panel5.Controls.Contains(UserControl1.Instance))
            {
                guna2Panel5.Controls.Add(UserControl1.Instance);
                UserControl1.Instance.Dock = DockStyle.Fill;
                UserControl1.Instance.BringToFront();
            }
            else
            {
                UserControl1.Instance.BringToFront();
            }
        }
    }
    }
    


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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            panel1.Size = new Size(249, 509); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(panel1.Width==291)
            {
                panel1.Size = new Size(69, 509);
            }
            else
            {
                panel1.Size = new Size(291, 509);
            }
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Top = button3.Top;
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            panel4.Top =btnclient.Top;
            if (!panelAffiche.Controls.Contains(UserControl1.Instance))
            {
                panelAffiche.Controls.Add(UserControl1.Instance);
                UserControl1.Instance.Dock = DockStyle.Fill;
                UserControl1.Instance.BringToFront();
            }
            else
            {
                UserControl1.Instance.BringToFront();
            }

        }

        private void panelAffiche_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCmd_Click(object sender, EventArgs e)
        {
            panel4.Top = btnCmd.Top;
            if (!panelAffiche.Controls.Contains(CommandeControl.Instance))
            {
                panelAffiche.Controls.Add(CommandeControl.Instance);
                CommandeControl.Instance.Dock = DockStyle.Fill;
                CommandeControl.Instance.BringToFront();
            }
            else
            {
                UserControl1.Instance.BringToFront();
            }
        }

        private void panelAffiche_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }

       /* private void button4_Click(object sender, EventArgs e)
        {
          //  panel3.Top = button4.Top;
        }*/
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_commande.pl
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        private Task ProgressData(List<string> list , IProgress<ProgressBar> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var progressreport = new ProgressBar();
            return Task.Run(() =>
            { for(int i =0; i< totalProcess; i++)
                {
                    progressreport.pourcentComplete = index++ * 100 / totalProcess;
                    progress.Report(progressreport);
                    Thread.Sleep(10);
                    
                }

            });
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            if(progressBar1.Value==100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                connecter m = new connecter();
                this.Hide();
                m.Show();
            }


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private async void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
            List<string> list = new List<string>();
            for (int i = 0; i < 1000; i++)
                list.Add(i.ToString());
            var progress = new Progress<ProgressBar>();
            progress.ProgressChanged += (o, report) =>
            {
                progressBar1.Value = report.pourcentComplete;
                progressBar1.Update();
                progressBar1.ForeColor = Color.White;
            };
            await ProgressData(list, progress);
        }
    }
}

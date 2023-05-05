using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeGeral
{
    
    public partial class Panel : Form
    {
        int papel = 1;
        int pedra = 2;
        int tesoura = 3;
        int numero = 0;
        int escolha = 1;
        int player = 0;
        int cpu = 0;
        public Panel()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            imgcpu.Visible = false;
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imgcpu.Visible = true;
            timer1.Start();


            Random random = new Random();
            this.numero = random.Next(1, 3);

            if (this.numero == 1)
            {
                imgcpu.Image = Properties.Resources.papel;
            }
            else if (this.numero == 2)
            {
                imgcpu.Image = Properties.Resources.pedra;
            }
            else if (this.numero == 3) {
                imgcpu.Image = Properties.Resources.tesoura;
            };

            if (this.escolha == 1 && this.numero == 2)
            {
                this.player = player + 1;
                
            }
            else if (this.escolha == 2 && this.numero == 3)
            {
                
                this.player = player + 1;
            }
            else if (this.escolha == 3 && this.numero == 1)
            {
                
                this.player = player + 1;
            }
            else if (this.escolha == 2 && this.numero == 1)
            {
                
                this.cpu = cpu + 1;
            }
            else if (this.escolha == 3 && this.numero == 2)
            {
                
                this.cpu = cpu + 1;
            }
            else if (this.escolha == 1 && this.numero == 3) {
                
                this.cpu = cpu + 1;
            };

            lbcpu.Text = cpu.ToString();
            lbplayer.Text = player.ToString();
            randomlb.Text = numero.ToString();
        }

        private void rdopapel_CheckedChanged(object sender, EventArgs e)
        {
            imgplayer.Image = Properties.Resources.papel;
            this.escolha = 1;
        }

        private void rdoPedra_CheckedChanged(object sender, EventArgs e)
        {
            imgplayer.Image = Properties.Resources.pedra;
            this.escolha = 2;
        }

        private void rdotesoura_CheckedChanged(object sender, EventArgs e)
        {
            imgplayer.Image = Properties.Resources.tesoura;
            this.escolha = 3;
        }

        private void lbplayer_Click(object sender, EventArgs e)
        {
            
        }

        private void randomlb_Click(object sender, EventArgs e)
        {
           
        }
    }
}

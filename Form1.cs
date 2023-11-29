using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Pianeti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Planetario p;

        List<Color> colori;

        const double G = 6.674;

        const double t = 0.02;
        private void Form1_Load(object sender, EventArgs e)
        {
            p= new Planetario();
            p.Pianeti = new List<Pianeta>();

            colori = new List<Color> {Color.Red, Color.Yellow, Color.Green, Color.Orange, Color.Purple};

            this.Size = new System.Drawing.Size(1500, 800);
        }

        int cont = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < p.Pianeti.Count; i++)
            {
                for (int j = 0; j < p.Pianeti.Count; j++)
                {
                    if (i != j)
                    {
                        double acc = (G * p.Pianeti[j].Massa) / ((p.Pianeti[i].Posizione - p.Pianeti[j].Posizione).Modulo() * (p.Pianeti[i].Posizione - p.Pianeti[j].Posizione).Modulo());

                        Vettore v = (p.Pianeti[j].Posizione - p.Pianeti[i].Posizione)  / (p.Pianeti[j].Posizione - p.Pianeti[i].Posizione).Modulo();

                        p.Pianeti[i].Accelerazione += v * acc;
                    }
                }
            }

            for(int i = 0; i < p.Pianeti.Count; i++)
            {
                p.Pianeti[i].Posizione = p.Pianeti[i].Posizione + p.Pianeti[i].Velocita * t + p.Pianeti[i].Accelerazione * t * t * 0.5;

                p.Pianeti[i].Velocita = p.Pianeti[i].Velocita + p.Pianeti[i].Accelerazione * t;

                p.Pianeti[i].Accelerazione.X = 0;
                p.Pianeti[i].Accelerazione.Y = 0;
            }

            cont++;

            if (cont == 30)
            {
                Graphics a = this.CreateGraphics();
                p.StampaPlanetario(a);
                cont = 0;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CreaPianeta_Click(object sender, EventArgs e)
        {
            double vx = double.Parse(txtVelocitaX.Text);
            double vy = double.Parse(txtVelocitaY.Text);

            double px = double.Parse(txtPosizioneX.Text);
            double py = double.Parse(txtPosizioneY.Text);

            double m = double.Parse(txtMassa.Text);
            Vettore velocita = new Vettore(vx, vy);
            Vettore posizione = new Vettore(px, py);

            Pianeta pianeta = new Pianeta(txtNome.Text, m, posizione, velocita);
            pianeta.Accelerazione= new Vettore(0,0);

            Random a = new Random();
            pianeta.Colore = colori[a.Next(4)];

            p.Pianeti.Add(pianeta);

            listBox1.Items.Add(pianeta.Nome);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtNome.Visible = false;
            txtMassa.Visible = false;
            txtPosizioneX.Visible = false;
            txtPosizioneY.Visible = false;
            txtVelocitaX.Visible = false;
            txtVelocitaY.Visible = false;

            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

            CreaPianeta.Visible = false;
            btnStart.Visible = false;
            listBox1.Visible = false;

            timer1.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }
    }
}

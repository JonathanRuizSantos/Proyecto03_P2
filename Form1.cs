using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MascotaVirtualProyecto3
{
    public partial class Form1 : Form
    {
        int vida = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WpfRuizSantos.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelTiempoReal_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTiempoReal.Text = DateTime.Now.ToString("hh:mm:ss:f-dd/MM/yyyy");
            labelVida.Text = vida.ToString();
            if (labelTiempoReal.Text == textBox1.Text && RBact1.Checked == true)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");
                RBVacio.Checked = true;
                MessageBox.Show("Bien hecho");
            }
            if(labelTiempoReal.Text == textBox1.Text && RBact1.Checked == false)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");

                if (vida > 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota tiene -10 % de vida");
                }
                if (vida < 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota paso a mejor vida");
                }

                RBVacio.Checked = true;
            }
            if (labelTiempoReal.Text == textBox2.Text && RBact2.Checked == true)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");
                RBVacio.Checked = true;
                MessageBox.Show("Bien hecho");
            }
            if (labelTiempoReal.Text == textBox2.Text && RBact2.Checked == false)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");

                if (vida > 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota tiene -10 % de vida");
                }
                if (vida < 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota paso a mejor vida");
                }

                RBVacio.Checked = true;
            }
            if (labelTiempoReal.Text == textBox3.Text && RBact3.Checked == true)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");
                RBVacio.Checked = true;
                MessageBox.Show("Bien hecho");
            }
            if (labelTiempoReal.Text == textBox3.Text && RBact3.Checked == false)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");

                if (vida > 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota tiene -10 % de vida");
                }
                if (vida < 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota paso a mejor vida");
                }

                RBVacio.Checked = true;
            }
            if (labelTiempoReal.Text == textBox4.Text && RBact4.Checked == true)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");
                RBVacio.Checked = true;
                MessageBox.Show("Bien hecho");
            }
            if (labelTiempoReal.Text == textBox4.Text && RBact4.Checked == false)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");

                if (vida > 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota tiene -10 % de vida");
                }
                if (vida < 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota paso a mejor vida");
                }

                RBVacio.Checked = true;
            }
            if (labelTiempoReal.Text == textBox5.Text && RBact5.Checked == true)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");
                RBVacio.Checked = true;
                MessageBox.Show("Bien hecho");
            }
            if (labelTiempoReal.Text == textBox5.Text && RBact5.Checked == false)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");

                if (vida > 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota tiene -10 % de vida");
                }
                if (vida < 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota paso a mejor vida");
                }

                RBVacio.Checked = true;
            }
            if (labelTiempoReal.Text == textBox6.Text && RBact6.Checked == true)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");
                RBVacio.Checked = true;
                MessageBox.Show("Bien hecho");
            }
            if (labelTiempoReal.Text == textBox6.Text && RBact6.Checked == false)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");

                if (vida > 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota tiene -10 % de vida");
                }
                if (vida < 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota paso a mejor vida");
                }

                RBVacio.Checked = true;
            }
            if (labelTiempoReal.Text == textBox7.Text && RBact7.Checked == true)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");
                RBVacio.Checked = true;
                MessageBox.Show("Bien hecho");
            }
            if (labelTiempoReal.Text == textBox7.Text && RBact7.Checked == false)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");

                if (vida > 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota tiene -10 % de vida");
                }
                if (vida < 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota paso a mejor vida");
                }

                RBVacio.Checked = true;
            }
            if (labelTiempoReal.Text == textBox8.Text && RBact8.Checked == true)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");
                RBVacio.Checked = true;
                MessageBox.Show("Bien hecho");
            }
            if (labelTiempoReal.Text == textBox8.Text && RBact8.Checked == false)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");

                if (vida > 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota tiene -10 % de vida");
                }
                if (vida < 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota paso a mejor vida");
                }

                RBVacio.Checked = true;
            }
            if (labelTiempoReal.Text == textBox9.Text && RBact9.Checked == true)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");
                RBVacio.Checked = true;
                MessageBox.Show("Bien hecho");
            }
            if (labelTiempoReal.Text == textBox9.Text && RBact9.Checked == false)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");

                if (vida > 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota tiene -10 % de vida");
                }
                if (vida < 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota paso a mejor vida");
                }

                RBVacio.Checked = true;
            }
            if (labelTiempoReal.Text == textBox10.Text && RBact10.Checked == true)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");
                RBVacio.Checked = true;
                MessageBox.Show("Bien hecho");
            }
            if (labelTiempoReal.Text == textBox10.Text && RBact10.Checked == false)
            {
                System.Diagnostics.Process.Start("TonoMensaje.mp3");

                if (vida > 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota tiene -10 % de vida");
                }
                if(vida < 10)
                {
                    vida = vida - 10;
                    labelVida.Text = vida.ToString();
                    MessageBox.Show("Tu mascota paso a mejor vida");
                }

                RBVacio.Checked = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Semáforo
{
    public partial class Form1 : Form
    {
        System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
        System.Drawing.Font font;
        public Form1()
        {
            InitializeComponent();
            privateFonts.AddFontFile(@"C:\Users\Marcos\Desktop\7mo Semestre\Sistemas programables\fuente\DS-DIGI.ttf");
            font = new Font(privateFonts.Families[0], 12);
            lblAmarillo.Font = new Font("DS-Digital", 48);
            lblRojo.Font = new Font("DS-Digital", 48);
            lblVerde.Font = new Font("DS-Digital", 48);
            //lblTitulo.Font = new Font("Chapaza", 36);

            pcbTerreno.Controls.Add(lblRojo);
            lblRojo.BackColor = Color.Transparent;

            pcbTerreno.Controls.Add(lblAmarillo);
            lblAmarillo.BackColor = Color.Transparent;

            pcbTerreno.Controls.Add(lblVerde);
            lblVerde.BackColor = Color.Transparent;

            //Semaforo Esquina Superior Izquierda
            pcbTerreno.Controls.Add(pcbSemA0);
            pcbTerreno.Controls.Add(pcbSemA1);
            pcbTerreno.Controls.Add(pcbSemA2);
            pcbTerreno.Controls.Add(pcbSemA3);
            //Semaforo Esquina Superior Derecha
            pcbTerreno.Controls.Add(pcbSemB0);
            pcbTerreno.Controls.Add(pcbSemB1);
            pcbTerreno.Controls.Add(pcbSemB2);
            pcbTerreno.Controls.Add(pcbSemB3);
            //Semaforo Esquina Inferior Izquierda
            pcbTerreno.Controls.Add(pcbSemD0);
            pcbTerreno.Controls.Add(pcbSemD1);
            pcbTerreno.Controls.Add(pcbSemD2);
            pcbTerreno.Controls.Add(pcbSemD3);
            //Semaforo Esquina Inferior Derecha
            pcbTerreno.Controls.Add(pcbSemC0);
            pcbTerreno.Controls.Add(pcbSemC1);
            pcbTerreno.Controls.Add(pcbSemC2);
            pcbTerreno.Controls.Add(pcbSemC3);

            pcbSemA0.BackColor = Color.Transparent;
            pcbSemA1.BackColor = Color.Transparent;
            pcbSemA2.BackColor = Color.Transparent;
            pcbSemA3.BackColor = Color.Transparent;

            pcbSemB0.BackColor = Color.Transparent;
            pcbSemB0.Image.RotateFlip(RotateFlipType.Rotate270FlipY);//RotateFlipType.Rotate270FlipX
            pcbSemB1.BackColor = Color.Transparent;
            pcbSemB1.Image.RotateFlip(RotateFlipType.Rotate270FlipY);//RotateFlipType.Rotate270FlipX
            pcbSemB2.BackColor = Color.Transparent;
            pcbSemB2.Image.RotateFlip(RotateFlipType.Rotate270FlipY);//RotateFlipType.Rotate270FlipX
            pcbSemB3.BackColor = Color.Transparent;
            pcbSemB3.Image.RotateFlip(RotateFlipType.Rotate270FlipY);//RotateFlipType.Rotate270FlipX

            pcbSemC0.BackColor = Color.Transparent;
            pcbSemC1.BackColor = Color.Transparent;
            pcbSemC2.BackColor = Color.Transparent;
            pcbSemC3.BackColor = Color.Transparent;
            pcbSemC0.Image.RotateFlip(RotateFlipType.Rotate270FlipX);
            pcbSemC1.Image.RotateFlip(RotateFlipType.Rotate270FlipX);
            pcbSemC2.Image.RotateFlip(RotateFlipType.Rotate270FlipX);
            pcbSemC3.Image.RotateFlip(RotateFlipType.Rotate270FlipX);
            pcbSemC0.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
            pcbSemC1.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
            pcbSemC2.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
            pcbSemC3.Image.RotateFlip(RotateFlipType.Rotate270FlipY);

            pcbSemD0.BackColor = Color.Transparent;
            pcbSemD1.BackColor = Color.Transparent;
            pcbSemD2.BackColor = Color.Transparent;
            pcbSemD3.BackColor = Color.Transparent;
            pcbSemD0.Image.RotateFlip(RotateFlipType.Rotate270FlipX);
            pcbSemD1.Image.RotateFlip(RotateFlipType.Rotate270FlipX);
            pcbSemD2.Image.RotateFlip(RotateFlipType.Rotate270FlipX);
            pcbSemD3.Image.RotateFlip(RotateFlipType.Rotate270FlipX);

            lblAmarillo.Visible = false;
            lblRojo.Visible = false;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Limpiar
            tmLuzVerdeRojaConst.Stop();
            tmPreventive.Stop();
            tmCambioDeLuces.Stop();
            tmAmarillo.Stop();
            tmRojo.Stop();
            lblRojo.Text = "0";
            lblAmarillo.Text = "0";
            lblVerde.Text = "0";
            lblCount.Text = "0";
            lblP1.Visible = false;
            lblP2.Visible = false;
            lblP3.Visible = false;

            //if (lblAmarillo.Visible == false)
            //{
            //    lblAmarillo.Visible = true;
            //}

            //Start
            lblCount.Text = "0";
            tmLuzVerdeRojaConst.Start();
            tmCambioDeLuces.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            //Limpiar
            tmLuzVerdeRojaConst.Stop();
            tmPreventive.Stop();
            tmCambioDeLuces.Stop();
            tmAmarillo.Stop();
            tmRojo.Stop();
            lblRojo.Text = "0";
            lblAmarillo.Text = "0";
            lblVerde.Text = "0";
            lblCount.Text = "0";
            lblP1.Visible = false;
            lblP2.Visible = false;
            lblP3.Visible = false;
            //Stop
            pcbSemA0.Visible = true;
            pcbSemA1.Visible = false;
            pcbSemA2.Visible = false;
            pcbSemA3.Visible = false;

            pcbSemB0.Visible = true;
            pcbSemB1.Visible = false;
            pcbSemB2.Visible = false;
            pcbSemB3.Visible = false;

            pcbSemC0.Visible = true;
            pcbSemC1.Visible = false;
            pcbSemC2.Visible = false;
            pcbSemC3.Visible = false;

            pcbSemD0.Visible = true;
            pcbSemD1.Visible = false;
            pcbSemD2.Visible = false;
            pcbSemD3.Visible = false;
        }

        private void btnPreventivas_Click(object sender, EventArgs e)
        {
            //Limpiar
            tmLuzVerdeRojaConst.Stop();
            tmPreventive.Stop();
            tmCambioDeLuces.Stop();
            lblRojo.Text = "0";
            lblAmarillo.Text = "0";
            lblVerde.Text = "0";
            lblCount.Text = "0";
            tmAmarillo.Start();
        }

        private void tmLuzVerdeRojaConst_Tick(object sender, EventArgs e)
        {
            tmCambioDeLuces.Start();
            if (lblP1.Visible == false && lblP2.Visible == false && lblP3.Visible == false)
            {
                Double total = Convert.ToDouble(lblVerde.Text);
                total = total + 1;
                lblVerde.Text = total.ToString();

                //Light green 
                pcbSemA0.Visible = false;
                pcbSemA1.Visible = false;
                pcbSemA2.Visible = false;
                pcbSemA3.Visible = true;

                //Light red
                pcbSemB0.Visible = false;
                pcbSemB1.Visible = true;
                pcbSemB2.Visible = false;
                pcbSemB3.Visible = false;

                //Light green
                pcbSemC0.Visible = false;
                pcbSemC1.Visible = false;
                pcbSemC2.Visible = false;
                pcbSemC3.Visible = true;

                //Light red
                pcbSemD0.Visible = false;
                pcbSemD1.Visible = true;
                pcbSemD2.Visible = false;
                pcbSemD3.Visible = false;
            }
            if (lblP1.Visible == true && lblP2.Visible == true && lblP3.Visible == true)
            {
                Double total = Convert.ToDouble(lblVerde.Text);
                total = total + 1;
                lblVerde.Text = total.ToString();

                //Light red
                pcbSemA0.Visible = false;
                pcbSemA1.Visible = true;
                pcbSemA2.Visible = false;
                pcbSemA3.Visible = false;

                //Light green 
                pcbSemB0.Visible = false;
                pcbSemB1.Visible = false;
                pcbSemB2.Visible = false;
                pcbSemB3.Visible = true;

                //Light red
                pcbSemC0.Visible = false;
                pcbSemC1.Visible = true;
                pcbSemC2.Visible = false;
                pcbSemC3.Visible = false;

                //Light green 
                pcbSemD0.Visible = false;
                pcbSemD1.Visible = false;
                pcbSemD2.Visible = false;
                pcbSemD3.Visible = true;
            }
        }

        private void tmCambioDeLuces_Tick(object sender, EventArgs e)
        {
            lblVerde.Visible = true;

            Double total = Convert.ToDouble(lblCount.Text);
            total = total + 0.5;
            lblCount.Text = total.ToString();
            if ((Convert.ToDouble(lblCount.Text)) < (Convert.ToDouble(lblVerde.Text)))
            {
                lblCount.Text = (Convert.ToDouble(lblCount.Text) + 0.5).ToString();
            }
            if ((lblP1.Visible == false && lblP2.Visible == false && lblP3.Visible == false) ||
            (lblP1.Visible == true && lblP2.Visible == false && lblP3.Visible == false) ||
            (lblP1.Visible == true && lblP2.Visible == true && lblP3.Visible == false))
            {
                if (total == 10.5)
                {
                    pcbSemA0.Visible = true;
                    pcbSemA1.Visible = false;
                    pcbSemA2.Visible = false;
                    pcbSemA3.Visible = false;

                    pcbSemC0.Visible = true;
                    pcbSemC1.Visible = false;
                    pcbSemC2.Visible = false;
                    pcbSemC3.Visible = false;
                    lblVerde.Text = "0";
                    lblVerde.Visible = true;
                    lblAmarillo.Visible = false;
                    lblRojo.Visible = false;
                }
                if (total == 11)
                {
                    pcbSemA0.Visible = false;
                    pcbSemA1.Visible = false;
                    pcbSemA2.Visible = false;
                    pcbSemA3.Visible = true;

                    pcbSemC0.Visible = false;
                    pcbSemC1.Visible = false;
                    pcbSemC2.Visible = false;
                    pcbSemC3.Visible = true;
                }
                if (total == 11.5)
                {
                    pcbSemA0.Visible = true;
                    pcbSemA1.Visible = false;
                    pcbSemA2.Visible = false;
                    pcbSemA3.Visible = false;

                    pcbSemC0.Visible = true;
                    pcbSemC1.Visible = false;
                    pcbSemC2.Visible = false;
                    pcbSemC3.Visible = false;
                }
                if (total == 12)
                {
                    pcbSemA0.Visible = false;
                    pcbSemA1.Visible = false;
                    pcbSemA2.Visible = false;
                    pcbSemA3.Visible = true;

                    pcbSemC0.Visible = false;
                    pcbSemC1.Visible = false;
                    pcbSemC2.Visible = false;
                    pcbSemC3.Visible = true;
                }
                if (total == 12.5)
                {
                    pcbSemA0.Visible = true;
                    pcbSemA1.Visible = false;
                    pcbSemA2.Visible = false;
                    pcbSemA3.Visible = false;

                    pcbSemC0.Visible = true;
                    pcbSemC1.Visible = false;
                    pcbSemC2.Visible = false;
                    pcbSemC3.Visible = false;
                }
                if (total == 13)
                {
                    pcbSemA0.Visible = false;
                    pcbSemA1.Visible = false;
                    pcbSemA2.Visible = false;
                    pcbSemA3.Visible = true;

                    pcbSemC0.Visible = false;
                    pcbSemC1.Visible = false;
                    pcbSemC2.Visible = false;
                    pcbSemC3.Visible = true;

                    lblP1.Visible = true;
                    tmPreventive.Start();
                }
                if (total == 13.5)
                {
                    pcbSemA0.Visible = true;
                    pcbSemA1.Visible = false;
                    pcbSemA2.Visible = false;
                    pcbSemA3.Visible = false;

                    pcbSemC0.Visible = true;
                    pcbSemC1.Visible = false;
                    pcbSemC2.Visible = false;
                    pcbSemC3.Visible = false;

                    tmLuzVerdeRojaConst.Stop();
                    lblVerde.Text = "0";
                    lblVerde.Visible = false;
                    lblAmarillo.Visible = true;
                    lblRojo.Visible = false;
                }
                if (total == 14)
                {
                    pcbSemA0.Visible = false;
                    pcbSemA1.Visible = false;
                    pcbSemA2.Visible = true;
                    pcbSemA3.Visible = false;

                    pcbSemC0.Visible = false;
                    pcbSemC1.Visible = false;
                    pcbSemC2.Visible = true;
                    pcbSemC3.Visible = false;
                }
                if (total == 16.5)
                {
                    tmRojo.Start();
                }
                if (total == 17)
                {
                    lblVerde.Visible = false;
                    lblAmarillo.Visible = false;
                    lblRojo.Visible = true;
                    lblAmarillo.Text = "0";
                    tmPreventive.Stop();
                    lblP2.Visible = true;
                    pcbSemA0.Visible = true;
                    pcbSemA1.Visible = false;
                    pcbSemA2.Visible = false;
                    pcbSemA3.Visible = false;
                    pcbSemC0.Visible = true;
                    pcbSemC1.Visible = false;
                    pcbSemC2.Visible = false;
                    pcbSemC3.Visible = false;
                }
                if (total == 18)
                {                    
                    //Turn on red light
                    pcbSemA0.Visible = false;
                    pcbSemA1.Visible = true;
                    pcbSemA2.Visible = false;
                    pcbSemA3.Visible = false;
                    //Turn on red light
                    pcbSemC0.Visible = false;
                    pcbSemC1.Visible = true;
                    pcbSemC2.Visible = false;
                    pcbSemC3.Visible = false;
                }
                if (total == 19.5)
                {
                    lblCount.Text = "0";
                    total = 0;
                    lblRojo.Text = "0";
                    lblP3.Visible = true;
                    tmRojo.Stop();
                    tmCambioDeLuces.Stop();
                    tmLuzVerdeRojaConst.Start();
                    lblVerde.Visible = true;
                    lblAmarillo.Visible = false;
                    lblRojo.Visible = false;
                }
            }
            if ((lblP1.Visible == true && lblP2.Visible == true && lblP3.Visible == true) ||
            (lblP1.Visible == false && lblP2.Visible == true && lblP3.Visible == true) ||
            (lblP1.Visible == false && lblP2.Visible == false && lblP3.Visible == true))
            {

                if ((Convert.ToDouble(lblCount.Text)) < (Convert.ToDouble(lblVerde.Text)))
                {
                    lblCount.Text = (Convert.ToDouble(lblCount.Text) + 1).ToString();
                }
                if (total == 10.5)
                {
                    pcbSemB0.Visible = true;
                    pcbSemB1.Visible = false;
                    pcbSemB2.Visible = false;
                    pcbSemB3.Visible = false;

                    pcbSemD0.Visible = true;
                    pcbSemD1.Visible = false;
                    pcbSemD2.Visible = false;
                    pcbSemD3.Visible = false;
                    lblVerde.Text = "0";
                    lblVerde.Visible = true;
                    lblAmarillo.Visible = false;
                    lblRojo.Visible = false;
                }
                if (total == 11)
                {
                    pcbSemB0.Visible = false;
                    pcbSemB1.Visible = false;
                    pcbSemB2.Visible = false;
                    pcbSemB3.Visible = true;

                    pcbSemD0.Visible = false;
                    pcbSemD1.Visible = false;
                    pcbSemD2.Visible = false;
                    pcbSemD3.Visible = true;
                }
                if (total == 11.5)
                {
                    pcbSemB0.Visible = true;
                    pcbSemB1.Visible = false;
                    pcbSemB2.Visible = false;
                    pcbSemB3.Visible = false;

                    pcbSemD0.Visible = true;
                    pcbSemD1.Visible = false;
                    pcbSemD2.Visible = false;
                    pcbSemD3.Visible = false;
                }
                if (total == 12)
                {
                    pcbSemB0.Visible = false;
                    pcbSemB1.Visible = false;
                    pcbSemB2.Visible = false;
                    pcbSemB3.Visible = true;

                    pcbSemD0.Visible = false;
                    pcbSemD1.Visible = false;
                    pcbSemD2.Visible = false;
                    pcbSemD3.Visible = true;
                }
                if (total == 12.5)
                {
                    pcbSemB0.Visible = true;
                    pcbSemB1.Visible = false;
                    pcbSemB2.Visible = false;
                    pcbSemB3.Visible = false;

                    pcbSemD0.Visible = true;
                    pcbSemD1.Visible = false;
                    pcbSemD2.Visible = false;
                    pcbSemD3.Visible = false;
                }
                if (total == 13)
                {
                    pcbSemB0.Visible = false;
                    pcbSemB1.Visible = false;
                    pcbSemB2.Visible = false;
                    pcbSemB3.Visible = true;

                    pcbSemD0.Visible = false;
                    pcbSemD1.Visible = false;
                    pcbSemD2.Visible = false;
                    pcbSemD3.Visible = true;
                    lblP1.Visible = false;
                    tmPreventive.Start();
                }
                if (total == 13.5)
                {
                    pcbSemB0.Visible = true;
                    pcbSemB1.Visible = false;
                    pcbSemB2.Visible = false;
                    pcbSemB3.Visible = false;

                    pcbSemD0.Visible = true;
                    pcbSemD1.Visible = false;
                    pcbSemD2.Visible = false;
                    pcbSemD3.Visible = false;
                    tmLuzVerdeRojaConst.Stop();
                    lblVerde.Text = "0";
                    lblVerde.Visible = false;
                    lblAmarillo.Visible = true;
                    lblRojo.Visible = false;
                }
                if (total == 14)
                {
                    pcbSemB0.Visible = false;
                    pcbSemB1.Visible = false;
                    pcbSemB2.Visible = true;
                    pcbSemB3.Visible = false;

                    pcbSemD0.Visible = false;
                    pcbSemD1.Visible = false;
                    pcbSemD2.Visible = true;
                    pcbSemD3.Visible = false;
                }
                if (total == 16.5)
                {
                    tmRojo.Start();
                }
                if (total == 17)
                {
                    lblVerde.Visible = false;
                    lblAmarillo.Visible = false;
                    lblRojo.Visible = true;
                    lblAmarillo.Text = "0";
                    tmPreventive.Stop();
                    lblP2.Visible = false;

                    pcbSemB0.Visible = true;
                    pcbSemB1.Visible = false;
                    pcbSemB2.Visible = false;
                    pcbSemB3.Visible = false;

                    pcbSemD0.Visible = true;
                    pcbSemD1.Visible = false;
                    pcbSemD2.Visible = false;
                    pcbSemD3.Visible = false;
                }
                if (total == 18)
                {
                    lblVerde.Visible = false;
                    lblAmarillo.Visible = false;
                    lblRojo.Visible = true;
                    //Turn on red light
                    pcbSemB0.Visible = false;
                    pcbSemB1.Visible = true;
                    pcbSemB2.Visible = false;
                    pcbSemB3.Visible = false;
                    //Turn on red light
                    pcbSemD0.Visible = false;
                    pcbSemD1.Visible = true;
                    pcbSemD2.Visible = false;
                    pcbSemD3.Visible = false;
                }
                if (total == 19.5)
                {                 
                    lblRojo.Visible = false;
                    lblCount.Text = "0";
                    total = 0;
                    lblRojo.Text = "0";
                    lblP3.Visible = false;
                    tmRojo.Stop();
                    tmCambioDeLuces.Stop();
                    tmLuzVerdeRojaConst.Start();
                }
            }
        }

        private void tmPreventive_Tick(object sender, EventArgs e)
        {
            if ((lblP1.Visible == true && lblP2.Visible == false && lblP3.Visible == false)
                || (lblP1.Visible == true && lblP2.Visible == true && lblP3.Visible == false))
            {
                Double total = Convert.ToDouble(lblAmarillo.Text);
                total = total + 1;
                lblAmarillo.Text = total.ToString();
            }
            if ((lblP1.Visible == false && lblP2.Visible == true && lblP3.Visible == true)
                || (lblP1.Visible == false && lblP2.Visible == false && lblP3.Visible == true))
            {
                Double total = Convert.ToDouble(lblAmarillo.Text);
                total = total + 1;
                lblAmarillo.Text = total.ToString();
            }
        }

        private void tmAmarillo_Tick(object sender, EventArgs e)
        {
            Double total = Convert.ToDouble(lblCount.Text);
            total = total + 0.5;
            lblCount.Text = total.ToString();

            if (lblCount.Text.Contains(".5"))
            {
                pcbSemA0.Visible = false;
                pcbSemA1.Visible = false;
                pcbSemA2.Visible = true;
                pcbSemA3.Visible = false;

                pcbSemB0.Visible = false;
                pcbSemB1.Visible = false;
                pcbSemB2.Visible = true;
                pcbSemB3.Visible = false;

                pcbSemC0.Visible = false;
                pcbSemC1.Visible = false;
                pcbSemC2.Visible = true;
                pcbSemC3.Visible = false;

                pcbSemD0.Visible = false;
                pcbSemD1.Visible = false;
                pcbSemD2.Visible = true;
                pcbSemD3.Visible = false;

                lblAmarillo.Visible = true;
            }
            if (!lblCount.Text.Contains(".5"))
            {
                pcbSemA0.Visible = true;
                pcbSemA1.Visible = false;
                pcbSemA2.Visible = false;
                pcbSemA3.Visible = false;

                pcbSemB0.Visible = true;
                pcbSemB1.Visible = false;
                pcbSemB2.Visible = false;
                pcbSemB3.Visible = false;

                pcbSemC0.Visible = true;
                pcbSemC1.Visible = false;
                pcbSemC2.Visible = false;
                pcbSemC3.Visible = false;

                pcbSemD0.Visible = true;
                pcbSemD1.Visible = false;
                pcbSemD2.Visible = false;
                pcbSemD3.Visible = false;

                lblAmarillo.Visible = false;
            }
        }

        private void tmRojo_Tick(object sender, EventArgs e)
        {
            if (lblP1.Visible == true && lblP2.Visible == true && lblP3.Visible == false)
            {
                Double total = Convert.ToDouble(lblRojo.Text);
                total = total + 1;
                lblRojo.Text = total.ToString();
            }
            if (lblP1.Visible == false && lblP2.Visible == false && lblP3.Visible == true)
            {
                Double total = Convert.ToDouble(lblRojo.Text);
                total = total + 1;
                lblRojo.Text = total.ToString();
            }
        }

        private void pcbSemB1_Click(object sender, EventArgs e)
        {

        }

        private void pcbSemA0_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Se obtiene la fuente de los contadores
            //System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
            //System.Drawing.Font font;
            ////inician los componentes
            //InitializeComponent();
            //Se aplica la fuente
            
        }
    }
}

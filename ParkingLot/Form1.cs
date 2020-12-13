using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace ParkingLot
{
    public partial class Form1 : Form
    {

        int CantidadEstacionados = 0, EspaciosDisponibles = 100, estadias = 0, hora = 5, resethora = 0, PrecioPorDia = 0;
        string user = "", pass = "";
        string asunto = "Estadias", destino = "occhuzz@gmail.com";

        public Form1()
        {
            InitializeComponent();

            timer1.Start();

            textBox_precio.Text="15";
            user = textBox_Mail.Text;
            pass = textBox_Pass.Text;
        }

        public int Precio { get => PrecioPorDia; set => PrecioPorDia = value; }

        private void btnPrecioDia_Click_1(object sender, EventArgs e)
        {
            PrecioPorDia = Convert.ToInt32(textBox_precio.Text);
            MessageBox.Show("Precio cambiado a " + PrecioPorDia);
        }

        private void textBox_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public int Autos { get => CantidadEstacionados; set => CantidadEstacionados = value; }
        public int Espacios { get => EspaciosDisponibles; set => EspaciosDisponibles = value; }
        public int Estadias { get => estadias; set => estadias = value; }

        private void btnIngresoDerectado_Click(object sender, EventArgs e)
        {
            CantidadEstacionados += 1;
            EspaciosDisponibles -= 1;
            labelAutos.Text = Convert.ToString(Autos);
            labelEspacios.Text = Convert.ToString(Espacios);
            MessageBox.Show("Ingreso detectado");
            if (CantidadEstacionados >= 100)
            {
                labelEstado.Text = "LLENO";
                labelEstado.ForeColor = Color.Brown;
            }
            else
            {
                labelEstado.Text = "DISPONIBLE";
                labelEstado.ForeColor = Color.Green;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (CantidadEstacionados == 0)
            {
                btnEgresoDetectado.Enabled = false;
                labelAutos.Text = "Null";
            }
            else
            {
                btnEgresoDetectado.Enabled = true;
            }

            DateTime dateTime = DateTime.Now;
            this.labelMinutos.Text = dateTime.ToString("mm");
            this.labelSegundos.Text = dateTime.ToString("ss");
            this.labelHora.Text = dateTime.ToString("HH");
            hora = Convert.ToInt32(labelHora.Text);

            if (hora == 00 && resethora == 0)
            {
                resethora = 1;

                //MessageBox.Show("Hora 00");

                using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                {
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential(user, pass);
                    MailMessage message = new MailMessage(user, destino, asunto, "La cantidad de autos estacionados es " + CantidadEstacionados + ". El precio de la estadia es de " + PrecioPorDia + ", haciendo un total de $" + PrecioPorDia * CantidadEstacionados);

                    try
                    {
                        client.Send(message);
                        MessageBox.Show("El correo de las estadias fue enviado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }

            if (hora != 00 && resethora == 1)
            {
                resethora = 0;
                //MessageBox.Show("Hora Distinta a 00");
            }
        }

        private void btnEgresoDetectado_Click(object sender, EventArgs e)
        {
            CantidadEstacionados -= 1;
            EspaciosDisponibles += 1;
            labelAutos.Text = Convert.ToString(Autos);
            labelEspacios.Text = Convert.ToString(Espacios);
            MessageBox.Show("Egreso detectado");

            if (CantidadEstacionados >= 100)
            {
                labelEstado.Text = "LLENO";
                labelEstado.ForeColor = Color.Brown;
            }
            else
            {
                labelEstado.Text = "DISPONIBLE";
                labelEstado.ForeColor = Color.Green;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelAutos.Text = Convert.ToString(Autos);
            labelEspacios.Text = Convert.ToString(Espacios);
            if (CantidadEstacionados >= 100)
            {
                labelEstado.Text = "LLENO";
                labelEstado.ForeColor = Color.Brown;
            }
            else
            {
                labelEstado.Text = "DISPONIBLE";
                labelEstado.ForeColor = Color.Green;
            }
        }

    }
}

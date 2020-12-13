namespace ParkingLot
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnIngresoDetectado = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelAutos = new System.Windows.Forms.Label();
            this.labelEspacios = new System.Windows.Forms.Label();
            this.btnEgresoDetectado = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelMinutos = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.textBox_precio = new System.Windows.Forms.TextBox();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.labelSegundos = new System.Windows.Forms.Label();
            this.btnPrecioDia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresoDetectado
            // 
            this.btnIngresoDetectado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoDetectado.Location = new System.Drawing.Point(334, 94);
            this.btnIngresoDetectado.Name = "btnIngresoDetectado";
            this.btnIngresoDetectado.Size = new System.Drawing.Size(75, 40);
            this.btnIngresoDetectado.TabIndex = 0;
            this.btnIngresoDetectado.Text = "Ingresar Auto";
            this.btnIngresoDetectado.UseVisualStyleBackColor = true;
            this.btnIngresoDetectado.Click += new System.EventHandler(this.btnIngresoDerectado_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.Color.Transparent;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(301, 214);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(66, 20);
            this.labelEstado.TabIndex = 3;
            this.labelEstado.Text = "Estado";
            // 
            // labelAutos
            // 
            this.labelAutos.AutoSize = true;
            this.labelAutos.BackColor = System.Drawing.Color.Transparent;
            this.labelAutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutos.ForeColor = System.Drawing.Color.Brown;
            this.labelAutos.Location = new System.Drawing.Point(230, 104);
            this.labelAutos.Name = "labelAutos";
            this.labelAutos.Size = new System.Drawing.Size(56, 20);
            this.labelAutos.TabIndex = 5;
            this.labelAutos.Text = "Autos";
            // 
            // labelEspacios
            // 
            this.labelEspacios.AutoSize = true;
            this.labelEspacios.BackColor = System.Drawing.Color.Transparent;
            this.labelEspacios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspacios.ForeColor = System.Drawing.Color.Green;
            this.labelEspacios.Location = new System.Drawing.Point(228, 159);
            this.labelEspacios.Name = "labelEspacios";
            this.labelEspacios.Size = new System.Drawing.Size(82, 20);
            this.labelEspacios.TabIndex = 7;
            this.labelEspacios.Text = "Espacios";
            // 
            // btnEgresoDetectado
            // 
            this.btnEgresoDetectado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgresoDetectado.Location = new System.Drawing.Point(334, 149);
            this.btnEgresoDetectado.Name = "btnEgresoDetectado";
            this.btnEgresoDetectado.Size = new System.Drawing.Size(75, 40);
            this.btnEgresoDetectado.TabIndex = 8;
            this.btnEgresoDetectado.Text = "Egresar Auto";
            this.btnEgresoDetectado.UseVisualStyleBackColor = true;
            this.btnEgresoDetectado.Click += new System.EventHandler(this.btnEgresoDetectado_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelMinutos
            // 
            this.labelMinutos.AutoSize = true;
            this.labelMinutos.BackColor = System.Drawing.Color.Transparent;
            this.labelMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinutos.Location = new System.Drawing.Point(507, 377);
            this.labelMinutos.Name = "labelMinutos";
            this.labelMinutos.Size = new System.Drawing.Size(29, 20);
            this.labelMinutos.TabIndex = 9;
            this.labelMinutos.Text = "00";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.BackColor = System.Drawing.Color.Transparent;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(468, 377);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(29, 20);
            this.labelHora.TabIndex = 10;
            this.labelHora.Text = "00";
            // 
            // textBox_precio
            // 
            this.textBox_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_precio.Location = new System.Drawing.Point(170, 272);
            this.textBox_precio.MaxLength = 3;
            this.textBox_precio.Name = "textBox_precio";
            this.textBox_precio.Size = new System.Drawing.Size(28, 13);
            this.textBox_precio.TabIndex = 12;
            this.textBox_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_precio_KeyPress);
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(225, 327);
            this.textBox_Mail.MaxLength = 256;
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(142, 20);
            this.textBox_Mail.TabIndex = 15;
            this.textBox_Mail.Text = "occhuzz@gmail.com";
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Location = new System.Drawing.Point(225, 381);
            this.textBox_Pass.MaxLength = 20;
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.PasswordChar = '*';
            this.textBox_Pass.Size = new System.Drawing.Size(142, 20);
            this.textBox_Pass.TabIndex = 16;
            this.textBox_Pass.Text = "maxx8699";
            this.textBox_Pass.UseSystemPasswordChar = true;
            // 
            // labelSegundos
            // 
            this.labelSegundos.AutoSize = true;
            this.labelSegundos.BackColor = System.Drawing.Color.Transparent;
            this.labelSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSegundos.Location = new System.Drawing.Point(547, 377);
            this.labelSegundos.Name = "labelSegundos";
            this.labelSegundos.Size = new System.Drawing.Size(29, 20);
            this.labelSegundos.TabIndex = 17;
            this.labelSegundos.Text = "00";
            // 
            // btnPrecioDia
            // 
            this.btnPrecioDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecioDia.Location = new System.Drawing.Point(225, 258);
            this.btnPrecioDia.Name = "btnPrecioDia";
            this.btnPrecioDia.Size = new System.Drawing.Size(85, 40);
            this.btnPrecioDia.TabIndex = 18;
            this.btnPrecioDia.Text = "Confirmar Precio";
            this.btnPrecioDia.UseVisualStyleBackColor = true;
            this.btnPrecioDia.Click += new System.EventHandler(this.btnPrecioDia_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParkingLot.Properties.Resources.Fondo_Parking;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.btnPrecioDia);
            this.Controls.Add(this.labelSegundos);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.textBox_Mail);
            this.Controls.Add(this.textBox_precio);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelMinutos);
            this.Controls.Add(this.btnEgresoDetectado);
            this.Controls.Add(this.labelEspacios);
            this.Controls.Add(this.labelAutos);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.btnIngresoDetectado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Parking_Lot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresoDetectado;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelAutos;
        private System.Windows.Forms.Label labelEspacios;
        private System.Windows.Forms.Button btnEgresoDetectado;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelMinutos;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.TextBox textBox_precio;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.Label labelSegundos;
        private System.Windows.Forms.Button btnPrecioDia;
    }
}


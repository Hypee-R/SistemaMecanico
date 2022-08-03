namespace SistemaMecanico.Vista
{
    partial class AltasCitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Location = new System.Drawing.Point(17, 62);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(121, 16);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "FECHA Y HORA:";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.BackColor = System.Drawing.Color.Transparent;
            this.lblLugar.Location = new System.Drawing.Point(21, 100);
            this.lblLugar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(61, 16);
            this.lblLugar.TabIndex = 2;
            this.lblLugar.Text = "LUGAR:";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(252, 97);
            this.txtLugar.Margin = new System.Windows.Forms.Padding(4);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(211, 23);
            this.txtLugar.TabIndex = 3;
            this.txtLugar.TextChanged += new System.EventHandler(this.validarCampos);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Location = new System.Drawing.Point(21, 134);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(202, 16);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "DESCRIPCIÓN DE SERVICIO:";
            this.lblDescripcion.Click += new System.EventHandler(this.lblDescripcion_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(252, 131);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(211, 24);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.validarCampos);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.BackColor = System.Drawing.Color.Transparent;
            this.lblCosto.Location = new System.Drawing.Point(21, 167);
            this.lblCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(236, 16);
            this.lblCosto.TabIndex = 6;
            this.lblCosto.Text = "COSTO ESTIMADO DE SERVICIO:";
            this.lblCosto.Click += new System.EventHandler(this.lblCosto_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Location = new System.Drawing.Point(21, 200);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(71, 16);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "CLIENTE:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(252, 197);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(211, 24);
            this.cmbClientes.TabIndex = 9;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.validarCampos);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(252, 257);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(229, 28);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "AGENDAR CITA";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::SistemaMecanico.Properties.Resources.arrow_right_east;
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(20, 351);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(45, 28);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "<<";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.txtHome_Click);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(252, 164);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(211, 23);
            this.txtCosto.TabIndex = 7;
            this.txtCosto.TextChanged += new System.EventHandler(this.validarCampos);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(252, 66);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(211, 23);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.TextChanged += new System.EventHandler(this.validarCampos);
            // 
            // AltasCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::SistemaMecanico.Properties.Resources.me;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(670, 436);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.lblFecha);
            this.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AltasCitas";
            this.Text = "AltasCitas";
            this.Load += new System.EventHandler(this.AltasCitas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtFecha;

    }
}
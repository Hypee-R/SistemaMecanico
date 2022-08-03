namespace SistemaMecanico.Vista
{
    partial class AltasUsuarios
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApPaterno = new System.Windows.Forms.Label();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.lblApMaterno = new System.Windows.Forms.Label();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.lblTelFijo = new System.Windows.Forms.Label();
            this.lblTelMovil = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtTelFijo = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefonoMovil = new System.Windows.Forms.MaskedTextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Location = new System.Drawing.Point(16, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(193, 50);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblApPaterno
            // 
            this.lblApPaterno.AutoSize = true;
            this.lblApPaterno.BackColor = System.Drawing.Color.Transparent;
            this.lblApPaterno.Location = new System.Drawing.Point(16, 88);
            this.lblApPaterno.Name = "lblApPaterno";
            this.lblApPaterno.Size = new System.Drawing.Size(152, 16);
            this.lblApPaterno.TabIndex = 2;
            this.lblApPaterno.Text = "APELLIDO PATERNO:";
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(193, 84);
            this.txtApPaterno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(159, 23);
            this.txtApPaterno.TabIndex = 3;
            this.txtApPaterno.TextChanged += new System.EventHandler(this.txtApPaterno_TextChanged);
            // 
            // lblApMaterno
            // 
            this.lblApMaterno.AutoSize = true;
            this.lblApMaterno.BackColor = System.Drawing.Color.Transparent;
            this.lblApMaterno.Location = new System.Drawing.Point(16, 123);
            this.lblApMaterno.Name = "lblApMaterno";
            this.lblApMaterno.Size = new System.Drawing.Size(157, 16);
            this.lblApMaterno.TabIndex = 4;
            this.lblApMaterno.Text = "APELLIDO MATERNO:";
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(192, 120);
            this.txtApMaterno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(159, 23);
            this.txtApMaterno.TabIndex = 5;
            this.txtApMaterno.TextChanged += new System.EventHandler(this.txtApMaterno_TextChanged);
            // 
            // lblTelFijo
            // 
            this.lblTelFijo.AutoSize = true;
            this.lblTelFijo.BackColor = System.Drawing.Color.Transparent;
            this.lblTelFijo.Location = new System.Drawing.Point(16, 159);
            this.lblTelFijo.Name = "lblTelFijo";
            this.lblTelFijo.Size = new System.Drawing.Size(124, 16);
            this.lblTelFijo.TabIndex = 6;
            this.lblTelFijo.Text = "TELÉFONO FIJO;";
            // 
            // lblTelMovil
            // 
            this.lblTelMovil.AutoSize = true;
            this.lblTelMovil.BackColor = System.Drawing.Color.Transparent;
            this.lblTelMovil.Location = new System.Drawing.Point(12, 195);
            this.lblTelMovil.Name = "lblTelMovil";
            this.lblTelMovil.Size = new System.Drawing.Size(140, 16);
            this.lblTelMovil.TabIndex = 8;
            this.lblTelMovil.Text = "TELÉFONO MÓVIL:";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(12, 230);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(179, 16);
            this.lblCorreoElectronico.TabIndex = 10;
            this.lblCorreoElectronico.Text = "CORREO ELECTRÓNICO:";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(193, 227);
            this.txtCorreoElectronico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(159, 23);
            this.txtCorreoElectronico.TabIndex = 11;
            this.txtCorreoElectronico.TextChanged += new System.EventHandler(this.txtCorreoElectronico_TextChanged);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Location = new System.Drawing.Point(16, 300);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(93, 16);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "DIRECCIÓN:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(193, 293);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(159, 23);
            this.txtDireccion.TabIndex = 13;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.Transparent;
            this.lblSexo.Location = new System.Drawing.Point(16, 332);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(50, 16);
            this.lblSexo.TabIndex = 14;
            this.lblSexo.Text = "SEXO:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cmbSexo.Location = new System.Drawing.Point(193, 329);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(159, 24);
            this.cmbSexo.TabIndex = 15;
            this.cmbSexo.SelectedIndexChanged += new System.EventHandler(this.cmbSexo_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(215, 374);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 28);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.ForeColor = System.Drawing.Color.Black;
            this.btnRegresar.Location = new System.Drawing.Point(19, 374);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(43, 28);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.Text = "<<";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtTelFijo
            // 
            this.txtTelFijo.Location = new System.Drawing.Point(193, 155);
            this.txtTelFijo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelFijo.Mask = "(999)000-0000";
            this.txtTelFijo.Name = "txtTelFijo";
            this.txtTelFijo.Size = new System.Drawing.Size(159, 23);
            this.txtTelFijo.TabIndex = 7;
            this.txtTelFijo.TextChanged += new System.EventHandler(this.txtTelFijo_TextChanged);
            // 
            // txtTelefonoMovil
            // 
            this.txtTelefonoMovil.Location = new System.Drawing.Point(193, 192);
            this.txtTelefonoMovil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefonoMovil.Mask = "000-000-0000";
            this.txtTelefonoMovil.Name = "txtTelefonoMovil";
            this.txtTelefonoMovil.Size = new System.Drawing.Size(159, 23);
            this.txtTelefonoMovil.TabIndex = 9;
            this.txtTelefonoMovil.TextChanged += new System.EventHandler(this.txtTelefonoMovil_TextChanged);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(108, 263);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(244, 16);
            this.lblAviso.TabIndex = 18;
            this.lblAviso.Text = "ESTE CORREO YA FUE UTILIZADO";
            this.lblAviso.Visible = false;
            // 
            // AltasUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SistemaMecanico.Properties.Resources.me;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(670, 473);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.txtTelefonoMovil);
            this.Controls.Add(this.txtTelFijo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.lblCorreoElectronico);
            this.Controls.Add(this.lblTelMovil);
            this.Controls.Add(this.lblTelFijo);
            this.Controls.Add(this.txtApMaterno);
            this.Controls.Add(this.lblApMaterno);
            this.Controls.Add(this.txtApPaterno);
            this.Controls.Add(this.lblApPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AltasUsuarios";
            this.Text = "Altas";
            this.Load += new System.EventHandler(this.Altas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApPaterno;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.Label lblApMaterno;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.Label lblTelFijo;
        private System.Windows.Forms.Label lblTelMovil;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.MaskedTextBox txtTelFijo;
        private System.Windows.Forms.MaskedTextBox txtTelefonoMovil;
        private System.Windows.Forms.Label lblAviso;
    }
}
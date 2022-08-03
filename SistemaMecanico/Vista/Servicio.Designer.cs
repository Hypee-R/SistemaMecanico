namespace SistemaMecanico.Vista
{
    partial class Servicio
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
            this.grpInicioServicio = new System.Windows.Forms.GroupBox();
            this.grpCita = new System.Windows.Forms.GroupBox();
            this.rdbSinCita = new System.Windows.Forms.RadioButton();
            this.rdbConCita = new System.Windows.Forms.RadioButton();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtDescEspecifica = new System.Windows.Forms.TextBox();
            this.lblDescEspe = new System.Windows.Forms.Label();
            this.cmbDescGlobal = new System.Windows.Forms.ComboBox();
            this.lblDescGlobal = new System.Windows.Forms.Label();
            this.txtCostoEstimado = new System.Windows.Forms.TextBox();
            this.lblCostoEstimado = new System.Windows.Forms.Label();
            this.txtFechaEstimada = new System.Windows.Forms.TextBox();
            this.lblFechaEstimada = new System.Windows.Forms.Label();
            this.txtTiempoEstiamdo = new System.Windows.Forms.TextBox();
            this.lblTiempoEstimado = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblPlacas = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblAuto = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCita = new System.Windows.Forms.ComboBox();
            this.lblCita = new System.Windows.Forms.Label();
            this.btnInicioServicio = new System.Windows.Forms.Button();
            this.grpFinalServicio = new System.Windows.Forms.GroupBox();
            this.grpMateriales = new System.Windows.Forms.GroupBox();
            this.rdbSinMaterial = new System.Windows.Forms.RadioButton();
            this.rdbConMaterial = new System.Windows.Forms.RadioButton();
            this.txtCostoTotal = new System.Windows.Forms.TextBox();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.txtManoDeObra = new System.Windows.Forms.TextBox();
            this.lblManoDeObra = new System.Windows.Forms.Label();
            this.cmbMateriales = new System.Windows.Forms.ComboBox();
            this.lblMateriales = new System.Windows.Forms.Label();
            this.txtServRealizado = new System.Windows.Forms.TextBox();
            this.lblServicios = new System.Windows.Forms.Label();
            this.txtTiempoInvertido = new System.Windows.Forms.TextBox();
            this.lblTiempoinver = new System.Windows.Forms.Label();
            this.txtDescAtual = new System.Windows.Forms.TextBox();
            this.lblDecrpActual = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.grpInicioServicio.SuspendLayout();
            this.grpCita.SuspendLayout();
            this.grpFinalServicio.SuspendLayout();
            this.grpMateriales.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInicioServicio
            // 
            this.grpInicioServicio.BackColor = System.Drawing.Color.Transparent;
            this.grpInicioServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpInicioServicio.Controls.Add(this.grpCita);
            this.grpInicioServicio.Controls.Add(this.cmbEmpleado);
            this.grpInicioServicio.Controls.Add(this.lblEmpleado);
            this.grpInicioServicio.Controls.Add(this.txtDescEspecifica);
            this.grpInicioServicio.Controls.Add(this.lblDescEspe);
            this.grpInicioServicio.Controls.Add(this.cmbDescGlobal);
            this.grpInicioServicio.Controls.Add(this.lblDescGlobal);
            this.grpInicioServicio.Controls.Add(this.txtCostoEstimado);
            this.grpInicioServicio.Controls.Add(this.lblCostoEstimado);
            this.grpInicioServicio.Controls.Add(this.txtFechaEstimada);
            this.grpInicioServicio.Controls.Add(this.lblFechaEstimada);
            this.grpInicioServicio.Controls.Add(this.txtTiempoEstiamdo);
            this.grpInicioServicio.Controls.Add(this.lblTiempoEstimado);
            this.grpInicioServicio.Controls.Add(this.txtMatricula);
            this.grpInicioServicio.Controls.Add(this.lblPlacas);
            this.grpInicioServicio.Controls.Add(this.txtModelo);
            this.grpInicioServicio.Controls.Add(this.lblAuto);
            this.grpInicioServicio.Controls.Add(this.cmbCliente);
            this.grpInicioServicio.Controls.Add(this.lblCliente);
            this.grpInicioServicio.Controls.Add(this.cmbCita);
            this.grpInicioServicio.Controls.Add(this.lblCita);
            this.grpInicioServicio.Enabled = false;
            this.grpInicioServicio.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInicioServicio.ForeColor = System.Drawing.Color.White;
            this.grpInicioServicio.Location = new System.Drawing.Point(12, 50);
            this.grpInicioServicio.Name = "grpInicioServicio";
            this.grpInicioServicio.Size = new System.Drawing.Size(428, 362);
            this.grpInicioServicio.TabIndex = 23;
            this.grpInicioServicio.TabStop = false;
            this.grpInicioServicio.Text = "DATOS DE INICIO DE SERVICIO";
            // 
            // grpCita
            // 
            this.grpCita.BackColor = System.Drawing.Color.White;
            this.grpCita.Controls.Add(this.rdbSinCita);
            this.grpCita.Controls.Add(this.rdbConCita);
            this.grpCita.Location = new System.Drawing.Point(11, 34);
            this.grpCita.Name = "grpCita";
            this.grpCita.Size = new System.Drawing.Size(200, 43);
            this.grpCita.TabIndex = 47;
            this.grpCita.TabStop = false;
            this.grpCita.Text = "¿TIENE CITA PREVIA?";
            this.grpCita.Enter += new System.EventHandler(this.grpCita_Enter);
            // 
            // rdbSinCita
            // 
            this.rdbSinCita.AutoSize = true;
            this.rdbSinCita.Location = new System.Drawing.Point(59, 19);
            this.rdbSinCita.Name = "rdbSinCita";
            this.rdbSinCita.Size = new System.Drawing.Size(47, 19);
            this.rdbSinCita.TabIndex = 25;
            this.rdbSinCita.TabStop = true;
            this.rdbSinCita.Text = "NO";
            this.rdbSinCita.UseVisualStyleBackColor = true;
            // 
            // rdbConCita
            // 
            this.rdbConCita.AutoSize = true;
            this.rdbConCita.Location = new System.Drawing.Point(3, 19);
            this.rdbConCita.Name = "rdbConCita";
            this.rdbConCita.Size = new System.Drawing.Size(36, 19);
            this.rdbConCita.TabIndex = 24;
            this.rdbConCita.TabStop = true;
            this.rdbConCita.Text = "SI";
            this.rdbConCita.UseVisualStyleBackColor = true;
            this.rdbConCita.CheckedChanged += new System.EventHandler(this.rdbConCita_CheckedChanged);
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(259, 313);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(154, 23);
            this.cmbEmpleado.TabIndex = 45;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleado.Location = new System.Drawing.Point(10, 321);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(180, 15);
            this.lblEmpleado.TabIndex = 44;
            this.lblEmpleado.Text = "TECNICO QUE ATENDERA:";
            // 
            // txtDescEspecifica
            // 
            this.txtDescEspecifica.Location = new System.Drawing.Point(259, 287);
            this.txtDescEspecifica.Multiline = true;
            this.txtDescEspecifica.Name = "txtDescEspecifica";
            this.txtDescEspecifica.Size = new System.Drawing.Size(154, 20);
            this.txtDescEspecifica.TabIndex = 41;
            // 
            // lblDescEspe
            // 
            this.lblDescEspe.AutoSize = true;
            this.lblDescEspe.Location = new System.Drawing.Point(11, 294);
            this.lblDescEspe.Name = "lblDescEspe";
            this.lblDescEspe.Size = new System.Drawing.Size(245, 15);
            this.lblDescEspe.TabIndex = 40;
            this.lblDescEspe.Text = "DESCRIPCION ESPECIFICA DE FALLA:";
            // 
            // cmbDescGlobal
            // 
            this.cmbDescGlobal.FormattingEnabled = true;
            this.cmbDescGlobal.Items.AddRange(new object[] {
            "FALLA MECANICA",
            "FALLA ELECTRICA"});
            this.cmbDescGlobal.Location = new System.Drawing.Point(259, 260);
            this.cmbDescGlobal.Name = "cmbDescGlobal";
            this.cmbDescGlobal.Size = new System.Drawing.Size(154, 23);
            this.cmbDescGlobal.TabIndex = 39;
            // 
            // lblDescGlobal
            // 
            this.lblDescGlobal.AutoSize = true;
            this.lblDescGlobal.Location = new System.Drawing.Point(10, 268);
            this.lblDescGlobal.Name = "lblDescGlobal";
            this.lblDescGlobal.Size = new System.Drawing.Size(225, 15);
            this.lblDescGlobal.TabIndex = 38;
            this.lblDescGlobal.Text = "DESCRIPCION GLOBAL DE FALLA:";
            // 
            // txtCostoEstimado
            // 
            this.txtCostoEstimado.Location = new System.Drawing.Point(259, 234);
            this.txtCostoEstimado.Name = "txtCostoEstimado";
            this.txtCostoEstimado.Size = new System.Drawing.Size(154, 22);
            this.txtCostoEstimado.TabIndex = 37;
            // 
            // lblCostoEstimado
            // 
            this.lblCostoEstimado.Location = new System.Drawing.Point(10, 241);
            this.lblCostoEstimado.Name = "lblCostoEstimado";
            this.lblCostoEstimado.Size = new System.Drawing.Size(181, 13);
            this.lblCostoEstimado.TabIndex = 46;
            this.lblCostoEstimado.Text = "COSTO ESTIMADO DE SERVICIO:";
            // 
            // txtFechaEstimada
            // 
            this.txtFechaEstimada.Location = new System.Drawing.Point(259, 208);
            this.txtFechaEstimada.Name = "txtFechaEstimada";
            this.txtFechaEstimada.Size = new System.Drawing.Size(154, 22);
            this.txtFechaEstimada.TabIndex = 36;
            // 
            // lblFechaEstimada
            // 
            this.lblFechaEstimada.AutoSize = true;
            this.lblFechaEstimada.Location = new System.Drawing.Point(10, 215);
            this.lblFechaEstimada.Name = "lblFechaEstimada";
            this.lblFechaEstimada.Size = new System.Drawing.Size(214, 15);
            this.lblFechaEstimada.TabIndex = 35;
            this.lblFechaEstimada.Text = "FECHA ESTIMADA DE ENTREGA:";
            // 
            // txtTiempoEstiamdo
            // 
            this.txtTiempoEstiamdo.Location = new System.Drawing.Point(259, 182);
            this.txtTiempoEstiamdo.Name = "txtTiempoEstiamdo";
            this.txtTiempoEstiamdo.Size = new System.Drawing.Size(154, 22);
            this.txtTiempoEstiamdo.TabIndex = 34;
            // 
            // lblTiempoEstimado
            // 
            this.lblTiempoEstimado.AutoSize = true;
            this.lblTiempoEstimado.Location = new System.Drawing.Point(10, 188);
            this.lblTiempoEstimado.Name = "lblTiempoEstimado";
            this.lblTiempoEstimado.Size = new System.Drawing.Size(250, 15);
            this.lblTiempoEstimado.TabIndex = 33;
            this.lblTiempoEstimado.Text = "TIEMPO ESTIMADO DE REPARACION:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(259, 156);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(154, 22);
            this.txtMatricula.TabIndex = 32;
            // 
            // lblPlacas
            // 
            this.lblPlacas.AutoSize = true;
            this.lblPlacas.ForeColor = System.Drawing.Color.White;
            this.lblPlacas.Location = new System.Drawing.Point(10, 161);
            this.lblPlacas.Name = "lblPlacas";
            this.lblPlacas.Size = new System.Drawing.Size(143, 15);
            this.lblPlacas.TabIndex = 31;
            this.lblPlacas.Text = "MATRICULA/PLACAS:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(259, 130);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(154, 22);
            this.txtModelo.TabIndex = 30;
            // 
            // lblAuto
            // 
            this.lblAuto.AutoSize = true;
            this.lblAuto.Location = new System.Drawing.Point(10, 137);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(113, 15);
            this.lblAuto.TabIndex = 29;
            this.lblAuto.Text = "AUTO/MODELO:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(259, 103);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(154, 23);
            this.cmbCliente.TabIndex = 28;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(10, 111);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(66, 15);
            this.lblCliente.TabIndex = 27;
            this.lblCliente.Text = "CLIENTE:";
            // 
            // cmbCita
            // 
            this.cmbCita.FormattingEnabled = true;
            this.cmbCita.Location = new System.Drawing.Point(259, 76);
            this.cmbCita.Name = "cmbCita";
            this.cmbCita.Size = new System.Drawing.Size(154, 23);
            this.cmbCita.TabIndex = 26;
            this.cmbCita.Visible = false;
            this.cmbCita.SelectedIndexChanged += new System.EventHandler(this.cmbCita_SelectedIndexChanged);
            // 
            // lblCita
            // 
            this.lblCita.AutoSize = true;
            this.lblCita.Location = new System.Drawing.Point(10, 84);
            this.lblCita.Name = "lblCita";
            this.lblCita.Size = new System.Drawing.Size(85, 15);
            this.lblCita.TabIndex = 25;
            this.lblCita.Text = "ID DE CITA:";
            this.lblCita.Visible = false;
            // 
            // btnInicioServicio
            // 
            this.btnInicioServicio.Location = new System.Drawing.Point(786, 425);
            this.btnInicioServicio.Name = "btnInicioServicio";
            this.btnInicioServicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicioServicio.TabIndex = 47;
            this.btnInicioServicio.Text = "ACEPTAR";
            this.btnInicioServicio.UseVisualStyleBackColor = true;
            this.btnInicioServicio.Click += new System.EventHandler(this.btnInicioServicio_Click);
            // 
            // grpFinalServicio
            // 
            this.grpFinalServicio.BackColor = System.Drawing.Color.Transparent;
            this.grpFinalServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpFinalServicio.Controls.Add(this.grpMateriales);
            this.grpFinalServicio.Controls.Add(this.txtCostoTotal);
            this.grpFinalServicio.Controls.Add(this.lblCostoTotal);
            this.grpFinalServicio.Controls.Add(this.txtManoDeObra);
            this.grpFinalServicio.Controls.Add(this.lblManoDeObra);
            this.grpFinalServicio.Controls.Add(this.cmbMateriales);
            this.grpFinalServicio.Controls.Add(this.lblMateriales);
            this.grpFinalServicio.Controls.Add(this.txtServRealizado);
            this.grpFinalServicio.Controls.Add(this.lblServicios);
            this.grpFinalServicio.Controls.Add(this.txtTiempoInvertido);
            this.grpFinalServicio.Controls.Add(this.lblTiempoinver);
            this.grpFinalServicio.Controls.Add(this.txtDescAtual);
            this.grpFinalServicio.Controls.Add(this.lblDecrpActual);
            this.grpFinalServicio.Enabled = false;
            this.grpFinalServicio.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFinalServicio.ForeColor = System.Drawing.Color.White;
            this.grpFinalServicio.Location = new System.Drawing.Point(445, 51);
            this.grpFinalServicio.Name = "grpFinalServicio";
            this.grpFinalServicio.Size = new System.Drawing.Size(429, 266);
            this.grpFinalServicio.TabIndex = 24;
            this.grpFinalServicio.TabStop = false;
            this.grpFinalServicio.Text = "DATOS DE FINAL DE SERVICIO";
            this.grpFinalServicio.Enter += new System.EventHandler(this.grpFinalServicio_Enter);
            // 
            // grpMateriales
            // 
            this.grpMateriales.BackColor = System.Drawing.Color.White;
            this.grpMateriales.Controls.Add(this.rdbSinMaterial);
            this.grpMateriales.Controls.Add(this.rdbConMaterial);
            this.grpMateriales.Location = new System.Drawing.Point(12, 115);
            this.grpMateriales.Name = "grpMateriales";
            this.grpMateriales.Size = new System.Drawing.Size(404, 44);
            this.grpMateriales.TabIndex = 45;
            this.grpMateriales.TabStop = false;
            this.grpMateriales.Text = "¿UTLIZO MATERIALES DEL TALLER?";
            // 
            // rdbSinMaterial
            // 
            this.rdbSinMaterial.AutoSize = true;
            this.rdbSinMaterial.Location = new System.Drawing.Point(115, 16);
            this.rdbSinMaterial.Name = "rdbSinMaterial";
            this.rdbSinMaterial.Size = new System.Drawing.Size(47, 19);
            this.rdbSinMaterial.TabIndex = 39;
            this.rdbSinMaterial.TabStop = true;
            this.rdbSinMaterial.Text = "NO";
            this.rdbSinMaterial.UseVisualStyleBackColor = true;
            // 
            // rdbConMaterial
            // 
            this.rdbConMaterial.AutoSize = true;
            this.rdbConMaterial.Location = new System.Drawing.Point(6, 16);
            this.rdbConMaterial.Name = "rdbConMaterial";
            this.rdbConMaterial.Size = new System.Drawing.Size(36, 19);
            this.rdbConMaterial.TabIndex = 38;
            this.rdbConMaterial.TabStop = true;
            this.rdbConMaterial.Text = "SI";
            this.rdbConMaterial.UseVisualStyleBackColor = true;
            this.rdbConMaterial.CheckedChanged += new System.EventHandler(this.rdbConMaterial_CheckedChanged);
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.Location = new System.Drawing.Point(265, 219);
            this.txtCostoTotal.Multiline = true;
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.Size = new System.Drawing.Size(150, 20);
            this.txtCostoTotal.TabIndex = 44;
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Location = new System.Drawing.Point(7, 226);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(105, 15);
            this.lblCostoTotal.TabIndex = 43;
            this.lblCostoTotal.Text = "COSTO TOTAL:";
            // 
            // txtManoDeObra
            // 
            this.txtManoDeObra.Location = new System.Drawing.Point(265, 193);
            this.txtManoDeObra.Multiline = true;
            this.txtManoDeObra.Name = "txtManoDeObra";
            this.txtManoDeObra.Size = new System.Drawing.Size(150, 20);
            this.txtManoDeObra.TabIndex = 42;
            // 
            // lblManoDeObra
            // 
            this.lblManoDeObra.AutoSize = true;
            this.lblManoDeObra.Location = new System.Drawing.Point(7, 200);
            this.lblManoDeObra.Name = "lblManoDeObra";
            this.lblManoDeObra.Size = new System.Drawing.Size(169, 15);
            this.lblManoDeObra.TabIndex = 41;
            this.lblManoDeObra.Text = "COSTO MANO DE OBRA:";
            // 
            // cmbMateriales
            // 
            this.cmbMateriales.FormattingEnabled = true;
            this.cmbMateriales.Location = new System.Drawing.Point(265, 165);
            this.cmbMateriales.Name = "cmbMateriales";
            this.cmbMateriales.Size = new System.Drawing.Size(150, 23);
            this.cmbMateriales.TabIndex = 40;
            this.cmbMateriales.Visible = false;
            // 
            // lblMateriales
            // 
            this.lblMateriales.AutoSize = true;
            this.lblMateriales.Location = new System.Drawing.Point(7, 173);
            this.lblMateriales.Name = "lblMateriales";
            this.lblMateriales.Size = new System.Drawing.Size(156, 15);
            this.lblMateriales.TabIndex = 39;
            this.lblMateriales.Text = "MATERIAL UTILIZADO:";
            this.lblMateriales.Visible = false;
            // 
            // txtServRealizado
            // 
            this.txtServRealizado.Location = new System.Drawing.Point(266, 83);
            this.txtServRealizado.Multiline = true;
            this.txtServRealizado.Name = "txtServRealizado";
            this.txtServRealizado.Size = new System.Drawing.Size(150, 20);
            this.txtServRealizado.TabIndex = 37;
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Location = new System.Drawing.Point(6, 88);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(229, 15);
            this.lblServicios.TabIndex = 36;
            this.lblServicios.Text = "SERVICIOS REALIZADOS AL AUTO:";
            // 
            // txtTiempoInvertido
            // 
            this.txtTiempoInvertido.Location = new System.Drawing.Point(266, 57);
            this.txtTiempoInvertido.Multiline = true;
            this.txtTiempoInvertido.Name = "txtTiempoInvertido";
            this.txtTiempoInvertido.Size = new System.Drawing.Size(150, 20);
            this.txtTiempoInvertido.TabIndex = 35;
            // 
            // lblTiempoinver
            // 
            this.lblTiempoinver.AutoSize = true;
            this.lblTiempoinver.Location = new System.Drawing.Point(6, 60);
            this.lblTiempoinver.Name = "lblTiempoinver";
            this.lblTiempoinver.Size = new System.Drawing.Size(258, 15);
            this.lblTiempoinver.TabIndex = 34;
            this.lblTiempoinver.Text = "TIEMPO INVERTIDO EN REPARACION:";
            // 
            // txtDescAtual
            // 
            this.txtDescAtual.Location = new System.Drawing.Point(265, 31);
            this.txtDescAtual.Multiline = true;
            this.txtDescAtual.Name = "txtDescAtual";
            this.txtDescAtual.Size = new System.Drawing.Size(150, 20);
            this.txtDescAtual.TabIndex = 33;
            // 
            // lblDecrpActual
            // 
            this.lblDecrpActual.AutoSize = true;
            this.lblDecrpActual.Location = new System.Drawing.Point(6, 38);
            this.lblDecrpActual.Name = "lblDecrpActual";
            this.lblDecrpActual.Size = new System.Drawing.Size(222, 15);
            this.lblDecrpActual.TabIndex = 32;
            this.lblDecrpActual.Text = "DESCRIPION ACTUAL DEL AUTO:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 425);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(38, 23);
            this.btnRegresar.TabIndex = 48;
            this.btnRegresar.Text = "<<";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::SistemaMecanico.Properties.Resources.me;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 503);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnInicioServicio);
            this.Controls.Add(this.grpFinalServicio);
            this.Controls.Add(this.grpInicioServicio);
            this.Name = "Servicio";
            this.Text = "InicioServicio";
            this.Load += new System.EventHandler(this.InicioServicio_Load);
            this.grpInicioServicio.ResumeLayout(false);
            this.grpInicioServicio.PerformLayout();
            this.grpCita.ResumeLayout(false);
            this.grpCita.PerformLayout();
            this.grpFinalServicio.ResumeLayout(false);
            this.grpFinalServicio.PerformLayout();
            this.grpMateriales.ResumeLayout(false);
            this.grpMateriales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpInicioServicio;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TextBox txtDescEspecifica;
        private System.Windows.Forms.Label lblDescEspe;
        private System.Windows.Forms.ComboBox cmbDescGlobal;
        private System.Windows.Forms.Label lblDescGlobal;
        private System.Windows.Forms.TextBox txtCostoEstimado;
        private System.Windows.Forms.Label lblCostoEstimado;
        private System.Windows.Forms.TextBox txtFechaEstimada;
        private System.Windows.Forms.Label lblFechaEstimada;
        private System.Windows.Forms.TextBox txtTiempoEstiamdo;
        private System.Windows.Forms.Label lblTiempoEstimado;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblPlacas;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblAuto;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCita;
        private System.Windows.Forms.Label lblCita;
        private System.Windows.Forms.RadioButton rdbConCita;
        private System.Windows.Forms.Button btnInicioServicio;
        private System.Windows.Forms.GroupBox grpFinalServicio;
        private System.Windows.Forms.TextBox txtTiempoInvertido;
        private System.Windows.Forms.Label lblTiempoinver;
        private System.Windows.Forms.TextBox txtDescAtual;
        private System.Windows.Forms.Label lblDecrpActual;
        private System.Windows.Forms.Label lblManoDeObra;
        private System.Windows.Forms.ComboBox cmbMateriales;
        private System.Windows.Forms.Label lblMateriales;
        private System.Windows.Forms.RadioButton rdbConMaterial;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.TextBox txtCostoTotal;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.TextBox txtManoDeObra;
        private System.Windows.Forms.TextBox txtServRealizado;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox grpCita;
        private System.Windows.Forms.RadioButton rdbSinCita;
        private System.Windows.Forms.GroupBox grpMateriales;
        private System.Windows.Forms.RadioButton rdbSinMaterial;

    }
}
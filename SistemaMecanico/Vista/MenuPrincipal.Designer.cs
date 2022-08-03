namespace SistemaMecanico.Vista
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menAgregarCli = new System.Windows.Forms.ToolStripMenuItem();
            this.menEliminarCli = new System.Windows.Forms.ToolStripMenuItem();
            this.menConsultarCli = new System.Windows.Forms.ToolStripMenuItem();
            this.menEditarCli = new System.Windows.Forms.ToolStripMenuItem();
            this.menEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.menAgregarEm = new System.Windows.Forms.ToolStripMenuItem();
            this.menEliminarEm = new System.Windows.Forms.ToolStripMenuItem();
            this.menConsultarEm = new System.Windows.Forms.ToolStripMenuItem();
            this.menEditarEm = new System.Windows.Forms.ToolStripMenuItem();
            this.menCitas = new System.Windows.Forms.ToolStripMenuItem();
            this.menCitaNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.menConsultarCita = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cANCELARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sERVICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sERVICIONUEVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONCLUIRSERVICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menClientes,
            this.menEmpleados,
            this.menCitas,
            this.sERVICIOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menClientes
            // 
            this.menClientes.BackColor = System.Drawing.Color.Black;
            this.menClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menAgregarCli,
            this.menEliminarCli,
            this.menConsultarCli,
            this.menEditarCli});
            this.menClientes.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menClientes.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.menClientes.Name = "menClientes";
            this.menClientes.Size = new System.Drawing.Size(92, 22);
            this.menClientes.Text = "CLIENTES";
            this.menClientes.Click += new System.EventHandler(this.menClientes_Click);
            // 
            // menAgregarCli
            // 
            this.menAgregarCli.BackColor = System.Drawing.Color.Gainsboro;
            this.menAgregarCli.ForeColor = System.Drawing.Color.Black;
            this.menAgregarCli.Image = global::SistemaMecanico.Properties.Resources.agreg;
            this.menAgregarCli.Name = "menAgregarCli";
            this.menAgregarCli.Size = new System.Drawing.Size(173, 22);
            this.menAgregarCli.Text = "AGREGAR";
            this.menAgregarCli.Click += new System.EventHandler(this.menAgregarCli_Click);
            // 
            // menEliminarCli
            // 
            this.menEliminarCli.BackColor = System.Drawing.Color.Gainsboro;
            this.menEliminarCli.Image = global::SistemaMecanico.Properties.Resources.b;
            this.menEliminarCli.Name = "menEliminarCli";
            this.menEliminarCli.Size = new System.Drawing.Size(173, 22);
            this.menEliminarCli.Text = "ELIMINAR";
            this.menEliminarCli.Click += new System.EventHandler(this.menEliminarCli_Click);
            // 
            // menConsultarCli
            // 
            this.menConsultarCli.BackColor = System.Drawing.Color.Gainsboro;
            this.menConsultarCli.Image = global::SistemaMecanico.Properties.Resources.kudgkg;
            this.menConsultarCli.Name = "menConsultarCli";
            this.menConsultarCli.Size = new System.Drawing.Size(173, 22);
            this.menConsultarCli.Text = "CONSULTAR";
            this.menConsultarCli.Click += new System.EventHandler(this.menConsultarCli_Click);
            // 
            // menEditarCli
            // 
            this.menEditarCli.BackColor = System.Drawing.Color.Gainsboro;
            this.menEditarCli.Image = global::SistemaMecanico.Properties.Resources.edii;
            this.menEditarCli.Name = "menEditarCli";
            this.menEditarCli.Size = new System.Drawing.Size(173, 22);
            this.menEditarCli.Text = "EDITAR";
            this.menEditarCli.Click += new System.EventHandler(this.menEditarCli_Click);
            // 
            // menEmpleados
            // 
            this.menEmpleados.BackColor = System.Drawing.Color.Gray;
            this.menEmpleados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menAgregarEm,
            this.menEliminarEm,
            this.menConsultarEm,
            this.menEditarEm});
            this.menEmpleados.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menEmpleados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menEmpleados.Name = "menEmpleados";
            this.menEmpleados.Size = new System.Drawing.Size(114, 22);
            this.menEmpleados.Text = "EMPLEADOS";
            // 
            // menAgregarEm
            // 
            this.menAgregarEm.BackColor = System.Drawing.Color.Gainsboro;
            this.menAgregarEm.Image = global::SistemaMecanico.Properties.Resources.agreg;
            this.menAgregarEm.Name = "menAgregarEm";
            this.menAgregarEm.Size = new System.Drawing.Size(173, 22);
            this.menAgregarEm.Text = "AGREGAR";
            this.menAgregarEm.Click += new System.EventHandler(this.menAgregarEm_Click);
            // 
            // menEliminarEm
            // 
            this.menEliminarEm.BackColor = System.Drawing.Color.Gainsboro;
            this.menEliminarEm.Image = global::SistemaMecanico.Properties.Resources.b;
            this.menEliminarEm.Name = "menEliminarEm";
            this.menEliminarEm.Size = new System.Drawing.Size(173, 22);
            this.menEliminarEm.Text = "ELIMINAR";
            this.menEliminarEm.Click += new System.EventHandler(this.menEliminarEm_Click);
            // 
            // menConsultarEm
            // 
            this.menConsultarEm.BackColor = System.Drawing.Color.Gainsboro;
            this.menConsultarEm.Image = global::SistemaMecanico.Properties.Resources.kudgkg;
            this.menConsultarEm.Name = "menConsultarEm";
            this.menConsultarEm.Size = new System.Drawing.Size(173, 22);
            this.menConsultarEm.Text = "CONSULTAR";
            this.menConsultarEm.Click += new System.EventHandler(this.menConsultarEm_Click);
            // 
            // menEditarEm
            // 
            this.menEditarEm.BackColor = System.Drawing.Color.Gainsboro;
            this.menEditarEm.Image = global::SistemaMecanico.Properties.Resources.edii;
            this.menEditarEm.Name = "menEditarEm";
            this.menEditarEm.Size = new System.Drawing.Size(173, 22);
            this.menEditarEm.Text = "EDITAR";
            this.menEditarEm.Click += new System.EventHandler(this.menEditarEm_Click);
            // 
            // menCitas
            // 
            this.menCitas.BackColor = System.Drawing.Color.Black;
            this.menCitas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menCitaNueva,
            this.menConsultarCita,
            this.eDITARToolStripMenuItem,
            this.cANCELARToolStripMenuItem});
            this.menCitas.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menCitas.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.menCitas.Name = "menCitas";
            this.menCitas.Size = new System.Drawing.Size(64, 22);
            this.menCitas.Text = "CITAS";
            // 
            // menCitaNueva
            // 
            this.menCitaNueva.BackColor = System.Drawing.Color.Gainsboro;
            this.menCitaNueva.Image = global::SistemaMecanico.Properties.Resources.cit;
            this.menCitaNueva.Name = "menCitaNueva";
            this.menCitaNueva.Size = new System.Drawing.Size(174, 22);
            this.menCitaNueva.Text = "CITA NUEVA";
            this.menCitaNueva.Click += new System.EventHandler(this.menCitaNueva_Click);
            // 
            // menConsultarCita
            // 
            this.menConsultarCita.BackColor = System.Drawing.Color.Gainsboro;
            this.menConsultarCita.Image = global::SistemaMecanico.Properties.Resources.kudgkg;
            this.menConsultarCita.Name = "menConsultarCita";
            this.menConsultarCita.Size = new System.Drawing.Size(174, 22);
            this.menConsultarCita.Text = "CONSULTAR";
            this.menConsultarCita.Click += new System.EventHandler(this.menConsultarCita_Click);
            // 
            // eDITARToolStripMenuItem
            // 
            this.eDITARToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.eDITARToolStripMenuItem.Image = global::SistemaMecanico.Properties.Resources.edii;
            this.eDITARToolStripMenuItem.Name = "eDITARToolStripMenuItem";
            this.eDITARToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.eDITARToolStripMenuItem.Text = "EDITAR";
            this.eDITARToolStripMenuItem.Click += new System.EventHandler(this.eDITARToolStripMenuItem_Click);
            // 
            // cANCELARToolStripMenuItem
            // 
            this.cANCELARToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.cANCELARToolStripMenuItem.Image = global::SistemaMecanico.Properties.Resources.elimina;
            this.cANCELARToolStripMenuItem.Name = "cANCELARToolStripMenuItem";
            this.cANCELARToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cANCELARToolStripMenuItem.Text = "CANCELAR";
            this.cANCELARToolStripMenuItem.Click += new System.EventHandler(this.cANCELARToolStripMenuItem_Click);
            // 
            // sERVICIOToolStripMenuItem
            // 
            this.sERVICIOToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.sERVICIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sERVICIONUEVOToolStripMenuItem,
            this.cONCLUIRSERVICIOToolStripMenuItem,
            this.cONSULTARToolStripMenuItem});
            this.sERVICIOToolStripMenuItem.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sERVICIOToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sERVICIOToolStripMenuItem.Name = "sERVICIOToolStripMenuItem";
            this.sERVICIOToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sERVICIOToolStripMenuItem.Text = "SERVICIO";
            // 
            // sERVICIONUEVOToolStripMenuItem
            // 
            this.sERVICIONUEVOToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.sERVICIONUEVOToolStripMenuItem.Image = global::SistemaMecanico.Properties.Resources.empezar;
            this.sERVICIONUEVOToolStripMenuItem.Name = "sERVICIONUEVOToolStripMenuItem";
            this.sERVICIONUEVOToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.sERVICIONUEVOToolStripMenuItem.Text = "INICIAR SERVICIO";
            this.sERVICIONUEVOToolStripMenuItem.Click += new System.EventHandler(this.sERVICIONUEVOToolStripMenuItem_Click);
            // 
            // cONCLUIRSERVICIOToolStripMenuItem
            // 
            this.cONCLUIRSERVICIOToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.cONCLUIRSERVICIOToolStripMenuItem.Image = global::SistemaMecanico.Properties.Resources.finalizar;
            this.cONCLUIRSERVICIOToolStripMenuItem.Name = "cONCLUIRSERVICIOToolStripMenuItem";
            this.cONCLUIRSERVICIOToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.cONCLUIRSERVICIOToolStripMenuItem.Text = "CONCLUIR SERVICIO";
            this.cONCLUIRSERVICIOToolStripMenuItem.Click += new System.EventHandler(this.cONCLUIRSERVICIOToolStripMenuItem_Click);
            // 
            // cONSULTARToolStripMenuItem
            // 
            this.cONSULTARToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.cONSULTARToolStripMenuItem.Image = global::SistemaMecanico.Properties.Resources.kudgkg;
            this.cONSULTARToolStripMenuItem.Name = "cONSULTARToolStripMenuItem";
            this.cONSULTARToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.cONSULTARToolStripMenuItem.Text = "CONSULTAR ";
            this.cONSULTARToolStripMenuItem.Click += new System.EventHandler(this.cONSULTARToolStripMenuItem_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::SistemaMecanico.Properties.Resources.buena;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(120, 99);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(352, 214);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaMecanico.Properties.Resources.me;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 456);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menClientes;
        private System.Windows.Forms.ToolStripMenuItem menAgregarCli;
        private System.Windows.Forms.ToolStripMenuItem menEliminarCli;
        private System.Windows.Forms.ToolStripMenuItem menConsultarCli;
        private System.Windows.Forms.ToolStripMenuItem menEditarCli;
        private System.Windows.Forms.ToolStripMenuItem menEmpleados;
        private System.Windows.Forms.ToolStripMenuItem menAgregarEm;
        private System.Windows.Forms.ToolStripMenuItem menEliminarEm;
        private System.Windows.Forms.ToolStripMenuItem menConsultarEm;
        private System.Windows.Forms.ToolStripMenuItem menEditarEm;
        private System.Windows.Forms.ToolStripMenuItem menCitas;
        private System.Windows.Forms.ToolStripMenuItem menCitaNueva;
        private System.Windows.Forms.ToolStripMenuItem menConsultarCita;
        private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cANCELARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sERVICIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sERVICIONUEVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONCLUIRSERVICIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTARToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
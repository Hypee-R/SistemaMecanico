using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMecanico.Vista
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void menAgregarCli_Click(object sender, EventArgs e)
        {
            abrirAltas(2,"Agregar");
        }

        private void menConsultarCli_Click(object sender, EventArgs e)
        {
            abrirConsultas(2, "Consultar", "Clientes");
        }

        private void menEliminarCli_Click(object sender, EventArgs e)
        {
            abrirConsultas(2, "Eliminar", "Clientes");
        }

        private void menEditarCli_Click(object sender, EventArgs e)
        {
            abrirConsultas(2, "Editar", "Clientes");
        }

        private void menAgregarEm_Click(object sender, EventArgs e)
        {
            abrirAltas(1,"Agregar");
        }

        private void menConsultarEm_Click(object sender, EventArgs e)
        {
            abrirConsultas(1, "Consultar", "Empleado");
        }

        private void menEliminarEm_Click(object sender, EventArgs e)
        {
            abrirConsultas(1, "Eliminar", "Empleado");
        }

        private void menEditarEm_Click(object sender, EventArgs e)
        {
            abrirConsultas(1, "Editar", "Empleado");
        }

        private void menCitaNueva_Click(object sender, EventArgs e)
        {
            AltasCitas ac = new AltasCitas("Agregar");
            ac.Show();
            this.Hide();
        }

        private void menConsultarCita_Click(object sender, EventArgs e)
        {
            abrirConsultas(1, "Consultar", "Citas");
        }

        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirConsultas(1,"Editar","Citas");
        }

        public void abrirConsultas(int p, string o, string m)
        {
            ConsultasUsuarios consultas = new ConsultasUsuarios(p, o, m);
            consultas.Show();
            this.Hide();
        }

        public void abrirAltas(int p, string ope)
        {
            AltasUsuarios altas = new AltasUsuarios(p, ope);
            altas.Show();
            this.Hide();
        }

        private void cANCELARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirConsultas(1,"Cancelar","Citas");
        }

        private void sERVICIONUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicio s = new Servicio("IniciarServicio");
            s.Show();
            this.Hide();
        }

        private void cONCLUIRSERVICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirConsultas(1, "Finalizar", "Servicios");
        }

        private void cONSULTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirConsultas(1,"Consultar","Servicios");
        }

        private void menClientes_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}

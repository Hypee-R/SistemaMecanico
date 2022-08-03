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
    public partial class AltasCitas : Form
    {
        string[] clientes;
        string id_cliente, operacion;
        Controlador.Controlador controler = new Controlador.Controlador();

        public AltasCitas(string op, string id=null)
        {
            InitializeComponent();
            operacion = op;
            id_cliente = id;
        }

        private void txtHome_Click(object sender, EventArgs e)
        {
            if (operacion.Equals("Agregar"))
            {
                MenuPrincipal mp = new MenuPrincipal();
                mp.Show();
            }
            if (operacion.Equals("Editar"))
            {
                ConsultasUsuarios cu = new ConsultasUsuarios(1,operacion,"Citas");
                cu.Show();
            }
            this.Hide();
        }

        private void AltasCitas_Load(object sender, EventArgs e)
        {
            
            if (operacion.Equals("Agregar"))
            {
                getClientes();

                this.Text = "AGREGAR CITA";
                btnAceptar.Text = "AGREGAR";
            }
            if (operacion.Equals("Editar"))
            {
                clientes = controler.GetDatosCitas(id_cliente);
                cmbClientes.Text = clientes[0];
                txtLugar.Text = clientes[1];
                txtDescripcion.Text = clientes[2];
                txtCosto.Text = clientes[3];
                txtFecha.Text = clientes[4];

                cmbClientes.Enabled = false;
                this.Text = "EDITAR CITA";
                btnAceptar.Text = "EDITAR";
                btnAceptar.Enabled = false;               
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (operacion.Equals("Agregar"))
                Altacita();
            if (operacion.Equals("Editar"))
                actalizarCita();
        }

        public void Altacita()
        {
            if (controler.AltaCitas(txtFecha.Text, txtLugar.Text, txtDescripcion.Text, txtCosto.Text, controler.GetIdClientes(cmbClientes.SelectedItem.ToString())))
                MessageBox.Show("CITA AGENDADA");
            else
                MessageBox.Show("ALGO SALIO MAL");
        }

        public void getClientes()
        {
            clientes = controler.GetClientes("NOMBRE_CLIENTE","vista_datos_cliente");
            for (int i = 0; i < clientes.Length; i++)
            {
                cmbClientes.Items.Add(clientes[i]);
            }
        }

        public void validarCampos(object cajaTexto, EventArgs e)
        {
            if (operacion.Equals("Agregar"))
            {
                if (txtFecha.Text != "" && txtLugar.Text != "" && txtDescripcion.Text != "" && txtCosto.Text != "" && cmbClientes.SelectedIndex > -1)
                    btnAceptar.Enabled = true;
                else
                    btnAceptar.Enabled = false;
            }
            if (operacion.Equals("Editar"))
            {
                if (txtFecha.Text != clientes[4] || txtLugar.Text != clientes[1] || txtDescripcion.Text != clientes[2] || txtCosto.Text != clientes[3])
                    btnAceptar.Enabled = true;
                else
                    btnAceptar.Enabled = false;
            }
        }

        public void actalizarCita()
        {
            controler.ActualizarDatosCitas(txtFecha.Text, txtLugar.Text, txtDescripcion.Text, txtCosto.Text, id_cliente);
            MessageBox.Show("DATOS ACTUALIZADOS");
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void lblCosto_Click(object sender, EventArgs e)
        {

        }
    }
}
 
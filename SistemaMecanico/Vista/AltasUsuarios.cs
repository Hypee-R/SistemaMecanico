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
    public partial class AltasUsuarios : Form
    {
        Controlador.Controlador controler = new Controlador.Controlador();
        int perfil;
        string operacion, id, sexo, menu;
        string[] datos;

        public AltasUsuarios(int pe,string ope,string i=null, string men=null)
        {
            InitializeComponent();
            perfil = pe;
            operacion = ope;
            id = i;
            menu = men;
        }

        private void Altas_Load(object sender, EventArgs e)
        {
            if(operacion.Equals("Agregar"))
            {
                btnAceptar.Text = "AGREGAR";
                if (perfil == 2) this.Text = "ALTAS CLIENTES";
                else this.Text = "ALTAS EMPLEADOS";
            }
            if (operacion.Equals("Editar"))
            {
                btnAceptar.Text = "ACTUALIZAR";
                if (perfil == 2) this.Text = "EDICION CLIENTES";
                else this.Text = "EDICION EMPLEADOS";
                datos= controler.GetDatosUsuarios(id);
                txtNombre.Text = datos[0];
                txtApPaterno.Text=datos[1];
                txtApMaterno.Text=datos[2];
                txtTelFijo.Text = datos[3];
                txtTelefonoMovil.Text = datos[4];
                txtCorreoElectronico.Text = datos[5];
                txtDireccion.Text = datos[6];
                if (datos[7].Equals("f")) cmbSexo.SelectedIndex = 1;
                else cmbSexo.SelectedIndex = 0;

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(operacion.Equals("Agregar")) AltasUsuariosBd();
            if (operacion.Equals("Editar")) ActualizarDatos();
            btnAceptar.Enabled = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if(operacion.Equals("Agregar"))
            {
            MenuPrincipal mp= new MenuPrincipal();
            mp.Show();
            this.Hide();
            }
            if (operacion.Equals("Editar"))
            {
                ConsultasUsuarios c = new ConsultasUsuarios(perfil,operacion ,menu);
                c.Show();
                this.Hide();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtApPaterno_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtApMaterno_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtTelFijo_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtTelefonoMovil_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtCorreoElectronico_TextChanged(object sender, EventArgs e)
        {
            if(operacion.Equals("Agregar"))
            {
                if (controler.GetCorreo(txtCorreoElectronico.Text) != false)
                {
                    lblAviso.Visible = true;
                    txtCorreoElectronico.Text = "";
                }
            }
            validarCampos();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSexo.SelectedIndex == 0) sexo = "m";
            else sexo = "f";
            validarCampos();
        }

        public void validarCampos()
        {
            if (operacion.Equals("Agregar"))
            {
                if (txtNombre.Text != "" && txtApPaterno.Text != "" && txtApMaterno.Text != "" && txtTelFijo.Text != "" && txtTelefonoMovil.Text != "" && txtCorreoElectronico.Text != "" && txtDireccion.Text != "" && cmbSexo.SelectedIndex > -1)
                    btnAceptar.Enabled = true;
                else
                    btnAceptar.Enabled = false;
            }
            if (operacion.Equals("Editar"))
            {
                if (txtNombre.Text != datos[0] || txtApPaterno.Text != datos[1] || txtApMaterno.Text != datos[2] || txtTelFijo.Text != datos[3] || txtTelefonoMovil.Text != datos[4] || txtCorreoElectronico.Text != datos[5] || txtDireccion.Text != datos[6] || sexo != datos[7])
                    btnAceptar.Enabled = true;
                else btnAceptar.Enabled = false;
            }
        }

        public void AltasUsuariosBd()
        {
            if (controler.AltasUsuario(txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text, txtTelFijo.Text, txtTelefonoMovil.Text, txtCorreoElectronico.Text, txtDireccion.Text, sexo, perfil))
            {
                MessageBox.Show("Usuario dado de alta :)");
            }
            else
                MessageBox.Show("Algo fallo :(");
        }

        public void ActualizarDatos()
        {
            controler.ActulizarDatos(txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text, txtTelFijo.Text, txtTelefonoMovil.Text, txtCorreoElectronico.Text, txtDireccion.Text, sexo, id);
            MessageBox.Show("Datos actualizados");
        }
        
    }
}

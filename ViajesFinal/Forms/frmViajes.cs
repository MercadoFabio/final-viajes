using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViajesFinal.Acceso_a_Datos.Implementaciones;
using ViajesFinal.Acceso_a_Datos.Interfaces;
using ViajesFinal.Entidades;
using ViajesFinal.Servicios;

namespace ViajesFinal
{
    public partial class frmViajes : Form
    {
        private GestorViajes gestor;
        private Viaje oViaje;
        private Accion modo;
        public frmViajes(Accion modo, int nro)
        {
            InitializeComponent();
            gestor = new GestorViajes(new DaoFactory());
            oViaje = new Viaje();
            this.modo = modo;
            if (modo.Equals(Accion.Create)) 
            {
                Text = "Grabar Nuevo Viaje";
                HabilitarCampos();
                btnEditar.Visible = false;
                btnGrabar.Enabled = false;
                btnBorrar.Visible = false;
            }
            if (modo.Equals(Accion.Update)) 
            {
                Text = "Editar Viaje";
                HabilitarCampos();
                CargarViaje();
                btnNuevo.Visible = false;
                btnGrabar.Enabled = false;
            }
            if (modo.Equals(Accion.Read)) 
            {
                Text = "Viaje";
                CargarViaje();
            }
        }

        private void CargarViaje()
        {
            if (lstViajes.SelectedIndex != -1) 
            {
                int nroIdViaje = (int)lstViajes.SelectedIndex+1;
                oViaje = gestor.ObtenerViajePorId(nroIdViaje);
                txtCodigo.Text = oViaje.pCodigo.ToString();
                txtDestino.Text = oViaje.pDestino;
                cboTransporte.SelectedValue = oViaje.pTransporte;
                if (oViaje.pTipo == 1)
                {
                    rbNacional.Checked = true;
                }
                if (oViaje.pTipo == 2)
                {
                    rbInternacional.Checked = true;
                }
                dtpFecha.Value = oViaje.pFecha.Date;

            }
           
        }

        public enum Accion 
        {
            Create,
            Read,
            Update,
            Delete
        }

        //Load del Form 
        private void frmViajes_Load(object sender, EventArgs e)
        {
            CargarTransportes();
            CargarLista();
            DeshabilitarCampos();
        }

        private void CargarLista()
        {
            DataTable tabla = gestor.ObtenerListaViajes();

            lstViajes.DataSource = tabla;
            lstViajes.DisplayMember = "Lista";
            //lstViajes.SelectedValue = "codigo";
            
        }

        private void CargarTransportes()
        {
            List<Transporte> lst = gestor.ObtenerTransportes();
            cboTransporte.DataSource = lst;
            cboTransporte.ValueMember = "idTransporte";
            cboTransporte.DisplayMember = "nombreTransporte";
            cboTransporte.SelectedValue = "idTransporte";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta seguro de cancelar la operacion?", "Peligro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            LimpiarCampos();
            DeshabilitarCampos();
            btnEditar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGrabar.Enabled = false;

        }

        private void DeshabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtDestino.Enabled = false;
            gbTipo.Enabled = false;
            dtpFecha.Enabled = false;
            cboTransporte.Enabled = false;
            lstViajes.Enabled = true;

        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtDestino.Text = "";
            cboTransporte.SelectedIndex = 0;
            rbNacional.Checked = true;
            dtpFecha.Value = DateTime.Now;


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimpiarCampos();
            btnNuevo.Enabled = false;
            lstViajes.Enabled = false;
            btnGrabar.Enabled = true;
            
        }

        private bool ValidarCampos()
        {
            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un codigo por favor", "Valor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return false;
            }
            if (txtDestino.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un destino", "Destino", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDestino.Focus();
                return false;
            }
            if (cboTransporte.SelectedIndex == -1)
            {
                MessageBox.Show("seleccione un tipo de transporte");
                cboTransporte.Focus();
                return false;
            
            }

            if (!rbNacional.Checked && !rbInternacional.Checked) 
            {
                MessageBox.Show("seleccione un tipo de destino");
                gbTipo.Focus();
                return false;

            }


            return true;
        }

        private void HabilitarCampos()
        {
            txtCodigo.Enabled = true;
            txtDestino.Enabled = true;
            gbTipo.Enabled = true;
            dtpFecha.Enabled = true;
            cboTransporte.Enabled = true;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            if (cboTransporte.Text.Equals(string.Empty)) 
            {
                MessageBox.Show("Debe seleccionar un transporte", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(txtCodigo.Text) || !int.TryParse(txtCodigo.Text, out _)) 
            {
                MessageBox.Show("Debe ingresar una cantidad valida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            int codigo;
            try
            {
                codigo = Convert.ToInt32(txtCodigo.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("El codigo o destino es incorrecto!");
                return;
            }

            ValidarCampos();

            GuardarViaje();
           


        }

        private void GuardarViaje() 
        {
            oViaje.pCodigo = Convert.ToInt32(txtCodigo.Text);
            oViaje.pDestino = txtDestino.Text;
            oViaje.pTransporte = Convert.ToInt32(cboTransporte.SelectedIndex+1);
            if (rbNacional.Checked)
            {
                oViaje.pTipo = 1;
            }
            if (rbInternacional.Checked)
            {
                oViaje.pTipo = 2;
            }
            oViaje.pFecha = Convert.ToDateTime(dtpFecha.Value);

            if (modo.Equals(Accion.Create)) 
            {
                if (gestor.NuevoViaje(oViaje))
                {
                    MessageBox.Show("Viaje registrado con exito.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLista();
                    LimpiarCampos();
                }
                else 
                {
                    MessageBox.Show("Error. No se pudo cargar el Viaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            
            }
            else 
            {
                if (gestor.EditarViaje(oViaje))
                {
                    MessageBox.Show("Viaje editado con exito.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLista();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("ERROR. No se pudo editar el viaje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            lstViajes.Enabled = false;
            txtCodigo.Enabled = false;
            btnEditar.Enabled = false;
            btnGrabar.Enabled = true;
        }

        private void lstViajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViajes.SelectedIndex != -1) 
            {
                CargarViaje();
            }
           
           
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int nroViaje = lstViajes.SelectedIndex + 1;
            DialogResult dialogResult = MessageBox.Show("Seguro desea eliminar el Viaje?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) 
            {
                if (gestor.BorrarViaje(nroViaje))
                {
                    MessageBox.Show("Viaje borrado con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    CargarLista();
                }
                else
                {
                    MessageBox.Show("No se pudo borrar el viaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
        }

        private void btnSaalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =MessageBox.Show("Estas seguro que desea salir ?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
                this.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vehiculoDB.Core.Clases;
using vehiculoDB.Core.Dao;

namespace vehiculoDB.Formularios.FormsPropietario
{
    public partial class formActualizarPropietario : Form
    {
        private PropietarioDao propietarioDao = new PropietarioDao();
        private int _id;
        public formActualizarPropietario(int idPropietario)
        {
            InitializeComponent();
            _id = idPropietario;
        }

        private void formActualizarPropietario_Load(object sender, EventArgs e)
        {
            var p = propietarioDao.GetById(_id);
            if (p == null)
            {
                MessageBox.Show("Propietario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBoxNombre.Text = p.Nombre;
            textBoxApellido.Text = p.Apellido;
            maskedTextBoxDui.Text = p.Dui;
            maskedTextBoxTelefono.Text = p.Telefono ?? "";
            textBoxDireccion.Text = p.Direccion ?? "";
        }

        private void bottonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Propietario propietario = new Propietario()
            {
                IdPropetario = _id,
                Nombre = textBoxNombre.Text,
                Apellido = textBoxApellido.Text,
                Dui = maskedTextBoxDui.Text,
                Telefono = maskedTextBoxTelefono.Text,
                Direccion = textBoxDireccion.Text
            };

            try
            {
                if (propietarioDao.Update(propietario))
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error inesperado "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

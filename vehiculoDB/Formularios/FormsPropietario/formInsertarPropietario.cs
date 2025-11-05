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
    public partial class formInsertarPropietario : Form
    {
        public formInsertarPropietario()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            PropietarioDao propietarioDao = new PropietarioDao();
            Propietario propietario = new Propietario()
            {
                Nombre = textBoxNombre.Text.Trim(),
                Apellido = textBoxApellido.Text.Trim(),
                Dui = maskedTextBoxDui.Text.Trim(),
                Telefono = maskedTextBoxTelefono.Text.Trim(),
                Direccion = textBoxDireccion.Text.Trim()
            };

            try
            {
                var id = propietarioDao.Insert(propietario);

                if (id > 0)
                {
                    MessageBox.Show(
                        "propietario ingresado con exito",
                        "Excito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "propietario ingresado sin exito",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrio un error inesperado: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void bottonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

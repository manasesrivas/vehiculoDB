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
using vehiculoDB.Formularios.FormsPropietario;

namespace vehiculoDB.Formularios.FormPropietario
{
    public partial class formPropietario : Form
    {
        private PropietarioDao propietarioDao = new PropietarioDao();
        public formPropietario()
        {
            InitializeComponent();
        }

        private void ConfigurationGrid()
        {
            dataGridViewPropietario.AutoGenerateColumns = false;
            dataGridViewPropietario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPropietario.MultiSelect = false;
            dataGridViewPropietario.Columns.Clear();
            dataGridViewPropietario.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreCol",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dataGridViewPropietario.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ApellidoCol",
                HeaderText = "Apellido",
                DataPropertyName = "Apellido",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dataGridViewPropietario.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DUICol",
                HeaderText = "DUI",
                DataPropertyName = "DUI",
                Width = 120
            });

            dataGridViewPropietario.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TelefonoCol",
                HeaderText = "Telefono",
                DataPropertyName = "Telefono",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dataGridViewPropietario.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DireccionCol",
                HeaderText = "Direccion",
                DataPropertyName = "Direccion",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

        }

        private void Cargar(string filtro = "")
        {
            dataGridViewPropietario.DataSource = propietarioDao.GetAll();
            dataGridViewPropietario.ClearSelection();
            dataGridViewPropietario.CurrentCell = null;
        }

        private void formPropietario_Load(object sender, EventArgs e)
        {
            ConfigurationGrid();
            Cargar();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            formInsertarPropietario form = new formInsertarPropietario();

            if (form.ShowDialog() == DialogResult.OK)
            {
                Cargar();
            }

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int? GetIdSeleccionado()
        {
            if (dataGridViewPropietario.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (dataGridViewPropietario.CurrentRow.DataBoundItem is Propietario propietario)
            {
                return propietario.IdPropetario;
            }

            return null;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            var id = GetIdSeleccionado();
            if (!id.HasValue)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }
            else
            {
                MessageBox.Show("Editar " + id.Value.ToString());
            }
                formActualizarPropietario form = new formActualizarPropietario(id.Value);

            if (form.ShowDialog() == DialogResult.OK);
        }
    }
}

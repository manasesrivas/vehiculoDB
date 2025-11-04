using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vehiculoDB.Core.Dao;

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
        }

        private void formPropietario_Load(object sender, EventArgs e)
        {
            ConfigurationGrid();
            Cargar();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

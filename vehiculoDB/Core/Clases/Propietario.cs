using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculoDB.Core.Clases
{
    internal class Propietario
    {
        private int idPropetario;
        private string nombre;
        private string apellido;
        private string dui;
        private string telefono;
        private string direccion;

        public int IdPropetario { get => idPropetario; set => idPropetario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dui { get => dui; set => dui = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }

    }
}

using vehiculoDB.Formularios.FormPropietario;

namespace vehiculoDB
{
    public partial class formVehiculo : Form
    {
        public formVehiculo()
        {
            InitializeComponent();
        }

        private void buttonPropietarios_Click(object sender, EventArgs e)
        {
            formPropietario formPropietario = new formPropietario();

            formPropietario.Show();
        }
    }
}

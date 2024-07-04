using LibreriaComputadora;

namespace FormsComputadora
{
    public partial class FormPrincipal : Form
    {
        private List<Computadora> listaComputadoras;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            listaComputadoras = new List<Computadora>();
            CargarDataGridView();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK)
            {
                listaComputadoras.Add(formAlta.Computadoras);
                CargarDataGridView();
            }
        }


        private void CargarDataGridView()
        {
            dgvComputadoras.DataSource = null;
            dgvComputadoras.DataSource = listaComputadoras;
        }
    }


}
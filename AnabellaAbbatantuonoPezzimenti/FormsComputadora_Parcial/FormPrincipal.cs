using LibreriaComputadora_Parcial;

namespace FormsComputadora_Parcial
{
    public partial class FormPrincipal : Form
    {
        List<Computadora> listaComputadoras;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            listaComputadoras = new List<Computadora>();
            ActualizarDataGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK)
            {
                listaComputadoras.Add(formAlta.NuevaComputadora);
                ActualizarDataGrid();
            }


        }

        private void ActualizarDataGrid()
        {
            dgvListasComputadoras.DataSource = null;
            dgvListasComputadoras.DataSource = listaComputadoras;
        }


    }
}
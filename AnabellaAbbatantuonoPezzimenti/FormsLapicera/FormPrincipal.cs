using LibreriaDeLapiceras;

namespace FormsLapicera
{
    public partial class FormPrincipal : Form
    {
        private List<Lapicera> listaLapiceras;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            listaLapiceras = new List<Lapicera>();
            //CargarDataGridView();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK)
            {
                listaLapiceras.Add(formAlta.Lapiceras);
                CargarDataGridView();
            }
        }


        private void CargarDataGridView()
        {
            dgvLapiceras.DataSource = null;
            dgvLapiceras.DataSource = listaLapiceras;
        }
    }


}
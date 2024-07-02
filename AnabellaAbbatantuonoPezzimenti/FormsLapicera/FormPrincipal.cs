using LibreriaDeClases;

namespace FormsLapicera
{
    public partial class FormPrincipal : Form
    {
        List<Lapicera> lapiceras;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void LapiceraPrincipal_Load(object sender, EventArgs e)
        {
            lapiceras = new List<Lapicera>();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormAltaLapicera formAltaLapicera = new FormAltaLapicera();
            if (formAltaLapicera.ShowDialog() == DialogResult.OK)
            {
                lapiceras.Add(formAltaLapicera.Lapicera);
                dgvCargar();
            }
        }
        private void dgvCargar()
        {
            dgv_lapicera.DataSource = null;
            dgv_lapicera.DataSource = lapiceras;
        }
    }
}
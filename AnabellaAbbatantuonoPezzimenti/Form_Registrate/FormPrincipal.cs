using MisClases;

namespace Form_Registrate
{
    public partial class FormPrincipal : Form
    {

        List<Ingresante> ingresanteList;
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ingresanteList = new List<Ingresante>();
            ActualizarDtgIngresantes();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK)
            {
                ingresanteList.Add(formAlta.Ingresantes);
                ActualizarDtgIngresantes();
            }

        }


        private void ActualizarDtgIngresantes()
        {
            dtgIngresantes.DataSource = null;
            dtgIngresantes.DataSource = ingresanteList;
        }


    }
}
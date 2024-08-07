using System.Runtime.CompilerServices;
using Segunda_evaluacion;

namespace FormComputadora
{
    public partial class FormPrincipal : Form
    {
        private List<Computadora> misComputadoras;



        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.misComputadoras = new List<Computadora>();
        }

        private void btn_Agragar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();
            if (formAlta.DialogResult == DialogResult.OK)
            {
                misComputadoras.Add(formAlta.MiPc);
            }

            dgv_computadoras.DataSource = null;
            dgv_computadoras.DataSource = misComputadoras;





        }
    }
}




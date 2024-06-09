using LibreriaParcial;
using System.Drawing.Text;

namespace FormularioAuto
{
    public partial class FormularioAuto : Form
    {
        List<Auto> misAutos;
        public FormularioAuto()
        {
            InitializeComponent();
        }

        private void FormularioAuto_Load(object sender, EventArgs e)
        {
            this.misAutos = new List<Auto>();
            this.cmb_color.Items.AddRange(Auto.ColoresValidos().ToArray());
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            string marca = this.txt_marca.Text;
            string cantCombust = this.txt_cantCombust.Text;
            string color = this.cmb_color.Text;

            Auto miAuto = new Auto(marca, cantCombust, color);
            misAutos.Add(miAuto);
            this.lst_AutosIngresados.Items.AddRange(misAutos.ToArray());
            this.Limpiar();




        }

        private void Limpiar()
        {
            this.cmb_color.Text = string.Empty;
            this.txt_marca.Text = string.Empty;
            this.txt_cantCombust.Text = string.Empty;
        }

        private void lst_AutosIngresados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}



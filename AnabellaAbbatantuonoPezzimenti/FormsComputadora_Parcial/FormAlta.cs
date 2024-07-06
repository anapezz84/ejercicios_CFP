using LibreriaComputadora_Parcial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FormsComputadora_Parcial
{
    public partial class FormAlta : Form
    {
        Computadora nuevaComputadora;

        public Computadora NuevaComputadora { get => nuevaComputadora; }

        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            cbxProcesador.DataSource = Computadora.ListadoDeProcesadores();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string procesador = cbxProcesador.Text;
            int memoriaRam = (int)nudMemoriaRam.Value;
            int disco = (int)nudDisco.Value;
            string sistemaOperativo = string.Empty;


            foreach (RadioButton radio in gbxSistemaOperativo.Controls)
            {
                if (radio.Checked)
                {
                    sistemaOperativo = radio.Text;
                    break;
                }
            }


            if (string.IsNullOrEmpty(cbxProcesador.Text))
            {
                MessageBox.Show("Seleccione un procesador ");
            }
            else if (memoriaRam <= 0)
            {
                MessageBox.Show("debe seleccionar un número mayor a 0");
            }
            else
            {

                nuevaComputadora = new Computadora(disco, memoriaRam, procesador, sistemaOperativo);
                foreach (CheckBox box in gbxProgramas.Controls)
                {
                    if (box.Checked)
                    {
                        nuevaComputadora.SetPrograma(box.Text);
                    }
                }

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
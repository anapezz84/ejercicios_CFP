using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Segunda_evaluacion;

namespace FormComputadora
{
    public partial class FormAlta : Form
    {
        private Computadora miPc;
        public Computadora MiPc { get => miPc; }

        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            this.cmb_Procesadores.DataSource = Computadora.ListadoDeProcesadores();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int capacidadDisco = (int)this.nud_Disco.Value;
            int memoriaRam = (int)this.nud_memoriaRam.Value;
            string procesador = cmb_Procesadores.Text;
            List<string> programas;
            string sistemaOperativo = string.Empty;

            foreach (RadioButton item in this.gpb_SistOperat.Controls)
            {
                if (item.Checked)
                {
                    sistemaOperativo = item.Text;
                    break;
                }
                Computadora pc = new Computadora(capacidadDisco, memoriaRam, procesador, sistemaOperativo);
                foreach (CheckBox chbox in gpb_Programas.Controls)
                {
                    if (chbox.Checked)
                    {
                        pc.SetPrograma(chbox.Text);
                    }
                }
                this.miPc = pc;
                DialogResult = DialogResult.OK;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


    }
}
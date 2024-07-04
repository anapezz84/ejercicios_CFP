using LibreriaComputadora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsComputadora
{
    public partial class FormAlta : Form
    {
        private Computadora computadoras;

        public computadora computadoras { get => computadoras; }

        public FormAlta()
        {
            InitializeComponent();
        }

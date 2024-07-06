using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FormsComputadora_Parcial
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvListasComputadoras = new DataGridView();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListasComputadoras).BeginInit();
            SuspendLayout();
            // 
            // dgvListasComputadoras
            // 
            dgvListasComputadoras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListasComputadoras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListasComputadoras.Location = new Point(57, 39);
            dgvListasComputadoras.Margin = new Padding(4, 3, 4, 3);
            dgvListasComputadoras.Name = "dgvListasComputadoras";
            dgvListasComputadoras.Size = new Size(739, 314);
            dgvListasComputadoras.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Green;
            btnAgregar.Font = new System.Drawing.Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(336, 380);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(149, 44);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(852, 452);
            Controls.Add(btnAgregar);
            Controls.Add(dgvListasComputadoras);
            Font = new System.Drawing.Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormPrincipal";
            Text = "Computadoras";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListasComputadoras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListasComputadoras;
        private Button btnAgregar;
    }
}
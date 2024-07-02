using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FormsLapicera
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
            dgvLapiceras = new DataGridView();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLapiceras).BeginInit();
            SuspendLayout();
            // 
            // dgvLapiceras
            // 
            dgvLapiceras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLapiceras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLapiceras.Location = new Point(54, 51);
            dgvLapiceras.Name = "dgvLapiceras";
            dgvLapiceras.Size = new Size(422, 323);
            dgvLapiceras.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new System.Drawing.Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(211, 422);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 36);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(527, 518);
            Controls.Add(btnAgregar);
            Controls.Add(dgvLapiceras);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLapiceras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLapiceras;
        private Button btnAgregar;
    }
}
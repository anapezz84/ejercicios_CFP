﻿namespace FormRegistrate
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
            dgv_ingresante = new DataGridView();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ingresante).BeginInit();
            SuspendLayout();
            // 
            // dgv_ingresante
            // 
            dgv_ingresante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ingresante.Location = new Point(12, 12);
            dgv_ingresante.Name = "dgv_ingresante";
            dgv_ingresante.Size = new Size(1155, 360);
            dgv_ingresante.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(532, 378);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1179, 450);
            Controls.Add(btn_agregar);
            Controls.Add(dgv_ingresante);
            Name = "FormPrincipal";
            Text = "Listado de ingresantes";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ingresante).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_ingresante;
        private Button btn_agregar;
    }
}
﻿using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Form_Registrate
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
            dtgIngresantes = new DataGridView();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgIngresantes).BeginInit();
            SuspendLayout();
            // 
            // dtgIngresantes
            // 
            dtgIngresantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgIngresantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgIngresantes.Location = new Point(37, 45);
            dtgIngresantes.Name = "dtgIngresantes";
            dtgIngresantes.Size = new Size(692, 299);
            dtgIngresantes.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(354, 379);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 39);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(781, 446);
            Controls.Add(btnAgregar);
            Controls.Add(dtgIngresantes);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgIngresantes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgIngresantes;
        private Button btnAgregar;
    }
}

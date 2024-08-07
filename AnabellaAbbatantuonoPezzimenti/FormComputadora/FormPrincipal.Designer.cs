using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FormComputadora
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
            dgv_computadoras = new DataGridView();
            btn_Agragar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_computadoras).BeginInit();
            SuspendLayout();
            // 
            // dgv_computadoras
            // 
            dgv_computadoras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_computadoras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_computadoras.Location = new Point(21, 30);
            dgv_computadoras.Name = "dgv_computadoras";
            dgv_computadoras.Size = new Size(946, 308);
            dgv_computadoras.TabIndex = 0;
            // 
            // btn_Agragar
            // 
            btn_Agragar.Location = new Point(432, 385);
            btn_Agragar.Name = "btn_Agragar";
            btn_Agragar.Size = new Size(190, 23);
            btn_Agragar.TabIndex = 1;
            btn_Agragar.Text = "Agregar";
            btn_Agragar.UseVisualStyleBackColor = true;
            btn_Agragar.Click += btn_Agragar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1004, 450);
            Controls.Add(btn_Agragar);
            Controls.Add(dgv_computadoras);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Computadoras";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_computadoras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_computadoras;
        private Button btn_Agragar;
    }
}
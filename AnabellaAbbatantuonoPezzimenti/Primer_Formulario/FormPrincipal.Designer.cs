using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Primer_Formulario
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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            txt_nombre = new TextBox();
            txt_especie = new TextBox();
            txt_edad = new TextBox();
            lbl_nombre = new Label();
            lbl_especie = new Label();
            lbl_edad = new Label();
            lst_salida = new ListBox();
            btn_ingresarDatos = new Button();
            btn_borrar = new Button();
            lbl_nombreEmpresa = new Label();
            btn_limpiartxtbox = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txt_nombre
            // 
            txt_nombre.BorderStyle = BorderStyle.FixedSingle;
            txt_nombre.Font = new System.Drawing.Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_nombre.Location = new Point(139, 195);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.PlaceholderText = "INGRESE NOMBRE DE LA MASCOTA";
            txt_nombre.Size = new Size(217, 21);
            txt_nombre.TabIndex = 0;
            // 
            // txt_especie
            // 
            txt_especie.Font = new System.Drawing.Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_especie.Location = new Point(139, 242);
            txt_especie.Name = "txt_especie";
            txt_especie.PlaceholderText = "INGRESE SU ESPECIE";
            txt_especie.Size = new Size(184, 21);
            txt_especie.TabIndex = 1;
            // 
            // txt_edad
            // 
            txt_edad.Font = new System.Drawing.Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_edad.Location = new Point(139, 293);
            txt_edad.Name = "txt_edad";
            txt_edad.PlaceholderText = "INGRESE SU EDAD";
            txt_edad.Size = new Size(184, 21);
            txt_edad.TabIndex = 2;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new System.Drawing.Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nombre.ForeColor = Color.Black;
            lbl_nombre.Location = new Point(55, 195);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(78, 17);
            lbl_nombre.TabIndex = 3;
            lbl_nombre.Text = "NOMBRE";
            // 
            // lbl_especie
            // 
            lbl_especie.AutoSize = true;
            lbl_especie.Font = new System.Drawing.Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_especie.ForeColor = Color.Black;
            lbl_especie.Location = new Point(55, 248);
            lbl_especie.Name = "lbl_especie";
            lbl_especie.Size = new Size(72, 17);
            lbl_especie.TabIndex = 4;
            lbl_especie.Text = "ESPECIE";
            // 
            // lbl_edad
            // 
            lbl_edad.AutoSize = true;
            lbl_edad.Font = new System.Drawing.Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_edad.ForeColor = Color.Black;
            lbl_edad.Location = new Point(55, 294);
            lbl_edad.Name = "lbl_edad";
            lbl_edad.Size = new Size(51, 17);
            lbl_edad.TabIndex = 5;
            lbl_edad.Text = "EDAD";
            // 
            // lst_salida
            // 
            lst_salida.Font = new System.Drawing.Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lst_salida.FormattingEnabled = true;
            lst_salida.ItemHeight = 15;
            lst_salida.Location = new Point(488, 186);
            lst_salida.Name = "lst_salida";
            lst_salida.Size = new Size(287, 184);
            lst_salida.TabIndex = 6;
            // 
            // btn_ingresarDatos
            // 
            btn_ingresarDatos.Font = new System.Drawing.Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ingresarDatos.Location = new Point(85, 374);
            btn_ingresarDatos.Name = "btn_ingresarDatos";
            btn_ingresarDatos.Size = new Size(128, 42);
            btn_ingresarDatos.TabIndex = 7;
            btn_ingresarDatos.Text = "INGRESAR";
            btn_ingresarDatos.UseVisualStyleBackColor = true;
            btn_ingresarDatos.Click += btn_ingresarDatos_Click;
            // 
            // btn_borrar
            // 
            btn_borrar.Font = new System.Drawing.Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_borrar.ForeColor = Color.Black;
            btn_borrar.Location = new Point(568, 376);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(136, 47);
            btn_borrar.TabIndex = 8;
            btn_borrar.Text = "BORRAR";
            btn_borrar.UseVisualStyleBackColor = true;
            btn_borrar.Click += btn_borrar_Click;
            // 
            // lbl_nombreEmpresa
            // 
            lbl_nombreEmpresa.Font = new System.Drawing.Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nombreEmpresa.Location = new Point(287, 52);
            lbl_nombreEmpresa.Name = "lbl_nombreEmpresa";
            lbl_nombreEmpresa.Size = new Size(211, 49);
            lbl_nombreEmpresa.TabIndex = 9;
            lbl_nombreEmpresa.Text = "VETERINARIA SAN FRANCISCO";
            // 
            // btn_limpiartxtbox
            // 
            btn_limpiartxtbox.Font = new System.Drawing.Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpiartxtbox.Location = new Point(287, 383);
            btn_limpiartxtbox.Name = "btn_limpiartxtbox";
            btn_limpiartxtbox.Size = new Size(133, 33);
            btn_limpiartxtbox.TabIndex = 10;
            btn_limpiartxtbox.Text = "Limpiar txtboxs";
            btn_limpiartxtbox.UseVisualStyleBackColor = true;
            btn_limpiartxtbox.Click += btn_limpiartxtbox_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(31, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(568, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(182, 159);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_limpiartxtbox);
            Controls.Add(lbl_nombreEmpresa);
            Controls.Add(btn_borrar);
            Controls.Add(btn_ingresarDatos);
            Controls.Add(lst_salida);
            Controls.Add(lbl_edad);
            Controls.Add(lbl_especie);
            Controls.Add(lbl_nombre);
            Controls.Add(txt_edad);
            Controls.Add(txt_especie);
            Controls.Add(txt_nombre);
            Name = "FormPrincipal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private TextBox txt_nombre;
        private TextBox txt_especie;
        private TextBox txt_edad;
        private Label lbl_nombre;
        private Label lbl_especie;
        private Label lbl_edad;
        private ListBox lst_salida;
        private Button btn_ingresarDatos;
        private Button btn_borrar;
        private Label lbl_nombreEmpresa;
        private Button btn_limpiartxtbox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
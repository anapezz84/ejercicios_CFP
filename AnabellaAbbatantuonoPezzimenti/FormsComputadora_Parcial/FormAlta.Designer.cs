using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FormsComputadora_Parcial
{
    partial class FormAlta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbxHardware = new GroupBox();
            lblDisco = new Label();
            lblMemoriaRam = new Label();
            lblProcesador = new Label();
            nudDisco = new NumericUpDown();
            nudMemoriaRam = new NumericUpDown();
            cbxProcesador = new ComboBox();
            gbxSistemaOperativo = new GroupBox();
            rdbMacOS = new RadioButton();
            rdbLinux = new RadioButton();
            rdbWindows = new RadioButton();
            gbxProgramas = new GroupBox();
            checkAvast = new CheckBox();
            checkDropbox = new CheckBox();
            checkWinrar = new CheckBox();
            checkAdobe = new CheckBox();
            checkOffice = new CheckBox();
            btnCancelar = new Button();
            btnAgregar = new Button();
            gbxHardware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDisco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMemoriaRam).BeginInit();
            gbxSistemaOperativo.SuspendLayout();
            gbxProgramas.SuspendLayout();
            SuspendLayout();
            // 
            // gbxHardware
            // 
            gbxHardware.Controls.Add(lblDisco);
            gbxHardware.Controls.Add(lblMemoriaRam);
            gbxHardware.Controls.Add(lblProcesador);
            gbxHardware.Controls.Add(nudDisco);
            gbxHardware.Controls.Add(nudMemoriaRam);
            gbxHardware.Controls.Add(cbxProcesador);
            gbxHardware.Font = new System.Drawing.Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxHardware.Location = new Point(51, 26);
            gbxHardware.Name = "gbxHardware";
            gbxHardware.Size = new Size(251, 294);
            gbxHardware.TabIndex = 0;
            gbxHardware.TabStop = false;
            gbxHardware.Text = "Hardware";
            // 
            // lblDisco
            // 
            lblDisco.AutoSize = true;
            lblDisco.Location = new Point(30, 182);
            lblDisco.Name = "lblDisco";
            lblDisco.Size = new Size(45, 17);
            lblDisco.TabIndex = 5;
            lblDisco.Text = "Disco";
            // 
            // lblMemoriaRam
            // 
            lblMemoriaRam.AutoSize = true;
            lblMemoriaRam.Location = new Point(6, 129);
            lblMemoriaRam.Name = "lblMemoriaRam";
            lblMemoriaRam.Size = new Size(102, 17);
            lblMemoriaRam.TabIndex = 4;
            lblMemoriaRam.Text = "Memoria Ram";
            // 
            // lblProcesador
            // 
            lblProcesador.AutoSize = true;
            lblProcesador.Location = new Point(16, 65);
            lblProcesador.Name = "lblProcesador";
            lblProcesador.Size = new Size(82, 17);
            lblProcesador.TabIndex = 3;
            lblProcesador.Text = "Procesador";
            // 
            // nudDisco
            // 
            nudDisco.Location = new Point(113, 180);
            nudDisco.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudDisco.Name = "nudDisco";
            nudDisco.Size = new Size(120, 25);
            nudDisco.TabIndex = 2;
            // 
            // nudMemoriaRam
            // 
            nudMemoriaRam.Location = new Point(114, 121);
            nudMemoriaRam.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudMemoriaRam.Name = "nudMemoriaRam";
            nudMemoriaRam.Size = new Size(120, 25);
            nudMemoriaRam.TabIndex = 1;
            // 
            // cbxProcesador
            // 
            cbxProcesador.FormattingEnabled = true;
            cbxProcesador.Location = new Point(113, 65);
            cbxProcesador.Name = "cbxProcesador";
            cbxProcesador.Size = new Size(121, 25);
            cbxProcesador.TabIndex = 0;
            // 
            // gbxSistemaOperativo
            // 
            gbxSistemaOperativo.Controls.Add(rdbMacOS);
            gbxSistemaOperativo.Controls.Add(rdbLinux);
            gbxSistemaOperativo.Controls.Add(rdbWindows);
            gbxSistemaOperativo.Font = new System.Drawing.Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxSistemaOperativo.Location = new Point(343, 26);
            gbxSistemaOperativo.Name = "gbxSistemaOperativo";
            gbxSistemaOperativo.Size = new Size(163, 121);
            gbxSistemaOperativo.TabIndex = 1;
            gbxSistemaOperativo.TabStop = false;
            gbxSistemaOperativo.Text = "Sistema operativo";
            // 
            // rdbMacOS
            // 
            rdbMacOS.AutoSize = true;
            rdbMacOS.Location = new Point(34, 84);
            rdbMacOS.Name = "rdbMacOS";
            rdbMacOS.Size = new Size(74, 21);
            rdbMacOS.TabIndex = 2;
            rdbMacOS.TabStop = true;
            rdbMacOS.Text = "MacOs";
            rdbMacOS.UseVisualStyleBackColor = true;
            // 
            // rdbLinux
            // 
            rdbLinux.AutoSize = true;
            rdbLinux.Location = new Point(34, 59);
            rdbLinux.Name = "rdbLinux";
            rdbLinux.Size = new Size(64, 21);
            rdbLinux.TabIndex = 1;
            rdbLinux.TabStop = true;
            rdbLinux.Text = "Linux";
            rdbLinux.UseVisualStyleBackColor = true;
            // 
            // rdbWindows
            // 
            rdbWindows.AutoSize = true;
            rdbWindows.Location = new Point(34, 34);
            rdbWindows.Name = "rdbWindows";
            rdbWindows.Size = new Size(85, 21);
            rdbWindows.TabIndex = 0;
            rdbWindows.TabStop = true;
            rdbWindows.Text = "Windows";
            rdbWindows.UseVisualStyleBackColor = true;
            // 
            // gbxProgramas
            // 
            gbxProgramas.Controls.Add(checkAvast);
            gbxProgramas.Controls.Add(checkDropbox);
            gbxProgramas.Controls.Add(checkWinrar);
            gbxProgramas.Controls.Add(checkAdobe);
            gbxProgramas.Controls.Add(checkOffice);
            gbxProgramas.Font = new System.Drawing.Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxProgramas.Location = new Point(343, 153);
            gbxProgramas.Name = "gbxProgramas";
            gbxProgramas.Size = new Size(163, 167);
            gbxProgramas.TabIndex = 1;
            gbxProgramas.TabStop = false;
            gbxProgramas.Text = "Programas";
            // 
            // checkAvast
            // 
            checkAvast.AutoSize = true;
            checkAvast.Location = new Point(33, 131);
            checkAvast.Name = "checkAvast";
            checkAvast.Size = new Size(64, 21);
            checkAvast.TabIndex = 4;
            checkAvast.Text = "Avast";
            checkAvast.UseVisualStyleBackColor = true;
            // 
            // checkDropbox
            // 
            checkDropbox.AutoSize = true;
            checkDropbox.Location = new Point(33, 97);
            checkDropbox.Name = "checkDropbox";
            checkDropbox.Size = new Size(84, 21);
            checkDropbox.TabIndex = 3;
            checkDropbox.Text = "Dropbox";
            checkDropbox.UseVisualStyleBackColor = true;
            // 
            // checkWinrar
            // 
            checkWinrar.AutoSize = true;
            checkWinrar.Location = new Point(34, 72);
            checkWinrar.Name = "checkWinrar";
            checkWinrar.Size = new Size(72, 21);
            checkWinrar.TabIndex = 2;
            checkWinrar.Text = "Winrar";
            checkWinrar.UseVisualStyleBackColor = true;
            // 
            // checkAdobe
            // 
            checkAdobe.AutoSize = true;
            checkAdobe.Location = new Point(34, 47);
            checkAdobe.Name = "checkAdobe";
            checkAdobe.Size = new Size(122, 21);
            checkAdobe.TabIndex = 1;
            checkAdobe.Text = "Adobe Reader";
            checkAdobe.UseVisualStyleBackColor = true;
            // 
            // checkOffice
            // 
            checkOffice.AutoSize = true;
            checkOffice.Location = new Point(34, 22);
            checkOffice.Name = "checkOffice";
            checkOffice.Size = new Size(66, 21);
            checkOffice.TabIndex = 0;
            checkOffice.Text = "Office";
            checkOffice.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(219, 357);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 35);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregar.Font = new System.Drawing.Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(377, 357);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(104, 35);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(567, 472);
            Controls.Add(btnAgregar);
            Controls.Add(btnCancelar);
            Controls.Add(gbxSistemaOperativo);
            Controls.Add(gbxProgramas);
            Controls.Add(gbxHardware);
            Name = "FormAlta";
            Text = "FormAlta";
            Load += FormAlta_Load;
            gbxHardware.ResumeLayout(false);
            gbxHardware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDisco).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMemoriaRam).EndInit();
            gbxSistemaOperativo.ResumeLayout(false);
            gbxSistemaOperativo.PerformLayout();
            gbxProgramas.ResumeLayout(false);
            gbxProgramas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxHardware;
        private GroupBox gbxSistemaOperativo;
        private GroupBox gbxProgramas;
        private ComboBox cbxProcesador;
        private Label lblDisco;
        private Label lblMemoriaRam;
        private Label lblProcesador;
        private NumericUpDown nudDisco;
        private NumericUpDown nudMemoriaRam;
        private RadioButton rdbMacOS;
        private RadioButton rdbLinux;
        private RadioButton rdbWindows;
        private CheckBox checkAvast;
        private CheckBox checkDropbox;
        private CheckBox checkWinrar;
        private CheckBox checkAdobe;
        private CheckBox checkOffice;
        private Button btnCancelar;
        private Button btnAgregar;
    }
}
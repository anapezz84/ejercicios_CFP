using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FormComputadora
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
            gpb_Hardware = new GroupBox();
            lbl_Disco = new Label();
            nud_Disco = new NumericUpDown();
            lbl_MemoriaRam = new Label();
            nud_memoriaRam = new NumericUpDown();
            lbl_Procesador = new Label();
            cmb_Procesadores = new ComboBox();
            gpb_SistOperat = new GroupBox();
            rd_Windows = new RadioButton();
            rd_Linux = new RadioButton();
            rd_MacOs = new RadioButton();
            gpb_Programas = new GroupBox();
            ckb_Avast = new CheckBox();
            ckb_Office = new CheckBox();
            ckb_Dropbox = new CheckBox();
            ckb_Adobe = new CheckBox();
            ckb_Winrar = new CheckBox();
            btn_Cancelar = new Button();
            btn_Agregar = new Button();
            gpb_Hardware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Disco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_memoriaRam).BeginInit();
            gpb_SistOperat.SuspendLayout();
            gpb_Programas.SuspendLayout();
            SuspendLayout();
            // 
            // gpb_Hardware
            // 
            gpb_Hardware.Controls.Add(lbl_Disco);
            gpb_Hardware.Controls.Add(nud_Disco);
            gpb_Hardware.Controls.Add(lbl_MemoriaRam);
            gpb_Hardware.Controls.Add(nud_memoriaRam);
            gpb_Hardware.Controls.Add(lbl_Procesador);
            gpb_Hardware.Controls.Add(cmb_Procesadores);
            gpb_Hardware.Location = new Point(58, 47);
            gpb_Hardware.Name = "gpb_Hardware";
            gpb_Hardware.Size = new Size(330, 305);
            gpb_Hardware.TabIndex = 0;
            gpb_Hardware.TabStop = false;
            gpb_Hardware.Text = "Hardware";
            // 
            // lbl_Disco
            // 
            lbl_Disco.AutoSize = true;
            lbl_Disco.Location = new Point(35, 142);
            lbl_Disco.Name = "lbl_Disco";
            lbl_Disco.Size = new Size(36, 15);
            lbl_Disco.TabIndex = 14;
            lbl_Disco.Text = "Disco";
            // 
            // nud_Disco
            // 
            nud_Disco.Location = new Point(136, 140);
            nud_Disco.Name = "nud_Disco";
            nud_Disco.Size = new Size(125, 23);
            nud_Disco.TabIndex = 15;
            // 
            // lbl_MemoriaRam
            // 
            lbl_MemoriaRam.AutoSize = true;
            lbl_MemoriaRam.Location = new Point(35, 96);
            lbl_MemoriaRam.Name = "lbl_MemoriaRam";
            lbl_MemoriaRam.Size = new Size(82, 15);
            lbl_MemoriaRam.TabIndex = 13;
            lbl_MemoriaRam.Text = "Memoria Ram";
            // 
            // nud_memoriaRam
            // 
            nud_memoriaRam.Location = new Point(137, 94);
            nud_memoriaRam.Name = "nud_memoriaRam";
            nud_memoriaRam.Size = new Size(124, 23);
            nud_memoriaRam.TabIndex = 16;
            // 
            // lbl_Procesador
            // 
            lbl_Procesador.AutoSize = true;
            lbl_Procesador.Location = new Point(35, 48);
            lbl_Procesador.Name = "lbl_Procesador";
            lbl_Procesador.Size = new Size(66, 15);
            lbl_Procesador.TabIndex = 12;
            lbl_Procesador.Text = "Procesador";
            // 
            // cmb_Procesadores
            // 
            cmb_Procesadores.FormattingEnabled = true;
            cmb_Procesadores.Location = new Point(136, 45);
            cmb_Procesadores.Name = "cmb_Procesadores";
            cmb_Procesadores.Size = new Size(125, 23);
            cmb_Procesadores.TabIndex = 17;
            // 
            // gpb_SistOperat
            // 
            gpb_SistOperat.Controls.Add(rd_Windows);
            gpb_SistOperat.Controls.Add(rd_Linux);
            gpb_SistOperat.Controls.Add(rd_MacOs);
            gpb_SistOperat.Location = new Point(486, 37);
            gpb_SistOperat.Name = "gpb_SistOperat";
            gpb_SistOperat.Size = new Size(241, 152);
            gpb_SistOperat.TabIndex = 0;
            gpb_SistOperat.TabStop = false;
            gpb_SistOperat.Text = "Sistema Operativo";
            // 
            // rd_Windows
            // 
            rd_Windows.AutoSize = true;
            rd_Windows.Location = new Point(17, 36);
            rd_Windows.Name = "rd_Windows";
            rd_Windows.Size = new Size(74, 19);
            rd_Windows.TabIndex = 4;
            rd_Windows.TabStop = true;
            rd_Windows.Text = "Windows";
            rd_Windows.UseVisualStyleBackColor = true;
            // 
            // rd_Linux
            // 
            rd_Linux.AutoSize = true;
            rd_Linux.Location = new Point(17, 71);
            rd_Linux.Name = "rd_Linux";
            rd_Linux.Size = new Size(54, 19);
            rd_Linux.TabIndex = 5;
            rd_Linux.TabStop = true;
            rd_Linux.Text = "Linux";
            rd_Linux.UseVisualStyleBackColor = true;
            // 
            // rd_MacOs
            // 
            rd_MacOs.AutoSize = true;
            rd_MacOs.Location = new Point(17, 108);
            rd_MacOs.Name = "rd_MacOs";
            rd_MacOs.Size = new Size(62, 19);
            rd_MacOs.TabIndex = 6;
            rd_MacOs.TabStop = true;
            rd_MacOs.Text = "MacOs";
            rd_MacOs.UseVisualStyleBackColor = true;
            // 
            // gpb_Programas
            // 
            gpb_Programas.Controls.Add(ckb_Avast);
            gpb_Programas.Controls.Add(ckb_Office);
            gpb_Programas.Controls.Add(ckb_Dropbox);
            gpb_Programas.Controls.Add(ckb_Adobe);
            gpb_Programas.Controls.Add(ckb_Winrar);
            gpb_Programas.Location = new Point(486, 211);
            gpb_Programas.Name = "gpb_Programas";
            gpb_Programas.Size = new Size(246, 151);
            gpb_Programas.TabIndex = 1;
            gpb_Programas.TabStop = false;
            gpb_Programas.Text = "Programas";
            // 
            // ckb_Avast
            // 
            ckb_Avast.AutoSize = true;
            ckb_Avast.Location = new Point(17, 122);
            ckb_Avast.Name = "ckb_Avast";
            ckb_Avast.Size = new Size(55, 19);
            ckb_Avast.TabIndex = 11;
            ckb_Avast.Text = "Avast";
            ckb_Avast.UseVisualStyleBackColor = true;
            // 
            // ckb_Office
            // 
            ckb_Office.AutoSize = true;
            ckb_Office.Location = new Point(19, 22);
            ckb_Office.Name = "ckb_Office";
            ckb_Office.Size = new Size(58, 19);
            ckb_Office.TabIndex = 7;
            ckb_Office.Text = "Office";
            ckb_Office.UseVisualStyleBackColor = true;
            // 
            // ckb_Dropbox
            // 
            ckb_Dropbox.AutoSize = true;
            ckb_Dropbox.Location = new Point(17, 97);
            ckb_Dropbox.Name = "ckb_Dropbox";
            ckb_Dropbox.Size = new Size(72, 19);
            ckb_Dropbox.TabIndex = 10;
            ckb_Dropbox.Text = "Dropbox";
            ckb_Dropbox.UseVisualStyleBackColor = true;
            // 
            // ckb_Adobe
            // 
            ckb_Adobe.AutoSize = true;
            ckb_Adobe.Location = new Point(19, 47);
            ckb_Adobe.Name = "ckb_Adobe";
            ckb_Adobe.Size = new Size(100, 19);
            ckb_Adobe.TabIndex = 8;
            ckb_Adobe.Text = "Adobe Reader";
            ckb_Adobe.UseVisualStyleBackColor = true;
            // 
            // ckb_Winrar
            // 
            ckb_Winrar.AutoSize = true;
            ckb_Winrar.Location = new Point(17, 72);
            ckb_Winrar.Name = "ckb_Winrar";
            ckb_Winrar.Size = new Size(61, 19);
            ckb_Winrar.TabIndex = 9;
            ckb_Winrar.Text = "Winrar";
            ckb_Winrar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(513, 392);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(75, 23);
            btn_Cancelar.TabIndex = 2;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(640, 392);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(75, 23);
            btn_Agregar.TabIndex = 3;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(871, 450);
            Controls.Add(btn_Agregar);
            Controls.Add(btn_Cancelar);
            Controls.Add(gpb_Programas);
            Controls.Add(gpb_SistOperat);
            Controls.Add(gpb_Hardware);
            Name = "FormAlta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAlta";
            Load += FormAlta_Load;
            gpb_Hardware.ResumeLayout(false);
            gpb_Hardware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Disco).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_memoriaRam).EndInit();
            gpb_SistOperat.ResumeLayout(false);
            gpb_SistOperat.PerformLayout();
            gpb_Programas.ResumeLayout(false);
            gpb_Programas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpb_Hardware;
        private GroupBox gpb_SistOperat;
        private GroupBox gpb_Programas;
        private Label lbl_Disco;
        private NumericUpDown nud_Disco;
        private Label lbl_MemoriaRam;
        private NumericUpDown nud_memoriaRam;
        private Label lbl_Procesador;
        private ComboBox cmb_Procesadores;
        private RadioButton rd_Windows;
        private RadioButton rd_Linux;
        private RadioButton rd_MacOs;
        private CheckBox ckb_Avast;
        private CheckBox ckb_Office;
        private CheckBox ckb_Dropbox;
        private CheckBox ckb_Adobe;
        private CheckBox ckb_Winrar;
        private Button btn_Cancelar;
        private Button btn_Agregar;
    }
}
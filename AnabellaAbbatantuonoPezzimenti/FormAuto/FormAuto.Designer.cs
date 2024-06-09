namespace FormularioAuto
{
    partial class FormularioAuto
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
            lbl_marca = new Label();
            lbl_cantCombust = new Label();
            lbl_Color = new Label();
            btn_Ok = new Button();
            txt_marca = new TextBox();
            txt_cantCombust = new TextBox();
            cmb_color = new ComboBox();
            lst_AutosIngresados = new ListBox();
            lbl_tituloLista = new Label();
            SuspendLayout();
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Location = new Point(47, 51);
            lbl_marca.Margin = new Padding(4, 0, 4, 0);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(54, 21);
            lbl_marca.TabIndex = 0;
            lbl_marca.Text = "Marca";
            // 
            // lbl_cantCombust
            // 
            lbl_cantCombust.AutoSize = true;
            lbl_cantCombust.Location = new Point(47, 130);
            lbl_cantCombust.Margin = new Padding(4, 0, 4, 0);
            lbl_cantCombust.Name = "lbl_cantCombust";
            lbl_cantCombust.Size = new Size(136, 21);
            lbl_cantCombust.TabIndex = 2;
            lbl_cantCombust.Text = "Cant_Combustible";
            // 
            // lbl_Color
            // 
            lbl_Color.AutoSize = true;
            lbl_Color.Location = new Point(47, 212);
            lbl_Color.Margin = new Padding(4, 0, 4, 0);
            lbl_Color.Name = "lbl_Color";
            lbl_Color.Size = new Size(46, 21);
            lbl_Color.TabIndex = 4;
            lbl_Color.Text = "Color";
            // 
            // btn_Ok
            // 
            btn_Ok.BackColor = SystemColors.ControlDark;
            btn_Ok.Location = new Point(47, 362);
            btn_Ok.Margin = new Padding(4);
            btn_Ok.Name = "btn_Ok";
            btn_Ok.Size = new Size(96, 33);
            btn_Ok.TabIndex = 6;
            btn_Ok.Text = "Ok";
            btn_Ok.UseVisualStyleBackColor = false;
            btn_Ok.Click += btn_Ok_Click;
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(47, 76);
            txt_marca.Margin = new Padding(4);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(154, 28);
            txt_marca.TabIndex = 1;
            // 
            // txt_cantCombust
            // 
            txt_cantCombust.Location = new Point(47, 155);
            txt_cantCombust.Margin = new Padding(4);
            txt_cantCombust.Name = "txt_cantCombust";
            txt_cantCombust.Size = new Size(154, 28);
            txt_cantCombust.TabIndex = 3;
            // 
            // cmb_color
            // 
            cmb_color.FormattingEnabled = true;
            cmb_color.Location = new Point(47, 237);
            cmb_color.Margin = new Padding(4);
            cmb_color.Name = "cmb_color";
            cmb_color.Size = new Size(154, 29);
            cmb_color.TabIndex = 5;
            // 
            // lst_AutosIngresados
            // 
            lst_AutosIngresados.FormattingEnabled = true;
            lst_AutosIngresados.ItemHeight = 21;
            lst_AutosIngresados.Location = new Point(258, 95);
            lst_AutosIngresados.Margin = new Padding(4);
            lst_AutosIngresados.Name = "lst_AutosIngresados";
            lst_AutosIngresados.ScrollAlwaysVisible = true;
            lst_AutosIngresados.Size = new Size(378, 319);
            lst_AutosIngresados.TabIndex = 8;
            lst_AutosIngresados.SelectedIndexChanged += lst_AutosIngresados_SelectedIndexChanged;
            // 
            // lbl_tituloLista
            // 
            lbl_tituloLista.AutoSize = true;
            lbl_tituloLista.Location = new Point(308, 51);
            lbl_tituloLista.Margin = new Padding(4, 0, 4, 0);
            lbl_tituloLista.Name = "lbl_tituloLista";
            lbl_tituloLista.Size = new Size(163, 21);
            lbl_tituloLista.TabIndex = 7;
            lbl_tituloLista.Text = "Listado de mis Autos";
            // 
            // FormularioAuto
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(649, 427);
            Controls.Add(lbl_tituloLista);
            Controls.Add(lst_AutosIngresados);
            Controls.Add(cmb_color);
            Controls.Add(txt_cantCombust);
            Controls.Add(txt_marca);
            Controls.Add(btn_Ok);
            Controls.Add(lbl_Color);
            Controls.Add(lbl_cantCombust);
            Controls.Add(lbl_marca);
            Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormularioAuto";
            Text = "Formulario Mi Auto";
            Load += FormularioAuto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_marca;
        private Label lbl_cantCombust;
        private Label lbl_Color;
        private Button btn_Ok;
        private TextBox txt_marca;
        private TextBox txt_cantCombust;
        private ComboBox cmb_color;
        private ListBox lst_AutosIngresados;
        private Label lbl_tituloLista;
    }
}

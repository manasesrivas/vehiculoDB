namespace vehiculoDB.Formularios.FormsPropietario
{
    partial class formInsertarPropietario
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
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            maskedTextBoxDui = new MaskedTextBox();
            maskedTextBoxTelefono = new MaskedTextBox();
            buttonAgregar = new Button();
            bottonCerrar = new Button();
            textBoxDireccion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(166, 53);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(187, 27);
            textBoxNombre.TabIndex = 0;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(164, 109);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(189, 27);
            textBoxApellido.TabIndex = 1;
            // 
            // maskedTextBoxDui
            // 
            maskedTextBoxDui.Location = new Point(164, 164);
            maskedTextBoxDui.Mask = "00000000-0";
            maskedTextBoxDui.Name = "maskedTextBoxDui";
            maskedTextBoxDui.Size = new Size(189, 27);
            maskedTextBoxDui.TabIndex = 2;
            // 
            // maskedTextBoxTelefono
            // 
            maskedTextBoxTelefono.Location = new Point(164, 211);
            maskedTextBoxTelefono.Mask = "0000-0000";
            maskedTextBoxTelefono.Name = "maskedTextBoxTelefono";
            maskedTextBoxTelefono.Size = new Size(189, 27);
            maskedTextBoxTelefono.TabIndex = 3;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(42, 353);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(135, 65);
            buttonAgregar.TabIndex = 4;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // bottonCerrar
            // 
            bottonCerrar.Location = new Point(272, 353);
            bottonCerrar.Name = "bottonCerrar";
            bottonCerrar.Size = new Size(118, 65);
            bottonCerrar.TabIndex = 5;
            bottonCerrar.Text = "Cerrar";
            bottonCerrar.UseVisualStyleBackColor = true;
            bottonCerrar.Click += bottonCerrar_Click;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(166, 269);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(187, 27);
            textBoxDireccion.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 60);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 7;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 116);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 171);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 9;
            label3.Text = "DUI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 214);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 10;
            label4.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 276);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 11;
            label5.Text = "Direccion:";
            // 
            // formInsertarPropietario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDireccion);
            Controls.Add(bottonCerrar);
            Controls.Add(buttonAgregar);
            Controls.Add(maskedTextBoxTelefono);
            Controls.Add(maskedTextBoxDui);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Name = "formInsertarPropietario";
            Text = "formInsertPropietario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private MaskedTextBox maskedTextBoxDui;
        private MaskedTextBox maskedTextBoxTelefono;
        private Button buttonAgregar;
        private Button bottonCerrar;
        private TextBox textBoxDireccion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
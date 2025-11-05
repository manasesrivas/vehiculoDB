namespace vehiculoDB.Formularios.FormsPropietario
{
    partial class formActualizarPropietario
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxDireccion = new TextBox();
            bottonCerrar = new Button();
            buttonAgregar = new Button();
            maskedTextBoxTelefono = new MaskedTextBox();
            maskedTextBoxDui = new MaskedTextBox();
            textBoxApellido = new TextBox();
            textBoxNombre = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 272);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 23;
            label5.Text = "Direccion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 210);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 22;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 167);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 21;
            label3.Text = "DUI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 112);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 20;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 56);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 19;
            label1.Text = "Nombre:";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(145, 265);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(187, 27);
            textBoxDireccion.TabIndex = 18;
            // 
            // bottonCerrar
            // 
            bottonCerrar.Location = new Point(251, 349);
            bottonCerrar.Name = "bottonCerrar";
            bottonCerrar.Size = new Size(118, 65);
            bottonCerrar.TabIndex = 17;
            bottonCerrar.Text = "Cerrar";
            bottonCerrar.UseVisualStyleBackColor = true;
            bottonCerrar.Click += bottonCerrar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(21, 349);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(135, 65);
            buttonAgregar.TabIndex = 16;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // maskedTextBoxTelefono
            // 
            maskedTextBoxTelefono.Location = new Point(143, 207);
            maskedTextBoxTelefono.Mask = "0000-0000";
            maskedTextBoxTelefono.Name = "maskedTextBoxTelefono";
            maskedTextBoxTelefono.Size = new Size(189, 27);
            maskedTextBoxTelefono.TabIndex = 15;
            // 
            // maskedTextBoxDui
            // 
            maskedTextBoxDui.Location = new Point(143, 160);
            maskedTextBoxDui.Mask = "00000000-0";
            maskedTextBoxDui.Name = "maskedTextBoxDui";
            maskedTextBoxDui.Size = new Size(189, 27);
            maskedTextBoxDui.TabIndex = 14;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(143, 105);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(189, 27);
            textBoxApellido.TabIndex = 13;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(145, 49);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(187, 27);
            textBoxNombre.TabIndex = 12;
            // 
            // formActualizarPropietario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 450);
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
            Name = "formActualizarPropietario";
            Text = "formActualizarPropietario";
            Load += formActualizarPropietario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxDireccion;
        private Button bottonCerrar;
        private Button buttonAgregar;
        private MaskedTextBox maskedTextBoxTelefono;
        private MaskedTextBox maskedTextBoxDui;
        private TextBox textBoxApellido;
        private TextBox textBoxNombre;
    }
}
namespace vehiculoDB
{
    partial class formVehiculo
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
            buttonPropietarios = new Button();
            SuspendLayout();
            // 
            // buttonPropietarios
            // 
            buttonPropietarios.Location = new Point(115, 120);
            buttonPropietarios.Name = "buttonPropietarios";
            buttonPropietarios.Size = new Size(94, 29);
            buttonPropietarios.TabIndex = 0;
            buttonPropietarios.Text = "Propietarios";
            buttonPropietarios.UseVisualStyleBackColor = true;
            buttonPropietarios.Click += buttonPropietarios_Click;
            // 
            // formVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPropietarios);
            Name = "formVehiculo";
            Text = "vehiculos";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPropietarios;
    }
}

namespace vehiculoDB.Formularios.FormPropietario
{
    partial class formPropietario
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
            dataGridViewPropietario = new DataGridView();
            buttonAgregar = new Button();
            buttonEditar = new Button();
            buttonCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPropietario).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPropietario
            // 
            dataGridViewPropietario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPropietario.Location = new Point(11, 12);
            dataGridViewPropietario.Name = "dataGridViewPropietario";
            dataGridViewPropietario.ReadOnly = true;
            dataGridViewPropietario.RowHeadersWidth = 51;
            dataGridViewPropietario.Size = new Size(1071, 426);
            dataGridViewPropietario.TabIndex = 0;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(1121, 34);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(130, 65);
            buttonAgregar.TabIndex = 1;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(1121, 160);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(125, 64);
            buttonEditar.TabIndex = 2;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Location = new Point(1121, 283);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(125, 64);
            buttonCerrar.TabIndex = 3;
            buttonCerrar.Text = "Cerrar";
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // formPropietario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 450);
            Controls.Add(buttonCerrar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonAgregar);
            Controls.Add(dataGridViewPropietario);
            Name = "formPropietario";
            Text = "Propietario";
            Load += formPropietario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPropietario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPropietario;
        private Button buttonAgregar;
        private Button buttonEditar;
        private Button buttonCerrar;
    }
}
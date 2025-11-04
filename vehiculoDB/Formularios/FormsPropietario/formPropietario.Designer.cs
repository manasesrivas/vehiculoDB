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
            button1 = new Button();
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
            dataGridViewPropietario.Size = new Size(1071, 335);
            dataGridViewPropietario.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(1121, 12);
            button1.Name = "button1";
            button1.Size = new Size(130, 62);
            button1.TabIndex = 1;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // formPropietario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 450);
            Controls.Add(button1);
            Controls.Add(dataGridViewPropietario);
            Name = "formPropietario";
            Text = "Propietario";
            Load += formPropietario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPropietario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPropietario;
        private Button button1;
    }
}
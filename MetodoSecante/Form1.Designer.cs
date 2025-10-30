namespace MetodoSecante
{
    partial class FormPrincipal
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
            lblFuncion = new Label();
            lbX0 = new Label();
            lbXI = new Label();
            lbError = new Label();
            txtFuncion = new TextBox();
            txtX0 = new TextBox();
            txtX1 = new TextBox();
            txtError = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            panel1 = new Panel();
            lblErrorFinal = new Label();
            lblRaiz = new Label();
            lblIteraciones = new Label();
            lblErrorFinalTitulo = new Label();
            lblRaizTitulo = new Label();
            lbIteración = new Label();
            dataIteracion = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataIteracion).BeginInit();
            SuspendLayout();
            // 
            // lblFuncion
            // 
            lblFuncion.AutoSize = true;
            lblFuncion.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuncion.Location = new Point(48, 55);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(97, 27);
            lblFuncion.TabIndex = 0;
            lblFuncion.Text = "Función:";
            // 
            // lbX0
            // 
            lbX0.AutoSize = true;
            lbX0.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbX0.Location = new Point(48, 107);
            lbX0.Name = "lbX0";
            lbX0.Size = new Size(44, 27);
            lbX0.TabIndex = 1;
            lbX0.Text = "X0:";
            // 
            // lbXI
            // 
            lbXI.AutoSize = true;
            lbXI.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbXI.Location = new Point(48, 159);
            lbXI.Name = "lbXI";
            lbXI.Size = new Size(44, 27);
            lbXI.TabIndex = 2;
            lbXI.Text = "X1:";
            // 
            // lbError
            // 
            lbError.AutoSize = true;
            lbError.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbError.Location = new Point(48, 210);
            lbError.Name = "lbError";
            lbError.Size = new Size(66, 27);
            lbError.TabIndex = 3;
            lbError.Text = "Error:";
            // 
            // txtFuncion
            // 
            txtFuncion.Location = new Point(179, 56);
            txtFuncion.Margin = new Padding(3, 4, 3, 4);
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(402, 27);
            txtFuncion.TabIndex = 4;
            // 
            // txtX0
            // 
            txtX0.Location = new Point(179, 108);
            txtX0.Margin = new Padding(3, 4, 3, 4);
            txtX0.Name = "txtX0";
            txtX0.Size = new Size(402, 27);
            txtX0.TabIndex = 5;
            // 
            // txtX1
            // 
            txtX1.Location = new Point(179, 160);
            txtX1.Margin = new Padding(3, 4, 3, 4);
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(402, 27);
            txtX1.TabIndex = 6;
            // 
            // txtError
            // 
            txtError.Location = new Point(179, 212);
            txtError.Margin = new Padding(3, 4, 3, 4);
            txtError.Name = "txtError";
            txtError.Size = new Size(402, 27);
            txtError.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(613, 55);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(137, 68);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(613, 144);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(137, 68);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblErrorFinal);
            panel1.Controls.Add(lblRaiz);
            panel1.Controls.Add(lblIteraciones);
            panel1.Controls.Add(lblErrorFinalTitulo);
            panel1.Controls.Add(lblRaizTitulo);
            panel1.Controls.Add(lbIteración);
            panel1.Location = new Point(48, 267);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 133);
            panel1.TabIndex = 10;
            // 
            // lblErrorFinal
            // 
            lblErrorFinal.AutoSize = true;
            lblErrorFinal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorFinal.Location = new Point(374, 84);
            lblErrorFinal.Name = "lblErrorFinal";
            lblErrorFinal.Size = new Size(50, 23);
            lblErrorFinal.TabIndex = 5;
            lblErrorFinal.Text = "0.000";
            // 
            // lblRaiz
            // 
            lblRaiz.AutoSize = true;
            lblRaiz.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRaiz.Location = new Point(374, 48);
            lblRaiz.Name = "lblRaiz";
            lblRaiz.Size = new Size(50, 23);
            lblRaiz.TabIndex = 4;
            lblRaiz.Text = "0.000";
            // 
            // lblIteraciones
            // 
            lblIteraciones.AutoSize = true;
            lblIteraciones.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIteraciones.Location = new Point(374, 12);
            lblIteraciones.Name = "lblIteraciones";
            lblIteraciones.Size = new Size(19, 23);
            lblIteraciones.TabIndex = 3;
            lblIteraciones.Text = "0";
            // 
            // lblErrorFinalTitulo
            // 
            lblErrorFinalTitulo.AutoSize = true;
            lblErrorFinalTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorFinalTitulo.Location = new Point(25, 84);
            lblErrorFinalTitulo.Name = "lblErrorFinalTitulo";
            lblErrorFinalTitulo.Size = new Size(98, 23);
            lblErrorFinalTitulo.TabIndex = 2;
            lblErrorFinalTitulo.Text = "Error Final:";
            // 
            // lblRaizTitulo
            // 
            lblRaizTitulo.AutoSize = true;
            lblRaizTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRaizTitulo.Location = new Point(25, 48);
            lblRaizTitulo.Name = "lblRaizTitulo";
            lblRaizTitulo.Size = new Size(48, 23);
            lblRaizTitulo.TabIndex = 1;
            lblRaizTitulo.Text = "Raíz:";
            // 
            // lbIteración
            // 
            lbIteración.AutoSize = true;
            lbIteración.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbIteración.Location = new Point(25, 12);
            lbIteración.Name = "lbIteración";
            lbIteración.Size = new Size(85, 23);
            lbIteración.TabIndex = 0;
            lbIteración.Text = "Iteración:";
            // 
            // dataIteracion
            // 
            dataIteracion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataIteracion.Location = new Point(48, 427);
            dataIteracion.Margin = new Padding(3, 4, 3, 4);
            dataIteracion.Name = "dataIteracion";
            dataIteracion.RowHeadersWidth = 51;
            dataIteracion.Size = new Size(900, 267);
            dataIteracion.TabIndex = 11;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1055, 733);
            Controls.Add(dataIteracion);
            Controls.Add(panel1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtError);
            Controls.Add(txtX1);
            Controls.Add(txtX0);
            Controls.Add(txtFuncion);
            Controls.Add(lbError);
            Controls.Add(lbXI);
            Controls.Add(lbX0);
            Controls.Add(lblFuncion);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPrincipal";
            Text = "Método de la Secante";
            Load += FormPrincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataIteracion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFuncion;
        private Label lbX0;
        private Label lbXI;
        private Label lbError;
        private TextBox txtFuncion;
        private TextBox txtX0;
        private TextBox txtX1;
        private TextBox txtError;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Panel panel1;
        private Label lblErrorFinal;
        private Label lblRaiz;
        private Label lblIteraciones;
        private Label lblErrorFinalTitulo;
        private Label lblRaizTitulo;
        private Label lbIteración;
        private DataGridView dataIteracion;
    }
}
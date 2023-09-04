namespace Notas
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            txtNota4 = new TextBox();
            btnCalcular = new Button();
            btnSalir = new Button();
            txtAlumno = new TextBox();
            lblPromedio = new Label();
            lblNotaBaja = new Label();
            lblValidacion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 47);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 0;
            label1.Text = "Alumno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(286, 47);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Nota 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(286, 107);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 2;
            label3.Text = "Nota 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(286, 168);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 3;
            label4.Text = "Nota 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(286, 233);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 4;
            label5.Text = "Nota 4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(42, 124);
            label6.Name = "label6";
            label6.Size = new Size(67, 17);
            label6.TabIndex = 5;
            label6.Text = "Promedio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(42, 168);
            label7.Name = "label7";
            label7.Size = new Size(67, 17);
            label7.TabIndex = 6;
            label7.Text = "Nota Baja";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(42, 212);
            label8.Name = "label8";
            label8.Size = new Size(68, 17);
            label8.TabIndex = 7;
            label8.Text = "Validacion";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(286, 65);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 23);
            txtNota1.TabIndex = 8;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(286, 125);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 23);
            txtNota2.TabIndex = 9;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(286, 186);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(100, 23);
            txtNota3.TabIndex = 10;
            // 
            // txtNota4
            // 
            txtNota4.Location = new Point(286, 251);
            txtNota4.Name = "txtNota4";
            txtNota4.Size = new Size(100, 23);
            txtNota4.TabIndex = 11;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCalcular.ForeColor = SystemColors.ControlText;
            btnCalcular.Location = new Point(34, 251);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 29);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSalir.Location = new Point(169, 251);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 29);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtAlumno
            // 
            txtAlumno.Location = new Point(42, 65);
            txtAlumno.Name = "txtAlumno";
            txtAlumno.Size = new Size(161, 23);
            txtAlumno.TabIndex = 14;
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblPromedio.Location = new Point(165, 124);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(74, 17);
            lblPromedio.TabIndex = 15;
            lblPromedio.Text = "lblPromedio";
            // 
            // lblNotaBaja
            // 
            lblNotaBaja.AutoSize = true;
            lblNotaBaja.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblNotaBaja.Location = new Point(165, 168);
            lblNotaBaja.Name = "lblNotaBaja";
            lblNotaBaja.Size = new Size(73, 17);
            lblNotaBaja.TabIndex = 16;
            lblNotaBaja.Text = "lblNotaBaja";
            // 
            // lblValidacion
            // 
            lblValidacion.AutoSize = true;
            lblValidacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblValidacion.Location = new Point(165, 212);
            lblValidacion.Name = "lblValidacion";
            lblValidacion.Size = new Size(79, 17);
            lblValidacion.TabIndex = 17;
            lblValidacion.Text = "lblValidacion";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 327);
            Controls.Add(lblValidacion);
            Controls.Add(lblNotaBaja);
            Controls.Add(lblPromedio);
            Controls.Add(txtAlumno);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(txtNota4);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtNota4;
        private Button btnCalcular;
        private Button btnSalir;
        private TextBox txtAlumno;
        private Label lblPromedio;
        private Label lblNotaBaja;
        private Label lblValidacion;
    }
}
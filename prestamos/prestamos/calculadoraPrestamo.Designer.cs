namespace prestamos
{
    partial class calculadoraPrestamo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculadoraPrestamo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.numeroCuotas = new System.Windows.Forms.NumericUpDown();
            this.tasaInteres = new System.Windows.Forms.TextBox();
            this.montoPrestamo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstCapitalRestante = new System.Windows.Forms.ListBox();
            this.lstCapitalPagado = new System.Windows.Forms.ListBox();
            this.lstMontoCuotas = new System.Windows.Forms.ListBox();
            this.lstInteresCuota = new System.Windows.Forms.ListBox();
            this.lstCapitalCuotas = new System.Windows.Forms.ListBox();
            this.lstNumeroCuotas = new System.Windows.Forms.ListBox();
            this.calcular = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.nodatapanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.startPage = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroCuotas)).BeginInit();
            this.panel2.SuspendLayout();
            this.nodatapanel.SuspendLayout();
            this.startPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.limpiar);
            this.panel1.Controls.Add(this.calcular);
            this.panel1.Controls.Add(this.numeroCuotas);
            this.panel1.Controls.Add(this.tasaInteres);
            this.panel1.Controls.Add(this.montoPrestamo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 177);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // numeroCuotas
            // 
            this.numeroCuotas.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroCuotas.Location = new System.Drawing.Point(549, 121);
            this.numeroCuotas.Margin = new System.Windows.Forms.Padding(20);
            this.numeroCuotas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeroCuotas.Name = "numeroCuotas";
            this.numeroCuotas.Size = new System.Drawing.Size(179, 33);
            this.numeroCuotas.TabIndex = 5;
            this.numeroCuotas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tasaInteres
            // 
            this.tasaInteres.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasaInteres.Location = new System.Drawing.Point(549, 77);
            this.tasaInteres.Margin = new System.Windows.Forms.Padding(20);
            this.tasaInteres.Name = "tasaInteres";
            this.tasaInteres.Size = new System.Drawing.Size(179, 33);
            this.tasaInteres.TabIndex = 4;
            this.tasaInteres.Text = "0";
            // 
            // montoPrestamo
            // 
            this.montoPrestamo.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoPrestamo.Location = new System.Drawing.Point(549, 32);
            this.montoPrestamo.Margin = new System.Windows.Forms.Padding(20);
            this.montoPrestamo.Name = "montoPrestamo";
            this.montoPrestamo.Size = new System.Drawing.Size(179, 33);
            this.montoPrestamo.TabIndex = 3;
            this.montoPrestamo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de Cuotas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tasa de interes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto del prestamo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.nodatapanel);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lstCapitalRestante);
            this.panel2.Controls.Add(this.lstCapitalPagado);
            this.panel2.Controls.Add(this.lstMontoCuotas);
            this.panel2.Controls.Add(this.lstInteresCuota);
            this.panel2.Controls.Add(this.lstCapitalCuotas);
            this.panel2.Controls.Add(this.lstNumeroCuotas);
            this.panel2.Location = new System.Drawing.Point(-1, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1233, 534);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1030, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 26);
            this.label9.TabIndex = 11;
            this.label9.Text = "Capital restante";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(811, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 26);
            this.label8.TabIndex = 10;
            this.label8.Text = "Capital pagado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(611, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "Monto cuotas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(411, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Interes cuota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(209, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Capital cuotas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(73, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cuotas°";
            // 
            // lstCapitalRestante
            // 
            this.lstCapitalRestante.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lstCapitalRestante.FormattingEnabled = true;
            this.lstCapitalRestante.ItemHeight = 21;
            this.lstCapitalRestante.Location = new System.Drawing.Point(1015, 62);
            this.lstCapitalRestante.Name = "lstCapitalRestante";
            this.lstCapitalRestante.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstCapitalRestante.Size = new System.Drawing.Size(183, 424);
            this.lstCapitalRestante.TabIndex = 5;
            // 
            // lstCapitalPagado
            // 
            this.lstCapitalPagado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lstCapitalPagado.FormattingEnabled = true;
            this.lstCapitalPagado.ItemHeight = 21;
            this.lstCapitalPagado.Location = new System.Drawing.Point(788, 62);
            this.lstCapitalPagado.Name = "lstCapitalPagado";
            this.lstCapitalPagado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstCapitalPagado.Size = new System.Drawing.Size(189, 424);
            this.lstCapitalPagado.TabIndex = 4;
            // 
            // lstMontoCuotas
            // 
            this.lstMontoCuotas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lstMontoCuotas.FormattingEnabled = true;
            this.lstMontoCuotas.ItemHeight = 21;
            this.lstMontoCuotas.Location = new System.Drawing.Point(580, 62);
            this.lstMontoCuotas.Name = "lstMontoCuotas";
            this.lstMontoCuotas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstMontoCuotas.Size = new System.Drawing.Size(179, 424);
            this.lstMontoCuotas.TabIndex = 3;
            // 
            // lstInteresCuota
            // 
            this.lstInteresCuota.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lstInteresCuota.FormattingEnabled = true;
            this.lstInteresCuota.ItemHeight = 21;
            this.lstInteresCuota.Location = new System.Drawing.Point(383, 62);
            this.lstInteresCuota.Name = "lstInteresCuota";
            this.lstInteresCuota.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstInteresCuota.Size = new System.Drawing.Size(176, 424);
            this.lstInteresCuota.TabIndex = 2;
            // 
            // lstCapitalCuotas
            // 
            this.lstCapitalCuotas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCapitalCuotas.FormattingEnabled = true;
            this.lstCapitalCuotas.ItemHeight = 21;
            this.lstCapitalCuotas.Location = new System.Drawing.Point(182, 62);
            this.lstCapitalCuotas.Name = "lstCapitalCuotas";
            this.lstCapitalCuotas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstCapitalCuotas.Size = new System.Drawing.Size(173, 424);
            this.lstCapitalCuotas.TabIndex = 1;
            // 
            // lstNumeroCuotas
            // 
            this.lstNumeroCuotas.BackColor = System.Drawing.Color.Gainsboro;
            this.lstNumeroCuotas.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstNumeroCuotas.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumeroCuotas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstNumeroCuotas.FormattingEnabled = true;
            this.lstNumeroCuotas.ItemHeight = 23;
            this.lstNumeroCuotas.Location = new System.Drawing.Point(78, 62);
            this.lstNumeroCuotas.Name = "lstNumeroCuotas";
            this.lstNumeroCuotas.Size = new System.Drawing.Size(71, 441);
            this.lstNumeroCuotas.TabIndex = 0;
            this.lstNumeroCuotas.SelectedIndexChanged += new System.EventHandler(this.lstNumeroCuotas_SelectedIndexChanged);
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.MidnightBlue;
            this.calcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.calcular.FlatAppearance.BorderSize = 2;
            this.calcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.calcular.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calcular.Location = new System.Drawing.Point(778, 32);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(129, 59);
            this.calcular.TabIndex = 6;
            this.calcular.Text = "CALCULAR";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.Gray;
            this.limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.limpiar.FlatAppearance.BorderSize = 2;
            this.limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.limpiar.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.limpiar.Location = new System.Drawing.Point(778, 95);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(129, 59);
            this.limpiar.TabIndex = 7;
            this.limpiar.Text = "LIMPIAR";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // nodatapanel
            // 
            this.nodatapanel.Controls.Add(this.label10);
            this.nodatapanel.Location = new System.Drawing.Point(1, 9);
            this.nodatapanel.Name = "nodatapanel";
            this.nodatapanel.Size = new System.Drawing.Size(1229, 542);
            this.nodatapanel.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label10.Location = new System.Drawing.Point(459, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(282, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "No hay datos a mostrar";
            // 
            // startPage
            // 
            this.startPage.BackColor = System.Drawing.Color.White;
            this.startPage.Controls.Add(this.label11);
            this.startPage.Controls.Add(this.button1);
            this.startPage.Controls.Add(this.panel4);
            this.startPage.Location = new System.Drawing.Point(2, -2);
            this.startPage.Name = "startPage";
            this.startPage.Size = new System.Drawing.Size(1228, 712);
            this.startPage.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(362, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(548, 40);
            this.label11.TabIndex = 2;
            this.label11.Text = "CALCULADORA DE PRESTAMOS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(428, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(427, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "EMPEZAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(513, 240);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 288);
            this.panel4.TabIndex = 0;
            // 
            // calculadoraPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1232, 708);
            this.Controls.Add(this.startPage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1254, 764);
            this.MinimumSize = new System.Drawing.Size(1254, 764);
            this.Name = "calculadoraPrestamo";
            this.Text = "Calculadora";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroCuotas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.nodatapanel.ResumeLayout(false);
            this.nodatapanel.PerformLayout();
            this.startPage.ResumeLayout(false);
            this.startPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numeroCuotas;
        private System.Windows.Forms.TextBox tasaInteres;
        private System.Windows.Forms.TextBox montoPrestamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstCapitalRestante;
        private System.Windows.Forms.ListBox lstCapitalPagado;
        private System.Windows.Forms.ListBox lstMontoCuotas;
        private System.Windows.Forms.ListBox lstInteresCuota;
        private System.Windows.Forms.ListBox lstCapitalCuotas;
        private System.Windows.Forms.ListBox lstNumeroCuotas;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Panel nodatapanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel startPage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
    }
}


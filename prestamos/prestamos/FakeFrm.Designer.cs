namespace prestamos
{
    partial class FakeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FakeFrm));
            this.startPage = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.startPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // startPage
            // 
            this.startPage.BackColor = System.Drawing.Color.White;
            this.startPage.Controls.Add(this.label11);
            this.startPage.Controls.Add(this.button1);
            this.startPage.Controls.Add(this.panel4);
            this.startPage.Location = new System.Drawing.Point(-214, -131);
            this.startPage.Name = "startPage";
            this.startPage.Size = new System.Drawing.Size(1228, 712);
            this.startPage.TabIndex = 17;
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
            // FakeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startPage);
            this.Name = "FakeFrm";
            this.Text = "FakeFrm";
            this.startPage.ResumeLayout(false);
            this.startPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel startPage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
    }
}
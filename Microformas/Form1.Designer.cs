namespace Microformas
{
    partial class Form1
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
            this.dtAdquisicion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaCobro = new System.Windows.Forms.Label();
            this.btnGrid = new System.Windows.Forms.Button();
            this.btnConsumir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtAdquisicion
            // 
            this.dtAdquisicion.CustomFormat = "";
            this.dtAdquisicion.Location = new System.Drawing.Point(108, 12);
            this.dtAdquisicion.Name = "dtAdquisicion";
            this.dtAdquisicion.Size = new System.Drawing.Size(200, 20);
            this.dtAdquisicion.TabIndex = 1;
            this.dtAdquisicion.ValueChanged += new System.EventHandler(this.dtAdquisicion_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha adquisición:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha cobro:";
            // 
            // txtFechaCobro
            // 
            this.txtFechaCobro.AutoSize = true;
            this.txtFechaCobro.Location = new System.Drawing.Point(105, 62);
            this.txtFechaCobro.Name = "txtFechaCobro";
            this.txtFechaCobro.Size = new System.Drawing.Size(0, 13);
            this.txtFechaCobro.TabIndex = 4;
            // 
            // btnGrid
            // 
            this.btnGrid.Location = new System.Drawing.Point(219, 128);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(96, 23);
            this.btnGrid.TabIndex = 5;
            this.btnGrid.Text = "Grid JSON";
            this.btnGrid.UseVisualStyleBackColor = true;
            this.btnGrid.Click += new System.EventHandler(this.btnGrid_Click);
            // 
            // btnConsumir
            // 
            this.btnConsumir.Location = new System.Drawing.Point(117, 128);
            this.btnConsumir.Name = "btnConsumir";
            this.btnConsumir.Size = new System.Drawing.Size(96, 23);
            this.btnConsumir.TabIndex = 6;
            this.btnConsumir.Text = "Consumir Api";
            this.btnConsumir.UseVisualStyleBackColor = true;
            this.btnConsumir.Click += new System.EventHandler(this.btnConsumir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 163);
            this.Controls.Add(this.btnConsumir);
            this.Controls.Add(this.btnGrid);
            this.Controls.Add(this.txtFechaCobro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtAdquisicion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtAdquisicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtFechaCobro;
        private System.Windows.Forms.Button btnGrid;
        private System.Windows.Forms.Button btnConsumir;
    }
}


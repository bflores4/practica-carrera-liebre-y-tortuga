namespace practica_carrera_liebre_y_tortuga
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.txtlaCarrera = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carrera entre la liebre y la tortuga";
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(216, 32);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(114, 51);
            this.btnComenzar.TabIndex = 1;
            this.btnComenzar.Text = "¡Comenzar carrera!";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // txtlaCarrera
            // 
            this.txtlaCarrera.Location = new System.Drawing.Point(12, 89);
            this.txtlaCarrera.Multiline = true;
            this.txtlaCarrera.Name = "txtlaCarrera";
            this.txtlaCarrera.ReadOnly = true;
            this.txtlaCarrera.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtlaCarrera.Size = new System.Drawing.Size(523, 287);
            this.txtlaCarrera.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 402);
            this.Controls.Add(this.txtlaCarrera);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1225F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.TextBox txtlaCarrera;
    }
}


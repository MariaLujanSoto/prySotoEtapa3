namespace prySotoEtapa3
{
    partial class frmEtapa3
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
            this.btnCrearAuto = new System.Windows.Forms.Button();
            this.btnCrearAvion = new System.Windows.Forms.Button();
            this.btnCrearBarco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearAuto
            // 
            this.btnCrearAuto.Location = new System.Drawing.Point(22, 584);
            this.btnCrearAuto.Name = "btnCrearAuto";
            this.btnCrearAuto.Size = new System.Drawing.Size(150, 38);
            this.btnCrearAuto.TabIndex = 0;
            this.btnCrearAuto.Text = "AUTO";
            this.btnCrearAuto.UseVisualStyleBackColor = true;
            this.btnCrearAuto.Click += new System.EventHandler(this.btnCrearAuto_Click);
            // 
            // btnCrearAvion
            // 
            this.btnCrearAvion.Location = new System.Drawing.Point(235, 584);
            this.btnCrearAvion.Name = "btnCrearAvion";
            this.btnCrearAvion.Size = new System.Drawing.Size(150, 38);
            this.btnCrearAvion.TabIndex = 1;
            this.btnCrearAvion.Text = "AVION";
            this.btnCrearAvion.UseVisualStyleBackColor = true;
            this.btnCrearAvion.Click += new System.EventHandler(this.btnCrearAvion_Click);
            // 
            // btnCrearBarco
            // 
            this.btnCrearBarco.Location = new System.Drawing.Point(446, 584);
            this.btnCrearBarco.Name = "btnCrearBarco";
            this.btnCrearBarco.Size = new System.Drawing.Size(150, 38);
            this.btnCrearBarco.TabIndex = 2;
            this.btnCrearBarco.Text = "AUTO";
            this.btnCrearBarco.UseVisualStyleBackColor = true;
            this.btnCrearBarco.Click += new System.EventHandler(this.btnCrearBarco_Click);
            // 
            // frmEtapa3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prySotoEtapa3.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 649);
            this.Controls.Add(this.btnCrearBarco);
            this.Controls.Add(this.btnCrearAvion);
            this.Controls.Add(this.btnCrearAuto);
            this.Name = "frmEtapa3";
            this.Text = "Etapa 3  : Crear Obetos Por Boton";
            this.Load += new System.EventHandler(this.frmEtapa3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearAuto;
        private System.Windows.Forms.Button btnCrearAvion;
        private System.Windows.Forms.Button btnCrearBarco;
    }
}


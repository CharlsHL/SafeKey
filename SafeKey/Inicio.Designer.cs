namespace SafeKey
{
    partial class Inicio
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
            this.btIngresar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btIngresar
            // 
            this.btIngresar.Location = new System.Drawing.Point(50, 208);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(99, 30);
            this.btIngresar.TabIndex = 0;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(197, 208);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(99, 30);
            this.btSalir.TabIndex = 1;
            this.btSalir.Text = "&Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(50, 66);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(246, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(50, 134);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(246, 20);
            this.txtContraseña.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.btIngresar);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.btSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 277);
            this.panel1.TabIndex = 4;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 277);
            this.Controls.Add(this.panel1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Panel panel1;
    }
}


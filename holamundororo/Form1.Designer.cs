namespace holamundororo
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
            this.pepe1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pepe1
            // 
            this.pepe1.AutoSize = true;
            this.pepe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pepe1.Location = new System.Drawing.Point(366, 199);
            this.pepe1.Name = "pepe1";
            this.pepe1.Size = new System.Drawing.Size(164, 31);
            this.pepe1.TabIndex = 0;
            this.pepe1.Text = "hola mundo";
            this.pepe1.Click += new System.EventHandler(this.pepe1_Click);
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.ForeColor = System.Drawing.Color.Red;
            this.l2.Location = new System.Drawing.Point(391, 165);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(0, 31);
            this.l2.TabIndex = 1;
            this.l2.Click += new System.EventHandler(this.l2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.pepe1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pepe1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Button button1;
    }
}


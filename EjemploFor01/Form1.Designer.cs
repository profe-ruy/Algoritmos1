
namespace EjemploFor01
{
    partial class Form1
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
            this.btnProcesar1 = new System.Windows.Forms.Button();
            this.btnProcesar2 = new System.Windows.Forms.Button();
            this.btnProcesar3 = new System.Windows.Forms.Button();
            this.btnProcesar4 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcesar1
            // 
            this.btnProcesar1.Location = new System.Drawing.Point(72, 23);
            this.btnProcesar1.Name = "btnProcesar1";
            this.btnProcesar1.Size = new System.Drawing.Size(140, 23);
            this.btnProcesar1.TabIndex = 0;
            this.btnProcesar1.Text = "Numeros del 1-50";
            this.btnProcesar1.UseVisualStyleBackColor = true;
            this.btnProcesar1.Click += new System.EventHandler(this.btnProcesar1_Click);
            // 
            // btnProcesar2
            // 
            this.btnProcesar2.Location = new System.Drawing.Point(72, 68);
            this.btnProcesar2.Name = "btnProcesar2";
            this.btnProcesar2.Size = new System.Drawing.Size(140, 23);
            this.btnProcesar2.TabIndex = 1;
            this.btnProcesar2.Text = "Numeros del 100-10";
            this.btnProcesar2.UseVisualStyleBackColor = true;
            this.btnProcesar2.Click += new System.EventHandler(this.btnProcesar2_Click);
            // 
            // btnProcesar3
            // 
            this.btnProcesar3.Location = new System.Drawing.Point(72, 112);
            this.btnProcesar3.Name = "btnProcesar3";
            this.btnProcesar3.Size = new System.Drawing.Size(140, 23);
            this.btnProcesar3.TabIndex = 2;
            this.btnProcesar3.Text = "Numeros del 1-100 Pares";
            this.btnProcesar3.UseVisualStyleBackColor = true;
            this.btnProcesar3.Click += new System.EventHandler(this.btnProcesar3_Click);
            // 
            // btnProcesar4
            // 
            this.btnProcesar4.Location = new System.Drawing.Point(72, 164);
            this.btnProcesar4.Name = "btnProcesar4";
            this.btnProcesar4.Size = new System.Drawing.Size(140, 23);
            this.btnProcesar4.TabIndex = 3;
            this.btnProcesar4.Text = "100 -97 - 94 ...";
            this.btnProcesar4.UseVisualStyleBackColor = true;
            this.btnProcesar4.Click += new System.EventHandler(this.btnProcesar4_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(252, 25);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(279, 381);
            this.txtResultado.TabIndex = 4;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(72, 321);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(140, 23);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnProcesar4);
            this.Controls.Add(this.btnProcesar3);
            this.Controls.Add(this.btnProcesar2);
            this.Controls.Add(this.btnProcesar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcesar1;
        private System.Windows.Forms.Button btnProcesar2;
        private System.Windows.Forms.Button btnProcesar3;
        private System.Windows.Forms.Button btnProcesar4;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnBorrar;
    }
}


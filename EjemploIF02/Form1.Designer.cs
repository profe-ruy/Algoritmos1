
namespace EjemploIF02
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
            this.txtCondicion2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCondicionUno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCondicion2
            // 
            this.txtCondicion2.Location = new System.Drawing.Point(144, 65);
            this.txtCondicion2.Name = "txtCondicion2";
            this.txtCondicion2.Size = new System.Drawing.Size(100, 20);
            this.txtCondicion2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Condicion2";
            // 
            // txtCondicionUno
            // 
            this.txtCondicionUno.Location = new System.Drawing.Point(144, 23);
            this.txtCondicionUno.Name = "txtCondicionUno";
            this.txtCondicionUno.Size = new System.Drawing.Size(100, 20);
            this.txtCondicionUno.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Condicion1";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(55, 157);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(227, 261);
            this.txtResultado.TabIndex = 7;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(132, 108);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 6;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 450);
            this.Controls.Add(this.txtCondicion2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCondicionUno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnProcesar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCondicion2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCondicionUno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnProcesar;
    }
}


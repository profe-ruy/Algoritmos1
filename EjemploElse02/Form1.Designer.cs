
namespace EjemploElse02
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatematica = new System.Windows.Forms.TextBox();
            this.txtFisica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHistoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matematica";
            // 
            // txtMatematica
            // 
            this.txtMatematica.Location = new System.Drawing.Point(234, 21);
            this.txtMatematica.Name = "txtMatematica";
            this.txtMatematica.Size = new System.Drawing.Size(100, 20);
            this.txtMatematica.TabIndex = 1;
            // 
            // txtFisica
            // 
            this.txtFisica.Location = new System.Drawing.Point(234, 61);
            this.txtFisica.Name = "txtFisica";
            this.txtFisica.Size = new System.Drawing.Size(100, 20);
            this.txtFisica.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fisica";
            // 
            // txtHistoria
            // 
            this.txtHistoria.Location = new System.Drawing.Point(234, 110);
            this.txtHistoria.Name = "txtHistoria";
            this.txtHistoria.Size = new System.Drawing.Size(100, 20);
            this.txtHistoria.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Historia";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(151, 160);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(183, 23);
            this.btnProcesar.TabIndex = 6;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(151, 202);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(183, 161);
            this.txtResultado.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtHistoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFisica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatematica);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatematica;
        private System.Windows.Forms.TextBox txtFisica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHistoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtResultado;
    }
}


﻿
namespace Ejemplo05
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
            this.txtMetros = new System.Windows.Forms.TextBox();
            this.txtYardas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPies = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metros";
            // 
            // txtMetros
            // 
            this.txtMetros.Location = new System.Drawing.Point(189, 39);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Size = new System.Drawing.Size(100, 20);
            this.txtMetros.TabIndex = 1;
            // 
            // txtYardas
            // 
            this.txtYardas.Location = new System.Drawing.Point(189, 133);
            this.txtYardas.Name = "txtYardas";
            this.txtYardas.Size = new System.Drawing.Size(100, 20);
            this.txtYardas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yardas";
            // 
            // txtPies
            // 
            this.txtPies.Location = new System.Drawing.Point(189, 188);
            this.txtPies.Name = "txtPies";
            this.txtPies.Size = new System.Drawing.Size(100, 20);
            this.txtPies.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pies";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(112, 84);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(177, 23);
            this.btnProcesar.TabIndex = 6;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 287);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtPies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYardas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMetros);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMetros;
        private System.Windows.Forms.TextBox txtYardas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProcesar;
    }
}


﻿
namespace Repaso_2dobloqueSA
{
    partial class NumAleatorio
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
            this.label2 = new System.Windows.Forms.Label();
            this.numMax = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un numero superior para \r\ngenerar un numeor aleatorio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(60, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "1 a ";
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(98, 64);
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(100, 20);
            this.numMax.TabIndex = 2;
            this.numMax.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Button
            // 
            this.Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Button.Location = new System.Drawing.Point(29, 90);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(193, 35);
            this.Button.TabIndex = 3;
            this.Button.Text = "Generar";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.txtNumMax_Click);
            // 
            // NumAleatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 153);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.numMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NumAleatorio";
            this.Text = "NumAleatorio";
            this.Load += new System.EventHandler(this.NumAleatorio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numMax;
        private System.Windows.Forms.Button Button;
    }
}
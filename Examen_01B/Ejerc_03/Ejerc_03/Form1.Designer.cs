﻿namespace Ejerc_03
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idTxtComplejo1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.idTxtImag1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTxtReal1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idTxtComplejo2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.idTxtImag2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idTxtReal2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.idTxtSuma = new System.Windows.Forms.TextBox();
            this.idTxtProducto = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idTxtComplejo1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.idTxtImag1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.idTxtReal1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NÚMERO 1";
            // 
            // idTxtComplejo1
            // 
            this.idTxtComplejo1.Location = new System.Drawing.Point(50, 383);
            this.idTxtComplejo1.Name = "idTxtComplejo1";
            this.idTxtComplejo1.Size = new System.Drawing.Size(145, 28);
            this.idTxtComplejo1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "NÚMERO COMPLEJO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "MOSTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idTxtImag1
            // 
            this.idTxtImag1.Location = new System.Drawing.Point(50, 182);
            this.idTxtImag1.Name = "idTxtImag1";
            this.idTxtImag1.Size = new System.Drawing.Size(116, 28);
            this.idTxtImag1.TabIndex = 3;
            this.idTxtImag1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTxtImag1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "PARTE IMAGINARIA";
            // 
            // idTxtReal1
            // 
            this.idTxtReal1.Location = new System.Drawing.Point(50, 85);
            this.idTxtReal1.Name = "idTxtReal1";
            this.idTxtReal1.Size = new System.Drawing.Size(116, 28);
            this.idTxtReal1.TabIndex = 1;
            this.idTxtReal1.TextChanged += new System.EventHandler(this.idTxtReal1_TextChanged);
            this.idTxtReal1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTxtReal1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARTE REAL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.idTxtComplejo2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.idTxtImag2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.idTxtReal2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(425, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 426);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NÚMERO 2";
            // 
            // idTxtComplejo2
            // 
            this.idTxtComplejo2.Location = new System.Drawing.Point(50, 383);
            this.idTxtComplejo2.Name = "idTxtComplejo2";
            this.idTxtComplejo2.Size = new System.Drawing.Size(145, 28);
            this.idTxtComplejo2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "NÚMERO COMPLEJO";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "MOSTRAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idTxtImag2
            // 
            this.idTxtImag2.Location = new System.Drawing.Point(50, 182);
            this.idTxtImag2.Name = "idTxtImag2";
            this.idTxtImag2.Size = new System.Drawing.Size(116, 28);
            this.idTxtImag2.TabIndex = 3;
            this.idTxtImag2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTxtImag2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "PARTE IMAGINARIA";
            // 
            // idTxtReal2
            // 
            this.idTxtReal2.Location = new System.Drawing.Point(50, 85);
            this.idTxtReal2.Name = "idTxtReal2";
            this.idTxtReal2.Size = new System.Drawing.Size(116, 28);
            this.idTxtReal2.TabIndex = 1;
            this.idTxtReal2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTxtReal2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "PARTE REAL";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(835, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 31);
            this.button3.TabIndex = 8;
            this.button3.Text = "SUMA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idTxtSuma
            // 
            this.idTxtSuma.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtSuma.Location = new System.Drawing.Point(835, 128);
            this.idTxtSuma.Name = "idTxtSuma";
            this.idTxtSuma.Size = new System.Drawing.Size(208, 28);
            this.idTxtSuma.TabIndex = 7;
            // 
            // idTxtProducto
            // 
            this.idTxtProducto.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtProducto.Location = new System.Drawing.Point(835, 259);
            this.idTxtProducto.Name = "idTxtProducto";
            this.idTxtProducto.Size = new System.Drawing.Size(208, 28);
            this.idTxtProducto.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(835, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 33);
            this.button4.TabIndex = 10;
            this.button4.Text = "PRODUCTO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1106, 471);
            this.Controls.Add(this.idTxtProducto);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.idTxtSuma);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NÚMEROS COMPLEJOS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idTxtComplejo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idTxtImag1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTxtReal1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox idTxtComplejo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox idTxtImag2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idTxtReal2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox idTxtSuma;
        private System.Windows.Forms.TextBox idTxtProducto;
        private System.Windows.Forms.Button button4;
    }
}


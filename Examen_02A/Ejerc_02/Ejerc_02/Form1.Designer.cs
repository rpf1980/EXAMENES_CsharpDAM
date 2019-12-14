namespace Ejerc_02
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
            this.idTxtRuta = new System.Windows.Forms.TextBox();
            this.idBtnExplorar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idTxtNombre = new System.Windows.Forms.TextBox();
            this.idTxtFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idTxtTama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "RUTA:";
            // 
            // idTxtRuta
            // 
            this.idTxtRuta.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtRuta.Location = new System.Drawing.Point(179, 55);
            this.idTxtRuta.Name = "idTxtRuta";
            this.idTxtRuta.Size = new System.Drawing.Size(534, 28);
            this.idTxtRuta.TabIndex = 1;
            // 
            // idBtnExplorar
            // 
            this.idBtnExplorar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnExplorar.Location = new System.Drawing.Point(365, 107);
            this.idBtnExplorar.Name = "idBtnExplorar";
            this.idBtnExplorar.Size = new System.Drawing.Size(153, 32);
            this.idBtnExplorar.TabIndex = 2;
            this.idBtnExplorar.Text = "EXPLORAR";
            this.idBtnExplorar.UseVisualStyleBackColor = true;
            this.idBtnExplorar.Click += new System.EventHandler(this.idBtnExplorar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "FICHEROS";
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(179, 223);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(304, 202);
            this.richTextBox.TabIndex = 4;
            this.richTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(550, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "NOMBRE COMPLETO";
            // 
            // idTxtNombre
            // 
            this.idTxtNombre.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtNombre.Location = new System.Drawing.Point(553, 223);
            this.idTxtNombre.Name = "idTxtNombre";
            this.idTxtNombre.Size = new System.Drawing.Size(204, 28);
            this.idTxtNombre.TabIndex = 6;
            // 
            // idTxtFecha
            // 
            this.idTxtFecha.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtFecha.Location = new System.Drawing.Point(553, 299);
            this.idTxtFecha.Name = "idTxtFecha";
            this.idTxtFecha.Size = new System.Drawing.Size(204, 28);
            this.idTxtFecha.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(550, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "FECHA DEL ÚLTIMO ACCESO";
            // 
            // idTxtTama
            // 
            this.idTxtTama.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtTama.Location = new System.Drawing.Point(553, 386);
            this.idTxtTama.Name = "idTxtTama";
            this.idTxtTama.Size = new System.Drawing.Size(204, 28);
            this.idTxtTama.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(550, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "TAMAÑO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(885, 479);
            this.Controls.Add(this.idTxtTama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idTxtFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idTxtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idBtnExplorar);
            this.Controls.Add(this.idTxtRuta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EJERCICIO 2 - OPCIÓN A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTxtRuta;
        private System.Windows.Forms.Button idBtnExplorar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTxtNombre;
        private System.Windows.Forms.TextBox idTxtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idTxtTama;
        private System.Windows.Forms.Label label5;
    }
}


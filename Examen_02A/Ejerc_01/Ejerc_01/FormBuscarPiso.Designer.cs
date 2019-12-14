namespace Ejerc_01
{
    partial class FormBuscarPiso
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
            this.checkPrecio = new System.Windows.Forms.CheckBox();
            this.checkOrientacion = new System.Windows.Forms.CheckBox();
            this.checkSuperficie = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTxtCriterio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkPrecio);
            this.groupBox1.Controls.Add(this.checkOrientacion);
            this.groupBox1.Controls.Add(this.checkSuperficie);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(72, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRITERIO DE BÚSQUEDA";
            // 
            // checkPrecio
            // 
            this.checkPrecio.AutoSize = true;
            this.checkPrecio.Location = new System.Drawing.Point(26, 125);
            this.checkPrecio.Name = "checkPrecio";
            this.checkPrecio.Size = new System.Drawing.Size(82, 24);
            this.checkPrecio.TabIndex = 2;
            this.checkPrecio.Text = "Precio";
            this.checkPrecio.UseVisualStyleBackColor = true;
            // 
            // checkOrientacion
            // 
            this.checkOrientacion.AutoSize = true;
            this.checkOrientacion.Location = new System.Drawing.Point(26, 80);
            this.checkOrientacion.Name = "checkOrientacion";
            this.checkOrientacion.Size = new System.Drawing.Size(129, 24);
            this.checkOrientacion.TabIndex = 1;
            this.checkOrientacion.Text = "Orientación";
            this.checkOrientacion.UseVisualStyleBackColor = true;
            // 
            // checkSuperficie
            // 
            this.checkSuperficie.AutoSize = true;
            this.checkSuperficie.Location = new System.Drawing.Point(26, 40);
            this.checkSuperficie.Name = "checkSuperficie";
            this.checkSuperficie.Size = new System.Drawing.Size(117, 24);
            this.checkSuperficie.TabIndex = 0;
            this.checkSuperficie.Text = "Superficie";
            this.checkSuperficie.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "RESULTADO";
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(72, 332);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(711, 131);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor para el criterio";
            // 
            // idTxtCriterio
            // 
            this.idTxtCriterio.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtCriterio.Location = new System.Drawing.Point(433, 125);
            this.idTxtCriterio.Name = "idTxtCriterio";
            this.idTxtCriterio.Size = new System.Drawing.Size(276, 28);
            this.idTxtCriterio.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(433, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBuscarPiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idTxtCriterio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarPiso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR PISO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkPrecio;
        private System.Windows.Forms.CheckBox checkOrientacion;
        private System.Windows.Forms.CheckBox checkSuperficie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTxtCriterio;
        private System.Windows.Forms.Button button1;
    }
}


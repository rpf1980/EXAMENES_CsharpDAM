namespace Ejerc_01
{
    partial class FormAddPiso
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
            this.idTxtID = new System.Windows.Forms.TextBox();
            this.idTxtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTxtSuperf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idTxtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // idTxtID
            // 
            this.idTxtID.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtID.Location = new System.Drawing.Point(282, 78);
            this.idTxtID.Name = "idTxtID";
            this.idTxtID.Size = new System.Drawing.Size(58, 28);
            this.idTxtID.TabIndex = 1;
            this.idTxtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTxtID_KeyPress);
            // 
            // idTxtDireccion
            // 
            this.idTxtDireccion.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtDireccion.Location = new System.Drawing.Point(282, 129);
            this.idTxtDireccion.Name = "idTxtDireccion";
            this.idTxtDireccion.Size = new System.Drawing.Size(436, 28);
            this.idTxtDireccion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "DIRECCIÓN: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "ORIENTACIÓN:";
            // 
            // idTxtSuperf
            // 
            this.idTxtSuperf.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtSuperf.Location = new System.Drawing.Point(282, 177);
            this.idTxtSuperf.Name = "idTxtSuperf";
            this.idTxtSuperf.Size = new System.Drawing.Size(128, 28);
            this.idTxtSuperf.TabIndex = 7;
            this.idTxtSuperf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTxtSuperf_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "SUPERFICIE:";
            // 
            // idTxtPrecio
            // 
            this.idTxtPrecio.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtPrecio.Location = new System.Drawing.Point(282, 277);
            this.idTxtPrecio.Name = "idTxtPrecio";
            this.idTxtPrecio.Size = new System.Drawing.Size(128, 28);
            this.idTxtPrecio.TabIndex = 11;
            this.idTxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTxtPrecio_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "PRECIO:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(318, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 53);
            this.button1.TabIndex = 12;
            this.button1.Text = "LIMPIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(51, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 53);
            this.button2.TabIndex = 13;
            this.button2.Text = "AÑADIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(577, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 53);
            this.button3.TabIndex = 14;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idComboBox
            // 
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Items.AddRange(new object[] {
            "Norte",
            "Sur",
            "Este",
            "Oeste"});
            this.idComboBox.Location = new System.Drawing.Point(282, 230);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(128, 24);
            this.idComboBox.TabIndex = 15;
            // 
            // FormAddPiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(802, 469);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idTxtPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTxtSuperf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idTxtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idTxtID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddPiso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AÑADIR PISO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTxtID;
        private System.Windows.Forms.TextBox idTxtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTxtSuperf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idTxtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox idComboBox;
    }
}
namespace Laboratorio_12_2
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
            this.buttonCalcular_Click = new System.Windows.Forms.Button();
            this.buttonLimpiar_Click = new System.Windows.Forms.Button();
            this.buttonSalir_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPromedio = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCalcular_Click
            // 
            this.buttonCalcular_Click.Location = new System.Drawing.Point(128, 256);
            this.buttonCalcular_Click.Name = "buttonCalcular_Click";
            this.buttonCalcular_Click.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular_Click.TabIndex = 0;
            this.buttonCalcular_Click.Text = "button1";
            this.buttonCalcular_Click.UseVisualStyleBackColor = true;
            this.buttonCalcular_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLimpiar_Click
            // 
            this.buttonLimpiar_Click.Location = new System.Drawing.Point(305, 256);
            this.buttonLimpiar_Click.Name = "buttonLimpiar_Click";
            this.buttonLimpiar_Click.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar_Click.TabIndex = 1;
            this.buttonLimpiar_Click.Text = "button2";
            this.buttonLimpiar_Click.UseVisualStyleBackColor = true;
            this.buttonLimpiar_Click.Click += new System.EventHandler(this.buttonLimpiar_Click_Click);
            // 
            // buttonSalir_Click
            // 
            this.buttonSalir_Click.Location = new System.Drawing.Point(509, 255);
            this.buttonSalir_Click.Name = "buttonSalir_Click";
            this.buttonSalir_Click.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir_Click.TabIndex = 2;
            this.buttonSalir_Click.Text = "button3";
            this.buttonSalir_Click.UseVisualStyleBackColor = true;
            this.buttonSalir_Click.Click += new System.EventHandler(this.buttonSalir_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // labelPromedio
            // 
            this.labelPromedio.Location = new System.Drawing.Point(525, 60);
            this.labelPromedio.Name = "labelPromedio";
            this.labelPromedio.Size = new System.Drawing.Size(100, 22);
            this.labelPromedio.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(525, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(525, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(525, 359);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelPromedio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSalir_Click);
            this.Controls.Add(this.buttonLimpiar_Click);
            this.Controls.Add(this.buttonCalcular_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalcular_Click;
        private System.Windows.Forms.Button buttonLimpiar_Click;
        private System.Windows.Forms.Button buttonSalir_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox labelPromedio;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}


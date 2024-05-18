namespace Unidad3
{
    partial class Form3
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
            label1 = new Label();
            label6 = new Label();
            textBox6 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(96, 26);
            label1.Name = "label1";
            label1.Size = new Size(213, 32);
            label1.TabIndex = 0;
            label1.Text = "Detalle de llamada";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(237, 89);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 27;
            label6.Text = "Hora de inicio";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(244, 127);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(135, 23);
            textBox6.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(23, 182);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 25;
            label5.Text = "Hora de fin";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(30, 220);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(135, 23);
            textBox5.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(23, 283);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 23;
            label4.Text = "Compañia";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(30, 321);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(135, 23);
            textBox4.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(237, 182);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 21;
            label3.Text = "Duracion";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(244, 220);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(135, 23);
            textBox3.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(237, 283);
            label2.Name = "label2";
            label2.Size = new Size(182, 25);
            label2.TabIndex = 19;
            label2.Text = "Numero de telefono";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(244, 321);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 23);
            textBox2.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(23, 89);
            label7.Name = "label7";
            label7.Size = new Size(61, 25);
            label7.TabIndex = 17;
            label7.Text = "Fecha";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 16;
            // 
            // button2
            // 
            button2.Location = new Point(295, 364);
            button2.Name = "button2";
            button2.Size = new Size(102, 35);
            button2.TabIndex = 28;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 411);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label6;
        private TextBox textBox6;
        private Label label5;
        private TextBox textBox5;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox1;
        private Button button2;
    }
}
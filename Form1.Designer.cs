namespace Prueba16Nov
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(630, 301);
            button1.Name = "button1";
            button1.Size = new Size(158, 29);
            button1.TabIndex = 0;
            button1.Text = "Ejecutar algoritmo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 44);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 2;
            label1.Text = "Límite Inferior";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 229);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(612, 216);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 89);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 5;
            label2.Text = "Límite Superior";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(660, 347);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Descarga";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 136);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 10;
            label3.Text = "# Páneles";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(167, 133);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 181);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 8;
            label4.Text = "# Experimentos";
            label4.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(167, 178);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(449, 69);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 12;
            label5.Text = "Estimación Media";
            label5.Click += label5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(600, 66);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 11;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(449, 136);
            label6.Name = "label6";
            label6.Size = new Size(142, 20);
            label6.TabIndex = 14;
            label6.Text = "Desviación Estándar";
            label6.Click += label6_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(600, 133);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 13;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBox2;
        private Button button2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
    }
}

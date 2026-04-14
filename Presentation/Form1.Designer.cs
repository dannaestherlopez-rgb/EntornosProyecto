namespace Presentation
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            btnAgregar = new Button();
            dtpFecha = new DateTimePicker();
            label4 = new Label();
            btnAgregarFecha = new Button();
            cmbBoxFechas = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(334, 269);
            button1.Name = "button1";
            button1.Size = new Size(125, 23);
            button1.TabIndex = 0;
            button1.Text = "Cambiar Color";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 220);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Rojo";
            // 
            // button2
            // 
            button2.Location = new Point(509, 269);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" });
            comboBox1.Location = new Point(475, 132);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 135);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(475, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 42);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 6;
            label3.Text = "Elemento a Agregar";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(598, 75);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(111, 73);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 8;
            dtpFecha.CloseUp += dtpFecha_CloseUp;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 42);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 9;
            label4.Text = "Agregue su Fecha";
            // 
            // btnAgregarFecha
            // 
            btnAgregarFecha.Location = new Point(331, 73);
            btnAgregarFecha.Name = "btnAgregarFecha";
            btnAgregarFecha.Size = new Size(104, 23);
            btnAgregarFecha.TabIndex = 10;
            btnAgregarFecha.Text = "Agregar Fecha";
            btnAgregarFecha.UseVisualStyleBackColor = true;
            btnAgregarFecha.Click += btnAgregarFecha_Click;
            // 
            // cmbBoxFechas
            // 
            cmbBoxFechas.FormattingEnabled = true;
            cmbBoxFechas.Location = new Point(111, 127);
            cmbBoxFechas.Name = "cmbBoxFechas";
            cmbBoxFechas.Size = new Size(121, 23);
            cmbBoxFechas.TabIndex = 11;
            cmbBoxFechas.TextChanged += cmbBoxFechas_TextChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 201);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 12;
            label5.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(cmbBoxFechas);
            Controls.Add(btnAgregarFecha);
            Controls.Add(label4);
            Controls.Add(dtpFecha);
            Controls.Add(btnAgregar);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button btnAgregar;
        private DateTimePicker dtpFecha;
        private Label label4;
        private Button btnAgregarFecha;
        private ComboBox cmbBoxFechas;
        private System.Windows.Forms.Timer timer1;
        private Label label5;
    }
}

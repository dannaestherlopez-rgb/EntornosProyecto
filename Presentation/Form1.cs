namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Rojo")
            {
                label1.Text = "Verde";
                label1.BackColor = Color.Green;
            }
            else
            {
                label1.Text = "Rojo";
                label1.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(74, 247, 146);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Rojo";
            label1.BackColor = Color.FromArgb(74, 247, 146);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox1.SelectedItem.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void btnAgregarFecha_Click(object sender, EventArgs e)
        {
            cmbBoxFechas.Items.Add(dtpFecha.Text);
        }

        private void cmbBoxFechas_TextChanged(object sender, EventArgs e)
        {
            cmbBoxFechas.Items.Add(dtpFecha.Text);
        }

        private void dtpFecha_CloseUp(object sender, EventArgs e)
        {
            cmbBoxFechas.Items.Add(dtpFecha.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = "valor del intervalo " + timer1.Interval;
        }
    }
}

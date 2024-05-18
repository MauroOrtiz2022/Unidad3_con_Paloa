namespace Unidad3
{
    public partial class Form1 : Form
    {
        public string numtelefono;
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            numtelefono = textBox1.Text;
            // Crear una instancia 
            Form2 form2 = new Form2();
            form2.ReceivedData = textBox1.Text;
            // Mostrar la instancia
            form2.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            // Obtener el texto del TextBox
            string text = textBox1.Text;
            // Verificar si el texto contiene alguna letra
            if (text.Any(char.IsLetter))
            {
                // Limpiar el TextBox si contiene una letra
                textBox1.Clear();
                label2.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

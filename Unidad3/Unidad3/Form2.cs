using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Unidad3
{
    public partial class Form2 : Form
    {
        public string ReceivedData { get; set; }
        public string numtelefono = "";
        public Form2()
        {
            InitializeComponent();
            dataGridView1.DataSource = productos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            numtelefono = ReceivedData;
            // Crear una instancia 
            Form3 form3 = new Form3();
            // Mostrar la instancia
            form3.Show();
            this.Hide();
        }
        public class Producto
        {
            public string Fecha { get; set; }
            public string Inicio_hora { get; set; }
            public string Fin_hora { get; set; }
            public string Duracion { get; set; }
            public string Compañia { get; set; }
            public string Telefono { get; set; }
        }
        List<Producto> productos = new List<Producto>
        {
                new Producto { Fecha = "12", Inicio_hora = "Producto 1", Fin_hora = "10.50m", Duracion = "10.50m", Compañia = "10.50m", Telefono = "10.50m" },
                new Producto { Fecha = "12", Inicio_hora = "Producto 1", Fin_hora = "10.50m", Duracion = "10.50m", Compañia = "10.50m", Telefono = "10.50m" },
        };

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

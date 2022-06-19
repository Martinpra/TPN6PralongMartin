using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPN6PralongMartin
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            string autor;
            int paginas;
            decimal precio;
            string resultado;
            string genero;

            string importado = (checkBox1.Checked == true) ? "Importado" : "Nacional";

            nombre = textBox1.Text;
            autor = textBox2.Text; 
            genero = comboBox1.Text;
            paginas = int.Parse(textBox3.Text);
            precio = Convert.ToDecimal(textBox4.Text);
            resultado = nombre.ToString() + " - " + autor.ToString() + " - " + genero.ToString() + " - " + paginas.ToString() + " - " + importado.ToString() + " - " + precio.ToString();

            listBox1.Items.Add(resultado);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            checkBox1.Checked = false;
            comboBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Novelas";
            comboBox1.Items.Add("Novelas");
            comboBox1.Items.Add("Cuentos");
            comboBox1.Items.Add("Peosia");
            comboBox1.Items.Add("Fabulas");
            comboBox1.Items.Add("Historieta");
        }
    }
}

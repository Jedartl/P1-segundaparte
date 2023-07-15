using SegundaParte.Algoritmo;

namespace SegundaParte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento del botón para calcular el valor de "u"
        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los valores de entrada desde los cuadros de texto
            int a = int.Parse(textBox1.Text);  // Valor de "x"
            int x = int.Parse(textBox2.Text);  // Valor del multiplicador "a"
            int c = int.Parse(textBox3.Text);  // Valor de la constante aditiva "c"

            // Crear una instancia de la clase "metodos" para utilizar el método "Metodosvarios"
            metodo AlgoMetodo = new metodo();

            // Calcular el valor de "u" utilizando el método "Metodosvarios" del objeto "AlgoMetodos"
            int u = AlgoMetodo.formulas(a, x, c);

            // Mostrar el resultado en el cuadro de texto textBox4
            textBox4.Text = u.ToString(); 
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
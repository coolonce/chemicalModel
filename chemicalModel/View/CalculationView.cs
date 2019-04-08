using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chemicalModel
{
    public partial class CalculationView : Form
    {
        public CalculationView()
        {
            InitializeComponent();
            AuthView auth = new AuthView();
            auth.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MathModel Model = new MathModel();
            
            double CaclF = Model.CaclF(0.1, 0.3);
            Console.WriteLine(CaclF);
        }
    }
}

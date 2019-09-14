using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public partial class Calculadora_de_Fabian_Rolon_del_curso_2do_D : Form
    {
        public Calculadora_de_Fabian_Rolon_del_curso_2do_D()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click_1(object sender, EventArgs e)
        {
            Numero numeroUno = new Numero(txtNumeroUno.Text);
            Numero numeroDos = new Numero(txtNumeroDos.Text);
            this.label1.Text = Calculadora.Operar(numeroUno, numeroDos, cbOperador.Text).ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumeroUno.Text = "";
            this.txtNumeroDos.Text = "";
            this.label1.Text = "0";
            cbOperador.Text = "";
        }

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias, vuelva pronto ", "Chau", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void BtnDecimalBinario_Click(object sender, EventArgs e)
        {
            Numero numeroUno = new Numero(label1.Text);
            this.label1.Text = numeroUno.DecimalBinario();
        }

        private void BtnBinarioDecimal_Click_1(object sender, EventArgs e)
        {
            Numero numeroUno = new Numero(label1.Text);
            this.label1.Text = numeroUno.BinarioDecimal();
        }
    }
}

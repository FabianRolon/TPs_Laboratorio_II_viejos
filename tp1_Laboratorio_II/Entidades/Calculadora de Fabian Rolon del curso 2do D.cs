﻿using System;
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
        #region Metodos de clase
        public void Limpiar()
        {
            this.txtNumeroUno.Text = "";
            this.txtNumeroDos.Text = "";
            this.label1.Text = "0";
            cbOperador.Text = "";
        }

        static double Operar(string numero1, string numero2, string operador)
        {
            Numero numeroUno = new Numero(numero1);
            Numero numeroDos = new Numero(numero2);
            return Calculadora.Operar(numeroUno, numeroDos, operador);
        }
        #endregion
        #region Controles
        public Calculadora_de_Fabian_Rolon_del_curso_2do_D()
        {
            InitializeComponent();
        }

        private void BtnOperar_Click_1(object sender, EventArgs e)
        {
            label1.Text = Operar(txtNumeroUno.Text, txtNumeroDos.Text, cbOperador.Text).ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias, vuelva pronto ", "Hasta luego", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void BtnDecimalBinario_Click(object sender, EventArgs e)
        {
            Numero numeroUno = new Numero(label1.Text);
            this.label1.Text = numeroUno.DecimalBinario(label1.Text);
        }

        private void BtnBinarioDecimal_Click_1(object sender, EventArgs e)
        {
            Numero numeroUno = new Numero(label1.Text);
            this.label1.Text = numeroUno.BinarioDecimal(label1.Text);
        }
        #endregion
    }
}

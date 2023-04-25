using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metodoGraficos
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ecuaciones = Int32.Parse(txt1.Text);
            MessageBox.Show(ecuaciones.ToString());
            this.Hide();
            va.vari = ecuaciones;
            variablesAgregar v1 = new variablesAgregar();
            v1.Show();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt1.Text, "[^0-9]"))
            {
                MessageBox.Show("por favor solo ingresar numeros");
                txt1.Text = txt1.Text.Remove(txt1.Text.Length - 1);
            }
        }
    }
}

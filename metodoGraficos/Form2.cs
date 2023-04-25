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
    public partial class variablesAgregar : Form
    {
        public variablesAgregar()
        {
            InitializeComponent();
        }
        int i = 0;
        int j = 1;
        int[] arX = new int[va.vari];
        int[] arY = new int[va.vari];
        int[] inSM = new int[va.vari];
        int[] inMIM = new int[va.vari];
        int[] total = new int[va.vari];

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            i = i + 1;
            j = j + 1;
            lblEc.Text = j.ToString() + "/" + va.vari.ToString();
            total[i] = Int32.Parse(txtTotal.Text);
            arX[i] = Int32.Parse(txtVx.Text);
            arY[i] = Int32.Parse(txtVy.Text);
            inSM[i] = cmbSM.SelectedIndex;
            inMIM[i] = cmbMIM.SelectedIndex;
            ltboxVar.Items.Add(arX[i].ToString() + cmbSM.Items[inSM[i]].ToString() + arY[i].ToString() + cmbMIM.Items[inMIM[i]].ToString() + total[i].ToString());
            txtTotal.Clear();
            txtVx.Clear();
            txtVy.Clear();
        }

        private void variablesAgregar_Load(object sender, EventArgs e)
        {
            lblEc.Text = j.ToString() + "/" + va.vari.ToString();
        }
    }
}

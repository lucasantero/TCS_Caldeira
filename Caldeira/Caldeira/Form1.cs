using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caldeira
{
    public partial class frmCaldeira : Form
    {
        public frmCaldeira()
        {
            InitializeComponent();
            AtualizaCaldeira();
            
        }
        private void AtualizaCaldeira()
        {
            txtTempCaldeira.Text = Caldeira.getInstance().Temperatura.ToString();
            txtNivelAguaCaldeira.Text = Caldeira.getInstance().NivelAgua.ToString();
            txtTempFunc1.Text = Caldeira.getInstance().Temperatura.ToString();
            txtNivelAguaFunc1.Text = Caldeira.getInstance().NivelAgua.ToString();
            txtTempFunc2.Text = Caldeira.getInstance().Temperatura.ToString();
            txtNivelAguaFunc2.Text = Caldeira.getInstance().NivelAgua.ToString();
        }

        private void btnAdicionarAgua_Click(object sender, EventArgs e)
        {
            Caldeira.getInstance().alterarNivelAgua(float.Parse(txtAgua.Text));
            AtualizaCaldeira();
        }

        private void btnAlterarTemperatura_Click(object sender, EventArgs e)
        {
            Caldeira.getInstance().alterarTemperaturaFogo(float.Parse(txtTemperatura.Text));
            AtualizaCaldeira();
        }

        private void txtAgua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

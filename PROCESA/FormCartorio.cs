using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROCESA
{
    public partial class FormCartorio : Form
    {
        Cartorio Cartorio;
        public FormCartorio(Cartorio cartorio)
        {
            InitializeComponent();
            this.Cartorio = cartorio;
        }

        private void FormPraca_Load(object sender, EventArgs e)
        {
            textCod.DataBindings.Add(new Binding("Text", this.Cartorio, "Cod"));
            textCidade.DataBindings.Add(new Binding("Text", this.Cartorio, "Cidade"));
            textContato.DataBindings.Add(new Binding("Text", this.Cartorio, "Contato"));
            textTelefone.DataBindings.Add(new Binding("Text", this.Cartorio, "Telefone"));
            textObservacao.DataBindings.Add(new Binding("Text", this.Cartorio, "Observacao"));

            if (this.Cartorio.Cod == 0)
            {
                textCod.Enabled = true;
            }
            else
            {
                textCod.Enabled = false;
            }
        }

        
    }
}

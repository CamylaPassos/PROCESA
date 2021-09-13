using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROCESA
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnNovoCartorio_Click(object sender, EventArgs e)
        {
            if (sender == btnNovoCartorio)
            {
                cartorioBindingSource.Add(new Cartorio());
                cartorioBindingSource.MoveLast();
            }

            if (cartorioBindingSource.Current == null) return;
           
            using (var form = new FormCartorio(cartorioBindingSource.Current as Cartorio))
            {
              if (form.ShowDialog() == DialogResult.OK)
                {
                    var cartorio = cartorioBindingSource.Current as Cartorio;
                    
                    if (cartorio == null) return;
                    
                    using (var db = new ApplicationDbContext())
                    {
                        if (db.Entry(cartorio).State == EntityState.Detached)
                            db.Set<Cartorio>().Attach(cartorio);

                        if (!db.Cartorios.Any(x=> x.Cod == cartorio.Cod)) 
                            db.Entry(cartorio).State = EntityState.Added;
                        else
                            db.Entry(cartorio).State = EntityState.Modified;

                        if (db.SaveChanges() > 0)
                        {
                            dgvCartorios.Refresh();
                            MessageBox.Show($"Cartorio \"{cartorio.Cidade}\" foi salva com sucesso.", "Informação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                       else
                        {
                            MessageBox.Show($"Cartorio \"{cartorio.Cidade}\" não pode ser salva.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    
                }
                if (form.DialogResult == DialogResult.Cancel)
                {
                    cartorioBindingSource.Remove(cartorioBindingSource.Current);
                }
             }

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            using (var db = new ApplicationDbContext())
            {
                cartorioBindingSource.DataSource = db.Cartorios.ToList();
            }
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            if (cartorioBindingSource.Current == null) return;

            var cartorio = cartorioBindingSource.Current as Cartorio;

            if (MessageBox.Show($"Deseja realmente excluir o Cartório \"{cartorio.Cidade}\" ?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            using (var db = new ApplicationDbContext())
            {
                if (db.Entry(cartorio).State == EntityState.Detached)
                    db.Set<Cartorio>().Attach(cartorio);

                db.Entry(cartorio).State = EntityState.Deleted;

                if (db.SaveChanges() > 0)
                {
                    cartorioBindingSource.Remove(cartorio);
                    dgvCartorios.Refresh();
                    MessageBox.Show($"Cartorio \"{cartorio.Cidade}\" excluída com sucesso.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Cartótio \"{cartorio.Cidade}\" não pode ser excluída.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void FormPrincipal_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Seja Bem-Vindo(a), bom trabalho!");
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmetente sair?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

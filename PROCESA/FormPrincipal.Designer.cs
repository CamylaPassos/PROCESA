
namespace PROCESA
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.dgvCartorios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovoCartorio = new System.Windows.Forms.Button();
            this.btnAlterarCartorio = new System.Windows.Forms.Button();
            this.btnExluir = new System.Windows.Forms.Button();
            this.codDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartorioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCartorios
            // 
            this.dgvCartorios.AllowUserToAddRows = false;
            this.dgvCartorios.AllowUserToDeleteRows = false;
            this.dgvCartorios.AutoGenerateColumns = false;
            this.dgvCartorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartorios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.contatoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn});
            this.dgvCartorios.DataSource = this.cartorioBindingSource;
            this.dgvCartorios.Location = new System.Drawing.Point(12, 45);
            this.dgvCartorios.Name = "dgvCartorios";
            this.dgvCartorios.ReadOnly = true;
            this.dgvCartorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartorios.Size = new System.Drawing.Size(725, 313);
            this.dgvCartorios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cartórios";
            // 
            // btnNovoCartorio
            // 
            this.btnNovoCartorio.Location = new System.Drawing.Point(634, 383);
            this.btnNovoCartorio.Name = "btnNovoCartorio";
            this.btnNovoCartorio.Size = new System.Drawing.Size(101, 39);
            this.btnNovoCartorio.TabIndex = 2;
            this.btnNovoCartorio.Text = "Adicionar...";
            this.btnNovoCartorio.UseVisualStyleBackColor = true;
            this.btnNovoCartorio.Click += new System.EventHandler(this.btnNovoCartorio_Click);
            // 
            // btnAlterarCartorio
            // 
            this.btnAlterarCartorio.Location = new System.Drawing.Point(534, 383);
            this.btnAlterarCartorio.Name = "btnAlterarCartorio";
            this.btnAlterarCartorio.Size = new System.Drawing.Size(94, 28);
            this.btnAlterarCartorio.TabIndex = 2;
            this.btnAlterarCartorio.Text = "Alterar...";
            this.btnAlterarCartorio.UseVisualStyleBackColor = true;
            this.btnAlterarCartorio.Click += new System.EventHandler(this.btnNovoCartorio_Click);
            // 
            // btnExluir
            // 
            this.btnExluir.Location = new System.Drawing.Point(343, 383);
            this.btnExluir.Name = "btnExluir";
            this.btnExluir.Size = new System.Drawing.Size(87, 28);
            this.btnExluir.TabIndex = 3;
            this.btnExluir.Text = "Excluir...";
            this.btnExluir.UseVisualStyleBackColor = true;
            this.btnExluir.Click += new System.EventHandler(this.btnExluir_Click);
            // 
            // codDataGridViewTextBoxColumn
            // 
            this.codDataGridViewTextBoxColumn.DataPropertyName = "Cod";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Format = "D4";
            dataGridViewCellStyle1.NullValue = null;
            this.codDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.codDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codDataGridViewTextBoxColumn.Name = "codDataGridViewTextBoxColumn";
            this.codDataGridViewTextBoxColumn.ReadOnly = true;
            this.codDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.codDataGridViewTextBoxColumn.Width = 80;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cidadeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidadeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cidadeDataGridViewTextBoxColumn.Width = 90;
            // 
            // contatoDataGridViewTextBoxColumn
            // 
            this.contatoDataGridViewTextBoxColumn.DataPropertyName = "Contato";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.contatoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.contatoDataGridViewTextBoxColumn.HeaderText = "Contato";
            this.contatoDataGridViewTextBoxColumn.Name = "contatoDataGridViewTextBoxColumn";
            this.contatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.contatoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.contatoDataGridViewTextBoxColumn.Width = 140;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.telefoneDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.telefoneDataGridViewTextBoxColumn.Width = 170;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.observacaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observação";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacaoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.observacaoDataGridViewTextBoxColumn.Width = 200;
            // 
            // cartorioBindingSource
            // 
            this.cartorioBindingSource.DataSource = typeof(PROCESA.Cartorio);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExluir);
            this.Controls.Add(this.btnAlterarCartorio);
            this.Controls.Add(this.btnNovoCartorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCartorios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.Shown += new System.EventHandler(this.FormPrincipal_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartorioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCartorios;
        private System.Windows.Forms.BindingSource cartorioBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovoCartorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAlterarCartorio;
        private System.Windows.Forms.Button btnExluir;
    }
}
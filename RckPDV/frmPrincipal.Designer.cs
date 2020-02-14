namespace RckPDV
{
  partial class frmPrincipal
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
      this.pnlDisplay = new System.Windows.Forms.Panel();
      this.pnlVenda = new System.Windows.Forms.Panel();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.pnlPagamento = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.pnlPesquisa = new System.Windows.Forms.Panel();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.txtNome = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.pnlOperador = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.pnlGerencia = new System.Windows.Forms.Panel();
      this.label5 = new System.Windows.Forms.Label();
      this.pnlDisplay.SuspendLayout();
      this.pnlVenda.SuspendLayout();
      this.pnlPagamento.SuspendLayout();
      this.pnlPesquisa.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.pnlOperador.SuspendLayout();
      this.pnlGerencia.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblWindowTitle
      // 
      this.lblWindowTitle.Size = new System.Drawing.Size(1083, 30);
      // 
      // btnWindowClose
      // 
      this.btnWindowClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowClose.BackgroundImage")));
      this.btnWindowClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
      this.btnWindowClose.Location = new System.Drawing.Point(1041, 6);
      // 
      // btnWindowMinimize
      // 
      this.btnWindowMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowMinimize.BackgroundImage")));
      this.btnWindowMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnWindowMinimize.Location = new System.Drawing.Point(1005, 6);
      // 
      // pnlDisplay
      // 
      this.pnlDisplay.BackColor = System.Drawing.Color.White;
      this.pnlDisplay.Controls.Add(this.pnlVenda);
      this.pnlDisplay.Controls.Add(this.pnlPagamento);
      this.pnlDisplay.Controls.Add(this.pnlPesquisa);
      this.pnlDisplay.Controls.Add(this.pnlOperador);
      this.pnlDisplay.Controls.Add(this.pnlGerencia);
      this.pnlDisplay.Location = new System.Drawing.Point(12, 33);
      this.pnlDisplay.Name = "pnlDisplay";
      this.pnlDisplay.Size = new System.Drawing.Size(1024, 720);
      this.pnlDisplay.TabIndex = 3;
      // 
      // pnlVenda
      // 
      this.pnlVenda.Controls.Add(this.listBox1);
      this.pnlVenda.Controls.Add(this.label1);
      this.pnlVenda.Dock = System.Windows.Forms.DockStyle.Right;
      this.pnlVenda.Location = new System.Drawing.Point(450, 100);
      this.pnlVenda.Name = "pnlVenda";
      this.pnlVenda.Size = new System.Drawing.Size(374, 520);
      this.pnlVenda.TabIndex = 2;
      // 
      // listBox1
      // 
      this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 19;
      this.listBox1.Items.AddRange(new object[] {
            "DESCRICAO           QTDE   UNIT.   TOTAL",
            "----------------------------------------",
            "PRODUTO               10    1,00   10,00",
            "PRODUTO               10    2,00   20,00",
            "----------------------------------------",
            "SUB TOTAL                       R$ 30,00",
            "DESCONTO                            3,00",
            "TOTAL                           R$ 27,00",
            "----------------------------------------",
            "DINHEIRO                        R$ 50,00",
            "TROCO                           R$ 23,00"});
      this.listBox1.Location = new System.Drawing.Point(0, 40);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(374, 480);
      this.listBox1.TabIndex = 22;
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Arial Black", 12F);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Padding = new System.Windows.Forms.Padding(5);
      this.label1.Size = new System.Drawing.Size(374, 40);
      this.label1.TabIndex = 21;
      this.label1.Text = "Venda";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // pnlPagamento
      // 
      this.pnlPagamento.Controls.Add(this.label2);
      this.pnlPagamento.Dock = System.Windows.Forms.DockStyle.Right;
      this.pnlPagamento.Location = new System.Drawing.Point(824, 100);
      this.pnlPagamento.Name = "pnlPagamento";
      this.pnlPagamento.Size = new System.Drawing.Size(200, 520);
      this.pnlPagamento.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
      this.label2.Dock = System.Windows.Forms.DockStyle.Top;
      this.label2.Font = new System.Drawing.Font("Arial Black", 12F);
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Padding = new System.Windows.Forms.Padding(5);
      this.label2.Size = new System.Drawing.Size(200, 40);
      this.label2.TabIndex = 21;
      this.label2.Text = "Pagamento";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // pnlPesquisa
      // 
      this.pnlPesquisa.Controls.Add(this.dataGridView1);
      this.pnlPesquisa.Controls.Add(this.txtNome);
      this.pnlPesquisa.Controls.Add(this.label4);
      this.pnlPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlPesquisa.Location = new System.Drawing.Point(0, 100);
      this.pnlPesquisa.Name = "pnlPesquisa";
      this.pnlPesquisa.Size = new System.Drawing.Size(1024, 520);
      this.pnlPesquisa.TabIndex = 0;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 78);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(1024, 442);
      this.dataGridView1.TabIndex = 22;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // txtNome
      // 
      this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNome.Dock = System.Windows.Forms.DockStyle.Top;
      this.txtNome.Font = new System.Drawing.Font("Arial", 20F);
      this.txtNome.Location = new System.Drawing.Point(0, 40);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(1024, 38);
      this.txtNome.TabIndex = 23;
      // 
      // label4
      // 
      this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
      this.label4.Dock = System.Windows.Forms.DockStyle.Top;
      this.label4.Font = new System.Drawing.Font("Arial Black", 12F);
      this.label4.ForeColor = System.Drawing.Color.White;
      this.label4.Location = new System.Drawing.Point(0, 0);
      this.label4.Name = "label4";
      this.label4.Padding = new System.Windows.Forms.Padding(5);
      this.label4.Size = new System.Drawing.Size(1024, 40);
      this.label4.TabIndex = 21;
      this.label4.Text = "Pesquisa";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // pnlOperador
      // 
      this.pnlOperador.Controls.Add(this.label3);
      this.pnlOperador.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlOperador.Location = new System.Drawing.Point(0, 0);
      this.pnlOperador.Name = "pnlOperador";
      this.pnlOperador.Size = new System.Drawing.Size(1024, 100);
      this.pnlOperador.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
      this.label3.Dock = System.Windows.Forms.DockStyle.Top;
      this.label3.Font = new System.Drawing.Font("Arial Black", 12F);
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(0, 0);
      this.label3.Name = "label3";
      this.label3.Padding = new System.Windows.Forms.Padding(5);
      this.label3.Size = new System.Drawing.Size(1024, 40);
      this.label3.TabIndex = 21;
      this.label3.Text = "Operador";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // pnlGerencia
      // 
      this.pnlGerencia.Controls.Add(this.label5);
      this.pnlGerencia.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlGerencia.Location = new System.Drawing.Point(0, 620);
      this.pnlGerencia.Name = "pnlGerencia";
      this.pnlGerencia.Size = new System.Drawing.Size(1024, 100);
      this.pnlGerencia.TabIndex = 4;
      // 
      // label5
      // 
      this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
      this.label5.Dock = System.Windows.Forms.DockStyle.Top;
      this.label5.Font = new System.Drawing.Font("Arial Black", 12F);
      this.label5.ForeColor = System.Drawing.Color.White;
      this.label5.Location = new System.Drawing.Point(0, 0);
      this.label5.Name = "label5";
      this.label5.Padding = new System.Windows.Forms.Padding(5);
      this.label5.Size = new System.Drawing.Size(1024, 40);
      this.label5.TabIndex = 21;
      this.label5.Text = "Gerência";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // frmPrincipal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1083, 788);
      this.Controls.Add(this.pnlDisplay);
      this.Name = "frmPrincipal";
      this.Text = "frmPrincipal";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmPrincipal_Load);
      this.Controls.SetChildIndex(this.lblWindowTitle, 0);
      this.Controls.SetChildIndex(this.btnWindowClose, 0);
      this.Controls.SetChildIndex(this.btnWindowMinimize, 0);
      this.Controls.SetChildIndex(this.pnlDisplay, 0);
      this.pnlDisplay.ResumeLayout(false);
      this.pnlVenda.ResumeLayout(false);
      this.pnlPagamento.ResumeLayout(false);
      this.pnlPesquisa.ResumeLayout(false);
      this.pnlPesquisa.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.pnlOperador.ResumeLayout(false);
      this.pnlGerencia.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlDisplay;
    private System.Windows.Forms.Panel pnlVenda;
    private System.Windows.Forms.Panel pnlPagamento;
    private System.Windows.Forms.Panel pnlPesquisa;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Panel pnlOperador;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Panel pnlGerencia;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.TextBox txtNome;
  }
}
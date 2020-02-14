namespace SysZoo
{
  partial class frmGerencia
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerencia));
      this.btnTickets = new System.Windows.Forms.Button();
      this.btnSair = new System.Windows.Forms.Button();
      this.btnPagamento = new System.Windows.Forms.Button();
      this.btnOperadores = new System.Windows.Forms.Button();
      this.btnConfiguracao = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblWindowTitle
      // 
      this.lblWindowTitle.Size = new System.Drawing.Size(338, 30);
      this.lblWindowTitle.Text = "Gerência";
      // 
      // btnWindowClose
      // 
      this.btnWindowClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowClose.BackgroundImage")));
      this.btnWindowClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
      this.btnWindowClose.Location = new System.Drawing.Point(294, 4);
      // 
      // btnWindowMinimize
      // 
      this.btnWindowMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowMinimize.BackgroundImage")));
      this.btnWindowMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnWindowMinimize.Location = new System.Drawing.Point(258, 4);
      // 
      // btnTickets
      // 
      this.btnTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnTickets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnTickets.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTickets.ForeColor = System.Drawing.Color.White;
      this.btnTickets.Location = new System.Drawing.Point(12, 77);
      this.btnTickets.Name = "btnTickets";
      this.btnTickets.Size = new System.Drawing.Size(315, 38);
      this.btnTickets.TabIndex = 4;
      this.btnTickets.Text = "Cadastro de &Tickets";
      this.btnTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnTickets.UseVisualStyleBackColor = false;
      this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);
      // 
      // btnSair
      // 
      this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSair.ForeColor = System.Drawing.Color.White;
      this.btnSair.Location = new System.Drawing.Point(12, 209);
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(315, 38);
      this.btnSair.TabIndex = 9;
      this.btnSair.Text = "&Sair";
      this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSair.UseVisualStyleBackColor = false;
      this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
      // 
      // btnPagamento
      // 
      this.btnPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnPagamento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnPagamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPagamento.ForeColor = System.Drawing.Color.White;
      this.btnPagamento.Location = new System.Drawing.Point(12, 121);
      this.btnPagamento.Name = "btnPagamento";
      this.btnPagamento.Size = new System.Drawing.Size(315, 38);
      this.btnPagamento.TabIndex = 5;
      this.btnPagamento.Text = "Cadastro de &Forma de Pagamento";
      this.btnPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnPagamento.UseVisualStyleBackColor = false;
      this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
      // 
      // btnOperadores
      // 
      this.btnOperadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnOperadores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnOperadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnOperadores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnOperadores.ForeColor = System.Drawing.Color.White;
      this.btnOperadores.Location = new System.Drawing.Point(12, 165);
      this.btnOperadores.Name = "btnOperadores";
      this.btnOperadores.Size = new System.Drawing.Size(315, 38);
      this.btnOperadores.TabIndex = 6;
      this.btnOperadores.Text = "Cadastro de &Operadores";
      this.btnOperadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnOperadores.UseVisualStyleBackColor = false;
      this.btnOperadores.Click += new System.EventHandler(this.btnOperadores_Click);
      // 
      // btnConfiguracao
      // 
      this.btnConfiguracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnConfiguracao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnConfiguracao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnConfiguracao.ForeColor = System.Drawing.Color.White;
      this.btnConfiguracao.Location = new System.Drawing.Point(12, 33);
      this.btnConfiguracao.Name = "btnConfiguracao";
      this.btnConfiguracao.Size = new System.Drawing.Size(315, 38);
      this.btnConfiguracao.TabIndex = 3;
      this.btnConfiguracao.Text = "&Configuração Impressora";
      this.btnConfiguracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnConfiguracao.UseVisualStyleBackColor = false;
      this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
      // 
      // frmGerencia
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(338, 261);
      this.Controls.Add(this.btnConfiguracao);
      this.Controls.Add(this.btnOperadores);
      this.Controls.Add(this.btnPagamento);
      this.Controls.Add(this.btnSair);
      this.Controls.Add(this.btnTickets);
      this.Name = "frmGerencia";
      this.Text = "Menu";
      this.Controls.SetChildIndex(this.lblWindowTitle, 0);
      this.Controls.SetChildIndex(this.btnWindowClose, 0);
      this.Controls.SetChildIndex(this.btnWindowMinimize, 0);
      this.Controls.SetChildIndex(this.btnTickets, 0);
      this.Controls.SetChildIndex(this.btnSair, 0);
      this.Controls.SetChildIndex(this.btnPagamento, 0);
      this.Controls.SetChildIndex(this.btnOperadores, 0);
      this.Controls.SetChildIndex(this.btnConfiguracao, 0);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnTickets;
    private System.Windows.Forms.Button btnSair;
    private System.Windows.Forms.Button btnPagamento;
    private System.Windows.Forms.Button btnOperadores;
    private System.Windows.Forms.Button btnConfiguracao;

  }
}
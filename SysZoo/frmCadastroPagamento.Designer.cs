namespace SysZoo
{
  partial class frmCadastroPagamento
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroPagamento));
      this.label1 = new System.Windows.Forms.Label();
      this.txtForma = new System.Windows.Forms.TextBox();
      this.btnGravar = new System.Windows.Forms.Button();
      this.lstFormas = new System.Windows.Forms.ListBox();
      this.btnExcluir = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblWindowTitle
      // 
      this.lblWindowTitle.Size = new System.Drawing.Size(389, 30);
      this.lblWindowTitle.TabIndex = 0;
      this.lblWindowTitle.Text = "Cadastro de Formas de Pagamento";
      // 
      // btnWindowClose
      // 
      this.btnWindowClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowClose.BackgroundImage")));
      this.btnWindowClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
      this.btnWindowClose.Location = new System.Drawing.Point(347, 6);
      this.btnWindowClose.TabIndex = 2;
      // 
      // btnWindowMinimize
      // 
      this.btnWindowMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowMinimize.BackgroundImage")));
      this.btnWindowMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnWindowMinimize.Location = new System.Drawing.Point(311, 6);
      this.btnWindowMinimize.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 18);
      this.label1.TabIndex = 3;
      this.label1.Text = "Descricao";
      // 
      // txtForma
      // 
      this.txtForma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtForma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtForma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtForma.Location = new System.Drawing.Point(12, 62);
      this.txtForma.Name = "txtForma";
      this.txtForma.Size = new System.Drawing.Size(272, 26);
      this.txtForma.TabIndex = 4;
      // 
      // btnGravar
      // 
      this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnGravar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGravar.ForeColor = System.Drawing.Color.White;
      this.btnGravar.Location = new System.Drawing.Point(290, 54);
      this.btnGravar.Name = "btnGravar";
      this.btnGravar.Size = new System.Drawing.Size(87, 38);
      this.btnGravar.TabIndex = 5;
      this.btnGravar.Text = "Gravar";
      this.btnGravar.UseVisualStyleBackColor = false;
      this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
      // 
      // lstFormas
      // 
      this.lstFormas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lstFormas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstFormas.FormattingEnabled = true;
      this.lstFormas.ItemHeight = 22;
      this.lstFormas.Items.AddRange(new object[] {
            "DINHEIRO",
            "CHEQUE"});
      this.lstFormas.Location = new System.Drawing.Point(12, 98);
      this.lstFormas.Name = "lstFormas";
      this.lstFormas.Size = new System.Drawing.Size(365, 222);
      this.lstFormas.TabIndex = 6;
      // 
      // btnExcluir
      // 
      this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExcluir.ForeColor = System.Drawing.Color.White;
      this.btnExcluir.Location = new System.Drawing.Point(12, 334);
      this.btnExcluir.Name = "btnExcluir";
      this.btnExcluir.Size = new System.Drawing.Size(365, 38);
      this.btnExcluir.TabIndex = 7;
      this.btnExcluir.Text = "Excluir";
      this.btnExcluir.UseVisualStyleBackColor = false;
      this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
      // 
      // frmCadastroPagamento
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(389, 384);
      this.Controls.Add(this.btnExcluir);
      this.Controls.Add(this.lstFormas);
      this.Controls.Add(this.btnGravar);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtForma);
      this.Name = "frmCadastroPagamento";
      this.Text = "frmPagamento";
      this.Load += new System.EventHandler(this.frmCadastroPagamento_Load);
      this.Controls.SetChildIndex(this.lblWindowTitle, 0);
      this.Controls.SetChildIndex(this.btnWindowClose, 0);
      this.Controls.SetChildIndex(this.btnWindowMinimize, 0);
      this.Controls.SetChildIndex(this.txtForma, 0);
      this.Controls.SetChildIndex(this.label1, 0);
      this.Controls.SetChildIndex(this.btnGravar, 0);
      this.Controls.SetChildIndex(this.lstFormas, 0);
      this.Controls.SetChildIndex(this.btnExcluir, 0);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtForma;
    private System.Windows.Forms.Button btnGravar;
    private System.Windows.Forms.ListBox lstFormas;
    private System.Windows.Forms.Button btnExcluir;
  }
}
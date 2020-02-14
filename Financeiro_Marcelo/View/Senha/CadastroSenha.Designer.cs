namespace Financeiro_Marcelo.Senha
{
  partial class CadastroSenha
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
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.txtSenhaEntrada = new lib.Visual.Components.sknTextBox();
      this.txtSenhaExclusiva = new lib.Visual.Components.sknTextBox();
      this.txtConfirmarSenhaEntrada = new lib.Visual.Components.sknTextBox();
      this.sknLabel3 = new lib.Visual.Components.sknLabel();
      this.sknLabel4 = new lib.Visual.Components.sknLabel();
      this.txtConfirmarSenhaExclusiva = new lib.Visual.Components.sknTextBox();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.sknLabel4);
      this.pnlContext.Controls.Add(this.txtConfirmarSenhaExclusiva);
      this.pnlContext.Controls.Add(this.sknLabel3);
      this.pnlContext.Controls.Add(this.txtConfirmarSenhaEntrada);
      this.pnlContext.Controls.Add(this.txtSenhaExclusiva);
      this.pnlContext.Controls.Add(this.txtSenhaEntrada);
      this.pnlContext.Controls.Add(this.sknLabel2);
      this.pnlContext.Controls.Add(this.sknLabel1);
      this.pnlContext.Size = new System.Drawing.Size(228, 177);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 177);
      this.pnlBottom.Size = new System.Drawing.Size(228, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(20, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(116, 8);
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 9);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(200, 13);
      this.sknLabel1.TabIndex = 0;
      this.sknLabel1.Text = "Senha para entrada e acesso ao sistema";
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(12, 87);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(167, 13);
      this.sknLabel2.TabIndex = 4;
      this.sknLabel2.Text = "Senha para operações exclusivas";
      // 
      // txtSenhaEntrada
      // 
      this.txtSenhaEntrada.AsDateTime = new System.DateTime(2011, 6, 29, 12, 9, 53, 596);
      this.txtSenhaEntrada.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtSenhaEntrada.AutoTab = true;
      this.txtSenhaEntrada.Location = new System.Drawing.Point(12, 25);
      this.txtSenhaEntrada.Name = "txtSenhaEntrada";
      this.txtSenhaEntrada.PasswordChar = '*';
      this.txtSenhaEntrada.Size = new System.Drawing.Size(200, 20);
      this.txtSenhaEntrada.TabIndex = 1;
      this.txtSenhaEntrada.TextFormat = null;
      this.txtSenhaEntrada.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // txtSenhaExclusiva
      // 
      this.txtSenhaExclusiva.AsDateTime = new System.DateTime(2011, 6, 29, 12, 9, 53, 589);
      this.txtSenhaExclusiva.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtSenhaExclusiva.AutoTab = true;
      this.txtSenhaExclusiva.Location = new System.Drawing.Point(12, 103);
      this.txtSenhaExclusiva.Name = "txtSenhaExclusiva";
      this.txtSenhaExclusiva.PasswordChar = '*';
      this.txtSenhaExclusiva.Size = new System.Drawing.Size(200, 20);
      this.txtSenhaExclusiva.TabIndex = 5;
      this.txtSenhaExclusiva.TextFormat = null;
      this.txtSenhaExclusiva.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // txtConfirmarSenhaEntrada
      // 
      this.txtConfirmarSenhaEntrada.AsDateTime = new System.DateTime(2011, 6, 29, 12, 9, 53, 582);
      this.txtConfirmarSenhaEntrada.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtConfirmarSenhaEntrada.AutoTab = true;
      this.txtConfirmarSenhaEntrada.Location = new System.Drawing.Point(12, 64);
      this.txtConfirmarSenhaEntrada.Name = "txtConfirmarSenhaEntrada";
      this.txtConfirmarSenhaEntrada.PasswordChar = '*';
      this.txtConfirmarSenhaEntrada.Size = new System.Drawing.Size(200, 20);
      this.txtConfirmarSenhaEntrada.TabIndex = 3;
      this.txtConfirmarSenhaEntrada.TextFormat = null;
      this.txtConfirmarSenhaEntrada.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel3
      // 
      this.sknLabel3.AutoSize = true;
      this.sknLabel3.Location = new System.Drawing.Point(12, 48);
      this.sknLabel3.Name = "sknLabel3";
      this.sknLabel3.Size = new System.Drawing.Size(51, 13);
      this.sknLabel3.TabIndex = 2;
      this.sknLabel3.Text = "Confirmar";
      // 
      // sknLabel4
      // 
      this.sknLabel4.AutoSize = true;
      this.sknLabel4.Location = new System.Drawing.Point(12, 126);
      this.sknLabel4.Name = "sknLabel4";
      this.sknLabel4.Size = new System.Drawing.Size(51, 13);
      this.sknLabel4.TabIndex = 6;
      this.sknLabel4.Text = "Confirmar";
      // 
      // txtConfirmarSenhaExclusiva
      // 
      this.txtConfirmarSenhaExclusiva.AsDateTime = new System.DateTime(2011, 6, 29, 12, 9, 53, 568);
      this.txtConfirmarSenhaExclusiva.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtConfirmarSenhaExclusiva.AutoTab = true;
      this.txtConfirmarSenhaExclusiva.Location = new System.Drawing.Point(12, 142);
      this.txtConfirmarSenhaExclusiva.Name = "txtConfirmarSenhaExclusiva";
      this.txtConfirmarSenhaExclusiva.PasswordChar = '*';
      this.txtConfirmarSenhaExclusiva.Size = new System.Drawing.Size(200, 20);
      this.txtConfirmarSenhaExclusiva.TabIndex = 7;
      this.txtConfirmarSenhaExclusiva.TextFormat = null;
      this.txtConfirmarSenhaExclusiva.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // CadastroSenha
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(228, 222);
      this.Name = "CadastroSenha";
      this.Text = "Cadastro de Senha";
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknTextBox txtSenhaEntrada;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknLabel sknLabel4;
    private lib.Visual.Components.sknTextBox txtConfirmarSenhaExclusiva;
    private lib.Visual.Components.sknLabel sknLabel3;
    private lib.Visual.Components.sknTextBox txtConfirmarSenhaEntrada;
    private lib.Visual.Components.sknTextBox txtSenhaExclusiva;
  }
}
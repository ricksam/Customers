namespace Financeiro_Marcelo.Senha
{
  partial class InformarSenha
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformarSenha));
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.txtSenha = new lib.Visual.Components.sknTextBox();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.txtSenha);
      this.pnlContext.Controls.Add(this.sknLabel1);
      this.pnlContext.Size = new System.Drawing.Size(292, 53);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 53);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(84, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(180, 8);
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 9);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(85, 13);
      this.sknLabel1.TabIndex = 0;
      this.sknLabel1.Text = "Informe a Senha";
      // 
      // txtSenha
      // 
      this.txtSenha.AsDateTime = new System.DateTime(((long)(0)));
      this.txtSenha.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtSenha.AutoTab = true;
      this.txtSenha.Location = new System.Drawing.Point(12, 25);
      this.txtSenha.Name = "txtSenha";
      this.txtSenha.PasswordChar = '*';
      this.txtSenha.Size = new System.Drawing.Size(268, 20);
      this.txtSenha.TabIndex = 1;
      this.txtSenha.TextFormat = null;
      this.txtSenha.TextType = lib.Visual.Components.enmTextType.String;
      this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
      // 
      // InformarSenha
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 98);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "InformarSenha";
      this.Text = "Senha";
      this.Load += new System.EventHandler(this.InformarSenha_Load);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknTextBox txtSenha;
  }
}
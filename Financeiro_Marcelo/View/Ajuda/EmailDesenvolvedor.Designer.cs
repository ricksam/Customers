namespace Financeiro_Marcelo.View.Ajuda
{
  partial class EmailDesenvolvedor
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
      this.txtMensagem = new lib.Visual.Components.sknTextBox();
      this.cbDados = new lib.Visual.Components.sknCheckBox();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.cbDados);
      this.pnlContext.Controls.Add(this.txtMensagem);
      this.pnlContext.Controls.Add(this.sknLabel1);
      this.pnlContext.Size = new System.Drawing.Size(544, 227);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 227);
      this.pnlBottom.Size = new System.Drawing.Size(544, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(336, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(432, 8);
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 9);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(131, 13);
      this.sknLabel1.TabIndex = 0;
      this.sknLabel1.Text = "Digite aqui sua mensagem";
      // 
      // txtMensagem
      // 
      this.txtMensagem.AsDateTime = new System.DateTime(((long)(0)));
      this.txtMensagem.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtMensagem.AutoTab = true;
      this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMensagem.Location = new System.Drawing.Point(12, 25);
      this.txtMensagem.Multiline = true;
      this.txtMensagem.Name = "txtMensagem";
      this.txtMensagem.Size = new System.Drawing.Size(520, 166);
      this.txtMensagem.TabIndex = 1;
      this.txtMensagem.Text = "Mensagem";
      this.txtMensagem.TextFormat = null;
      this.txtMensagem.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // cbDados
      // 
      this.cbDados.Location = new System.Drawing.Point(12, 197);
      this.cbDados.Name = "cbDados";
      this.cbDados.Size = new System.Drawing.Size(253, 24);
      this.cbDados.TabIndex = 2;
      this.cbDados.Text = "Incluir copia dos dados";
      this.cbDados.UseVisualStyleBackColor = true;
      // 
      // EmailDesenvolvedor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(544, 272);
      this.Name = "EmailDesenvolvedor";
      this.Text = "Email ao Desenvolvedor";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknCheckBox cbDados;
    private lib.Visual.Components.sknTextBox txtMensagem;
    private lib.Visual.Components.sknLabel sknLabel1;
  }
}
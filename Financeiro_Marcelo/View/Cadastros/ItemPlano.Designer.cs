namespace Financeiro_Marcelo
{
  partial class ItemPlano
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
      this.txtDescricao = new lib.Visual.Components.sknTextBox();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.txtPrioridade = new lib.Visual.Components.sknTextBox();
      this.cbObrigaDescricao = new lib.Visual.Components.sknCheckBox();
      this.cbConferencia = new lib.Visual.Components.sknCheckBox();
      this.cbAdicionaItens = new lib.Visual.Components.sknCheckBox();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.cbAdicionaItens);
      this.pnlContext.Controls.Add(this.cbConferencia);
      this.pnlContext.Controls.Add(this.cbObrigaDescricao);
      this.pnlContext.Controls.Add(this.txtPrioridade);
      this.pnlContext.Controls.Add(this.sknLabel2);
      this.pnlContext.Controls.Add(this.txtDescricao);
      this.pnlContext.Controls.Add(this.sknLabel1);
      this.pnlContext.Size = new System.Drawing.Size(331, 231);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 231);
      this.pnlBottom.Size = new System.Drawing.Size(331, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(123, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(219, 8);
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 9);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(55, 13);
      this.sknLabel1.TabIndex = 0;
      this.sknLabel1.Text = "Descrição";
      // 
      // txtDescricao
      // 
      this.txtDescricao.AsDateTime = new System.DateTime(((long)(0)));
      this.txtDescricao.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtDescricao.AutoTab = true;
      this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDescricao.Location = new System.Drawing.Point(12, 25);
      this.txtDescricao.Name = "txtDescricao";
      this.txtDescricao.Size = new System.Drawing.Size(307, 20);
      this.txtDescricao.TabIndex = 1;
      this.txtDescricao.TextFormat = null;
      this.txtDescricao.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(12, 48);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(54, 13);
      this.sknLabel2.TabIndex = 2;
      this.sknLabel2.Text = "Prioridade";
      // 
      // txtPrioridade
      // 
      this.txtPrioridade.AsDateTime = new System.DateTime(((long)(0)));
      this.txtPrioridade.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtPrioridade.AutoTab = true;
      this.txtPrioridade.Location = new System.Drawing.Point(12, 64);
      this.txtPrioridade.Name = "txtPrioridade";
      this.txtPrioridade.Size = new System.Drawing.Size(138, 20);
      this.txtPrioridade.TabIndex = 3;
      this.txtPrioridade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtPrioridade.TextFormat = null;
      this.txtPrioridade.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // cbObrigaDescricao
      // 
      this.cbObrigaDescricao.Location = new System.Drawing.Point(12, 90);
      this.cbObrigaDescricao.Name = "cbObrigaDescricao";
      this.cbObrigaDescricao.Size = new System.Drawing.Size(307, 40);
      this.cbObrigaDescricao.TabIndex = 4;
      this.cbObrigaDescricao.Text = "Este plano de contas obriga o preenchimento do campo descrição no lançamento";
      this.cbObrigaDescricao.UseVisualStyleBackColor = true;
      // 
      // cbConferencia
      // 
      this.cbConferencia.Location = new System.Drawing.Point(12, 136);
      this.cbConferencia.Name = "cbConferencia";
      this.cbConferencia.Size = new System.Drawing.Size(307, 37);
      this.cbConferencia.TabIndex = 5;
      this.cbConferencia.Text = "Os valores lançados para este plano de contas são utilizados no cálculo da confer" +
    "ência do caixa";
      this.cbConferencia.UseVisualStyleBackColor = true;
      // 
      // cbAdicionaItens
      // 
      this.cbAdicionaItens.Location = new System.Drawing.Point(12, 179);
      this.cbAdicionaItens.Name = "cbAdicionaItens";
      this.cbAdicionaItens.Size = new System.Drawing.Size(307, 37);
      this.cbAdicionaItens.TabIndex = 6;
      this.cbAdicionaItens.Text = "Permite adicionar itens";
      this.cbAdicionaItens.UseVisualStyleBackColor = true;
      // 
      // ItemPlano
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(331, 276);
      this.Name = "ItemPlano";
      this.Text = "Plano de Contas";
      this.Load += new System.EventHandler(this.ItemPlano_Load);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknTextBox txtDescricao;
    private lib.Visual.Components.sknCheckBox cbConferencia;
    private lib.Visual.Components.sknCheckBox cbObrigaDescricao;
    private lib.Visual.Components.sknTextBox txtPrioridade;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknCheckBox cbAdicionaItens;
  }
}
namespace Financeiro_Marcelo.View
{
  partial class LancamentoItem
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
      this.Label2 = new lib.Visual.Components.sknLabel();
      this.txtQtde = new lib.Visual.Components.sknTextBox();
      this.txtTotal = new lib.Visual.Components.sknTextBox();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.txtVlrUnitario = new lib.Visual.Components.sknTextBox();
      this.sknLabel3 = new lib.Visual.Components.sknLabel();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.txtVlrUnitario);
      this.pnlContext.Controls.Add(this.sknLabel3);
      this.pnlContext.Controls.Add(this.txtTotal);
      this.pnlContext.Controls.Add(this.sknLabel2);
      this.pnlContext.Controls.Add(this.txtQtde);
      this.pnlContext.Controls.Add(this.Label2);
      this.pnlContext.Controls.Add(this.txtDescricao);
      this.pnlContext.Controls.Add(this.sknLabel1);
      this.pnlContext.Size = new System.Drawing.Size(526, 103);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 103);
      this.pnlBottom.Size = new System.Drawing.Size(526, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(318, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(414, 8);
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 9);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(93, 13);
      this.sknLabel1.TabIndex = 0;
      this.sknLabel1.Text = "Descrição do Item";
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
      this.txtDescricao.Size = new System.Drawing.Size(495, 20);
      this.txtDescricao.TabIndex = 1;
      this.txtDescricao.TextFormat = null;
      this.txtDescricao.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // Label2
      // 
      this.Label2.AutoSize = true;
      this.Label2.Location = new System.Drawing.Point(12, 48);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(30, 13);
      this.Label2.TabIndex = 2;
      this.Label2.Text = "Qtde";
      // 
      // txtQtde
      // 
      this.txtQtde.AsDateTime = new System.DateTime(((long)(0)));
      this.txtQtde.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtQtde.AutoTab = true;
      this.txtQtde.Location = new System.Drawing.Point(12, 64);
      this.txtQtde.Name = "txtQtde";
      this.txtQtde.Size = new System.Drawing.Size(161, 20);
      this.txtQtde.TabIndex = 3;
      this.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtQtde.TextFormat = "#,##0.0000";
      this.txtQtde.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // txtTotal
      // 
      this.txtTotal.AsDateTime = new System.DateTime(((long)(0)));
      this.txtTotal.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtTotal.AutoTab = true;
      this.txtTotal.Location = new System.Drawing.Point(179, 64);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.Size = new System.Drawing.Size(161, 20);
      this.txtTotal.TabIndex = 5;
      this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtTotal.TextFormat = "#,##0.00";
      this.txtTotal.TextType = lib.Visual.Components.enmTextType.Decimal;
      this.txtTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotal_KeyDown);
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(179, 48);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(104, 13);
      this.sknLabel2.TabIndex = 4;
      this.sknLabel2.Text = "Total (F2 Expressão)";
      // 
      // txtVlrUnitario
      // 
      this.txtVlrUnitario.AsDateTime = new System.DateTime(((long)(0)));
      this.txtVlrUnitario.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtVlrUnitario.AutoTab = true;
      this.txtVlrUnitario.Enabled = false;
      this.txtVlrUnitario.Location = new System.Drawing.Point(346, 64);
      this.txtVlrUnitario.Name = "txtVlrUnitario";
      this.txtVlrUnitario.Size = new System.Drawing.Size(161, 20);
      this.txtVlrUnitario.TabIndex = 7;
      this.txtVlrUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtVlrUnitario.TextFormat = "#,##0.00";
      this.txtVlrUnitario.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // sknLabel3
      // 
      this.sknLabel3.AutoSize = true;
      this.sknLabel3.Location = new System.Drawing.Point(346, 48);
      this.sknLabel3.Name = "sknLabel3";
      this.sknLabel3.Size = new System.Drawing.Size(61, 13);
      this.sknLabel3.TabIndex = 6;
      this.sknLabel3.Text = "Vlr. Unitário";
      // 
      // LancamentoItem
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(526, 148);
      this.Name = "LancamentoItem";
      this.Text = "Item";
      this.Load += new System.EventHandler(this.LancamentoItem_Load);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknTextBox txtDescricao;
    private lib.Visual.Components.sknTextBox txtVlrUnitario;
    private lib.Visual.Components.sknLabel sknLabel3;
    private lib.Visual.Components.sknTextBox txtTotal;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknTextBox txtQtde;
    private lib.Visual.Components.sknLabel Label2;
  }
}
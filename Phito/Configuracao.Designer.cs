namespace Phito
{
  partial class Configuracao
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtLoja = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtGuiche = new lib.Visual.Components.sknTextBox();
      this.txtPortaImpressora = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtWebService = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.txtWebService);
      this.pnlContext.Controls.Add(this.label4);
      this.pnlContext.Controls.Add(this.txtPortaImpressora);
      this.pnlContext.Controls.Add(this.label3);
      this.pnlContext.Controls.Add(this.txtGuiche);
      this.pnlContext.Controls.Add(this.label2);
      this.pnlContext.Controls.Add(this.txtLoja);
      this.pnlContext.Controls.Add(this.label1);
      this.pnlContext.Size = new System.Drawing.Size(384, 187);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 187);
      this.pnlBottom.Size = new System.Drawing.Size(384, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(186, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(282, 8);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(27, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Loja";
      // 
      // txtLoja
      // 
      this.txtLoja.Location = new System.Drawing.Point(12, 25);
      this.txtLoja.Name = "txtLoja";
      this.txtLoja.Size = new System.Drawing.Size(360, 20);
      this.txtLoja.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 87);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Guiche";
      // 
      // txtGuiche
      // 
      this.txtGuiche.AsDateTime = new System.DateTime(((long)(0)));
      this.txtGuiche.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtGuiche.AutoTab = true;
      this.txtGuiche.Location = new System.Drawing.Point(12, 103);
      this.txtGuiche.Name = "txtGuiche";
      this.txtGuiche.Size = new System.Drawing.Size(100, 20);
      this.txtGuiche.TabIndex = 6;
      this.txtGuiche.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtGuiche.TextFormat = null;
      this.txtGuiche.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // txtPortaImpressora
      // 
      this.txtPortaImpressora.Location = new System.Drawing.Point(12, 142);
      this.txtPortaImpressora.Name = "txtPortaImpressora";
      this.txtPortaImpressora.Size = new System.Drawing.Size(100, 20);
      this.txtPortaImpressora.TabIndex = 0;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 126);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(86, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Porta Impressora";
      // 
      // txtWebService
      // 
      this.txtWebService.Location = new System.Drawing.Point(12, 64);
      this.txtWebService.Name = "txtWebService";
      this.txtWebService.Size = new System.Drawing.Size(360, 20);
      this.txtWebService.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 48);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(69, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Web Service";
      // 
      // Configuracao
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(384, 232);
      this.Name = "Configuracao";
      this.Text = "Configuracao";
      this.Load += new System.EventHandler(this.Configuracao_Load);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtLoja;
    private lib.Visual.Components.sknTextBox txtGuiche;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtPortaImpressora;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtWebService;
    private System.Windows.Forms.Label label4;
  }
}
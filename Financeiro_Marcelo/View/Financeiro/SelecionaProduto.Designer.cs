namespace Financeiro_Marcelo.View
{
  partial class SelecionaProduto
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
      this.lstProdutos = new lib.Visual.Components.sknListBox();
      this.SuspendLayout();
      // 
      // lstProdutos
      // 
      this.lstProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lstProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstProdutos.FormattingEnabled = true;
      this.lstProdutos.ItemHeight = 25;
      this.lstProdutos.Location = new System.Drawing.Point(0, 0);
      this.lstProdutos.Name = "lstProdutos";
      this.lstProdutos.Size = new System.Drawing.Size(484, 262);
      this.lstProdutos.TabIndex = 0;
      this.lstProdutos.DoubleClick += new System.EventHandler(this.lstProdutos_DoubleClick);
      this.lstProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstProdutos_KeyDown);
      // 
      // SelecionaProduto
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 262);
      this.Controls.Add(this.lstProdutos);
      this.Name = "SelecionaProduto";
      this.Text = "Produtos";
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknListBox lstProdutos;
  }
}
namespace Financeiro_Marcelo.Fechamento
{
  partial class UltimosBalancos
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
      this.lstBalancos = new lib.Visual.Components.sknGrid();
      this.btnSair = new lib.Visual.Components.sknButton();
      this.btnApagar = new lib.Visual.Components.sknButton();
      ((System.ComponentModel.ISupportInitialize)(this.lstBalancos)).BeginInit();
      this.SuspendLayout();
      // 
      // lstBalancos
      // 
      this.lstBalancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.lstBalancos.Location = new System.Drawing.Point(12, 12);
      this.lstBalancos.Name = "lstBalancos";
      this.lstBalancos.Size = new System.Drawing.Size(575, 238);
      this.lstBalancos.TabIndex = 0;
      // 
      // btnSair
      // 
      this.btnSair.Location = new System.Drawing.Point(512, 256);
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(75, 23);
      this.btnSair.TabIndex = 1;
      this.btnSair.Text = "Sair";
      this.btnSair.UseVisualStyleBackColor = true;
      this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
      // 
      // btnApagar
      // 
      this.btnApagar.Location = new System.Drawing.Point(12, 256);
      this.btnApagar.Name = "btnApagar";
      this.btnApagar.Size = new System.Drawing.Size(75, 23);
      this.btnApagar.TabIndex = 2;
      this.btnApagar.Text = "Apagar";
      this.btnApagar.UseVisualStyleBackColor = true;
      this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
      // 
      // UltimosBalancos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(599, 293);
      this.Controls.Add(this.btnApagar);
      this.Controls.Add(this.btnSair);
      this.Controls.Add(this.lstBalancos);
      this.Name = "UltimosBalancos";
      this.Text = "Ultimos Balanços";
      this.Load += new System.EventHandler(this.UltimosBalancos_Load);
      ((System.ComponentModel.ISupportInitialize)(this.lstBalancos)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknGrid lstBalancos;
    private lib.Visual.Components.sknButton btnSair;
    private lib.Visual.Components.sknButton btnApagar;
  }
}
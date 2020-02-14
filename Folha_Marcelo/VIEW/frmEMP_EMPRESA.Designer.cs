namespace Folha_Marcelo
{
  partial class frmEMP_EMPRESA
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
      this.lblEMP_NOME = new lib.Visual.Components.sknLabel();
      this.txtEMP_NOME = new lib.Visual.Components.sknTextBox();
      this.cbInativo = new System.Windows.Forms.CheckBox();
      this.pnlEdit.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlEdit
      // 
      this.pnlEdit.Controls.Add(this.cbInativo);
      this.pnlEdit.Controls.Add(this.lblEMP_NOME);
      this.pnlEdit.Controls.Add(this.txtEMP_NOME);
      this.pnlEdit.Size = new System.Drawing.Size(475, 75);
      // 
      // lblEMP_NOME
      // 
      this.lblEMP_NOME.AutoSize = true;
      this.lblEMP_NOME.Location = new System.Drawing.Point(12, 3);
      this.lblEMP_NOME.Name = "lblEMP_NOME";
      this.lblEMP_NOME.Size = new System.Drawing.Size(35, 13);
      this.lblEMP_NOME.TabIndex = 1;
      this.lblEMP_NOME.Text = "Nome";
      // 
      // txtEMP_NOME
      // 
      this.txtEMP_NOME.AsDateTime = new System.DateTime(((long)(0)));
      this.txtEMP_NOME.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtEMP_NOME.AutoTab = true;
      this.txtEMP_NOME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtEMP_NOME.Location = new System.Drawing.Point(12, 19);
      this.txtEMP_NOME.Name = "txtEMP_NOME";
      this.txtEMP_NOME.Size = new System.Drawing.Size(450, 20);
      this.txtEMP_NOME.TabIndex = 2;
      this.txtEMP_NOME.TextFormat = null;
      this.txtEMP_NOME.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // cbInativo
      // 
      this.cbInativo.AutoSize = true;
      this.cbInativo.Location = new System.Drawing.Point(12, 45);
      this.cbInativo.Name = "cbInativo";
      this.cbInativo.Size = new System.Drawing.Size(58, 17);
      this.cbInativo.TabIndex = 3;
      this.cbInativo.Text = "Inativo";
      this.cbInativo.UseVisualStyleBackColor = true;
      // 
      // frmEMP_EMPRESA
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(475, 155);
      this.Name = "frmEMP_EMPRESA";
      this.Text = "Cadastro de lojas";
      this.Search += new lib.Visual.Forms.FormSearch.OnSearch_Handle(this.Form_Search);
      this.pnlEdit.ResumeLayout(false);
      this.pnlEdit.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel lblEMP_NOME;
    private lib.Visual.Components.sknTextBox txtEMP_NOME;
    private System.Windows.Forms.CheckBox cbInativo;
  }
}

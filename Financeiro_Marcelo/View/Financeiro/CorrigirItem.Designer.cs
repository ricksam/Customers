namespace Financeiro_Marcelo.View
{
  partial class CorrigirItem
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
      this.cmbItem = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.cmbCorrigir = new System.Windows.Forms.ComboBox();
      this.btnCorrigir = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // cmbItem
      // 
      this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbItem.FormattingEnabled = true;
      this.cmbItem.Location = new System.Drawing.Point(12, 25);
      this.cmbItem.Name = "cmbItem";
      this.cmbItem.Size = new System.Drawing.Size(395, 21);
      this.cmbItem.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(27, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Item";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 49);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(63, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Corrigir para";
      // 
      // cmbCorrigir
      // 
      this.cmbCorrigir.FormattingEnabled = true;
      this.cmbCorrigir.Location = new System.Drawing.Point(12, 65);
      this.cmbCorrigir.Name = "cmbCorrigir";
      this.cmbCorrigir.Size = new System.Drawing.Size(395, 21);
      this.cmbCorrigir.TabIndex = 2;
      // 
      // btnCorrigir
      // 
      this.btnCorrigir.Location = new System.Drawing.Point(12, 92);
      this.btnCorrigir.Name = "btnCorrigir";
      this.btnCorrigir.Size = new System.Drawing.Size(75, 23);
      this.btnCorrigir.TabIndex = 4;
      this.btnCorrigir.Text = "Corrigir";
      this.btnCorrigir.UseVisualStyleBackColor = true;
      this.btnCorrigir.Click += new System.EventHandler(this.btnCorrigir_Click);
      // 
      // CorrigirItem
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(419, 129);
      this.Controls.Add(this.btnCorrigir);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.cmbCorrigir);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cmbItem);
      this.Name = "CorrigirItem";
      this.Text = "CorrigirItem";
      this.Load += new System.EventHandler(this.CorrigirItem_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbItem;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cmbCorrigir;
    private System.Windows.Forms.Button btnCorrigir;
  }
}
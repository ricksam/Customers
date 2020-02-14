namespace RckEventos
{
  partial class EmailCobrança
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
      this.sknButton1 = new lib.Visual.Components.sknButton();
      this.SuspendLayout();
      // 
      // sknButton1
      // 
      this.sknButton1.Location = new System.Drawing.Point(193, 79);
      this.sknButton1.Name = "sknButton1";
      this.sknButton1.Size = new System.Drawing.Size(75, 23);
      this.sknButton1.TabIndex = 0;
      this.sknButton1.Text = "sknButton1";
      this.sknButton1.UseVisualStyleBackColor = true;
      this.sknButton1.Click += new System.EventHandler(this.sknButton1_Click);
      // 
      // EmailCobrança
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 262);
      this.Controls.Add(this.sknButton1);
      this.Name = "EmailCobrança";
      this.Text = "EmailCobrança";
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknButton sknButton1;
  }
}
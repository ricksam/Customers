namespace TestePostData
{
  partial class SendGCM
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
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.txtRegistro = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Dock = System.Windows.Forms.DockStyle.Top;
      this.button1.Location = new System.Drawing.Point(0, 20);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(464, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox1
      // 
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox1.Location = new System.Drawing.Point(0, 43);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(464, 219);
      this.textBox1.TabIndex = 1;
      // 
      // txtRegistro
      // 
      this.txtRegistro.Dock = System.Windows.Forms.DockStyle.Top;
      this.txtRegistro.Location = new System.Drawing.Point(0, 0);
      this.txtRegistro.Name = "txtRegistro";
      this.txtRegistro.Size = new System.Drawing.Size(464, 20);
      this.txtRegistro.TabIndex = 2;
      // 
      // SendGCM
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(464, 262);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.txtRegistro);
      this.Name = "SendGCM";
      this.Text = "SendGCM";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox txtRegistro;
  }
}
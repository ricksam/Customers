namespace TestePostData
{
  partial class Form1
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
      this.txtLink = new lib.Visual.Components.sknTextBox();
      this.txtPost = new lib.Visual.Components.sknTextBox();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.sknButton1 = new lib.Visual.Components.sknButton();
      this.txtResposta = new lib.Visual.Components.sknTextBox();
      this.sknLabel3 = new lib.Visual.Components.sknLabel();
      this.SuspendLayout();
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 9);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(27, 13);
      this.sknLabel1.TabIndex = 0;
      this.sknLabel1.Text = "Link";
      // 
      // txtLink
      // 
      this.txtLink.AsDateTime = new System.DateTime(((long)(0)));
      this.txtLink.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtLink.AutoTab = true;
      this.txtLink.Location = new System.Drawing.Point(12, 25);
      this.txtLink.Name = "txtLink";
      this.txtLink.Size = new System.Drawing.Size(847, 20);
      this.txtLink.TabIndex = 1;
      this.txtLink.TextFormat = null;
      this.txtLink.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // txtPost
      // 
      this.txtPost.AsDateTime = new System.DateTime(((long)(0)));
      this.txtPost.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtPost.AutoTab = true;
      this.txtPost.Location = new System.Drawing.Point(12, 64);
      this.txtPost.Multiline = true;
      this.txtPost.Name = "txtPost";
      this.txtPost.Size = new System.Drawing.Size(847, 92);
      this.txtPost.TabIndex = 3;
      this.txtPost.TextFormat = null;
      this.txtPost.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(12, 48);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(28, 13);
      this.sknLabel2.TabIndex = 2;
      this.sknLabel2.Text = "Post";
      // 
      // sknButton1
      // 
      this.sknButton1.Location = new System.Drawing.Point(12, 162);
      this.sknButton1.Name = "sknButton1";
      this.sknButton1.Size = new System.Drawing.Size(75, 23);
      this.sknButton1.TabIndex = 4;
      this.sknButton1.Text = "Enviar";
      this.sknButton1.UseVisualStyleBackColor = true;
      this.sknButton1.Click += new System.EventHandler(this.sknButton1_Click);
      // 
      // txtResposta
      // 
      this.txtResposta.AsDateTime = new System.DateTime(((long)(0)));
      this.txtResposta.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtResposta.AutoTab = true;
      this.txtResposta.Location = new System.Drawing.Point(12, 204);
      this.txtResposta.Multiline = true;
      this.txtResposta.Name = "txtResposta";
      this.txtResposta.Size = new System.Drawing.Size(847, 92);
      this.txtResposta.TabIndex = 6;
      this.txtResposta.TextFormat = null;
      this.txtResposta.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel3
      // 
      this.sknLabel3.AutoSize = true;
      this.sknLabel3.Location = new System.Drawing.Point(12, 188);
      this.sknLabel3.Name = "sknLabel3";
      this.sknLabel3.Size = new System.Drawing.Size(52, 13);
      this.sknLabel3.TabIndex = 5;
      this.sknLabel3.Text = "Resposta";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(881, 314);
      this.Controls.Add(this.txtResposta);
      this.Controls.Add(this.sknLabel3);
      this.Controls.Add(this.sknButton1);
      this.Controls.Add(this.txtPost);
      this.Controls.Add(this.sknLabel2);
      this.Controls.Add(this.txtLink);
      this.Controls.Add(this.sknLabel1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknTextBox txtLink;
    private lib.Visual.Components.sknTextBox txtPost;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknButton sknButton1;
    private lib.Visual.Components.sknTextBox txtResposta;
    private lib.Visual.Components.sknLabel sknLabel3;
  }
}


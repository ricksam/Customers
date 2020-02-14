namespace Phito
{
  partial class Senha
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
      this.btnNormal = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtSenha = new System.Windows.Forms.TextBox();
      this.btnPreferencial = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnNormal
      // 
      this.btnNormal.BackgroundImage = global::Phito.Properties.Resources.botao_fundo;
      this.btnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnNormal.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
      this.btnNormal.ForeColor = System.Drawing.Color.White;
      this.btnNormal.Location = new System.Drawing.Point(61, 159);
      this.btnNormal.Name = "btnNormal";
      this.btnNormal.Size = new System.Drawing.Size(500, 100);
      this.btnNormal.TabIndex = 2;
      this.btnNormal.Text = "Normal";
      this.btnNormal.UseVisualStyleBackColor = true;
      this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(54, 69);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(223, 37);
      this.label1.TabIndex = 0;
      this.label1.Text = "Senha Cartao";
      // 
      // txtSenha
      // 
      this.txtSenha.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
      this.txtSenha.Location = new System.Drawing.Point(61, 109);
      this.txtSenha.Name = "txtSenha";
      this.txtSenha.Size = new System.Drawing.Size(500, 44);
      this.txtSenha.TabIndex = 1;
      this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
      // 
      // btnPreferencial
      // 
      this.btnPreferencial.BackgroundImage = global::Phito.Properties.Resources.botao_fundo;
      this.btnPreferencial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnPreferencial.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
      this.btnPreferencial.ForeColor = System.Drawing.Color.White;
      this.btnPreferencial.Location = new System.Drawing.Point(61, 265);
      this.btnPreferencial.Name = "btnPreferencial";
      this.btnPreferencial.Size = new System.Drawing.Size(500, 100);
      this.btnPreferencial.TabIndex = 3;
      this.btnPreferencial.Text = "Preferencial";
      this.btnPreferencial.UseVisualStyleBackColor = true;
      this.btnPreferencial.Click += new System.EventHandler(this.btnPreferencial_Click);
      // 
      // Senha
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::Phito.Properties.Resources.fundo;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(624, 442);
      this.Controls.Add(this.btnPreferencial);
      this.Controls.Add(this.txtSenha);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnNormal);
      this.Name = "Senha";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Senha";
      this.Load += new System.EventHandler(this.Senha_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnNormal;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtSenha;
    private System.Windows.Forms.Button btnPreferencial;
  }
}
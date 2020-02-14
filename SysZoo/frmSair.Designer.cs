namespace SysZoo
{
  partial class frmSair
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSair));
      this.btnEncerrarMovimento = new System.Windows.Forms.Button();
      this.btnFecharPrograma = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblWindowTitle
      // 
      this.lblWindowTitle.Text = "Sair";
      // 
      // btnWindowClose
      // 
      this.btnWindowClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowClose.BackgroundImage")));
      this.btnWindowClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
      // 
      // btnWindowMinimize
      // 
      this.btnWindowMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowMinimize.BackgroundImage")));
      this.btnWindowMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      // 
      // btnEncerrarMovimento
      // 
      this.btnEncerrarMovimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnEncerrarMovimento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnEncerrarMovimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEncerrarMovimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEncerrarMovimento.ForeColor = System.Drawing.Color.White;
      this.btnEncerrarMovimento.Location = new System.Drawing.Point(12, 33);
      this.btnEncerrarMovimento.Name = "btnEncerrarMovimento";
      this.btnEncerrarMovimento.Size = new System.Drawing.Size(260, 38);
      this.btnEncerrarMovimento.TabIndex = 4;
      this.btnEncerrarMovimento.Text = "&Encerrar este movimento";
      this.btnEncerrarMovimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnEncerrarMovimento.UseVisualStyleBackColor = false;
      this.btnEncerrarMovimento.Click += new System.EventHandler(this.btnEncerrarMovimento_Click);
      // 
      // btnFecharPrograma
      // 
      this.btnFecharPrograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnFecharPrograma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnFecharPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnFecharPrograma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnFecharPrograma.ForeColor = System.Drawing.Color.White;
      this.btnFecharPrograma.Location = new System.Drawing.Point(12, 77);
      this.btnFecharPrograma.Name = "btnFecharPrograma";
      this.btnFecharPrograma.Size = new System.Drawing.Size(260, 38);
      this.btnFecharPrograma.TabIndex = 5;
      this.btnFecharPrograma.Text = "&Fechar o programa";
      this.btnFecharPrograma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnFecharPrograma.UseVisualStyleBackColor = false;
      this.btnFecharPrograma.Click += new System.EventHandler(this.btnFecharPrograma_Click);
      // 
      // frmSair
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 127);
      this.Controls.Add(this.btnFecharPrograma);
      this.Controls.Add(this.btnEncerrarMovimento);
      this.Name = "frmSair";
      this.Text = "frmSair";
      this.Controls.SetChildIndex(this.lblWindowTitle, 0);
      this.Controls.SetChildIndex(this.btnWindowClose, 0);
      this.Controls.SetChildIndex(this.btnWindowMinimize, 0);
      this.Controls.SetChildIndex(this.btnEncerrarMovimento, 0);
      this.Controls.SetChildIndex(this.btnFecharPrograma, 0);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnEncerrarMovimento;
    private System.Windows.Forms.Button btnFecharPrograma;
  }
}
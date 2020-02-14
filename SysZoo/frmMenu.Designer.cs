namespace SysZoo
{
  partial class frmMenu
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerencia));
      this.btnSair = new System.Windows.Forms.Button();
      this.btnSangria = new System.Windows.Forms.Button();
      this.btnSuprimento = new System.Windows.Forms.Button();
      this.btnConfiguracao = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblWindowTitle
      // 
      this.lblWindowTitle.Size = new System.Drawing.Size(338, 30);
      this.lblWindowTitle.Text = "Menu";
      // 
      // btnWindowClose
      // 
      this.btnWindowClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowClose.BackgroundImage")));
      this.btnWindowClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
      this.btnWindowClose.Location = new System.Drawing.Point(294, 4);
      // 
      // btnWindowMinimize
      // 
      this.btnWindowMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowMinimize.BackgroundImage")));
      this.btnWindowMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnWindowMinimize.Location = new System.Drawing.Point(258, 4);
      // 
      // btnSair
      // 
      this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSair.ForeColor = System.Drawing.Color.White;
      this.btnSair.Location = new System.Drawing.Point(12, 165);
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(315, 38);
      this.btnSair.TabIndex = 9;
      this.btnSair.Text = "&Sair";
      this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSair.UseVisualStyleBackColor = false;
      this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
      // 
      // btnSangria
      // 
      this.btnSangria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnSangria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnSangria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSangria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSangria.ForeColor = System.Drawing.Color.White;
      this.btnSangria.Location = new System.Drawing.Point(12, 77);
      this.btnSangria.Name = "btnSangria";
      this.btnSangria.Size = new System.Drawing.Size(315, 38);
      this.btnSangria.TabIndex = 7;
      this.btnSangria.Text = "S&angria";
      this.btnSangria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSangria.UseVisualStyleBackColor = false;
      this.btnSangria.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnSuprimento
      // 
      this.btnSuprimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnSuprimento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnSuprimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSuprimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSuprimento.ForeColor = System.Drawing.Color.White;
      this.btnSuprimento.Location = new System.Drawing.Point(12, 121);
      this.btnSuprimento.Name = "btnSuprimento";
      this.btnSuprimento.Size = new System.Drawing.Size(315, 38);
      this.btnSuprimento.TabIndex = 8;
      this.btnSuprimento.Text = "S&uprimento";
      this.btnSuprimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSuprimento.UseVisualStyleBackColor = false;
      this.btnSuprimento.Click += new System.EventHandler(this.btnSuprimento_Click);
      // 
      // btnConfiguracao
      // 
      this.btnConfiguracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnConfiguracao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnConfiguracao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnConfiguracao.ForeColor = System.Drawing.Color.White;
      this.btnConfiguracao.Location = new System.Drawing.Point(12, 33);
      this.btnConfiguracao.Name = "btnConfiguracao";
      this.btnConfiguracao.Size = new System.Drawing.Size(315, 38);
      this.btnConfiguracao.TabIndex = 3;
      this.btnConfiguracao.Text = "&Configuração";
      this.btnConfiguracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnConfiguracao.UseVisualStyleBackColor = false;
      this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
      // 
      // frmGerencia
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(338, 216);
      this.Controls.Add(this.btnConfiguracao);
      this.Controls.Add(this.btnSuprimento);
      this.Controls.Add(this.btnSangria);
      this.Controls.Add(this.btnSair);
      this.Name = "frmGerencia";
      this.Text = "Menu";
      this.Controls.SetChildIndex(this.lblWindowTitle, 0);
      this.Controls.SetChildIndex(this.btnWindowClose, 0);
      this.Controls.SetChildIndex(this.btnWindowMinimize, 0);
      this.Controls.SetChildIndex(this.btnSair, 0);
      this.Controls.SetChildIndex(this.btnSangria, 0);
      this.Controls.SetChildIndex(this.btnSuprimento, 0);
      this.Controls.SetChildIndex(this.btnConfiguracao, 0);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnSair;
    private System.Windows.Forms.Button btnSangria;
    private System.Windows.Forms.Button btnSuprimento;
    private System.Windows.Forms.Button btnConfiguracao;

  }
}
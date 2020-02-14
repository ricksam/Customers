namespace SysZoo
{
  partial class frmQuestion
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestion));
      this.btnSim = new System.Windows.Forms.Button();
      this.btnNao = new System.Windows.Forms.Button();
      this.lblMensagem = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblWindowTitle
      // 
      this.lblWindowTitle.Size = new System.Drawing.Size(500, 30);
      this.lblWindowTitle.Text = "Atenção";
      // 
      // btnWindowClose
      // 
      this.btnWindowClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowClose.BackgroundImage")));
      this.btnWindowClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
      this.btnWindowClose.Location = new System.Drawing.Point(458, 6);
      // 
      // btnWindowMinimize
      // 
      this.btnWindowMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowMinimize.BackgroundImage")));
      this.btnWindowMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnWindowMinimize.Location = new System.Drawing.Point(422, 6);
      // 
      // btnSim
      // 
      this.btnSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnSim.DialogResult = System.Windows.Forms.DialogResult.Yes;
      this.btnSim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSim.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSim.ForeColor = System.Drawing.Color.White;
      this.btnSim.Location = new System.Drawing.Point(111, 238);
      this.btnSim.Name = "btnSim";
      this.btnSim.Size = new System.Drawing.Size(134, 50);
      this.btnSim.TabIndex = 4;
      this.btnSim.Text = "&Sim";
      this.btnSim.UseVisualStyleBackColor = false;
      // 
      // btnNao
      // 
      this.btnNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnNao.DialogResult = System.Windows.Forms.DialogResult.No;
      this.btnNao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnNao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnNao.ForeColor = System.Drawing.Color.White;
      this.btnNao.Location = new System.Drawing.Point(251, 238);
      this.btnNao.Name = "btnNao";
      this.btnNao.Size = new System.Drawing.Size(134, 50);
      this.btnNao.TabIndex = 5;
      this.btnNao.Text = "&Não";
      this.btnNao.UseVisualStyleBackColor = false;
      // 
      // lblMensagem
      // 
      this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
      this.lblMensagem.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblMensagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMensagem.ForeColor = System.Drawing.Color.Black;
      this.lblMensagem.Location = new System.Drawing.Point(0, 0);
      this.lblMensagem.Name = "lblMensagem";
      this.lblMensagem.Padding = new System.Windows.Forms.Padding(5);
      this.lblMensagem.Size = new System.Drawing.Size(500, 300);
      this.lblMensagem.TabIndex = 3;
      this.lblMensagem.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
      this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // frmQuestion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(500, 300);
      this.Controls.Add(this.btnNao);
      this.Controls.Add(this.btnSim);
      this.Controls.Add(this.lblMensagem);
      this.Name = "frmQuestion";
      this.Text = "frmQuestion";
      this.Load += new System.EventHandler(this.frmQuestion_Load);
      this.Controls.SetChildIndex(this.lblMensagem, 0);
      this.Controls.SetChildIndex(this.lblWindowTitle, 0);
      this.Controls.SetChildIndex(this.btnWindowClose, 0);
      this.Controls.SetChildIndex(this.btnWindowMinimize, 0);
      this.Controls.SetChildIndex(this.btnSim, 0);
      this.Controls.SetChildIndex(this.btnNao, 0);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnSim;
    private System.Windows.Forms.Button btnNao;
    private System.Windows.Forms.Label lblMensagem;
  }
}
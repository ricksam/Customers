namespace SysZoo
{
  partial class frmValor
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValor));
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.lblInfo = new System.Windows.Forms.Label();
      this.txtValor = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lblWindowTitle
      // 
      this.lblWindowTitle.TabIndex = 0;
      this.lblWindowTitle.Text = "Atenção";
      // 
      // btnWindowClose
      // 
      this.btnWindowClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowClose.BackgroundImage")));
      this.btnWindowClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
      this.btnWindowClose.TabIndex = 2;
      // 
      // btnWindowMinimize
      // 
      this.btnWindowMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowMinimize.BackgroundImage")));
      this.btnWindowMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnWindowMinimize.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.Color.White;
      this.button1.Location = new System.Drawing.Point(12, 93);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(128, 38);
      this.button1.TabIndex = 5;
      this.button1.Text = "Confirmar";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.ForeColor = System.Drawing.Color.White;
      this.button2.Location = new System.Drawing.Point(149, 93);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(123, 38);
      this.button2.TabIndex = 6;
      this.button2.Text = "Sair";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // lblInfo
      // 
      this.lblInfo.AutoSize = true;
      this.lblInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblInfo.Location = new System.Drawing.Point(12, 40);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(44, 18);
      this.lblInfo.TabIndex = 3;
      this.lblInfo.Text = "Valor";
      // 
      // txtValor
      // 
      this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtValor.Location = new System.Drawing.Point(12, 61);
      this.txtValor.Name = "txtValor";
      this.txtValor.Size = new System.Drawing.Size(260, 26);
      this.txtValor.TabIndex = 4;
      // 
      // frmValor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 144);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.txtValor);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "frmValor";
      this.Text = "frmSenha";
      this.Controls.SetChildIndex(this.lblWindowTitle, 0);
      this.Controls.SetChildIndex(this.btnWindowClose, 0);
      this.Controls.SetChildIndex(this.btnWindowMinimize, 0);
      this.Controls.SetChildIndex(this.button1, 0);
      this.Controls.SetChildIndex(this.button2, 0);
      this.Controls.SetChildIndex(this.txtValor, 0);
      this.Controls.SetChildIndex(this.lblInfo, 0);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label lblInfo;
    private System.Windows.Forms.TextBox txtValor;
  }
}
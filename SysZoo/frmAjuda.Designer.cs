namespace SysZoo
{
  partial class frmAjuda
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjuda));
      this.btnSuporte = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblWindowTitle
      // 
      this.lblWindowTitle.Text = "Ajuda";
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
      // btnSuporte
      // 
      this.btnSuporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnSuporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnSuporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSuporte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSuporte.ForeColor = System.Drawing.Color.White;
      this.btnSuporte.Location = new System.Drawing.Point(12, 230);
      this.btnSuporte.Name = "btnSuporte";
      this.btnSuporte.Size = new System.Drawing.Size(260, 38);
      this.btnSuporte.TabIndex = 10;
      this.btnSuporte.Text = "Solicitar Suporte";
      this.btnSuporte.UseVisualStyleBackColor = false;
      this.btnSuporte.Click += new System.EventHandler(this.btnSuporte_Click);
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 39);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(260, 188);
      this.label1.TabIndex = 11;
      this.label1.Text = resources.GetString("label1.Text");
      // 
      // frmAjuda
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 281);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnSuporte);
      this.Name = "frmAjuda";
      this.Text = "frmAjuda";
      this.Controls.SetChildIndex(this.lblWindowTitle, 0);
      this.Controls.SetChildIndex(this.btnWindowClose, 0);
      this.Controls.SetChildIndex(this.btnWindowMinimize, 0);
      this.Controls.SetChildIndex(this.btnSuporte, 0);
      this.Controls.SetChildIndex(this.label1, 0);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnSuporte;
    private System.Windows.Forms.Label label1;
  }
}
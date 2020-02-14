namespace ControlePortarias
{
  partial class frmCamera
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCamera));
      this.label1 = new System.Windows.Forms.Label();
      this.imgCamera = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.label1.ForeColor = System.Drawing.Color.Yellow;
      this.label1.Location = new System.Drawing.Point(0, 480);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(640, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Pressione [ENTER] para salvar a imagem";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // imgCamera
      // 
      this.imgCamera.Dock = System.Windows.Forms.DockStyle.Fill;
      this.imgCamera.Location = new System.Drawing.Point(0, 0);
      this.imgCamera.Name = "imgCamera";
      this.imgCamera.Size = new System.Drawing.Size(640, 480);
      this.imgCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.imgCamera.TabIndex = 0;
      this.imgCamera.TabStop = false;
      // 
      // frmCamera
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.ClientSize = new System.Drawing.Size(640, 493);
      this.Controls.Add(this.imgCamera);
      this.Controls.Add(this.label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmCamera";
      this.Text = "Camera";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCamera_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox imgCamera;
    private System.Windows.Forms.Label label1;
  }
}
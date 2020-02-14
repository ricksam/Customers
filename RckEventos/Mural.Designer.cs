namespace RckEventos
{
  partial class Mural
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
      this.components = new System.ComponentModel.Container();
      this.imgFoto = new System.Windows.Forms.PictureBox();
      this.tmrFoto = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
      this.SuspendLayout();
      // 
      // imgFoto
      // 
      this.imgFoto.Dock = System.Windows.Forms.DockStyle.Fill;
      this.imgFoto.Location = new System.Drawing.Point(0, 0);
      this.imgFoto.Name = "imgFoto";
      this.imgFoto.Size = new System.Drawing.Size(300, 300);
      this.imgFoto.TabIndex = 0;
      this.imgFoto.TabStop = false;
      this.imgFoto.Paint += new System.Windows.Forms.PaintEventHandler(this.imgFoto_Paint);
      this.imgFoto.DoubleClick += new System.EventHandler(this.imgFoto_DoubleClick);
      // 
      // tmrFoto
      // 
      this.tmrFoto.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Mural
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(300, 300);
      this.Controls.Add(this.imgFoto);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Mural";
      this.Text = "Mural";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.Mural_Load);
      ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox imgFoto;
    private System.Windows.Forms.Timer tmrFoto;
  }
}
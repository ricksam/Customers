namespace Phito
{
  partial class Painel
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Painel));
      this.pnlDisplay = new System.Windows.Forms.Panel();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.pnlAnteriores = new System.Windows.Forms.Panel();
      this.label5 = new System.Windows.Forms.Label();
      this.lblGuiche = new System.Windows.Forms.Label();
      this.lblSenha = new System.Windows.Forms.Label();
      this.lblNome = new System.Windows.Forms.Label();
      this.imgFoto = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.tmrDisplay = new System.Windows.Forms.Timer(this.components);
      this.pnlDisplay.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlDisplay
      // 
      this.pnlDisplay.BackColor = System.Drawing.Color.Transparent;
      this.pnlDisplay.Controls.Add(this.pictureBox3);
      this.pnlDisplay.Controls.Add(this.pnlAnteriores);
      this.pnlDisplay.Controls.Add(this.label5);
      this.pnlDisplay.Controls.Add(this.lblGuiche);
      this.pnlDisplay.Controls.Add(this.lblSenha);
      this.pnlDisplay.Controls.Add(this.lblNome);
      this.pnlDisplay.Controls.Add(this.imgFoto);
      this.pnlDisplay.Controls.Add(this.pictureBox1);
      this.pnlDisplay.Location = new System.Drawing.Point(1, 1);
      this.pnlDisplay.Name = "pnlDisplay";
      this.pnlDisplay.Size = new System.Drawing.Size(1024, 720);
      this.pnlDisplay.TabIndex = 2;
      // 
      // pictureBox3
      // 
      this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
      this.pictureBox3.Location = new System.Drawing.Point(11, 638);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(390, 69);
      this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox3.TabIndex = 18;
      this.pictureBox3.TabStop = false;
      // 
      // pnlAnteriores
      // 
      this.pnlAnteriores.Location = new System.Drawing.Point(662, 312);
      this.pnlAnteriores.Name = "pnlAnteriores";
      this.pnlAnteriores.Size = new System.Drawing.Size(349, 395);
      this.pnlAnteriores.TabIndex = 17;
      // 
      // label5
      // 
      this.label5.BackColor = System.Drawing.Color.Transparent;
      this.label5.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(652, 260);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(359, 66);
      this.label5.TabIndex = 16;
      this.label5.Text = "Anteriores";
      // 
      // lblGuiche
      // 
      this.lblGuiche.BackColor = System.Drawing.Color.Transparent;
      this.lblGuiche.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblGuiche.Location = new System.Drawing.Point(266, 460);
      this.lblGuiche.Name = "lblGuiche";
      this.lblGuiche.Size = new System.Drawing.Size(333, 87);
      this.lblGuiche.TabIndex = 14;
      // 
      // lblSenha
      // 
      this.lblSenha.BackColor = System.Drawing.Color.Transparent;
      this.lblSenha.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSenha.Location = new System.Drawing.Point(266, 276);
      this.lblSenha.Name = "lblSenha";
      this.lblSenha.Size = new System.Drawing.Size(380, 100);
      this.lblSenha.TabIndex = 12;
      // 
      // lblNome
      // 
      this.lblNome.BackColor = System.Drawing.Color.Transparent;
      this.lblNome.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNome.Location = new System.Drawing.Point(272, 376);
      this.lblNome.Name = "lblNome";
      this.lblNome.Size = new System.Drawing.Size(374, 171);
      this.lblNome.TabIndex = 11;
      // 
      // imgFoto
      // 
      this.imgFoto.Image = global::Phito.Properties.Resources.User;
      this.imgFoto.Location = new System.Drawing.Point(11, 260);
      this.imgFoto.Name = "imgFoto";
      this.imgFoto.Size = new System.Drawing.Size(249, 287);
      this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.imgFoto.TabIndex = 10;
      this.imgFoto.TabStop = false;
      this.imgFoto.Visible = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.pictureBox1.Image = global::Phito.Properties.Resources.logo;
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(1024, 254);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox1.TabIndex = 9;
      this.pictureBox1.TabStop = false;
      // 
      // tmrDisplay
      // 
      this.tmrDisplay.Enabled = true;
      this.tmrDisplay.Interval = 2000;
      this.tmrDisplay.Tick += new System.EventHandler(this.tmrDisplay_Tick);
      // 
      // Painel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::Phito.Properties.Resources.fundo;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1024, 720);
      this.Controls.Add(this.pnlDisplay);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.KeyPreview = true;
      this.Name = "Painel";
      this.Text = "Painel";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.Painel_Load);
      this.pnlDisplay.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlDisplay;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox imgFoto;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblGuiche;
    private System.Windows.Forms.Label lblSenha;
    private System.Windows.Forms.Label lblNome;
    private System.Windows.Forms.Timer tmrDisplay;
    private System.Windows.Forms.Panel pnlAnteriores;
    private System.Windows.Forms.PictureBox pictureBox3;
  }
}
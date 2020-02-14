namespace Phito
{
  partial class Tottem
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tottem));
      this.pnlDisplay = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.pnlDisplay.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlDisplay
      // 
      this.pnlDisplay.BackColor = System.Drawing.Color.Transparent;
      this.pnlDisplay.Controls.Add(this.pictureBox1);
      this.pnlDisplay.Controls.Add(this.button3);
      this.pnlDisplay.Controls.Add(this.button2);
      this.pnlDisplay.Controls.Add(this.button1);
      this.pnlDisplay.Location = new System.Drawing.Point(1, 1);
      this.pnlDisplay.Name = "pnlDisplay";
      this.pnlDisplay.Size = new System.Drawing.Size(1024, 720);
      this.pnlDisplay.TabIndex = 1;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.pictureBox1.Image = global::Phito.Properties.Resources.logo;
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(1024, 308);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox1.TabIndex = 8;
      this.pictureBox1.TabStop = false;
      // 
      // button3
      // 
      this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
      this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.button3.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
      this.button3.ForeColor = System.Drawing.Color.White;
      this.button3.Location = new System.Drawing.Point(169, 543);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(675, 100);
      this.button3.TabIndex = 2;
      this.button3.Text = "Consulta";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.btn_Click);
      // 
      // button2
      // 
      this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
      this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.button2.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
      this.button2.ForeColor = System.Drawing.Color.White;
      this.button2.Location = new System.Drawing.Point(169, 437);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(675, 100);
      this.button2.TabIndex = 1;
      this.button2.Text = "Retirada de Fórmulas";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.btn_Click);
      // 
      // button1
      // 
      this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
      this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.button1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
      this.button1.ForeColor = System.Drawing.Color.White;
      this.button1.Location = new System.Drawing.Point(169, 331);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(675, 100);
      this.button1.TabIndex = 0;
      this.button1.Text = "Atendimento";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.btn_Click);
      // 
      // Tottem
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::Phito.Properties.Resources.fundo;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1024, 720);
      this.Controls.Add(this.pnlDisplay);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.KeyPreview = true;
      this.Name = "Tottem";
      this.Text = "Form1";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.Form1_Load);
      this.pnlDisplay.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlDisplay;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.PictureBox pictureBox1;

  }
}


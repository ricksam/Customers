namespace Phito
{
  partial class Atendente
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Atendente));
      this.pnlDisplay = new System.Windows.Forms.Panel();
      this.lblInfo = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.btnConsulta = new System.Windows.Forms.Button();
      this.btnRetiradaFormulas = new System.Windows.Forms.Button();
      this.btnAtendimento = new System.Windows.Forms.Button();
      this.pnlDisplay.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlDisplay
      // 
      this.pnlDisplay.BackColor = System.Drawing.Color.Transparent;
      this.pnlDisplay.Controls.Add(this.lblInfo);
      this.pnlDisplay.Controls.Add(this.pictureBox1);
      this.pnlDisplay.Controls.Add(this.btnConsulta);
      this.pnlDisplay.Controls.Add(this.btnRetiradaFormulas);
      this.pnlDisplay.Controls.Add(this.btnAtendimento);
      this.pnlDisplay.Location = new System.Drawing.Point(12, 12);
      this.pnlDisplay.Name = "pnlDisplay";
      this.pnlDisplay.Size = new System.Drawing.Size(577, 447);
      this.pnlDisplay.TabIndex = 0;
      // 
      // lblInfo
      // 
      this.lblInfo.AutoSize = true;
      this.lblInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.lblInfo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblInfo.Location = new System.Drawing.Point(0, 410);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(460, 37);
      this.lblInfo.TabIndex = 3;
      this.lblInfo.Text = "Operadora: Gisele. Guiche: 1";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.pictureBox1.Image = global::Phito.Properties.Resources.logo;
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(577, 178);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 8;
      this.pictureBox1.TabStop = false;
      // 
      // btnConsulta
      // 
      this.btnConsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsulta.BackgroundImage")));
      this.btnConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnConsulta.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnConsulta.ForeColor = System.Drawing.Color.White;
      this.btnConsulta.Location = new System.Drawing.Point(27, 324);
      this.btnConsulta.Name = "btnConsulta";
      this.btnConsulta.Size = new System.Drawing.Size(538, 64);
      this.btnConsulta.TabIndex = 2;
      this.btnConsulta.Text = "Consulta (0)";
      this.btnConsulta.UseVisualStyleBackColor = true;
      this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
      // 
      // btnRetiradaFormulas
      // 
      this.btnRetiradaFormulas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetiradaFormulas.BackgroundImage")));
      this.btnRetiradaFormulas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnRetiradaFormulas.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRetiradaFormulas.ForeColor = System.Drawing.Color.White;
      this.btnRetiradaFormulas.Location = new System.Drawing.Point(27, 254);
      this.btnRetiradaFormulas.Name = "btnRetiradaFormulas";
      this.btnRetiradaFormulas.Size = new System.Drawing.Size(538, 64);
      this.btnRetiradaFormulas.TabIndex = 1;
      this.btnRetiradaFormulas.Text = "Retirada de Fórmulas (0)";
      this.btnRetiradaFormulas.UseVisualStyleBackColor = true;
      this.btnRetiradaFormulas.Click += new System.EventHandler(this.btnRetiradaFormulas_Click);
      // 
      // btnAtendimento
      // 
      this.btnAtendimento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtendimento.BackgroundImage")));
      this.btnAtendimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnAtendimento.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAtendimento.ForeColor = System.Drawing.Color.White;
      this.btnAtendimento.Location = new System.Drawing.Point(27, 184);
      this.btnAtendimento.Name = "btnAtendimento";
      this.btnAtendimento.Size = new System.Drawing.Size(538, 64);
      this.btnAtendimento.TabIndex = 0;
      this.btnAtendimento.Text = "Atendimento (0)";
      this.btnAtendimento.UseVisualStyleBackColor = true;
      this.btnAtendimento.Click += new System.EventHandler(this.btnAtendimento_Click);
      // 
      // Atendente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::Phito.Properties.Resources.fundo;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(601, 475);
      this.Controls.Add(this.pnlDisplay);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "Atendente";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Atendente";
      this.Load += new System.EventHandler(this.Atendente_Load);
      this.pnlDisplay.ResumeLayout(false);
      this.pnlDisplay.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlDisplay;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button btnConsulta;
    private System.Windows.Forms.Button btnRetiradaFormulas;
    private System.Windows.Forms.Button btnAtendimento;
    private System.Windows.Forms.Label lblInfo;
  }
}
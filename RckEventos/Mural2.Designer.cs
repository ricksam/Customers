namespace RckEventos
{
  partial class Mural2
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
            this.tmrFotos = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgFoto
            // 
            this.imgFoto.BackColor = System.Drawing.Color.Black;
            this.imgFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgFoto.Location = new System.Drawing.Point(0, 0);
            this.imgFoto.Name = "imgFoto";
            this.imgFoto.Size = new System.Drawing.Size(700, 468);
            this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFoto.TabIndex = 2;
            this.imgFoto.TabStop = false;
            this.imgFoto.DoubleClick += new System.EventHandler(this.imgFoto_DoubleClick);
            // 
            // tmrFotos
            // 
            this.tmrFotos.Interval = 8000;
            this.tmrFotos.Tick += new System.EventHandler(this.tmrFotos_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 32);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.DimGray;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Yellow;
            this.txtCodigo.Location = new System.Drawing.Point(3, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(141, 26);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(150, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(25, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Info";
            // 
            // Mural2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.imgFoto);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Mural2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mural2";
            this.Load += new System.EventHandler(this.Mural2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox imgFoto;
    private System.Windows.Forms.Timer tmrFotos;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblInfo;
    private System.Windows.Forms.TextBox txtCodigo;
  }
}
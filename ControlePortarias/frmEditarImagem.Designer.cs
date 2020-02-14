namespace ControlePortarias
{
  partial class frmEditarImagem
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarImagem));
      this.imgFoto = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label4 = new System.Windows.Forms.Label();
      this.tbSelecao = new System.Windows.Forms.TrackBar();
      this.label3 = new System.Windows.Forms.Label();
      this.tbImagem = new System.Windows.Forms.TrackBar();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tbSelecao)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbImagem)).BeginInit();
      this.SuspendLayout();
      // 
      // imgFoto
      // 
      this.imgFoto.Dock = System.Windows.Forms.DockStyle.Fill;
      this.imgFoto.Location = new System.Drawing.Point(0, 16);
      this.imgFoto.Name = "imgFoto";
      this.imgFoto.Size = new System.Drawing.Size(734, 437);
      this.imgFoto.TabIndex = 0;
      this.imgFoto.TabStop = false;
      this.imgFoto.Click += new System.EventHandler(this.imgFoto_Click);
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.SystemColors.Control;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.label1.ForeColor = System.Drawing.Color.Black;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(734, 16);
      this.label1.TabIndex = 1;
      this.label1.Text = "Clique na imagem para selecionar a área que deseja recortar. Se possível no centr" +
    "o do rosto";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.Control;
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.tbSelecao);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.tbImagem);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 453);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(734, 59);
      this.panel1.TabIndex = 2;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(339, 35);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(46, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Seleção";
      // 
      // tbSelecao
      // 
      this.tbSelecao.Location = new System.Drawing.Point(391, 18);
      this.tbSelecao.Maximum = 500;
      this.tbSelecao.Minimum = 25;
      this.tbSelecao.Name = "tbSelecao";
      this.tbSelecao.Size = new System.Drawing.Size(271, 45);
      this.tbSelecao.TabIndex = 5;
      this.tbSelecao.TickFrequency = 25;
      this.tbSelecao.Value = 250;
      this.tbSelecao.Scroll += new System.EventHandler(this.tbSelecao_Scroll);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 35);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(44, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Imagem";
      // 
      // tbImagem
      // 
      this.tbImagem.Location = new System.Drawing.Point(62, 18);
      this.tbImagem.Maximum = 1200;
      this.tbImagem.Minimum = 200;
      this.tbImagem.Name = "tbImagem";
      this.tbImagem.Size = new System.Drawing.Size(271, 45);
      this.tbImagem.TabIndex = 3;
      this.tbImagem.TickFrequency = 50;
      this.tbImagem.Value = 700;
      this.tbImagem.Scroll += new System.EventHandler(this.tbImagem_Scroll);
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.SystemColors.Control;
      this.label2.Dock = System.Windows.Forms.DockStyle.Top;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.label2.ForeColor = System.Drawing.Color.Black;
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(734, 15);
      this.label2.TabIndex = 2;
      this.label2.Text = "Use os controles abaixo para aumentar ou diminuir a imagem ou a área selecionada." +
    " Ao final pressione ENTER para salvar a área recortada";
      // 
      // frmEditarImagem
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlDark;
      this.ClientSize = new System.Drawing.Size(734, 512);
      this.Controls.Add(this.imgFoto);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmEditarImagem";
      this.Text = "Editar Imagem";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmEditarImagem_Load);
      ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tbSelecao)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbImagem)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox imgFoto;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TrackBar tbSelecao;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TrackBar tbImagem;
  }
}
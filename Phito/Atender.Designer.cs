namespace Phito
{
  partial class Atender
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
      this.imgFoto = new System.Windows.Forms.PictureBox();
      this.lblNome = new System.Windows.Forms.Label();
      this.lblSenha = new System.Windows.Forms.Label();
      this.lblChegada = new System.Windows.Forms.Label();
      this.lblPreferencial = new System.Windows.Forms.Label();
      this.btnIniciarAtendimento = new System.Windows.Forms.Button();
      this.btnFinalizarAtendimento = new System.Windows.Forms.Button();
      this.btnProximo = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
      this.SuspendLayout();
      // 
      // imgFoto
      // 
      this.imgFoto.BackColor = System.Drawing.Color.Transparent;
      this.imgFoto.Image = global::Phito.Properties.Resources.User;
      this.imgFoto.Location = new System.Drawing.Point(12, 12);
      this.imgFoto.Name = "imgFoto";
      this.imgFoto.Size = new System.Drawing.Size(189, 200);
      this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.imgFoto.TabIndex = 0;
      this.imgFoto.TabStop = false;
      // 
      // lblNome
      // 
      this.lblNome.BackColor = System.Drawing.Color.Transparent;
      this.lblNome.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNome.Location = new System.Drawing.Point(207, 9);
      this.lblNome.Name = "lblNome";
      this.lblNome.Size = new System.Drawing.Size(300, 50);
      this.lblNome.TabIndex = 0;
      this.lblNome.Text = "Jose da Silva";
      // 
      // lblSenha
      // 
      this.lblSenha.BackColor = System.Drawing.Color.Transparent;
      this.lblSenha.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSenha.Location = new System.Drawing.Point(206, 59);
      this.lblSenha.Name = "lblSenha";
      this.lblSenha.Size = new System.Drawing.Size(300, 50);
      this.lblSenha.TabIndex = 1;
      this.lblSenha.Text = "Cartão: AX123YZ";
      // 
      // lblChegada
      // 
      this.lblChegada.BackColor = System.Drawing.Color.Transparent;
      this.lblChegada.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblChegada.Location = new System.Drawing.Point(207, 109);
      this.lblChegada.Name = "lblChegada";
      this.lblChegada.Size = new System.Drawing.Size(300, 50);
      this.lblChegada.TabIndex = 2;
      this.lblChegada.Text = "Chegada: 11:45";
      // 
      // lblPreferencial
      // 
      this.lblPreferencial.BackColor = System.Drawing.Color.Transparent;
      this.lblPreferencial.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPreferencial.Location = new System.Drawing.Point(206, 159);
      this.lblPreferencial.Name = "lblPreferencial";
      this.lblPreferencial.Size = new System.Drawing.Size(300, 50);
      this.lblPreferencial.TabIndex = 3;
      this.lblPreferencial.Text = "Preferencial: Não";
      // 
      // btnIniciarAtendimento
      // 
      this.btnIniciarAtendimento.BackgroundImage = global::Phito.Properties.Resources.botao_fundo;
      this.btnIniciarAtendimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnIniciarAtendimento.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
      this.btnIniciarAtendimento.ForeColor = System.Drawing.Color.White;
      this.btnIniciarAtendimento.Location = new System.Drawing.Point(12, 218);
      this.btnIniciarAtendimento.Name = "btnIniciarAtendimento";
      this.btnIniciarAtendimento.Size = new System.Drawing.Size(600, 84);
      this.btnIniciarAtendimento.TabIndex = 4;
      this.btnIniciarAtendimento.Text = "Iniciar Atendimento";
      this.btnIniciarAtendimento.UseVisualStyleBackColor = true;
      this.btnIniciarAtendimento.Click += new System.EventHandler(this.btnIniciarAtendimento_Click);
      // 
      // btnFinalizarAtendimento
      // 
      this.btnFinalizarAtendimento.BackgroundImage = global::Phito.Properties.Resources.botao_fundo;
      this.btnFinalizarAtendimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnFinalizarAtendimento.Enabled = false;
      this.btnFinalizarAtendimento.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
      this.btnFinalizarAtendimento.ForeColor = System.Drawing.Color.White;
      this.btnFinalizarAtendimento.Location = new System.Drawing.Point(12, 308);
      this.btnFinalizarAtendimento.Name = "btnFinalizarAtendimento";
      this.btnFinalizarAtendimento.Size = new System.Drawing.Size(600, 84);
      this.btnFinalizarAtendimento.TabIndex = 5;
      this.btnFinalizarAtendimento.Text = "Finalizar Atendimento";
      this.btnFinalizarAtendimento.UseVisualStyleBackColor = true;
      this.btnFinalizarAtendimento.Click += new System.EventHandler(this.btnFinalizarAtendimento_Click);
      // 
      // btnProximo
      // 
      this.btnProximo.BackgroundImage = global::Phito.Properties.Resources.botao_fundo;
      this.btnProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnProximo.Enabled = false;
      this.btnProximo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
      this.btnProximo.ForeColor = System.Drawing.Color.White;
      this.btnProximo.Location = new System.Drawing.Point(12, 398);
      this.btnProximo.Name = "btnProximo";
      this.btnProximo.Size = new System.Drawing.Size(600, 84);
      this.btnProximo.TabIndex = 6;
      this.btnProximo.Text = "Próximo";
      this.btnProximo.UseVisualStyleBackColor = true;
      this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
      // 
      // Atender
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::Phito.Properties.Resources.fundo;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(624, 495);
      this.ControlBox = false;
      this.Controls.Add(this.btnProximo);
      this.Controls.Add(this.btnFinalizarAtendimento);
      this.Controls.Add(this.btnIniciarAtendimento);
      this.Controls.Add(this.lblPreferencial);
      this.Controls.Add(this.lblChegada);
      this.Controls.Add(this.lblSenha);
      this.Controls.Add(this.lblNome);
      this.Controls.Add(this.imgFoto);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "Atender";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Atender";
      this.Load += new System.EventHandler(this.Atender_Load);
      ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox imgFoto;
    private System.Windows.Forms.Label lblNome;
    private System.Windows.Forms.Label lblSenha;
    private System.Windows.Forms.Label lblChegada;
    private System.Windows.Forms.Label lblPreferencial;
    private System.Windows.Forms.Button btnIniciarAtendimento;
    private System.Windows.Forms.Button btnFinalizarAtendimento;
    private System.Windows.Forms.Button btnProximo;
  }
}
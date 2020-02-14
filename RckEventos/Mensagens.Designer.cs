namespace RckEventos
{
  partial class Mensagens
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
      this.pnlDisplay = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtNome = new System.Windows.Forms.TextBox();
      this.lblReturn = new System.Windows.Forms.Label();
      this.txtMensagem = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.pnlDisplay.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlDisplay
      // 
      this.pnlDisplay.BackColor = System.Drawing.Color.WhiteSmoke;
      this.pnlDisplay.Controls.Add(this.label3);
      this.pnlDisplay.Controls.Add(this.label1);
      this.pnlDisplay.Controls.Add(this.txtNome);
      this.pnlDisplay.Controls.Add(this.lblReturn);
      this.pnlDisplay.Controls.Add(this.txtMensagem);
      this.pnlDisplay.Controls.Add(this.button1);
      this.pnlDisplay.Location = new System.Drawing.Point(10, 42);
      this.pnlDisplay.Name = "pnlDisplay";
      this.pnlDisplay.Size = new System.Drawing.Size(700, 500);
      this.pnlDisplay.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(16, 103);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(115, 33);
      this.label3.TabIndex = 7;
      this.label3.Text = "Mensagem";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(16, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 33);
      this.label1.TabIndex = 6;
      this.label1.Text = "Nome";
      // 
      // txtNome
      // 
      this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtNome.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNome.Location = new System.Drawing.Point(22, 59);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(648, 41);
      this.txtNome.TabIndex = 5;
      this.txtNome.TextChanged += new System.EventHandler(this.txt_TextChanged);
      // 
      // lblReturn
      // 
      this.lblReturn.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.lblReturn.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
      this.lblReturn.ForeColor = System.Drawing.Color.Red;
      this.lblReturn.Location = new System.Drawing.Point(0, 433);
      this.lblReturn.Name = "lblReturn";
      this.lblReturn.Size = new System.Drawing.Size(700, 67);
      this.lblReturn.TabIndex = 4;
      this.lblReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // txtMensagem
      // 
      this.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtMensagem.Font = new System.Drawing.Font("Segoe Print", 14.25F);
      this.txtMensagem.Location = new System.Drawing.Point(22, 139);
      this.txtMensagem.Multiline = true;
      this.txtMensagem.Name = "txtMensagem";
      this.txtMensagem.Size = new System.Drawing.Size(648, 246);
      this.txtMensagem.TabIndex = 1;
      this.txtMensagem.TextChanged += new System.EventHandler(this.txt_TextChanged);
      // 
      // button1
      // 
      this.button1.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
      this.button1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
      this.button1.Location = new System.Drawing.Point(22, 391);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(648, 39);
      this.button1.TabIndex = 2;
      this.button1.Text = "Enviar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Mensagens
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Silver;
      this.ClientSize = new System.Drawing.Size(734, 512);
      this.Controls.Add(this.pnlDisplay);
      this.Name = "Mensagens";
      this.Text = "Livro de Mensagens";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.Mensagens_Load);
      this.pnlDisplay.ResumeLayout(false);
      this.pnlDisplay.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox txtMensagem;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Panel pnlDisplay;
    private System.Windows.Forms.TextBox txtNome;
    private System.Windows.Forms.Label lblReturn;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
  }
}
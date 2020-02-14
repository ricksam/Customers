namespace SysZoo
{
  partial class frmConfiguracao
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracao));
      this.label1 = new System.Windows.Forms.Label();
      this.txtIdentificacao = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtVelocidade = new System.Windows.Forms.TextBox();
      this.cmbPorta = new System.Windows.Forms.ComboBox();
      this.btnGravar = new System.Windows.Forms.Button();
      this.cbIndividual = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // lblWindowTitle
      // 
      this.lblWindowTitle.Size = new System.Drawing.Size(320, 30);
      this.lblWindowTitle.Text = "Configuração";
      // 
      // btnWindowClose
      // 
      this.btnWindowClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowClose.BackgroundImage")));
      this.btnWindowClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
      this.btnWindowClose.Location = new System.Drawing.Point(278, 6);
      // 
      // btnWindowMinimize
      // 
      this.btnWindowMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowMinimize.BackgroundImage")));
      this.btnWindowMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnWindowMinimize.Location = new System.Drawing.Point(242, 6);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 46);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(180, 18);
      this.label1.TabIndex = 3;
      this.label1.Text = "Identificacao do Terminal";
      // 
      // txtIdentificacao
      // 
      this.txtIdentificacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtIdentificacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtIdentificacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtIdentificacao.Location = new System.Drawing.Point(12, 67);
      this.txtIdentificacao.Name = "txtIdentificacao";
      this.txtIdentificacao.Size = new System.Drawing.Size(295, 26);
      this.txtIdentificacao.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 96);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(295, 18);
      this.label2.TabIndex = 5;
      this.label2.Text = "Porta de comunicação com a impressora";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(12, 150);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(206, 18);
      this.label3.TabIndex = 7;
      this.label3.Text = "Velocidade de comunicacao";
      // 
      // txtVelocidade
      // 
      this.txtVelocidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtVelocidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtVelocidade.Location = new System.Drawing.Point(12, 171);
      this.txtVelocidade.Name = "txtVelocidade";
      this.txtVelocidade.Size = new System.Drawing.Size(295, 26);
      this.txtVelocidade.TabIndex = 8;
      this.txtVelocidade.Text = "38400";
      // 
      // cmbPorta
      // 
      this.cmbPorta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbPorta.FormattingEnabled = true;
      this.cmbPorta.Location = new System.Drawing.Point(12, 117);
      this.cmbPorta.Name = "cmbPorta";
      this.cmbPorta.Size = new System.Drawing.Size(295, 30);
      this.cmbPorta.TabIndex = 6;
      // 
      // btnGravar
      // 
      this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnGravar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGravar.ForeColor = System.Drawing.Color.White;
      this.btnGravar.Location = new System.Drawing.Point(147, 231);
      this.btnGravar.Name = "btnGravar";
      this.btnGravar.Size = new System.Drawing.Size(160, 38);
      this.btnGravar.TabIndex = 10;
      this.btnGravar.Text = "Gravar";
      this.btnGravar.UseVisualStyleBackColor = false;
      this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
      // 
      // cbIndividual
      // 
      this.cbIndividual.AutoSize = true;
      this.cbIndividual.Font = new System.Drawing.Font("Arial", 12F);
      this.cbIndividual.Location = new System.Drawing.Point(12, 203);
      this.cbIndividual.Name = "cbIndividual";
      this.cbIndividual.Size = new System.Drawing.Size(196, 22);
      this.cbIndividual.TabIndex = 9;
      this.cbIndividual.Text = "Imprimir Ticket Individual";
      this.cbIndividual.UseVisualStyleBackColor = true;
      // 
      // frmConfiguracao
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(320, 281);
      this.Controls.Add(this.cbIndividual);
      this.Controls.Add(this.btnGravar);
      this.Controls.Add(this.cmbPorta);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtVelocidade);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtIdentificacao);
      this.Name = "frmConfiguracao";
      this.Text = "frmConfiguracao";
      this.Load += new System.EventHandler(this.frmConfiguracao_Load);
      this.Controls.SetChildIndex(this.lblWindowTitle, 0);
      this.Controls.SetChildIndex(this.btnWindowClose, 0);
      this.Controls.SetChildIndex(this.btnWindowMinimize, 0);
      this.Controls.SetChildIndex(this.txtIdentificacao, 0);
      this.Controls.SetChildIndex(this.label1, 0);
      this.Controls.SetChildIndex(this.label2, 0);
      this.Controls.SetChildIndex(this.txtVelocidade, 0);
      this.Controls.SetChildIndex(this.label3, 0);
      this.Controls.SetChildIndex(this.cmbPorta, 0);
      this.Controls.SetChildIndex(this.btnGravar, 0);
      this.Controls.SetChildIndex(this.cbIndividual, 0);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtIdentificacao;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtVelocidade;
    private System.Windows.Forms.ComboBox cmbPorta;
    private System.Windows.Forms.Button btnGravar;
    private System.Windows.Forms.CheckBox cbIndividual;
  }
}
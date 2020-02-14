namespace SysZoo
{
  partial class frmMovOperacional
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovOperacional));
      this.cmbPorta = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtVelocidade = new System.Windows.Forms.TextBox();
      this.btnGravar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnWindowClose
      // 
      this.btnWindowClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowClose.BackgroundImage")));
      this.btnWindowClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
      // 
      // btnWindowMinimize
      // 
      this.btnWindowMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowMinimize.BackgroundImage")));
      this.btnWindowMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      // 
      // cmbPorta
      // 
      this.cmbPorta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbPorta.FormattingEnabled = true;
      this.cmbPorta.Items.AddRange(new object[] {
            "SANGRIA",
            "SUPRIMENTO"});
      this.cmbPorta.Location = new System.Drawing.Point(12, 64);
      this.cmbPorta.Name = "cmbPorta";
      this.cmbPorta.Size = new System.Drawing.Size(260, 30);
      this.cmbPorta.TabIndex = 8;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 43);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(78, 18);
      this.label2.TabIndex = 7;
      this.label2.Text = "Operacao";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(12, 97);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(206, 18);
      this.label3.TabIndex = 9;
      this.label3.Text = "Velocidade de comunicacao";
      // 
      // txtVelocidade
      // 
      this.txtVelocidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtVelocidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtVelocidade.Location = new System.Drawing.Point(12, 118);
      this.txtVelocidade.Name = "txtVelocidade";
      this.txtVelocidade.Size = new System.Drawing.Size(260, 26);
      this.txtVelocidade.TabIndex = 10;
      this.txtVelocidade.Text = "0,00";
      this.txtVelocidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // btnGravar
      // 
      this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnGravar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGravar.ForeColor = System.Drawing.Color.White;
      this.btnGravar.Location = new System.Drawing.Point(112, 150);
      this.btnGravar.Name = "btnGravar";
      this.btnGravar.Size = new System.Drawing.Size(160, 38);
      this.btnGravar.TabIndex = 11;
      this.btnGravar.Text = "Gravar";
      this.btnGravar.UseVisualStyleBackColor = false;
      // 
      // frmMovOperacional
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 201);
      this.Controls.Add(this.btnGravar);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtVelocidade);
      this.Controls.Add(this.cmbPorta);
      this.Controls.Add(this.label2);
      this.Name = "frmMovOperacional";
      this.Text = "frmMovOperacional";
      this.Controls.SetChildIndex(this.lblWindowTitle, 0);
      this.Controls.SetChildIndex(this.btnWindowClose, 0);
      this.Controls.SetChildIndex(this.btnWindowMinimize, 0);
      this.Controls.SetChildIndex(this.label2, 0);
      this.Controls.SetChildIndex(this.cmbPorta, 0);
      this.Controls.SetChildIndex(this.txtVelocidade, 0);
      this.Controls.SetChildIndex(this.label3, 0);
      this.Controls.SetChildIndex(this.btnGravar, 0);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbPorta;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtVelocidade;
    private System.Windows.Forms.Button btnGravar;
  }
}
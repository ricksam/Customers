namespace SysZoo
{
  partial class frmTesteImpressora
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTesteImpressora));
      this.btnPagamento = new System.Windows.Forms.Button();
      this.cmbPorta = new System.Windows.Forms.ComboBox();
      this.txtVelocity = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.cbIndividual = new System.Windows.Forms.CheckBox();
      this.lblInternet = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblWindowTitle
      // 
      this.lblWindowTitle.Text = "Teste";
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
      // btnPagamento
      // 
      this.btnPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnPagamento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnPagamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPagamento.ForeColor = System.Drawing.Color.White;
      this.btnPagamento.Location = new System.Drawing.Point(43, 160);
      this.btnPagamento.Name = "btnPagamento";
      this.btnPagamento.Size = new System.Drawing.Size(167, 38);
      this.btnPagamento.TabIndex = 6;
      this.btnPagamento.Text = "Imprimir";
      this.btnPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnPagamento.UseVisualStyleBackColor = false;
      this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
      // 
      // cmbPorta
      // 
      this.cmbPorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbPorta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbPorta.FormattingEnabled = true;
      this.cmbPorta.Location = new System.Drawing.Point(66, 53);
      this.cmbPorta.Name = "cmbPorta";
      this.cmbPorta.Size = new System.Drawing.Size(121, 30);
      this.cmbPorta.TabIndex = 3;
      // 
      // txtVelocity
      // 
      this.txtVelocity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtVelocity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtVelocity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtVelocity.Location = new System.Drawing.Point(43, 98);
      this.txtVelocity.Name = "txtVelocity";
      this.txtVelocity.Size = new System.Drawing.Size(197, 26);
      this.txtVelocity.TabIndex = 4;
      this.txtVelocity.Text = "38400";
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.Color.White;
      this.button1.Location = new System.Drawing.Point(43, 204);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(167, 38);
      this.button1.TabIndex = 7;
      this.button1.Text = "Corta Papel";
      this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // cbIndividual
      // 
      this.cbIndividual.AutoSize = true;
      this.cbIndividual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbIndividual.Location = new System.Drawing.Point(43, 130);
      this.cbIndividual.Name = "cbIndividual";
      this.cbIndividual.Size = new System.Drawing.Size(151, 22);
      this.cbIndividual.TabIndex = 5;
      this.cbIndividual.Text = "Imprimir Individual";
      this.cbIndividual.UseVisualStyleBackColor = true;
      // 
      // lblInternet
      // 
      this.lblInternet.Location = new System.Drawing.Point(66, 249);
      this.lblInternet.Name = "lblInternet";
      this.lblInternet.Size = new System.Drawing.Size(100, 23);
      this.lblInternet.TabIndex = 8;
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.ForeColor = System.Drawing.Color.White;
      this.button2.Location = new System.Drawing.Point(43, 248);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(167, 38);
      this.button2.TabIndex = 9;
      this.button2.Text = "Aciona Gaveta";
      this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(43, 292);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 10;
      this.button3.Text = "button3";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // frmTesteImpressora
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 344);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.lblInternet);
      this.Controls.Add(this.cbIndividual);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.txtVelocity);
      this.Controls.Add(this.cmbPorta);
      this.Controls.Add(this.btnPagamento);
      this.Name = "frmTesteImpressora";
      this.Text = "TesteImpressora";
      this.Load += new System.EventHandler(this.TesteImpressora_Load);
      this.Controls.SetChildIndex(this.lblWindowTitle, 0);
      this.Controls.SetChildIndex(this.btnWindowClose, 0);
      this.Controls.SetChildIndex(this.btnWindowMinimize, 0);
      this.Controls.SetChildIndex(this.btnPagamento, 0);
      this.Controls.SetChildIndex(this.cmbPorta, 0);
      this.Controls.SetChildIndex(this.txtVelocity, 0);
      this.Controls.SetChildIndex(this.button1, 0);
      this.Controls.SetChildIndex(this.cbIndividual, 0);
      this.Controls.SetChildIndex(this.lblInternet, 0);
      this.Controls.SetChildIndex(this.button2, 0);
      this.Controls.SetChildIndex(this.button3, 0);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnPagamento;
    private System.Windows.Forms.ComboBox cmbPorta;
    private System.Windows.Forms.TextBox txtVelocity;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.CheckBox cbIndividual;
    private System.Windows.Forms.Label lblInternet;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
  }
}
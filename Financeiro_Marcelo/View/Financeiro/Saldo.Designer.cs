namespace Financeiro_Marcelo.View
{
  partial class Saldo
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
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.cmbConta = new lib.Visual.Components.sknComboBox();
      this.btnSaldo = new lib.Visual.Components.sknButton();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.cmbUltimos = new lib.Visual.Components.sknComboBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.grdSaldo = new lib.Visual.Components.sknGrid();
      this.sknButton1 = new lib.Visual.Components.sknButton();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdSaldo)).BeginInit();
      this.SuspendLayout();
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 9);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(80, 13);
      this.sknLabel1.TabIndex = 0;
      this.sknLabel1.Text = "Conta Bancária";
      // 
      // cmbConta
      // 
      this.cmbConta.AutoTab = true;
      this.cmbConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbConta.FormattingEnabled = true;
      this.cmbConta.Location = new System.Drawing.Point(12, 25);
      this.cmbConta.Name = "cmbConta";
      this.cmbConta.Size = new System.Drawing.Size(304, 21);
      this.cmbConta.TabIndex = 1;
      this.cmbConta.SelectedIndexChanged += new System.EventHandler(this.cmbConta_SelectedIndexChanged);
      // 
      // btnSaldo
      // 
      this.btnSaldo.Location = new System.Drawing.Point(12, 52);
      this.btnSaldo.Name = "btnSaldo";
      this.btnSaldo.Size = new System.Drawing.Size(304, 23);
      this.btnSaldo.TabIndex = 2;
      this.btnSaldo.Text = "Registrar Depósito/Regirada";
      this.btnSaldo.UseVisualStyleBackColor = true;
      this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(12, 89);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(308, 13);
      this.sknLabel2.TabIndex = 3;
      this.sknLabel2.Text = "Últimas Operações. Exibir os últimos                              registros.";
      // 
      // cmbUltimos
      // 
      this.cmbUltimos.AutoTab = true;
      this.cmbUltimos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbUltimos.FormattingEnabled = true;
      this.cmbUltimos.Items.AddRange(new object[] {
            "10",
            "20",
            "50"});
      this.cmbUltimos.Location = new System.Drawing.Point(202, 81);
      this.cmbUltimos.Name = "cmbUltimos";
      this.cmbUltimos.Size = new System.Drawing.Size(50, 21);
      this.cmbUltimos.TabIndex = 5;
      this.cmbUltimos.SelectedIndexChanged += new System.EventHandler(this.cmbUltimos_SelectedIndexChanged);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.sknButton1);
      this.panel1.Controls.Add(this.sknLabel1);
      this.panel1.Controls.Add(this.cmbUltimos);
      this.panel1.Controls.Add(this.cmbConta);
      this.panel1.Controls.Add(this.sknLabel2);
      this.panel1.Controls.Add(this.btnSaldo);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(624, 115);
      this.panel1.TabIndex = 6;
      // 
      // grdSaldo
      // 
      this.grdSaldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdSaldo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdSaldo.Location = new System.Drawing.Point(0, 115);
      this.grdSaldo.Name = "grdSaldo";
      this.grdSaldo.Size = new System.Drawing.Size(624, 327);
      this.grdSaldo.TabIndex = 7;
      // 
      // sknButton1
      // 
      this.sknButton1.Location = new System.Drawing.Point(322, 25);
      this.sknButton1.Name = "sknButton1";
      this.sknButton1.Size = new System.Drawing.Size(75, 50);
      this.sknButton1.TabIndex = 6;
      this.sknButton1.Text = "Exibir Extrato";
      this.sknButton1.UseVisualStyleBackColor = true;
      this.sknButton1.Click += new System.EventHandler(this.sknButton1_Click);
      // 
      // Saldo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(624, 442);
      this.Controls.Add(this.grdSaldo);
      this.Controls.Add(this.panel1);
      this.Name = "Saldo";
      this.Text = "Saldo";
      this.Load += new System.EventHandler(this.Saldo_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdSaldo)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknComboBox cmbConta;
    private lib.Visual.Components.sknButton btnSaldo;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknComboBox cmbUltimos;
    private System.Windows.Forms.Panel panel1;
    private lib.Visual.Components.sknGrid grdSaldo;
    private lib.Visual.Components.sknButton sknButton1;
  }
}
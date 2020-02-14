namespace Financeiro_Marcelo
{
  partial class Estorno
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
      this.sknPanel1 = new lib.Visual.Components.sknPanel();
      this.btnEstornar = new lib.Visual.Components.sknButton();
      this.cmbEmpresa = new lib.Visual.Components.sknComboBox();
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.grdEstorno = new lib.Visual.Components.sknGrid();
      this.sknPanel2 = new lib.Visual.Components.sknPanel();
      this.grdLancamentos = new lib.Visual.Components.sknGrid();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.sknPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdEstorno)).BeginInit();
      this.sknPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdLancamentos)).BeginInit();
      this.SuspendLayout();
      // 
      // sknPanel1
      // 
      this.sknPanel1.Controls.Add(this.btnEstornar);
      this.sknPanel1.Controls.Add(this.cmbEmpresa);
      this.sknPanel1.Controls.Add(this.sknLabel1);
      this.sknPanel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.sknPanel1.Location = new System.Drawing.Point(0, 0);
      this.sknPanel1.Name = "sknPanel1";
      this.sknPanel1.Size = new System.Drawing.Size(734, 63);
      this.sknPanel1.TabIndex = 0;
      // 
      // btnEstornar
      // 
      this.btnEstornar.Location = new System.Drawing.Point(208, 23);
      this.btnEstornar.Name = "btnEstornar";
      this.btnEstornar.Size = new System.Drawing.Size(100, 23);
      this.btnEstornar.TabIndex = 4;
      this.btnEstornar.Text = "Estornar";
      this.btnEstornar.UseVisualStyleBackColor = true;
      this.btnEstornar.Click += new System.EventHandler(this.btnEstornar_Click);
      // 
      // cmbEmpresa
      // 
      this.cmbEmpresa.AutoTab = true;
      this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbEmpresa.FormattingEnabled = true;
      this.cmbEmpresa.Location = new System.Drawing.Point(12, 25);
      this.cmbEmpresa.Name = "cmbEmpresa";
      this.cmbEmpresa.Size = new System.Drawing.Size(190, 21);
      this.cmbEmpresa.TabIndex = 3;
      this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 9);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(48, 13);
      this.sknLabel1.TabIndex = 2;
      this.sknLabel1.Text = "Empresa";
      // 
      // grdEstorno
      // 
      this.grdEstorno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdEstorno.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdEstorno.Location = new System.Drawing.Point(0, 63);
      this.grdEstorno.Name = "grdEstorno";
      this.grdEstorno.Size = new System.Drawing.Size(734, 247);
      this.grdEstorno.TabIndex = 1;
      this.grdEstorno.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEstorno_RowEnter);
      // 
      // sknPanel2
      // 
      this.sknPanel2.Controls.Add(this.grdLancamentos);
      this.sknPanel2.Controls.Add(this.sknLabel2);
      this.sknPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.sknPanel2.Location = new System.Drawing.Point(0, 310);
      this.sknPanel2.Name = "sknPanel2";
      this.sknPanel2.Size = new System.Drawing.Size(734, 202);
      this.sknPanel2.TabIndex = 2;
      // 
      // grdLancamentos
      // 
      this.grdLancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdLancamentos.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdLancamentos.Location = new System.Drawing.Point(0, 13);
      this.grdLancamentos.Name = "grdLancamentos";
      this.grdLancamentos.Size = new System.Drawing.Size(734, 189);
      this.grdLancamentos.TabIndex = 1;
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.sknLabel2.Location = new System.Drawing.Point(0, 0);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(223, 13);
      this.sknLabel2.TabIndex = 0;
      this.sknLabel2.Text = "Visualize aqui as contas da baixa selecionada";
      // 
      // Estorno
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(734, 512);
      this.Controls.Add(this.grdEstorno);
      this.Controls.Add(this.sknPanel2);
      this.Controls.Add(this.sknPanel1);
      this.Name = "Estorno";
      this.Text = "Estorno";
      this.Load += new System.EventHandler(this.Estorno_Load);
      this.sknPanel1.ResumeLayout(false);
      this.sknPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdEstorno)).EndInit();
      this.sknPanel2.ResumeLayout(false);
      this.sknPanel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdLancamentos)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknPanel sknPanel1;
    private lib.Visual.Components.sknGrid grdEstorno;
    private lib.Visual.Components.sknComboBox cmbEmpresa;
    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknButton btnEstornar;
    private lib.Visual.Components.sknPanel sknPanel2;
    private lib.Visual.Components.sknGrid grdLancamentos;
    private lib.Visual.Components.sknLabel sknLabel2;
  }
}
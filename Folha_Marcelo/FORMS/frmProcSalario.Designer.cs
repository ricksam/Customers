namespace Folha_Marcelo.FORMS
{
  partial class frmProcSalario
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.cmbMes = new System.Windows.Forms.ComboBox();
      this.cmbAno = new System.Windows.Forms.ComboBox();
      this.btnIniciar = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.lblLoja = new System.Windows.Forms.Label();
      this.lblColaborador = new System.Windows.Forms.Label();
      this.progressBar2 = new System.Windows.Forms.ProgressBar();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(297, 26);
      this.label1.TabIndex = 0;
      this.label1.Text = "Este formulário faz o lançamento de salário mensal para todos\r\n os colaboradores " +
    "ativos no sistema";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 49);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(27, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Mês";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(127, 49);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(26, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Ano";
      // 
      // cmbMes
      // 
      this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbMes.FormattingEnabled = true;
      this.cmbMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
      this.cmbMes.Location = new System.Drawing.Point(12, 65);
      this.cmbMes.Name = "cmbMes";
      this.cmbMes.Size = new System.Drawing.Size(112, 21);
      this.cmbMes.TabIndex = 4;
      // 
      // cmbAno
      // 
      this.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbAno.FormattingEnabled = true;
      this.cmbAno.Location = new System.Drawing.Point(130, 65);
      this.cmbAno.Name = "cmbAno";
      this.cmbAno.Size = new System.Drawing.Size(96, 21);
      this.cmbAno.TabIndex = 5;
      // 
      // btnIniciar
      // 
      this.btnIniciar.Location = new System.Drawing.Point(232, 63);
      this.btnIniciar.Name = "btnIniciar";
      this.btnIniciar.Size = new System.Drawing.Size(75, 23);
      this.btnIniciar.TabIndex = 8;
      this.btnIniciar.Text = "Iniciar";
      this.btnIniciar.UseVisualStyleBackColor = true;
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(15, 105);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(292, 21);
      this.progressBar1.TabIndex = 9;
      this.progressBar1.Value = 20;
      // 
      // lblLoja
      // 
      this.lblLoja.AutoSize = true;
      this.lblLoja.Location = new System.Drawing.Point(12, 89);
      this.lblLoja.Name = "lblLoja";
      this.lblLoja.Size = new System.Drawing.Size(27, 13);
      this.lblLoja.TabIndex = 10;
      this.lblLoja.Text = "Loja";
      // 
      // lblColaborador
      // 
      this.lblColaborador.AutoSize = true;
      this.lblColaborador.Location = new System.Drawing.Point(12, 129);
      this.lblColaborador.Name = "lblColaborador";
      this.lblColaborador.Size = new System.Drawing.Size(64, 13);
      this.lblColaborador.TabIndex = 12;
      this.lblColaborador.Text = "Colaborador";
      // 
      // progressBar2
      // 
      this.progressBar2.Location = new System.Drawing.Point(15, 145);
      this.progressBar2.Name = "progressBar2";
      this.progressBar2.Size = new System.Drawing.Size(292, 21);
      this.progressBar2.TabIndex = 11;
      this.progressBar2.Value = 70;
      // 
      // frmProcSalario
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(320, 182);
      this.Controls.Add(this.lblColaborador);
      this.Controls.Add(this.progressBar2);
      this.Controls.Add(this.lblLoja);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.btnIniciar);
      this.Controls.Add(this.cmbAno);
      this.Controls.Add(this.cmbMes);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmProcSalario";
      this.Text = "Lançamento de Salários";
      this.Load += new System.EventHandler(this.frmProcSalario_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cmbMes;
    private System.Windows.Forms.ComboBox cmbAno;
    private System.Windows.Forms.Button btnIniciar;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Label lblLoja;
    private System.Windows.Forms.Label lblColaborador;
    private System.Windows.Forms.ProgressBar progressBar2;
  }
}
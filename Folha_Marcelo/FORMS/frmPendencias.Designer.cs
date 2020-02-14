namespace Folha_Marcelo.VIEW
{
  partial class frmPendencias
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
      this.grdAlertas = new lib.Visual.Components.sknGrid();
      this.panel1 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.txtObservacao = new lib.Visual.Components.sknTextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.btnEncerrarAlerta = new System.Windows.Forms.Button();
      this.btnNovaOcorrencia = new System.Windows.Forms.Button();
      this.txtDataNascimento = new lib.Visual.Components.sknTextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtOcorrencia = new lib.Visual.Components.sknTextBox();
      this.btnEncerrarAlertaNovaOcorrencia = new System.Windows.Forms.Button();
      this.cmbOcorrencia = new lib.Visual.Components.sknComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtColaborador = new lib.Visual.Components.sknTextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtEmpresa = new lib.Visual.Components.sknTextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtAlerta = new lib.Visual.Components.sknTextBox();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.grdAlertas)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // grdAlertas
      // 
      this.grdAlertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdAlertas.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdAlertas.Location = new System.Drawing.Point(0, 0);
      this.grdAlertas.Name = "grdAlertas";
      this.grdAlertas.Size = new System.Drawing.Size(734, 315);
      this.grdAlertas.TabIndex = 0;
      this.grdAlertas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAlertas_CellClick);
      this.grdAlertas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.grdAlertas_KeyUp);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.txtObservacao);
      this.panel1.Controls.Add(this.label7);
      this.panel1.Controls.Add(this.btnEncerrarAlerta);
      this.panel1.Controls.Add(this.btnNovaOcorrencia);
      this.panel1.Controls.Add(this.txtDataNascimento);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.txtOcorrencia);
      this.panel1.Controls.Add(this.btnEncerrarAlertaNovaOcorrencia);
      this.panel1.Controls.Add(this.cmbOcorrencia);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.txtColaborador);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.txtEmpresa);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.txtAlerta);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 315);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(734, 197);
      this.panel1.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(534, 16);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(138, 23);
      this.button1.TabIndex = 17;
      this.button1.Text = "Histórico";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // txtObservacao
      // 
      this.txtObservacao.AsDateTime = new System.DateTime(((long)(0)));
      this.txtObservacao.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtObservacao.AutoTab = true;
      this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtObservacao.Location = new System.Drawing.Point(12, 136);
      this.txtObservacao.Name = "txtObservacao";
      this.txtObservacao.Size = new System.Drawing.Size(660, 20);
      this.txtObservacao.TabIndex = 13;
      this.txtObservacao.TextFormat = null;
      this.txtObservacao.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(12, 120);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(65, 13);
      this.label7.TabIndex = 12;
      this.label7.Text = "Observação";
      // 
      // btnEncerrarAlerta
      // 
      this.btnEncerrarAlerta.Enabled = false;
      this.btnEncerrarAlerta.Location = new System.Drawing.Point(12, 162);
      this.btnEncerrarAlerta.Name = "btnEncerrarAlerta";
      this.btnEncerrarAlerta.Size = new System.Drawing.Size(179, 23);
      this.btnEncerrarAlerta.TabIndex = 14;
      this.btnEncerrarAlerta.Text = "Encerrar Alerta";
      this.btnEncerrarAlerta.UseVisualStyleBackColor = true;
      this.btnEncerrarAlerta.Click += new System.EventHandler(this.btnEncerrarAlerta_Click);
      // 
      // btnNovaOcorrencia
      // 
      this.btnNovaOcorrencia.Enabled = false;
      this.btnNovaOcorrencia.Location = new System.Drawing.Point(197, 162);
      this.btnNovaOcorrencia.Name = "btnNovaOcorrencia";
      this.btnNovaOcorrencia.Size = new System.Drawing.Size(179, 23);
      this.btnNovaOcorrencia.TabIndex = 15;
      this.btnNovaOcorrencia.Text = "Nova Ocorrência";
      this.btnNovaOcorrencia.UseVisualStyleBackColor = true;
      this.btnNovaOcorrencia.Click += new System.EventHandler(this.btnNovaOcorrencia_Click);
      // 
      // txtDataNascimento
      // 
      this.txtDataNascimento.AsDateTime = new System.DateTime(((long)(0)));
      this.txtDataNascimento.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtDataNascimento.AutoTab = true;
      this.txtDataNascimento.Enabled = false;
      this.txtDataNascimento.Location = new System.Drawing.Point(534, 58);
      this.txtDataNascimento.Name = "txtDataNascimento";
      this.txtDataNascimento.Size = new System.Drawing.Size(138, 20);
      this.txtDataNascimento.TabIndex = 7;
      this.txtDataNascimento.TextFormat = null;
      this.txtDataNascimento.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(531, 42);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(80, 13);
      this.label6.TabIndex = 6;
      this.label6.Text = "Dt. Nascimento";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 81);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(59, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Ocorrência";
      // 
      // txtOcorrencia
      // 
      this.txtOcorrencia.AsDateTime = new System.DateTime(((long)(0)));
      this.txtOcorrencia.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtOcorrencia.AutoTab = true;
      this.txtOcorrencia.Enabled = false;
      this.txtOcorrencia.Location = new System.Drawing.Point(12, 97);
      this.txtOcorrencia.Name = "txtOcorrencia";
      this.txtOcorrencia.Size = new System.Drawing.Size(263, 20);
      this.txtOcorrencia.TabIndex = 9;
      this.txtOcorrencia.TextFormat = null;
      this.txtOcorrencia.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // btnEncerrarAlertaNovaOcorrencia
      // 
      this.btnEncerrarAlertaNovaOcorrencia.Enabled = false;
      this.btnEncerrarAlertaNovaOcorrencia.Location = new System.Drawing.Point(382, 162);
      this.btnEncerrarAlertaNovaOcorrencia.Name = "btnEncerrarAlertaNovaOcorrencia";
      this.btnEncerrarAlertaNovaOcorrencia.Size = new System.Drawing.Size(290, 23);
      this.btnEncerrarAlertaNovaOcorrencia.TabIndex = 16;
      this.btnEncerrarAlertaNovaOcorrencia.Text = "Encerrar Alerta/Nova ocorrência";
      this.btnEncerrarAlertaNovaOcorrencia.UseVisualStyleBackColor = true;
      this.btnEncerrarAlertaNovaOcorrencia.Click += new System.EventHandler(this.btnEncerrarAlertaNovaOcorrencia_Click);
      // 
      // cmbOcorrencia
      // 
      this.cmbOcorrencia.AutoTab = true;
      this.cmbOcorrencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbOcorrencia.FormattingEnabled = true;
      this.cmbOcorrencia.Location = new System.Drawing.Point(281, 97);
      this.cmbOcorrencia.Name = "cmbOcorrencia";
      this.cmbOcorrencia.Size = new System.Drawing.Size(391, 21);
      this.cmbOcorrencia.TabIndex = 11;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(278, 81);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(88, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "Nova Ocorrencia";
      // 
      // txtColaborador
      // 
      this.txtColaborador.AsDateTime = new System.DateTime(((long)(0)));
      this.txtColaborador.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtColaborador.AutoTab = true;
      this.txtColaborador.Enabled = false;
      this.txtColaborador.Location = new System.Drawing.Point(219, 58);
      this.txtColaborador.Name = "txtColaborador";
      this.txtColaborador.Size = new System.Drawing.Size(309, 20);
      this.txtColaborador.TabIndex = 5;
      this.txtColaborador.TextFormat = null;
      this.txtColaborador.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(216, 42);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(64, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Colaborador";
      // 
      // txtEmpresa
      // 
      this.txtEmpresa.AsDateTime = new System.DateTime(((long)(0)));
      this.txtEmpresa.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtEmpresa.AutoTab = true;
      this.txtEmpresa.Enabled = false;
      this.txtEmpresa.Location = new System.Drawing.Point(12, 58);
      this.txtEmpresa.Name = "txtEmpresa";
      this.txtEmpresa.Size = new System.Drawing.Size(201, 20);
      this.txtEmpresa.TabIndex = 3;
      this.txtEmpresa.TextFormat = null;
      this.txtEmpresa.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Empresa";
      // 
      // txtAlerta
      // 
      this.txtAlerta.AsDateTime = new System.DateTime(((long)(0)));
      this.txtAlerta.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtAlerta.AutoTab = true;
      this.txtAlerta.Enabled = false;
      this.txtAlerta.Location = new System.Drawing.Point(12, 19);
      this.txtAlerta.Name = "txtAlerta";
      this.txtAlerta.Size = new System.Drawing.Size(516, 20);
      this.txtAlerta.TabIndex = 1;
      this.txtAlerta.TextFormat = null;
      this.txtAlerta.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(34, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Alerta";
      // 
      // frmPendencias
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(734, 512);
      this.Controls.Add(this.grdAlertas);
      this.Controls.Add(this.panel1);
      this.Name = "frmPendencias";
      this.Text = "Pendências";
      this.Load += new System.EventHandler(this.frmPendencias_Load);
      ((System.ComponentModel.ISupportInitialize)(this.grdAlertas)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknGrid grdAlertas;
    private System.Windows.Forms.Panel panel1;
    private lib.Visual.Components.sknTextBox txtAlerta;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnEncerrarAlertaNovaOcorrencia;
    private lib.Visual.Components.sknComboBox cmbOcorrencia;
    private System.Windows.Forms.Label label4;
    private lib.Visual.Components.sknTextBox txtColaborador;
    private System.Windows.Forms.Label label3;
    private lib.Visual.Components.sknTextBox txtEmpresa;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label5;
    private lib.Visual.Components.sknTextBox txtOcorrencia;
    private lib.Visual.Components.sknTextBox txtDataNascimento;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnEncerrarAlerta;
    private System.Windows.Forms.Button btnNovaOcorrencia;
    private lib.Visual.Components.sknTextBox txtObservacao;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button button1;
  }
}
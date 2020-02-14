namespace Folha_Marcelo.VIEW
{
  partial class frmHistorico
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
      this.cmbColaborador = new lib.Visual.Components.sknComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.cmbEmpresas = new lib.Visual.Components.sknComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.sknPanel1 = new lib.Visual.Components.sknPanel();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.grdHistorico = new lib.Visual.Components.sknGrid();
      this.panel2 = new System.Windows.Forms.Panel();
      this.btnEditarHistorico = new System.Windows.Forms.Button();
      this.btnRemoverHistorico = new System.Windows.Forms.Button();
      this.btnAdicionarHistorico = new System.Windows.Forms.Button();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.lstAlertas = new lib.Visual.Components.sknListBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnEditarAlerta = new System.Windows.Forms.Button();
      this.btnRemoverAlertas = new System.Windows.Forms.Button();
      this.btnAdicionarAlertas = new System.Windows.Forms.Button();
      this.sknPanel1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdHistorico)).BeginInit();
      this.panel2.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmbColaborador
      // 
      this.cmbColaborador.AutoTab = true;
      this.cmbColaborador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbColaborador.FormattingEnabled = true;
      this.cmbColaborador.Location = new System.Drawing.Point(210, 24);
      this.cmbColaborador.Name = "cmbColaborador";
      this.cmbColaborador.Size = new System.Drawing.Size(312, 21);
      this.cmbColaborador.TabIndex = 7;
      this.cmbColaborador.SelectedIndexChanged += new System.EventHandler(this.cmbColaborador_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(210, 8);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(64, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Colaborador";
      // 
      // cmbEmpresas
      // 
      this.cmbEmpresas.AutoTab = true;
      this.cmbEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbEmpresas.FormattingEnabled = true;
      this.cmbEmpresas.Location = new System.Drawing.Point(12, 24);
      this.cmbEmpresas.Name = "cmbEmpresas";
      this.cmbEmpresas.Size = new System.Drawing.Size(192, 21);
      this.cmbEmpresas.TabIndex = 5;
      this.cmbEmpresas.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresas_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Empresa";
      // 
      // sknPanel1
      // 
      this.sknPanel1.Controls.Add(this.label1);
      this.sknPanel1.Controls.Add(this.cmbEmpresas);
      this.sknPanel1.Controls.Add(this.cmbColaborador);
      this.sknPanel1.Controls.Add(this.label2);
      this.sknPanel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.sknPanel1.Location = new System.Drawing.Point(0, 0);
      this.sknPanel1.Name = "sknPanel1";
      this.sknPanel1.Size = new System.Drawing.Size(534, 55);
      this.sknPanel1.TabIndex = 9;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 55);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(534, 457);
      this.tabControl1.TabIndex = 10;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.grdHistorico);
      this.tabPage1.Controls.Add(this.panel2);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(526, 431);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Histórico";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // grdHistorico
      // 
      this.grdHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdHistorico.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdHistorico.Location = new System.Drawing.Point(3, 32);
      this.grdHistorico.Name = "grdHistorico";
      this.grdHistorico.Size = new System.Drawing.Size(520, 396);
      this.grdHistorico.TabIndex = 9;
      this.grdHistorico.DoubleClick += new System.EventHandler(this.grdHistorico_DoubleClick);
      this.grdHistorico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdHistorico_KeyDown);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.btnEditarHistorico);
      this.panel2.Controls.Add(this.btnRemoverHistorico);
      this.panel2.Controls.Add(this.btnAdicionarHistorico);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(3, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(520, 29);
      this.panel2.TabIndex = 10;
      // 
      // btnEditarHistorico
      // 
      this.btnEditarHistorico.Location = new System.Drawing.Point(84, 3);
      this.btnEditarHistorico.Name = "btnEditarHistorico";
      this.btnEditarHistorico.Size = new System.Drawing.Size(75, 23);
      this.btnEditarHistorico.TabIndex = 2;
      this.btnEditarHistorico.Text = "Editar";
      this.btnEditarHistorico.UseVisualStyleBackColor = true;
      this.btnEditarHistorico.Click += new System.EventHandler(this.btnEditarHistorico_Click);
      // 
      // btnRemoverHistorico
      // 
      this.btnRemoverHistorico.Location = new System.Drawing.Point(165, 3);
      this.btnRemoverHistorico.Name = "btnRemoverHistorico";
      this.btnRemoverHistorico.Size = new System.Drawing.Size(75, 23);
      this.btnRemoverHistorico.TabIndex = 1;
      this.btnRemoverHistorico.Text = "Remover";
      this.btnRemoverHistorico.UseVisualStyleBackColor = true;
      this.btnRemoverHistorico.Click += new System.EventHandler(this.btnRemoverHistorico_Click);
      // 
      // btnAdicionarHistorico
      // 
      this.btnAdicionarHistorico.Location = new System.Drawing.Point(3, 3);
      this.btnAdicionarHistorico.Name = "btnAdicionarHistorico";
      this.btnAdicionarHistorico.Size = new System.Drawing.Size(75, 23);
      this.btnAdicionarHistorico.TabIndex = 0;
      this.btnAdicionarHistorico.Text = "Adicionar";
      this.btnAdicionarHistorico.UseVisualStyleBackColor = true;
      this.btnAdicionarHistorico.Click += new System.EventHandler(this.btnAdicionarHistorico_Click);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.lstAlertas);
      this.tabPage2.Controls.Add(this.panel1);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(526, 431);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Alertas";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // lstAlertas
      // 
      this.lstAlertas.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lstAlertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstAlertas.FormattingEnabled = true;
      this.lstAlertas.ItemHeight = 20;
      this.lstAlertas.Location = new System.Drawing.Point(3, 32);
      this.lstAlertas.Name = "lstAlertas";
      this.lstAlertas.Size = new System.Drawing.Size(520, 396);
      this.lstAlertas.TabIndex = 2;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnEditarAlerta);
      this.panel1.Controls.Add(this.btnRemoverAlertas);
      this.panel1.Controls.Add(this.btnAdicionarAlertas);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(520, 29);
      this.panel1.TabIndex = 1;
      // 
      // btnEditarAlerta
      // 
      this.btnEditarAlerta.Location = new System.Drawing.Point(84, 3);
      this.btnEditarAlerta.Name = "btnEditarAlerta";
      this.btnEditarAlerta.Size = new System.Drawing.Size(75, 23);
      this.btnEditarAlerta.TabIndex = 2;
      this.btnEditarAlerta.Text = "Editar";
      this.btnEditarAlerta.UseVisualStyleBackColor = true;
      this.btnEditarAlerta.Click += new System.EventHandler(this.btnEditarAlerta_Click);
      // 
      // btnRemoverAlertas
      // 
      this.btnRemoverAlertas.Location = new System.Drawing.Point(165, 3);
      this.btnRemoverAlertas.Name = "btnRemoverAlertas";
      this.btnRemoverAlertas.Size = new System.Drawing.Size(75, 23);
      this.btnRemoverAlertas.TabIndex = 1;
      this.btnRemoverAlertas.Text = "Remover";
      this.btnRemoverAlertas.UseVisualStyleBackColor = true;
      this.btnRemoverAlertas.Click += new System.EventHandler(this.btnRemoverAlertas_Click);
      // 
      // btnAdicionarAlertas
      // 
      this.btnAdicionarAlertas.Location = new System.Drawing.Point(3, 3);
      this.btnAdicionarAlertas.Name = "btnAdicionarAlertas";
      this.btnAdicionarAlertas.Size = new System.Drawing.Size(75, 23);
      this.btnAdicionarAlertas.TabIndex = 0;
      this.btnAdicionarAlertas.Text = "Adicionar";
      this.btnAdicionarAlertas.UseVisualStyleBackColor = true;
      this.btnAdicionarAlertas.Click += new System.EventHandler(this.btnAdicionarAlertas_Click);
      // 
      // frmHistorico
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(534, 512);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.sknPanel1);
      this.Name = "frmHistorico";
      this.Text = "Historico";
      this.Load += new System.EventHandler(this.Historico_Load);
      this.sknPanel1.ResumeLayout(false);
      this.sknPanel1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grdHistorico)).EndInit();
      this.panel2.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknComboBox cmbColaborador;
    private System.Windows.Forms.Label label2;
    private lib.Visual.Components.sknComboBox cmbEmpresas;
    private System.Windows.Forms.Label label1;
    private lib.Visual.Components.sknPanel sknPanel1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private lib.Visual.Components.sknGrid grdHistorico;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button btnRemoverHistorico;
    private System.Windows.Forms.Button btnAdicionarHistorico;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnRemoverAlertas;
    private System.Windows.Forms.Button btnAdicionarAlertas;
    private System.Windows.Forms.Button btnEditarHistorico;
    private System.Windows.Forms.Button btnEditarAlerta;
    private lib.Visual.Components.sknListBox lstAlertas;
  }
}
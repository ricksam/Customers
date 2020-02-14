namespace Financeiro_Marcelo
{
  partial class CarregaVendas
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
      this.tmrVendas = new System.Windows.Forms.Timer(this.components);
      this.grpVendas = new System.Windows.Forms.GroupBox();
      this.pbSincronismo = new System.Windows.Forms.ProgressBar();
      this.lblSincronismo = new System.Windows.Forms.Label();
      this.txtNuFormulario = new lib.Visual.Components.sknTextBox();
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.sknLabel3 = new lib.Visual.Components.sknLabel();
      this.grdVendas = new lib.Visual.Components.sknGrid();
      this.lblTotal = new lib.Visual.Components.sknLabel();
      this.sknButton1 = new lib.Visual.Components.sknButton();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.grpVendas.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdVendas)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.sknButton1);
      this.pnlContext.Controls.Add(this.lblTotal);
      this.pnlContext.Controls.Add(this.grdVendas);
      this.pnlContext.Controls.Add(this.sknLabel3);
      this.pnlContext.Controls.Add(this.sknLabel2);
      this.pnlContext.Controls.Add(this.sknLabel1);
      this.pnlContext.Controls.Add(this.txtNuFormulario);
      this.pnlContext.Controls.Add(this.grpVendas);
      this.pnlContext.Size = new System.Drawing.Size(694, 343);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 343);
      this.pnlBottom.Size = new System.Drawing.Size(694, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(486, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(582, 8);
      // 
      // tmrVendas
      // 
      this.tmrVendas.Enabled = true;
      this.tmrVendas.Tick += new System.EventHandler(this.tmrVendas_Tick);
      // 
      // grpVendas
      // 
      this.grpVendas.Controls.Add(this.pbSincronismo);
      this.grpVendas.Controls.Add(this.lblSincronismo);
      this.grpVendas.Enabled = false;
      this.grpVendas.Location = new System.Drawing.Point(12, 4);
      this.grpVendas.Name = "grpVendas";
      this.grpVendas.Size = new System.Drawing.Size(432, 65);
      this.grpVendas.TabIndex = 0;
      this.grpVendas.TabStop = false;
      this.grpVendas.Text = "Sincronizando";
      // 
      // pbSincronismo
      // 
      this.pbSincronismo.Location = new System.Drawing.Point(6, 32);
      this.pbSincronismo.Name = "pbSincronismo";
      this.pbSincronismo.Size = new System.Drawing.Size(420, 23);
      this.pbSincronismo.TabIndex = 1;
      // 
      // lblSincronismo
      // 
      this.lblSincronismo.AutoSize = true;
      this.lblSincronismo.Location = new System.Drawing.Point(6, 16);
      this.lblSincronismo.Name = "lblSincronismo";
      this.lblSincronismo.Size = new System.Drawing.Size(56, 13);
      this.lblSincronismo.TabIndex = 0;
      this.lblSincronismo.Text = "Aguarde...";
      // 
      // txtNuFormulario
      // 
      this.txtNuFormulario.AsDateTime = new System.DateTime(((long)(0)));
      this.txtNuFormulario.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtNuFormulario.AutoTab = true;
      this.txtNuFormulario.Location = new System.Drawing.Point(65, 317);
      this.txtNuFormulario.Name = "txtNuFormulario";
      this.txtNuFormulario.Size = new System.Drawing.Size(116, 20);
      this.txtNuFormulario.TabIndex = 6;
      this.txtNuFormulario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtNuFormulario.TextFormat = null;
      this.txtNuFormulario.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 301);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(266, 13);
      this.sknLabel1.TabIndex = 4;
      this.sknLabel1.Text = "Selecione uma venda e informe o número do formulário";
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(12, 320);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(47, 13);
      this.sknLabel2.TabIndex = 5;
      this.sknLabel2.Text = "Número:";
      // 
      // sknLabel3
      // 
      this.sknLabel3.AutoSize = true;
      this.sknLabel3.Location = new System.Drawing.Point(12, 72);
      this.sknLabel3.Name = "sknLabel3";
      this.sknLabel3.Size = new System.Drawing.Size(91, 13);
      this.sknLabel3.TabIndex = 2;
      this.sknLabel3.Text = "[Enter] para editar";
      // 
      // grdVendas
      // 
      this.grdVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdVendas.Location = new System.Drawing.Point(12, 88);
      this.grdVendas.Name = "grdVendas";
      this.grdVendas.Size = new System.Drawing.Size(670, 210);
      this.grdVendas.TabIndex = 3;
      this.grdVendas.DoubleClick += new System.EventHandler(this.grdVendas_DoubleClick);
      this.grdVendas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdVendas_KeyDown);
      // 
      // lblTotal
      // 
      this.lblTotal.AutoSize = true;
      this.lblTotal.Location = new System.Drawing.Point(450, 46);
      this.lblTotal.Name = "lblTotal";
      this.lblTotal.Size = new System.Drawing.Size(34, 13);
      this.lblTotal.TabIndex = 1;
      this.lblTotal.Text = "Total:";
      // 
      // sknButton1
      // 
      this.sknButton1.Location = new System.Drawing.Point(582, 20);
      this.sknButton1.Name = "sknButton1";
      this.sknButton1.Size = new System.Drawing.Size(90, 44);
      this.sknButton1.TabIndex = 7;
      this.sknButton1.Text = "Visualizar Relatorio";
      this.sknButton1.UseVisualStyleBackColor = true;
      this.sknButton1.Click += new System.EventHandler(this.sknButton1_Click);
      // 
      // CarregaVendas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(694, 388);
      this.Name = "CarregaVendas";
      this.Text = "Carregar Vendas";
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.grpVendas.ResumeLayout(false);
      this.grpVendas.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdVendas)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Timer tmrVendas;
    private System.Windows.Forms.GroupBox grpVendas;
    private System.Windows.Forms.ProgressBar pbSincronismo;
    private System.Windows.Forms.Label lblSincronismo;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknTextBox txtNuFormulario;
    private lib.Visual.Components.sknLabel sknLabel3;
    private lib.Visual.Components.sknGrid grdVendas;
    private lib.Visual.Components.sknLabel lblTotal;
    private lib.Visual.Components.sknButton sknButton1;
  }
}
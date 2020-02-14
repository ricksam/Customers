namespace GravaVendaArquivo
{
  partial class Principal
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
      this.lblAguarde = new lib.Visual.Components.sknLabel();
      this.tmrReport = new System.Windows.Forms.Timer(this.components);
      this.prgBand = new System.Windows.Forms.ProgressBar();
      this.prgDst = new System.Windows.Forms.ProgressBar();
      this.SuspendLayout();
      // 
      // lblAguarde
      // 
      this.lblAguarde.AutoSize = true;
      this.lblAguarde.Dock = System.Windows.Forms.DockStyle.Top;
      this.lblAguarde.Location = new System.Drawing.Point(0, 0);
      this.lblAguarde.Name = "lblAguarde";
      this.lblAguarde.Size = new System.Drawing.Size(47, 13);
      this.lblAguarde.TabIndex = 0;
      this.lblAguarde.Text = "Aguarde";
      this.lblAguarde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tmrReport
      // 
      this.tmrReport.Enabled = true;
      this.tmrReport.Tick += new System.EventHandler(this.tmrReport_Tick);
      // 
      // prgBand
      // 
      this.prgBand.Location = new System.Drawing.Point(12, 27);
      this.prgBand.Name = "prgBand";
      this.prgBand.Size = new System.Drawing.Size(330, 23);
      this.prgBand.TabIndex = 1;
      // 
      // prgDst
      // 
      this.prgDst.Location = new System.Drawing.Point(12, 56);
      this.prgDst.Name = "prgDst";
      this.prgDst.Size = new System.Drawing.Size(330, 23);
      this.prgDst.TabIndex = 2;
      // 
      // Principal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(354, 97);
      this.ControlBox = false;
      this.Controls.Add(this.prgDst);
      this.Controls.Add(this.prgBand);
      this.Controls.Add(this.lblAguarde);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "Principal";
      this.Text = "Formulario";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private lib.Visual.Components.sknLabel lblAguarde;
    private System.Windows.Forms.Timer tmrReport;
    private System.Windows.Forms.ProgressBar prgBand;
    private System.Windows.Forms.ProgressBar prgDst;
  }
}


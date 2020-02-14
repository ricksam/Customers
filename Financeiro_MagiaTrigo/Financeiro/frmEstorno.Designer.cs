namespace MagiaTrigo
{
  partial class frmEstorno
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
      this.Grid = new lib.Visual.Components.sknGrid();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.Grid);
      this.pnlContext.Controls.Add(this.sknLabel1);
      this.pnlContext.Size = new System.Drawing.Size(600, 286);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 286);
      this.pnlBottom.Size = new System.Drawing.Size(600, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(392, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(488, 8);
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.sknLabel1.Location = new System.Drawing.Point(0, 0);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(323, 13);
      this.sknLabel1.TabIndex = 3;
      this.sknLabel1.Text = "Marque as baixas que deseja estornar e depois clique em confirmar";
      this.sknLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Grid
      // 
      this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Grid.Location = new System.Drawing.Point(0, 13);
      this.Grid.MultiSelect = false;
      this.Grid.Name = "Grid";
      this.Grid.Size = new System.Drawing.Size(600, 273);
      this.Grid.TabIndex = 2;
      this.Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellContentClick);
      // 
      // frmEstorno
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(600, 331);
      this.Name = "frmEstorno";
      this.Text = "Estorno";
      this.Activated += new System.EventHandler(this.frmEstorno_Activated);
      this.Load += new System.EventHandler(this.frmEstorno_Load);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknGrid Grid;

  }
}
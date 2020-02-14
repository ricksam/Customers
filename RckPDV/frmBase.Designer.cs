namespace RckPDV
{
  partial class frmBase
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
      this.btnWindowClose = new System.Windows.Forms.Button();
      this.btnWindowMinimize = new System.Windows.Forms.Button();
      this.lblWindowTitle = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnWindowClose
      // 
      this.btnWindowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnWindowClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
      this.btnWindowClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnWindowClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
      this.btnWindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnWindowClose.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnWindowClose.ForeColor = System.Drawing.Color.White;
      this.btnWindowClose.Location = new System.Drawing.Point(242, 6);
      this.btnWindowClose.Name = "btnWindowClose";
      this.btnWindowClose.Size = new System.Drawing.Size(30, 18);
      this.btnWindowClose.TabIndex = 2;
      this.btnWindowClose.TabStop = false;
      this.btnWindowClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.btnWindowClose.UseVisualStyleBackColor = false;
      this.btnWindowClose.Click += new System.EventHandler(this.button2_Click);
      this.btnWindowClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
      this.btnWindowClose.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
      this.btnWindowClose.MouseHover += new System.EventHandler(this.btn_MouseHover);
      // 
      // btnWindowMinimize
      // 
      this.btnWindowMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnWindowMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnWindowMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnWindowMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnWindowMinimize.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnWindowMinimize.ForeColor = System.Drawing.Color.White;
      this.btnWindowMinimize.Location = new System.Drawing.Point(206, 6);
      this.btnWindowMinimize.Name = "btnWindowMinimize";
      this.btnWindowMinimize.Size = new System.Drawing.Size(30, 18);
      this.btnWindowMinimize.TabIndex = 1;
      this.btnWindowMinimize.TabStop = false;
      this.btnWindowMinimize.UseVisualStyleBackColor = false;
      this.btnWindowMinimize.Click += new System.EventHandler(this.button1_Click);
      this.btnWindowMinimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
      this.btnWindowMinimize.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
      this.btnWindowMinimize.MouseHover += new System.EventHandler(this.btn_MouseHover);
      // 
      // lblWindowTitle
      // 
      this.lblWindowTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
      this.lblWindowTitle.Dock = System.Windows.Forms.DockStyle.Top;
      this.lblWindowTitle.Font = new System.Drawing.Font("Arial Black", 10F);
      this.lblWindowTitle.ForeColor = System.Drawing.Color.White;
      this.lblWindowTitle.Location = new System.Drawing.Point(0, 0);
      this.lblWindowTitle.Name = "lblWindowTitle";
      this.lblWindowTitle.Padding = new System.Windows.Forms.Padding(5);
      this.lblWindowTitle.Size = new System.Drawing.Size(284, 30);
      this.lblWindowTitle.TabIndex = 0;
      this.lblWindowTitle.Text = "[titulo]";
      this.lblWindowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lblWindowTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.frmBase_Paint);
      // 
      // frmBase
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.ClientSize = new System.Drawing.Size(284, 262);
      this.ControlBox = false;
      this.Controls.Add(this.btnWindowMinimize);
      this.Controls.Add(this.btnWindowClose);
      this.Controls.Add(this.lblWindowTitle);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.KeyPreview = true;
      this.Name = "frmBase";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "frmBase";
      this.Load += new System.EventHandler(this.frmBase_Load);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmBase_Paint);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBase_KeyDown);
      this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmBase_KeyPress);
      this.ResumeLayout(false);

    }

    #endregion

    public System.Windows.Forms.Label lblWindowTitle;
    public System.Windows.Forms.Button btnWindowClose;
    public System.Windows.Forms.Button btnWindowMinimize;

  }
}
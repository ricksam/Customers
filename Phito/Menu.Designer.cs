namespace Phito
{
  partial class Menu
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(104, 51);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 39);
      this.button1.TabIndex = 0;
      this.button1.Text = "Totem";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(104, 96);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 39);
      this.button2.TabIndex = 1;
      this.button2.Text = "Atendente";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(104, 141);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 39);
      this.button3.TabIndex = 2;
      this.button3.Text = "Painel";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçãoToolStripMenuItem,
            this.testeToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(284, 24);
      this.menuStrip1.TabIndex = 4;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // configuraçãoToolStripMenuItem
      // 
      this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
      this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
      this.configuraçãoToolStripMenuItem.Text = "Configuração";
      this.configuraçãoToolStripMenuItem.Click += new System.EventHandler(this.configuraçãoToolStripMenuItem_Click);
      // 
      // testeToolStripMenuItem
      // 
      this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
      this.testeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
      this.testeToolStripMenuItem.Text = "Teste";
      this.testeToolStripMenuItem.Click += new System.EventHandler(this.testeToolStripMenuItem_Click_1);
      // 
      // Menu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 209);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Menu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Menu";
      this.Load += new System.EventHandler(this.Menu_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
  }
}
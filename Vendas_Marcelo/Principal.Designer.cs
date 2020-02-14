namespace Vendas_Marcelo
{
  partial class Form1
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
      this.grpProcesso = new System.Windows.Forms.GroupBox();
      this.lblError = new lib.Visual.Components.sknLabel();
      this.lblProcess = new System.Windows.Forms.Label();
      this.grpConfiguracoes = new System.Windows.Forms.GroupBox();
      this.btnBanco = new lib.Visual.Components.sknButton();
      this.button1 = new System.Windows.Forms.Button();
      this.txtArguments = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtProgram = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtTempo = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
      this.tmrProcesso = new System.Windows.Forms.Timer(this.components);
      this.sknButton1 = new lib.Visual.Components.sknButton();
      this.grpProcesso.SuspendLayout();
      this.grpConfiguracoes.SuspendLayout();
      this.SuspendLayout();
      // 
      // grpProcesso
      // 
      this.grpProcesso.Controls.Add(this.lblError);
      this.grpProcesso.Controls.Add(this.lblProcess);
      this.grpProcesso.Location = new System.Drawing.Point(12, 12);
      this.grpProcesso.Name = "grpProcesso";
      this.grpProcesso.Size = new System.Drawing.Size(542, 82);
      this.grpProcesso.TabIndex = 0;
      this.grpProcesso.TabStop = false;
      this.grpProcesso.Text = "Processo";
      // 
      // lblError
      // 
      this.lblError.AutoSize = true;
      this.lblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblError.Location = new System.Drawing.Point(13, 47);
      this.lblError.Name = "lblError";
      this.lblError.Size = new System.Drawing.Size(2, 15);
      this.lblError.TabIndex = 1;
      // 
      // lblProcess
      // 
      this.lblProcess.AutoSize = true;
      this.lblProcess.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblProcess.Location = new System.Drawing.Point(6, 16);
      this.lblProcess.Name = "lblProcess";
      this.lblProcess.Size = new System.Drawing.Size(113, 19);
      this.lblProcess.TabIndex = 0;
      this.lblProcess.Text = "Configuração";
      // 
      // grpConfiguracoes
      // 
      this.grpConfiguracoes.Controls.Add(this.sknButton1);
      this.grpConfiguracoes.Controls.Add(this.btnBanco);
      this.grpConfiguracoes.Controls.Add(this.button1);
      this.grpConfiguracoes.Controls.Add(this.txtArguments);
      this.grpConfiguracoes.Controls.Add(this.label3);
      this.grpConfiguracoes.Controls.Add(this.txtProgram);
      this.grpConfiguracoes.Controls.Add(this.label2);
      this.grpConfiguracoes.Controls.Add(this.txtTempo);
      this.grpConfiguracoes.Controls.Add(this.label1);
      this.grpConfiguracoes.Controls.Add(this.btnSave);
      this.grpConfiguracoes.Location = new System.Drawing.Point(12, 100);
      this.grpConfiguracoes.Name = "grpConfiguracoes";
      this.grpConfiguracoes.Size = new System.Drawing.Size(542, 166);
      this.grpConfiguracoes.TabIndex = 1;
      this.grpConfiguracoes.TabStop = false;
      this.grpConfiguracoes.Text = "Configurações";
      // 
      // btnBanco
      // 
      this.btnBanco.Location = new System.Drawing.Point(110, 30);
      this.btnBanco.Name = "btnBanco";
      this.btnBanco.Size = new System.Drawing.Size(198, 23);
      this.btnBanco.TabIndex = 8;
      this.btnBanco.Text = "Reconfigurar banco de dados";
      this.btnBanco.UseVisualStyleBackColor = true;
      this.btnBanco.Click += new System.EventHandler(this.btnBanco_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(506, 69);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(30, 23);
      this.button1.TabIndex = 7;
      this.button1.Text = "...";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // txtArguments
      // 
      this.txtArguments.Location = new System.Drawing.Point(6, 110);
      this.txtArguments.Name = "txtArguments";
      this.txtArguments.Size = new System.Drawing.Size(530, 20);
      this.txtArguments.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 94);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Argumentos";
      // 
      // txtProgram
      // 
      this.txtProgram.Location = new System.Drawing.Point(6, 71);
      this.txtProgram.Name = "txtProgram";
      this.txtProgram.Size = new System.Drawing.Size(494, 20);
      this.txtProgram.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 55);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(80, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Processar após";
      // 
      // txtTempo
      // 
      this.txtTempo.Location = new System.Drawing.Point(6, 32);
      this.txtTempo.Name = "txtTempo";
      this.txtTempo.Size = new System.Drawing.Size(98, 20);
      this.txtTempo.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Tempo Inicial";
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(461, 136);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 0;
      this.btnSave.Text = "Salvar";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // dlgOpen
      // 
      this.dlgOpen.Filter = "*.exe|*.exe";
      // 
      // tmrProcesso
      // 
      this.tmrProcesso.Tick += new System.EventHandler(this.tmrProcesso_Tick);
      // 
      // sknButton1
      // 
      this.sknButton1.Location = new System.Drawing.Point(314, 30);
      this.sknButton1.Name = "sknButton1";
      this.sknButton1.Size = new System.Drawing.Size(169, 23);
      this.sknButton1.TabIndex = 9;
      this.sknButton1.Text = "Teste envio de dados";
      this.sknButton1.UseVisualStyleBackColor = true;
      this.sknButton1.Click += new System.EventHandler(this.sknButton1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(566, 279);
      this.Controls.Add(this.grpConfiguracoes);
      this.Controls.Add(this.grpProcesso);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.Text = "Principal";
      this.grpProcesso.ResumeLayout(false);
      this.grpProcesso.PerformLayout();
      this.grpConfiguracoes.ResumeLayout(false);
      this.grpConfiguracoes.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox grpProcesso;
    private System.Windows.Forms.GroupBox grpConfiguracoes;
    private System.Windows.Forms.TextBox txtArguments;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtProgram;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtTempo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.OpenFileDialog dlgOpen;
    private System.Windows.Forms.Label lblProcess;
    private System.Windows.Forms.Timer tmrProcesso;
    private lib.Visual.Components.sknButton btnBanco;
    private lib.Visual.Components.sknLabel lblError;
    private lib.Visual.Components.sknButton sknButton1;
  }
}


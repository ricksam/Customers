namespace Financeiro_Marcelo.View.Ajuda
{
    partial class ListaEMail
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
      this.txtEMail = new lib.Visual.Components.sknTextBox();
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.lstEMail = new lib.Visual.Components.sknListBox();
      this.btnAdd = new lib.Visual.Components.sknButton();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.SuspendLayout();
      // 
      // txtEMail
      // 
      this.txtEMail.AsDateTime = new System.DateTime(((long)(0)));
      this.txtEMail.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtEMail.AutoTab = false;
      this.txtEMail.Location = new System.Drawing.Point(12, 25);
      this.txtEMail.Name = "txtEMail";
      this.txtEMail.Size = new System.Drawing.Size(220, 20);
      this.txtEMail.TabIndex = 1;
      this.txtEMail.TextFormat = null;
      this.txtEMail.TextType = lib.Visual.Components.enmTextType.String;
      this.txtEMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEMail_KeyDown);
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 9);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(190, 13);
      this.sknLabel1.TabIndex = 2;
      this.sknLabel1.Text = "EMail ([Enter] para adicionar um e-mail)";
      // 
      // lstEMail
      // 
      this.lstEMail.FormattingEnabled = true;
      this.lstEMail.Location = new System.Drawing.Point(12, 64);
      this.lstEMail.Name = "lstEMail";
      this.lstEMail.Size = new System.Drawing.Size(260, 186);
      this.lstEMail.TabIndex = 3;
      this.lstEMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstEMail_KeyDown);
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(238, 23);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(34, 23);
      this.btnAdd.TabIndex = 4;
      this.btnAdd.Text = "+";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(12, 48);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(251, 13);
      this.sknLabel2.TabIndex = 5;
      this.sknLabel2.Text = "Para remover selecione o email e pressione [Delete]";
      // 
      // ListaEMail
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 262);
      this.Controls.Add(this.sknLabel2);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.lstEMail);
      this.Controls.Add(this.sknLabel1);
      this.Controls.Add(this.txtEMail);
      this.Name = "ListaEMail";
      this.Text = "Lista de Emails";
      this.Load += new System.EventHandler(this.ListaEMail_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private lib.Visual.Components.sknTextBox txtEMail;
        private lib.Visual.Components.sknLabel sknLabel1;
        private lib.Visual.Components.sknListBox lstEMail;
        private lib.Visual.Components.sknButton btnAdd;
        private lib.Visual.Components.sknLabel sknLabel2;

    }
}
namespace SysZoo
{
  partial class frmVendaTicket
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendaTicket));
      this.lstTickets = new System.Windows.Forms.ListBox();
      this.lstVenda = new System.Windows.Forms.ListBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.lblTotal = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnImprimir = new System.Windows.Forms.Button();
      this.btnCancelarItem = new System.Windows.Forms.Button();
      this.btnCancelarVenda = new System.Windows.Forms.Button();
      this.btnGerencia = new System.Windows.Forms.Button();
      this.btnSair = new System.Windows.Forms.Button();
      this.lblOperador = new System.Windows.Forms.Label();
      this.lstPgto = new System.Windows.Forms.ListBox();
      this.pnlDisplay = new System.Windows.Forms.Panel();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.lblDataHora = new System.Windows.Forms.Label();
      this.lblCOM = new System.Windows.Forms.Label();
      this.btnLote = new System.Windows.Forms.Button();
      this.btnUnitario = new System.Windows.Forms.Button();
      this.tmrDataHora = new System.Windows.Forms.Timer(this.components);
      this.lblProcessoInternet = new System.Windows.Forms.Label();
      this.pnlDisplay.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // lblWindowTitle
      // 
      this.lblWindowTitle.Size = new System.Drawing.Size(1024, 30);
      this.lblWindowTitle.Text = "Venda Tickets";
      // 
      // btnWindowClose
      // 
      this.btnWindowClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowClose.BackgroundImage")));
      this.btnWindowClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
      this.btnWindowClose.Location = new System.Drawing.Point(982, 6);
      // 
      // btnWindowMinimize
      // 
      this.btnWindowMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowMinimize.BackgroundImage")));
      this.btnWindowMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnWindowMinimize.Location = new System.Drawing.Point(946, 6);
      // 
      // lstTickets
      // 
      this.lstTickets.BackColor = System.Drawing.Color.Gainsboro;
      this.lstTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.lstTickets.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstTickets.FormattingEnabled = true;
      this.lstTickets.ItemHeight = 27;
      this.lstTickets.Items.AddRange(new object[] {
            "INTEIRA",
            "MEIA"});
      this.lstTickets.Location = new System.Drawing.Point(3, 208);
      this.lstTickets.Name = "lstTickets";
      this.lstTickets.Size = new System.Drawing.Size(200, 351);
      this.lstTickets.TabIndex = 13;
      this.lstTickets.Click += new System.EventHandler(this.lstTickets_Click);
      this.lstTickets.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstTickets_KeyDown);
      // 
      // lstVenda
      // 
      this.lstVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.lstVenda.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstVenda.FormattingEnabled = true;
      this.lstVenda.ItemHeight = 22;
      this.lstVenda.Items.AddRange(new object[] {
            "Inteira     10,00",
            "Inteira     10,00",
            "Inteira     10,00",
            "--------------------",
            "Meia         5,00"});
      this.lstVenda.Location = new System.Drawing.Point(209, 211);
      this.lstVenda.Name = "lstVenda";
      this.lstVenda.Size = new System.Drawing.Size(468, 352);
      this.lstVenda.TabIndex = 17;
      this.lstVenda.Click += new System.EventHandler(this.lstVenda_Click);
      // 
      // label4
      // 
      this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
      this.label4.Font = new System.Drawing.Font("Arial Black", 12F);
      this.label4.ForeColor = System.Drawing.Color.White;
      this.label4.Location = new System.Drawing.Point(3, 168);
      this.label4.Name = "label4";
      this.label4.Padding = new System.Windows.Forms.Padding(5);
      this.label4.Size = new System.Drawing.Size(200, 40);
      this.label4.TabIndex = 20;
      this.label4.Text = "Tickets";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label5
      // 
      this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
      this.label5.Font = new System.Drawing.Font("Arial Black", 12F);
      this.label5.ForeColor = System.Drawing.Color.White;
      this.label5.Location = new System.Drawing.Point(209, 168);
      this.label5.Name = "label5";
      this.label5.Padding = new System.Windows.Forms.Padding(5);
      this.label5.Size = new System.Drawing.Size(468, 40);
      this.label5.TabIndex = 21;
      this.label5.Text = "Venda";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblTotal
      // 
      this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
      this.lblTotal.Font = new System.Drawing.Font("Arial Black", 24F);
      this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
      this.lblTotal.Location = new System.Drawing.Point(683, 208);
      this.lblTotal.Name = "lblTotal";
      this.lblTotal.Padding = new System.Windows.Forms.Padding(5);
      this.lblTotal.Size = new System.Drawing.Size(243, 66);
      this.lblTotal.TabIndex = 23;
      this.lblTotal.Text = "R$ 4.225,00";
      this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
      this.label1.Font = new System.Drawing.Font("Arial Black", 12F);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(683, 168);
      this.label1.Name = "label1";
      this.label1.Padding = new System.Windows.Forms.Padding(5);
      this.label1.Size = new System.Drawing.Size(243, 40);
      this.label1.TabIndex = 22;
      this.label1.Text = "Total";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
      this.label2.Font = new System.Drawing.Font("Arial Black", 12F);
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(683, 274);
      this.label2.Name = "label2";
      this.label2.Padding = new System.Windows.Forms.Padding(5);
      this.label2.Size = new System.Drawing.Size(243, 40);
      this.label2.TabIndex = 24;
      this.label2.Text = "Pagamento";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnImprimir
      // 
      this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnImprimir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnImprimir.ForeColor = System.Drawing.Color.White;
      this.btnImprimir.Location = new System.Drawing.Point(726, 585);
      this.btnImprimir.Name = "btnImprimir";
      this.btnImprimir.Size = new System.Drawing.Size(200, 82);
      this.btnImprimir.TabIndex = 27;
      this.btnImprimir.Text = "&Imprimir";
      this.btnImprimir.UseVisualStyleBackColor = false;
      this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
      // 
      // btnCancelarItem
      // 
      this.btnCancelarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnCancelarItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnCancelarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancelarItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancelarItem.ForeColor = System.Drawing.Color.White;
      this.btnCancelarItem.Location = new System.Drawing.Point(473, 585);
      this.btnCancelarItem.Name = "btnCancelarItem";
      this.btnCancelarItem.Size = new System.Drawing.Size(250, 38);
      this.btnCancelarItem.TabIndex = 28;
      this.btnCancelarItem.Text = "Cancelar Item [DEL]";
      this.btnCancelarItem.UseVisualStyleBackColor = false;
      this.btnCancelarItem.Click += new System.EventHandler(this.btnCancelarItem_Click);
      // 
      // btnCancelarVenda
      // 
      this.btnCancelarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnCancelarVenda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnCancelarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancelarVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancelarVenda.ForeColor = System.Drawing.Color.White;
      this.btnCancelarVenda.Location = new System.Drawing.Point(473, 629);
      this.btnCancelarVenda.Name = "btnCancelarVenda";
      this.btnCancelarVenda.Size = new System.Drawing.Size(250, 38);
      this.btnCancelarVenda.TabIndex = 29;
      this.btnCancelarVenda.Text = "&Cancelar Venda";
      this.btnCancelarVenda.UseVisualStyleBackColor = false;
      this.btnCancelarVenda.Click += new System.EventHandler(this.button3_Click);
      // 
      // btnGerencia
      // 
      this.btnGerencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnGerencia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnGerencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnGerencia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGerencia.ForeColor = System.Drawing.Color.White;
      this.btnGerencia.Location = new System.Drawing.Point(209, 585);
      this.btnGerencia.Name = "btnGerencia";
      this.btnGerencia.Size = new System.Drawing.Size(258, 38);
      this.btnGerencia.TabIndex = 31;
      this.btnGerencia.Text = "&Gerência";
      this.btnGerencia.UseVisualStyleBackColor = false;
      this.btnGerencia.Click += new System.EventHandler(this.button4_Click);
      // 
      // btnSair
      // 
      this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSair.ForeColor = System.Drawing.Color.White;
      this.btnSair.Location = new System.Drawing.Point(209, 629);
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(258, 38);
      this.btnSair.TabIndex = 32;
      this.btnSair.Text = "&Sair";
      this.btnSair.UseVisualStyleBackColor = false;
      this.btnSair.Click += new System.EventHandler(this.button5_Click);
      // 
      // lblOperador
      // 
      this.lblOperador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
      this.lblOperador.Font = new System.Drawing.Font("Arial Black", 12F);
      this.lblOperador.ForeColor = System.Drawing.Color.White;
      this.lblOperador.Location = new System.Drawing.Point(1, 1);
      this.lblOperador.Name = "lblOperador";
      this.lblOperador.Padding = new System.Windows.Forms.Padding(5);
      this.lblOperador.Size = new System.Drawing.Size(628, 40);
      this.lblOperador.TabIndex = 34;
      this.lblOperador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lstPgto
      // 
      this.lstPgto.BackColor = System.Drawing.Color.Gainsboro;
      this.lstPgto.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.lstPgto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstPgto.FormattingEnabled = true;
      this.lstPgto.ItemHeight = 22;
      this.lstPgto.Items.AddRange(new object[] {
            "INTEIRA",
            "MEIA"});
      this.lstPgto.Location = new System.Drawing.Point(683, 317);
      this.lstPgto.Name = "lstPgto";
      this.lstPgto.Size = new System.Drawing.Size(243, 264);
      this.lstPgto.TabIndex = 35;
      this.lstPgto.Click += new System.EventHandler(this.lstPgto_Click);
      this.lstPgto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstPgto_KeyDown);
      // 
      // pnlDisplay
      // 
      this.pnlDisplay.BackColor = System.Drawing.Color.White;
      this.pnlDisplay.Controls.Add(this.pictureBox3);
      this.pnlDisplay.Controls.Add(this.pictureBox2);
      this.pnlDisplay.Controls.Add(this.pictureBox1);
      this.pnlDisplay.Controls.Add(this.lblDataHora);
      this.pnlDisplay.Controls.Add(this.lblCOM);
      this.pnlDisplay.Controls.Add(this.btnLote);
      this.pnlDisplay.Controls.Add(this.btnUnitario);
      this.pnlDisplay.Controls.Add(this.lblOperador);
      this.pnlDisplay.Controls.Add(this.lstPgto);
      this.pnlDisplay.Controls.Add(this.lstTickets);
      this.pnlDisplay.Controls.Add(this.lstVenda);
      this.pnlDisplay.Controls.Add(this.label4);
      this.pnlDisplay.Controls.Add(this.btnSair);
      this.pnlDisplay.Controls.Add(this.label5);
      this.pnlDisplay.Controls.Add(this.btnGerencia);
      this.pnlDisplay.Controls.Add(this.label1);
      this.pnlDisplay.Controls.Add(this.btnCancelarVenda);
      this.pnlDisplay.Controls.Add(this.lblTotal);
      this.pnlDisplay.Controls.Add(this.btnCancelarItem);
      this.pnlDisplay.Controls.Add(this.label2);
      this.pnlDisplay.Controls.Add(this.btnImprimir);
      this.pnlDisplay.Location = new System.Drawing.Point(46, 44);
      this.pnlDisplay.Name = "pnlDisplay";
      this.pnlDisplay.Size = new System.Drawing.Size(930, 670);
      this.pnlDisplay.TabIndex = 36;
      // 
      // pictureBox3
      // 
      this.pictureBox3.Image = global::SysZoo.Properties.Resources.Atlantis;
      this.pictureBox3.Location = new System.Drawing.Point(705, 44);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(222, 121);
      this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox3.TabIndex = 42;
      this.pictureBox3.TabStop = false;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = global::SysZoo.Properties.Resources.Nova_Imagem__1_;
      this.pictureBox2.Location = new System.Drawing.Point(374, 44);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(222, 121);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox2.TabIndex = 41;
      this.pictureBox2.TabStop = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::SysZoo.Properties.Resources.sorocabalogo;
      this.pictureBox1.Location = new System.Drawing.Point(7, 44);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(235, 121);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 40;
      this.pictureBox1.TabStop = false;
      // 
      // lblDataHora
      // 
      this.lblDataHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
      this.lblDataHora.Font = new System.Drawing.Font("Arial Black", 12F);
      this.lblDataHora.ForeColor = System.Drawing.Color.White;
      this.lblDataHora.Location = new System.Drawing.Point(635, 1);
      this.lblDataHora.Name = "lblDataHora";
      this.lblDataHora.Padding = new System.Windows.Forms.Padding(5);
      this.lblDataHora.Size = new System.Drawing.Size(189, 40);
      this.lblDataHora.TabIndex = 39;
      this.lblDataHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblCOM
      // 
      this.lblCOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
      this.lblCOM.Font = new System.Drawing.Font("Arial Black", 12F);
      this.lblCOM.ForeColor = System.Drawing.Color.White;
      this.lblCOM.Location = new System.Drawing.Point(830, 1);
      this.lblCOM.Name = "lblCOM";
      this.lblCOM.Padding = new System.Windows.Forms.Padding(5);
      this.lblCOM.Size = new System.Drawing.Size(100, 40);
      this.lblCOM.TabIndex = 38;
      this.lblCOM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnLote
      // 
      this.btnLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnLote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLote.ForeColor = System.Drawing.Color.White;
      this.btnLote.Location = new System.Drawing.Point(3, 629);
      this.btnLote.Name = "btnLote";
      this.btnLote.Size = new System.Drawing.Size(200, 38);
      this.btnLote.TabIndex = 37;
      this.btnLote.Text = "&Lote [*]";
      this.btnLote.UseVisualStyleBackColor = false;
      this.btnLote.Click += new System.EventHandler(this.btnLote_Click);
      // 
      // btnUnitario
      // 
      this.btnUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnUnitario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnUnitario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnUnitario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnUnitario.ForeColor = System.Drawing.Color.White;
      this.btnUnitario.Location = new System.Drawing.Point(3, 585);
      this.btnUnitario.Name = "btnUnitario";
      this.btnUnitario.Size = new System.Drawing.Size(200, 38);
      this.btnUnitario.TabIndex = 36;
      this.btnUnitario.Text = "&Unitário [ENTER]";
      this.btnUnitario.UseVisualStyleBackColor = false;
      this.btnUnitario.Click += new System.EventHandler(this.btnUnitario_Click);
      // 
      // tmrDataHora
      // 
      this.tmrDataHora.Enabled = true;
      this.tmrDataHora.Interval = 30000;
      this.tmrDataHora.Tick += new System.EventHandler(this.tmrDataHora_Tick);
      // 
      // lblProcessoInternet
      // 
      this.lblProcessoInternet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblProcessoInternet.AutoSize = true;
      this.lblProcessoInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblProcessoInternet.Location = new System.Drawing.Point(12, 746);
      this.lblProcessoInternet.Name = "lblProcessoInternet";
      this.lblProcessoInternet.Size = new System.Drawing.Size(67, 13);
      this.lblProcessoInternet.TabIndex = 37;
      this.lblProcessoInternet.Text = "Sem Internet";
      // 
      // frmVendaTicket
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1024, 768);
      this.Controls.Add(this.lblProcessoInternet);
      this.Controls.Add(this.pnlDisplay);
      this.Name = "frmVendaTicket";
      this.Text = "frmVendaTicket";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVendaTicket_FormClosed);
      this.Load += new System.EventHandler(this.frmVendaTicket_Load);
      this.Controls.SetChildIndex(this.lblWindowTitle, 0);
      this.Controls.SetChildIndex(this.btnWindowClose, 0);
      this.Controls.SetChildIndex(this.btnWindowMinimize, 0);
      this.Controls.SetChildIndex(this.pnlDisplay, 0);
      this.Controls.SetChildIndex(this.lblProcessoInternet, 0);
      this.pnlDisplay.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lstTickets;
    private System.Windows.Forms.ListBox lstVenda;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblTotal;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnImprimir;
    private System.Windows.Forms.Button btnCancelarItem;
    private System.Windows.Forms.Button btnCancelarVenda;
    private System.Windows.Forms.Button btnGerencia;
    private System.Windows.Forms.Button btnSair;
    private System.Windows.Forms.Label lblOperador;
    private System.Windows.Forms.ListBox lstPgto;
    private System.Windows.Forms.Panel pnlDisplay;
    private System.Windows.Forms.Button btnLote;
    private System.Windows.Forms.Button btnUnitario;
    private System.Windows.Forms.Label lblCOM;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label lblDataHora;
    private System.Windows.Forms.Timer tmrDataHora;
    private System.Windows.Forms.Label lblProcessoInternet;
  }
}
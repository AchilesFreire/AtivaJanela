namespace AtivaJanela
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            TxtIntervaloTempo = new TextBox();
            label3 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            LblIntervaloDecorrido = new Label();
            LblUltimaTecla = new Label();
            label1 = new Label();
            CboProgramasAtivos = new ComboBox();
            BtnAtualizarProgramasAtivos = new Button();
            ChkRastrearMovimentoMouse = new CheckBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Itm_Iniciar = new ToolStripMenuItem();
            Itm_Parar = new ToolStripMenuItem();
            Itm_Fechar = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 10000;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.FlatAppearance.BorderColor = Color.SteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.SteelBlue;
            button1.Location = new Point(126, 99);
            button1.Name = "button1";
            button1.Size = new Size(85, 34);
            button1.TabIndex = 4;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnIniciar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.Enabled = false;
            button2.FlatAppearance.BorderColor = Color.SteelBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.SteelBlue;
            button2.Location = new Point(217, 99);
            button2.Name = "button2";
            button2.Size = new Size(85, 34);
            button2.TabIndex = 5;
            button2.Text = "Parar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += BtnParar_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(6, 142);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "Parado";
            // 
            // TxtIntervaloTempo
            // 
            TxtIntervaloTempo.BackColor = Color.LightGray;
            TxtIntervaloTempo.ForeColor = Color.SteelBlue;
            TxtIntervaloTempo.Location = new Point(6, 110);
            TxtIntervaloTempo.Name = "TxtIntervaloTempo";
            TxtIntervaloTempo.Size = new Size(88, 23);
            TxtIntervaloTempo.TabIndex = 3;
            TxtIntervaloTempo.Text = "5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(6, 84);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Intervalo (min):";
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Ativa Janela";
            notifyIcon1.Visible = true;
            notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
            // 
            // LblIntervaloDecorrido
            // 
            LblIntervaloDecorrido.Font = new Font("Segoe UI", 9F);
            LblIntervaloDecorrido.ForeColor = Color.SteelBlue;
            LblIntervaloDecorrido.Location = new Point(245, 142);
            LblIntervaloDecorrido.Name = "LblIntervaloDecorrido";
            LblIntervaloDecorrido.Size = new Size(57, 20);
            LblIntervaloDecorrido.TabIndex = 2;
            LblIntervaloDecorrido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblUltimaTecla
            // 
            LblUltimaTecla.Font = new Font("Segoe UI", 9F);
            LblUltimaTecla.ForeColor = Color.SteelBlue;
            LblUltimaTecla.Location = new Point(100, 142);
            LblUltimaTecla.Name = "LblUltimaTecla";
            LblUltimaTecla.Size = new Size(85, 20);
            LblUltimaTecla.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Aplicativo Alvo:";
            // 
            // CboProgramasAtivos
            // 
            CboProgramasAtivos.FormattingEnabled = true;
            CboProgramasAtivos.Location = new Point(6, 27);
            CboProgramasAtivos.Name = "CboProgramasAtivos";
            CboProgramasAtivos.Size = new Size(218, 23);
            CboProgramasAtivos.TabIndex = 0;
            // 
            // BtnAtualizarProgramasAtivos
            // 
            BtnAtualizarProgramasAtivos.Location = new Point(230, 27);
            BtnAtualizarProgramasAtivos.Name = "BtnAtualizarProgramasAtivos";
            BtnAtualizarProgramasAtivos.Size = new Size(72, 23);
            BtnAtualizarProgramasAtivos.TabIndex = 1;
            BtnAtualizarProgramasAtivos.Text = "Atualizar";
            BtnAtualizarProgramasAtivos.UseVisualStyleBackColor = true;
            BtnAtualizarProgramasAtivos.Click += BtnAtualizarProgramasAtivos_Click;
            // 
            // ChkRastrearMovimentoMouse
            // 
            ChkRastrearMovimentoMouse.AutoSize = true;
            ChkRastrearMovimentoMouse.Location = new Point(6, 56);
            ChkRastrearMovimentoMouse.Name = "ChkRastrearMovimentoMouse";
            ChkRastrearMovimentoMouse.Size = new Size(189, 19);
            ChkRastrearMovimentoMouse.TabIndex = 2;
            ChkRastrearMovimentoMouse.Text = "Rastrear movimento do mouse";
            ChkRastrearMovimentoMouse.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { Itm_Iniciar, Itm_Parar, Itm_Fechar });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(110, 70);
            // 
            // Itm_Iniciar
            // 
            Itm_Iniciar.Name = "Itm_Iniciar";
            Itm_Iniciar.Size = new Size(109, 22);
            Itm_Iniciar.Text = "Iniciar";
            Itm_Iniciar.Click += Itm_Iniciar_Click;
            // 
            // Itm_Parar
            // 
            Itm_Parar.Name = "Itm_Parar";
            Itm_Parar.Size = new Size(109, 22);
            Itm_Parar.Text = "Parar";
            Itm_Parar.Click += Itm_Parar_Click;
            // 
            // Itm_Fechar
            // 
            Itm_Fechar.Name = "Itm_Fechar";
            Itm_Fechar.Size = new Size(109, 22);
            Itm_Fechar.Text = "Fechar";
            Itm_Fechar.Click += Itm_Fechar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(314, 176);
            Controls.Add(ChkRastrearMovimentoMouse);
            Controls.Add(BtnAtualizarProgramasAtivos);
            Controls.Add(CboProgramasAtivos);
            Controls.Add(TxtIntervaloTempo);
            Controls.Add(LblIntervaloDecorrido);
            Controls.Add(LblUltimaTecla);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = Color.SteelBlue;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Shown += FrmPrincipal_Shown;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox TxtIntervaloTempo;
        private Label label3;
        private NotifyIcon notifyIcon1;
        private Label LblIntervaloDecorrido;
        private Label LblUltimaTecla;
        private Label label1;
        private ComboBox CboProgramasAtivos;
        private Button BtnAtualizarProgramasAtivos;
        private CheckBox ChkRastrearMovimentoMouse;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem Itm_Iniciar;
        private ToolStripMenuItem Itm_Parar;
        private ToolStripMenuItem Itm_Fechar;
    }
}
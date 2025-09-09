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
            button1.Location = new Point(100, 21);
            button1.Name = "button1";
            button1.Size = new Size(85, 34);
            button1.TabIndex = 0;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.Enabled = false;
            button2.FlatAppearance.BorderColor = Color.SteelBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.SteelBlue;
            button2.Location = new Point(191, 21);
            button2.Name = "button2";
            button2.Size = new Size(85, 34);
            button2.TabIndex = 0;
            button2.Text = "Parar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "Parado";
            // 
            // TxtIntervaloTempo
            // 
            TxtIntervaloTempo.BackColor = Color.LightGray;
            TxtIntervaloTempo.Location = new Point(6, 32);
            TxtIntervaloTempo.Name = "TxtIntervaloTempo";
            TxtIntervaloTempo.Size = new Size(88, 23);
            TxtIntervaloTempo.TabIndex = 3;
            TxtIntervaloTempo.Text = "5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(6, 6);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Intervalo (min):";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Ativa Janela";
            notifyIcon1.Visible = true;
            notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
            // 
            // LblIntervaloDecorrido
            // 
            LblIntervaloDecorrido.Font = new Font("Segoe UI", 9F);
            LblIntervaloDecorrido.ForeColor = Color.SteelBlue;
            LblIntervaloDecorrido.Location = new Point(219, 63);
            LblIntervaloDecorrido.Name = "LblIntervaloDecorrido";
            LblIntervaloDecorrido.Size = new Size(57, 20);
            LblIntervaloDecorrido.TabIndex = 2;
            LblIntervaloDecorrido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblUltimaTecla
            // 
            LblUltimaTecla.Font = new Font("Segoe UI", 9F);
            LblUltimaTecla.ForeColor = Color.SteelBlue;
            LblUltimaTecla.Location = new Point(100, 63);
            LblUltimaTecla.Name = "LblUltimaTecla";
            LblUltimaTecla.Size = new Size(85, 20);
            LblUltimaTecla.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(280, 93);
            Controls.Add(TxtIntervaloTempo);
            Controls.Add(LblIntervaloDecorrido);
            Controls.Add(LblUltimaTecla);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Shown += FrmPrincipal_Shown;
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
    }
}
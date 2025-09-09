using Microsoft.VisualBasic.Logging;

namespace AtivaJanela
{
    public partial class FrmPrincipal : Form
    {

        private bool IniciadoAutomaticamente = false;
        public string[] Parametros { get; set; }

        long IntervaloTempoSemTecla = 120;
        long TempoSemTecla = 0;
        KeyboardHook kbh;

        private List<String> Teclas = new List<string>() {
            "{INS}",
            "{HOME}",
            "{DOWN}",
            "{END}",
            "{TAB}",
            "{CAPSLOCK}"
        };

        private Boolean Ativo = false;

        private Boolean TecladoAlfaNumerico = false;


        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bool Iniciar = false;
            foreach (var parametro in Parametros)
            {
                if (parametro.Equals("/iniciar", StringComparison.OrdinalIgnoreCase))
                    Iniciar = true;
                if (parametro.Equals("/tecladoalfanumerico", StringComparison.OrdinalIgnoreCase))
                    TecladoAlfaNumerico = true;

            }
            if (TecladoAlfaNumerico)
            {
                Teclas.Clear();
                for (char letra = 'a'; letra <= 'z'; letra++)
                {
                    Teclas.Add("" + letra);
                }
                for (char numero = '0'; numero <= '9'; numero++)
                {
                    Teclas.Add("" + numero);
                }
                Log(Teclas.Count + "Teclado alfanumérico detectado");
                TxtIntervaloTempo.Text = "1";
            }
            else
            {
                var arq = Path.Combine(Application.StartupPath, "Teclas.txt");
                if (File.Exists(arq))
                {
                    var linhas = File.ReadAllLines(arq);

                    Teclas.Clear();
                    Teclas.AddRange(linhas);
                    Log(Teclas.Count + " Teclas detectadas");
                }
            }
            if (Iniciar)
            {
                IniciadoAutomaticamente = true;
                Inicia();
            }

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = Ativo;
            if (Ativo)
                this.Hide();
        }

        private void FrmPrincipal_Shown(object sender, EventArgs e)
        {
            if (IniciadoAutomaticamente)
            {
                this.Hide();
                IniciadoAutomaticamente = false;

            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                TempoSemTecla++;
                LblIntervaloDecorrido.Text = TempoSemTecla.ToString();
                Application.DoEvents();
                if (TempoSemTecla >= IntervaloTempoSemTecla)
                {
                    var pos = DateTime.Now.Millisecond % Teclas.Count;
                    var tecla = Teclas[pos];
                    SendKeys.Send(tecla);
                    Log(tecla);
                    Application.DoEvents();
                    TempoSemTecla = 0;
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message, true);
                SendKeys.Send("{TAB}");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicia();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Para();
        }

        private void Log(String txt, Boolean Erro = false)
        {
            LblUltimaTecla.Text = txt;
            LblUltimaTecla.Refresh();
            Application.DoEvents();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }
        private void Kbh_KeyDown(int wParam, KeyboardHookData lParam)
        {
            TempoSemTecla = 0;
        }
        private void Inicia()
        {
            if (long.TryParse(TxtIntervaloTempo.Text, out long intervalo))
            {
                IntervaloTempoSemTecla = intervalo * 60;
            }
            else
            {
                IntervaloTempoSemTecla = 120;
            }
            LblIntervaloDecorrido.Text = "";
            Application.DoEvents();
            Log($"Intervalo: {IntervaloTempoSemTecla}");
            TxtIntervaloTempo.Enabled = false;
            kbh = new KeyboardHook(true);
            kbh.KeyDown += Kbh_KeyDown;

            timer1.Interval = 1000;
            timer1.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;

            Application.DoEvents();

            label2.Text = "Iniciado";

            Application.DoEvents();

            this.Hide();
            Ativo = true;
        }



        private void Para()
        {
            TxtIntervaloTempo.Enabled = true;
            LblIntervaloDecorrido.Text = "";
            Application.DoEvents();
            if (kbh != null)
            {
                kbh.unhook();
                kbh.KeyDown -= Kbh_KeyDown;
                kbh = null;
            }
            TempoSemTecla = 0;
            timer1.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;
            Application.DoEvents();
            Log("PARADO");
            label2.Text = "Parado";
            Application.DoEvents();
            Ativo = false;
        }
    }
}
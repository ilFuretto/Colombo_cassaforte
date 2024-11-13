namespace Colombo_cassaforte
{
    public partial class Form1 : Form
    {
        private Cassaforte cassaforte1;
        public Form1()
        {
            InitializeComponent();
            cassaforte1 = new Cassaforte("0000001", "Esperia", "X01", "A1209B735XF2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stato.Text = Convert.ToString(cassaforte1.Stato);
            tentativi.Text = Convert.ToString(cassaforte1.TentativiDiSblocco);
        }

        private void Stato()
        {
            if (cassaforte1.Stato)
                stato.Text = "APERTA";
            else
                stato.Text = "CHIUSA";
            if (cassaforte1.StatoDiBlocco == true)
                stato.Text = "BLOCCATA";
        }

        private void TentativiSblocco()
        {
            tentativi.Text = Convert.ToString(cassaforte1.TentativiDiSblocco);
        }
        private void inviaUtente_Click(object sender, EventArgs e)
        {
            if (InserisciUtente.Text.Length != 5)
                return;
            if (cassaforte1.CodiceUtente != null)
            {
                cassaforte1.ApriCassaforte(InserisciUtente.Text);
                Stato();
                TentativiSblocco();
            }

        }


        private void inviaSblocco_Click(object sender, EventArgs e)
        {
            if (InserisciUtente.Text.Length != 12)
                return;
            if (cassaforte1.CodiceSblocco != null)
            {
                cassaforte1.SbloccaCassaforte(inserisciSblocco.Text);
                Stato();
                TentativiSblocco();
            }
        }

        private void inviaImpostaUtente_Click(object sender, EventArgs e)
        {
            bool controllo = false;
            if (impostaUtente.Text.Length != 5)
                return;
            for(int i = 0; i<impostaUtente.Text.Length; i++)
            {
                if (impostaUtente.Text[i] <= '0' && impostaUtente.Text[i] >= '9')
                    controllo=true;
            }
            if (controllo == false)
            {
                cassaforte1.ImpostaCodiceUtente(impostaUtente.Text);
                label4.Visible = false;
                impostaUtente.Visible = false;
                inviaImpostaUtente.Visible = false;
            }
        }
    }
}
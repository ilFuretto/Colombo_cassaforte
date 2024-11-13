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

        public void Form1_Load(object sender, EventArgs e)
        {
            Stato();
            TentativiSblocco();
            label6.Visible = false;
            inserisciData.Visible = false;
            inviaInserisciData.Visible = false;
        }

        public void Stato()
        {
            if (cassaforte1.Stato)
                stato.Text = "APERTA";
            else
                stato.Text = "CHIUSA";
            if (cassaforte1.StatoDiBlocco == true)
                stato.Text = "BLOCCATA";
        }

        public void TentativiSblocco()
        {
            tentativi.Text = Convert.ToString(cassaforte1.TentativiDiSblocco);
        }
        //Metodo per inviare il codice utente senza richiesta data
         
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

        /*Metodo per inviare codice utente con successiva richiesta data NON FINITO
        public void inviaUtente_Click(object sender, EventArgs e)
        {
            if (InserisciUtente.Text.Length != 5)
                return;
            if (cassaforte1.CodiceUtente != null)
            {
                
                
                label6.Visible = true;
                inserisciData.Visible = true;
                inviaInserisciData.Visible = true;
            }
        }*/

        public void inviaSblocco_Click(object sender, EventArgs e)
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

        public void inviaImpostaUtente_Click(object sender, EventArgs e)
        {
            bool controllo = false;
            if (impostaUtente.Text.Length != 5)
                return;
            for (int i = 0; i < impostaUtente.Text.Length; i++)
            {
                if (impostaUtente.Text[i] <= '0' && impostaUtente.Text[i] >= '9')
                    controllo = true;
            }
            if (controllo == false)
            {
                cassaforte1.ImpostaCodiceUtente(impostaUtente.Text);
                label4.Visible = false;
                impostaUtente.Visible = false;
                inviaImpostaUtente.Visible = false;
            }
        }

        public void inviaChiudi_Click(object sender, EventArgs e)
        {
            cassaforte1.ChiudiCassaforte();
            Stato();
        }

        private void inviaImpostaData_Click(object sender, EventArgs e)
        {
            cassaforte1.ImpostaData(impostaData.Text);
            label7.Visible = false;
            impostaData.Visible = false;
            inviaImpostaData.Visible = false;
        }

        private void inviaInserisciData_Click(object sender, EventArgs e)
        {
            cassaforte1.AperturaProgrammata(inserisciData.Text, InserisciUtente.Text);
            Stato();
            TentativiSblocco();
        }
    }
}
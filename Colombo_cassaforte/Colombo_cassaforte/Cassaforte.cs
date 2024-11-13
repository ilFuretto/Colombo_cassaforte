using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colombo_cassaforte
{
    internal class Cassaforte
    {
        private string matricola;
        public string Matricola
        {
            get { return matricola; }
        }
        private string produttore;
        public string Produttore
        {
            get { return produttore; }
        }
        private string modello;
        public string Modello
        {  
            get { return modello; } 
        }
        private string codiceSblocco;
        public string CodiceSblocco
        {
            get { return codiceSblocco; }
        }
        private bool stato;
        public bool Stato
        {
            get { return stato; }
            set { stato = value; }
        }
        private bool statoDiBlocco;
        public bool StatoDiBlocco
        {
            get { return statoDiBlocco; }
            set { statoDiBlocco = value;}
        }
        private string codiceUtente;
        public string CodiceUtente
        {
            get { return codiceUtente; }
        }
        private int tentativiDiSblocco;//inizializzato a 0 visto che non inserito nel costruttore
        public int TentativiDiSblocco
        {
            get { return tentativiDiSblocco; }
            set { tentativiDiSblocco = value; }
        }
       

        public Cassaforte(string matricola, string produttore, string modello, string codiceSblocco) 
        {
            this.matricola = matricola;
            this.produttore = produttore;  
            this.modello = modello;
            if (codiceSblocco.Length != 12)
                return;
            else
                this.codiceSblocco = codiceSblocco;
            this.stato = false;
            this.statoDiBlocco = false;
        }

        public void ImpostaCodiceUtente(string codice)
        {
            if (codice.Length != 5)
                return;
            else
                codiceUtente = codice;
        }

        public void ApriCassaforte(string codice)
        {
            if (StatoDiBlocco==true)
                return;
            if (codice != codiceUtente)
            {
                TentativiDiSblocco++;
                if (TentativiDiSblocco == 4)
                    StatoDiBlocco = true;
                return;
            }
                Stato = true;
        }

        public void ChiudiCassaforte()
        {
            Stato = false;
        }

        public void SbloccaCassaforte(string codice)
        {
            if(codice!=codiceSblocco)
                return;
            StatoDiBlocco = false;
            TentativiDiSblocco = 0;
            Stato = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreSette_AnrangoRamosGionsi
{
    internal class clsCarte
    {

        //un array con i valori accettabili da una carta di questa classe
        private static readonly string[] Valori = {
            "ASSO",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "FANTE",
            "REGINA",
            "RE"
        };
        //un array con i semi accettabili da una carta di questa classe
        public static readonly string[] Semi = {
            "CUORE",
            "PICCHE",
            "QUADRI",
            "FIORE"
        };
        private string valore;
        private string seme;
        private static Random rnd=new Random();

        /**
         * PROPRIETA' DELLA CLASSE
         */

        public string Valore{
            get { return valore; }
            set
            {
                if (Accettabile(value,Valori)) valore = value;
                else throw new Exception("Valore non valido per il gioco TreSette");
            }
        }
       
        public string Seme
        {
            get { return seme; }
            set
            {
                if (Accettabile(value,Semi)) seme = value;
                else throw new Exception("Seme non valido");
            }
        }

        /***
         * COSTRUTTORI
         */

        //classico costruttore con parametri che verranno assegnate alle relative proprietà
        public clsCarte(string _seme, string _valore)
        {
            Seme=_seme; 
            Valore=_valore;
        }
        //Costruttore utile per creare una copia di una carta per parametro
        public clsCarte(clsCarte card):this(card.Seme,card.Valore)
        {
        }
        //nel caso si istanzi un oggetto clsCarte senza parametri allora esso otterrà
        //di default valori casuali
        public clsCarte():this(SemeCasuale(),ValoreCasuale()) {
        }

        /***
         * METODI PRIVATI
         */

        //Le 2 seguenti funzioni ritornano una cella casuale dei valori precaricati
        //di Semi e Valori
        private static string SemeCasuale()
        {
            return Semi[rnd.Next(Semi.Length)];
        }

        private static string ValoreCasuale()
        {
            return Valori[rnd.Next(Valori.Length)];
        }

        //E' una funzione di verifica, torna true se il valore passato per parametro è presente
        //nei valori precaricati di un array
        private bool Accettabile(string value, string[] valori)
        {
            bool accettabile = true;
            int i = 0;
            while (value != valori[i] && i < valori.Length - 1) i++;
            if (valori[i] !=value) accettabile=false;

            return accettabile;
        }

        public string VisDati()
        {
            return "Carta da valore " + Valore + " e seme " + Seme+"\n";
        }

        /**
         * METODI PUBBLICI
         */

        //questo metodo serve per dare un esempio a chi vuole creare una carta nel programma
        public string Proponi()
        {
            return ValoreCasuale() + ", " + SemeCasuale();
        }
    }
}

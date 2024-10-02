using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreSette_AnrangoRamosGionsi
{
    internal class clsMazzoCarte
    {
        //lista di elementi clsCarte 
        private List<clsCarte> Mazzo = new List<clsCarte>();

        //numero progressivo statico
        private static int numCarte = 0;

        private static Random rnd = new Random();
        /***
         * METODI PRIVATI
         */
        private bool cartaGiaEsistente(clsCarte card, List<clsCarte> mazzoCard)
        {
            bool esistente = false;
            int i = 0;
            //string output = "";
            //output += (card != mazzoCard[i]).ToString() + "\n";
            while (((card.Seme != mazzoCard[i].Seme) || (mazzoCard[i].Valore != card.Valore)) && i < numCarte - 1)
            {
                i++;
                //output += (card != mazzoCard[i]).ToString() + "\n";
            }
            if ((card.Seme == mazzoCard[i].Seme) && (mazzoCard[i].Valore == card.Valore)) esistente = true;

            //MessageBox.Show("Esito: "+output);
            return esistente;
        }
        private bool ElementoTrovato(string value, string[] valori)
        {
            bool trovato = false;
            int i = 0;
            while (value != valori[i] && i < valori.Length - 1) i++;
            if (valori[i] == value) trovato = true;

            return trovato;
        }

        /***
         * METODI PUBBLICI
         */
        public void InserisciCarta(clsCarte carta)
        {
            if (numCarte != 0)
            {
                if (numCarte <= 40)
                {
                    if (!cartaGiaEsistente(carta, Mazzo))
                    {
                        Mazzo.Add(carta);
                        numCarte++;
                    }
                    else throw new Exception("Carta già esistente");
                }
                else throw new Exception("Mazzo pieno");
            }
            else
            {
                Mazzo.Add(carta);
                numCarte++;
            }
        }



        //primo metodo DammiCarta, esso restituisce la prima carta nel mazzo
        public clsCarte DammiCarta()
        {
            return Mazzo.FirstOrDefault();
        }

        //questa funzione ricerca una carta O per Valore O per Seme, se la carta non  è
        //presente o valore e seme sono scambiati nel'input tira un eccezione (perchè non trovati)
        public clsCarte[] DammiCarte(string SemeOValore)
        {
            List<clsCarte> retCarte= new List<clsCarte>();  
            string exception="";
            string[] valoreSeme= SemeOValore.Split(' ');

            if(valoreSeme.Length == 2)
            {
                //si ricerca per sentinella, perciò una sola carta sarà trovata
                int i = 0;
                while ((Mazzo[i].Seme != valoreSeme[1] && Mazzo[i].Valore != valoreSeme[0]) && i < numCarte - 1) i++;
                if (Mazzo[i].Seme == valoreSeme[1] && Mazzo[i].Valore == valoreSeme[0]) retCarte.Add(Mazzo[i]) ;
                else exception= "Carta non Presente nel Mazzo";
            }
            else
            {
                //l'insieme di sia semi che valori è non disgiunto e non ordinato perciò si utilizzerà un for
                for (int i = 0; i < numCarte; i++)
                    if (Mazzo[i].Seme == SemeOValore || Mazzo[i].Valore == SemeOValore) retCarte.Add(Mazzo[i]);
                if (retCarte.Count == 0) exception = "Nessuna carta con stringa: " + SemeOValore;
            }

            if (exception == "") return retCarte.ToArray();
            else throw new Exception(exception);
        }

        public void VisualizzaMazzo(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.DataSource = Mazzo;
        }

        //La funzione ritorna una stringa contenente la somma di ogni carta con lo stesso seme
        //Non tira nessuna eccezione perchè anceh se il mazzo fosse vuoto non romperebbe il programma
        public string Totali()
        {
            string output;
            int[] contSemi = new int[4];
            for (int i = 0; i < numCarte; i++)
            {
                if (Mazzo[i].Seme == clsCarte.Semi[0]) contSemi[0]++;
                else
                if (Mazzo[i].Seme == clsCarte.Semi[1]) contSemi[1]++;
                else
                if (Mazzo[i].Seme == clsCarte.Semi[2]) contSemi[2]++;
                else
                if (Mazzo[i].Seme == clsCarte.Semi[3]) contSemi[3]++;
            }
            output = $"{clsCarte.Semi[0]}: {contSemi[0]}\n{clsCarte.Semi[1]}: {contSemi[1]}\n{clsCarte.Semi[2]}: {contSemi[2]}\n{clsCarte.Semi[3]}: {contSemi[3]}";
            return output;
        }

        //Metodo di mescolamento molto semplice dove si utilizzando indici casuali
        public void MescolaCarte()
        {
            int pos;
            for (int i = 0; i < numCarte; i++)
            {
                pos = rnd.Next(numCarte);
                (Mazzo[i], Mazzo[pos]) = (Mazzo[pos], Mazzo[i]);
            }
        }
    }
}

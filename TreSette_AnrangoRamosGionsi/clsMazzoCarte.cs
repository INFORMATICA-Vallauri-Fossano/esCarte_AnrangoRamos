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
        //presente tira un eccezione
        public clsCarte DammiCarta(string SemeOValore)
        {
            int i = 0;
            while ((Mazzo[i].Seme != SemeOValore && Mazzo[i].Valore != SemeOValore) && i < numCarte - 1) i++;
            if (Mazzo[i].Seme == SemeOValore || Mazzo[i].Valore == SemeOValore) return Mazzo[i];
            else throw new Exception("Carta non Presente nel Mazzo");
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

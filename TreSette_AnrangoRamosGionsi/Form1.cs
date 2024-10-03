using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TreSette_AnrangoRamosGionsi
{
    public partial class Form1 : Form
    {
        private clsCarte carta;
        private clsMazzoCarte mazzo=new clsMazzoCarte();    

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carta = new clsCarte();
            VisualizzaCarta();
        }

        private void btnCreaCartaCasuale_Click(object sender, EventArgs e)
        {
            carta = new clsCarte();
            VisualizzaCarta();
        }
        private void VisualizzaCarta()
        {
            lblSemeCartaAttuale.Text = carta.Seme;
            lblValoreCartaAttuale.Text = carta.Valore;
        }

        private void btnProponiCarta_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Ecco un esempio di carta Valida: {carta.Proponi()}", "Example", MessageBoxButtons.OK);
        }

        private void btnCreaCartaConParametri_Click(object sender, EventArgs e)
        {
            string val = txtValoreCarta.Text;
            string sem=txtSemeCarta.Text;

            val=val.Trim().ToUpper();
            sem= sem.Trim().ToUpper();
            try
            {
                carta.Valore= val;
                carta.Seme=sem;

                VisualizzaCarta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'Input: " + ex.Message);
            }
        }

        private void btnInserireCartaNelMazzo_Click(object sender, EventArgs e)
        {
            try
            {
                clsCarte nuovaCarta = new clsCarte(carta);
            mazzo.InserisciCarta(nuovaCarta);
            mazzo.VisualizzaMazzo(dgvMazzoCarte);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }

        private void btnMescolaMazzo_Click(object sender, EventArgs e)
        {
            mazzo.MescolaCarte();
            mazzo.VisualizzaMazzo(dgvMazzoCarte);
        }

        private void btnCercaCarta_Click(object sender, EventArgs e)
        {
            string parametre = Interaction.InputBox("Inserire il valore e/o il seme della carta da cercare. \nSe nulla è inserito sarà pescata la prima carta", "Ricerca carta");
            parametre = parametre.Trim().ToUpper();
            clsCarte[] carteCercate;
            try
            {
                if (parametre == "")
                {
                        carta = mazzo.DammiCarta();
                    if (carta != null)
                    {
                        VisualizzaCarta();
                        MessageBox.Show("Carta trovata con successo e renderizzata correttamente");
                    }
                    else MessageBox.Show("Mazzo vuoto!");
                }
                else
                {
                    carteCercate = mazzo.DammiCarte(parametre);

                    if (carteCercate.Length == 1)
                    {
                        carta= carteCercate[0];
                        
                            VisualizzaCarta();
                            MessageBox.Show("Carta trovata e renderizzata con successo");
                    }
                    else
                    {
                        MessageBox.Show(carta.ToString());
                    string output = "Si è carcata una collezione di carte con "+parametre+" :\n";
                    for (int i = 0; i < carteCercate.Length; i++)
                        output += carteCercate[i].VisDati();
                    MessageBox.Show(output);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }

        private void btnVisualizzaTotali_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mazzo.Totali());
        }
    }
}

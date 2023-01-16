using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ristinolla
{
    public partial class Ristinolla : Form
    {
        int siirtolkm;
        bool siirto = true; //true = X:n vuoro, false = O:n vuoro
        bool yksinpeli;
        bool voitto = false;

        public Ristinolla()
        {
            InitializeComponent();
            
        }
        private bool vaihe1 = true; //Tarkistaa, onko valittu yksin- tai kaksinpeli
        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult res;
            res = MessageBox.Show("Haluatko varmasti lopettaa?", "Suljetaanko?", buttons);
            if (res == DialogResult.Yes)
                this.Close();
            //Lopettaa ohjelman valikosta
        }

        private void btnYksinpeli_Click(object sender, EventArgs e) //Klikkauksen jälkeen vain nimensyöttö mahdollinen
        {
            btnYksinpeli.Enabled = false;
            btnKaksinpeli.Enabled = false;
            btnAloita.Enabled = true;
            txtPelaaja1.Enabled = true;
            txtPelaaja2.Text = "Kone";
            siirtolkm = 0;
            vaihe1 = false;
            yksinpeli = true;
            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            C1.Text = "";
            C2.Text = "";
            C3.Text = "";
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;
            voitto = false;
            
            
            
        }

        private void btnKaksinpeli_Click(object sender, EventArgs e) //Klikauksen jälkeen vain nimensyöttö mahdollinen
        {
            btnYksinpeli.Enabled = false;
            btnKaksinpeli.Enabled = false;
            btnAloita.Enabled = true;
            txtPelaaja1.Enabled = true;
            txtPelaaja2.Enabled = true;
            siirtolkm = 0;
            vaihe1 = false;
            yksinpeli = false;
            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            C1.Text = "";
            C2.Text = "";
            C3.Text = "";
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;
            voitto = false;
        }

        private void btnAloita_Click(object sender, EventArgs e) //Pelikenttä aktivoituu. Muita nappeja ei pysty klikkaamaan. Samalla tarkistus, onko molemmille pelaajille annettu nimi.
        {   
            if (txtPelaaja1.Text == "" && txtPelaaja2.Text == "") 
            {
                MessageBox.Show("Syötä pelaajille nimet!", "Virhe!");
            }
            else if (txtPelaaja1.Text == "" || txtPelaaja2.Text == "")
            {
                MessageBox.Show("Syötä pelaajalle nimi!", "Virhe!");
            }
            else
            {
                btnAloita.Enabled = false;
                txtPelaaja1.Enabled = false;
                txtPelaaja2.Enabled = false;
                pelikentta.Enabled = true;
                lblPelaajaInGame1.Text = txtPelaaja1.Text;
                lblPelaajaInGame2.Text = txtPelaaja2.Text;
                txtPelaaja1.Text = "";
                txtPelaaja2.Text = "";
                lblPelaajaInGame1.Visible = true;
                lblPelaajaInGame2.Visible = true;
                label1.ForeColor = System.Drawing.Color.DarkGreen;
                siirto = true;
            }
        }

        private void tietokonettaVastaanToolStripMenuItem_Click(object sender, EventArgs e) //Valikosta valittu yksinpeli.
        {
            if (vaihe1 == false)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult res;
                res = MessageBox.Show("Haluatko varmasti aloittaa uuden pelin? Tämänhetkistä peliä ei tilastoida.", "Uusi peli?", buttons);
                if (res == DialogResult.Yes)
                {
                    pelikentta.Enabled = false;
                    txtPelaaja1.Enabled = true;
                    txtPelaaja1.Text = "";
                    txtPelaaja2.Text = "Kone";
                    lblPelaajaInGame1.Text = "";
                    lblPelaajaInGame2.Text = "";
                    lblPelaajaInGame1.Visible = false;
                    lblPelaajaInGame2.Visible = false;
                    btnAloita.Enabled = true;
                    siirtolkm = 0;
                    yksinpeli = true;
                    A1.Text = "";
                    A2.Text = "";
                    A3.Text = "";
                    B1.Text = "";
                    B2.Text = "";
                    B3.Text = "";
                    C1.Text = "";
                    C2.Text = "";
                    C3.Text = "";
                    A1.Enabled = true;
                    A2.Enabled = true;
                    A3.Enabled = true;
                    B1.Enabled = true;
                    B2.Enabled = true;
                    B3.Enabled = true;
                    C1.Enabled = true;
                    C2.Enabled = true;
                    C3.Enabled = true;
                    voitto = false;
                }
            }
            else
            {
                btnYksinpeli.Enabled = false;
                btnKaksinpeli.Enabled = false;
                btnAloita.Enabled = true;
                txtPelaaja1.Enabled = true;
                txtPelaaja2.Text = "Kone";
                siirtolkm = 0;
                vaihe1 = false;
                yksinpeli = true;
                A1.Text = "";
                A2.Text = "";
                A3.Text = "";
                B1.Text = "";
                B2.Text = "";
                B3.Text = "";
                C1.Text = "";
                C2.Text = "";
                C3.Text = "";
                A1.Enabled = true;
                A2.Enabled = true;
                A3.Enabled = true;
                B1.Enabled = true;
                B2.Enabled = true;
                B3.Enabled = true;
                C1.Enabled = true;
                C2.Enabled = true;
                C3.Enabled = true;
                voitto = false;
            }
        }

        private void kaksinpeliToolStripMenuItem_Click(object sender, EventArgs e) //Valikosta valittu kaksinpeli.
        {
            if (vaihe1 == false)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult res;
                res = MessageBox.Show("Haluatko varmasti aloittaa uuden pelin? Tämänhetkistä peliä ei tilastoida.", "Uusi peli?", buttons);
                if (res == DialogResult.Yes)
                {
                    pelikentta.Enabled = false;
                    txtPelaaja1.Enabled = true;
                    txtPelaaja1.Text = "";
                    txtPelaaja2.Enabled = true;
                    txtPelaaja2.Text = "";
                    lblPelaajaInGame1.Text = "";
                    lblPelaajaInGame2.Text = "";
                    lblPelaajaInGame1.Visible = false;
                    lblPelaajaInGame2.Visible = false;
                    btnAloita.Enabled = true;
                    siirtolkm = 0;
                    yksinpeli = false;
                    A1.Text = "";
                    A2.Text = "";
                    A3.Text = "";
                    B1.Text = "";
                    B2.Text = "";
                    B3.Text = "";
                    C1.Text = "";
                    C2.Text = "";
                    C3.Text = "";
                    A1.Enabled = true;
                    A2.Enabled = true;
                    A3.Enabled = true;
                    B1.Enabled = true;
                    B2.Enabled = true;
                    B3.Enabled = true;
                    C1.Enabled = true;
                    C2.Enabled = true;
                    C3.Enabled = true;
                    voitto = false;
                }
            }
            else
            {
                btnYksinpeli.Enabled = false;
                btnKaksinpeli.Enabled = false;
                btnAloita.Enabled = true;
                txtPelaaja1.Enabled = true;
                txtPelaaja2.Enabled = true;
                siirtolkm = 0;
                vaihe1 = false;
                yksinpeli = false;
                A1.Text = "";
                A2.Text = "";
                A3.Text = "";
                B1.Text = "";
                B2.Text = "";
                B3.Text = "";
                C1.Text = "";
                C2.Text = "";
                C3.Text = "";
                A1.Enabled = true;
                A2.Enabled = true;
                A3.Enabled = true;
                B1.Enabled = true;
                B2.Enabled = true;
                B3.Enabled = true;
                C1.Enabled = true;
                C2.Enabled = true;
                C3.Enabled = true;
                voitto = false;
            }
        }
        // Pelikentän tapahtumat ristinollan sääntöjen mukaisesti. Selvitetään, onko kaksin- vai yksinpeli. Selvitetään voiton mahdollisuus jokaisen siirron jälkeen.
        // Tietokonetta vastaan pelatessa se käy mahdollisia pelitilanteita läpi ja tekee siirtonsa tilanteen mukaan, kuintenkin seuraavassa järjestyksessä:
        // 1.Voita   2.Estä vastustajan voitto   3.Etsi keskus- tai kulmapaikka   4.Etsi muu tyhjä paikka
        private void A1_Click(object sender, EventArgs e)
        {
            if (siirto == true)
            {
                A1.Text = "X";
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                A1.Text = "O";
                label2.ForeColor = DefaultForeColor;
                label1.ForeColor = System.Drawing.Color.DarkGreen;
            }
            A1.Enabled = false;
            siirtolkm++;
            
            if (yksinpeli == true)
            {
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = DefaultForeColor;
                voittoTarkistus();
                siirto = false;
                if (pelinLoppu() == false) // Mikäli pelaaja voittaa, tällä estetään konetta jatkamasta peliä.
                {
                    if (tietokoneVoitto() == false)
                    {
                        if (estaVoitto() == false)
                        {
                            if (etsiKeskusTaiKulma() == false)
                            {
                                etsiTyhja();
                                siirtolkm++;
                            }
                            else
                                siirtolkm++;
                        }
                        else
                            siirtolkm++;
                    }
                    else
                        siirtolkm++;
                    siirto = true;
                    voittoTarkistus();
                }
            }
            else
            {
                siirto = !siirto;
                voittoTarkistus();               
            }
        }

        private void A2_Click(object sender, EventArgs e)
        {
            if (siirto == true)
            {
                A2.Text = "X";
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                A2.Text = "O";
                label2.ForeColor = DefaultForeColor;
                label1.ForeColor = System.Drawing.Color.DarkGreen;
            }
            A2.Enabled = false;
            siirtolkm++;

            if (yksinpeli == true)
            {
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = DefaultForeColor;
                siirto = false;
                voittoTarkistus();
                if (pelinLoppu() == false)
                {
                    if (tietokoneVoitto() == false)
                    {
                        if (estaVoitto() == false)
                        {
                            if (etsiKeskusTaiKulma() == false)
                            {
                                etsiTyhja();
                                siirtolkm++;
                            }
                            else
                                siirtolkm++;
                        }
                        else
                            siirtolkm++;

                    }
                    else
                        siirtolkm++;
                    siirto = true;
                    voittoTarkistus();
                }
            }

            else
            {
                siirto = !siirto;
                voittoTarkistus();
            }
        }

        private void A3_Click(object sender, EventArgs e)
        {
            if (siirto == true)
            {
                A3.Text = "X";
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                A3.Text = "O";
                label2.ForeColor = DefaultForeColor;
                label1.ForeColor = System.Drawing.Color.DarkGreen;
            }
            A3.Enabled = false;
            siirtolkm++;

            if (yksinpeli == true)
            {
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = DefaultForeColor;
                siirto = false;
                voittoTarkistus();
                if (pelinLoppu() == false)
                {
                    if (tietokoneVoitto() == false)
                    {
                        if (estaVoitto() == false)
                        {
                            if (etsiKeskusTaiKulma() == false)
                            {
                                etsiTyhja();
                                siirtolkm++;
                            }
                            else
                                siirtolkm++;
                        }
                        else
                            siirtolkm++;

                    }
                    else
                        siirtolkm++;
                    siirto = true;
                    voittoTarkistus();
                }
            }

            else
            {
                siirto = !siirto;
                voittoTarkistus();
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (siirto == true)
            {
                B1.Text = "X";
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                B1.Text = "O";
                label2.ForeColor = DefaultForeColor;
                label1.ForeColor = System.Drawing.Color.DarkGreen;
            }
            B1.Enabled = false;
            siirtolkm++;

            if (yksinpeli == true)
            {
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = DefaultForeColor;
                siirto = false;
                voittoTarkistus();
                if (pelinLoppu() == false)
                {
                    if (tietokoneVoitto() == false)
                    {
                        if (estaVoitto() == false)
                        {
                            if (etsiKeskusTaiKulma() == false)
                            {
                                etsiTyhja();
                                siirtolkm++;
                            }
                            else
                                siirtolkm++;
                        }
                        else
                            siirtolkm++;
                    }
                    else
                        siirtolkm++;
                    siirto = true;
                    voittoTarkistus();
                }
            }
            else
            {
                siirto = !siirto;
                voittoTarkistus();
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (siirto == true)
            {
                B2.Text = "X";
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                B2.Text = "O";
                label2.ForeColor = DefaultForeColor;
                label1.ForeColor = System.Drawing.Color.DarkGreen;
            }
            B2.Enabled = false;
            siirtolkm++;

            if (yksinpeli == true)
            {
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = DefaultForeColor;
                siirto = false;
                voittoTarkistus();
                if (pelinLoppu() == false)
                {
                    if (tietokoneVoitto() == false)
                    {
                        if (estaVoitto() == false)
                        {
                            if (etsiKeskusTaiKulma() == false)
                            {
                                etsiTyhja();
                                siirtolkm++;
                            }
                            else
                                siirtolkm++;
                        }
                        else
                            siirtolkm++;
                    }
                    else
                        siirtolkm++;
                    siirto = true;
                    voittoTarkistus();
                }
            }
            else
            {
                siirto = !siirto;
                voittoTarkistus();
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (siirto == true)
            {
                B3.Text = "X";
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                B3.Text = "O";
                label2.ForeColor = DefaultForeColor;
                label1.ForeColor = System.Drawing.Color.DarkGreen;
            }
            B3.Enabled = false;
            siirtolkm++;

            if (yksinpeli == true)
            {
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = DefaultForeColor;
                siirto = false;
                voittoTarkistus();
                if (pelinLoppu() == false)
                {
                    if (tietokoneVoitto() == false)
                    {
                        if (estaVoitto() == false)
                        {
                            if (etsiKeskusTaiKulma() == false)
                            {
                                etsiTyhja();
                                siirtolkm++;
                            }
                            else
                                siirtolkm++;
                        }
                        else
                            siirtolkm++;
                    }
                    else
                        siirtolkm++;
                    siirto = true;
                    voittoTarkistus();
                }
            }
            else
            {
                siirto = !siirto;
                voittoTarkistus();
            }
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (siirto == true)
            {
                C1.Text = "X";
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                C1.Text = "O";
                label2.ForeColor = DefaultForeColor;
                label1.ForeColor = System.Drawing.Color.DarkGreen;
            }
            C1.Enabled = false;
            siirtolkm++;

            if (yksinpeli == true)
            {
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = DefaultForeColor;
                siirto = false;
                voittoTarkistus();
                if (pelinLoppu() == false)
                {
                    if (tietokoneVoitto() == false)
                    {
                        if (estaVoitto() == false)
                        {
                            if (etsiKeskusTaiKulma() == false)
                            {
                                etsiTyhja();
                                siirtolkm++;
                            }
                            else
                                siirtolkm++;
                        }
                        else
                            siirtolkm++;
                    }
                    else
                        siirtolkm++;
                    siirto = true;
                    voittoTarkistus();
                }
            }
            else
            {
                siirto = !siirto;
                voittoTarkistus();
            }
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (siirto == true)
            {
                C2.Text = "X";
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                C2.Text = "O";
                label2.ForeColor = DefaultForeColor;
                label1.ForeColor = System.Drawing.Color.DarkGreen;
            }
            C2.Enabled = false;
            siirtolkm++;

            if (yksinpeli == true)
            {
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = DefaultForeColor;
                siirto = false;
                voittoTarkistus();
                if (pelinLoppu() == false)
                {
                    if (tietokoneVoitto() == false)
                    {
                        if (estaVoitto() == false)
                        {
                            if (etsiKeskusTaiKulma() == false)
                            {
                                etsiTyhja();
                                siirtolkm++;
                            }
                            else
                                siirtolkm++;
                        }
                        else
                            siirtolkm++;
                    }
                    else
                        siirtolkm++;
                    siirto = true;
                    voittoTarkistus();
                }
            }
            else
            {
                siirto = !siirto;
                voittoTarkistus();
            }    
        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (siirto == true)
            {
                C3.Text = "X";
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                C3.Text = "O";
                label2.ForeColor = DefaultForeColor;
                label1.ForeColor = System.Drawing.Color.DarkGreen;
            }
            C3.Enabled = false;
            siirtolkm++;

            if (yksinpeli == true)
            {
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = DefaultForeColor;
                siirto = false;
                voittoTarkistus();
                if (pelinLoppu() == false)
                {
                    if (tietokoneVoitto() == false)
                    {
                        if (estaVoitto() == false)
                        {
                            if (etsiKeskusTaiKulma() == false)
                            {
                                etsiTyhja();
                                siirtolkm++;
                            }
                            else
                                siirtolkm++;
                        }
                        else
                            siirtolkm++;
                    }
                    else
                        siirtolkm++;
                    siirto = true;
                    voittoTarkistus();
                }
            }
            else
            {
                siirto = !siirto;
                voittoTarkistus();
            }
        }
        private bool tietokoneVoitto() //Tietokone pyrkii voittamaan, jos mahdollista
        {
            if (A1.Text == "O" && A2.Text == "O" && A3.Text == "")
            {
                A3.Text = "O";
                A3.Enabled = false;
                return true;
            }
            else if (A1.Text == "O" && A3.Text == "O" && A2.Text == "")
            {
                A2.Text = "O";
                A2.Enabled = false;
                return true;
            }
            else if (A2.Text == "O" && A3.Text == "O" && A1.Text == "")
            {
                A1.Text = "O";
                A1.Enabled = false;
                return true;
            }
            else if (B1.Text == "O" && B2.Text == "O" && B3.Text == "")
            {
                B3.Text = "O";
                B3.Enabled = false;
                return true;
            }
            else if (B1.Text == "O" && B3.Text == "O" && B2.Text == "")
            {
                B2.Text = "O";
                B2.Enabled = false;
                return true;
            }
            else if (B2.Text == "O" && B3.Text == "O" && B1.Text == "")
            {
                B1.Text = "O";
                B1.Enabled = false;
                return true;
            }
            else if (C1.Text == "O" && C2.Text == "O" && C3.Text == "")
            {
                C3.Text = "O";
                C3.Enabled = false;
                return true;
            }
            else if (C1.Text == "O" && C3.Text == "O" && C2.Text == "")
            {
                C2.Text = "O";
                C2.Enabled = false;
                return true;
            }
            else if (C2.Text == "O" && C3.Text == "O" && C1.Text == "")
            {
                C1.Text = "O";
                C1.Enabled = false;
                return true;
            }
            else if (A1.Text == "O" && B1.Text == "O" && C1.Text == "")
            {
                C1.Text = "O";
                C1.Enabled = false;
                return true;
            }
            else if (A1.Text == "O" && C1.Text == "O" && B1.Text == "")
            {
                B1.Text = "O";
                B1.Enabled = false;
                return true;
            }
            else if (B1.Text == "O" && C1.Text == "O" && A1.Text == "")
            {
                A1.Text = "O";
                A1.Enabled = false;
                return true;
            }
            else if (A2.Text == "O" && B2.Text == "O" && C3.Text == "")
            {
                C3.Text = "O";
                C3.Enabled = false;
                return true;
            }
            else if (A2.Text == "O" && C2.Text == "O" && B2.Text == "")
            {
                B2.Text = "O";
                B2.Enabled = false;
                return true;
            }
            else if (B2.Text == "O" && C2.Text == "O" && A2.Text == "")
            {
                A2.Text = "O";
                A2.Enabled = false;
                return true;
            }
            else if (A3.Text == "O" && B3.Text == "O" && C3.Text == "")
            {
                C3.Text = "O";
                C3.Enabled = false;
                return true;
            }
            else if (A3.Text == "O" && C3.Text == "O" && B3.Text == "")
            {
                B3.Text = "O";
                B3.Enabled = false;
                return true;
            }
            else if (B3.Text == "O" && C3.Text == "O" && A3.Text == "")
            {
                A3.Text = "O";
                A3.Enabled = false;
                return true;
            }
            else if (A1.Text == "O" && C3.Text == "O" && B2.Text == "")
            {
                B2.Text = "O";
                B2.Enabled = false;
                return true;
            }
            else if (B2.Text == "O" && C3.Text == "O" && A1.Text == "")
            {
                A1.Text = "O";
                A1.Enabled = false;
                return true;
            }
            else if (A1.Text == "O" && B2.Text == "O" && C3.Text == "")
            {
                C3.Text = "O";
                C3.Enabled = false;
                return true;
            }
            else if (A3.Text == "O" && B2.Text == "O" && C1.Text == "")
            {
                C1.Text = "O";
                C1.Enabled = false;
                return true;
            }
            else if (A3.Text == "O" && C1.Text == "O" && B2.Text == "")
            {
                B2.Text = "O";
                B2.Enabled = false;
                return true;
            }
            else if (C1.Text == "O" && B2.Text == "O" && A3.Text == "")
            {
                A3.Text = "O";
                A3.Enabled = false;
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool estaVoitto() //Tietokone pyrkii estämään vastustajan voiton
        {
            if (A1.Text == "X" && A2.Text == "X" && A3.Text == "")
            {
                A3.Text = "O";
                A3.Enabled = false;
                return true;
            }
            else if (A1.Text == "X" && A3.Text == "X" && A2.Text == "")
            {
                A2.Text = "O";
                A2.Enabled = false;
                return true;
            }
            else if (A2.Text == "X" && A3.Text == "X" && A1.Text == "")
            {
                A1.Text = "O";
                A1.Enabled = false;
                return true;
            }
            else if (B1.Text == "X" && B2.Text == "X" && B3.Text == "")
            {
                B3.Text = "O";
                B3.Enabled = false;
                return true;
            }
            else if (B1.Text == "X" && B3.Text == "X" && B2.Text == "")
            {
                B2.Text = "O";
                B2.Enabled = false;
                return true;
            }
            else if (B2.Text == "X" && B3.Text == "X" && B1.Text == "")
            {
                B1.Text = "O";
                B1.Enabled = false;
                return true;
            }
            else if (C1.Text == "X" && C2.Text == "X" && C3.Text == "")
            {
                C3.Text = "O";
                C3.Enabled = false;
                return true;
            }
            else if (C1.Text == "X" && C3.Text == "X" && C2.Text == "")
            {
                C2.Text = "O";
                C2.Enabled = false;
                return true;
            }
            else if (C2.Text == "X" && C3.Text == "X" && C1.Text == "")
            {
                C1.Text = "O";
                C1.Enabled = false;
                return true;
            }
            else if (A1.Text == "X" && B1.Text == "X" && C1.Text == "")
            {
                C1.Text = "O";
                C1.Enabled = false;
                return true;
            }
            else if (A1.Text == "X" && C1.Text == "X" && B1.Text == "")
            {
                B1.Text = "O";
                B1.Enabled = false;
                return true;
            }
            else if (B1.Text == "X" && C1.Text == "X" && A1.Text == "")
            {
                A1.Text = "O";
                A1.Enabled = false;
                return true;
            }
            else if (A2.Text == "X" && B2.Text == "X" && C2.Text == "")
            {
                C2.Text = "O";
                C2.Enabled = false;
                return true;
            }
            else if (A2.Text == "X" && C2.Text == "X" && B2.Text == "")
            {
                B2.Text = "O";
                B2.Enabled = false;
                return true;
            }
            else if (B2.Text == "X" && C2.Text == "X" && A2.Text == "")
            {
                A2.Text = "O";
                A2.Enabled = false;
                return true;
            }
            else if (A3.Text == "X" && B3.Text == "X" && C3.Text == "")
            {
                C3.Text = "O";
                C3.Enabled = false;
                return true;
            }
            else if (A3.Text == "X" && C3.Text == "X" && B3.Text == "")
            {
                B3.Text = "O";
                B3.Enabled = false;
                return true;
            }
            else if (B3.Text == "X" && C3.Text == "X" && A3.Text == "")
            {
                A3.Text = "O";
                A3.Enabled = false;
                return true;
            }
            else if (A1.Text == "X" && C3.Text == "X" && B2.Text == "")
            {
                B2.Text = "O";
                B2.Enabled = false;
                return true;
            }
            else if (B2.Text == "X" && C3.Text == "X" && A1.Text == "")
            {
                A1.Text = "O";
                A1.Enabled = false;
                return true;
            }
            else if (A1.Text == "X" && B2.Text == "X" && C3.Text == "")
            {
                C3.Text = "O";
                C3.Enabled = false;
                return true;
            }
            else if (A3.Text == "X" && B2.Text == "X" && C1.Text == "")
            {
                C1.Text = "O";
                C1.Enabled = false;
                return true;
            }
            else if (A3.Text == "X" && C1.Text == "X" && B2.Text == "")
            {
                B2.Text = "O";
                B2.Enabled = false;
                return true;
            }
            else if (C1.Text == "X" && B2.Text == "X" && A3.Text == "")
            {
                A3.Text = "O";
                A3.Enabled = false;
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
        private bool etsiKeskusTaiKulma() // Etsitään keskus- tai kulmapaikka.
        {
            
            if (B2.Text == "")
            {
                B2.Text = "O";
                B2.Enabled = false;
                return true;
            }
            else if (A1.Text == "")
            {
                A1.Text = "O";
                A1.Enabled = false;
                return true;
            }
            else if (A3.Text == "")
            {
                A3.Text = "O";
                A3.Enabled = false;
                return true;

            }
            else if (C1.Text == "")
            {
                C1.Text = "O";
                C1.Enabled = false;
                return true;
            }
            else if (C3.Text == "")
            {
                C3.Text = "O";
                C3.Enabled = false;
                return true;
            }
            else
                return false;
               
        }
        private bool etsiTyhja() // Etsitään muu tyhjä tila.
        {
            if (A2.Text == "")
            {
                A2.Text = "O";
                A2.Enabled = false;
                return true;
            }
            else if (B1.Text == "")
            {
                B1.Text = "O";
                B1.Enabled = false;
                return true;
            }
            else if (B3.Text == "")
            {
                B3.Text = "O";
                B3.Enabled = false;
                return true;
            }
            else if (C2.Text == "")
            {
                C2.Text = "O";
                C2.Enabled = false;
                return true;
            }
            else
            {
                return false;
            }

        }
        private void voittoTarkistus()
        {
            //Tarkistus vaakasuunnassa
            if (A1.Text == A2.Text && A2.Text == A3.Text && !A1.Enabled)
                voitto = true;
            if (B1.Text == B2.Text && B2.Text == B3.Text && !B1.Enabled)
                voitto = true;
            if (C1.Text == C2.Text && C2.Text == C3.Text && !C1.Enabled)
                voitto = true;
            //Tarkistus pystysuunnassa
            if (A1.Text == B1.Text && B1.Text == C1.Text && !A1.Enabled)
                voitto = true;
            if (A2.Text == B2.Text && B2.Text == C2.Text && !A2.Enabled)
                voitto = true;
            if (A3.Text == B3.Text && B3.Text == C3.Text && !A3.Enabled)
                voitto = true;
            //Tarkistus vinottain
            if (A1.Text == B2.Text && B2.Text == C3.Text && !A1.Enabled)
                voitto = true;
            if (A3.Text == B2.Text && B2.Text == C1.Text && !A3.Enabled)
                voitto = true;


            

            if (voitto == true) // Tapahtumat voittajan löytyessä.
            {
                string voittaja;
                if (siirto == true)
                    voittaja = lblPelaajaInGame2.Text;
                else
                    voittaja = lblPelaajaInGame1.Text;
                MessageBox.Show(voittaja + " voitti!", "Peli päättyi!");
                btnYksinpeli.Enabled = true;
                btnKaksinpeli.Enabled = true;
                pelikentta.Enabled = false;
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = DefaultForeColor;
                yksinpeli = false;
                vaihe1 = true;
                siirtolkm = 0;
                DateTime aika = DateTime.Now;
                string tiedosto = @"c:\Ristinolla\tilastot.txt"; //Kirjoitetaan tiedostoon tilastot
                StreamWriter sw = new StreamWriter(tiedosto, true);
                if (voittaja == lblPelaajaInGame1.Text)
                {
                    sw.WriteLine(aika);
                    sw.WriteLine(lblPelaajaInGame1.Text + " 1 - 0 " + lblPelaajaInGame2.Text);
                    sw.WriteLine(" ");
                }
                if (voittaja == lblPelaajaInGame2.Text)
                {
                    sw.WriteLine(aika);
                    sw.WriteLine(lblPelaajaInGame1.Text + " 0 - 1 " + lblPelaajaInGame2.Text);
                    sw.WriteLine(" ");
                }
                sw.Close();

            }
            if (siirtolkm >= 9 && voitto == false) // Mikäli tasapeli.
            {
                MessageBox.Show("Tasapeli!", "Peli päättyi!");
                btnYksinpeli.Enabled = true;
                btnKaksinpeli.Enabled = true;
                pelikentta.Enabled = false;
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = DefaultForeColor;
                siirtolkm = 0;
                vaihe1 = true;
                DateTime aika = DateTime.Now;
                string tiedosto = @"c:\Ristinolla\tilastot.txt"; //Kirjoitetaan tiedostoon tilastot
                StreamWriter sw = new StreamWriter(tiedosto, true);
                sw.WriteLine(aika);
                sw.WriteLine(lblPelaajaInGame1.Text + " 0 - 0 " + lblPelaajaInGame2.Text);
                sw.WriteLine(" ");
                sw.Close();

            }
            
        }
        private bool pelinLoppu() // Tällä fuktiolla estetään konetta jatkamasta peliä, mikäli vastustaja on jo voittanut.
        {
            if (voitto == true)
            {
                return true;
            }
            else
                return false;
                
        }

        private void tilastotToolStripMenuItem_Click(object sender, EventArgs e) // Tilastot avautuvat
        {
            System.Diagnostics.Process.Start("notepad.exe", @"c:\Ristinolla\tilastot.txt");
        }
    }
}

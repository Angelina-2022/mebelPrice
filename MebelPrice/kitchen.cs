using System;
using System.Windows.Forms;

namespace MebelPrice
{
    public partial class kitchen : Form
    {

        private double shirina_niz;
        private double vysota_niz;
        private double glubina_niz;

        private double modul_niz;
        private double cena_modula_niz;
        private double cena_fasada_niz;

        private double shirina_verh;
        private double vysota_verh;
        private double glubina_verh;
        private double modul_verh;
        private double cena_modula_verh;
        private double cena_fasada_verh;

        private int cenaYashika1;
        private int cenaYashika2;
        private int kolvo_yashikov1;
        private int kolvo_yashikov2;

        private double cena_stoleshnica;

        private int petli_kolvo;
        private int ruchki_kolvo;
        private int krabi_kolvo;
        private int petli_cena;
        private int ruchki_cena;
        private int krabi_cena;


        private double ploshad_lista = 57960;
        private double nacenka_proizvodstva = 2.2;
        private double nacenka_magazina = 1.4;

        private int cena_moiki;
        private int cena_sushilki;

        private double niz_yarus_itog;
        private double verh_yarus_itog;
        private double itog_stoleshnica;

        private int karkas_niz_int;
        private int fasad_niz_int;
        private int fasad_verh_int;
        private int karkas_verh_int;
        private int itog_yashiki;
        private int itog_stoleshnica_int;
        private int itog_furnitura;
        private int itog_napolnenie;
        private int itog_kuhnay_int;

        private int itog_magazin_int;

        public kitchen()
        {
            InitializeComponent();

        }

        private void kitchen_Load(object sender, EventArgs e)
        {

        }

        private void iscluchenia()
        {
          
            if (string.IsNullOrEmpty(textBox_shirina_niz.Text) && string.IsNullOrEmpty(textBox_vysota_niz.Text) && string.IsNullOrEmpty(textBox_glubina_niz.Text))
            {
                MessageBox.Show("Вы не ввели размеры кухни!");
            }
            if (string.IsNullOrEmpty(textBox_cena_modula_niz.Text))
            {
                MessageBox.Show("Вы не ввели цену модуля!");
            }
            if (string.IsNullOrEmpty(textBox_cena_fasada_niz.Text))
            {
                MessageBox.Show("Вы не ввели цену фасада!");
            }
        }
        private void niz_yarus()
        {
            try { shirina_niz = double.Parse(textBox_shirina_niz.Text); } catch { shirina_niz = 0; }
            try { vysota_niz = double.Parse(textBox_vysota_niz.Text); } catch { vysota_niz = 0; }
            try { glubina_niz = double.Parse(textBox_glubina_niz.Text); } catch { glubina_niz = 0; }
            try { modul_niz = double.Parse(textBox_modul_niz.Text); } catch { modul_niz = 0; }
            try { cena_modula_niz = double.Parse(textBox_cena_modula_niz.Text); } catch { cena_modula_niz = 0; }
            try { cena_fasada_niz = double.Parse(textBox_cena_fasada_niz.Text); } catch { cena_fasada_niz = 0; }

            double karkas_niz = (modul_niz * cena_modula_niz);
            double fasad_niz = (((shirina_niz * vysota_niz) / ploshad_lista) * cena_fasada_niz) * nacenka_proizvodstva;
            niz_yarus_itog = karkas_niz + fasad_niz;

            karkas_niz_int = (int)karkas_niz;
            fasad_niz_int = (int)fasad_niz;
            label_itog_karkas_niz.Text = karkas_niz_int.ToString();
            label_itog_fasad_niz.Text = fasad_niz_int.ToString();
        }
        private void verh_yarus()
        {
            try { shirina_verh = double.Parse(textBox_shirina_verh.Text); } catch { shirina_verh = 0; }
            try { vysota_verh = double.Parse(textBox_vysota_verh.Text); } catch { vysota_verh = 0; }
            try { glubina_verh = double.Parse(textBox_glubina_verh.Text); } catch { glubina_verh = 0; }
            try { modul_verh = double.Parse(textBox_modul_verh.Text); } catch { modul_verh = 0; }
            try { cena_modula_verh = double.Parse(textBox_cena_modula_verh.Text); } catch { cena_modula_verh = 0; }
            try { cena_fasada_verh = double.Parse(textBox_cena_fasada_verh.Text); } catch { cena_fasada_verh = 0; }

            double karkas_verh = (modul_verh * cena_modula_verh);
            double fasad_verh = (((shirina_verh * vysota_verh) / ploshad_lista) * cena_fasada_verh) * nacenka_proizvodstva;
            verh_yarus_itog = karkas_verh + fasad_verh;
            karkas_verh_int = (int)karkas_verh;
            fasad_verh_int = (int)fasad_verh;
            label_itog_karkas_verh.Text = karkas_verh_int.ToString();
            label_itog_fasad_verh.Text = fasad_verh_int.ToString();
        }
        private void yashiki()
        {
            try { cenaYashika1 = int.Parse(textBox_cenaYashika1.Text); } catch { cenaYashika1 = 0; }
            try { cenaYashika2 = int.Parse(textBox_cenaYashika2.Text); } catch { cenaYashika2 = 0; }
            try { kolvo_yashikov1 = int.Parse(textBox_kolvo_yashikov1.Text); } catch { kolvo_yashikov1 = 0; }
            try { kolvo_yashikov2 = int.Parse(textBox_kolvo_yashikov2.Text); } catch { kolvo_yashikov2 = 0; }

            itog_yashiki = (cenaYashika1 * kolvo_yashikov1) + (cenaYashika2 * kolvo_yashikov2);

            label_itog_yashiki.Text = itog_yashiki.ToString();
        }
        private void stoleshnica()
        {
            try { cena_stoleshnica = double.Parse(textBox_cena_stoleshnici.Text); } catch { cena_stoleshnica = 0; }
            itog_stoleshnica = cena_stoleshnica * nacenka_proizvodstva;
            itog_stoleshnica_int = (int)itog_stoleshnica;
            label_itog_stoleshnica.Text = itog_stoleshnica_int.ToString();
        }
        private void furnitura()
        {
            try { petli_kolvo = int.Parse(textBox_petli_kolvo.Text); } catch { petli_kolvo = 0; }
            try { ruchki_kolvo = int.Parse(textBox_ruchki_kolvo.Text); } catch { ruchki_kolvo = 0; }
            try { krabi_kolvo = int.Parse(textBox_krabi_kolvo.Text); } catch { krabi_kolvo = 0; }
            try { petli_cena = int.Parse(textBox_petli_cena.Text); } catch { petli_cena = 0; }
            try { ruchki_cena = int.Parse(textBox_ruchki_cena.Text); } catch { ruchki_cena = 0; }
            try { krabi_cena = int.Parse(textBox_krabi_cena.Text); } catch { krabi_cena = 0; }
            itog_furnitura = (petli_kolvo * petli_cena) + (ruchki_kolvo * ruchki_cena) + (krabi_kolvo * krabi_cena);

            label_itog_furnitura.Text = itog_furnitura.ToString();
        }
        private void napolnenie()
        {
            try { cena_moiki = int.Parse(textBox_cena_moiki.Text); } catch { cena_moiki = 0; }
            try { cena_sushilki = int.Parse(textBox_cena_sushilki.Text); } catch { cena_sushilki = 0; }
            itog_napolnenie = cena_moiki + cena_sushilki;
            label_itog_napolnenie.Text = itog_napolnenie.ToString();

        }
        private void kuhnya()
        {
            double itog_kuhnay = niz_yarus_itog + verh_yarus_itog + itog_stoleshnica + itog_yashiki + itog_furnitura + itog_napolnenie;
            double itog_magazin = itog_kuhnay * nacenka_magazina;

            itog_kuhnay_int = (int)itog_kuhnay;
            itog_magazin_int = (int)itog_magazin;

            label_itog_proizvodstvo.Text = itog_kuhnay_int.ToString();
            label_itog_magazin.Text = itog_magazin_int.ToString();
        }
        private void textBox_shirina_niz_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_shirina_niz.Text + e.KeyChar);
                if (value < 1 || value > 600)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_shirina_verh_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_shirina_verh.Text + e.KeyChar);
                if (value < 1 || value > 600)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_vysota_niz_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_vysota_niz.Text + e.KeyChar);
                if (value < 1 || value > 90)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_vysota_verh_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_vysota_verh.Text + e.KeyChar);
                if (value < 1 || value > 130)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_glubina_niz_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_glubina_niz.Text + e.KeyChar);
                if (value < 1 || value > 100)
                {
                    e.Handled = true;

                }
            }
        }

        private void textBox_glubina_verh_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_glubina_verh.Text + e.KeyChar);
                if (value < 1 || value > 100)
                {
                    e.Handled = true;

                }
            }
        }

        private void textBox_modul_niz_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_modul_niz.Text + e.KeyChar);
                if (value < 1 || value > 15)
                {
                    e.Handled = true;

                }
            }
        }

        private void textBox_modul_verh_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_modul_verh.Text + e.KeyChar);
                if (value < 1 || value > 15)
                {
                    e.Handled = true;

                }
            }
        }

        private void textBox_cena_modula_niz_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_cena_modula_niz.Text + e.KeyChar);
                if (value < 1 || value > 10000)
                {
                    e.Handled = true;

                }
            }
        }

        private void textBox_cena_modula_verh_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_cena_modula_verh.Text + e.KeyChar);
                if (value < 1 || value > 10000)
                {
                    e.Handled = true;

                }
            }
        }

        private void textBox_cena_fasada_niz_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_cena_fasada_niz.Text + e.KeyChar);
                if (value < 1 || value > 10000)
                {
                    e.Handled = true;

                }
            }
        }

        private void textBox_cena_fasada_verh_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_cena_fasada_verh.Text + e.KeyChar);
                if (value < 1 || value > 10000)
                {
                    e.Handled = true;

                }
            }
        }

        private void textBox_cenaYashika1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_cenaYashika1.Text + e.KeyChar);
                if (value < 1 || value > 10000)
                {
                    e.Handled = true;

                }
            }
        }

        private void textBox_cenaYashika2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_cenaYashika2.Text + e.KeyChar);
                if (value < 1 || value > 10000)
                {
                    e.Handled = true;

                }
            }
        }

        private void textBox_cena_stoleshnici_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_cena_stoleshnici.Text + e.KeyChar);
                if (value < 1 || value > 10000)
                {
                    e.Handled = true;

                }
            }
        }

        private void textBox_kolvo_yashikov2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_kolvo_yashikov2.Text + e.KeyChar);
                if (value < 1 || value > 15)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_kolvo_yashikov1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_kolvo_yashikov1.Text + e.KeyChar);
                if (value < 1 || value > 15)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_petli_kolvo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_petli_kolvo.Text + e.KeyChar);
                if (value < 1 || value > 35)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_ruchki_kolvo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_ruchki_kolvo.Text + e.KeyChar);
                if (value < 1 || value > 35)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_krabi_kolvo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_krabi_kolvo.Text + e.KeyChar);
                if (value < 1 || value > 35)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_petli_cena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_petli_cena.Text + e.KeyChar);
                if (value < 1 || value > 1000)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_krabi_cena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_krabi_cena.Text + e.KeyChar);
                if (value < 1 || value > 1000)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_ruchki_cena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_ruchki_cena.Text + e.KeyChar);
                if (value < 1 || value > 3000)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_cena_moiki_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_cena_moiki.Text + e.KeyChar);
                if (value < 1 || value > 10000)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_cena_sushilki_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_cena_moiki.Text + e.KeyChar);
                if (value < 1 || value > 6000)
                {
                    e.Handled = true;
                }
            }
        }

        private void clean()
        {

            textBox_shirina_niz.Text = "";
            textBox_vysota_niz.Text = "";
            textBox_glubina_niz.Text = "";
            textBox_modul_niz.Text = "";
            textBox_cena_modula_niz.Text = "";
            textBox_cena_fasada_niz.Text = "";

            textBox_shirina_verh.Text = "";
            textBox_vysota_verh.Text = "";
            textBox_glubina_verh.Text = "";
            textBox_modul_verh.Text = "";
            textBox_cena_modula_verh.Text = "";
            textBox_cena_fasada_verh.Text = "";

            textBox_cenaYashika1.Text = "";
            textBox_cenaYashika2.Text = "";
            textBox_kolvo_yashikov1.Text = "";
            textBox_kolvo_yashikov1.Text = "";

            textBox_cena_stoleshnici.Text = "";

            textBox_petli_kolvo.Text = "";
            textBox_petli_cena.Text = "";
            textBox_ruchki_kolvo.Text = "";
            textBox_ruchki_cena.Text = "";
            textBox_krabi_kolvo.Text = "";
            textBox_krabi_cena.Text = "";
            textBox_cena_moiki.Text = "";
            textBox_cena_sushilki.Text = "";

            label_itog_karkas_niz.Text = "0";
            label_itog_fasad_niz.Text = "0";
            label_itog_karkas_verh.Text = "0";
            label_itog_fasad_verh.Text = "0";
            label_itog_yashiki.Text = "0";
            label_itog_furnitura.Text = "0";
            label_itog_napolnenie.Text = "0";
            label_itog_proizvodstvo.Text = "0";
            label_itog_magazin.Text = "0";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            iscluchenia();
            niz_yarus();
            verh_yarus();
            yashiki();
            stoleshnica();
            furnitura();
            napolnenie();
            kuhnya();
        }

        private void kitchen_FormClosed(object sender, FormClosedEventArgs e)
        {
            typeOfMebel newForm = new typeOfMebel(); // Создаем новую форму
            newForm.Show(); // Отображаем новую форму
        }
    }
}
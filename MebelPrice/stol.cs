using System;
using System.Windows.Forms;

namespace MebelPrice
{
    public partial class stol : Form
    {
        private double shirina_stola;
        private double vysota_stola;
        private double glubina_stola;
        private double cena_mat_stola;
        private double vysota_zad_stenki_stola;
        private double shirina_zad_stenki_stola;

        private double itog_stoleshnica;
        private double itog_bokovie_stenki;
        private double itog_zad_stenka_stola;
        private double itog_polka_stol;
        private double itog_ruchki;
        private double itog_nozhki;

        private double itog_stol;
        private double itog_tymba;
        private double itog_dop;

        private double ploshad_lista = 57960;
        private double nacenka_proizvodstva = 2.2;
        private double nacenka_magazina = 1.4;
        public stol()
        {
            InitializeComponent();
        }

        private void table_Load(object sender, EventArgs e)
        {


        }
        private void iscluchenia()
        {
            if (string.IsNullOrEmpty(textBox_shrinaStola.Text) && string.IsNullOrEmpty(textBox_vysotaStola.Text) && string.IsNullOrEmpty(textBox_glubinaStola.Text))
            {
                MessageBox.Show("Вы не ввели размеры стола!");
            }

            if (string.IsNullOrEmpty(textBox_cena_materiala_stola.Text))
            {
                MessageBox.Show("Вы не ввели цену материала стола!");
            }


        }

        private void stoleshnica()
        {

            try { shirina_stola = double.Parse(textBox_shrinaStola.Text); } catch { shirina_stola = 0; }
            try { vysota_stola = double.Parse(textBox_vysotaStola.Text); } catch { vysota_stola = 0; }
            try { glubina_stola = double.Parse(textBox_glubinaStola.Text); } catch { glubina_stola = 0; }
            try { cena_mat_stola = double.Parse(textBox_cena_materiala_stola.Text); } catch { cena_mat_stola = 0; }

            itog_stoleshnica = (((shirina_stola * glubina_stola) / ploshad_lista) * cena_mat_stola) * nacenka_proizvodstva;
        }
        private void bokStenki()
        {
            double kolvo_stenok;
            try { kolvo_stenok = double.Parse(textBox_kolvo_stenok.Text); } catch { kolvo_stenok = 0; }


            itog_bokovie_stenki = (((vysota_stola * glubina_stola) / ploshad_lista) * cena_mat_stola) * nacenka_proizvodstva;


            itog_bokovie_stenki = ((((vysota_stola * glubina_stola) * kolvo_stenok) / ploshad_lista) * cena_mat_stola) * nacenka_proizvodstva;

        }
        private void zadStenka()
        {
            try { shirina_zad_stenki_stola = double.Parse(textBox_shirina_zad_stenki.Text); } catch { shirina_zad_stenki_stola = 0; }
            try { vysota_zad_stenki_stola = double.Parse(textBox_vysota_zad_stenka.Text); } catch { vysota_zad_stenki_stola = 0; }

            itog_zad_stenka_stola = (((shirina_zad_stenki_stola * vysota_zad_stenki_stola) / ploshad_lista) * cena_mat_stola) * nacenka_proizvodstva;
        }
        private void polkaStol()
        {
            double shirina_polki_stol, glubina_polki_stol;
            try { shirina_polki_stol = double.Parse(textBox_shirina_polki_stol.Text); } catch { shirina_polki_stol = 0; }
            try { glubina_polki_stol = double.Parse(textBox_glubina_polki_stol.Text); } catch { glubina_polki_stol = 0; }

            itog_polka_stol = (((shirina_polki_stol * glubina_polki_stol) / ploshad_lista) * cena_mat_stola) * nacenka_proizvodstva;
        }
        private void ruchki()
        {
            double kolvo_ruchek, cena_ruchek;
            try { kolvo_ruchek = double.Parse(textBox_kolvoRuchek.Text); } catch { kolvo_ruchek = 0; }
            try { cena_ruchek = double.Parse(textBox_cenaRuchek.Text); } catch { cena_ruchek = 0; }
            itog_ruchki = kolvo_ruchek * cena_ruchek;
        }
        private void nozhki()
        {

            double kolvo_nozhek, cena_nozhek;
            try { kolvo_nozhek = double.Parse(textBox_kolvo_nozhek.Text); } catch { kolvo_nozhek = 0; }
            try { cena_nozhek = double.Parse(textBox_cena_nozhki.Text); } catch { cena_nozhek = 0; }
            itog_nozhki = kolvo_nozhek * cena_nozhek;
        }
     
        private void tymba()
        {
            double shirina_tymba, vysota_tymba, glubina_tymba;
            double kolvo_polok;
            double vysota_dverci;
            double cena_yashika, kolvo_yashikov;
            double cena_mat_zad_syenki_tymba;

            try { shirina_tymba = double.Parse(textBox_shirina_tymba.Text); } catch { shirina_tymba = 0; }
            try { vysota_tymba = double.Parse(textBox_vysota_tymba.Text); } catch { vysota_tymba = 0; }
            try { glubina_tymba = double.Parse(textBox_glubina_tymba.Text); } catch { glubina_tymba = 0; }
            try { kolvo_polok = double.Parse(textBox_kolvo_polok_tymba.Text); } catch { kolvo_polok = 0; }
            try { vysota_dverci = double.Parse(textBox_vysota_dverci.Text); } catch { vysota_dverci = 0; }
            try { cena_yashika = double.Parse(textBox_cenaYashika.Text); } catch { cena_yashika = 0; }
            try { kolvo_yashikov = double.Parse(textBox_kolvoYashikov.Text); } catch { kolvo_yashikov = 0; }
            try { cena_mat_zad_syenki_tymba = double.Parse(textBox_cena_materiala_zad_stenki_tymba.Text); } catch { cena_mat_zad_syenki_tymba = 0; }

            double itog_korpus, itog_polki, itog_yuashiki, itog_dverca, itog_zad_stenka;
            itog_korpus = (((((shirina_tymba * glubina_tymba) * 2) / ploshad_lista) * cena_mat_stola) + ((((vysota_tymba * glubina_tymba) * 2) / ploshad_lista) * cena_mat_stola)) * nacenka_proizvodstva;

            itog_polki = ((((shirina_tymba * glubina_tymba) * kolvo_polok) / ploshad_lista) * cena_mat_stola) * nacenka_proizvodstva;

            itog_dverca = (((shirina_tymba * vysota_dverci) / ploshad_lista) * cena_mat_stola) * nacenka_proizvodstva;

            itog_yuashiki = kolvo_yashikov * cena_yashika;

            itog_zad_stenka = (((shirina_tymba * vysota_tymba) / ploshad_lista) * cena_mat_zad_syenki_tymba) * nacenka_proizvodstva;

            itog_tymba = itog_korpus + itog_dverca + itog_yuashiki + itog_polki + itog_zad_stenka;

        }
        private void itog()
        {
            itog_stol = itog_stoleshnica + itog_bokovie_stenki + itog_zad_stenka_stola;
            itog_dop = itog_polka_stol + itog_ruchki + itog_nozhki;

            double itog_stol_out = itog_stol * nacenka_magazina;
            int itog_stol_int = (int)itog_stol_out;
            label_itogStol.Text = itog_stol_int.ToString();

            double itog_dop_out = itog_dop * nacenka_magazina;
            int itog_dop_int = (int)itog_dop_out;
            label_itogDop.Text = itog_dop_int.ToString();

            double itog_tymba_out = itog_tymba * nacenka_magazina;
            int itog_tymba_int = (int)itog_tymba_out;
            label_itogTymba.Text = itog_tymba_int.ToString();


            double itog_proizvodsto = itog_stol + itog_dop + itog_tymba;
            int itog_proizvodstvo_int = (int)itog_proizvodsto;
            label_itog_proizvodstvo.Text = itog_proizvodstvo_int.ToString();


            double itog_magazin = itog_proizvodsto * nacenka_magazina;
            int itog_magazin_int = (int)itog_magazin;
            label_itog_magazin.Text = itog_magazin_int.ToString();
        }


        private void button_schitat_Click(object sender, EventArgs e)
        {
            iscluchenia();
            try
            {
                stoleshnica();
                bokStenki();
                zadStenka();
                polkaStol();
                ruchki();
                nozhki();
                itog();
                tymba();
            }
            catch
            {
                MessageBox.Show("ошибка. Не удалось вычислить");
            }
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_shrinaStola.Text = "";
            textBox_vysotaStola.Text = "";
            textBox_glubinaStola.Text = "";
            textBox_cena_materiala_stola.Text = "";

            textBox_shirina_zad_stenki.Text = "";
            textBox_vysota_zad_stenka.Text = "";

            textBox_glubina_polki_stol.Text = "";
            textBox_shirina_polki_stol.Text = "";

            textBox_kolvoRuchek.Text = "";
            textBox_cenaRuchek.Text = "";

            textBox_cena_nozhki.Text = "";
            textBox_kolvo_nozhek.Text = "";

            textBox_vysota_dverci.Text = "";

            textBox_shirina_tymba.Text = "";
            textBox_vysota_tymba.Text = "";
            textBox_glubina_tymba.Text = "";
            textBox_kolvo_polok_tymba.Text = "";

            textBox_kolvoYashikov.Text = "";
            textBox_cenaYashika.Text = "";
            textBox_cena_materiala_zad_stenki_tymba.Text = "";

            label_itogStol.Text = "0";
            label_itogDop.Text = "0";
            label_itogTymba.Text = "0";

            label_itog_magazin.Text = "0";
            label_itog_proizvodstvo.Text = "0";

        }

        private void textBox_glubinaStola_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_glubinaStola.Text + e.KeyChar);
                if (value < 1 || value > 300)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_shrinaStola_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_shrinaStola.Text + e.KeyChar);
                if (value < 1 || value > 300)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_vysotaStola_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_vysotaStola.Text + e.KeyChar);
                if (value < 1 || value > 100)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_cena_materiala_stola_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_cena_materiala_stola.Text + e.KeyChar);
                if (value < 1 || value > 6000)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_vysota_zad_stenka_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_vysota_zad_stenka.Text + e.KeyChar);
                if (value < 1 || value > 100)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_shirina_zad_stenki_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_shirina_zad_stenki.Text + e.KeyChar);
                if (value < 1 || value > 300)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_glubina_polki_stol_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_glubina_polki_stol.Text + e.KeyChar);
                if (value < 1 || value > 90)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_shirina_polki_stol_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_shirina_polki_stol.Text + e.KeyChar);
                if (value < 1 || value > 300)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_kolvoRuchek_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_kolvoRuchek.Text + e.KeyChar);
                if (value < 1 || value > 10)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_cenaRuchek_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_cenaRuchek.Text + e.KeyChar);
                if (value < 1 || value > 3000)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_kolvo_nozhek_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_kolvo_nozhek.Text + e.KeyChar);
                if (value < 1 || value > 4)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_cena_nozhki_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_cena_nozhki.Text + e.KeyChar);
                if (value < 1 || value > 5000)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_shirina_tymba_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_shirina_tymba.Text + e.KeyChar);
                if (value < 1 || value > 100)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_vysota_tymba_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_vysota_tymba.Text + e.KeyChar);
                if (value < 1 || value > 200)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_glubina_tymba_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_glubina_tymba.Text + e.KeyChar);
                if (value < 1 || value > 100)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_kolvo_polok_tymba_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_kolvo_polok_tymba.Text + e.KeyChar);
                if (value < 1 || value > 15)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_vysota_dverci_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_vysota_dverci.Text + e.KeyChar);
                if (value < 1 || value > 200)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_cenaYashika_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_cenaYashika.Text + e.KeyChar);
                if (value < 1 || value > 7000)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_kolvoYashikov_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_kolvoYashikov.Text + e.KeyChar);
                if (value < 1 || value > 10)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_cena_materiala_zad_stenki_tymba_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_cena_materiala_zad_stenki_tymba.Text + e.KeyChar);
                if (value < 1 || value > 7000)
                {
                    e.Handled = true;
                }
            }
        }

        private void stol_FormClosed(object sender, FormClosedEventArgs e)
        {
            typeOfMebel newForm = new typeOfMebel(); // Создаем новую форму
            newForm.Show(); // Отображаем новую форму
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_kolvo_stenok.Text + e.KeyChar);
                if (value < 1 || value > 2)
                {
                    e.Handled = true;
                }
            }
        }
    }
}

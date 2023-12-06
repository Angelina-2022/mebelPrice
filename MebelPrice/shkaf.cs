using System;
using System.Windows.Forms;

namespace MebelPrice
{
    public partial class shkaf : Form
    {
        //общие переменные 
        private double shirina_shkaf;
        private double vysota_shkaf;
        private double glubina_shkaf;
        private double cena_materiala_korpusa;
        private double cena_materiala_zad_stenki;
        private double kolvo_peregorodok;

        private double shirinaZerkala1;
        private double shirinaZerkala2;
        private double vysotaaZerkala1;
        private double vysotaaZerkala2;

        private int kolvo_ruchek;
        private int kolvo_shtang;
        private int cena_ruchek;
        private int cena_shtang;

        private double shirina_dveri1;
        private double shirina_dveri2;
        private double shirina_dveri3;
        private double shirina_dveri4;
        private double vysota_dveri1;
        private double vysota_dveri2;
        private double vysota_dveri3;
        private double vysota_dveri4;
        private double cena_materiala_dver1;
        private double cena_materiala_dver2;
        private double cena_materiala_dver3;
        private double cena_materiala_dver4;

        private double shirina_polki1;
        private double kolvo_polok1;
        private double shirina_polki2;
        private double kolvo_polok2;
        private double shirina_polki3;
        private double kolvo_polok3;
        private double shirina_polki4;
        private double kolvo_polok4;

        private double kolvoYashikov1;
        private double cenaYashika1;
        private double kolvoYashikov2;
        private double cenaYashika2;

        private double nacenka_proizvodstva = 2.2;
        private double nacenka_magazina = 1.4;

        private double itog_cena_korpus;
        private double itog_zerkala;
        private double itog_furnitura;
        private double itog_dveri;
        private double itog_polki_obshee;
        private double itog_yashiki;

        private int cena_zerkala = 2000;
        //размеры
        private double ploshad_lista = 57960;
        private double ploshad_zerkala = 10000;

        public string file_path;

        public shkaf()
        {
            InitializeComponent();
        }

        private void iscluchenia()
        {
            if (string.IsNullOrEmpty(textBox_shrinaShkafa.Text) && string.IsNullOrEmpty(textBox_vysotaShkafa.Text) && string.IsNullOrEmpty(textBox_glubinaShkafa.Text))
            {
                MessageBox.Show("Вы не ввели размеры шкафа!");
            }

            if (string.IsNullOrEmpty(textBox_cena_materiala_korpusa.Text))
            {
                MessageBox.Show("Вы не ввели цену материала шкафа!");
            }
        }
        private void korpusAll()
        {

            try { shirina_shkaf = double.Parse(textBox_shrinaShkafa.Text); } catch { shirina_shkaf = 0; }
            try { vysota_shkaf = double.Parse(textBox_vysotaShkafa.Text); } catch { vysota_shkaf = 0; }
            try { glubina_shkaf = double.Parse(textBox_glubinaShkafa.Text); } catch { glubina_shkaf = 0; }
            try { cena_materiala_korpusa = double.Parse(textBox_cena_materiala_korpusa.Text); } catch { cena_materiala_korpusa = 0; }

            //корпус

            double cena_sten = (((vysota_shkaf * glubina_shkaf) / ploshad_lista) * cena_materiala_korpusa) * 2;
            double cena_pol_and_potolok = (((shirina_shkaf * glubina_shkaf) / ploshad_lista) * cena_materiala_korpusa) * 2;
            double cena_korpus = cena_sten + cena_pol_and_potolok;

            //задняя стенка
            try { cena_materiala_zad_stenki = double.Parse(textBox_cena_materiala_zad_stenki.Text); } catch { cena_materiala_zad_stenki = 0; }
            double cena_zad_stenki = ((shirina_shkaf * vysota_shkaf) / ploshad_lista) * cena_materiala_zad_stenki;

            //перегородки
            try { kolvo_peregorodok = double.Parse(textBox_kolPeregorodok.Text); } catch { kolvo_peregorodok = 0; }
            double cena_peregorodok = (((vysota_shkaf * glubina_shkaf) / ploshad_lista) * cena_materiala_korpusa) * kolvo_peregorodok;

            itog_cena_korpus = (cena_korpus + cena_zad_stenki + cena_peregorodok) * nacenka_proizvodstva;
            double itog_cena_korpus_out = itog_cena_korpus*nacenka_magazina;
            int itog_cena_korpus_int = (int)itog_cena_korpus_out;
            label_itogKorpus.Text = itog_cena_korpus_int.ToString();
        }
        private void zerkala()
        {


            //зеркало1
            try { shirinaZerkala1 = double.Parse(textBox_shirinaZerkala1.Text); } catch { shirinaZerkala1 = 0; }
            try { vysotaaZerkala1 = double.Parse(textBox_vysotaaZerkala1.Text); } catch { vysotaaZerkala1 = 0; }
            double cena_zerkalo1 = ((shirinaZerkala1 * vysotaaZerkala1) / ploshad_zerkala) * cena_zerkala;

            //зеркало2
            try { shirinaZerkala2 = double.Parse(textBox_shirinaZerkala2.Text); } catch { shirinaZerkala2 = 0; }
            try { vysotaaZerkala2 = double.Parse(textBox_vysotaaZerkala2.Text); } catch { vysotaaZerkala2 = 0; }
            double cena_zerkalo2 = ((shirinaZerkala2 * vysotaaZerkala2) / ploshad_zerkala) * cena_zerkala;

            //общее
            itog_zerkala = cena_zerkalo1 + cena_zerkalo2;
            int itog_zerkala_int = (int)itog_zerkala;
            label_itogZerkala.Text = itog_zerkala_int.ToString();
        }
        private void furnitira()
        {
            //ручки
            try { kolvo_ruchek = int.Parse(textBox_kolvoRuchek.Text); } catch { kolvo_ruchek = 0; }
            try { cena_ruchek = int.Parse(textBox_cenaRuchek.Text); } catch { cena_ruchek = 0; }
            int itog_ruchki = kolvo_ruchek * cena_ruchek;
            //штанги
            try { kolvo_shtang = int.Parse(textBox_kolvoShtang.Text); } catch { kolvo_shtang = 0; }
            try { cena_shtang = int.Parse(textBox_cenaShtang.Text); } catch { cena_shtang = 0; }
            int itog_shtangi = kolvo_shtang * cena_shtang;
            //общее
            itog_furnitura = (itog_ruchki + itog_shtangi);
            int itog_furnitura_int = (int)itog_furnitura;
            label_itogFurniture.Text = itog_furnitura_int.ToString();
        }
        private void dveri()
        {
            //дверь1
            try { shirina_dveri1 = double.Parse(textBox_shirinaDveri1.Text); } catch { shirina_dveri1 = 0; }
            try { vysota_dveri1 = double.Parse(textBox_vysotaDveri1.Text); } catch { vysota_dveri1 = 0; }
            try { cena_materiala_dver1 = double.Parse(textBox_materialDver1.Text); } catch { cena_materiala_dver1 = 0; }

            double itog_dver1 = ((shirina_dveri1 * vysota_dveri1) / ploshad_lista) * cena_materiala_dver1;

            //дверь2
            try { shirina_dveri2 = double.Parse(textBox_shirinaDveri2.Text); } catch { shirina_dveri2 = 0; }
            try { vysota_dveri2 = double.Parse(textBox_vysotaDveri2.Text); } catch { vysota_dveri2 = 0; }
            try { cena_materiala_dver2 = double.Parse(textBox_materialDver2.Text); } catch { cena_materiala_dver2 = 0; }

            double itog_dver2 = ((shirina_dveri2 * vysota_dveri2) / ploshad_lista) * cena_materiala_dver2;

            //дверь3
            try { shirina_dveri3 = double.Parse(textBox_shirinaDveri3.Text); } catch { shirina_dveri3 = 0; }
            try { vysota_dveri3 = double.Parse(textBox_vysotaDveri3.Text); } catch { vysota_dveri3 = 0; }
            try { cena_materiala_dver3 = double.Parse(textBox_materialDver3.Text); } catch { cena_materiala_dver3 = 0; }

            double itog_dver3 = ((shirina_dveri3 * vysota_dveri3) / ploshad_lista) * cena_materiala_dver3;

            //дверь4
            try { shirina_dveri4 = double.Parse(textBox_shirinaDveri4.Text); } catch { shirina_dveri4 = 0; }
            try { vysota_dveri4 = int.Parse(textBox_vysotaDveri4.Text); } catch { vysota_dveri4 = 0; }
            try { cena_materiala_dver4 = int.Parse(textBox_materialDver4.Text); } catch { cena_materiala_dver4 = 0; }

            double itog_dver4 = ((shirina_dveri4 * vysota_dveri4) / ploshad_lista) * cena_materiala_dver4;

            //общее
            itog_dveri = (itog_dver1 + itog_dver2 + itog_dver3 + itog_dver4) * nacenka_proizvodstva;
            double itog_dveri_out = itog_dveri * nacenka_magazina;
            int itog_dveri_int = (int)itog_dveri_out;
            label_itogDveri.Text = itog_dveri_int.ToString();
        }
        private void polki()
        {
            //секция1
            try { shirina_polki1 = double.Parse(textBox_shirinaPolki1.Text); } catch { shirina_polki1 = 0; }
            try { kolvo_polok1 = double.Parse(textBox_kolvoPolok1.Text); } catch { kolvo_polok1 = 0; }
            double itog_polki1 = ((shirina_polki1 * glubina_shkaf) / ploshad_lista) * cena_materiala_korpusa;

            //секция2
            try { shirina_polki2 = double.Parse(textBox_shirinaPolki2.Text); } catch { shirina_polki2 = 0; }
            try { kolvo_polok2 = double.Parse(textBox_kolvoPolok2.Text); } catch { kolvo_polok2 = 0; }
            double itog_polki2 = ((shirina_polki2 * glubina_shkaf) / ploshad_lista) * cena_materiala_korpusa;

            //секция3
            try { shirina_polki3 = double.Parse(textBox_shirinaPolki3.Text); } catch { shirina_polki3 = 0; }
            try { kolvo_polok3 = double.Parse(textBox_kolvoPolok3.Text); } catch { kolvo_polok3 = 0; }
            double itog_polki3 = ((shirina_polki3 * glubina_shkaf) / ploshad_lista) * cena_materiala_korpusa;

            //секция4
            try { shirina_polki4 = double.Parse(textBox_shirinaPolki4.Text); } catch { shirina_polki4 = 0; }
            try { kolvo_polok4 = double.Parse(textBox_kolvoPolok4.Text); } catch { kolvo_polok4 = 0; }
            double itog_polki4 = ((shirina_polki4 * glubina_shkaf) / ploshad_lista) * cena_materiala_korpusa;

            itog_polki_obshee = (itog_polki1 + itog_polki2 + itog_polki3 + itog_polki4) * nacenka_proizvodstva;
            double itog_polki_obshee_out = itog_polki_obshee * nacenka_magazina;
            int itog_polki_obshee_int = (int)itog_polki_obshee_out;

            label_itogPolki.Text = itog_polki_obshee_int.ToString();
        }

        private void yashiki()
        {
            //ящик1
            try { kolvoYashikov1 = int.Parse(textBox_kolvoYashikov1.Text); } catch { kolvoYashikov1 = 0; }
            try { cenaYashika1 = int.Parse(textBox_cenaYashika1.Text); } catch { cenaYashika1 = 0; }
            double itog_yashik1 = cenaYashika1 * kolvoYashikov1;

            //ящик2
            try { kolvoYashikov2 = int.Parse(textBox_kolvoYashikov2.Text); } catch { kolvoYashikov2 = 0; }
            try { cenaYashika2 = int.Parse(textBox_cenaYashika2.Text); } catch { cenaYashika2 = 0; }
            double itog_yashik2 = cenaYashika2 * kolvoYashikov2;

            itog_yashiki = itog_yashik1 + itog_yashik2;
            int itog_yashiki_int = (int)itog_yashiki;
            label_itogYashiki.Text = itog_yashiki_int.ToString();
        }
        private void cenaShkafa()
        {
            double itog_stoimost_proizvodstva = itog_cena_korpus + itog_dveri + itog_zerkala + itog_polki_obshee + itog_furnitura + itog_yashiki;
            int itog_stoimost_proizvodstva_int = (int)itog_stoimost_proizvodstva;
            label_itogStoimostProiz.Text = itog_stoimost_proizvodstva_int.ToString();

            double itog_magazin = itog_stoimost_proizvodstva * nacenka_magazina;
            int itog_magazin_int = (int)itog_magazin;
            label_itogMagazin.Text = itog_magazin_int.ToString();
        }



        private void textBox_vysotaShkafa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_vysotaShkafa.Text + e.KeyChar);
                if (value < 1 || value > 300)
                {
                    e.Handled = true;
                }
            }
        }
        private void textBox_shrinaShkafa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_shrinaShkafa.Text + e.KeyChar);
                if (value < 1 || value > 400)
                {
                    e.Handled = true;
                }
            }
        }
        private void textBox_glubinaShkafa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // Проверяем, что вводимое значение находится в диапазоне от 1 до 70
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_glubinaShkafa.Text + e.KeyChar);
                if (value < 1 || value > 70)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_shirinaDveri1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_shirinaDveri1.Text + e.KeyChar);
                if (value < 1 || value > 400)
                {
                    e.Handled = true;
                }
            }
        }
        private void textBox_shirinaDveri2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_shirinaDveri2.Text + e.KeyChar);
                if (value < 1 || value > 400)
                {
                    e.Handled = true;
                }
            }
        }
        private void textBox_shirinaDveri3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_shirinaDveri3.Text + e.KeyChar);
                if (value < 1 || value > 400)
                {
                    e.Handled = true;
                }
            }
        }
        private void textBox_shirinaDveri4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_shirinaDveri4.Text + e.KeyChar);
                if (value < 1 || value > 400)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_shirinaPolki1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_shirinaPolki1.Text + e.KeyChar);
                if (value < 1 || value > 200)
                {
                    e.Handled = true;
                }
            }
        }
        private void textBox_shirinaPolki2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_shirinaPolki2.Text + e.KeyChar);
                if (value < 1 || value > 200)
                {
                    e.Handled = true;
                }
            }
        }
        private void textBox_shirinaPolki3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_shirinaPolki3.Text + e.KeyChar);
                if (value < 1 || value > 200)
                {
                    e.Handled = true;
                }
            }
        }
        private void textBox_shirinaPolki4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_shirinaPolki4.Text + e.KeyChar);
                if (value < 1 || value > 200)
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
                if (value < 1 || value > 9000)
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
                if (value < 1 || value > 9000)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_kolvoYashikov1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_kolvoYashikov1.Text + e.KeyChar);
                if (value < 1 || value > 20)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_kolvoYashikov2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_kolvoYashikov2.Text + e.KeyChar);
                if (value < 1 || value > 20)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_cena_materiala_korpusa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_cena_materiala_korpusa.Text + e.KeyChar);
                if (value < 1 || value > 10000)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_cena_materiala_zad_stenki_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_cena_materiala_zad_stenki.Text + e.KeyChar);
                if (value < 1 || value > 10000)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_materialDver1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_materialDver1.Text + e.KeyChar);
                if (value < 1 || value > 10000)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_materialDver2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_materialDver2.Text + e.KeyChar);
                if (value < 1 || value > 10000)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_materialDver3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_materialDver3.Text + e.KeyChar);
                if (value < 1 || value > 10000)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_materialDver4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_materialDver4.Text + e.KeyChar);
                if (value < 1 || value > 10000)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_kolvoPolok1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_kolvoPolok1.Text + e.KeyChar);
                if (value < 1 || value > 15)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_kolvoPolok3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_kolvoPolok3.Text + e.KeyChar);
                if (value < 1 || value > 15)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_kolvoPolok2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_kolvoPolok2.Text + e.KeyChar);
                if (value < 1 || value > 15)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_kolvoPolok4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_kolvoPolok4.Text + e.KeyChar);
                if (value < 1 || value > 15)
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
                if (value < 1 || value > 25)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_kolvoShtang_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_kolvoShtang.Text + e.KeyChar);
                if (value < 1 || value > 15)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_vysotaDveri1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_vysotaDveri1.Text + e.KeyChar);
                if (value < 1 || value > 300)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_vysotaDveri2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_vysotaDveri2.Text + e.KeyChar);
                if (value < 1 || value > 300)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_vysotaDveri3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_vysotaDveri3.Text + e.KeyChar);
                if (value < 1 || value > 300)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_vysotaDveri4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_vysotaDveri4.Text + e.KeyChar);
                if (value < 1 || value > 300)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_shirinaZerkala1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_shirinaZerkala1.Text + e.KeyChar);
                if (value < 1 || value > 200)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_shirinaZerkala2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_shirinaZerkala2.Text + e.KeyChar);
                if (value < 1 || value > 200)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_vysotaaZerkala1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_vysotaaZerkala1.Text + e.KeyChar);
                if (value < 1 || value > 300)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_vysotaaZerkala2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_vysotaaZerkala2.Text + e.KeyChar);
                if (value < 1 || value > 300)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_kolPeregorodok_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, что вводимый символ является цифрой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                int value = int.Parse(textBox_kolPeregorodok.Text + e.KeyChar);
                if (value < 1 || value > 5)
                {
                    e.Handled = true;
                }
            }
        }
        private void clean()
        {

            textBox_vysotaShkafa.Text = "";
            textBox_glubinaShkafa.Text = "";
            textBox_shrinaShkafa.Text = "";
            textBox_cena_materiala_korpusa.Text = "";
            textBox_kolPeregorodok.Text = "";
            textBox_cena_materiala_zad_stenki.Text = "";

            textBox_shirinaDveri1.Text = "";
            textBox_vysotaDveri1.Text = "";
            textBox_materialDver1.Text = "";
            textBox_shirinaDveri2.Text = "";
            textBox_vysotaDveri2.Text = "";
            textBox_materialDver2.Text = "";
            textBox_shirinaDveri3.Text = "";
            textBox_vysotaDveri3.Text = "";
            textBox_materialDver3.Text = "";
            textBox_shirinaDveri4.Text = "";
            textBox_vysotaDveri4.Text = "";
            textBox_materialDver4.Text = "";

            textBox_shirinaPolki1.Text = "";
            textBox_kolvoPolok1.Text = "";
            textBox_shirinaPolki2.Text = "";
            textBox_kolvoPolok2.Text = "";
            textBox_shirinaPolki3.Text = "";
            textBox_kolvoPolok3.Text = "";
            textBox_shirinaPolki4.Text = "";
            textBox_kolvoPolok4.Text = "";

            textBox_shirinaZerkala1.Text = "";
            textBox_vysotaaZerkala1.Text = "";
            textBox_shirinaZerkala2.Text = "";
            textBox_vysotaaZerkala2.Text = "";

            textBox_cenaYashika1.Text = "";
            textBox_kolvoYashikov1.Text = "";
            textBox_cenaYashika2.Text = "";
            textBox_kolvoYashikov2.Text = "";

            textBox_cenaRuchek.Text = "";
            textBox_kolvoRuchek.Text = "";
            textBox_kolvoShtang.Text = "";
            textBox_cenaShtang.Text = "";

            label_itogDveri.Text = "0";
            label_itogKorpus.Text = "0";
            label_itogFurniture.Text = "0";
            label_itogPolki.Text = "0";
            label_itogZerkala.Text = "0";
            label_itogYashiki.Text = "0";
            label_itogMagazin.Text = "0";
            label_itogStoimostProiz.Text = "0";
        }
       
        private void button_schitat_Click(object sender, EventArgs e)
        {       
            iscluchenia();

            try
            {
                korpusAll();
                zerkala();
                furnitira();
                dveri();
                polki();
                yashiki();
                cenaShkafa();
            }
            catch { MessageBox.Show("ошибка"); }
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void shkaf_FormClosed(object sender, FormClosedEventArgs e)
        {
            typeOfMebel newForm = new typeOfMebel(); // Создаем новую форму
            newForm.Show(); // Отображаем новую форму
        }
    }
}

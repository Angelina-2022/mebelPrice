using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MebelPrice
{
    public partial class infoRazrabotchik : Form
    {
        public infoRazrabotchik()
        {
            InitializeComponent();
        }

        private void infoRazrabotchik_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main newForm = new Main(); // Создаем новую форму
            newForm.Show(); // Отображаем новую форму
        }

    }
}

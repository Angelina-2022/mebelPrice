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
    public partial class Main : Form
    { 
       
        public Main()
        {
            InitializeComponent();
        }

        private void buttonRaschet_Click(object sender, EventArgs e)
        {
            typeOfMebel form1 = new typeOfMebel();
            form1.Show();
        }

        private void buttonInfoRazrabotchik_Click(object sender, EventArgs e)
        {
            
                infoRazrabotchik form2 = new infoRazrabotchik();

                this.Hide();
                form2.Show();
            
        }

       
    }
}

using System;
using System.Windows.Forms;

namespace MebelPrice
{
    public partial class typeOfMebel : Form
    {

        public typeOfMebel()
        {

            InitializeComponent();
        }

        private void buttonClick_kitchen(object sender, EventArgs e)
        {
            kitchen form1 = new kitchen();

            this.Hide(); 
            form1.Show();
        }


        private void buttonClick_shkaf(object sender, EventArgs e)
        {
            shkaf form2 = new shkaf();

            this.Hide(); 
            form2.Show();
        }
        private void buttonClick_stol(object sender, EventArgs e)
        {
            stol form3 = new stol();

            this.Hide(); 
            form3.Show();
        }

    }
}

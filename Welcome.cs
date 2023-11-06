using System;
using System.Windows.Forms;

namespace Сash_register
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            Hide();
        }
    }
}

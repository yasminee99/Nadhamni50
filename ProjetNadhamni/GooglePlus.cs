using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetNadhamni
{
    public partial class GooglePlus : Form
    {
        public GooglePlus()
        {
            InitializeComponent();
        }

        private void exitGplus_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_usernameGoogle_Click(object sender, EventArgs e)
        {
            txt_usernameGoogle.Clear();
        }

        private void txt_passwordGoogle_Click(object sender, EventArgs e)
        {
            txt_passwordGoogle.Clear();
        }
    }
}

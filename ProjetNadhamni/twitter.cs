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
    public partial class twitter : Form
    {
        public twitter()
        {
            InitializeComponent();
        }

        private void exitTwitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_usernameTwitter_Click(object sender, EventArgs e)
        {
            txt_usernameTwitter.Clear();
        }

        private void txt_passwordTwitter_Click(object sender, EventArgs e)
        {
            txt_passwordTwitter.Clear();
        }
    }
}

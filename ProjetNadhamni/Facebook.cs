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
    public partial class Facebook : Form
    {
        public Facebook()
        {
            InitializeComponent();
        }

        private void exitFb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_usernameFb_Click(object sender, EventArgs e)
        {
            txt_usernameFb.Clear();
        }

        private void txt_passwordFb_Click(object sender, EventArgs e)
        {
            txt_passwordFb.Clear();
        }
    }
}

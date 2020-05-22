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
    public partial class SuccessTaskAdded : Form
    {
        public SuccessTaskAdded()
        {
            InitializeComponent();
        }

        private void icon_delay_Tick(object sender, EventArgs e)
        {
            btn_OK.Visible = true;

            icon.Enabled = false;
            icon_delay.Stop();
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            icon_delay.Start();
            icon.Enabled = true;
        }

        private void SuccessTaskAdded_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void icon_Click(object sender, EventArgs e)
        {

        }
    }
}

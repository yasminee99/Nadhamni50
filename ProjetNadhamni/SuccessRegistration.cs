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
    public partial class SuccessRegistration : Form
    {
        public SuccessRegistration()
        {
            InitializeComponent();
        }

        private void SuccessRegistration_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            icon_delay.Start();
            icon.Enabled = true;
        }

        private void icon_delay_Tick(object sender, EventArgs e)
        {
            btn_OK.Visible = true;
         
            icon.Enabled = false;
            icon_delay.Stop();
        }

        private void btnAddKids_Click(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {   
           PersonalInformation p = new PersonalInformation();
            p.Show();
            this.Hide();
            Facebook f = new Facebook();
            GooglePlus gp = new GooglePlus();
            twitter t = new twitter();
            f.Hide();
            gp.Hide();
            t.Hide();
        }

        private void bunifuOK_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void icon_Click(object sender, EventArgs e)
        {

        }
    }
}

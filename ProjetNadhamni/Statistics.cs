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
    public partial class Statistics : Form
    {
        public static bool svisited = false;
        public Statistics()
        {
            InitializeComponent();
            svisited = true;
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dsh3 = new Dashboard();
            this.Hide();
            dsh3.Show();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Profile pf3 = new Profile();
            this.Hide();
            pf3.Show();
        }

        private void btn_tasks_Click(object sender, EventArgs e)
        {
            Tasks tsk3 = new Tasks();
            this.Hide();
            tsk3.Show();
        }

        private void btn_parameters_Click(object sender, EventArgs e)
        {
            Settings st3 = new Settings();
            this.Hide();
            st3.Show();
        }

        private void ExitDashboard_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

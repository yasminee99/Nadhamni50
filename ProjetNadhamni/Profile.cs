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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dsh1 = new Dashboard();
            this.Hide();
            dsh1.Show();
        }

        private void btn_tasks_Click(object sender, EventArgs e)
        {
            Tasks tsk1 = new Tasks();
            this.Hide();
            tsk1.Show();
        }

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            Statistics stc1 = new Statistics();
            this.Hide();
            stc1.Show();
        }

        private void btn_parameters_Click(object sender, EventArgs e)
        {
            Settings st1 = new Settings();
            this.Hide();
            st1.Show();
        }

        private void ExitDashboard_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

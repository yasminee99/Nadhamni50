using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetNadhamni
{
    public partial class Studies : Form
    {
        public Studies()
        {
            InitializeComponent();
        }
        int days;
        String starth, startm, endh, endm;
        String starttime, endtime;

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSaveStudies_Click(object sender, EventArgs e)
        {
            starth = cmb_startTimeStudiesH.Text;
            startm = cmb_startTimeStudiesM.Text;
            starttime = starth + startm;
            endh = cmb_EndTimeStudiesH.Text;
            endm = cmb_EndTimeStudiesM.Text;
            endtime = endh + endm;

            SqlConnection con = new SqlConnection();
            if (txt_levelStudies.Text == "" || txt_specialty.Text == "" || txt_specialty.Text == "")

            {
                if (MondayStudies.Checked == true || TuesdayStudies.Checked == true || wednesdayStudies.Checked == true || ThursdayStudies.Checked == true || fridayStudies.Checked == true || SaturdayStudies.Checked == true || SundayStudies.Checked == true)
                {
                    MessageBox.Show("Please fill all fields");
                    return;
                }
            }
            else
            {
                try
                {

                    con.ConnectionString = @"Data Source=DESKTOP-69MM1NJ\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Studies(LevelOfStudies,Speciality,Establishment,DaysOfStud,StartTime,EndTime,UserName) values(@LevelOfStudies,@Speciality,@Establishment,@DaysOfStud,@StartTime,@EndTime,@UserName)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@levelOfStudies", txt_levelStudies.Text);
                    cmd.Parameters.AddWithValue("@Speciality", txt_specialty.Text);
                    cmd.Parameters.AddWithValue("@Establishment", txt_establishment.Text);
                    cmd.Parameters.AddWithValue("@DaysOfStud", days);
                    cmd.Parameters.AddWithValue("@StartTime", starttime);
                    cmd.Parameters.AddWithValue("@EndTime", endtime);
                    cmd.Parameters.AddWithValue("@UserName", Home.FK);

                    //Execute Command
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("success");

                    SuccessJob stud1 = new SuccessJob();
                    stud1.Show();
                    /*Dashboard d = new Dashboard();
                    d.Show();
                    this.Hide();*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
        }

        private void MondayStudies_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void TuesdayStudies_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void wednesdayStudies_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void ThursdayStudies_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void fridayStudies_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void SaturdayStudies_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void SundayStudies_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void txt_levelStudies_Click(object sender, EventArgs e)
        {
            txt_levelStudies.Clear();
        }

        private void txt_specialty_Click(object sender, EventArgs e)
        {
            txt_specialty.Clear();
        }

        private void txt_establishment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_establishment_Click(object sender, EventArgs e)
        {
            txt_establishment.Clear();
        }

        private void Studies_Load(object sender, EventArgs e)
        {

        }
    }
}

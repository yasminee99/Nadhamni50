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
    public partial class Spouse : Form
    {
        public Spouse()
        {
            InitializeComponent();
        }
        string gender,work, health, Spousetypeofwork;
        int days = 0;
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void rd_femISpouse_CheckedChanged(object sender, EventArgs e)
        {
            gender = "woman";
        }

        private void rd_maleSpouse_CheckedChanged(object sender, EventArgs e)
        {
            gender = "man";
        }

        private void rd_HealthySpouse_CheckedChanged(object sender, EventArgs e)
        {
            health = "healthy";
        }

        private void rd_SickSpouse_CheckedChanged(object sender, EventArgs e)
        {
            health = "sick";
        }

        private void rd_YesWorkSpouse_CheckedChanged(object sender, EventArgs e)
        {
            work = "yes";
        }

        private void rd_NoWorkSpouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_NoWorkSpouse.Checked)
            { txt_jobSpouse.Enabled = false;
                MondaySpouse.Enabled = false;
                TuesdaySpouse.Enabled = false;
                wednesdaySpouse.Enabled = false;
                ThursdaySpouse.Enabled = false;
                fridaySpouse.Enabled = false;
                SaturdaySpouse.Enabled = false;
                SundaySpouse.Enabled = false;
            }
            work = "no";
        }

        private void MondaySpouse_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void TuesdaySpouse_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void wednesdaySpouse_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void SundaySpouse_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void ThursdaySpouse_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void fridaySpouse_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void SaturdaySpouse_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void txt_jobSpouse_TextChanged(object sender, EventArgs e)
        {

        }

        private void Spouse_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_firstnameSpouse_Click(object sender, EventArgs e)
        {
            txt_firstnameSpouse.Clear();
        }

        private void txt_lastnameSpouse_Click(object sender, EventArgs e)
        {
            txt_lastnameSpouse.Clear();
        }

        private void txt_jobSpouse_Click(object sender, EventArgs e)
        {
            txt_jobSpouse.Clear();
        }

        private void txt_docNameSpouse_Click(object sender, EventArgs e)
        {
            txt_docNameSpouse.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSaveSpouse_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            try
            {
                /*if (work.Equals("no"))
                    Spousetypeofwork = "unemployment";
                else
                    Spousetypeofwork = txt_jobSpouse.Text;*/

                con.ConnectionString = @"Data Source=DESKTOP-69MM1NJ\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Spouse(FirstName,LastName,Gender,Birthday,Health,Consultation,DrName,Work,TypeOfWork,DaysOfWork,UserName) values(@FirstName,@LastName,@Gender,@Birthday,@Health,@Consultation,@DrName,@Work,@TypeOfWork,@DaysOfWork,@UserName)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstName", txt_firstnameSpouse.Text);
                cmd.Parameters.AddWithValue("@LastName", txt_lastnameSpouse.Text);

                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Birthday", birthdaySpouse.Value.ToString());

                if (rd_HealthySpouse.Checked) { 
                health = "healthy";
                cmd.Parameters.AddWithValue("@Health", health);
            }
                else
                    if(rd_SickSpouse.Checked){
                    health = "sick";
                    cmd.Parameters.AddWithValue("@Health", health);

                }
                cmd.Parameters.AddWithValue("@Consultation", ConsultationSpouse.Value.ToString());
                cmd.Parameters.AddWithValue("@DrName", txt_docNameSpouse.Text);
                if (rd_YesWorkSpouse.Checked)
                {
                    work = "yes";
                    cmd.Parameters.AddWithValue("@Work", work);
                    Spousetypeofwork = txt_jobSpouse.Text;
                    cmd.Parameters.AddWithValue("@TypeOfWork", Spousetypeofwork);
                }
                else
                    if (rd_NoWorkSpouse.Checked)
                {
                    work = "no";
                    cmd.Parameters.AddWithValue("@Work", work);
                    Spousetypeofwork = "unemployment";
                    cmd.Parameters.AddWithValue("@TypeOfWork", Spousetypeofwork);
                }
                cmd.Parameters.AddWithValue("@DaysOfWork", days);
                cmd.Parameters.AddWithValue("@UserName", Home.FK);

                //Execute Command
                cmd.ExecuteNonQuery();
               // MessageBox.Show("success");

                if (PersonalInformation.kid)
                {
                    SuccessSpouse1 sp1 = new SuccessSpouse1();
                    sp1.Show();
                   /* Kids k = new Kids();
                    k.Show();
                    this.Hide();*/
                }
                if (!PersonalInformation.kid && (PersonalInformation.Worker || PersonalInformation.Student || PersonalInformation.unemployed))
                {
                    SuccessSpouse2 sp2 = new SuccessSpouse2();
                    sp2.Show();
                        
                    /*Parents p = new Parents();
                    p.Show();
                    this.Hide();*/

                }
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
}

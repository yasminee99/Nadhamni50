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
    public partial class PersonalInformation : Form
    {
        public PersonalInformation()
        {
            InitializeComponent();
        }
        //variables pour la transition entre les interfaces
        public static bool kid = false;
        public static bool Worker = false;
        public static bool Student =  false;
        public static bool unemployed = true;
        public static bool Mar = false;
        public static bool Div = false;
        public static bool wid = false;
        public static bool sing = false;
        //variables for the DB

        string gender, CivilStatus, student, kids, work ;
        string health, exercice,activity, typeofwork;
        int days = 0;


        



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void exitPersonal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSavePersInfo_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = @"Data Source=DESKTOP-69MM1NJ\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";


            try
            {  //tbar9ich lel BD
                if (days != 0)
                    activity = txt_activityInfo.Text;
                else
                    activity = "no activity";
                if (work.Equals("no"))
                    typeofwork = "unemployment";
                else
                    typeofwork = txt_WorkInfo.Text;

                con.Open();
                SqlCommand cmd = new SqlCommand("update Profile set FirstName=@FirstName,LastName=@LastName,Gender=@Gender,Birthday=@Birthday,Adress=@Adress,Work=@Work,TypeOfWork=@TypeOfWork,Student=@Student,CivilStatus=@CivilStatus,Kids=@Kids,Health=@Health,Consultation=@Consultation,DrName=@DrName,Exercice=@Exercice,TypeOfActivity=@TypeOfActivity,DaysOfPractice=@DaysOfPractice where UserName='" + Home.FK + "'", con);
                cmd.CommandType = CommandType.Text;
                // Add parameters
                cmd.Parameters.AddWithValue("@FirstName", txt_firstnameInfo.Text);
                cmd.Parameters.AddWithValue("@LastName", txt_lastnameInfo.Text);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Birthday", birthdayInfo.Value.ToString());
                cmd.Parameters.AddWithValue("@Adress", txt_AdrInfo.Text);
                cmd.Parameters.AddWithValue("@Work", work);
                cmd.Parameters.AddWithValue("@TypeOfWork", typeofwork);
                cmd.Parameters.AddWithValue("@Student", student);
                cmd.Parameters.AddWithValue("@CivilStatus", CivilStatus);
                cmd.Parameters.AddWithValue("@Kids", kids);
                cmd.Parameters.AddWithValue("@Health", health);
                cmd.Parameters.AddWithValue("@Consultation", ConsultationInfo.Value.ToString());
                cmd.Parameters.AddWithValue("@DrName", txt_docNameInfo.Text);
                cmd.Parameters.AddWithValue("@Exercice", exercice);
                cmd.Parameters.AddWithValue("@TypeOfActivity", activity);
                cmd.Parameters.AddWithValue("@DaysOfPractice", days);

                cmd.ExecuteNonQuery();

                //Moving to the rest of interfaces
                Facebook f = new Facebook();
                GooglePlus gp = new GooglePlus();
                twitter t = new twitter();
                if (Mar)
                {
                    
                    f.Visible=false;
                    gp.Visible = false; 
                    t.Visible=false;
                    SuccessPers1 p1 = new SuccessPers1();
                    p1.Show();
                    
                    
                    
                }

                if ((wid || Div) && (kid))
                {


                    f.Visible = false;
                    gp.Visible = false;
                    t.Visible = false;
                    SuccessPers2 p2 = new SuccessPers2();
                    p2.Show();
                    
                   
                   
                }
                if (sing)
                {


                    f.Visible = false;
                    gp.Visible = false;
                    t.Visible = false;
                    SuccessPers3 p3 = new SuccessPers3();
                    p3.Show();
                    
                    
                    
                }
                if ((wid || Div) && (!kid))
                {


                    f.Visible = false;
                    gp.Visible = false;
                    t.Visible = false;
                    SuccessPers4 p4 = new SuccessPers4();
                    p4.Show();
                    
                    
                   
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
            

        private void rd_femInfo_CheckedChanged(object sender, EventArgs e)
        {
            gender = "woman";
        }

        private void rd_maleInfo_CheckedChanged(object sender, EventArgs e)
        {
            gender = "man";
        }

        private void rd_NoWorkInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_NoWorkInfo.Checked)
            { txt_WorkInfo.Enabled = false; }
            work = "no";
        }

        private void rd_noStud_CheckedChanged(object sender, EventArgs e)
        {
            student = "no";
        }

        private void rd_NoKidsInfo_CheckedChanged(object sender, EventArgs e)
        {
            kids = "no";
        }

        private void rd_HealthyInfo_CheckedChanged(object sender, EventArgs e)
        {
            health = "healthy";
        }

        private void rd_SickInfo_CheckedChanged(object sender, EventArgs e)
        {
            health = "sick";
        }

        private void rd_YesExerciceInfo_CheckedChanged(object sender, EventArgs e)
        {
            exercice = "yes";
        }

        private void rd_NoExerciceInfo_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rd_NoExerciceInfo.Checked)
            {
                txt_activityInfo.Enabled = false;
              
                    MondayInfo.Enabled = false;
                    TuesdayInfo.Enabled = false;
                    wednesdayInfo.Enabled = false;
                    ThursdayInfo.Enabled = false;
                    fridayInfo.Enabled = false;
                    SaturdayInfo.Enabled = false;
                    SundayInfo.Enabled = false;
                
            }
            exercice = "no";
        }

        private void MondayInfo_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void TuesdayInfo_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void wednesdayInfo_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void SundayInfo_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void ThursdayInfo_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void fridayInfo_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void SaturdayInfo_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void txt_activityInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_WorkInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_firstnameInfo_Click(object sender, EventArgs e)
        {
            txt_firstnameInfo.Clear();
        }

        private void txt_lastnameInfo_Click(object sender, EventArgs e)
        {
            txt_lastnameInfo.Clear();
        }

        private void txt_AdrInfo_Click(object sender, EventArgs e)
        {
            txt_AdrInfo.Clear();
        }

        private void txt_WorkInfo_Click(object sender, EventArgs e)
        {
            txt_WorkInfo.Clear();
        }

        private void txt_docNameInfo_Click(object sender, EventArgs e)
        {
            txt_docNameInfo.Clear();
        }

        private void txt_activityInfo_Click(object sender, EventArgs e)
        {
            txt_activityInfo.Clear();
        }

        private void PersonalInformation_Load(object sender, EventArgs e)
        {
            txt_WorkInfo.Enabled = false;
            label5.Visible = false;
            rd_YesKidsInfo.Visible = false;
            rd_NoKidsInfo.Visible = false;
        }

        private void rd_YesWorkInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_YesWorkInfo.Checked == true)
            {
                txt_WorkInfo.Enabled = true;
                Worker = true;
                unemployed = false;
                rd_yesStud.Enabled = false;
                rd_noStud.Enabled = false;
            }
            work = "yes";
            student = "no";
        }

        private void rd_marriedInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_marriedInfo.Checked)
            {
                Mar = true;
                label5.Visible = true;
                rd_YesKidsInfo.Visible = true;
                rd_NoKidsInfo.Visible = true;
            }
            CivilStatus = "married";
        }

        private void rd_DivorcedInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_DivorcedInfo.Checked)
            {
                Div = true;
                label5.Visible = true;
                rd_YesKidsInfo.Visible = true;
                rd_NoKidsInfo.Visible = true;
            }
            CivilStatus = "divorced";
        }

        private void rd_WidInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_WidInfo.Checked)
            {
                wid = true;
                label5.Visible = true;
                rd_YesKidsInfo.Visible = true;
                rd_NoKidsInfo.Visible = true;
            }
            CivilStatus = "widow";
        }

        private void rd_YesKidsInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_YesKidsInfo.Checked == true)
                kid = true;
            kids = "yes";
        }

        private void rd_singleInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_singleInfo.Checked == true)
                sing = true;
            CivilStatus = "single";
            kids = "no";
        }

        private void rd_yesStud_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_yesStud.Checked == true)
                Student = true;
            unemployed = false;
            student = "yes";
        }
       
    }
}

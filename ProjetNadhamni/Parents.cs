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
    public partial class Parents : Form
    {
        public Parents()
        {
            InitializeComponent();
        }
        //the father's variables
        string RD_F = "no", D_F = "no", CV_F = "no", C_F = "no";

        private void RespitoryDiseasesFather_CheckedChanged(object sender, EventArgs e)
        {
            RD_F = "yes";
        }

        private void CardiovascularIllnessesFather_CheckedChanged(object sender, EventArgs e)
        {
            CV_F = "yes";
        }

        private void DiabetesFather_CheckedChanged(object sender, EventArgs e)
        {
            D_F = "yes";
        }

        private void CancerFather_CheckedChanged(object sender, EventArgs e)
        {
            C_F = "yes";
        }

        private void RespitoryDiseasesMother_CheckedChanged(object sender, EventArgs e)
        {
            RD_M = "yes";
        }

        private void CardiovascularIllnessesMother_CheckedChanged(object sender, EventArgs e)
        {
            CV_M = "yes";
        }

        private void DiabetesMother_CheckedChanged(object sender, EventArgs e)
        {
            D_M = "yes";
        }

        private void CancerMother_CheckedChanged(object sender, EventArgs e)
        {
            C_M = "yes";
        }

        //the mother's variables
        string RD_M = "no", D_M = "no", CV_M = "no", C_M = "no";

        private void txt_docFamily_Click(object sender, EventArgs e)
        {
            txt_docFamily.Clear();
        }

        private void txt_firstnameMother_Click(object sender, EventArgs e)
        {
            txt_firstnameMother.Clear();
        }

        private void txt_firstnameFather_Click(object sender, EventArgs e)
        {
            txt_firstnameFather.Clear();
        }

        //DB
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-69MM1NJ\\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False");
        

        private void btnSaveParents_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                //insert into father's table
                SqlCommand cmd1 = new SqlCommand("insert into Father(FirstName,Birthday,RespiratoryDiseases,CardiovascularDiseases,Diabetes,Cancer,FamilyDr,UserName)values(@FirstName,@Birthday,@RespiratoryDiseases,@CardiovascularDiseases,@Diabetes,@Cancer,@FamilyDr,@UserName)", con);
                cmd1.CommandType = CommandType.Text;
                cmd1.Parameters.AddWithValue("@FirstName", txt_firstnameFather.Text);
                cmd1.Parameters.AddWithValue("@Birthday", birthdayFather.Value.ToString());
                cmd1.Parameters.AddWithValue("@RespiratoryDiseases", RD_F);
                cmd1.Parameters.AddWithValue("@CardiovascularDiseases", CV_F);
                cmd1.Parameters.AddWithValue("@Diabetes", D_F);
                cmd1.Parameters.AddWithValue("@Cancer", C_F);
                cmd1.Parameters.AddWithValue("@FamilyDr", txt_docFamily.Text);
                cmd1.Parameters.AddWithValue("@UserName", Home.FK);
                cmd1.ExecuteNonQuery();
                //insert into mother's table
                SqlCommand cmd2 = new SqlCommand("insert into Mother(FirstName,Birthday,RespiratoryDiseases,CardiovascularDiseases,Diabetes,Cancer,FamilyDr,UserName)values(@FirstName,@Birthday,@RespiratoryDiseases,@CardiovascularDiseases,@Diabetes,@Cancer,@FamilyDr,@UserName)", con);
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.AddWithValue("@FirstName", txt_firstnameMother.Text);
                cmd2.Parameters.AddWithValue("@Birthday", birthdayMother.Value.ToString());
                cmd2.Parameters.AddWithValue("@RespiratoryDiseases", RD_M);
                cmd2.Parameters.AddWithValue("@CardiovascularDiseases", CV_M);
                cmd2.Parameters.AddWithValue("@Diabetes", D_M);
                cmd2.Parameters.AddWithValue("@Cancer", C_M);
                cmd2.Parameters.AddWithValue("@FamilyDr", txt_docFamily.Text);
                cmd2.Parameters.AddWithValue("@UserName", Home.FK);
                cmd2.ExecuteNonQuery();
                //MessageBox.Show("success");

                //passage entre les interfaces
                if (PersonalInformation.Worker)
                {
                    SuccessParentsWorker s1 = new SuccessParentsWorker();
                    s1.Show();
                   /* Job j = new Job();
                    j.Show();
                    this.Hide();*/
                }
                if (PersonalInformation.Student)
                {
                    SuccessParentsStudent s2 = new SuccessParentsStudent();
                    s2.Show();

                    /*Studies st = new Studies();
                    st.Show();
                    this.Hide();*/
                }
                if (PersonalInformation.unemployed)
                {
                    SuccessParentsUnemployed s3 = new SuccessParentsUnemployed();
                    s3.Show();
                    /*Dashboard d = new Dashboard();
                    d.Show();
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

        private void Parents_Load(object sender, EventArgs e)
        {

        }
    }
}

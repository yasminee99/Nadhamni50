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
    public partial class EditTasks : Form
    {
        public EditTasks()
        {
            InitializeComponent();
        }
        public static int editstart;
        
        

        //String starth, startm, endh, endm;
        //String starttime, endtime;
        //con.ConnectionString = @"Data Source=DESKTOP-69MM1NJ\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";


        private void button1_Click(object sender, EventArgs e)
        {
            
            /*SqlConnection con = new SqlConnection();

            con.ConnectionString = @"Data Source=DESKTOP-69MM1NJ\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";
            con.Open();
            MessageBox.Show("DB connected");
            SqlCommand cmd = new SqlCommand(" select * from Tasks WHERE id='" + int.Parse(username.Text) + "'", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                firstname.Text = (dr["TaskName"].ToString());
                birthday.Text = Convert.ToDateTime(dr["DateOfTask"]).ToShortDateString();
            }
            con.Close();*/

        }

        private void EditTasks_Load(object sender, EventArgs e)
        {
            
        }

       

        private void icon_delay_Tick(object sender, EventArgs e)
        {
            
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            
        }

        private void txt_idTask_Click(object sender, EventArgs e)
        {
            txt_idTask.Clear();
        }

        private void txt_taskName_Click(object sender, EventArgs e)
        {
            txt_taskName.Clear();
        }

        private void txt_category_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_dateTask_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_tolerTime_Click(object sender, EventArgs e)
        {
            txt_tolerTime.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void KeepDate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_taskType_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_endTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void txt_tolerTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void txt_taskLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_FinishTask_Click(object sender, EventArgs e)
        {

            EditingDone edt = new EditingDone();
            edt.Show();
            
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            editstart = int.Parse(txt_idTask.Text);
            SqlConnection con = new SqlConnection();

            con.ConnectionString = @"Data Source=DESKTOP-69MM1NJ\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";
            con.Open();
            //MessageBox.Show("Data base connected");
            DBconnecting db = new DBconnecting();
            db.Show();
            SqlCommand cmd = new SqlCommand(" select * from Tasks WHERE id='" + int.Parse(txt_idTask.Text) + "'", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_taskName.Text = (dr["TaskName"].ToString());
                txt_category.Text = (dr["Category"].ToString());
                txt_dateTask.Text = Convert.ToDateTime(dr["DateOfTask"]).ToShortDateString();
                txt_startTime.Text = (dr["StartTime"].ToString());
                txt_endTime.Text = (dr["EndTime"].ToString());
                txt_taskType.Text = (dr["TaskType"].ToString());
                txt_tolerTime.Text = (dr["ToleranceTime"].ToString());
                txt_taskLocation.Text = (dr["Location"].ToString());
                rb_invoPer.Text = (dr["InvolvedPersons"].ToString());

            }
            con.Close();
        }

        private void txt_taskLocation_Click(object sender, EventArgs e)
        {
            txt_taskLocation.Clear();
        }

        private void rb_invoPer_Click(object sender, EventArgs e)
        {
            rb_invoPer.Clear();
        }

        

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_editStart_Click(object sender, EventArgs e)
        {
            EditStartTimeTask st = new EditStartTimeTask();
            st.Show();
        }

        private void btn_editEndTime_Click(object sender, EventArgs e)
        {
            EditEndTimeTask et = new EditEndTimeTask();
            et.Show();
        }

        private void btn_editDate_Click(object sender, EventArgs e)
        {
            EditDateTask ed = new EditDateTask();
            ed.Show();
        }

        private void btn_editLocation_Click(object sender, EventArgs e)
        {
            EditLocationTask el = new EditLocationTask();
            el.Show();
        }

        private void btn_editTolerance_Click(object sender, EventArgs e)
        {
            EditToleranceTask etol = new EditToleranceTask();
            etol.Show();
        }

        private void btn_editCategory_Click(object sender, EventArgs e)
        {
            EditCategoryTask ct = new EditCategoryTask();
            ct.Show();
        }

        private void btn_editType_Click(object sender, EventArgs e)
        {
            EditTypeTask etp = new EditTypeTask();
            etp.Show();
        }

        private void btn_editName_Click(object sender, EventArgs e)
        {
            EditNameTask nt = new EditNameTask();
            nt.Show();
        }

        private void btn_editInvolved_Click(object sender, EventArgs e)
        {
            EditInvolvedTask ip = new EditInvolvedTask();
            ip.Show();
        }
    }
}

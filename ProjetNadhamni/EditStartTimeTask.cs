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
    public partial class EditStartTimeTask : Form
    {
        public EditStartTimeTask()
        {
            InitializeComponent();
        }
        public String starth, startm, endh, endm;
        public String starttime, endtime;
                    
        private void EditStartEndTimeTask_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_updateStartTask_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = @"Data Source=DESKTOP-69MM1NJ\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";

            try
            {
                starth = cmb_startTimeTaskH.Text;
                startm = cmb_startTimeTaskM.Text;
                starttime = starth + startm;
                //endh = cmb_endTimeTaskH.Text;
                //endm = cmb_endTimeTaskM.Text;
                //endtime = endh + endm;
               
                con.Open();
                SqlCommand cmd = new SqlCommand("update Tasks set StartTime=@StartTime where Id='" + EditTasks.editstart +  "'", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@StartTime", starttime);

                cmd.ExecuteNonQuery();
               


            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                    this.Hide();
            }
            
            
        }

        private void icon_delay_Tick(object sender, EventArgs e)
        {
            
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            
        }
    }
}

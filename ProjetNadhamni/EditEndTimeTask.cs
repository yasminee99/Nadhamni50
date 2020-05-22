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
    public partial class EditEndTimeTask : Form
    {
        public EditEndTimeTask()
        {
            InitializeComponent();
        }
        public String starth, startm, endh, endm;

        private void EditEndTimeTask_Load(object sender, EventArgs e)
        {

        }

        public String starttime, endtime;

        private void btn_updateEndTask_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = @"Data Source=DESKTOP-69MM1NJ\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";

            try
            {
                
                endh = cmb_endTimeTaskH.Text;
                endm = cmb_endTimeTaskM.Text;
                endtime = endh + endm;

                con.Open();
                SqlCommand cmd = new SqlCommand("update Tasks set EndTime=@EndTime where Id='" + EditTasks.editstart + "'", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@EndTime", endtime);

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
    }
}

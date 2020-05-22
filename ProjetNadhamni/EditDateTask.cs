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
    public partial class EditDateTask : Form
    {
        public EditDateTask()
        {
            InitializeComponent();
        }

        private void btn_updateDateTask_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = @"Data Source=DESKTOP-69MM1NJ\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";

            try
            {
              
                con.Open();
                SqlCommand cmd = new SqlCommand("update Tasks set DateOfTask=@DateOfTask where Id='" + EditTasks.editstart + "'", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@DateOfTask", DateTask.Value.ToString());

               

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

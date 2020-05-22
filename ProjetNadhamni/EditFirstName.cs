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
    public partial class EditFirstName : Form
    {
        public EditFirstName()
        {
            InitializeComponent();
        }



        private void btn_updateFirstName_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = @"Data Source=DESKTOP-69MM1NJ\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Profile set FirstName=@FirstName where UserName='" + Home.FK + "'", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstName", txt_firstNameUpdated.Text);
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

        private void txt_firstNameUpdated_Click(object sender, EventArgs e)
        {
            txt_firstNameUpdated.Clear();
        }
    }
}

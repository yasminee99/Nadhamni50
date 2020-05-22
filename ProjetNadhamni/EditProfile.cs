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
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = @"Data Source=DESKTOP-69MM1NJ\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";

            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Profile where UserName='" + Home.FK + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_editFirstName.Text = dr[3].ToString();
                    txt_editLastName.Text = dr[4].ToString();
                    txt_editEmail.Text = dr[2].ToString();
                    txt_editPassword.Text = dr[1].ToString();

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

        private void btn_modifyfirstN_Click(object sender, EventArgs e)
        {
            EditFirstName efn = new EditFirstName();
            efn.Show();
        }

        private void btn_finishTask_Click(object sender, EventArgs e)
        {
            EditingDone ed = new EditingDone();
            ed.Show();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = @"Data Source=DESKTOP-69MM1NJ\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";

            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Profile where UserName='" + Home.FK + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_editFirstName.Text = dr[3].ToString();
                    txt_editLastName.Text = dr[4].ToString();
                    txt_editEmail.Text = dr[2].ToString();
                    txt_editPassword.Text = dr[1].ToString();

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

        private void btn_modifylastN_Click(object sender, EventArgs e)
        {
            EditLastName edl = new EditLastName();
            edl.Show();
        }

        private void btn_modifyEmail_Click(object sender, EventArgs e)
        {
            EditEmail em = new EditEmail();
            em.Show();

        }

        private void btn_modifypwd_Click(object sender, EventArgs e)
        {
            EditPassword ep = new EditPassword();
            ep.Show();
        }
    }
}

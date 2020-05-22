using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetNadhamni
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public static bool pass = false;
        Profile pf = new Profile();
        SqlConnection con = new SqlConnection();

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {


            try
            {

                con.ConnectionString = "Data Source=DESKTOP-69MM1NJ\\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";
                con.Open();
                if (Home.NewUser == false)
                {

                    SqlCommand cmd = new SqlCommand("select * from Tasks where UserName = '" + Home.FK + "'", con);

                    SqlDataReader dr = cmd.ExecuteReader();
                    int i = 0;
                    while (dr.Read())
                    {

                        ViewTasks.Rows.Add(dr[0], dr[2], dr[1], Convert.ToDateTime(dr[3]).ToShortDateString(), dr[4], dr[5], dr[7], dr[8], dr[6], dr[9]);
                        if (dr["Done"].ToString().Equals("yes"))
                        {
                            DataGridViewCheckBoxCell chkchecking = ViewTasks.Rows[i].Cells["Column10"] as DataGridViewCheckBoxCell;
                            chkchecking.Value = true;
                            i++;

                        }
                    }
                    dr.Close();
                }

                // Dashboard Notes
                if (!Home.Note)
                {

                    SqlCommand cmd = new SqlCommand("select * from Notes where UserName = '" + Home.FK + "'", con);

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ViewNotes.Rows.Add(dr[1], dr[2]);
                    }
                    dr.Close();
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


            
               
                
           
               

            try
            {
                con.Open();
                string selectQuery = "select ProfilePic from Profile  where UserName = '" + Home.FK + "'";
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    Byte[] img = (Byte[])(dr[0]);
                    if (img == null)
                    {
                        pictureBox7.Image = null;
                    }

                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox7.Image = Image.FromStream(ms);

                    }
                }
                else
                {
                    MessageBox.Show("error img not found");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            try
            {
                //con.ConnectionString = "Data Source=DESKTOP-AU9FQ00\\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Tasks where DateOfTask='" + (DateTime.Today.AddDays(1)).ToString("yyyy-MM-dd") + "'and UserName='" + Home.FK + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    if (!Tasks.tvisited && !Settings.sevisited && !Statistics.svisited)
                    {
                        string planing = "Today you have to: \n";
                        string taskname;
                        string statrttime;
                        string location;
                        while (dr.Read())
                        {
                            taskname = dr[1].ToString();
                            planing += taskname + "at ";
                            statrttime = dr[4].ToString();
                            planing += statrttime + "from ";
                            location = dr[7].ToString();
                            planing += location + "\n";

                        }
                        planing += "\n for more informations please check your planing";
                        notifyIcon1.ShowBalloonTip(5000, "Tommorow's planing", planing, ToolTipIcon.Info);
                        notifyIcon1.ShowBalloonTip(5000, "Tommorow's planing", "for more informations,check your tasks", ToolTipIcon.Info);
                    }


                }
                dr.Close();
                //unusual noti
                SqlCommand cmd1 = new SqlCommand("select count(*) from Tasks where DateOfTask='" + (DateTime.Today).ToString("yyyy-MM-dd") + "' and TaskType='" + "unusual" + "' and UserName='" + Home.FK + "'", con);
                string nbrdays = Convert.ToString(cmd1.ExecuteScalar());
                if (Convert.ToInt32(cmd1.ExecuteScalar()) > 0)
                    notifyIcon1.ShowBalloonTip(5000, "Don't forget", "you have " + nbrdays + " unusal task(s) for today check your planing for more details", ToolTipIcon.Info);
                //urgent notif
                SqlCommand cmd2 = new SqlCommand("select count(*) from Tasks where DateOfTask='" + (DateTime.Today).ToString("yyyy-MM-dd") + "' and TaskType='" + "urgent" + "' and UserName='" + Home.FK + "'", con);
                nbrdays = Convert.ToString(cmd2.ExecuteScalar());
                if (Convert.ToInt32(cmd2.ExecuteScalar()) > 0)
                    notifyIcon1.ShowBalloonTip(5000, "Don't forget", "you have " + nbrdays + " urgent task(s) for today check your planing for more details", ToolTipIcon.Info);
            } //end try2
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }




        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            PnlPassage.Top = btn_dashboard.Top;
            PnlPassage.Height = btn_dashboard.Height;


        }



        private void btn_tasks_Click(object sender, EventArgs e)
        {
            PnlPassage.Top = btn_taskDash.Top;
            PnlPassage.Height = btn_taskDash.Height;
            pnlDashboard.Visible = false;
            this.Hide();
            Tasks tsk = new Tasks();
            tsk.Show();

        }

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            PnlPassage.Top = btn_statDash.Top;
            PnlPassage.Height = btn_statDash.Height;
            this.Hide();
            Statistics stc = new Statistics();
            stc.Show();
        }

        private void btn_parameters_Click(object sender, EventArgs e)
        {
            PnlPassage.Top = btn_settingsDash.Top;
            PnlPassage.Height = btn_settingsDash.Height;
        }

        private void btn_profile_Click_1(object sender, EventArgs e)
        {
            PnlPassage.Top = btn_profileDash.Top;
            PnlPassage.Height = btn_profileDash.Height;
            Profile pf = new Profile();
            this.Hide();
            pf.Show();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            PnlPassage.Top = btn_settingsDash.Top;
            PnlPassage.Height = btn_settingsDash.Height;
            this.Hide();
            Settings set = new Settings();
            set.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitDashboard_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditTasks et = new EditTasks();
            et.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            
      
        }

        private void btn_saveNote_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = "Data Source=DESKTOP-69MM1NJ\\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";
                con.Open();
                //new note is added
                Home.Note = false;
                SqlCommand cmd = new SqlCommand("insert into Notes (Title,Description,UserName)values(@Title,@Description,@UserName)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Title", txt_title.Text);
                string[] Desc = rb_notes.Lines;
                string description = string.Join("", Desc);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@UserName", Home.FK);
                cmd.ExecuteNonQuery();
                //interface
                MessageBox.Show("done");



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

        private void btn_clearNote_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                rb_notes.Clear();
                txt_title.Clear();
                SqlCommand cmd = new SqlCommand("select * from Notes where UserName = '" + Home.FK + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ViewNotes.Rows.Add(dr[1], dr[2]);
                }
                dr.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_titleNotes_Click(object sender, EventArgs e)
        {
            txt_title.Clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)

        {
            
            
            DeleteTask dt = new DeleteTask();
            dt.Show();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            
            con.Open();

            int id;
            for (int i = 0; i < ViewTasks.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell chkchecking = ViewTasks.Rows[i].Cells[10] as DataGridViewCheckBoxCell;
                id = Convert.ToInt32(ViewTasks.Rows[i].Cells[0].Value);

                if (Convert.ToBoolean(chkchecking.Value) == true)
                {
                    SqlCommand cmd1 = new SqlCommand("update Tasks set Done=@Done where Id=" + id, con);
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Parameters.AddWithValue("@Done", "yes");
                    cmd1.ExecuteNonQuery();
                }
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DailyPlanning dp = new DailyPlanning();
            dp.Show();
        }
    }
    
}

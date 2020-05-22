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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        Facebook fb = new Facebook();
        GooglePlus gp = new GooglePlus();
        twitter tw = new twitter();
        SuccessRegistration sc = new SuccessRegistration();
        //BD
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-69MM1NJ\\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        Dashboard dsh = new Dashboard();
        public static String FK;
        public static bool NewUser = false;
        public static bool Note = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pic_fb_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fb.Left += 10;
            if (fb.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                fb.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            fb.Left -= 10;
            if (fb.Left <= 525)
            {
                timer2.Stop();
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {
            fb.Show();
            gp.Show();
            tw.Show();
            
        }

        private void exitHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pic_google_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            gp.Left += 10;
            if (gp.Left >= 830)
            {
                timer3.Stop();
                this.TopMost = false;
                gp.TopMost = true;
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            gp.Left -= 10;
            if (gp.Left <= 525)
            {
                timer4.Stop();
            }
        }

        private void pic_twitter_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            tw.Left += 10;
            if (tw.Left >= 830)
            {
                timer5.Stop();
                this.TopMost = false;
                tw.TopMost = true;
                timer6.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            tw.Left -= 10;
            if (tw.Left <= 525)
            {
                timer6.Stop();
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            


            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select * from Profile where UserName='" + txt_username.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("This username exists,choose another one!");

                }
                else
                {   //we have to close the DataReader so we can execute the insert query
                    dr.Close();
                    //we will add a new user by inserting his UserName,his Password and his E-mail
                    SqlCommand cmd1 = new SqlCommand("insert into Profile(UserName,Password,Email,ProfilePic) values(@UserName,@Password,@Email,@ProfilePic)", con);
                    //Je dois confgurer les paramétres
                    cmd1.CommandType = CommandType.Text;//Cette instruction donne le type de la commande , la valeur par defaut est text et elle n'est pas obligatoire
                    cmd1.Parameters.AddWithValue("@UserName", txt_username.Text);
                    cmd1.Parameters.AddWithValue("@Password", txt_password.Text);
                    cmd1.Parameters.AddWithValue("@Email", txt_Email.Text);
                    var image = new ImageConverter().ConvertTo(pictureBox1.Image, typeof(Byte[]));
                    cmd1.Parameters.AddWithValue("@ProfilePic", image);
                    //get the FK
                    FK = txt_username.Text;
                    
                    //newuser confirmed
                    NewUser = true;
                    Note = true;
                    //Execut the query
                    cmd1.ExecuteNonQuery();
                    //MessageBox.Show("success");
                    sc.Show();
                    //this.Hide();
                    fb.Close();
                    tw.Close();
                    gp.Close();

                    
                    /*PersonalInformation p = new PersonalInformation();
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

       

       

        private void txt_username_click(object sender, EventArgs e)
        {
            txt_username.Clear();
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            txt_password.Clear();
        }

        private void txt_Email_Click(object sender, EventArgs e)
        {
            txt_Email.Clear();
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select * from Profile where UserName='" + txt_username.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {   //get the FK
                    FK = txt_username.Text;
                    Boolean ok = false;
                    while (dr.Read() && ok == false)
                    {
                        if (!txt_password.Text.Equals(dr["Password"]))
                        {
                            PasswordCheck pw = new PasswordCheck();
                            pw.Show();
                            // MessageBox.Show("You need to check your password!"); 
                            ok = true; }
                        else if (!txt_Email.Text.Equals(dr["Email"]))
                        { //MessageBox.Show("You need to check your E-mail!"); 
                            EmailCheck ec = new EmailCheck();
                            ec.Show();
                            ok = true; }

                    }
                    if (ok == false)
                    {
                        dsh.Show();
                        this.Hide();
                        fb.Close();
                        tw.Close();
                        gp.Close();
                    }
                }
                else
                {

                    if (txt_password.Text.Equals("") && txt_Email.Text.Equals("") && txt_username.Text.Equals(""))
                    {
                        // MessageBox.Show("The fields are empty");
                        EmptyFields ep = new EmptyFields();
                        ep.Show();
                    }
                    else { }
                    // MessageBox.Show("You need to register!");
                    CheckRegistration crg1 = new CheckRegistration();
                    crg1.Show();
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
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            if (txt_username.Text.Equals(" ")==false)
            {
                checkBox1.Enabled = true;
            }
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images |*.jpg;*.jpeg,*.png";
            if (OD.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(OD.FileName);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SqlConnection con = new SqlConnection();

                con.ConnectionString = @"Data Source=DESKTOP-69MM1NJ\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";

                try
                {
                    con.Open();
                    string sql = "select ProfilePic,Password,Email from Profile  where UserName = '" + txt_username.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    
                    SqlDataReader dr = cmd.ExecuteReader();
                    

                    dr.Read();
                    if (dr.HasRows)
                    {
                        txt_password.Text = dr[1].ToString();
                        txt_Email.Text = dr[2].ToString();


                        Byte[] img = (Byte[])(dr[0]);
                        if (img == null)
                        {
                            pictureBox1.Image = null;
                        }

                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            pictureBox1.Image = Image.FromStream(ms);
                            

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

                Upload.Visible = false;
               
            }
        
        }
    }
}

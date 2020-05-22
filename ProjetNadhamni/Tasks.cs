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
using System.Speech;
using System.Speech.Recognition;
using System.Threading;


namespace ProjetNadhamni
{
    public partial class Tasks : Form

    { 
        public SpeechRecognitionEngine recognizer;

        public Grammar grammar;

        public Thread RecThread;
        public Boolean RecognizerState = true;
        public static bool tvisited = false;
        public Tasks()
        {
            InitializeComponent();
            tvisited = true;
        }
        String starth, startm, endh, endm;
        String starttime, endtime;

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dsh2 = new Dashboard();
            this.Hide();
            dsh2.Show();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Profile pf2 = new Profile();
            this.Hide();
            pf2.Show();
        }

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            Statistics stc2 = new Statistics();
            this.Hide();
            stc2.Show();
        }

        private void btn_parameters_Click(object sender, EventArgs e)
        {
            Settings st2 = new Settings();
            this.Hide();
            st2.Show();
        }

        private void ExitDashboard_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void Tasks_Load(object sender, EventArgs e)
        {
            //Here we first need to setup the grammar rules:

            GrammarBuilder build = new GrammarBuilder();
            build.AppendDictation();

            grammar = new Grammar(build);

            //In here we initialize the recognizer and setup its events:

            recognizer = new SpeechRecognitionEngine();
            recognizer.LoadGrammar(grammar);
            recognizer.SetInputToDefaultAudioDevice();

            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

            //Here will initialize the recognizer thread:

            RecognizerState = true;
            RecThread = new Thread(new ThreadStart(RecThreadFunction));
            RecThread.Start();
        }

        public void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //Recognizer recognizes the speech

            if (!RecognizerState)
                return;

            this.Invoke((MethodInvoker)delegate
            {
                txt_taskName.Text += (" " + e.Result.Text.ToLower());
                //This will add a space between each word you say
            });
        }
        public void RecThreadFunction()
        {
            //This is on separate threads. Will loop the recognizer when receiving calls

            while (true)
            {
                try
                {
                    recognizer.Recognize();
                }
                catch
                {
                    //Handles errors
                    //Won't hear you, nothing will happen
                }
            }


        }

      

        private void Tasks_FormClosing(object sender, FormClosingEventArgs e)
        {
            RecThread.Abort();
            RecThread = null;

            recognizer.UnloadAllGrammars();
            recognizer.Dispose();

            grammar = null;
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_voiceEnabled_Click(object sender, EventArgs e)
        {
            RecognizerState = true;
        }

        private void btn_voiceDisabled_Click(object sender, EventArgs e)
        {
            RecognizerState = false;
        }

        private void btn_Clearfield_Click(object sender, EventArgs e)
        {
            txt_taskName.Clear();
        }

        private void pnlDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_taskName_Click(object sender, EventArgs e)
        {
            txt_taskName.Clear();
        }

        private void txt_tolerTime_Click(object sender, EventArgs e)
        {
            txt_tolerTime.Clear();
        }

        private void txt_taskLocation_Click(object sender, EventArgs e)
        {
            txt_taskLocation.Clear();
        }

        private void btn_SaveTasks_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            starth = cmb_startTimeTaskH.Text;
            startm = cmb_startTimeTaskM.Text;
            starttime = starth + startm;
            endh = cmb_endTimeTaskH.Text;
            endm = cmb_endTimeTaskM.Text;
            endtime = endh + endm;

            try
            {
                con.ConnectionString = @"Data Source=DESKTOP-69MM1NJ\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";
              
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Tasks(TaskName,Category,DateOfTask,StartTime,EndTime,ToleranceTime,Location,InvolvedPersons,TaskType,Done,UserName)values(@TaskName,@Category,@DateOfTask,@StartTime,@EndTime,@ToleranceTime,@Location,@InvolvedPersons,@TaskType,@Done,@UserName)", con);
                //the User is no more new
                Home.NewUser = false;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@TaskName", txt_taskName.Text);
                cmd.Parameters.AddWithValue("@Category", cmb_category.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DateOfTask", DateTask.Value.ToString());
                cmd.Parameters.AddWithValue("@StartTime", starttime);
                cmd.Parameters.AddWithValue("@EndTime", endtime);
                cmd.Parameters.AddWithValue("@ToleranceTime", txt_tolerTime.Text);
                cmd.Parameters.AddWithValue("@Location", txt_taskLocation.Text);
                string[] InvPer = rb_invoPer.Lines;
                string inv = string.Join(",", InvPer);
                cmd.Parameters.AddWithValue("@InvolvedPersons", inv);
                cmd.Parameters.AddWithValue("@TaskType", cmb_taskType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Done", "no");
                cmd.Parameters.AddWithValue("@UserName", Home.FK);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Task added");
                SuccessTaskAdded tsk = new SuccessTaskAdded();
                tsk.Show();
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
    }
}

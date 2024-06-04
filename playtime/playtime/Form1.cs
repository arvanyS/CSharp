using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace playtime
{

    
    public partial class Playtime : Form
    {
        
        public Playtime()
        {
            InitializeComponent();
            


        }
        
        int hour = 0;
        int minute = 0;
        int second = 0;
        bool isClick = false;
        string gamePath = "";
        
        

        SqlConnection connection = new SqlConnection("Data Source = .; Initial Catalog=GAME; Integrated Security=True");

        private void AddGame() 
        {
            connection.Open();

            string addGameCmd = "INSERT INTO PLAY (GAME,PATH) VALUES (" + "'" + addGameText.Text + "'" + ",'"+gamePathText.Text+"'"+")";
            
            SqlCommand cmd = new SqlCommand(addGameCmd, connection);
            cmd.ExecuteNonQuery();
            connection.Close() ;

            gamesCombo.Items.Add(addGameText.Text);
            gamesCombo.SelectedIndex = gamesCombo.Items.Count-1;

            
        }
        private void IStarted() 
        {

            string current = DateTime.Now.ToString("yyyy-MM-dd");
            connection.Open();
            
            string startDateCmd = "UPDATE PLAY SET STARTING_DATE='" + current + "' WHERE GAME='" + gamesCombo.Text + "'";
            string StatusTo1Cmd = "UPDATE PLAY SET STATUS=" + 1 + " WHERE GAME='" + gamesCombo.Text + "'";

            SqlCommand cmd = new SqlCommand(startDateCmd, connection);
            SqlCommand cmd2 = new SqlCommand(StatusTo1Cmd, connection);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            connection.Close();
            ShowInformations();

        }
        private void IFinished()
        {


            string current = DateTime.Now.ToString("yyyy-MM-dd");

            connection.Open();
            
            string endDateCmd = "UPDATE PLAY SET ENDING_DATE='" + current + "' WHERE GAME='" + gamesCombo.Text + "'";
            string StatusTo0Cmd = "UPDATE PLAY SET STATUS=" + 0 + " WHERE GAME='" + gamesCombo.Text + "'";
            SqlCommand cmd = new SqlCommand(endDateCmd, connection);
            SqlCommand cmd2 = new SqlCommand(StatusTo0Cmd, connection);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            connection.Close();
            ShowInformations();
        }
        private void LoadGames()
        {
            connection.Open();
            string selectAll = "SELECT * FROM PLAY";
            SqlCommand cmd = new SqlCommand(selectAll, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                gamesCombo.Items.Add(reader["GAME"]);
                
            }


            connection.Close();


        }
        private void ShowInformations()
        {
            connection.Open();
            gamePath = "";
            string selectedGame = gamesCombo.Text;
            string selectedCmd = "SELECT * FROM PLAY WHERE GAME='" + selectedGame + "'";
            SqlCommand cmd = new SqlCommand(selectedCmd, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                hour = Convert.ToInt32(reader["PLAYING_HOURS"]);
                minute = Convert.ToInt32(reader["PLAYING_MINUTES"]);
                startLabel.Text = reader["STARTING_DATE"].ToString();
                finishLabel.Text = reader["ENDING_DATE"].ToString() ;
                gamePath = reader["PATH"].ToString();

                if (Convert.ToInt32(reader["STATUS"]) == 1)
                {
                    istartedButton.Enabled = false;
                    ifinishedButton.Enabled = true;
                }
                else
                {
                    istartedButton.Enabled = true;
                    ifinishedButton.Enabled = false;
                }
            }
            ShowTime();
            
            

            connection.Close();
            


        }
        private void SaveTime()
        {
            connection.Open();

            string hourCmd = "UPDATE PLAY SET PLAYING_HOURS=" + hour + " WHERE GAME='" + gamesCombo.Text + "'";
            string minuteCmd = "UPDATE PLAY SET PLAYING_MINUTES=" + minute + " WHERE GAME='" + gamesCombo.Text + "'";
            SqlCommand cmd = new SqlCommand(hourCmd, connection);
            SqlCommand cmd2 = new SqlCommand(minuteCmd, connection);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            connection.Close();
        }
        private void TickTack() 
        {
            second++;
            if (second == 60)
            {
                minute++;
                second = 0;
                if (minute == 60)
                {
                    minute = 0;
                    hour++;
                }
            }
        }
        private void ShowTime()
        {
            timerText.Text = hour + ":" + minute + ":" + second;
        }
        private void ResetTime()
        {
            hour = 0;
            minute = 0;
            second = 0;
        }
        private void LoadWarning()
        {
            MessageBox.Show("Firstly load a game!");
        }
        private void NullWarning()
        {
            MessageBox.Show("Game or path cannot be null!");
        }
        private void SelectGamePath()
        {
            gamePAth.ShowDialog();
            gamePath = gamePAth.FileName;
            gamePathText.Text = gamePath;

        }
        private void LaunchGame() 
        {

            try{
                System.Diagnostics.Process.Start(@gamePath);
                startTime();
                this.WindowState = FormWindowState.Minimized;

            }
            catch(System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("The game is not available");
            }
            
            
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            if (!isClick)
            {
                LoadWarning();
            }
            else
            {
                timer.Start();
                startButton.Visible = false;
                stopButton.Visible = true;
                resetButton.Visible = false;
            }
            
        }
        private void startTime()
        {
            timer.Start();
            startButton.Visible = false;
            stopButton.Visible = true;
            resetButton.Visible = false;
        }
        private void lightTheme()
        {
            Playtime.ActiveForm.BackColor = Color.White;

            foreach (Control item in Controls)
            {
                if (item is GroupBox)
                {
                    item.ForeColor = Color.Black;
                    item.BackColor = Color.LightSkyBlue;
                }
            }

        }
        private void darkTheme()
        {
            Playtime.ActiveForm.BackColor = Color.Black;

            foreach (Control item in Controls)
            {
                if (item is GroupBox)
                {
                    item.ForeColor = Color.White;
                    item.BackColor = Color.Transparent;
                }
            }
        }
       

       

        private void timer_Tick(object sender, EventArgs e)
        {
            ShowTime();
            TickTack();
            
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            stopButton.Visible = false;
            startButton.Visible = true;
            resetButton.Visible = true;
            saveButton.Visible = true;
        }

        private void Playtime_Load(object sender, EventArgs e)
        {
            
            LoadGames();
            if (gamesCombo.Items.Count != 0)
            {
                gamesCombo.SelectedIndex = gamesCombo.Items.Count-1;
            }
            
            ShowTime();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (addGameText.Text == "" || gamePathText.Text=="")
            {
                NullWarning();
            }
            else
            {
                AddGame();
            }
            
        }

        private void istartedButton_Click(object sender, EventArgs e)
        {
            if (!isClick)
            {
                LoadWarning();
            }
            else
            {
                IStarted();
            }
            
        }
        private void ifinishedButton_Click(object sender, EventArgs e)
        {
            if (!isClick)
            {
                LoadWarning();
            }
            else
            {
                IFinished();
            }

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            ShowInformations();
            isClick=true;
            launchButton.Enabled = true;
 
        }

        

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetTime();
            ShowTime();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
           SaveTime();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectGamePath();
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            if (!isClick)
            {
                LoadWarning();
            }
            else
            {
                
                LaunchGame();
                
            }
            
        }

        private void gamesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            launchButton.Enabled=false;
        }

        private void darkButton_Click(object sender, EventArgs e)
        {
            
        }

        private void themeButton_Click_1(object sender,EventArgs e)
        {
            lightTheme();
            themeButton.Visible=false;
            darkButton.Visible=true;
        }

        private void darkButton_Click_1(object sender, EventArgs e)
        {
            darkTheme();
            themeButton.Visible = true;
            darkButton.Visible = false;
        }
    }
}

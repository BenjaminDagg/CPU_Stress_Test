using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Management;
using System.Drawing;
using OpenHardwareMonitor.Hardware;






namespace StressTest
{
    public partial class CPUStressTest : Form
    {

        public int threadCount;
        public Thread[] threads;
        public const string CPU_NAME_KEY = "Win32_Processor";
        public string cpu = "";
        public int testedThreadCount = 0;
        public int testDuration;
        public bool isTesting;
        public int timer;
        public enum TimeUnit  { SECOND, MINUTE, HOUR };
        public TimeUnit timeUnit;
        public const int PRIME_NUM = 500000000;
        private EventWaitHandle waitHandle = new AutoResetEvent(false);



        public CPUStressTest()
        {
            //find thread count of users CPU
            this.threadCount = Environment.ProcessorCount;
            this.testedThreadCount = this.threadCount;

            //default test duration is 1 hour
            this.testDuration = 3600000;

            //get users cpu name
            this.cpu = getSystemObject(CPUStressTest.CPU_NAME_KEY);

            this.timeUnit = TimeUnit.MINUTE;

            //initialize worker threads
            this.threads = new Thread[this.threadCount];
            for (int i = 0; i < this.threadCount; i++)
            {
                this.threads[i] = new Thread(() => nthPrime(PRIME_NUM));
                
                
            }

            this.isTesting = false;

            this.timer = 0;

            

            
            InitializeComponent();

            //sert cpu label
            this.UserCpuLabel.Text = this.cpu;

            //set core count label
            this.UserCoreLabel.Text = this.threadCount.ToString();

            //set number of cores input
            
            //set input range for core input
            this.UserCoreInput.Maximum = this.threadCount;
            this.UserCoreInput.Minimum = 0;
            this.UserCoreInput.Value = this.threadCount;

            this.TimerLabel.Text = "Test Duration (min)";

            this.TimerStatus.Text = "00:00:00";

            //set cpu info
            this.CPUFreqActual.Text = this.cpuStats.currFreq.ToString();
            


        }

        
        /*
         * Gets the users processor name using Management 
         * */
        public string getSystemObject(string key)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2",
                "select * from " + key
                );

            string result = "";
            foreach (ManagementObject share in searcher.Get())
            {
                result += share["Name"];
            }

            return result;
            
        }


        //starts all member threads to begin work
        public void startTest()
        {
            //reset inputs
            this.isTesting = true;
            this.UserCoreInput.Enabled = false;
            this.TimerDurationInput.Enabled = false;

            //change button to stop button
            this.StartTestBtn.Text = "Stop";
            this.StartTestBtn.BackColor = Color.FromArgb(255, 128, 128);
            this.TestTimer.Enabled = true;
            
            //start threads
            for (int i = 0; i < this.testedThreadCount; i++)
            {
                //resume suspended threads
                if (this.threads[i].ThreadState == ThreadState.Suspended )
                {
                    this.threads[i].Resume();
                }
                else
                {
                    this.threads[i].Start();
                }


            }
            
            
        }


        //makes all member threads end work
        public void endTest()
        {
            //reset timer
            this.timer = 0;

            //reset inputs
            this.isTesting = false;
            this.UserCoreInput.Enabled = true;

            //change to start button
            //change button to stop button
            this.StartTestBtn.Text = "Start";
            this.StartTestBtn.BackColor = Color.FromArgb(128, 255, 128);
            this.TestTimer.Enabled = false;
            this.TimerDurationInput.Enabled = true;
            this.UserCoreInput.Enabled = true;

            //reset timer text
            this.TimerStatus.Text = "00:00:00";

            //suspend all threads
            for (int i = 0; i < this.threadCount; i++)
            {
                if (this.threads[i].ThreadState == ThreadState.Running || this.threads[i].ThreadState == ThreadState.Background)
                {
                    this.threads[i].Suspend();
                }
                
            }
            
            //initilize new array of threads
            this.threads = new Thread[this.threadCount];
            for (int i = 0; i < this.threadCount; i++)
            {
                this.threads[i] = new Thread(() => nthPrime(PRIME_NUM));
            }


        }


        //event toolbar label is clciked
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }


        //event triggered when test button is clicked
        private void TestToolBtn_Click(object sender, EventArgs e)
        {
            
        }


        //event when start button clicked
        private void StartBtn_Click(object sender, EventArgs e)
        {
            //make start button un-clickable
            this.StartMenuOption.Enabled = false;
            startTest();
        }

        //event when start button clicked
        private void StopBtn_Click(object sender, EventArgs e)
        {
            //make start button clickable again
            this.StartMenuOption.Enabled = true;
            endTest();
        }


        //the actuall CPU test itself. Calculates very large prime numbers
        public  void nthPrime(int n)
        {
            
            if (n < 1)
            {
                return;
            }

            List<int> prime_numbers = new List<int>();
            for (int i = 0; prime_numbers.Count < n; i++)
            {

                if (!this.isTesting)
                {
                    return;
                }

                //test if number is prime
                if (i <= 1)
                {
                    continue;
                }
                else if (i <= 3)
                {
                    prime_numbers.Add(i);
                }
                else if (i % 2 == 0 || i % 3 == 0)
                {
                    continue;
                }
                else
                {
                    int j = 5;
                    bool flag = false;
                    while (j * j <= i)
                    {
                        if (i % j == 0 || i % (i + 2) == 0)
                        {
                            flag = true;
                            break;
                        }
                        j += 6;
                    }
                    if (!flag)
                    {
                        prime_numbers.Add(i);
                    }
                }

            }

            
        }


        //event triggered when title label is clicked
        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void TabelLayout_Paint(object sender, PaintEventArgs e)
        {

        }


        //event triggered when user core inpout changes
        private void UserCoreInput_TextChanged(object sender, EventArgs e)
        {
            //update tested core countn variable to the user input
            this.testedThreadCount = Convert.ToInt32(Math.Round(this.UserCoreInput.Value, 0));
        }


        //event triggered when user core inpout changes
        private void UserCoreInput_ValueChanged(object sender, EventArgs e)
        {
            //update tested core countn variable to the user input
            this.testedThreadCount = Convert.ToInt32(Math.Round(this.UserCoreInput.Value,0));
        }


        //hh:mm:ss
        /*
         * Converts integer counter into a timer format
         * */
        private string parseTimer(int seconds)
        {
            if (seconds < 60)
            {
                if (seconds < 10)
                {
                    return "00:00:0" + seconds.ToString();
                }
                else
                {
                    return "00:00:" + seconds;
                }
            }
            else if (seconds >= 60 && seconds < 3600)
            {
                int min = (int)seconds / 60;
                int sec = seconds % 60;
                string resmin = min.ToString();
                string ressec = sec.ToString();
                if (min < 60)
                {
                    resmin = "0" + resmin;
                }
                if (sec < 60 && sec < 10)
                {
                    ressec = "0" + ressec;
                }
                return "00:" + resmin + ":" + ressec;
            }

            else
            {
                return seconds.ToString();
            }
        }
        


        //event triggered every interval of the timer (every 1 second)
        private void TestTimer_Tick(object sender, EventArgs e)
        {
            //increment timer variable
            this.timer++;

            //update timer
            this.TimerStatus.Text = parseTimer(this.timer);

            //check if time is up
            if (timer >= this.testDuration)
            {
                endTest();
                this.StartMenuOption.Enabled = true;
                TestTimer.Enabled = false;
            }

           
        }


        //event triggered when time interval input changes
        private void TimerDurationInput_ValueChanged(object sender, EventArgs e)
        {
            //checks if input is within bounds
            if (Convert.ToInt32(Math.Round(this.TimerDurationInput.Value, 0)) < 0)
            {
                MessageBox.Show("Duration must be a positive number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            //sets timer according to the selected unit
            switch (this.timeUnit)
            {
                case TimeUnit.SECOND:
                    this.testDuration = Convert.ToInt32(Math.Round(this.TimerDurationInput.Value, 0));
                    break;
                case TimeUnit.MINUTE:
                    this.testDuration = 60 * Convert.ToInt32(Math.Round(this.TimerDurationInput.Value, 0));
                    break;
                default:
                    this.testDuration = 3600 * Convert.ToInt32(Math.Round(this.TimerDurationInput.Value, 0));
                    break;
            }


            
        }


        //event triggered when start button on toolbar is clicked
        private void StartTestBtn_Click(object sender, EventArgs e)
        {
            if (!this.isTesting)
            {
                
                startTest();
            }
            else
            {
               
                endTest();
            }
           
        }


        //event triggered when a tim unit is selected from toolbar
        protected void TimeUnitBtn_Click(object sender, EventArgs e, TimeUnit unit)
        {
            this.timeUnit = unit;
            string res = "";
            switch(unit)
            {
                case TimeUnit.SECOND:
                    res = "sec";
                    break;
                case TimeUnit.MINUTE:
                    res = "min";
                    break;
                default:
                    res = "hr";
                    break;
            }
            //update timer label with new unit
            this.TimerLabel.Text = "Test Duration (" + res + ")";
        }
    }
}

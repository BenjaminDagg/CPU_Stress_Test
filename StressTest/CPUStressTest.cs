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
        public const int PRIME_NUM = Int32.MaxValue;



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
            
            this.UserCoreInput.Maximum = this.threadCount;
            this.UserCoreInput.Minimum = 0;

            this.TimerLabel.Text = "Test Duration (min)";

            this.TimerStatus.Text = "00:00:00";
        }


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
            this.isTesting = true;
            this.UserCoreInput.Enabled = false;
            this.TimerDurationInput.Enabled = false;

            //change button to stop button
            this.StartTestBtn.Text = "Stop";
            this.StartTestBtn.BackColor = Color.FromArgb(255, 128, 128);
            this.TestTimer.Enabled = true;

            for (int i = 0; i < this.testedThreadCount; i++)
            {
                if (this.threads[i].ThreadState == ThreadState.Suspended)
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

            for (int i = 0; i < this.testedThreadCount; i++)
            {
                
                this.threads[i].Suspend();
                
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void TestToolBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Test tool btn clicked");
        }


        //event when start button clicked
        private void StartBtn_Click(object sender, EventArgs e)
        {
            this.StartMenuOption.Enabled = false;
            startTest();
        }

        //event when start button clicked
        private void StopBtn_Click(object sender, EventArgs e)
        {
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

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void TabelLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserCoreInput_TextChanged(object sender, EventArgs e)
        {
            this.testedThreadCount = Convert.ToInt32(Math.Round(this.UserCoreInput.Value, 0));
        }

        private void UserCoreInput_ValueChanged(object sender, EventArgs e)
        {
            
            this.testedThreadCount = Convert.ToInt32(Math.Round(this.UserCoreInput.Value,0));
        }


        //hh:mm:ss
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
        

        private void TestTimer_Tick(object sender, EventArgs e)
        {
            this.timer++;

            this.TimerStatus.Text = parseTimer(this.timer);
            if (timer >= this.testDuration)
            {
                endTest();
                this.StartMenuOption.Enabled = true;
                TestTimer.Enabled = false;
            }
        }

        private void TimerDurationInput_ValueChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt32(Math.Round(this.TimerDurationInput.Value, 0)) < 0)
            {
                MessageBox.Show("Duration must be a positive number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

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
            this.TimerLabel.Text = "Test Duration (" + res + ")";
        }
    }
}

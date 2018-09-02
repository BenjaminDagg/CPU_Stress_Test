using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;


namespace StressTest
{
    public class CPUStatManager 
    {
        public uint currFreq;
        public uint maxFreq;
        
        

        public CPUStatManager()
        {
            this.currFreq = 0;
            this.maxFreq = 0;

            getCPUFreq();
        }


        
        //uses management api to get cpu frequency
        public void getCPUFreq()
        {
            using (ManagementObject Mo = new ManagementObject("Win32_Processor.DeviceID='CPU0'"))
            {
                this.currFreq = (uint)(Mo["CurrentClockSpeed"]);
                this.maxFreq = (uint)(Mo["MaxClockSpeed"]);
            }
        }

        
    }
}

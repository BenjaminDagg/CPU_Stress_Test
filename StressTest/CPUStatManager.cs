using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using OpenHardwareMonitor.Hardware;
using System.Diagnostics;


namespace StressTest
{
    public class CPUStatManager : IVisitor
    {
        public uint currFreq;
        public uint maxFreq;
        
        

        public CPUStatManager()
        {
            this.currFreq = 0;
            this.maxFreq = 0;
            getCPUFreq();
            
        }


        //sets computer object to look through
        public void VisitComputer(IComputer computer)
        {
            computer.Traverse(this);
        }


        //iterates over hardware of computer
        public void VisitHardware(IHardware hardware)
        {
            hardware.Update();
            foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
        }


        public void VisitSensor(ISensor sensor) { }
        public void VisitParameter(IParameter parameter) { }


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

using System;
using System.Collections.Generic;
using System.Text;

namespace RebootEngine
{
    public class ScheduleData
    {
        protected List<string> _hostCollection = new List<string>();
        public List<string> HostCollection { get { return _hostCollection; } }
        public DateTime RebootTime { get; set; }

        public void AddRebootSchedule()
        {
            var control = new schedulercontrol();
            foreach (var host in HostCollection)
            {
                control.ScheduleReboot(host, RebootTime);
            }
        }
    }

}

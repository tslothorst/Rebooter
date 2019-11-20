using System;
using System.Collections.Generic;
using System.Text;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices;

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

        private bool VerifyHostName(string HostName) 
        {
            string DomainName = Domain.GetCurrentDomain().ToString();
            string LdapAddress = "LDAP://" + DomainName + ":3289";
            DirectoryEntry de = new DirectoryEntry(LdapAddress);
            DirectorySearcher ds = new DirectorySearcher(de);
            return true;
        }
    }

}

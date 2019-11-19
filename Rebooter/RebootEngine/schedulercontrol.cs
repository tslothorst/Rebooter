using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32.TaskScheduler;

namespace RebootEngine
{
    class schedulercontrol
    {
        public schedulercontrol()
        {

        }

        public void ScheduleReboot(string hostname, DateTime reboottime)
        {
            using (TaskService ts = new TaskService(hostname))
            {
                // Create a new task definition and assign properties
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "Rebooter - Scheduled Reboot";

                // Create a trigger that will once
                td.Triggers.Add(new TimeTrigger { StartBoundary = reboottime });

                // Schedules a reboot to happen
                td.Actions.Add(new ExecAction("powershell.exe", "Restart-Computer -Force", null));

                // Register the task in the root folder
                ts.RootFolder.RegisterTaskDefinition(@"Server Reboot Once", td);

            }

        }
    }
}

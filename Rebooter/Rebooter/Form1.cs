using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RebootEngine;

namespace Rebooter
{
    public partial class Form1 : Form
    {
        protected ScheduleData schedData = new ScheduleData();

        public Form1()
        {
            InitializeComponent();          
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            schedData.AddRebootSchedule();
        }

        private void clrlist_Click(object sender, EventArgs e)
        {
            schedData.HostCollection.Clear();
            srvlist.Items.Clear();
        }

        private void addsrvtolist_Click(object sender, EventArgs e)
        {
            srvlist.Columns.Add("Hostname", -2, HorizontalAlignment.Left);
            srvlist.FullRowSelect = true;
            srvlist.GridLines = true;
            srvlist.View = System.Windows.Forms.View.List;

            string buffer = serverbox.Text;
            schedData.RebootTime = dateTimePicker1.Value;
            serverbox.Clear();
            if (!string.IsNullOrEmpty(buffer))
            {                
                schedData.HostCollection.Add(buffer);
                srvlist.Items.Clear();                 
                foreach (var host in schedData.HostCollection)
                {
                    srvlist.Items.Add(host);
                }                
            }
        }
    }
}

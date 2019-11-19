namespace Rebooter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serverbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addsrvtolist = new System.Windows.Forms.Button();
            this.clrlist = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.srvlist = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // serverbox
            // 
            this.serverbox.Location = new System.Drawing.Point(23, 25);
            this.serverbox.Name = "serverbox";
            this.serverbox.Size = new System.Drawing.Size(209, 20);
            this.serverbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servername:";
            // 
            // addsrvtolist
            // 
            this.addsrvtolist.Location = new System.Drawing.Point(12, 128);
            this.addsrvtolist.Name = "addsrvtolist";
            this.addsrvtolist.Size = new System.Drawing.Size(75, 23);
            this.addsrvtolist.TabIndex = 2;
            this.addsrvtolist.Text = "Add to list";
            this.addsrvtolist.UseVisualStyleBackColor = true;
            this.addsrvtolist.Click += new System.EventHandler(this.addsrvtolist_Click);
            // 
            // clrlist
            // 
            this.clrlist.Location = new System.Drawing.Point(12, 158);
            this.clrlist.Name = "clrlist";
            this.clrlist.Size = new System.Drawing.Size(75, 23);
            this.clrlist.TabIndex = 3;
            this.clrlist.Text = "Clear list";
            this.clrlist.UseVisualStyleBackColor = true;
            this.clrlist.Click += new System.EventHandler(this.clrlist_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Schedule Reboot";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Serverlist:";
            // 
            // srvlist
            // 
            this.srvlist.HideSelection = false;
            this.srvlist.Location = new System.Drawing.Point(288, 52);
            this.srvlist.Name = "srvlist";
            this.srvlist.Size = new System.Drawing.Size(452, 270);
            this.srvlist.TabIndex = 8;
            this.srvlist.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.srvlist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clrlist);
            this.Controls.Add(this.addsrvtolist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverbox);
            this.Name = "Form1";
            this.Text = "Reboot Scheduler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addsrvtolist;
        private System.Windows.Forms.Button clrlist;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView srvlist;
    }
}


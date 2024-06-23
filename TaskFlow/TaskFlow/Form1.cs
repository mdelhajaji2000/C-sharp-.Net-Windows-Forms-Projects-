using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskFlow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Starting_Panel.BringToFront();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Display_Date.Text = "";
            Display_Date.Text += dateTimePicker1.Value.ToString("dd-mm-yyyy") + Environment.NewLine;
            Display_Date.Text += dateTimePicker1.Value.ToString("yyyy-dd-mm") + Environment.NewLine;
            Display_Date.Text += dateTimePicker1.Value.ToString("dd-mmm-yy") + Environment.NewLine;
            Display_Date.Text += dateTimePicker1.Value.ToString("dddd,dd-mm-yyyy") + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            notifyIcon1.BalloonTipText = "Hello World";
            notifyIcon1.BalloonTipTitle = "Hello";
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("ttt");
        }
    }
}

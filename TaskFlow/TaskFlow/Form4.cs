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
    public partial class Form4 : Form
    {
        public Form4(string CurrentStatus)
        {
            InitializeComponent();
            Task_Status = CurrentStatus;
            Status_label.Text = CurrentStatus;
        }

        public string Task_Status;
        public bool Perform_Action = false;

        private void button1_Click(object sender, EventArgs e)
        {
            Task_Status = "Done";
            Status_label.Text = Task_Status;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task_Status = "Not Done Yet";
            Status_label.Text = Task_Status;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task_Status = "Canceled";
            Status_label.Text = Task_Status;
        }


        private void Return()
        {
            this.Close();
        }

        private void Confirm_BT_Click(object sender, EventArgs e)
        {
            Perform_Action = true;
            Return();
        }

        private void return_BT_Click(object sender, EventArgs e)
        {
            Perform_Action = false;
            Return();
        }
    }
}

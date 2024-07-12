using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskFlow
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ClearAll();
        }

        public static string Task_Title;
        public static string Task_Details;
        public static string Task_Start_Date;
        public static string Task_Expire_Date;
        public static bool Perform_Action = false;

        private void Task_Title_Text_Box_TextChanged(object sender, EventArgs e)
        {
            Task_Title = Task_Title_Text_Box.Text;
        }

        private void Task_Details_Text_Box_TextChanged(object sender, EventArgs e)
        {
            Task_Details = Task_Details_Text_Box.Text;
        }

        private void dateTimePicker_Starting_ValueChanged(object sender, EventArgs e)
        {
            Task_Start_Date = dateTimePicker_Starting.Text;
        }

        private void dateTimePicker_Expire_ValueChanged(object sender, EventArgs e)
        {
            Task_Expire_Date = dateTimePicker_Expire.Text;
        }

        private void Task_Title_Text_Box_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Task_Title_Text_Box.Text))
            {
                e.Cancel = true;
                Task_Title_Text_Box.Focus();
                errorProvider1.SetError(Task_Title_Text_Box, "Required...!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Task_Title_Text_Box, "");
            }
        }

        private void Task_Details_Text_Box_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Task_Details_Text_Box.Text))
            {
                e.Cancel = true;
                Task_Details_Text_Box.Focus();
                errorProvider1.SetError(Task_Details_Text_Box, "Required..!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Task_Details_Text_Box, "");
            }
        }

        private bool CheckDate() // Check the dates ability
        {
            if (Task_Start_Date == Task_Expire_Date)
            {
                MessageBox.Show("The Task Expire Date Cannot Be The Same As The starting Date..!", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            return true;
        }

        private void Return()
        {
            this.Close();
        }

        private void ClearAll()
        {
            Task_Title_Text_Box.Text = "";
            Task_Details_Text_Box.Text = "";
        }

        private void Creat_New_Task_BT_Click(object sender, EventArgs e)
        {
            Perform_Action = true;
            Return();
        }
    }
}

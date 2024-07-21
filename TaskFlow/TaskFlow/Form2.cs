using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

            Task_Title_Text_Box.Focus();

            dateTimePicker_Starting.Text = DateTime.Now.ToString();
            dateTimePicker_Expire.Text = DateTime.Now.AddDays(1).ToString();
        }

        public static string Task_Title;
        public static string Task_Details;
        public static string Task_Start_Date = "not Defined";
        public static string Task_Expire_Date = "not Defined";
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
            DateTime date = dateTimePicker_Starting.Value;
            Task_Start_Date = date.ToString("dd/MM/yyyy");
        }

        private void dateTimePicker_Expire_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker_Expire.Value;
            Task_Expire_Date = date.ToString("dd/MM/yyyy");
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
            Perform_Action = false;
        }

        private void ClearAll()
        {
            Task_Title_Text_Box.Text = "";
            Task_Details_Text_Box.Text = "";
        }

        private bool Check_Task_Info()
        {
            if (!CheckDate()) return false;

            if (string.IsNullOrEmpty(Task_Title) || string.IsNullOrEmpty(Task_Details))
            {
                MessageBox.Show("The Task Title Or Task Details Arent Inserted..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void Creat_New_Task_BT_Click(object sender, EventArgs e)
        {
            if (Check_Task_Info())
            {
                Perform_Action = true;
                this.Close();
            }
        }

        private void Return_BT_Click(object sender, EventArgs e)
        {
            Return();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Task_Title_Text_Box.Focus();

        }
    }
}

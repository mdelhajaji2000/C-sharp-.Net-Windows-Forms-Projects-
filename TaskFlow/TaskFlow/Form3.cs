using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskFlow
{
    public partial class Form3 : Form
    {
        public Form3(string Task_Title, string Task_Details, string Task_Start_Date, string Task_Expire_Date)
        {
            InitializeComponent();
            Task_Title_Text_Box.Text = Task_Title;
            Task_Details_Text_box.Text = Task_Details;
            dateTimePicker_Starting.Text = Task_Start_Date;
            dateTimePicker_Expire.Text = Task_Expire_Date;

        }

        public string New_Task_Title;
        public string New_Task_Details;
        public string New_Task_StartingDate;
        public string New_Task_ExpireDate;
        public bool Performe_Action = false;

        private void Return_BT_Click(object sender, EventArgs e)
        {
            Performe_Action = false;
            this.Close();
        }

        private void Edit_Task_BT_Click(object sender, EventArgs e)
        {
            Performe_Action = true;
            this.Close();
        }

        private void Task_Title_Text_Box_TextChanged(object sender, EventArgs e)
        {
            New_Task_Title = Task_Title_Text_Box.Text;
        }

        private void Task_Details_Text_box_TextChanged(object sender, EventArgs e)
        {
            New_Task_Details = Task_Details_Text_box.Text;
        }

        private void dateTimePicker_Starting_ValueChanged(object sender, EventArgs e)
        {
            New_Task_StartingDate = dateTimePicker_Starting.Value.ToString("dd/MM/yyyy");
        }

        private void dateTimePicker_Expire_ValueChanged(object sender, EventArgs e)
        {
            New_Task_ExpireDate = dateTimePicker_Expire.Value.ToString("dd/MM/yyyy");
        }
    }
}

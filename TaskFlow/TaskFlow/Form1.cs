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
            Main_Panel.BringToFront();
        }

        private void Show_Tasks_BT_Click(object sender, EventArgs e)
        {
            Show_Tasks_Panel.BringToFront();
        }


        // App Variables
        Form2 Create_New_Task_Form = new Form2();
        Form3 Edit_Task_Form = new Form3();
        //

        #region App Main Functions

        public void Add_Task()
        {
            ListViewItem item = new ListViewItem("Not Done Yet".Trim());
            item.ImageIndex = 0;
            item.SubItems.Add(Form2.Task_Title.Trim());
            item.SubItems.Add(Form2.Task_Details.Trim());
            item.SubItems.Add(Form2.Task_Start_Date.Trim());
            item.SubItems.Add(Form2.Task_Expire_Date.Trim());

            Task_List.Items.Add(item);
        }

        private void Remove_Task()
        {

        }


        #endregion

        private void Create_New_Bt_Click(object sender, EventArgs e)
        {
            Create_New_Task_Form.ShowDialog();
            if (Form2.Perform_Action)
            {
                Add_Task();
                MessageBox.Show("Task Created Successfuly..!", "Action Performed");
            }
            else
            {
                return;
            }
        }

        private void SelectImageForListViewIteam(string status)
        {
            switch(status)
            {
                case "Not Done Yet":
                    Task_List.SelectedItems[0].ImageIndex = 0;
                    break;
                case "Done":
                    Task_List.SelectedItems[0].ImageIndex = 1;
                    break;
                case "Canceled":
                    Task_List.SelectedItems[0].ImageIndex = 2;
                    break;
            }
        }

        private void Task_List_DoubleClick(object sender, EventArgs e)
        {
            Form4 Edit_Task_Status_Form = new Form4(Task_List.SelectedItems[0].Text);
            Edit_Task_Status_Form.ShowDialog();
            if (Edit_Task_Status_Form.Perform_Action)
            {
                Task_List.SelectedItems[0].Text = Edit_Task_Status_Form.Task_Status;
                SelectImageForListViewIteam(Task_List.SelectedItems[0].Text);
            }
        }

        private void Remove_Task_Bt_Click(object sender, EventArgs e)
        {
            if (Task_List.Items.Count > 0)
            {
                Task_List.SelectedItems[0].Remove();
                MessageBox.Show("Task Removed Successfuly", "Action Performed");
            }
            else return;
        }

        private void Creat_New_Task_BT_Click(object sender, EventArgs e)
        {
            Create_New_Task_Form.ShowDialog();
            if (Form2.Perform_Action)
            {
                Add_Task();
                MessageBox.Show("Task Created Successfuly..!", "Action Performed");
            }
            else
            {
                return;
            }
        }
    }
}

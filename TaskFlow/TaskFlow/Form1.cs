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

        #region App Main Functions

        private void Check_items_Count()
        {
            if (Task_List.Items.Count == 0)
            {
                No_Tasks_Mark_Label.Visible = true;
            }
            else
            {
                No_Tasks_Mark_Label.Visible = false;
            }
        }

        public void Add_Task()
        {
            ListViewItem item = new ListViewItem("Not Done Yet".Trim());
            item.ImageIndex = 0;

            Font itemFont = new Font(Task_List.Font.Name, 13);
            item.Font = itemFont;

            item.SubItems.Add(Form2.Task_Title.Trim());
            item.SubItems.Add(Form2.Task_Details.Trim());
            item.SubItems.Add(Form2.Task_Start_Date.Trim());
            item.SubItems.Add(Form2.Task_Expire_Date.Trim());

            Task_List.Items.Add(item);

            Check_items_Count();
        }

        private void Remove_Task()
        {
            if (Task_List.Items.Count > 0)
            {
                try
                {
                    for (int i = 0; i < Task_List.SelectedItems.Count; i++)
                    {
                        Task_List.SelectedItems[i].Remove();
                    }

                    //MessageBox.Show("Task(s) Removed Successfuly", "Action Performed");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
            else return;

            Check_items_Count();
        }


        #endregion

        private void Create_Task()
        {
            Form2 Create_New_Task_Form = new Form2();

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

        private void Create_New_Bt_Click(object sender, EventArgs e)
        {
            Create_Task();
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
            //Form4 Edit_Task_Status_Form = new Form4(Task_List.SelectedItems[0].Text);
            //Edit_Task_Status_Form.ShowDialog();
            //if (Edit_Task_Status_Form.Perform_Action)
            //{
            //    Task_List.SelectedItems[0].Text = Edit_Task_Status_Form.Task_Status;
            //    SelectImageForListViewIteam(Task_List.SelectedItems[0].Text);
            //}

            string Task_Status = Task_List.SelectedItems[0].Text;
            string Task_Title = Task_List.SelectedItems[0].SubItems[1].Text;
            string Task_Details = Task_List.SelectedItems[0].SubItems[2].Text;
            string Task_Starting_Date = Task_List.SelectedItems[0].SubItems[3].Text;
            string Task_Expire_Date = Task_List.SelectedItems[0].SubItems[4].Text;

            string Task_info = "Task Title :                 " + Task_Title + "\n";
            Task_info += "Task Status :                " + Task_Status + "\n";
            Task_info += "Task Details :               " + Task_Details + "\n";
            Task_info += "Task Starting Date :     " + Task_Starting_Date + "\n";
            Task_info += "Task_Expire_Date :       " + Task_Expire_Date;

            string TaskInfo_title = "Task Info";

            MessageBox.Show(Task_info, TaskInfo_title);
        }

        private void Remove_Task_Bt_Click(object sender, EventArgs e)
        {
            Remove_Task();
        }

        private void Creat_New_Task_BT_Click(object sender, EventArgs e)
        {
            Create_Task();
        }


        private void Edit_BT_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure at least one item is selected
                if (Task_List.SelectedItems.Count > 0)
                {
                    var selectedItem = Task_List.SelectedItems[0];

                    // Ensure the selected item has the required number of subitems
                    if (selectedItem.SubItems.Count >= 5)
                    {
                        // Pass the subitem texts to the dialog
                        Form3 Edit_Item_Dialog = new Form3(
                            selectedItem.SubItems[1].Text,
                            selectedItem.SubItems[2].Text,
                            selectedItem.SubItems[3].Text,
                            selectedItem.SubItems[4].Text
                        );

                        Edit_Item_Dialog.ShowDialog(); // Ensure ShowDialog is used to wait for dialog result

                        // Check if the action should be performed after the dialog is closed
                        if (Edit_Item_Dialog.Performe_Action)
                        {
                            // Update subitems with new values from the dialog
                            selectedItem.SubItems[1].Text = Edit_Item_Dialog.New_Task_Title;
                            selectedItem.SubItems[2].Text = Edit_Item_Dialog.New_Task_Details;
                            selectedItem.SubItems[3].Text = Edit_Item_Dialog.New_Task_StartingDate;
                            selectedItem.SubItems[4].Text = Edit_Item_Dialog.New_Task_ExpireDate;
                        }

                        // Optionally refresh the ListView (usually not needed)
                        Task_List.Refresh();

                        //
                        Current_Selected_Task_Status.Text = selectedItem.SubItems[1].Text;
                    }
                    else
                    {
                        MessageBox.Show("The selected item does not have enough subitems.");
                    }
                }
                else
                {
                    MessageBox.Show("No item is selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Task_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Task_List.SelectedItems.Count > 0)
            {
                Mark_To_Select_TaskStatus_label.Visible = false;
                Current_Selected_Task_Status.Text = Task_List.SelectedItems[0].Text;
                Selected_Task_Name_Label.Text = Task_List.SelectedItems[0].SubItems[1].Text;

                Remove_Task_Bt.Enabled = true;
                Edit_BT.Enabled = true;
            }
            else
            {
                Mark_To_Select_TaskStatus_label.Visible = true;
                Remove_Task_Bt.Enabled = false;
                Edit_BT.Enabled = false;
                Selected_Task_Name_Label.Text = "No Selected Tasks";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Create_Task();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Check_items_Count();
        }

        private void Change_To_Done_BT_Click(object sender, EventArgs e)
        {
            Task_List.SelectedItems[0].Text = "Done";
            Current_Selected_Task_Status.Text = "Done";
            Task_List.SelectedItems[0].ImageIndex = 1;
        }

        private void Change_To_NotDone_BT_Click(object sender, EventArgs e)
        {
            Task_List.SelectedItems[0].Text = "Not Done Yet";
            Current_Selected_Task_Status.Text = "Not Done Yet";
            Task_List.SelectedItems[0].ImageIndex = 0;
        }

        private void Change_To_Canceled_Bt_Click(object sender, EventArgs e)
        {
            Task_List.SelectedItems[0].Text = "Canceled";
            Current_Selected_Task_Status.Text = "Canceled";
            Task_List.SelectedItems[0].ImageIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 34; i++)
            {
                ListViewItem item = new ListViewItem("Not Done Yet".Trim());
                item.ImageIndex = 0;

                Font itemFont = new Font(Task_List.Font.Name, 13);
                item.Font = itemFont;

                item.SubItems.Add("Task" + i);
                item.SubItems.Add("Do Task " + i);
                item.SubItems.Add("12/04/2024");
                item.SubItems.Add("12/12/2012");

                Task_List.Items.Add(item);

                Check_items_Count();
            }
        }


    }
}

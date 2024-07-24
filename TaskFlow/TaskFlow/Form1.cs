/*
====================================================
Created By : Mdelhajaji2000 [insta]
This Project is under Lisence : BSD 3-Clause License
====================================================
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace TaskFlow
{
    public partial class Form1 : Form 
    {

        private List<ListViewItem> All_Items;
        public Form1()
        {
            InitializeComponent();
            Main_Panel.BringToFront();
            All_Items = new List<ListViewItem>();
        }

        #region States Variables

        // Those int variables are used In The Stats Board in the main panel
        int DoneTaskCount = 0;
        int CanceledTaskCount = 0;
        int NotDoneTaskCount = 0;
        int TotaleTaskCount = 0;  // Soon Those int will be autoFiled By The Data Base...

        #endregion

        #region Application Back-End Functions 

        public void Add_Task()
        {
            ListViewItem item = new ListViewItem("Not Done Yet".Trim());
            item.ImageIndex = 0;

            Font itemFont = new Font(Task_List.Font.Name, 13);
            item.Font = itemFont;

            item.SubItems.Add(Form2.Task_Title.Trim());
            item.SubItems.Add(Form2.Task_Details.Trim());
            item.SubItems[1].Font = new Font(Task_List.Font.Name, 17);
            item.SubItems.Add(Form2.Task_Start_Date.Trim());
            item.SubItems.Add(Form2.Task_Expire_Date.Trim());

            Task_List.Items.Add(item);
            if (!All_Items.Contains(item))
            {
                All_Items.Append(item);
            }
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
                        if (All_Items.Count > 0)
                        {
                            if (All_Items.Contains(Task_List.SelectedItems[i]))
                            {
                                All_Items.Remove(Task_List.SelectedItems[i]);
                            }
                        }

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

        private void Copy_TaskListItems_To_List()
        {
            if (All_Items.Count == 0)
            {
                foreach (ListViewItem item in Task_List.Items)
                {
                    All_Items.Add(item);
                }
            }
        }

        private void SelectImageForListViewIteam(string status)
        {
            switch (status)
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

        private string GetTaskInfo()
        {
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

            return Task_info;
        }

        private void EditSelectedListViewItem()
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
                //Task_List.Refresh();

                //
                Current_Selected_Task_Status.Text = selectedItem.SubItems[1].Text;
            }
            else
            {
                MessageBox.Show("The selected item does not have enough subitems.");
            }
        }

        private void SelectedItemsCountChange()
        {
            if (Task_List.SelectedItems.Count > 0)
            {
                Mark_To_Select_TaskStatus_label.Visible = false;
                Current_Selected_Task_Status.Text = Task_List.SelectedItems[0].Text;
                Selected_Task_Name_Label.Text = Task_List.SelectedItems[0].SubItems[1].Text;

                Remove_Task_Bt.Enabled = true;
                Edit_BT.Enabled = true;
                Console.WriteLine($"{Task_List.SelectedItems[0].Text}");

            }
            else
            {
                Mark_To_Select_TaskStatus_label.Visible = true;
                Remove_Task_Bt.Enabled = false;
                Edit_BT.Enabled = false;
                Selected_Task_Name_Label.Text = "No Selected Tasks";
            }
        }

        private void GenerateRandomItems()
        {
            for (int i = 0; i < 15; i++)
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
                Console.WriteLine($"Task {i} Created ...!");
                Check_items_Count();


            }
        }

        private void GetSerchedItems(string Task_Name)
        {
            Copy_TaskListItems_To_List();


            if (string.IsNullOrEmpty(Task_Name))
            {
                Task_List.Items.Clear();
                Task_List.Items.AddRange(All_Items.ToArray());
                return;
            }

            var Search_items = All_Items.Where(item => item.SubItems[1].Text == Task_Name);
            Task_List.Items.Clear();

            if (Search_items.Count() == 0)
            {
                MessageBox.Show($"No Task with {Task_Name} was Found...!");
                Task_List.Items.Clear();
                Task_List.Items.AddRange(All_Items.ToArray());
                return;
            }

            Task_List.Items.Clear();
            Task_List.Items.AddRange(Search_items.ToArray());
        }

        private void Reset_Task_List()
        {
            DialogResult Result = MessageBox.Show("Are You Sure That You want To Delete All Your Tasks ? ", "Confirmation.", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (Result == DialogResult.Yes)
            {
                if (All_Items.Count() > 0)
                {
                    All_Items.Clear();
                }
                if (Task_List.Items.Count > 0)
                {
                    Task_List.Items.Clear();
                }
                Mark_To_Select_TaskStatus_label.Visible = true;
            }
            else
            {
                MessageBox.Show("Action Canceled..!");
            }
        }

        private void Filtering_Tasks_By_Task_Status(int index) // use the paramter (Best Practice => To let The Function Worck With other Controls)
        {
            if (All_Items.Count == 0)
            {
                foreach (ListViewItem item in Task_List.Items)
                {
                    All_Items.Add(item);
                }
            }

            Task_List.Items.Clear();

            switch (index)
            {
                case 0:
                    Task_List.Items.AddRange(All_Items.ToArray());
                    All_Items.Clear();
                    break;
                case 1:
                    var Completed_Task = All_Items.Where(item => item.Text == "Completed");
                    Task_List.Items.AddRange(Completed_Task.ToArray());
                    break;
                case 2:
                    var NotDoneTask = All_Items.Where(item => item.Text == "Not Done Yet");
                    Task_List.Items.AddRange(NotDoneTask.ToArray());
                    break;
                case 3:
                    var CanceledTAsk = All_Items.Where(item => item.Text == "Canceled");
                    Task_List.Items.AddRange(CanceledTAsk.ToArray());
                    break;
            }

        }


        private void GetStats()
        {
            Copy_TaskListItems_To_List();
            int DoneTaskCounter = 0;
            int NotDoneTaskCounter = 0;
            int CanceledTaskCounter = 0;

            foreach (ListViewItem item in All_Items)
            {
                // Trim whitespace and compare case-insensitively
                string itemText = item.Text.Trim();

                Console.WriteLine("=-=" + itemText); // Debugging output

                if (itemText.Equals("Completed", StringComparison.OrdinalIgnoreCase))
                {
                    DoneTaskCounter++;
                }
                else if (itemText.Equals("Not Done Yet", StringComparison.OrdinalIgnoreCase))
                {
                    NotDoneTaskCounter++;
                }
                else if (itemText.Equals("Canceled", StringComparison.OrdinalIgnoreCase))
                {
                    CanceledTaskCounter++;
                }
            }

            DoneTaskCount = DoneTaskCounter;
            NotDoneTaskCount = NotDoneTaskCounter;
            TotaleTaskCount = All_Items.Count;
            CanceledTaskCount = CanceledTaskCounter;
        }

        private void Refresh_Stats()
        {
            GetStats(); // fill counters variables with values from all_items list

            Totale_Task_Counter.Text = TotaleTaskCount.ToString();
            Done_Task_Counter.Text = DoneTaskCount.ToString();
            NotDone_task_Counter.Text = NotDoneTaskCount.ToString();
            Canceled_Task_Counter.Text = CanceledTaskCount.ToString();
        }

        #endregion

        #region Controls Event Functions

        private void Show_Tasks_BT_Click(object sender, EventArgs e)
        {
            Show_Tasks_Panel.BringToFront();
        }

        private void Create_New_Bt_Click(object sender, EventArgs e)
        {
            Filtering_Tasks_By_Task_Status(0);
            Create_Task();
        }

        private void Task_List_DoubleClick(object sender, EventArgs e)
        {
            // Editing The Task status Was Change From Form4 To The Main Form Side Bar....!
            // Thiose are The Old Code And Form 4 is Still Included In The Project
            //Form4 Edit_Task_Status_Form = new Form4(Task_List.SelectedItems[0].Text);
            //Edit_Task_Status_Form.ShowDialog();
            //if (Edit_Task_Status_Form.Perform_Action)
            //{
            //    Task_List.SelectedItems[0].Text = Edit_Task_Status_Form.Task_Status;
            //    SelectImageForListViewIteam(Task_List.SelectedItems[0].Text);
            //}

            string TaskInfo_title = "Task Info";

            MessageBox.Show(GetTaskInfo(), TaskInfo_title);
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
                    EditSelectedListViewItem();
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
            SelectedItemsCountChange();
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
            Task_List.SelectedItems[0].Text = "Completed";
            Current_Selected_Task_Status.Text = "Completed";
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
            Filtering_Tasks_By_Task_Status(0);
            GenerateRandomItems();
        }

        int ButtonCkliked = 0;
        private void Search_BT_Click(object sender, EventArgs e)
        {

            if (ButtonCkliked % 2 == 0)
            {
                string Task_Name = Search_Text_Box.Text;
                GetSerchedItems(Task_Name);
                ButtonCkliked++;
                Search_BT.BackgroundImage = Properties.Resources._003_multiply;
            }
            else
            {

                Copy_TaskListItems_To_List();
                Task_List.Items.Clear();
                Task_List.Items.AddRange(All_Items.ToArray());
                ButtonCkliked++;
                Search_BT.BackgroundImage = Properties.Resources._004_find;

                comboBox1.SelectedIndex = 0;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reset_Task_List();
        }

        private void Stats_Refresh_BT_Click(object sender, EventArgs e)
        {
            Refresh_Stats();
        }

        private void return_ToMain_BT_Click(object sender, EventArgs e)
        {
            Main_Panel.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/mdelhajaji2000/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/mdelhajaji2000");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:mdelhajajipro2007@gmail.com");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:mdelhajajipro2007@gmail.com");
        }

        private void About_BT_Click(object sender, EventArgs e)
        {
            About_The_Devalloper_Panel.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Main_Panel.BringToFront();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtering_Tasks_By_Task_Status(comboBox1.SelectedIndex);
        }

        private void Reset_From_BT_Click(object sender, EventArgs e)
        {
            Reset_Task_List();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application Type  : Windows Form\n" +
                            "Frame Worck       : .NET 8\n" +
                            "Language          : C# version 10\n" +
                            "App Main Language : English USA\n" +
                            @"Source Code       : www.github.com\mdelhajaji2000" +
                            "IDE :             : \nVisual Studio Community Edition", "Application Info");
        }

        #endregion


    }

}

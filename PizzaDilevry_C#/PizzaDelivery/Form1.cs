using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PizzaDelivery
{


    public partial class Form1 : Form
    {

        private Label[] labels;
        private int count = 0;
        private int max_labels = 6;
        private double _Price = 0d;
        private int ToppingsAddedCounter = 0;
        private double _Sizeprice = 0d;
        private bool IsForShipping = false;
        private List<string> Discount_codes = File.ReadAllLines(@"C:\Users\mdelh\OneDrive\Desktop\My-Full-Real-Projects\C-sharp-.Net-Windows-Forms-Projects-\PizzaDilevry_C#\PizzaDelivery\Resources\Discount_Codes.txt").ToList();
        //
        public static string _SPizza_size = "";
        public static string _SCrustType = "";
        public static string _SWhere_To_eat = "";
        public static string _SToppings = "";
        public static string _Scount = "";
        public static string _Sdiscount_value = "";
        public static string _SPizza_type = "";
        public static string _SFinalPrice = "";
        //

        public static Shipping ShippingForm = new Shipping();

        int button = 1;

        int _Count = 1;
        double _Size = 0d;
        double _Toppings = 0d;
        bool _Discount = false;

        private void UpdateToTalePrice(double SizePrice, double Toppings, int Count, bool Discount = false)
        {
            _Price = (SizePrice + Toppings) * Count;
            if (Discount)
            {
                _Price -= (_Price * 10) / 100;
            }
            Dispaly_TOTAle_Price.Text = _Price.ToString() + "$";
            _SFinalPrice = _Price.ToString();
            UpdateTopingslabel();
        }

        private void UpdatePrice_Size(double SizePrice)
        {
            UpdateToTalePrice(SizePrice, 0, 0, false);
        }

        public Form1()
        {
            InitializeComponent();
            labels_Array();
            this.Start_Panel.BringToFront();
            Reset_All();
        }

        private void labels_Array()
        {
            labels = new Label[max_labels];
            Console.WriteLine("label {0} : created", (max_labels));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count == max_labels - 1)
            {
                MessageBox.Show("You attend to The maximan possible buttons", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else
            {
                count++;
                labels[count] = new Label();
                // Set Default button Propareties : 
                labels[count].Text = Text;
                labels[count].Name = labels[count].Text;
                labels[count].Size = new System.Drawing.Size(191, 33);
                labels[count].TabIndex = count + 10;
                //this.groupBox6.Controls.Add(this.label[count]);
                this.ToppingsSumary.Controls.Add(this.labels[count]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addButton();
        }


        private System.Windows.Forms.Button addButton()
        {
            Button btn = new Button();
            this.Controls.Add(btn);

            btn.Top = button * 20;
            btn.Left = 200;
            btn.Text = "button" + this.button.ToString();
            btn.BringToFront();
            button++;

            return btn;
        }

        private void BT_Size_Small_CheckedChanged(object sender, EventArgs e)
        {
           
            Display_Size.Text = "Small";
            _SPizza_size = "Small";
            _Size = 3d;
            UpdateToTalePrice(_Size, _Toppings, _Count, _Discount);
            //SizeCount = 3d;
            //Dispaly_TOTAle_Price.Text = Convert.ToString(_Price + SizeCount) + "$";

        }

        private void BT_Pizza_Meduim_CheckedChanged(object sender, EventArgs e)
        {
            Display_Size.Text = "Medium";
            _SPizza_size = "Meduim";
            _Size = 5.5d;
            UpdateToTalePrice(_Size, _Toppings, _Count, _Discount);
            //Dispaly_TOTAle_Price.Text = Convert.ToString(_Price + SizeCount) + "$";
        }

        private void BT_Size_Larg_CheckedChanged(object sender, EventArgs e)
        {
            Display_Size.Text = "Large";
            _SPizza_size = "Large";
            _Size = 7d;
            UpdateToTalePrice(_Size, _Toppings, _Count, _Discount);
            //Dispaly_TOTAle_Price.Text = Convert.ToString(_Price + SizeCount) + "$";

        }

        private void Crust_Thin_CheckedChanged(object sender, EventArgs e)
        {
            Display_CrustType.Text = "Thin";
            _SCrustType = "Thin";
        }

        private void Crust_Think_CheckedChanged(object sender, EventArgs e)
        {
            Display_CrustType.Text = "Think";
            _SCrustType = "Think";
        }

        private void AddLabel(string text)
        {
            if (count >= max_labels)
            {
                MessageBox.Show("Maximum number of labels reached", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Label newLabel = new Label();
            newLabel.Text = text;
            newLabel.Name = "Label" + count;
            newLabel.Size = new System.Drawing.Size(230, 30);
            newLabel.TabIndex = count + 10;
            newLabel.Location = new Point(10, 10 + (count * 25));
            newLabel.Tag = count;
            this.ToppingsSumary.Controls.Add(newLabel);

            labels[count] = newLabel;
            count++;

            if (count > 0)
            {
                Toppings_none_label.Visible = false;
            }
        }

        private void RemoveLabel(int tag)
        {
            if (tag >= 0 && tag < count)
            {
                Label labelToRemove = labels[tag];
                this.ToppingsSumary.Controls.Remove(labelToRemove);
                labelToRemove.Dispose();

                for (int i = tag; i < count - 1; i++)
                {
                    labels[i] = labels[i + 1];
                    labels[i].Location = new Point(labels[i].Location.X, labels[i].Location.Y - 25);
                    labels[i].Tag = i;
                }

                labels[count - 1] = null;
                count--;
            }

            if (count == 0)
            {
                Toppings_none_label.Visible = true;
            }
        }

        private void BT_ExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            if (BT_ExtraChees.Checked)
            {
                _Toppings += 0.5d;
                AddLabel("Extra Cheese - 0.50$");
                UpdateToTalePrice(_Size, _Toppings, _Count, _Discount);
            }
            else
            {
                _Toppings -= 0.5d;
                UpdateToTalePrice(_Size, _Toppings, _Count, _Discount);
                for (int i = 0; i < count; i++)
                {
                    if (labels[i] != null && labels[i].Text == "Extra Cheese - 0.50$")
                    {
                        RemoveLabel(i);
                        break;
                    }
                }
            }
        }

        private void BT_Mushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (BT_Mushrooms.Checked)
            {
                _Toppings += 1;
                AddLabel("Mushrooms - 1.00$");
                UpdateToTalePrice(_Size, _Toppings, _Count, _Discount);
            }
            else
            {
                _Toppings -= 1;
                UpdateToTalePrice(_Size, _Toppings, _Count, _Discount);
                for (int i = 0; i < count; i++)
                {
                    if (labels[i] != null && labels[i].Text == "Mushrooms - 1.00$")
                    {
                        RemoveLabel(i);
                        break;
                    }
                }
            }
        }

        private void BT_Tomatos_CheckedChanged(object sender, EventArgs e)
        {
            if (BT_Tomatos.Checked)
            {
                _Toppings += 0.25d;
                AddLabel("Tomatoes - 0.25$");
                UpdateToTalePrice(_Size, _Toppings, _Count, _Discount);
            }
            else
            {
                _Toppings -= 0.25d;
                UpdateToTalePrice(_Size, _Toppings, _Count, _Discount);
                for (int i = 0; i < count; i++)
                {
                    if (labels[i] != null && labels[i].Text == "Tomatoes - 0.25$")
                    {
                        RemoveLabel(i);
                        break;
                    }
                }
            }
        }

         private void Update_AddedPrice()
         {
             Display_Totale_Toppings.Text = Convert.ToString(_Toppings) + "$";
             Dispaly_TOTAle_Price.Text = Convert.ToString(_Price) + "$";
         }

        private void BT_Union_CheckedChanged(object sender, EventArgs e)
        {
            if (BT_Union.Checked)
            {
                _Toppings += 0.25d;
                AddLabel("Union - 0.25$");
                UpdateToTalePrice(_Size, _Toppings, _Count, _Discount);
            }
            else
            {
                _Toppings -= 0.25d;
                UpdateToTalePrice(_Size, _Toppings, _Count, _Discount);
                for (int i = 0; i < count; i++)
                {
                    if (labels[i] != null && labels[i].Text == "Union - 0.25$")
                    {
                        RemoveLabel(i);
                        break;
                    }
                }
            }
        }

        private void BT_Olives_CheckedChanged(object sender, EventArgs e)
        {
            if (BT_Olives.Checked)
            {
                //_Price += 0.25d;
                //_Toppings += 0.25d;
                AddLabel("Olives - FREE");
            }
            else
            {
                //_Price -= 0.25d;
                //_Toppings -= 0.25d;
                for (int i = 0; i < count; i++)
                {
                    if (labels[i] != null && labels[i].Text == "Olives - FREE")
                    {
                        RemoveLabel(i);
                        break;
                    }
                }
            }
        }

        private void BT_Green_Papper_CheckedChanged(object sender, EventArgs e)
        {
            if (BT_Green_Papper.Checked)
            {
                _Toppings += 0.5d;
                AddLabel("Green_Papper - 0.5$");
                UpdateToTalePrice(_Size, _Toppings, _Count, _Discount);
            }
            else
            {
                _Toppings -= 0.5d;
                UpdateToTalePrice(_Size, _Toppings, _Count, _Discount);
                for (int i = 0; i < count; i++)
                {
                    if (labels[i] != null && labels[i].Text == "Green_Papper - 0.5$")
                    {
                        RemoveLabel(i);
                        break;
                    }
                }
            }
        }

        private void BT_EAt_In_CheckedChanged(object sender, EventArgs e)
        {
            DIsplay_Where_TO_Eat.Text = "Eat-IN";
        }

        private void BT_Take_Out_CheckedChanged(object sender, EventArgs e)
        {
            DIsplay_Where_TO_Eat.Text = "Take-out";
        }


        private void TB_reset_Click(object sender, EventArgs e)
        {
            Reset_All();
        }

        private void Reset_All()
        {
            BT_Size_Small.Checked = false;
            BT_Pizza_Meduim.Checked = false;
            BT_Size_Larg.Checked = false;
            Crust_Thin.Checked = false;
            Crust_Think.Checked = false;
            BT_EAt_In.Checked = false;
            BT_Take_Out.Checked = false;

            for (int i = 0; i < 6; i++)
            {
                if (labels[i] != null)
                {
                    RemoveLabel(i);
                }
            }

            BT_ExtraChees.Checked = false;
            BT_Mushrooms.Checked = false;
            BT_Tomatos.Checked = false;
            BT_Olives.Checked = false;
            BT_Union.Checked = false;
            BT_Olives.Checked = false;
            BT_Green_Papper.Checked = false;

            numericUpDown_Count.Value = 1;
            CB_PizzaType.SelectedIndex = 0;

            MTB_DiscountCode.Text = "";
            Display_PizzaType.Text = "Normal";
            Display_Discountvalue.Text = "-0%";

            Display_Size.Text = "";
            DIsplay_Where_TO_Eat.Text = "";
            Display_CrustType.Text = "";
            Dispaly_TOTAle_Price.Text = "0.00$";
            Display_Totale_Toppings.Text = "0.00$";

            MTB_DiscountCode.Enabled = true;

            _Count = 1;
            _Size = 0d;
            _Toppings = 0d;
            _Discount = false;
            UpdateToTalePrice(_Size, _Toppings, _Count, false);

            Toppings_none_label.Visible = true;
        }

        public static bool _IsForShipping()
        {
            if (_SWhere_To_eat == "Take-out")
                return true;
            return false;
        }

        private void TB_Order_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Get_SToppings());
            Fill_Bill_Informatioms();
            if (Check_Order_Ability())
            {
                if (_IsForShipping())
                {
                    ShippingForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Order Taken Successfuly : Click OK To Get The Bill", "Order Taken", MessageBoxButtons.OK);
                    Export_Order.ExportBillToTxtFile();
                }

            }
            else return;
        }

        private void Fill_Bill_Informatioms()
        {
            _SToppings = Get_SToppings();
            if (string.IsNullOrEmpty(_SToppings))
            {
                _SToppings = "None";
            }

            if (string.IsNullOrEmpty(_SPizza_type))
            {
                _SPizza_type = "Normal";
            }

            _SWhere_To_eat = DIsplay_Where_TO_Eat.Text;
        }

        protected string Get_SToppings()
        {
            string Stoppings = "";
            foreach (Label C in labels)
            {
                if (C != null)
                {
                    Stoppings += "" + C.Text;
                    Stoppings += "\n";
                }
                Stoppings += "                       ";
            }

            return Stoppings;
        }

        private void CB_PizzaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display_PizzaType.Text = CB_PizzaType.Text;
        }

        private void MTB_DiscountCode_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_Price < 3)
            {
                MessageBox.Show("Please select The passed Pizza Information To Complete and Apli the Discount Code !", "Discount Faild !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (Discount_codes.Contains(MTB_DiscountCode.Text))
            {
                if (_Price >= 3) _Price -= ((10 * _Price) / 100);
                Discount_Message.ForeColor = System.Drawing.Color.FromArgb(43, 255, 0);
                Discount_Message.Visible = true;
                Discount_Message.Text = "valable Discount Code (:";
                Display_Discountvalue.Text = "-10%";
                MessageBox.Show("Discount Code Applied Successfuly...!\nCode : " + MTB_DiscountCode.Text, "Successeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MTB_DiscountCode.Enabled = false;
                _Discount = true;
                UpdateToTalePrice(_Size, _Toppings, _Count, true);
                _Sdiscount_value = "-10%";
            }
            else
            {
                Discount_Message.Visible = true;
                MessageBox.Show("The Discount Code Is Not Valable !!!", "Not Found !");
                Discount_Message.ForeColor = System.Drawing.Color.Red;
                Discount_Message.Text = "The Discount Code Is Not Valable !!!";
                
            }
        }

        private void numericUpDown_Count_ValueChanged(object sender, EventArgs e)
        {
            _Count = Convert.ToInt32(numericUpDown_Count.Value);
            UpdateToTalePrice(_Size, _Toppings, _Count, _Discount);
            Display_Count.Text = _Count.ToString();
        }

        private void UpdateTopingslabel()
        {
            Display_Totale_Toppings.Text = Convert.ToString(_Toppings) + "$";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Export_Order.ExportBillToTxtFile();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            _SToppings = Get_SToppings();
            Export_Order.ExportBillToTxtFile();

        }

        private bool Check_Order_Ability()
        {
            if (
                string.IsNullOrEmpty(_SPizza_size) || 
                string.IsNullOrEmpty(_SCrustType) ||
                string.IsNullOrEmpty(_SWhere_To_eat)
                //string.IsNullOrEmpty(_SToppings) ||  (Not Nesseeery !)
                //string.IsNullOrEmpty(_Scount) ||
                //string.IsNullOrEmpty() ||
            )
            {
                MessageBox.Show("Please Go Fill The Nessassry Pizza Informations", "Error");
                return false;
            }
            else
            {
                return true;
            }
        }
    }


    internal class Export_Order : Form1
    {

        public static void OpenBillFile(string bill_path)
        {
            try
            {
                Process.Start("notepad.exe", bill_path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private static void CreatFile() // Creat a Empty txt File for The Bill
        {
            string Folderpath;
            Folderpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Dont Forget To Specialize the path with the programme file path

            // this code is just for testing while Debugging : 
            // Folderpath = @"C:\Users\mdelh\OneDrive\Desktop";
            //================================================

            Folderpath = Path.Combine(Folderpath, "Bills");

            Random rand = new Random();
            string Bill_NO = rand.Next().ToString();
            string filename = "Bill_" + Bill_NO + ".txt";
            Folderpath = Path.Combine(Folderpath, filename);

            try
            {
                using (StreamWriter fs = new StreamWriter(Folderpath))
                {
                    fs.WriteLine("         Bill NO : {0}", Bill_NO);
                    fs.WriteLine("=============================================");
                    fs.WriteLine("* Pizza Information`s : ");
                    fs.WriteLine("      Pizza Size : {0}", _SPizza_size);
                    fs.WriteLine("      Pizza Crust Type : {0}", _SCrustType);
                    fs.WriteLine("      Pizza Toppings : {0}", _SToppings);
                    fs.WriteLine("      Eat-IN / Take away : {0}", _SWhere_To_eat);
                    fs.WriteLine("* Price : ");
                    fs.WriteLine("      Pizza Total Price : {0}$", _SFinalPrice);
                    fs.WriteLine("=============================================");
                    if (Form1._IsForShipping())
                    {
                        fs.WriteLine("* Shipping info : ");
                        fs.WriteLine("      First Name    : {0}", ShippingForm.FirstName);
                        fs.WriteLine("      Last name     : {0}", ShippingForm.LastName);
                        fs.WriteLine("      Phone Number  : {0}", ShippingForm.Phone);
                        fs.WriteLine("      Address        : {0}", ShippingForm.Adress);
                        fs.WriteLine("      Notes         : {0}", ShippingForm.Notes);
                        fs.WriteLine("=============================================");
                    }


                }

                OpenBillFile(Folderpath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void ExportBillToTxtFile()
        {
            CreatFile();
        }

        
    }
}
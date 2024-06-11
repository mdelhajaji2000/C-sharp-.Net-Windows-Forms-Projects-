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

namespace PizzaDelivery
{
    public partial class Form1 : Form
    {

        private Label[] labels;
        private int count = 0;
        private int max_labels = 6;
        private double _ToppingAdded = 0;
        private double _Price = 0d;
        private int ToppingsAddedCounter = 0;
        private double SizeCount = 0d;

        int button = 1;

        public Form1()
        {
            InitializeComponent();
            Buttons_Array();
        }

        private void Buttons_Array()
        {
            labels = new Label[max_labels];
            Console.Write("label {0} : created", (max_labels - 1));
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
            SizeCount = 3d;
            Dispaly_TOTAle_Price.Text = Convert.ToString(_Price + SizeCount) + "$";

        }

        private void BT_Pizza_Meduim_CheckedChanged(object sender, EventArgs e)
        {
            Display_Size.Text = "Medium";
            SizeCount = 5.5d;
            Dispaly_TOTAle_Price.Text = Convert.ToString(_Price + SizeCount) + "$";
        }

        private void BT_Size_Larg_CheckedChanged(object sender, EventArgs e)
        {
            Display_Size.Text = "Large";
            SizeCount = 7d;
            Dispaly_TOTAle_Price.Text = Convert.ToString(_Price + SizeCount) + "$";

        }

        private void Crust_Thin_CheckedChanged(object sender, EventArgs e)
        {
            Display_CrustType.Text = "Thin";
        }

        private void Crust_Think_CheckedChanged(object sender, EventArgs e)
        {
            Display_CrustType.Text = "Think";
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
        }

        private void BT_ExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            if (BT_ExtraChees.Checked)
            {
                _Price += 0.5d;
                _ToppingAdded += 0.5d;
                AddLabel("Extra Cheese - 0.50$");
                Update_AddedPrice();
            }
            else
            {
                _Price -= 0.5d;
                _ToppingAdded -= 0.5d;
                Update_AddedPrice();
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
                _Price += 1;
                _ToppingAdded += 1;
                AddLabel("Mushrooms - 1.00$");
                Update_AddedPrice();
            }
            else
            {
                _Price -= 1;
                _ToppingAdded -= 1;
                Update_AddedPrice();
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
                _Price += 0.25d;
                _ToppingAdded += 0.25d;
                AddLabel("Tomatoes - 0.25$");
                Update_AddedPrice();
            }
            else
            {
                _Price -= 0.25d;
                _ToppingAdded -= 0.25d;
                Update_AddedPrice();
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
            AddedPriceLable.Text = Convert.ToString(_ToppingAdded) + "$";
            Dispaly_TOTAle_Price.Text = Convert.ToString(_Price) + "$";
        }

        private void BT_Union_CheckedChanged(object sender, EventArgs e)
        {
            if (BT_Union.Checked)
            {
                _Price += 0.25d;
                _ToppingAdded += 0.25d;
                AddLabel("Union - 0.25$");
                Update_AddedPrice();
            }
            else
            {
                _Price -= 0.25d;
                _ToppingAdded -= 0.25d;
                Update_AddedPrice();
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
                //_ToppingAdded += 0.25d;
                AddLabel("Olives - FREE");
                Update_AddedPrice();
            }
            else
            {
                //_Price -= 0.25d;
                //_ToppingAdded -= 0.25d;
                Update_AddedPrice();
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
                _Price += 0.5d;
                _ToppingAdded += 0.5d;
                AddLabel("Green_Papper - 0.5$");
                Update_AddedPrice();
            }
            else
            {
                _Price -= 0.5d;
                _ToppingAdded -= 0.5d;
                Update_AddedPrice();
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
            BT_Size_Small.Checked = false;
            BT_Pizza_Meduim.Checked = false;
            BT_Size_Larg.Checked = false;

            Display_Size.Text = "";
            DIsplay_Where_TO_Eat.Text = "";
            Display_CrustType.Text = "";
            Dispaly_TOTAle_Price.Text = "0.00$";
            AddedPriceLable.Text = "0.00$";
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
            
        }

        private void TB_Order_Click(object sender, EventArgs e)
        {
            Shipping ShippingForm = new Shipping();
            ShippingForm.ShowDialog();
        }
    }
}
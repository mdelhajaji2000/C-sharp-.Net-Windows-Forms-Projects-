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

namespace PizzaDelivery
{
    public partial class Shipping : Form
    {
        public Shipping()
        {
            InitializeComponent();
        }


        public string FirstName = "";
        public string LastName = "";
        public string Adress = "";
        public string Notes = "";
        public string Phone = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Order Taked Successfuly", "Order info : ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Export_Order.ExportBillToTxtFile();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Required..!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox2, "");
                FirstName = textBox2.Text;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Required..!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
                LastName = textBox1.Text;
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Required..!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox3, "");
                Phone = textBox3.Text;
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                e.Cancel = true;
                textBox4.Focus();
                errorProvider1.SetError(textBox4, "Required..!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox4, "");
                Adress = textBox4.Text;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Notes = textBox5.Text;
        }
    }
}

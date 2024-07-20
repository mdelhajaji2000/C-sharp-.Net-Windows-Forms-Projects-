namespace TaskFlow
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Main_panel = new System.Windows.Forms.Panel();
            this.dateTimePicker_Expire = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Starting = new System.Windows.Forms.DateTimePicker();
            this.Task_Details_Text_Box = new System.Windows.Forms.TextBox();
            this.Task_Title_Text_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Return_BT = new System.Windows.Forms.Button();
            this.Creat_New_Task_BT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Main_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_panel
            // 
            this.Main_panel.Controls.Add(this.dateTimePicker_Expire);
            this.Main_panel.Controls.Add(this.dateTimePicker_Starting);
            this.Main_panel.Controls.Add(this.Task_Details_Text_Box);
            this.Main_panel.Controls.Add(this.Task_Title_Text_Box);
            this.Main_panel.Controls.Add(this.label5);
            this.Main_panel.Controls.Add(this.label2);
            this.Main_panel.Controls.Add(this.label1);
            this.Main_panel.Controls.Add(this.label4);
            this.Main_panel.Controls.Add(this.panel2);
            this.Main_panel.Controls.Add(this.panel1);
            resources.ApplyResources(this.Main_panel, "Main_panel");
            this.Main_panel.Name = "Main_panel";
            // 
            // dateTimePicker_Expire
            // 
            resources.ApplyResources(this.dateTimePicker_Expire, "dateTimePicker_Expire");
            this.dateTimePicker_Expire.Name = "dateTimePicker_Expire";
            this.dateTimePicker_Expire.ValueChanged += new System.EventHandler(this.dateTimePicker_Expire_ValueChanged);
            // 
            // dateTimePicker_Starting
            // 
            resources.ApplyResources(this.dateTimePicker_Starting, "dateTimePicker_Starting");
            this.dateTimePicker_Starting.Name = "dateTimePicker_Starting";
            this.dateTimePicker_Starting.ValueChanged += new System.EventHandler(this.dateTimePicker_Starting_ValueChanged);
            // 
            // Task_Details_Text_Box
            // 
            this.Task_Details_Text_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Task_Details_Text_Box, "Task_Details_Text_Box");
            this.Task_Details_Text_Box.Name = "Task_Details_Text_Box";
            this.Task_Details_Text_Box.TextChanged += new System.EventHandler(this.Task_Details_Text_Box_TextChanged);
            this.Task_Details_Text_Box.Validating += new System.ComponentModel.CancelEventHandler(this.Task_Details_Text_Box_Validating);
            // 
            // Task_Title_Text_Box
            // 
            this.Task_Title_Text_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Task_Title_Text_Box, "Task_Title_Text_Box");
            this.Task_Title_Text_Box.Name = "Task_Title_Text_Box";
            this.Task_Title_Text_Box.TextChanged += new System.EventHandler(this.Task_Title_Text_Box_TextChanged);
            this.Task_Title_Text_Box.Validating += new System.ComponentModel.CancelEventHandler(this.Task_Title_Text_Box_Validating);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Name = "label5";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Name = "label4";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.Return_BT);
            this.panel2.Controls.Add(this.Creat_New_Task_BT);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // Return_BT
            // 
            resources.ApplyResources(this.Return_BT, "Return_BT");
            this.Return_BT.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Return_BT.Name = "Return_BT";
            this.Return_BT.UseVisualStyleBackColor = true;
            this.Return_BT.Click += new System.EventHandler(this.Return_BT_Click);
            // 
            // Creat_New_Task_BT
            // 
            resources.ApplyResources(this.Creat_New_Task_BT, "Creat_New_Task_BT");
            this.Creat_New_Task_BT.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Creat_New_Task_BT.Name = "Creat_New_Task_BT";
            this.Creat_New_Task_BT.UseVisualStyleBackColor = true;
            this.Creat_New_Task_BT.Click += new System.EventHandler(this.Creat_New_Task_BT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TaskFlow.Properties.Resources._004_task;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Main_panel);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Main_panel.ResumeLayout(false);
            this.Main_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Task_Details_Text_Box;
        private System.Windows.Forms.TextBox Task_Title_Text_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Expire;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Starting;
        private System.Windows.Forms.Button Return_BT;
        private System.Windows.Forms.Button Creat_New_Task_BT;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
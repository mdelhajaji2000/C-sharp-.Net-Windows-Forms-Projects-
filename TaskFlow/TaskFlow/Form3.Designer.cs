namespace TaskFlow
{
    partial class Form3
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
            this.Main_panel = new System.Windows.Forms.Panel();
            this.dateTimePicker_Expire = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Starting = new System.Windows.Forms.DateTimePicker();
            this.Task_Details_Text_box = new System.Windows.Forms.TextBox();
            this.Task_Title_Text_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Return_BT = new System.Windows.Forms.Button();
            this.Edit_Task_BT = new System.Windows.Forms.Button();
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
            this.Main_panel.Controls.Add(this.Task_Details_Text_box);
            this.Main_panel.Controls.Add(this.Task_Title_Text_Box);
            this.Main_panel.Controls.Add(this.label5);
            this.Main_panel.Controls.Add(this.label2);
            this.Main_panel.Controls.Add(this.label1);
            this.Main_panel.Controls.Add(this.label4);
            this.Main_panel.Controls.Add(this.panel2);
            this.Main_panel.Controls.Add(this.panel1);
            this.Main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_panel.Location = new System.Drawing.Point(0, 0);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(672, 655);
            this.Main_panel.TabIndex = 1;
            // 
            // dateTimePicker_Expire
            // 
            this.dateTimePicker_Expire.Location = new System.Drawing.Point(279, 401);
            this.dateTimePicker_Expire.Name = "dateTimePicker_Expire";
            this.dateTimePicker_Expire.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker_Expire.TabIndex = 16;
            this.dateTimePicker_Expire.ValueChanged += new System.EventHandler(this.dateTimePicker_Expire_ValueChanged);
            // 
            // dateTimePicker_Starting
            // 
            this.dateTimePicker_Starting.Location = new System.Drawing.Point(279, 356);
            this.dateTimePicker_Starting.Name = "dateTimePicker_Starting";
            this.dateTimePicker_Starting.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker_Starting.TabIndex = 15;
            this.dateTimePicker_Starting.ValueChanged += new System.EventHandler(this.dateTimePicker_Starting_ValueChanged);
            // 
            // Task_Details_Text_box
            // 
            this.Task_Details_Text_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Task_Details_Text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.Task_Details_Text_box.Location = new System.Drawing.Point(264, 188);
            this.Task_Details_Text_box.Multiline = true;
            this.Task_Details_Text_box.Name = "Task_Details_Text_box";
            this.Task_Details_Text_box.Size = new System.Drawing.Size(351, 149);
            this.Task_Details_Text_box.TabIndex = 14;
            this.Task_Details_Text_box.TextChanged += new System.EventHandler(this.Task_Details_Text_box_TextChanged);
            // 
            // Task_Title_Text_Box
            // 
            this.Task_Title_Text_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Task_Title_Text_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.Task_Title_Text_Box.Location = new System.Drawing.Point(264, 135);
            this.Task_Title_Text_Box.Name = "Task_Title_Text_Box";
            this.Task_Title_Text_Box.Size = new System.Drawing.Size(351, 47);
            this.Task_Title_Text_Box.TabIndex = 13;
            this.Task_Title_Text_Box.TextChanged += new System.EventHandler(this.Task_Title_Text_Box_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 45);
            this.label5.TabIndex = 12;
            this.label5.Text = "Expire Date    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "Starting Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(21, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Task Details :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(21, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 45);
            this.label4.TabIndex = 8;
            this.label4.Text = "Task Title     :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.Return_BT);
            this.panel2.Controls.Add(this.Edit_Task_BT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 555);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 100);
            this.panel2.TabIndex = 1;
            // 
            // Return_BT
            // 
            this.Return_BT.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.Return_BT.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Return_BT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Return_BT.Location = new System.Drawing.Point(511, 21);
            this.Return_BT.Name = "Return_BT";
            this.Return_BT.Size = new System.Drawing.Size(149, 67);
            this.Return_BT.TabIndex = 10;
            this.Return_BT.Text = "Return";
            this.Return_BT.UseVisualStyleBackColor = true;
            this.Return_BT.Click += new System.EventHandler(this.Return_BT_Click);
            // 
            // Edit_Task_BT
            // 
            this.Edit_Task_BT.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.Edit_Task_BT.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Edit_Task_BT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Edit_Task_BT.Location = new System.Drawing.Point(350, 21);
            this.Edit_Task_BT.Name = "Edit_Task_BT";
            this.Edit_Task_BT.Size = new System.Drawing.Size(149, 67);
            this.Edit_Task_BT.TabIndex = 9;
            this.Edit_Task_BT.Text = "Edit";
            this.Edit_Task_BT.UseVisualStyleBackColor = true;
            this.Edit_Task_BT.Click += new System.EventHandler(this.Edit_Task_BT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TaskFlow.Properties.Resources._004_task;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(29, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 45F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(134, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(516, 68);
            this.label6.TabIndex = 2;
            this.label6.Text = "Edit Task Properties\r\n";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 655);
            this.Controls.Add(this.Main_panel);
            this.Name = "Form3";
            this.Text = "Edit Task Properties";
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
        private System.Windows.Forms.DateTimePicker dateTimePicker_Expire;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Starting;
        private System.Windows.Forms.TextBox Task_Details_Text_box;
        private System.Windows.Forms.TextBox Task_Title_Text_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Return_BT;
        private System.Windows.Forms.Button Edit_Task_BT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
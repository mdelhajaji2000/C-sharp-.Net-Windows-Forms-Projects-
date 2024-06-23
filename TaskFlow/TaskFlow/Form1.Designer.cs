namespace TaskFlow
{
    partial class Form1
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
            this.Starting_Panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.main_header_label = new System.Windows.Forms.Label();
            this.Display_Date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Starting_Panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Starting_Panel
            // 
            this.Starting_Panel.BackColor = System.Drawing.Color.LightSlateGray;
            this.Starting_Panel.Controls.Add(this.button1);
            this.Starting_Panel.Controls.Add(this.dateTimePicker1);
            this.Starting_Panel.Controls.Add(this.Display_Date);
            this.Starting_Panel.Controls.Add(this.panel1);
            this.Starting_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Starting_Panel.Location = new System.Drawing.Point(0, 0);
            this.Starting_Panel.Name = "Starting_Panel";
            this.Starting_Panel.Size = new System.Drawing.Size(1321, 581);
            this.Starting_Panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.main_header_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 127);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TaskFlow.Properties.Resources.task;
            this.pictureBox1.Location = new System.Drawing.Point(254, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // main_header_label
            // 
            this.main_header_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.main_header_label.Font = new System.Drawing.Font("Goudy Stout", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_header_label.ForeColor = System.Drawing.Color.Transparent;
            this.main_header_label.Location = new System.Drawing.Point(324, 22);
            this.main_header_label.Name = "main_header_label";
            this.main_header_label.Size = new System.Drawing.Size(705, 77);
            this.main_header_label.TabIndex = 0;
            this.main_header_label.Text = "Task Flow";
            this.main_header_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Display_Date
            // 
            this.Display_Date.AutoSize = true;
            this.Display_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display_Date.Location = new System.Drawing.Point(820, 246);
            this.Display_Date.Name = "Display_Date";
            this.Display_Date.Size = new System.Drawing.Size(51, 20);
            this.Display_Date.TabIndex = 6;
            this.Display_Date.Text = "label1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(242, 240);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 581);
            this.Controls.Add(this.Starting_Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Starting_Panel.ResumeLayout(false);
            this.Starting_Panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Starting_Panel;
        private System.Windows.Forms.Label main_header_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Display_Date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}


namespace RCP_Game
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
            this.Title_Panel = new System.Windows.Forms.Panel();
            this.Game_ICon = new System.Windows.Forms.PictureBox();
            this.Version_Label = new System.Windows.Forms.Label();
            this.SubTitle_Label = new System.Windows.Forms.Label();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Main_Menu_Panel = new System.Windows.Forms.Panel();
            this.GameModeButton_1VS1 = new System.Windows.Forms.Button();
            this.GameModeButton_VC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VSComputer_Panel = new System.Windows.Forms.Panel();
            this.Return_Button = new System.Windows.Forms.Button();
            this.Result_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.start_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Scissors_Choice_Button = new System.Windows.Forms.Button();
            this.Paper_Choice_Button = new System.Windows.Forms.Button();
            this.Rock_Choice_button = new System.Windows.Forms.Button();
            this.Computer_Choice_Label = new System.Windows.Forms.Label();
            this.UserChoice_Label = new System.Windows.Forms.Label();
            this.Computer_Choice_PB = new System.Windows.Forms.PictureBox();
            this.User_Choice_PB = new System.Windows.Forms.PictureBox();
            this.PlayerVSPlayer_Panel = new System.Windows.Forms.Panel();
            this.P2_Hide_Choise = new System.Windows.Forms.Button();
            this.P1_Hide_Choice = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.P2_Scissors_Button_Choice = new System.Windows.Forms.Button();
            this.P2_Paper_Button_Choice = new System.Windows.Forms.Button();
            this.P2_Rock_Player_Button_Choice = new System.Windows.Forms.Button();
            this.Return_Button_2 = new System.Windows.Forms.Button();
            this.PlayerVSPlayer_Result_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.P1_Scissors_Button_Choice = new System.Windows.Forms.Button();
            this.P1_Paper_Button_Choice = new System.Windows.Forms.Button();
            this.P1_Rock_Button_Choice = new System.Windows.Forms.Button();
            this.player_2_Choice_label = new System.Windows.Forms.Label();
            this.player_1_Choice_Label = new System.Windows.Forms.Label();
            this.player2_PB = new System.Windows.Forms.PictureBox();
            this.player_1_PB = new System.Windows.Forms.PictureBox();
            this.Title_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Game_ICon)).BeginInit();
            this.Main_Menu_Panel.SuspendLayout();
            this.VSComputer_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Computer_Choice_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Choice_PB)).BeginInit();
            this.PlayerVSPlayer_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_1_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_Panel
            // 
            this.Title_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Title_Panel.Controls.Add(this.Game_ICon);
            this.Title_Panel.Controls.Add(this.Version_Label);
            this.Title_Panel.Controls.Add(this.SubTitle_Label);
            this.Title_Panel.Controls.Add(this.Title_Label);
            this.Title_Panel.Font = new System.Drawing.Font("Cooper Black", 44F);
            this.Title_Panel.Location = new System.Drawing.Point(12, 3);
            this.Title_Panel.Name = "Title_Panel";
            this.Title_Panel.Size = new System.Drawing.Size(840, 101);
            this.Title_Panel.TabIndex = 0;
            // 
            // Game_ICon
            // 
            this.Game_ICon.Image = global::RCP_Game.Properties.Resources.rock_paper_scissors;
            this.Game_ICon.Location = new System.Drawing.Point(191, 3);
            this.Game_ICon.Name = "Game_ICon";
            this.Game_ICon.Size = new System.Drawing.Size(113, 86);
            this.Game_ICon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Game_ICon.TabIndex = 3;
            this.Game_ICon.TabStop = false;
            // 
            // Version_Label
            // 
            this.Version_Label.AutoSize = true;
            this.Version_Label.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version_Label.Location = new System.Drawing.Point(701, 77);
            this.Version_Label.Name = "Version_Label";
            this.Version_Label.Size = new System.Drawing.Size(87, 14);
            this.Version_Label.TabIndex = 2;
            this.Version_Label.Text = "V1.0.0 Beta";
            // 
            // SubTitle_Label
            // 
            this.SubTitle_Label.AutoSize = true;
            this.SubTitle_Label.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTitle_Label.Location = new System.Drawing.Point(307, 77);
            this.SubTitle_Label.Name = "SubTitle_Label";
            this.SubTitle_Label.Size = new System.Drawing.Size(170, 14);
            this.SubTitle_Label.TabIndex = 1;
            this.SubTitle_Label.Text = "Rocket-Paper-Scissors";
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.Location = new System.Drawing.Point(310, 9);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(153, 68);
            this.Title_Label.TabIndex = 0;
            this.Title_Label.Text = "RPS";
            // 
            // Main_Menu_Panel
            // 
            this.Main_Menu_Panel.BackColor = System.Drawing.Color.SkyBlue;
            this.Main_Menu_Panel.Controls.Add(this.Title_Panel);
            this.Main_Menu_Panel.Controls.Add(this.GameModeButton_1VS1);
            this.Main_Menu_Panel.Controls.Add(this.GameModeButton_VC);
            this.Main_Menu_Panel.Controls.Add(this.label1);
            this.Main_Menu_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Menu_Panel.Location = new System.Drawing.Point(0, 0);
            this.Main_Menu_Panel.Name = "Main_Menu_Panel";
            this.Main_Menu_Panel.Size = new System.Drawing.Size(860, 586);
            this.Main_Menu_Panel.TabIndex = 1;
            // 
            // GameModeButton_1VS1
            // 
            this.GameModeButton_1VS1.BackColor = System.Drawing.Color.LightBlue;
            this.GameModeButton_1VS1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GameModeButton_1VS1.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.GameModeButton_1VS1.Location = new System.Drawing.Point(236, 372);
            this.GameModeButton_1VS1.Margin = new System.Windows.Forms.Padding(0);
            this.GameModeButton_1VS1.Name = "GameModeButton_1VS1";
            this.GameModeButton_1VS1.Size = new System.Drawing.Size(334, 62);
            this.GameModeButton_1VS1.TabIndex = 6;
            this.GameModeButton_1VS1.Text = "1 VS 1";
            this.GameModeButton_1VS1.UseVisualStyleBackColor = false;
            this.GameModeButton_1VS1.Click += new System.EventHandler(this.GameModeButton_1VS1_Click);
            // 
            // GameModeButton_VC
            // 
            this.GameModeButton_VC.BackColor = System.Drawing.Color.LightBlue;
            this.GameModeButton_VC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GameModeButton_VC.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.GameModeButton_VC.Location = new System.Drawing.Point(236, 287);
            this.GameModeButton_VC.Margin = new System.Windows.Forms.Padding(0);
            this.GameModeButton_VC.Name = "GameModeButton_VC";
            this.GameModeButton_VC.Size = new System.Drawing.Size(334, 62);
            this.GameModeButton_VC.TabIndex = 5;
            this.GameModeButton_VC.Text = "VS Computer";
            this.GameModeButton_VC.UseVisualStyleBackColor = false;
            this.GameModeButton_VC.Click += new System.EventHandler(this.GameModeButton_VC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 44F);
            this.label1.Location = new System.Drawing.Point(124, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 68);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Game Mode : ";
            // 
            // VSComputer_Panel
            // 
            this.VSComputer_Panel.BackColor = System.Drawing.Color.SkyBlue;
            this.VSComputer_Panel.Controls.Add(this.Return_Button);
            this.VSComputer_Panel.Controls.Add(this.Result_Label);
            this.VSComputer_Panel.Controls.Add(this.label5);
            this.VSComputer_Panel.Controls.Add(this.start_Button);
            this.VSComputer_Panel.Controls.Add(this.label4);
            this.VSComputer_Panel.Controls.Add(this.Scissors_Choice_Button);
            this.VSComputer_Panel.Controls.Add(this.Paper_Choice_Button);
            this.VSComputer_Panel.Controls.Add(this.Rock_Choice_button);
            this.VSComputer_Panel.Controls.Add(this.Computer_Choice_Label);
            this.VSComputer_Panel.Controls.Add(this.UserChoice_Label);
            this.VSComputer_Panel.Controls.Add(this.Computer_Choice_PB);
            this.VSComputer_Panel.Controls.Add(this.User_Choice_PB);
            this.VSComputer_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSComputer_Panel.Location = new System.Drawing.Point(0, 0);
            this.VSComputer_Panel.Name = "VSComputer_Panel";
            this.VSComputer_Panel.Size = new System.Drawing.Size(860, 586);
            this.VSComputer_Panel.TabIndex = 7;
            // 
            // Return_Button
            // 
            this.Return_Button.BackgroundImage = global::RCP_Game.Properties.Resources.turn_back;
            this.Return_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Return_Button.Location = new System.Drawing.Point(780, 12);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(68, 62);
            this.Return_Button.TabIndex = 8;
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // Result_Label
            // 
            this.Result_Label.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Result_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Result_Label.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_Label.ForeColor = System.Drawing.Color.Lime;
            this.Result_Label.Location = new System.Drawing.Point(699, 533);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(110, 27);
            this.Result_Label.TabIndex = 7;
            this.Result_Label.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(603, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Result : ";
            // 
            // start_Button
            // 
            this.start_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.start_Button.Location = new System.Drawing.Point(402, 241);
            this.start_Button.Name = "start_Button";
            this.start_Button.Size = new System.Drawing.Size(75, 54);
            this.start_Button.TabIndex = 6;
            this.start_Button.Text = "Confirme";
            this.start_Button.UseVisualStyleBackColor = false;
            this.start_Button.Click += new System.EventHandler(this.start_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select your choice : ";
            // 
            // Scissors_Choice_Button
            // 
            this.Scissors_Choice_Button.BackgroundImage = global::RCP_Game.Properties.Resources._003_scissors;
            this.Scissors_Choice_Button.Location = new System.Drawing.Point(292, 454);
            this.Scissors_Choice_Button.Name = "Scissors_Choice_Button";
            this.Scissors_Choice_Button.Size = new System.Drawing.Size(67, 68);
            this.Scissors_Choice_Button.TabIndex = 4;
            this.Scissors_Choice_Button.UseVisualStyleBackColor = true;
            this.Scissors_Choice_Button.Click += new System.EventHandler(this.Scissors_Choice_Button_Click);
            // 
            // Paper_Choice_Button
            // 
            this.Paper_Choice_Button.BackgroundImage = global::RCP_Game.Properties.Resources._002_five;
            this.Paper_Choice_Button.Location = new System.Drawing.Point(191, 454);
            this.Paper_Choice_Button.Name = "Paper_Choice_Button";
            this.Paper_Choice_Button.Size = new System.Drawing.Size(67, 68);
            this.Paper_Choice_Button.TabIndex = 4;
            this.Paper_Choice_Button.UseVisualStyleBackColor = true;
            this.Paper_Choice_Button.Click += new System.EventHandler(this.Paper_Choice_Button_Click);
            // 
            // Rock_Choice_button
            // 
            this.Rock_Choice_button.BackgroundImage = global::RCP_Game.Properties.Resources._004_fist;
            this.Rock_Choice_button.Location = new System.Drawing.Point(98, 454);
            this.Rock_Choice_button.Name = "Rock_Choice_button";
            this.Rock_Choice_button.Size = new System.Drawing.Size(67, 68);
            this.Rock_Choice_button.TabIndex = 4;
            this.Rock_Choice_button.UseVisualStyleBackColor = true;
            this.Rock_Choice_button.Click += new System.EventHandler(this.Rock_Choice_button_Click);
            // 
            // Computer_Choice_Label
            // 
            this.Computer_Choice_Label.Font = new System.Drawing.Font("Cooper Black", 30F);
            this.Computer_Choice_Label.ForeColor = System.Drawing.Color.Red;
            this.Computer_Choice_Label.Location = new System.Drawing.Point(450, 77);
            this.Computer_Choice_Label.Name = "Computer_Choice_Label";
            this.Computer_Choice_Label.Size = new System.Drawing.Size(373, 46);
            this.Computer_Choice_Label.TabIndex = 3;
            this.Computer_Choice_Label.Text = "Computer Choice";
            this.Computer_Choice_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserChoice_Label
            // 
            this.UserChoice_Label.Font = new System.Drawing.Font("Cooper Black", 30F);
            this.UserChoice_Label.ForeColor = System.Drawing.Color.Red;
            this.UserChoice_Label.Location = new System.Drawing.Point(90, 77);
            this.UserChoice_Label.Name = "UserChoice_Label";
            this.UserChoice_Label.Size = new System.Drawing.Size(269, 46);
            this.UserChoice_Label.TabIndex = 2;
            this.UserChoice_Label.Text = "Your Choice";
            this.UserChoice_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Computer_Choice_PB
            // 
            this.Computer_Choice_PB.Image = global::RCP_Game.Properties.Resources.rock_paper_scissors;
            this.Computer_Choice_PB.Location = new System.Drawing.Point(509, 147);
            this.Computer_Choice_PB.Name = "Computer_Choice_PB";
            this.Computer_Choice_PB.Size = new System.Drawing.Size(261, 267);
            this.Computer_Choice_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Computer_Choice_PB.TabIndex = 1;
            this.Computer_Choice_PB.TabStop = false;
            // 
            // User_Choice_PB
            // 
            this.User_Choice_PB.Image = global::RCP_Game.Properties.Resources.rock_paper_scissors;
            this.User_Choice_PB.Location = new System.Drawing.Point(98, 147);
            this.User_Choice_PB.Name = "User_Choice_PB";
            this.User_Choice_PB.Size = new System.Drawing.Size(261, 267);
            this.User_Choice_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.User_Choice_PB.TabIndex = 0;
            this.User_Choice_PB.TabStop = false;
            // 
            // PlayerVSPlayer_Panel
            // 
            this.PlayerVSPlayer_Panel.BackColor = System.Drawing.Color.SkyBlue;
            this.PlayerVSPlayer_Panel.Controls.Add(this.P2_Hide_Choise);
            this.PlayerVSPlayer_Panel.Controls.Add(this.P1_Hide_Choice);
            this.PlayerVSPlayer_Panel.Controls.Add(this.label11);
            this.PlayerVSPlayer_Panel.Controls.Add(this.P2_Scissors_Button_Choice);
            this.PlayerVSPlayer_Panel.Controls.Add(this.P2_Paper_Button_Choice);
            this.PlayerVSPlayer_Panel.Controls.Add(this.P2_Rock_Player_Button_Choice);
            this.PlayerVSPlayer_Panel.Controls.Add(this.Return_Button_2);
            this.PlayerVSPlayer_Panel.Controls.Add(this.PlayerVSPlayer_Result_label);
            this.PlayerVSPlayer_Panel.Controls.Add(this.label7);
            this.PlayerVSPlayer_Panel.Controls.Add(this.button2);
            this.PlayerVSPlayer_Panel.Controls.Add(this.label8);
            this.PlayerVSPlayer_Panel.Controls.Add(this.P1_Scissors_Button_Choice);
            this.PlayerVSPlayer_Panel.Controls.Add(this.P1_Paper_Button_Choice);
            this.PlayerVSPlayer_Panel.Controls.Add(this.P1_Rock_Button_Choice);
            this.PlayerVSPlayer_Panel.Controls.Add(this.player_2_Choice_label);
            this.PlayerVSPlayer_Panel.Controls.Add(this.player_1_Choice_Label);
            this.PlayerVSPlayer_Panel.Controls.Add(this.player2_PB);
            this.PlayerVSPlayer_Panel.Controls.Add(this.player_1_PB);
            this.PlayerVSPlayer_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayerVSPlayer_Panel.Location = new System.Drawing.Point(0, 0);
            this.PlayerVSPlayer_Panel.Name = "PlayerVSPlayer_Panel";
            this.PlayerVSPlayer_Panel.Size = new System.Drawing.Size(860, 586);
            this.PlayerVSPlayer_Panel.TabIndex = 8;
            // 
            // P2_Hide_Choise
            // 
            this.P2_Hide_Choise.Location = new System.Drawing.Point(553, 551);
            this.P2_Hide_Choise.Name = "P2_Hide_Choise";
            this.P2_Hide_Choise.Size = new System.Drawing.Size(140, 23);
            this.P2_Hide_Choise.TabIndex = 26;
            this.P2_Hide_Choise.Text = "Hide_Your_Choice";
            this.P2_Hide_Choise.UseVisualStyleBackColor = true;
            this.P2_Hide_Choise.Click += new System.EventHandler(this.P2_Hide_Choise_Click);
            // 
            // P1_Hide_Choice
            // 
            this.P1_Hide_Choice.Location = new System.Drawing.Point(118, 551);
            this.P1_Hide_Choice.Name = "P1_Hide_Choice";
            this.P1_Hide_Choice.Size = new System.Drawing.Size(140, 23);
            this.P1_Hide_Choice.TabIndex = 25;
            this.P1_Hide_Choice.Text = "Hide_Your_Choice";
            this.P1_Hide_Choice.UseVisualStyleBackColor = true;
            this.P1_Hide_Choice.Click += new System.EventHandler(this.P1_Hide_Choice_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(567, 427);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Select your choice : ";
            // 
            // P2_Scissors_Button_Choice
            // 
            this.P2_Scissors_Button_Choice.BackgroundImage = global::RCP_Game.Properties.Resources._003_scissors;
            this.P2_Scissors_Button_Choice.Location = new System.Drawing.Point(692, 454);
            this.P2_Scissors_Button_Choice.Name = "P2_Scissors_Button_Choice";
            this.P2_Scissors_Button_Choice.Size = new System.Drawing.Size(67, 68);
            this.P2_Scissors_Button_Choice.TabIndex = 21;
            this.P2_Scissors_Button_Choice.UseVisualStyleBackColor = true;
            this.P2_Scissors_Button_Choice.Click += new System.EventHandler(this.P2_Scissors_Button_Choice_Click);
            // 
            // P2_Paper_Button_Choice
            // 
            this.P2_Paper_Button_Choice.BackgroundImage = global::RCP_Game.Properties.Resources._002_five;
            this.P2_Paper_Button_Choice.Location = new System.Drawing.Point(591, 454);
            this.P2_Paper_Button_Choice.Name = "P2_Paper_Button_Choice";
            this.P2_Paper_Button_Choice.Size = new System.Drawing.Size(67, 68);
            this.P2_Paper_Button_Choice.TabIndex = 22;
            this.P2_Paper_Button_Choice.UseVisualStyleBackColor = true;
            this.P2_Paper_Button_Choice.Click += new System.EventHandler(this.P2_Paper_Button_Choice_Click);
            // 
            // P2_Rock_Player_Button_Choice
            // 
            this.P2_Rock_Player_Button_Choice.BackgroundImage = global::RCP_Game.Properties.Resources._004_fist;
            this.P2_Rock_Player_Button_Choice.Location = new System.Drawing.Point(498, 454);
            this.P2_Rock_Player_Button_Choice.Name = "P2_Rock_Player_Button_Choice";
            this.P2_Rock_Player_Button_Choice.Size = new System.Drawing.Size(67, 68);
            this.P2_Rock_Player_Button_Choice.TabIndex = 23;
            this.P2_Rock_Player_Button_Choice.UseVisualStyleBackColor = true;
            this.P2_Rock_Player_Button_Choice.Click += new System.EventHandler(this.P2_Rock_Player_Button_Choice_Click);
            // 
            // Return_Button_2
            // 
            this.Return_Button_2.BackgroundImage = global::RCP_Game.Properties.Resources.turn_back;
            this.Return_Button_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Return_Button_2.Location = new System.Drawing.Point(741, 19);
            this.Return_Button_2.Name = "Return_Button_2";
            this.Return_Button_2.Size = new System.Drawing.Size(68, 62);
            this.Return_Button_2.TabIndex = 20;
            this.Return_Button_2.UseVisualStyleBackColor = true;
            this.Return_Button_2.Click += new System.EventHandler(this.Return_Button_2_Click);
            // 
            // PlayerVSPlayer_Result_label
            // 
            this.PlayerVSPlayer_Result_label.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PlayerVSPlayer_Result_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PlayerVSPlayer_Result_label.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerVSPlayer_Result_label.ForeColor = System.Drawing.Color.Lime;
            this.PlayerVSPlayer_Result_label.Location = new System.Drawing.Point(446, 29);
            this.PlayerVSPlayer_Result_label.Name = "PlayerVSPlayer_Result_label";
            this.PlayerVSPlayer_Result_label.Size = new System.Drawing.Size(100, 27);
            this.PlayerVSPlayer_Result_label.TabIndex = 18;
            this.PlayerVSPlayer_Result_label.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(350, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Result : ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Location = new System.Drawing.Point(374, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 54);
            this.button2.TabIndex = 17;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Select your choice : ";
            // 
            // P1_Scissors_Button_Choice
            // 
            this.P1_Scissors_Button_Choice.BackgroundImage = global::RCP_Game.Properties.Resources._003_scissors;
            this.P1_Scissors_Button_Choice.Location = new System.Drawing.Point(253, 461);
            this.P1_Scissors_Button_Choice.Name = "P1_Scissors_Button_Choice";
            this.P1_Scissors_Button_Choice.Size = new System.Drawing.Size(67, 68);
            this.P1_Scissors_Button_Choice.TabIndex = 13;
            this.P1_Scissors_Button_Choice.UseVisualStyleBackColor = true;
            this.P1_Scissors_Button_Choice.Click += new System.EventHandler(this.P1_Scissors_Button_Choice_Click);
            // 
            // P1_Paper_Button_Choice
            // 
            this.P1_Paper_Button_Choice.BackgroundImage = global::RCP_Game.Properties.Resources._002_five;
            this.P1_Paper_Button_Choice.Location = new System.Drawing.Point(152, 461);
            this.P1_Paper_Button_Choice.Name = "P1_Paper_Button_Choice";
            this.P1_Paper_Button_Choice.Size = new System.Drawing.Size(67, 68);
            this.P1_Paper_Button_Choice.TabIndex = 14;
            this.P1_Paper_Button_Choice.UseVisualStyleBackColor = true;
            this.P1_Paper_Button_Choice.Click += new System.EventHandler(this.P1_Paper_Button_Choice_Click);
            // 
            // P1_Rock_Button_Choice
            // 
            this.P1_Rock_Button_Choice.BackgroundImage = global::RCP_Game.Properties.Resources._004_fist;
            this.P1_Rock_Button_Choice.Location = new System.Drawing.Point(59, 461);
            this.P1_Rock_Button_Choice.Name = "P1_Rock_Button_Choice";
            this.P1_Rock_Button_Choice.Size = new System.Drawing.Size(67, 68);
            this.P1_Rock_Button_Choice.TabIndex = 15;
            this.P1_Rock_Button_Choice.UseVisualStyleBackColor = true;
            this.P1_Rock_Button_Choice.Click += new System.EventHandler(this.P1_Rock_Button_Choice_Click);
            // 
            // player_2_Choice_label
            // 
            this.player_2_Choice_label.AutoSize = true;
            this.player_2_Choice_label.Font = new System.Drawing.Font("Cooper Black", 30F);
            this.player_2_Choice_label.ForeColor = System.Drawing.Color.Red;
            this.player_2_Choice_label.Location = new System.Drawing.Point(450, 84);
            this.player_2_Choice_label.Name = "player_2_Choice_label";
            this.player_2_Choice_label.Size = new System.Drawing.Size(332, 46);
            this.player_2_Choice_label.TabIndex = 12;
            this.player_2_Choice_label.Text = "Player 2 Choice";
            // 
            // player_1_Choice_Label
            // 
            this.player_1_Choice_Label.AutoSize = true;
            this.player_1_Choice_Label.Font = new System.Drawing.Font("Cooper Black", 30F);
            this.player_1_Choice_Label.ForeColor = System.Drawing.Color.Red;
            this.player_1_Choice_Label.Location = new System.Drawing.Point(15, 84);
            this.player_1_Choice_Label.Name = "player_1_Choice_Label";
            this.player_1_Choice_Label.Size = new System.Drawing.Size(332, 46);
            this.player_1_Choice_Label.TabIndex = 11;
            this.player_1_Choice_Label.Text = "Player 1 Choice";
            // 
            // player2_PB
            // 
            this.player2_PB.Image = global::RCP_Game.Properties.Resources.rock_paper_scissors;
            this.player2_PB.Location = new System.Drawing.Point(496, 154);
            this.player2_PB.Name = "player2_PB";
            this.player2_PB.Size = new System.Drawing.Size(261, 267);
            this.player2_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player2_PB.TabIndex = 10;
            this.player2_PB.TabStop = false;
            // 
            // player_1_PB
            // 
            this.player_1_PB.Image = global::RCP_Game.Properties.Resources.rock_paper_scissors;
            this.player_1_PB.Location = new System.Drawing.Point(59, 154);
            this.player_1_PB.Name = "player_1_PB";
            this.player_1_PB.Size = new System.Drawing.Size(261, 267);
            this.player_1_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player_1_PB.TabIndex = 9;
            this.player_1_PB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 586);
            this.Controls.Add(this.PlayerVSPlayer_Panel);
            this.Controls.Add(this.VSComputer_Panel);
            this.Controls.Add(this.Main_Menu_Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Title_Panel.ResumeLayout(false);
            this.Title_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Game_ICon)).EndInit();
            this.Main_Menu_Panel.ResumeLayout(false);
            this.Main_Menu_Panel.PerformLayout();
            this.VSComputer_Panel.ResumeLayout(false);
            this.VSComputer_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Computer_Choice_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Choice_PB)).EndInit();
            this.PlayerVSPlayer_Panel.ResumeLayout(false);
            this.PlayerVSPlayer_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_1_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Title_Panel;
        private System.Windows.Forms.PictureBox Game_ICon;
        private System.Windows.Forms.Label Version_Label;
        private System.Windows.Forms.Label SubTitle_Label;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.Panel Main_Menu_Panel;
        private System.Windows.Forms.Button GameModeButton_VC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GameModeButton_1VS1;
        private System.Windows.Forms.Panel VSComputer_Panel;
        private System.Windows.Forms.Label UserChoice_Label;
        private System.Windows.Forms.PictureBox Computer_Choice_PB;
        private System.Windows.Forms.PictureBox User_Choice_PB;
        private System.Windows.Forms.Label Computer_Choice_Label;
        private System.Windows.Forms.Button Scissors_Choice_Button;
        private System.Windows.Forms.Button Paper_Choice_Button;
        private System.Windows.Forms.Button Rock_Choice_button;
        private System.Windows.Forms.Label Result_Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button start_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.Panel PlayerVSPlayer_Panel;
        private System.Windows.Forms.Button Return_Button_2;
        private System.Windows.Forms.Label PlayerVSPlayer_Result_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button P1_Scissors_Button_Choice;
        private System.Windows.Forms.Button P1_Paper_Button_Choice;
        private System.Windows.Forms.Button P1_Rock_Button_Choice;
        private System.Windows.Forms.Label player_2_Choice_label;
        private System.Windows.Forms.Label player_1_Choice_Label;
        private System.Windows.Forms.PictureBox player2_PB;
        private System.Windows.Forms.PictureBox player_1_PB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button P2_Scissors_Button_Choice;
        private System.Windows.Forms.Button P2_Paper_Button_Choice;
        private System.Windows.Forms.Button P2_Rock_Player_Button_Choice;
        private System.Windows.Forms.Button P2_Hide_Choise;
        private System.Windows.Forms.Button P1_Hide_Choice;
    }
}


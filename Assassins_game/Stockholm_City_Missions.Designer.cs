﻿namespace Assassins_game
{
    partial class Stockholm_City_Missions
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
            GoBackButton = new Button();
            MissionLoadButton = new Button();
            listViewMissions = new ListView();
            missionDescriptionTextBox = new TextBox();
            SendMissionButton = new Button();
            ListAssassinsForMissions = new ListView();
            listViewHistoryMission = new ListView();
            AddingMissions = new Button();
            RefreshAssassinsListViewButton = new Button();
            listViewUserMissions = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            HowToPlayTextBox = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // GoBackButton
            // 
            GoBackButton.Location = new Point(317, 314);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(94, 29);
            GoBackButton.TabIndex = 1;
            GoBackButton.Text = "Go Back";
            GoBackButton.UseVisualStyleBackColor = true;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // MissionLoadButton
            // 
            MissionLoadButton.Location = new Point(317, 120);
            MissionLoadButton.Name = "MissionLoadButton";
            MissionLoadButton.Size = new Size(94, 29);
            MissionLoadButton.TabIndex = 2;
            MissionLoadButton.Text = "Load";
            MissionLoadButton.UseVisualStyleBackColor = true;
            MissionLoadButton.Click += MissionLoadButton_Click;
            // 
            // listViewMissions
            // 
            listViewMissions.Location = new Point(463, 36);
            listViewMissions.Name = "listViewMissions";
            listViewMissions.Size = new Size(283, 176);
            listViewMissions.TabIndex = 3;
            listViewMissions.UseCompatibleStateImageBehavior = false;
            listViewMissions.View = View.List;
            listViewMissions.SelectedIndexChanged += listViewMissions_SelectedIndexChanged;
            // 
            // missionDescriptionTextBox
            // 
            missionDescriptionTextBox.Location = new Point(12, 245);
            missionDescriptionTextBox.Multiline = true;
            missionDescriptionTextBox.Name = "missionDescriptionTextBox";
            missionDescriptionTextBox.Size = new Size(276, 176);
            missionDescriptionTextBox.TabIndex = 4;
            missionDescriptionTextBox.TextChanged += missionDescriptionTextBox_TextChanged;
            // 
            // SendMissionButton
            // 
            SendMissionButton.Location = new Point(317, 279);
            SendMissionButton.Name = "SendMissionButton";
            SendMissionButton.Size = new Size(94, 29);
            SendMissionButton.TabIndex = 6;
            SendMissionButton.Text = "Send";
            SendMissionButton.UseVisualStyleBackColor = true;
            SendMissionButton.Click += SendButton_Click;
            // 
            // ListAssassinsForMissions
            // 
            ListAssassinsForMissions.Location = new Point(463, 456);
            ListAssassinsForMissions.Name = "ListAssassinsForMissions";
            ListAssassinsForMissions.Size = new Size(277, 136);
            ListAssassinsForMissions.TabIndex = 9;
            ListAssassinsForMissions.UseCompatibleStateImageBehavior = false;
            ListAssassinsForMissions.View = View.List;
            // 
            // listViewHistoryMission
            // 
            listViewHistoryMission.Location = new Point(12, 454);
            listViewHistoryMission.Name = "listViewHistoryMission";
            listViewHistoryMission.Size = new Size(276, 174);
            listViewHistoryMission.TabIndex = 5;
            listViewHistoryMission.UseCompatibleStateImageBehavior = false;
            listViewHistoryMission.View = View.List;
            // 
            // AddingMissions
            // 
            AddingMissions.Location = new Point(317, 216);
            AddingMissions.Name = "AddingMissions";
            AddingMissions.Size = new Size(94, 29);
            AddingMissions.TabIndex = 10;
            AddingMissions.Text = "Missions";
            AddingMissions.UseVisualStyleBackColor = true;
            AddingMissions.Click += AddingMissions_Click;
            // 
            // RefreshAssassinsListViewButton
            // 
            RefreshAssassinsListViewButton.Location = new Point(317, 155);
            RefreshAssassinsListViewButton.Name = "RefreshAssassinsListViewButton";
            RefreshAssassinsListViewButton.Size = new Size(94, 29);
            RefreshAssassinsListViewButton.TabIndex = 11;
            RefreshAssassinsListViewButton.Text = "Refresh";
            RefreshAssassinsListViewButton.UseVisualStyleBackColor = true;
            RefreshAssassinsListViewButton.Click += RefreshButton_Click;
            // 
            // listViewUserMissions
            // 
            listViewUserMissions.Location = new Point(463, 245);
            listViewUserMissions.Name = "listViewUserMissions";
            listViewUserMissions.Size = new Size(283, 174);
            listViewUserMissions.TabIndex = 12;
            listViewUserMissions.UseCompatibleStateImageBehavior = false;
            listViewUserMissions.View = View.List;
            listViewUserMissions.SelectedIndexChanged += ListViewUserMissions_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 218);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 13;
            label1.Text = "Missions Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(485, 9);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 13;
            label2.Text = "Assassin Missions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(485, 222);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 13;
            label3.Text = "User Missions";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 431);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 13;
            label4.Text = "Missions History";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(464, 433);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 13;
            label5.Text = "Assassins";
            // 
            // HowToPlayTextBox
            // 
            HowToPlayTextBox.Location = new Point(12, 36);
            HowToPlayTextBox.Multiline = true;
            HowToPlayTextBox.Name = "HowToPlayTextBox";
            HowToPlayTextBox.Size = new Size(277, 179);
            HowToPlayTextBox.TabIndex = 14;
            HowToPlayTextBox.TextChanged += HotToPlay_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 13;
            label6.Text = "How To Play:";
            // 
            // Stockholm_City_Missions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 1056);
            Controls.Add(HowToPlayTextBox);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(listViewUserMissions);
            Controls.Add(RefreshAssassinsListViewButton);
            Controls.Add(AddingMissions);
            Controls.Add(ListAssassinsForMissions);
            Controls.Add(SendMissionButton);
            Controls.Add(listViewHistoryMission);
            Controls.Add(missionDescriptionTextBox);
            Controls.Add(listViewMissions);
            Controls.Add(MissionLoadButton);
            Controls.Add(GoBackButton);
            Name = "Stockholm_City_Missions";
            Text = "Stockholm_City_Missions";
            Load += Stockholm_City_Missions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button GoBackButton;
        private Button MissionLoadButton;
        private ListView listViewMissions;
        private TextBox missionDescriptionTextBox;
        private Button SendMissionButton;
        private ListView ListAssassinsForMissions;
        private ListView listViewHistoryMission;
        private Button AddingMissions;
        private Button RefreshAssassinsListViewButton;
        private ListView listViewUserMissions;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox HowToPlayTextBox;
        private Label label6;
    }
}
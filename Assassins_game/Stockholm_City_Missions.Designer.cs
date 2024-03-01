namespace Assassins_game
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
            components = new System.ComponentModel.Container();
            GoBackButton = new Button();
            MissionLoadButton = new Button();
            listViewMissions = new ListView();
            missionDescriptionTextBox = new TextBox();
            listViewHistoryMission = new ListView();
            CountdownTimer = new System.Windows.Forms.Timer(components);
            SendMissionButton = new Button();
            remainingTimeLabel = new Label();
            ListAssassinsForMissions = new ListView();
            SuspendLayout();
            // 
            // GoBackButton
            // 
            GoBackButton.Location = new Point(346, 354);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(94, 29);
            GoBackButton.TabIndex = 1;
            GoBackButton.Text = "Go Back";
            GoBackButton.UseVisualStyleBackColor = true;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // MissionLoadButton
            // 
            MissionLoadButton.Location = new Point(346, 268);
            MissionLoadButton.Name = "MissionLoadButton";
            MissionLoadButton.Size = new Size(94, 29);
            MissionLoadButton.TabIndex = 2;
            MissionLoadButton.Text = "Load";
            MissionLoadButton.UseVisualStyleBackColor = true;
            MissionLoadButton.Click += MissionLoadButton_Click;
            // 
            // listViewMissions
            // 
            listViewMissions.Location = new Point(484, 36);
            listViewMissions.Name = "listViewMissions";
            listViewMissions.Size = new Size(242, 383);
            listViewMissions.TabIndex = 3;
            listViewMissions.UseCompatibleStateImageBehavior = false;
            listViewMissions.View = View.List;
            listViewMissions.SelectedIndexChanged += listViewMissions_SelectedIndexChanged;
            // 
            // missionDescriptionTextBox
            // 
            missionDescriptionTextBox.Location = new Point(46, 54);
            missionDescriptionTextBox.Multiline = true;
            missionDescriptionTextBox.Name = "missionDescriptionTextBox";
            missionDescriptionTextBox.Size = new Size(394, 176);
            missionDescriptionTextBox.TabIndex = 4;
            missionDescriptionTextBox.TextChanged += missionDescriptionTextBox_TextChanged;
            // 
            // listViewHistoryMission
            // 
            listViewHistoryMission.Location = new Point(46, 275);
            listViewHistoryMission.Name = "listViewHistoryMission";
            listViewHistoryMission.Size = new Size(270, 144);
            listViewHistoryMission.TabIndex = 5;
            listViewHistoryMission.UseCompatibleStateImageBehavior = false;
            listViewHistoryMission.View = View.List;
            // 
            // CountdownTimer
            // 
            CountdownTimer.Enabled = true;
            CountdownTimer.Tick += SendButton_Click;
            // 
            // SendMissionButton
            // 
            SendMissionButton.Location = new Point(346, 315);
            SendMissionButton.Name = "SendMissionButton";
            SendMissionButton.Size = new Size(94, 29);
            SendMissionButton.TabIndex = 6;
            SendMissionButton.Text = "Send";
            SendMissionButton.UseVisualStyleBackColor = true;
            SendMissionButton.Click += SendButton_Click;
            // 
            // remainingTimeLabel
            // 
            remainingTimeLabel.AutoSize = true;
            remainingTimeLabel.Location = new Point(87, 245);
            remainingTimeLabel.Name = "remainingTimeLabel";
            remainingTimeLabel.Size = new Size(63, 20);
            remainingTimeLabel.TabIndex = 7;
            remainingTimeLabel.Text = "00:00:00";
            // 
            // ListAssassinsForMissions
            // 
            ListAssassinsForMissions.Location = new Point(37, 439);
            ListAssassinsForMissions.Name = "ListAssassinsForMissions";
            ListAssassinsForMissions.Size = new Size(689, 143);
            ListAssassinsForMissions.TabIndex = 8;
            ListAssassinsForMissions.UseCompatibleStateImageBehavior = false;
            ListAssassinsForMissions.View = View.List;
            ListAssassinsForMissions.SelectedIndexChanged += PopulateListViewAssassins;
            // 
            // Stockholm_City_Missions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 1056);
            Controls.Add(ListAssassinsForMissions);
            Controls.Add(remainingTimeLabel);
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
        private ListView listViewHistoryMission;
        private System.Windows.Forms.Timer CountdownTimer;
        private Button SendMissionButton;
        private Label remainingTimeLabel;
        private ListView ListAssassinsForMissions;
    }
}
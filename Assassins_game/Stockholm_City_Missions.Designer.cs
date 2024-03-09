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
            SuspendLayout();
            // 
            // GoBackButton
            // 
            GoBackButton.Location = new Point(241, 602);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(94, 29);
            GoBackButton.TabIndex = 1;
            GoBackButton.Text = "Go Back";
            GoBackButton.UseVisualStyleBackColor = true;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // MissionLoadButton
            // 
            MissionLoadButton.Location = new Point(41, 602);
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
            listViewMissions.Size = new Size(283, 176);
            listViewMissions.TabIndex = 3;
            listViewMissions.UseCompatibleStateImageBehavior = false;
            listViewMissions.View = View.List;
            listViewMissions.SelectedIndexChanged += listViewMissions_SelectedIndexChanged;
            // 
            // missionDescriptionTextBox
            // 
            missionDescriptionTextBox.Location = new Point(12, 36);
            missionDescriptionTextBox.Multiline = true;
            missionDescriptionTextBox.Name = "missionDescriptionTextBox";
            missionDescriptionTextBox.Size = new Size(366, 176);
            missionDescriptionTextBox.TabIndex = 4;
            missionDescriptionTextBox.TextChanged += missionDescriptionTextBox_TextChanged;
            // 
            // SendMissionButton
            // 
            SendMissionButton.Location = new Point(141, 602);
            SendMissionButton.Name = "SendMissionButton";
            SendMissionButton.Size = new Size(94, 29);
            SendMissionButton.TabIndex = 6;
            SendMissionButton.Text = "Send";
            SendMissionButton.UseVisualStyleBackColor = true;
            SendMissionButton.Click += SendButton_Click;
            // 
            // ListAssassinsForMissions
            // 
            ListAssassinsForMissions.Location = new Point(12, 462);
            ListAssassinsForMissions.Name = "ListAssassinsForMissions";
            ListAssassinsForMissions.Size = new Size(755, 121);
            ListAssassinsForMissions.TabIndex = 9;
            ListAssassinsForMissions.UseCompatibleStateImageBehavior = false;
            ListAssassinsForMissions.View = View.List;
            // 
            // listViewHistoryMission
            // 
            listViewHistoryMission.Location = new Point(12, 245);
            listViewHistoryMission.Name = "listViewHistoryMission";
            listViewHistoryMission.Size = new Size(366, 174);
            listViewHistoryMission.TabIndex = 5;
            listViewHistoryMission.UseCompatibleStateImageBehavior = false;
            listViewHistoryMission.View = View.List;
            // 
            // AddingMissions
            // 
            AddingMissions.Location = new Point(341, 602);
            AddingMissions.Name = "AddingMissions";
            AddingMissions.Size = new Size(94, 29);
            AddingMissions.TabIndex = 10;
            AddingMissions.Text = "Missions";
            AddingMissions.UseVisualStyleBackColor = true;
            AddingMissions.Click += AddingMissions_Click;
            // 
            // RefreshAssassinsListViewButton
            // 
            RefreshAssassinsListViewButton.Location = new Point(441, 602);
            RefreshAssassinsListViewButton.Name = "RefreshAssassinsListViewButton";
            RefreshAssassinsListViewButton.Size = new Size(94, 29);
            RefreshAssassinsListViewButton.TabIndex = 11;
            RefreshAssassinsListViewButton.Text = "Refresh";
            RefreshAssassinsListViewButton.UseVisualStyleBackColor = true;
            RefreshAssassinsListViewButton.Click += RefreshButton_Click;
            // 
            // listViewUserMissions
            // 
            listViewUserMissions.Location = new Point(484, 245);
            listViewUserMissions.Name = "listViewUserMissions";
            listViewUserMissions.Size = new Size(283, 174);
            listViewUserMissions.TabIndex = 12;
            listViewUserMissions.UseCompatibleStateImageBehavior = false;
            listViewUserMissions.SelectedIndexChanged += ListViewUserMissions_SelectedIndexChanged;
            // 
            // Stockholm_City_Missions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 1056);
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
    }
}
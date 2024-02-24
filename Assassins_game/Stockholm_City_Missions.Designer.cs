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
            SendButton = new Button();
            GoBackButton = new Button();
            MissionLoadButton = new Button();
            listViewMissions = new ListView();
            missionDescriptionTextBox = new TextBox();
            SuspendLayout();
            // 
            // SendButton
            // 
            SendButton.Location = new Point(346, 319);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(94, 29);
            SendButton.TabIndex = 1;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
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
            // 
            // Stockholm_City_Missions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(missionDescriptionTextBox);
            Controls.Add(listViewMissions);
            Controls.Add(MissionLoadButton);
            Controls.Add(GoBackButton);
            Controls.Add(SendButton);
            Name = "Stockholm_City_Missions";
            Text = "Stockholm_City_Missions";
            Load += Stockholm_City_Missions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SendButton;
        private Button GoBackButton;
        private Button MissionLoadButton;
        private ListView listViewMissions;
        private TextBox missionDescriptionTextBox;
    }
}
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
            listViewMissions = new ListView();
            columnHeader1 = new ColumnHeader();
            SendButton = new Button();
            GoBackButton = new Button();
            label1 = new Label();
            LabelName = new Label();
            label3 = new Label();
            label4 = new Label();
            LabelId = new Label();
            label6 = new Label();
            LabelDescription = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // listViewMissions
            // 
            listViewMissions.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listViewMissions.HoverSelection = true;
            listViewMissions.Location = new Point(29, 29);
            listViewMissions.Name = "listViewMissions";
            listViewMissions.Size = new Size(257, 372);
            listViewMissions.TabIndex = 0;
            listViewMissions.UseCompatibleStateImageBehavior = false;
            listViewMissions.View = View.List;
            listViewMissions.SelectedIndexChanged += listViewMissions_SelectedIndexChanged;
            // 
            // SendButton
            // 
            SendButton.Location = new Point(337, 360);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(94, 29);
            SendButton.TabIndex = 1;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // GoBackButton
            // 
            GoBackButton.Location = new Point(527, 360);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(94, 29);
            GoBackButton.TabIndex = 1;
            GoBackButton.Text = "Go Back";
            GoBackButton.UseVisualStyleBackColor = true;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 56);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(484, 85);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(12, 20);
            LabelName.TabIndex = 2;
            LabelName.Text = ".";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 143);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "DESCRIPTION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(452, 311);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 2;
            label4.Text = "TIME";
            // 
            // LabelId
            // 
            LabelId.AutoSize = true;
            LabelId.Location = new Point(292, 85);
            LabelId.Name = "LabelId";
            LabelId.Size = new Size(12, 20);
            LabelId.TabIndex = 2;
            LabelId.Text = ".";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(484, 56);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 2;
            label6.Text = "NAME";
            label6.Click += LabelName_Click;
            // 
            // LabelDescription
            // 
            LabelDescription.AutoSize = true;
            LabelDescription.Location = new Point(292, 175);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new Size(204, 20);
            LabelDescription.TabIndex = 2;
            LabelDescription.Text = "Select Mission for description";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(452, 331);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 2;
            label8.Text = "TIME";
            // 
            // Stockholm_City_Missions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(LabelDescription);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(LabelName);
            Controls.Add(LabelId);
            Controls.Add(label1);
            Controls.Add(GoBackButton);
            Controls.Add(SendButton);
            Controls.Add(listViewMissions);
            Name = "Stockholm_City_Missions";
            Text = "Stockholm_City_Missions";
            Load += Stockholm_City_Missions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewMissions;
        private Button SendButton;
        private Button GoBackButton;
        private Label label1;
        private Label LabelName;
        private Label label3;
        private Label label4;
        private Label LabelId;
        private Label label6;
        private Label LabelDescription;
        private Label label8;
        private ColumnHeader columnHeader1;
    }
}
namespace Assassins_game
{
    partial class Contract
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
            missionNameTextBox = new TextBox();
            missionDescriptionTextBoxAdd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            AddButtonPress = new Button();
            SuspendLayout();
            // 
            // missionNameTextBox
            // 
            missionNameTextBox.Location = new Point(173, 75);
            missionNameTextBox.Multiline = true;
            missionNameTextBox.Name = "missionNameTextBox";
            missionNameTextBox.Size = new Size(210, 27);
            missionNameTextBox.TabIndex = 0;
            missionNameTextBox.TextChanged += missionNameTextBox_TextChanged;
            // 
            // missionDescriptionTextBoxAdd
            // 
            missionDescriptionTextBoxAdd.Location = new Point(411, 75);
            missionDescriptionTextBoxAdd.Multiline = true;
            missionDescriptionTextBoxAdd.Name = "missionDescriptionTextBoxAdd";
            missionDescriptionTextBoxAdd.Size = new Size(215, 111);
            missionDescriptionTextBoxAdd.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 38);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 1;
            label1.Text = "Operation Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 38);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // AddButtonPress
            // 
            AddButtonPress.Location = new Point(240, 278);
            AddButtonPress.Name = "AddButtonPress";
            AddButtonPress.Size = new Size(94, 29);
            AddButtonPress.TabIndex = 2;
            AddButtonPress.Text = "Add";
            AddButtonPress.UseVisualStyleBackColor = true;
            AddButtonPress.Click += AddButtonPress_Click;
            // 
            // Contract
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddButtonPress);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(missionDescriptionTextBoxAdd);
            Controls.Add(missionNameTextBox);
            Name = "Contract";
            Text = "Contract";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox missionNameTextBox;
        private TextBox missionDescriptionTextBoxAdd;
        private Label label1;
        private Label label2;
        private Button AddButtonPress;
    }
}
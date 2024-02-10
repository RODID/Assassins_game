namespace Assassins_game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login_button = new Button();
            signup_button = new Button();
            username_label = new Label();
            password_label = new Label();
            password_textbox = new TextBox();
            username_textbox = new TextBox();
            SuspendLayout();
            // 
            // login_button
            // 
            login_button.Location = new Point(98, 215);
            login_button.Name = "login_button";
            login_button.Size = new Size(94, 29);
            login_button.TabIndex = 0;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = true;
            // 
            // signup_button
            // 
            signup_button.Location = new Point(98, 261);
            signup_button.Name = "signup_button";
            signup_button.Size = new Size(94, 29);
            signup_button.TabIndex = 1;
            signup_button.Text = "Signup";
            signup_button.UseVisualStyleBackColor = true;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Location = new Point(85, 53);
            username_label.Name = "username_label";
            username_label.Size = new Size(75, 20);
            username_label.TabIndex = 2;
            username_label.Text = "Username";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(85, 130);
            password_label.Name = "password_label";
            password_label.Size = new Size(70, 20);
            password_label.TabIndex = 3;
            password_label.Text = "Password";
            password_label.Click += label2_Click;
            // 
            // password_textbox
            // 
            password_textbox.Location = new Point(85, 167);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(125, 27);
            password_textbox.TabIndex = 4;
            // 
            // username_textbox
            // 
            username_textbox.Location = new Point(85, 86);
            username_textbox.Name = "username_textbox";
            username_textbox.Size = new Size(125, 27);
            username_textbox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 347);
            Controls.Add(username_textbox);
            Controls.Add(password_textbox);
            Controls.Add(password_label);
            Controls.Add(username_label);
            Controls.Add(signup_button);
            Controls.Add(login_button);
            Name = "Form1";
            Text = "Assassin_Game";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_button;
        private Button signup_button;
        private Label username_label;
        private Label password_label;
        private TextBox password_textbox;
        private TextBox username_textbox;
    }
}

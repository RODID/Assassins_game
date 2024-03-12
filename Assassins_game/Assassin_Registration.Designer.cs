namespace Assassins_game
{
    partial class Assassin_Registration
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
            register_clear_ = new Button();
            Register_username_txtlabel = new Label();
            register_password_txtlabel = new Label();
            register_email_txtlabel = new Label();
            register_password_txtlabel2 = new Label();
            register_username_txtbox = new TextBox();
            register_password_txtbox1 = new TextBox();
            register_password_txtbox2 = new TextBox();
            textBox4 = new TextBox();
            register_email_txtbox = new TextBox();
            register_goback_ = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // register_clear_
            // 
            register_clear_.Location = new Point(421, 285);
            register_clear_.Name = "register_clear_";
            register_clear_.Size = new Size(94, 29);
            register_clear_.TabIndex = 1;
            register_clear_.Text = "Clear";
            register_clear_.UseVisualStyleBackColor = true;
            register_clear_.Click += register_clear_Click;
            // 
            // Register_username_txtlabel
            // 
            Register_username_txtlabel.AutoSize = true;
            Register_username_txtlabel.Location = new Point(245, 85);
            Register_username_txtlabel.Name = "Register_username_txtlabel";
            Register_username_txtlabel.Size = new Size(107, 20);
            Register_username_txtlabel.TabIndex = 2;
            Register_username_txtlabel.Text = "Assassin Name";
            // 
            // register_password_txtlabel
            // 
            register_password_txtlabel.AutoSize = true;
            register_password_txtlabel.Location = new Point(421, 85);
            register_password_txtlabel.Name = "register_password_txtlabel";
            register_password_txtlabel.Size = new Size(70, 20);
            register_password_txtlabel.TabIndex = 2;
            register_password_txtlabel.Text = "Password";
            // 
            // register_email_txtlabel
            // 
            register_email_txtlabel.AutoSize = true;
            register_email_txtlabel.Location = new Point(245, 187);
            register_email_txtlabel.Name = "register_email_txtlabel";
            register_email_txtlabel.Size = new Size(46, 20);
            register_email_txtlabel.TabIndex = 2;
            register_email_txtlabel.Text = "Email";
            // 
            // register_password_txtlabel2
            // 
            register_password_txtlabel2.AutoSize = true;
            register_password_txtlabel2.Location = new Point(421, 187);
            register_password_txtlabel2.Name = "register_password_txtlabel2";
            register_password_txtlabel2.Size = new Size(70, 20);
            register_password_txtlabel2.TabIndex = 2;
            register_password_txtlabel2.Text = "Password";
            // 
            // register_username_txtbox
            // 
            register_username_txtbox.Location = new Point(245, 122);
            register_username_txtbox.Name = "register_username_txtbox";
            register_username_txtbox.Size = new Size(125, 27);
            register_username_txtbox.TabIndex = 3;
            // 
            // register_password_txtbox1
            // 
            register_password_txtbox1.Location = new Point(421, 122);
            register_password_txtbox1.Name = "register_password_txtbox1";
            register_password_txtbox1.Size = new Size(125, 27);
            register_password_txtbox1.TabIndex = 3;
            register_password_txtbox1.TextChanged += register_password_txtbox1_TextChanged;
            // 
            // register_password_txtbox2
            // 
            register_password_txtbox2.Location = new Point(421, 219);
            register_password_txtbox2.Name = "register_password_txtbox2";
            register_password_txtbox2.Size = new Size(125, 27);
            register_password_txtbox2.TabIndex = 3;
            register_password_txtbox2.TextChanged += register_password_txtbox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(245, 219);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 3;
            // 
            // register_email_txtbox
            // 
            register_email_txtbox.Location = new Point(245, 219);
            register_email_txtbox.Name = "register_email_txtbox";
            register_email_txtbox.Size = new Size(125, 27);
            register_email_txtbox.TabIndex = 3;
            // 
            // register_goback_
            // 
            register_goback_.Location = new Point(348, 363);
            register_goback_.Name = "register_goback_";
            register_goback_.Size = new Size(94, 29);
            register_goback_.TabIndex = 1;
            register_goback_.Text = "Go Back";
            register_goback_.UseVisualStyleBackColor = true;
            register_goback_.Click += register_goback_Click;
            // 
            // button1
            // 
            button1.Location = new Point(288, 285);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += RegisterButton_Click;
            // 
            // Assassin_Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(register_email_txtbox);
            Controls.Add(textBox4);
            Controls.Add(register_password_txtbox2);
            Controls.Add(register_password_txtbox1);
            Controls.Add(register_username_txtbox);
            Controls.Add(register_password_txtlabel2);
            Controls.Add(register_email_txtlabel);
            Controls.Add(register_password_txtlabel);
            Controls.Add(Register_username_txtlabel);
            Controls.Add(register_goback_);
            Controls.Add(register_clear_);
            Name = "Assassin_Registration";
            Text = "Assassin_Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button register_clear_;
        private Label Register_username_txtlabel;
        private Label register_password_txtlabel;
        private Label register_email_txtlabel;
        private Label register_password_txtlabel2;
        private TextBox register_username_txtbox;
        private TextBox register_password_txtbox1;
        private TextBox register_password_txtbox2;
        private TextBox textBox4;
        private TextBox register_email_txtbox;
        private Button register_goback_;
        private Button button1;
    }
}
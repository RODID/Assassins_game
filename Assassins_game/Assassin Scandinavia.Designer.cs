namespace Assassins_game
{
    partial class Assassin_Scandinavia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assassin_Scandinavia));
            pictureBox1 = new PictureBox();
            Stockholm_Mission_Button = new Button();
            Refresh_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(742, 1249);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Stockholm_Mission_Button
            // 
            Stockholm_Mission_Button.Location = new Point(386, 692);
            Stockholm_Mission_Button.Name = "Stockholm_Mission_Button";
            Stockholm_Mission_Button.Size = new Size(94, 29);
            Stockholm_Mission_Button.TabIndex = 1;
            Stockholm_Mission_Button.Text = "Stockholm";
            Stockholm_Mission_Button.UseVisualStyleBackColor = true;
            Stockholm_Mission_Button.Click += Stockholm_Mission_Button_Click;
            // 
            // Refresh_Button
            // 
            Refresh_Button.ForeColor = Color.ForestGreen;
            Refresh_Button.Location = new Point(446, 571);
            Refresh_Button.Name = "Refresh_Button";
            Refresh_Button.Size = new Size(94, 29);
            Refresh_Button.TabIndex = 2;
            Refresh_Button.Text = "Refresh";
            Refresh_Button.UseVisualStyleBackColor = true;
            Refresh_Button.Click += Refresh_Button_Click;
            // 
            // Assassin_Scandinavia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 1127);
            Controls.Add(Refresh_Button);
            Controls.Add(Stockholm_Mission_Button);
            Controls.Add(pictureBox1);
            Name = "Assassin_Scandinavia";
            Text = "Assassin_Scandinavia";
            Load += Assassin_Scandinavia_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Stockholm_Mission_Button;
        private Button Refresh_Button;
    }
}
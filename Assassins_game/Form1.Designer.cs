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
            stockholm = new Button();
            uppsala = new Button();
            malmö = new Button();
            göteborg = new Button();
            SuspendLayout();
            // 
            // stockholm
            // 
            stockholm.Location = new Point(142, 112);
            stockholm.Name = "stockholm";
            stockholm.Size = new Size(94, 29);
            stockholm.TabIndex = 0;
            stockholm.Text = "Stockholm";
            stockholm.UseVisualStyleBackColor = true;
            // 
            // uppsala
            // 
            uppsala.Location = new Point(142, 189);
            uppsala.Name = "uppsala";
            uppsala.Size = new Size(94, 29);
            uppsala.TabIndex = 1;
            uppsala.Text = "Uppsala";
            uppsala.UseVisualStyleBackColor = true;
            // 
            // malmö
            // 
            malmö.Location = new Point(142, 275);
            malmö.Name = "malmö";
            malmö.Size = new Size(94, 29);
            malmö.TabIndex = 2;
            malmö.Text = "Malmö";
            malmö.UseVisualStyleBackColor = true;
            // 
            // göteborg
            // 
            göteborg.Location = new Point(142, 363);
            göteborg.Name = "göteborg";
            göteborg.Size = new Size(94, 29);
            göteborg.TabIndex = 3;
            göteborg.Text = "Göteborg";
            göteborg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(göteborg);
            Controls.Add(malmö);
            Controls.Add(uppsala);
            Controls.Add(stockholm);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button stockholm;
        private Button uppsala;
        private Button malmö;
        private Button göteborg;
    }
}

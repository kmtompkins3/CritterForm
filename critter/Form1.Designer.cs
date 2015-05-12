namespace critter
{
    partial class Form1
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
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.HungerBar = new System.Windows.Forms.ProgressBar();
            this.HappienessBar = new System.Windows.Forms.ProgressBar();
            this.WasteBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WarningBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Feed = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HealthBar
            // 
            this.HealthBar.Location = new System.Drawing.Point(525, 35);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(206, 23);
            this.HealthBar.TabIndex = 0;
            // 
            // HungerBar
            // 
            this.HungerBar.Location = new System.Drawing.Point(85, 35);
            this.HungerBar.Name = "HungerBar";
            this.HungerBar.Size = new System.Drawing.Size(100, 23);
            this.HungerBar.TabIndex = 1;
            // 
            // HappienessBar
            // 
            this.HappienessBar.Location = new System.Drawing.Point(85, 64);
            this.HappienessBar.Name = "HappienessBar";
            this.HappienessBar.Size = new System.Drawing.Size(100, 23);
            this.HappienessBar.TabIndex = 2;
            // 
            // WasteBar
            // 
            this.WasteBar.Location = new System.Drawing.Point(85, 93);
            this.WasteBar.Name = "WasteBar";
            this.WasteBar.Size = new System.Drawing.Size(100, 23);
            this.WasteBar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hunger:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Happieness:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Waste:";
            // 
            // WarningBox
            // 
            this.WarningBox.Location = new System.Drawing.Point(12, 367);
            this.WarningBox.Name = "WarningBox";
            this.WarningBox.Size = new System.Drawing.Size(618, 62);
            this.WarningBox.TabIndex = 8;
            this.WarningBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Warnings/Errors:";
            // 
            // Feed
            // 
            this.Feed.AutoEllipsis = true;
            this.Feed.Location = new System.Drawing.Point(210, 35);
            this.Feed.Name = "Feed";
            this.Feed.Size = new System.Drawing.Size(75, 23);
            this.Feed.TabIndex = 10;
            this.Feed.Text = "Feed";
            this.Feed.UseVisualStyleBackColor = true;
            this.Feed.Click += new System.EventHandler(this.button1_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(210, 65);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 11;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(210, 93);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(75, 23);
            this.Clean.TabIndex = 12;
            this.Clean.Text = "Clean";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(636, 385);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(95, 23);
            this.Reset.TabIndex = 13;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 441);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Feed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WarningBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WasteBar);
            this.Controls.Add(this.HappienessBar);
            this.Controls.Add(this.HungerBar);
            this.Controls.Add(this.HealthBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.ProgressBar HungerBar;
        private System.Windows.Forms.ProgressBar HappienessBar;
        private System.Windows.Forms.ProgressBar WasteBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox WarningBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Feed;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Button Reset;
    }
}


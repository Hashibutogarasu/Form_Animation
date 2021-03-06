
namespace Twitter
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
            this.TopIcon = new System.Windows.Forms.PictureBox();
            this.BackGroundPicture = new System.Windows.Forms.PictureBox();
            this.HomeButton = new System.Windows.Forms.Button();
            this.MentionsButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TopIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // TopIcon
            // 
            this.TopIcon.Image = global::Twitter.Properties.Resources.icon_42;
            this.TopIcon.Location = new System.Drawing.Point(0, 0);
            this.TopIcon.Name = "TopIcon";
            this.TopIcon.Size = new System.Drawing.Size(42, 42);
            this.TopIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TopIcon.TabIndex = 0;
            this.TopIcon.TabStop = false;
            // 
            // BackGroundPicture
            // 
            this.BackGroundPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGroundPicture.Location = new System.Drawing.Point(0, 0);
            this.BackGroundPicture.Name = "BackGroundPicture";
            this.BackGroundPicture.Size = new System.Drawing.Size(784, 361);
            this.BackGroundPicture.TabIndex = 2;
            this.BackGroundPicture.TabStop = false;
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(12, 71);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(127, 36);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "ホーム";
            this.HomeButton.UseVisualStyleBackColor = true;
            // 
            // MentionsButton
            // 
            this.MentionsButton.Location = new System.Drawing.Point(12, 113);
            this.MentionsButton.Name = "MentionsButton";
            this.MentionsButton.Size = new System.Drawing.Size(127, 36);
            this.MentionsButton.TabIndex = 1;
            this.MentionsButton.Text = "メンション";
            this.MentionsButton.UseVisualStyleBackColor = true;
            // 
            // ProfileButton
            // 
            this.ProfileButton.Location = new System.Drawing.Point(12, 155);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(127, 36);
            this.ProfileButton.TabIndex = 2;
            this.ProfileButton.Text = "プロフィール";
            this.ProfileButton.UseVisualStyleBackColor = true;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(12, 197);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(127, 36);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "設定";
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.MentionsButton);
            this.Controls.Add(this.HomeButton);
            //this.Controls.Add(this.TopIcon);
            //this.Controls.Add(this.BackGroundPicture);
            this.Name = "Form1";
            this.Text = "Twitter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.PictureBox TopIcon;
        private System.Windows.Forms.PictureBox BackGroundPicture;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button MentionsButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button SettingsButton;
    }
}


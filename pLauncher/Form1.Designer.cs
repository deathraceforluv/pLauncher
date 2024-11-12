namespace pLauncher
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Declaring the controls
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox gameDirectoryTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox steamIdTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Button generateSteamIdButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browseButton = new System.Windows.Forms.Button();
            this.gameDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.steamIdTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.launchButton = new System.Windows.Forms.Button();
            this.labelGameDirectory = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelSteamID = new System.Windows.Forms.Label();
            this.generateSteamIdButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.browseButton.Location = new System.Drawing.Point(212, 49);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(38, 20);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "•••";
            this.browseButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // gameDirectoryTextBox
            // 
            this.gameDirectoryTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gameDirectoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameDirectoryTextBox.Enabled = false;
            this.gameDirectoryTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.gameDirectoryTextBox.Location = new System.Drawing.Point(20, 49);
            this.gameDirectoryTextBox.Name = "gameDirectoryTextBox";
            this.gameDirectoryTextBox.ReadOnly = true;
            this.gameDirectoryTextBox.Size = new System.Drawing.Size(186, 20);
            this.gameDirectoryTextBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.usernameTextBox.Location = new System.Drawing.Point(21, 111);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(230, 20);
            this.usernameTextBox.TabIndex = 2;
            // 
            // steamIdTextBox
            // 
            this.steamIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.steamIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.steamIdTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.steamIdTextBox.Location = new System.Drawing.Point(20, 156);
            this.steamIdTextBox.Name = "steamIdTextBox";
            this.steamIdTextBox.Size = new System.Drawing.Size(150, 20);
            this.steamIdTextBox.TabIndex = 3;
            this.steamIdTextBox.TextChanged += new System.EventHandler(this.steamIdTextBox_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.saveButton.Location = new System.Drawing.Point(20, 202);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 46);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save All";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // launchButton
            // 
            this.launchButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.launchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launchButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.launchButton.Location = new System.Drawing.Point(150, 202);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(100, 46);
            this.launchButton.TabIndex = 5;
            this.launchButton.Text = "Launch Game";
            this.launchButton.UseVisualStyleBackColor = false;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // labelGameDirectory
            // 
            this.labelGameDirectory.AutoSize = true;
            this.labelGameDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelGameDirectory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameDirectory.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGameDirectory.Location = new System.Drawing.Point(16, 27);
            this.labelGameDirectory.Name = "labelGameDirectory";
            this.labelGameDirectory.Size = new System.Drawing.Size(118, 19);
            this.labelGameDirectory.TabIndex = 7;
            this.labelGameDirectory.Text = "Game Directory";
            this.labelGameDirectory.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUsername.Location = new System.Drawing.Point(17, 89);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(80, 19);
            this.labelUsername.TabIndex = 8;
            this.labelUsername.Text = "Username";
            // 
            // labelSteamID
            // 
            this.labelSteamID.AutoSize = true;
            this.labelSteamID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSteamID.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSteamID.Location = new System.Drawing.Point(17, 134);
            this.labelSteamID.Name = "labelSteamID";
            this.labelSteamID.Size = new System.Drawing.Size(72, 19);
            this.labelSteamID.TabIndex = 9;
            this.labelSteamID.Text = "Steam ID";
            // 
            // generateSteamIdButton
            // 
            this.generateSteamIdButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.generateSteamIdButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.generateSteamIdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateSteamIdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateSteamIdButton.ForeColor = System.Drawing.Color.White;
            this.generateSteamIdButton.Location = new System.Drawing.Point(176, 156);
            this.generateSteamIdButton.Name = "generateSteamIdButton";
            this.generateSteamIdButton.Size = new System.Drawing.Size(19, 20);
            this.generateSteamIdButton.TabIndex = 6;
            this.generateSteamIdButton.Text = "^";
            this.generateSteamIdButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.generateSteamIdButton.UseVisualStyleBackColor = false;
            this.generateSteamIdButton.Click += new System.EventHandler(this.generateSteamIdButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.ForeColor = System.Drawing.SystemColors.Control;
            this.helpButton.Location = new System.Drawing.Point(237, 12);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(20, 25);
            this.helpButton.TabIndex = 10;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(269, 265);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.labelSteamID);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelGameDirectory);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.gameDirectoryTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.steamIdTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.generateSteamIdButton);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelGameDirectory;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelSteamID;
        private System.Windows.Forms.Button helpButton;
    }
}

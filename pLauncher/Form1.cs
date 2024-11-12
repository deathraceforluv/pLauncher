using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string savedDirectory = Properties.Settings.Default.GameDirectory;
            if (string.IsNullOrEmpty(savedDirectory))
            {
                browseButton_Click(sender, e); // Prompt the user to select directory on first launch
            }
            else
            {
                gameDirectoryTextBox.Text = savedDirectory;
                LoadUserSettings(savedDirectory); // Load user settings from text files
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select Your Game Directory";
                folderDialog.ShowNewFolderButton = false;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    gameDirectoryTextBox.Text = folderDialog.SelectedPath;
                    Properties.Settings.Default.GameDirectory = folderDialog.SelectedPath;
                    Properties.Settings.Default.Save();
                    LoadUserSettings(folderDialog.SelectedPath); // Load user settings from text files
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string gameDirectory = Properties.Settings.Default.GameDirectory;
            string steamSettingsPath = Path.Combine(gameDirectory, "Phasmophobia_Data", "Plugins", "x86_64", "steam_settings");

            if (Directory.Exists(steamSettingsPath))
            {
                string accountNameFile = Path.Combine(steamSettingsPath, "force_account_name.txt");
                string steamIdFile = Path.Combine(steamSettingsPath, "force_steamid.txt");

                File.WriteAllText(accountNameFile, usernameTextBox.Text);
                File.WriteAllText(steamIdFile, steamIdTextBox.Text);

                MessageBox.Show("Settings saved successfully!");
            }
            else
            {
                MessageBox.Show("Game directory or Steam settings path not found.");
            }
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            string gameDirectory = Properties.Settings.Default.GameDirectory;
            string gameExecutablePath = Path.Combine(gameDirectory, "Phasmophobia.exe");

            if (File.Exists(gameExecutablePath))
            {
                System.Diagnostics.Process.Start(gameExecutablePath);
            }
            else
            {
                MessageBox.Show("Game executable not found.");
            }
        }

        private void generateSteamIdButton_Click(object sender, EventArgs e)
        {
            steamIdTextBox.Text = GenerateRandomSteamID();
        }

        private string GenerateRandomSteamID()
        {
            Random random = new Random();
            long randomSuffix = random.Next(1000, 9999);  // Randomizes the last 4 Digits of the Steam ID to ensure no user's match Steam ID's
            string steamId = $"7656119796028{randomSuffix:D4}"; // Uses template and fills it in with the generated 4
            return steamId;
        }

        private void LoadUserSettings(string gameDirectory)
        {
            string steamSettingsPath = Path.Combine(gameDirectory, "Phasmophobia_Data", "Plugins", "x86_64", "steam_settings");

            if (Directory.Exists(steamSettingsPath))
            {
                string accountNameFile = Path.Combine(steamSettingsPath, "force_account_name.txt");
                string steamIdFile = Path.Combine(steamSettingsPath, "force_steamid.txt");

                if (File.Exists(accountNameFile))
                {
                    usernameTextBox.Text = File.ReadAllText(accountNameFile);
                }

                if (File.Exists(steamIdFile))
                {
                    steamIdTextBox.Text = File.ReadAllText(steamIdFile);
                }
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have any issues? Check out the latest updates in the discord!\ndiscord.gg/yuAMDxGPmP");
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void steamIdTextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

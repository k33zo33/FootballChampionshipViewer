using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            try
            {
                Repository.LoadSettings();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occured while trying to load application settings:{ex.Message}");
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Hide();
                    SettingsFile.gender = rbtnFemale.Checked;
                    SettingsFile.country = String.Empty;
                    Repository.SaveSettings();
                    new MainForm().Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occured while trying to save application settings:{ex.Message}");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Hide();
                new MainForm().Show();
            }
        }

        private void BtnLanguage_Click(object sender, EventArgs e)
        {
            try
            {
                if (Thread.CurrentThread.CurrentCulture.Name == Repository.HR)
                {
                    Repository.SetCulture(Repository.EN);
                    SettingsFile.language = "Croatian";
                    RefreshForm();
                    LoadGender();
                }
                else
                {
                    Repository.SetCulture(Repository.HR);
                    SettingsFile.language = "Engleski";
                    RefreshForm();
                    LoadGender();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occured while trying to change application language:{ex.Message}");
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            try
            {
                Repository.LoadSettings();
                Repository.LoadLanguage();
                RefreshForm();
                LoadGender();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occured while trying to load application settings:{ex.Message}");
            }
        }

        private void LoadGender()
        {
            try
            {
                if (SettingsFile.gender)
                {
                    rbtnFemale.Checked = true;
                }
                else
                {
                    rbtnMale.Checked = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occured while trying to load World Cup gender:{ex.Message}");
            }
        }
        private void RefreshForm()
        {
            this.Controls.Clear();
            InitializeComponent();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Dispose();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
                return;
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Hide();
                    new MainForm().Show();
                }
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}

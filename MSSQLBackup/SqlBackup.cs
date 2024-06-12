using System.Data.SqlClient;

using System;
using System.Data;

using System.Windows.Forms;

namespace MSSQLBackup
{
    public partial class SqlBackup : Form
    {

        // Member variable to store the selected backup file path
        private string selectedBackupFilePath = string.Empty;
        public SqlBackup()
        {
            InitializeComponent();
            DatabaseDropdown.Enabled = false;

            BackUpBtn.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SQLtxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatabaseDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            string server = SQLtxtBox.Text; // SQL Server Name saved in variable 
            string connectionString = $"Server={server};Integrated Security=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT name FROM sys.databases WHERE state = 0", connection); // Query to get databases
                    SqlDataReader reader = command.ExecuteReader();

                    DatabaseDropdown.Items.Clear(); // Clear existing items
                    while (reader.Read())
                    {
                        DatabaseDropdown.Items.Add(reader["name"].ToString());
                    }

                    reader.Close();
                    DatabaseDropdown.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            BackUpBtn.Enabled = true;
        }

        // Backup button click event handler
        private void BackUpBtn_Click(object sender, EventArgs e)
        {
            if (DatabaseDropdown.SelectedItem == null)
            {
                MessageBox.Show("Please select a database to backup.");
                return;
            }

            if (string.IsNullOrEmpty(selectedBackupFilePath))
            {
                MessageBox.Show("Please select a backup location.");
                return;
            }

            string database = DatabaseDropdown.SelectedItem.ToString();
            string server = SQLtxtBox.Text;
            string connectionString = $"Server={server};Integrated Security=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string backupQuery = $"BACKUP DATABASE [{database}] TO DISK='{selectedBackupFilePath}'";

                    using (SqlCommand command = new SqlCommand(backupQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Database backup completed successfully.");

                        // Display the backup location and database name
                        BackupLocationTextBox.Text = $"Database: '{database}' -- \nBackup Location: '{selectedBackupFilePath}'";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Method to handle backup location selection
        private void SelectBackupLocation()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Backup Files (*.bak)|*.bak";
                saveFileDialog.Title = "Select Backup Location";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedBackupFilePath = saveFileDialog.FileName;
                    BackupLocationTextBox.Text = $"Selected Backup Location: '{selectedBackupFilePath}'";
                }
            }
        }

        // Location button click event handler
        private void LocationBtn_Click(object sender, EventArgs e)
        {
            SelectBackupLocation();
        }

        // Backup location text box text changed event handler
        private void BackupLocationTextBox_TextChanged(object sender, EventArgs e)
        {
            // Location of a backup will appear in here 
        }


    }
}

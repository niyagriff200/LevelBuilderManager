using LevelBuilderManager.Classes;
using LevelBuilderManager.Data;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LevelBuilderManager
{
    public partial class frmLevels : Form
    {
        //So I can return to the main menu when I close this form
        private frmMainMenu frmOriginal;

        private LevelManagerRepo repo = new LevelManagerRepo(); // Create an instance of the repository class that handles database operations for levels
        public frmLevels()
        {
            InitializeComponent();
        }

        public frmLevels(frmMainMenu mainMenuObj)
        {
            InitializeComponent();
            frmOriginal = mainMenuObj;
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            //When the return button is clicked, close this form (which will trigger the FormClosed event and show the main menu)
            frmOriginal.Show();
            this.Close();
        }

        private void frmLevels_FormClosing(object sender, FormClosingEventArgs e)
        {
            //When the form is closing, show the main menu again
            frmOriginal.Show();
        }

        // This event handler is triggered when the form loads, and it calls the LoadData method to populate the DataGridView with level data from the database.
        private void frmLevels_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // This method loads the level data from the database and populates the DataGridView when the form loads.
        private void LoadData()
        {
            string connLevels = DBHelper.GetConnection().ConnectionString; // Get the connection string for the database using the DBHelper class, which abstracts away the details of database connectivity

            using SqlConnection sqlLevelsConn = new SqlConnection(connLevels);
            {
                //When the form loads, populate the DataGridView with all levels from the database
                dgvLevelsManager.DataSource = DBHelper.ExecuteRead("SELECT * FROM Levels", new Dictionary<string, object>());
            }
        }

        // This event handler adds a new level to the database when the "Add Level" button is clicked.
        private void btnAddLevel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameEntry.Text) || string.IsNullOrWhiteSpace(txtThemeEntry.Text))
            {
                lbMessage.Text = "Please fill in all fields.";
                return;
            }

            GameAssetLevel level = FormToLevel(); // Convert the form input fields into a GameAssetLevel object to prepare for insertion into the database

            int rows = repo.AddLevel(level); // Call the AddLevel method of the repository to insert the new level into the database, and get the number of affected rows

            if (rows > 0) // If at least one row was affected, the insert was successful
                lbMessage.Text = "Level added successfully!";
            else
                lbMessage.Text = "No level was added.";

            LoadData();// Refresh the DataGridView to show the newly added level
        }



        // This event handler deletes the selected level from the database when the "Delete Level" button is clicked.
        private void btnDeleteLevel_Click(object sender, EventArgs e)
        {
            if (dgvLevelsManager.SelectedRows.Count == 0) // Check if a row is selected
            {
                lbMessage.Text = "Select a level to delete.";
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this level?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                GameAssetLevel level = repo.RowToLevel(dgvLevelsManager.SelectedRows[0]); // Convert the selected row to a GameAssetLevel object to get the ID for deletion

                

                // Execute the delete query and get the number of affected rows
                int rows = repo.DeleteLevel(level.AssetID);

                if (rows > 0) // If at least one row was affected, the delete was successful
                    lbMessage.Text = "Level deleted.";
                else
                    lbMessage.Text = "Delete failed.";

                LoadData(); // Refresh the DataGridView to reflect the changes in the database
            }
        }

        // This event handler populates the form input fields with the data from the selected row in the DataGridView,
        private void dgvLevelsManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure that a valid row is clicked (not the header)
            {
                DataGridViewRow row = dgvLevelsManager.Rows[e.RowIndex];

                txtNameEntry.Text = row.Cells["Name"].Value.ToString();
                txtThemeEntry.Text = row.Cells["Theme"].Value.ToString();
                numDifficultyEntry.Value = Convert.ToDecimal(row.Cells["Difficulty"].Value);
                numEnemyCount.Value = Convert.ToDecimal(row.Cells["Enemy Count"].Value);
            }
        }

        // This method converts the form input fields into a GameAssetLevel object,
        // which can then be used for database operations like insert or update.
        private GameAssetLevel FormToLevel()
        {
            return new GameAssetLevel(
                0, // ID is auto-generated on INSERT
                txtNameEntry.Text,
                (int)numDifficultyEntry.Value,
                txtThemeEntry.Text,
                (int)numEnemyCount.Value
            );
        }


        private void btnUpdateLevel_Click(object sender, EventArgs e)
        {
            if (dgvLevelsManager.SelectedRows.Count == 0)
            {
                lbMessage.Text = "Select a level to update.";
                return;
            }


            var result = MessageBox.Show("Are you sure you want to update this level?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Convert selected row to object so we know which ID to update
                GameAssetLevel level = repo.RowToLevel(dgvLevelsManager.SelectedRows[0]);

                // Update object with new form values
                level.AssetName = txtNameEntry.Text;
                level.Theme = txtThemeEntry.Text;
                level.Difficulty = (int)numDifficultyEntry.Value;
                level.EnemyCount = (int)numEnemyCount.Value;

                int rows = repo.UpdateLevel(level); // Execute the update query and get the number of affected rows

                lbMessage.Text = rows > 0 ? "Level updated!" : "Update failed."; //if at least one row was affected, the update was successful, else it failed

                LoadData();
            }
        }

    }
}

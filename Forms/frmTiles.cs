using LevelBuilderManager.Classes;
using LevelBuilderManager.Data;
using Microsoft.Data.SqlClient;

namespace LevelBuilderManager
{
    public partial class frmTiles : Form
    {
        //So I can return to the main menu when I close this form
        private frmMainMenu frmOriginal;

        private LevelManagerRepo repo = new LevelManagerRepo(); // Create an instance of the repository class that handles database operations for levels
        public frmTiles()
        {
            InitializeComponent();
        }

        public frmTiles(frmMainMenu mainMenuObj)
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

        private void frmTiles_FormClosing(object sender, FormClosingEventArgs e)
        {
            //When the form is closing, show the main menu again
            frmOriginal.Show();
        }

        // This event handler is triggered when the form loads, and it calls the LoadData method to populate the DataGridView with level data from the database.
        private void frmTiles_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // This method loads the level data from the database and populates the DataGridView when the form loads.
        private void LoadData()
        {
            string connTiles = DBHelper.GetConnection().ConnectionString; // Get the connection string for the database using the DBHelper class, which abstracts away the details of database connectivity

            using SqlConnection sqlTilesConn = new SqlConnection(connTiles);
            {
                //When the form loads, populate the DataGridView with all tiles from the database
                dgvTilesManager.DataSource = DBHelper.ExecuteRead("SELECT * FROM Tiles", new Dictionary<string, object>());
            }
        }

        // This event handler adds a new tile to the database when the "Add Tile" button is clicked.
        private void btnAddTile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameEntry.Text) || string.IsNullOrWhiteSpace(txtTypeEntry.Text))
            {
                lbMessage.Text = "Please fill in all fields.";
                return;
            }

            GameAssetTile tile = FormToTile(); // Convert the form input fields into a GameAssetTile object to prepare for insertion into the database

           int rows = repo.AddTile(tile);

            if (rows > 0) // If at least one row was affected, the insert was successful
                lbMessage.Text = "Tile added successfully!";
            else
                lbMessage.Text = "No tile was added.";

            LoadData();// Refresh the DataGridView to show the newly added tile
        }

        // This event handler deletes the selected tile from the database when the "Delete Tile" button is clicked.
        private void btnDeleteTile_Click(object sender, EventArgs e)
        {
            if (dgvTilesManager.SelectedRows.Count == 0) // Check if a row is selected
            {
                lbMessage.Text = "Select a tile to delete.";
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this tile?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {

                GameAssetTile tile = repo.RowToTile(dgvTilesManager.SelectedRows[0]); // Convert the selected row to a GameAssetTile object to get the ID for deletion

                int rows = repo.DeleteTile(tile.AssetID); // Execute the delete query and get the number of affected rows

                if (rows > 0) // If at least one row was affected, the delete was successful
                    lbMessage.Text = "Tile deleted.";
                else
                    lbMessage.Text = "Delete failed.";

                LoadData(); // Refresh the DataGridView to reflect the changes in the database
            }
        }

        // This event handler populates the form input fields with the data from the selected row in the DataGridView,
        private void dgvTilesManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure that a valid row is clicked (not the header)
            {
                DataGridViewRow row = dgvTilesManager.Rows[e.RowIndex];

                txtNameEntry.Text = row.Cells["Name"].Value.ToString();
                txtTypeEntry.Text = row.Cells["Type"].Value.ToString();
                cbCanBeWalkedOn.Checked = Convert.ToBoolean(row.Cells["Can Be Walked On"].Value);
            }
        }

        // This method converts the form input fields into a GameAssetTile object,
        // which can then be used for database operations like insert or update.
        private GameAssetTile FormToTile()
        {
            return new GameAssetTile(
                0, // ID is auto-generated on INSERT
                txtNameEntry.Text,
                txtTypeEntry.Text,
                cbCanBeWalkedOn.Checked
            );
        }
        

        private void btnUpdateTile_Click(object sender, EventArgs e)
        {
            if (dgvTilesManager.SelectedRows.Count == 0)
            {
                lbMessage.Text = "Select a tile to update.";
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to update this tile?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                // Convert selected row to object so we know which ID to update
                GameAssetTile tile = repo.RowToTile(dgvTilesManager.SelectedRows[0]);

                // Update object with new form values
                tile.AssetName = txtNameEntry.Text;
                tile.Type = txtTypeEntry.Text;
                tile.CanBeWalkedOn = cbCanBeWalkedOn.Checked;

                int rows = repo.UpdateTile(tile); // Execute the update query and get the number of affected rows

                lbMessage.Text = rows > 0 ? "Tile updated!" : "Update failed."; //if at least one row was affected, the update was successful, else it failed

                LoadData();
            }
        }
    }
    
}

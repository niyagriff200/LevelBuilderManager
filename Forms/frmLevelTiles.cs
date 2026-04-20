using System.Data;
using LevelBuilderManager.Data;
using Microsoft.Data.SqlClient;

namespace LevelBuilderManager
{
    public partial class frmLevelTiles : Form
    {
        //So I can return to the main menu when I close this form
        private frmMainMenu frmOriginal;

        public frmLevelTiles()
        {
            InitializeComponent();
        }

        public frmLevelTiles(frmMainMenu mainMenuObj)
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

        private void frmLevelTiles_FormClosing(object sender, FormClosingEventArgs e)
        {
            //When the form is closing, show the main menu again
            frmOriginal.Show();
        }

        private void frmLevelTiles_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadLevelsCombo();
            LoadTilesCombo();
        }

        private void LoadData()
        {
            string connLevels = DBHelper.GetConnection().ConnectionString; // Get the connection string for the database using the DBHelper class, which abstracts away the details of database connectivity

            using SqlConnection sqlLevelsConn = new SqlConnection(connLevels);
            {
                //When the form loads, populate the DataGridView with all levels from the database
                dgvLevelTilesManager.DataSource = DBHelper.ExecuteRead("SELECT * FROM LevelTiles", new Dictionary<string, object>());
            }
        }

        private void LoadLevelsCombo() //This method loads the levels from the database and populates the levels combo box with the level names and IDs.
        {
            DataTable dtLevels = DBHelper.ExecuteRead("SELECT Id, Name FROM Levels", null);

            //This adds a new column to the DataTable called "Display" that concatenates the
            //Id and Name columns with a hyphen in between.
            //This will be used as the display value for the combo box.
            dtLevels.Columns.Add("Display", typeof(string), "Id + ' - ' + Name");


            //This sets the DataSource of the combo box to the DataTable, and specifies that the DisplayMember is the "Display" column (which shows both Id and Name)
            //and the ValueMember is the "Id" column (which will be used as the actual value when an item is selected).
            cmbLevelNameID.DataSource = dtLevels;
            cmbLevelNameID.DisplayMember = "Display";
            cmbLevelNameID.ValueMember = "Id";
        }

        private void LoadTilesCombo() //This method loads the tiles from the database and populates the tiles combo box with the tile names and IDs.
        {
            //This executes a SQL query to select the Id and Name of all tiles from the database, and stores the result in a DataTable.
            DataTable dtTiles = DBHelper.ExecuteRead("SELECT Id, Name FROM Tiles", null);

            dtTiles.Columns.Add("Display", typeof(string), "Id + ' - ' + Name"); 

            cmbTileNameID.DataSource = dtTiles;
            cmbTileNameID.DisplayMember = "Display";
            cmbTileNameID.ValueMember = "Id";
        }

        //This method is called when the "Add Level Tile" button is clicked. It checks if a level and tile have been selected,
        //and if so, it inserts a new record into the LevelTiles table in the database with the selected level ID, tile ID, and tile count.
        private void btnAddLevelTile_Click(object sender, EventArgs e)
        { 
            if (cmbLevelNameID.SelectedIndex == -1 || cmbTileNameID.SelectedIndex == -1) // Check if a level and tile have been selected in the combo boxes. If not, display a message and return.
            {
                lbMessage.Text = "Select a level and a tile.";
                return;
            }

            //Get the selected level ID, tile ID, and tile count from the form controls.
            int levelID = (int)cmbLevelNameID.SelectedValue;
            int tileID = (int)cmbTileNameID.SelectedValue;
            int tileCount = (int)numTileCount.Value;

            //Construct a SQL query to insert a new record into the LevelTiles table with the selected level ID, tile ID, and tile count.
            string sql = @"INSERT INTO LevelTiles (LevelID, TileID, TileCount)
                   VALUES (@levelID, @tileID, @tileCount)";

            //Create a dictionary of parameters to pass to the DBHelper method, mapping the parameter names in the SQL query to the actual values from the form controls.
            var parameters = new Dictionary<string, object>
            {
                {"@levelID", levelID},
                {"@tileID", tileID},
                {"@tileCount", tileCount}
            };

            //Execute the SQL query using the DBHelper method, which will return the number of rows affected by the query.
            int rows = DBHelper.ExecuteNonQuery(sql, parameters);

            lbMessage.Text = rows > 0 ? "LevelTile added!" : "Insert failed."; //If the number of rows affected is greater than 0, it's successful, otherwise it failed.

            LoadData();
        }

        //This method is called when the "Delete Level Tile" button is clicked. It checks if a row is selected in the DataGridView,
        //and if so, it deletes the corresponding record from the LevelTiles table in the database based on the levelID and tileID of the selected row.
        private void btnDeleteLevelTile_Click(object sender, EventArgs e)
        {
            if (dgvLevelTilesManager.SelectedRows.Count == 0)
            {
                lbMessage.Text = "Select a row to delete.";
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            //Get the levelID and tileID of the selected row from the DataGridView, which correspond to the record in the LevelTiles table that we want to delete.
            int levelID = Convert.ToInt32(dgvLevelTilesManager.SelectedRows[0].Cells["LevelID"].Value);
            int tileID = Convert.ToInt32(dgvLevelTilesManager.SelectedRows[0].Cells["TileID"].Value);

            string sql = "DELETE FROM LevelTiles WHERE LevelID = @levelID AND TileID = @tileID"; //Construct a SQL query to delete the record from the LevelTiles table where the LevelID and TileID match the selected values.

            //Create a dictionary of parameters to pass to the DBHelper method, mapping the parameter names in the SQL query to the actual values from the selected row.
            var parameters = new Dictionary<string, object>
            {
                {"@levelID", levelID},
                {"@tileID", tileID}
            };

            int rows = DBHelper.ExecuteNonQuery(sql, parameters);

            lbMessage.Text = rows > 0 ? "Deleted!" : "Delete failed.";

            LoadData();
        }



        //This method is called when the "Update Level Tile" button is clicked. It checks if a row is selected in the DataGridView,
        //and if so, it updates the corresponding record in the LevelTiles table in the database based on the ID of the selected row.
        private void btnUpdateLevelTile_Click(object sender, EventArgs e)
        {
            if (dgvLevelTilesManager.SelectedRows.Count == 0)
            {
                lbMessage.Text = "Select a row to update.";
                return;
            }

            var result = MessageBox.Show("Are you sure you want to update this record?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Original keys from the selected row
                int originalLevelID = Convert.ToInt32(dgvLevelTilesManager.SelectedRows[0].Cells["LevelID"].Value);
                int originalTileID = Convert.ToInt32(dgvLevelTilesManager.SelectedRows[0].Cells["TileID"].Value);

                // New values from the form
                int newLevelID = (int)cmbLevelNameID.SelectedValue;
                int newTileID = (int)cmbTileNameID.SelectedValue;
                int tileCount = (int)numTileCount.Value;

                // Construct a SQL query to update the record in the LevelTiles table where the original LevelID and TileID match the selected values, setting the new LevelID, TileID, and TileCount.
                string sql = @"UPDATE LevelTiles
                       SET LevelID = @newLevelID,
                           TileID = @newTileID,
                           TileCount = @tileCount
                       WHERE LevelID = @originalLevelID AND TileID = @originalTileID";

                // Create a dictionary of parameters to pass to the DBHelper method, mapping the parameter names in the SQL query to the actual values from the form controls and the original selected row.
                var parameters = new Dictionary<string, object>
                {
                    {"@newLevelID", newLevelID},
                    {"@newTileID", newTileID},
                    {"@tileCount", tileCount},
                    {"@originalLevelID", originalLevelID},
                    {"@originalTileID", originalTileID}
                };

                int rows = DBHelper.ExecuteNonQuery(sql, parameters);

                lbMessage.Text = rows > 0 ? "Updated!" : "Update failed."; // If the number of rows affected is greater than 0, it's successful, otherwise it failed.

                LoadData();
            }
        }


        //This method is called when a cell in the DataGridView is clicked. It populates the form controls (combo boxes and numeric up-down) with the values from the selected row,
        //allowing the user to see the current values and make changes if they want to update the record.
        private void dgvLevelTilesManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLevelTilesManager.Rows[e.RowIndex];

                cmbLevelNameID.SelectedValue = Convert.ToInt32(row.Cells["LevelID"].Value);
                cmbTileNameID.SelectedValue = Convert.ToInt32(row.Cells["TileID"].Value);
                numTileCount.Value = Convert.ToInt32(row.Cells["TileCount"].Value);
            }
        }


    }
}

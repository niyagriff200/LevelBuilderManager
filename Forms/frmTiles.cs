using LevelBuilderManager.Classes;
using LevelBuilderManager.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LevelBuilderManager
{
    public partial class frmTiles : Form
    {
        //So I can return to the main menu when I close this form
        private frmMainMenu frmOriginal;

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

            string sql = @"INSERT INTO Tiles (Name, Type, [Can Be Walked On])
                   VALUES (@name, @type, @canBeWalkedOn)"; // SQL query to insert a new tile into the Tiles table, using parameters to prevent SQL injection

            var parameters = new Dictionary<string, object> // Create parameters for the SQL query, using the properties of the GameAssetTile object
            {
                {"@name", tile.AssetName},
                {"@type", tile.Type},
                {"@canBeWalkedOn", tile.CanBeWalkedOn}
            };

            int rows = DBHelper.ExecuteNonQuery(sql, parameters); // Execute the insert query and get the number of affected rows to determine if the insert was successful

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
            GameAssetTile tile = RowToTile(dgvTilesManager.SelectedRows[0]); // Convert the selected row to a GameAssetTile object to get the ID for deletion

            string sql = "DELETE FROM Tiles WHERE Id = @id";

            var parameters = new Dictionary<string, object> // Create parameters for the SQL query, using the ID of the selected tile
            {
                {"@id", tile.AssetID}
            };

            int rows = DBHelper.ExecuteNonQuery(sql, parameters); // Execute the delete query and get the number of affected rows

            if (rows > 0) // If at least one row was affected, the delete was successful
                lbMessage.Text = "Tile deleted.";
            else
                lbMessage.Text = "Delete failed.";

            LoadData(); // Refresh the DataGridView to reflect the changes in the database
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

        // This method converts a DataGridViewRow into a GameAssetTile object,
        // which is useful for operations like delete where we need the ID and other properties of the tile.
        private GameAssetTile RowToTile(DataGridViewRow row)
        {
            return new GameAssetTile(
                Convert.ToInt32(row.Cells["Id"].Value),
                row.Cells["Name"].Value.ToString(),
                row.Cells["Type"].Value.ToString(),
                Convert.ToBoolean(row.Cells["Can Be Walked On"].Value)
            );
        }

        private void btnUpdateTile_Click(object sender, EventArgs e)
        {
            if (dgvTilesManager.SelectedRows.Count == 0)
            {
                lbMessage.Text = "Select a tile to update.";
                return;
            }

            // Convert selected row to object so we know which ID to update
            GameAssetTile tile = RowToTile(dgvTilesManager.SelectedRows[0]);

            // Update object with new form values
            tile.AssetName = txtNameEntry.Text;
            tile.Type = txtTypeEntry.Text;
            tile.CanBeWalkedOn = cbCanBeWalkedOn.Checked;

            string sql = @"UPDATE Tiles
                   SET Name = @name,
                       Type = @type,
                       [Can Be Walked On] = @canBeWalkedOn
                   WHERE Id = @id";

            var parameters = new Dictionary<string, object>
            {
                {"@id", tile.AssetID},
                {"@name", tile.AssetName},
                {"@type", tile.Type},
                {"@canBeWalkedOn", tile.CanBeWalkedOn}
            };

            int rows = DBHelper.ExecuteNonQuery(sql, parameters);

            lbMessage.Text = rows > 0 ? "Tile updated!" : "Update failed."; //if at least one row was affected, the update was successful, else it failed

            LoadData();
        }
    }
    
}

using LevelBuilderManager.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LevelBuilderManager.Data
{
    public class LevelManagerRepo
    {
        public int Delete(int id)
        {
            // Implementation for deleting a level or tile from the database using the provided ID
            string sql = "DELETE FROM Levels WHERE Id = @id";

            var parameters = new Dictionary<string, object> // Create parameters for the SQL query, using the ID of the selected level
                {
                    {"@id", id}
                };

            int rows = DBHelper.ExecuteNonQuery(sql, parameters);

            return rows; // Return the number of affected rows to indicate whether the delete was successful
        }

        public int Delete(int LevelID, int TileID)
        {

            string sql = "DELETE FROM LevelTiles WHERE LevelID = @levelID AND TileID = @tileID"; //Construct a SQL query to delete the record from the LevelTiles table where the LevelID and TileID match the selected values.

            //Create a dictionary of parameters to pass to the DBHelper method, mapping the parameter names in the SQL query to the actual values from the selected row.
            var parameters = new Dictionary<string, object>
            {
                {"@levelID", LevelID},
                {"@tileID", TileID}
            };

            int rows = DBHelper.ExecuteNonQuery(sql, parameters);

            return rows;
        }

        public DataTable GetAll()
        {
            // Implementation for retrieving all levels from the database and returning them as a DataTable
            string sql = "SELECT * FROM Levels";

            // Call the DBHelper method to execute the SQL query and return the results as a DataTable, passing an empty dictionary for parameters since there are no parameters in this query.
            return DBHelper.ExecuteRead(sql, new Dictionary<string, object>());
        }

        public int AddLevel(GameAssetLevel gameAssetLevel)
        {
            GameAssetLevel level = gameAssetLevel; // Assign the input GameAssetLevel object to a local variable for easier reference
            string sql = @"INSERT INTO Levels (Name, Theme, Difficulty, [Enemy Count])
                   VALUES (@name, @theme, @difficulty, @enemyCount)"; // SQL query to insert a new level into the Levels table, using parameters to prevent SQL injection

            var parameters = new Dictionary<string, object> // Create parameters for the SQL query, using the properties of the GameAssetLevel object
            {
                {"@name", level.AssetName},
                {"@theme", level.Theme},
                {"@difficulty", level.Difficulty},
                {"@enemyCount", level.EnemyCount}
            };

            int rows = DBHelper.ExecuteNonQuery(sql, parameters); // Execute the insert query and get the number of affected rows to determine if the insert was successful
            return rows; // Return the number of affected rows to indicate whether the insert was successful
        }

        public int AddTile(GameAssetTile gameAssetTile)
        {
            GameAssetTile tile = gameAssetTile; // Assign the input GameAssetTile object to a local variable for easier reference

            string sql = @"INSERT INTO Tiles (Name, Type, [Can Be Walked On])
                   VALUES (@name, @type, @canBeWalkedOn)"; // SQL query to insert a new tile into the Tiles table, using parameters to prevent SQL injection

            var parameters = new Dictionary<string, object> // Create parameters for the SQL query, using the properties of the GameAssetTile object
            {
                {"@name", tile.AssetName},
                {"@type", tile.Type},
                {"@canBeWalkedOn", tile.CanBeWalkedOn}
            };

            int rows = DBHelper.ExecuteNonQuery(sql, parameters); // Execute the insert query and get the number of affected rows to determine if the insert was successful
            return rows; // Return the number of affected rows to indicate whether the insert was successful
        }

        public int AddTileToLevel(int levelID, int tileID, int tileCount)
        {
            string sql = @"INSERT INTO LevelTiles (LevelID, TileID, TileCount)
                   VALUES (@levelID, @tileID, @tileCount)"; // SQL query to insert a new record into the LevelTiles table, associating a tile with a level
            var parameters = new Dictionary<string, object> // Create parameters for the SQL query, using the provided levelID and tileID
            {
                {"@levelID", levelID},
                {"@tileID", tileID},
                {"@tileCount", tileCount}
            };
            int rows = DBHelper.ExecuteNonQuery(sql, parameters); // Execute the insert query and get the number of affected rows to determine if the insert was successful
            return rows; // Return the number of affected rows to indicate whether the insert was successful
        }

        public int UpdateLevel(GameAssetLevel gameAssetLevel)
        {
            GameAssetLevel level = gameAssetLevel; // Assign the input GameAssetLevel object to a local variable for easier reference
            string sql = @"UPDATE Levels
                       SET Name = @name,
                           Theme = @theme,
                           Difficulty = @difficulty,
                           [Enemy Count] = @enemyCount
                       WHERE Id = @id";

            var parameters = new Dictionary<string, object>
                {
                    {"@id", level.AssetID},
                    {"@name", level.AssetName},
                    {"@theme", level.Theme},
                    {"@difficulty", level.Difficulty},
                    {"@enemyCount", level.EnemyCount}
                };

            int rows = DBHelper.ExecuteNonQuery(sql, parameters);
            return rows; // Return the number of affected rows to indicate whether the update was successful
        }

        public int UpdateTile(GameAssetTile gameAssetTile)
        {
            GameAssetTile tile = gameAssetTile; // Assign the input GameAssetTile object to a local variable for easier reference
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
            return rows; // Return the number of affected rows to indicate whether the update was successful
        }

        public int UpdateLevelTile(int originalLevelID, int originalTileID, int newLevelID, int newTileID, int tileCount)
        {
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
            return rows; // Return the number of affected rows to indicate whether the update was successful
        }

        public GameAssetTile RowToTile(DataGridViewRow row)
        {
            return new GameAssetTile(
                Convert.ToInt32(row.Cells["Id"].Value),
                row.Cells["Name"].Value.ToString(),
                row.Cells["Type"].Value.ToString(),
                Convert.ToBoolean(row.Cells["Can Be Walked On"].Value)
            );
        }


        public GameAssetLevel RowToLevel(DataGridViewRow row)
        {
            return new GameAssetLevel(
                Convert.ToInt32(row.Cells["Id"].Value),
                row.Cells["Name"].Value.ToString(),
                Convert.ToInt32(row.Cells["Difficulty"].Value),
                row.Cells["Theme"].Value.ToString(),
                Convert.ToInt32(row.Cells["Enemy Count"].Value)
            );
        }
    }
}

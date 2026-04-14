using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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

        private void frmLevelTiles_Load(object sender, EventArgs e)
        {
            string connLevelTiles = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = LevelTilesDatabase; Integrated Security = True; " +
                "Connect Timeout = 30; Encrypt = True; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False; Command Timeout = 30;";

            using SqlConnection sqlLevelTilesConn = new SqlConnection(connLevelTiles);
            {
                //Open the connection to the database
                sqlLevelTilesConn.Open();

                //Query to select all records from the LevelTiles table
                string sqlLevelTilesQuery = "SELECT * FROM LevelTiles";

                // Create a SqlDataAdapter to execute the query and fill a DataTable
                SqlDataAdapter sqlLevelTileAdapter = new SqlDataAdapter(sqlLevelTilesQuery, sqlLevelTilesConn);

                //Fill a DataTable with the results of the query
                DataTable dtLevelTiles = new DataTable();
                sqlLevelTileAdapter.Fill(dtLevelTiles);

                //Bind the DataTable to the DataGridView to display the tiles
                dgvLevelTilesManager.DataSource = dtLevelTiles;
            }
        }
    }
}

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

        private void frmTiles_Load(object sender, EventArgs e)
        {
            string connTiles = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = TilesDatabase; Integrated Security = True; " +
                "Connect Timeout = 30; Encrypt = True; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False; Command Timeout = 30;";

            using SqlConnection sqlTilesConn = new SqlConnection(connTiles);
            {
                //Open the connection to the database
                sqlTilesConn.Open();

                //Query to select all records from the Tiles table
                string sqlTilesQuery = "SELECT * FROM Tiles";

                // Create a SqlDataAdapter to execute the query and fill a DataTable
                SqlDataAdapter sqlTileAdapter = new SqlDataAdapter(sqlTilesQuery, sqlTilesConn);

                //Fill a DataTable with the results of the query
                DataTable dtTiles = new DataTable();
                sqlTileAdapter.Fill(dtTiles);

                //Bind the DataTable to the DataGridView to display the tiles
                dgvTilesManager.DataSource = dtTiles;
            }
        }
    }
}

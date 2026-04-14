using Microsoft.Data.SqlClient;
using System.Data;

namespace LevelBuilderManager
{
    public partial class frmLevels : Form
    {
        //So I can return to the main menu when I close this form
        private frmMainMenu frmOriginal;

        public frmLevels()
        {
            InitializeComponent();
        }

        public frmLevels(frmMainMenu mainMenuObj)
        {
            InitializeComponent();
            frmOriginal = mainMenuObj;
        }

        /*private void frmLevels_FormClosed(object sender, FormClosedEventArgs e)
        {
            //When this form is closed, show the main menu again
            frmOriginal.Show();
        }*/

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //When the return button is clicked, close this form (which will trigger the FormClosed event and show the main menu)
            frmOriginal.Show();
            this.Close();
        }

        private void frmLevels_Load(object sender, EventArgs e)
        {
            string connLevels = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = LevelsDatabase; Integrated Security = True; " +
                "Connect Timeout = 30; Encrypt = True; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False; Command Timeout = 30;";

            using SqlConnection sqlLevelsConn = new SqlConnection(connLevels);
            {
                //Open the connection to the database
                sqlLevelsConn.Open();

                //Query to select all records from the Levels table
                string sqlLevelsQuery = "SELECT * FROM Levels";

                // Create a SqlDataAdapter to execute the query and fill a DataTable
                SqlDataAdapter sqlLevelAdapter = new SqlDataAdapter(sqlLevelsQuery, sqlLevelsConn);

                //Fill a DataTable with the results of the query
                DataTable dtLevels = new DataTable();
                sqlLevelAdapter.Fill(dtLevels);

                //Bind the DataTable to the DataGridView to display the levels
                dgvLevelsManager.DataSource = dtLevels;
            }
        }
    }
}

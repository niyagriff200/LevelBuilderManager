using System.Diagnostics;
using Microsoft.Data.SqlClient;
using LevelBuilderManager.Data;
using System.Data;


namespace LevelBuilderManager
{
    public partial class frmPerformanceTest : Form
    {
        //So I can return to the main menu when I close this form
        private frmMainMenu frmOriginal;

        public frmPerformanceTest()
        {
            InitializeComponent();
        }

        public frmPerformanceTest(frmMainMenu mainMenuObj)
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

        private void frmPerformanceTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            //When the form is closing, show the main menu again
            frmOriginal.Show();
        }

        private void btnTestDataTable_Click(object sender, EventArgs e)
        {
            // Start timing
            Stopwatch sw = new Stopwatch();
            sw.Start();

            // Load using DBHelper (DataTable)
            DataTable result = DBHelper.ExecuteRead("SELECT * FROM Levels", null);

            // Stop timing
            sw.Stop();

            lbDataTableResult.Text = $"DataTable Load Time: {sw.ElapsedMilliseconds} ms";
        }

        private void btnTestReaderLoad_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            string connString = DBHelper.GetConnection().ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string sql = "SELECT * FROM Levels";
                SqlCommand cmd = new SqlCommand(sql, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Accessing the fields is enough to simulate real work | using var in place of object since we don't care about the actual types here
                        var id = reader["Id"];
                        var name = reader["Name"];
                        var theme = reader["Theme"];
                        var difficulty = reader["Difficulty"];
                        var enemyCount = reader["Enemy Count"];
                    }
                }
            }

            sw.Stop();

            lbReaderLoadResult.Text = $"Reader Loop Time: {sw.ElapsedMilliseconds} ms";
        }

    }
}

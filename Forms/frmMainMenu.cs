namespace LevelBuilderManager
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnManageLevels_Click(object sender, EventArgs e)
        {
            // TODO: Open the Manage Levels form
            frmLevels levelsForm = new frmLevels(this);
            levelsForm.Show();
            this.Hide();
        }

        private void btnManageTiles_Click(object sender, EventArgs e)
        {
            //TODO: Open the Manage Tiles form
            frmTiles tilesForm = new frmTiles(this);
            tilesForm.Show(); 
            this.Hide();
        }

        private void btnAssignTtoL_Click(object sender, EventArgs e)
        {
            //TODO: Open the Assign Tiles to Levels form
            frmLevelTiles levelTilesForm = new frmLevelTiles(this);
            levelTilesForm.Show();
            this.Hide();
        }

        private void btnPerformanceTest_Click(object sender, EventArgs e)
        {
            //TODO: Open the Performance Testing form
            frmPerformanceTest performanceTestForm = new frmPerformanceTest(this);
            performanceTestForm.Show();
            this.Hide();
        }
    }
}

using LevelBuilderManager.Forms;

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
            
            frmLevels levelsForm = new frmLevels(this);
            levelsForm.Show();
            this.Hide();
        }

        private void btnManageTiles_Click(object sender, EventArgs e)
        {
            
            frmTiles tilesForm = new frmTiles(this);
            tilesForm.Show();
            this.Hide();
        }

        private void btnAssignTtoL_Click(object sender, EventArgs e)
        {
            
            frmLevelTiles levelTilesForm = new frmLevelTiles(this);
            levelTilesForm.Show();
            this.Hide();
        }

        private void btnPerformanceTest_Click(object sender, EventArgs e)
        {
            
            frmPerformanceTest performanceTestForm = new frmPerformanceTest(this);
            performanceTestForm.Show();
            this.Hide();
        }

        private void btnML_Click(object sender, EventArgs e)
        {

            frmML mlForm = new frmML(this);
            mlForm.Show();
            this.Hide();
        }
    }
}

namespace LevelBuilderManager
{
    partial class frmLevelTiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnReturn = new Button();
            lbTileCount = new Label();
            btnDeleteLevelTile = new Button();
            btnAddLevelTile = new Button();
            lbTileNameID = new Label();
            lbLevelNameID = new Label();
            dgvLevelTilesManager = new DataGridView();
            numTileCount = new NumericUpDown();
            cmbLevelNameID = new ComboBox();
            cmbTileNameID = new ComboBox();
            lbMessage = new Label();
            btnUpdateLevelTile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLevelTilesManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTileCount).BeginInit();
            SuspendLayout();
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(24, 29);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(240, 58);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Return to Menu";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // lbTileCount
            // 
            lbTileCount.AutoSize = true;
            lbTileCount.Location = new Point(26, 454);
            lbTileCount.Name = "lbTileCount";
            lbTileCount.Size = new Size(153, 41);
            lbTileCount.TabIndex = 29;
            lbTileCount.Text = "Tile Count";
            // 
            // btnDeleteLevelTile
            // 
            btnDeleteLevelTile.Location = new Point(252, 611);
            btnDeleteLevelTile.Name = "btnDeleteLevelTile";
            btnDeleteLevelTile.Size = new Size(251, 58);
            btnDeleteLevelTile.TabIndex = 27;
            btnDeleteLevelTile.Text = "Delete Level Tile";
            btnDeleteLevelTile.UseVisualStyleBackColor = true;
            btnDeleteLevelTile.Click += btnDeleteLevelTile_Click;
            // 
            // btnAddLevelTile
            // 
            btnAddLevelTile.Location = new Point(12, 611);
            btnAddLevelTile.Name = "btnAddLevelTile";
            btnAddLevelTile.Size = new Size(240, 58);
            btnAddLevelTile.TabIndex = 26;
            btnAddLevelTile.Text = "Add Level Tiles";
            btnAddLevelTile.UseVisualStyleBackColor = true;
            btnAddLevelTile.Click += btnAddLevelTile_Click;
            // 
            // lbTileNameID
            // 
            lbTileNameID.AutoSize = true;
            lbTileNameID.Location = new Point(26, 295);
            lbTileNameID.Name = "lbTileNameID";
            lbTileNameID.Size = new Size(151, 41);
            lbTileNameID.TabIndex = 25;
            lbTileNameID.Text = "Tile Name";
            // 
            // lbLevelNameID
            // 
            lbLevelNameID.AutoSize = true;
            lbLevelNameID.Location = new Point(26, 146);
            lbLevelNameID.Name = "lbLevelNameID";
            lbLevelNameID.Size = new Size(172, 41);
            lbLevelNameID.TabIndex = 24;
            lbLevelNameID.Text = "Level Name";
            // 
            // dgvLevelTilesManager
            // 
            dgvLevelTilesManager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLevelTilesManager.Location = new Point(585, 82);
            dgvLevelTilesManager.Name = "dgvLevelTilesManager";
            dgvLevelTilesManager.RowHeadersWidth = 102;
            dgvLevelTilesManager.Size = new Size(1080, 703);
            dgvLevelTilesManager.TabIndex = 21;
            dgvLevelTilesManager.CellClick += dgvLevelTilesManager_CellClick;
            // 
            // numTileCount
            // 
            numTileCount.Location = new Point(26, 524);
            numTileCount.Name = "numTileCount";
            numTileCount.Size = new Size(300, 47);
            numTileCount.TabIndex = 30;
            // 
            // cmbLevelNameID
            // 
            cmbLevelNameID.FormattingEnabled = true;
            cmbLevelNameID.Location = new Point(24, 202);
            cmbLevelNameID.Name = "cmbLevelNameID";
            cmbLevelNameID.Size = new Size(302, 49);
            cmbLevelNameID.TabIndex = 31;
            // 
            // cmbTileNameID
            // 
            cmbTileNameID.FormattingEnabled = true;
            cmbTileNameID.Location = new Point(24, 359);
            cmbTileNameID.Name = "cmbTileNameID";
            cmbTileNameID.Size = new Size(302, 49);
            cmbTileNameID.TabIndex = 32;
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.Location = new Point(264, 684);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(0, 41);
            lbMessage.TabIndex = 33;
            // 
            // btnUpdateLevelTile
            // 
            btnUpdateLevelTile.Location = new Point(12, 675);
            btnUpdateLevelTile.Name = "btnUpdateLevelTile";
            btnUpdateLevelTile.Size = new Size(240, 58);
            btnUpdateLevelTile.TabIndex = 34;
            btnUpdateLevelTile.Text = "Update Level Tiles";
            btnUpdateLevelTile.UseVisualStyleBackColor = true;
            btnUpdateLevelTile.Click += btnUpdateLevelTile_Click;
            // 
            // frmLevelTiles
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1677, 798);
            Controls.Add(btnUpdateLevelTile);
            Controls.Add(lbMessage);
            Controls.Add(cmbTileNameID);
            Controls.Add(cmbLevelNameID);
            Controls.Add(numTileCount);
            Controls.Add(lbTileCount);
            Controls.Add(btnDeleteLevelTile);
            Controls.Add(btnAddLevelTile);
            Controls.Add(lbTileNameID);
            Controls.Add(lbLevelNameID);
            Controls.Add(dgvLevelTilesManager);
            Controls.Add(btnReturn);
            Name = "frmLevelTiles";
            Text = "Level Builder Manager - Level Tiles";
            FormClosing += frmLevelTiles_FormClosing;
            Load += frmLevelTiles_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLevelTilesManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTileCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReturn;
        private Label lbTileCount;
        private CheckBox cbCanBeWalkedOn;
        private Button btnDeleteLevelTile;
        private Button btnAddLevelTile;
        private Label lbTileNameID;
        private Label lbLevelNameID;
        private TextBox txtTypeEntry;
        private DataGridView dgvLevelTilesManager;
        private NumericUpDown numTileCount;
        private ComboBox cmbLevelNameID;
        private ComboBox cmbTileNameID;
        private Label lbMessage;
        private Button btnUpdateLevelTile;
    }
}
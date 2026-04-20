namespace LevelBuilderManager
{
    partial class frmLevels
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
            dgvLevelsManager = new DataGridView();
            txtNameEntry = new TextBox();
            txtThemeEntry = new TextBox();
            numDifficultyEntry = new NumericUpDown();
            lbName = new Label();
            lbTheme = new Label();
            lbDifficulty = new Label();
            btnAddLevel = new Button();
            btnDeleteLevel = new Button();
            lbMessage = new Label();
            numEnemyCount = new NumericUpDown();
            lbEnemyCount = new Label();
            btnUpdateLevel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLevelsManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDifficultyEntry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEnemyCount).BeginInit();
            SuspendLayout();
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(12, 12);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(246, 58);
            btnReturn.TabIndex = 0;
            btnReturn.Text = "Return to Menu";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // dgvLevelsManager
            // 
            dgvLevelsManager.AllowUserToAddRows = false;
            dgvLevelsManager.AllowUserToDeleteRows = false;
            dgvLevelsManager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLevelsManager.Location = new Point(610, 114);
            dgvLevelsManager.MultiSelect = false;
            dgvLevelsManager.Name = "dgvLevelsManager";
            dgvLevelsManager.ReadOnly = true;
            dgvLevelsManager.RowHeadersWidth = 102;
            dgvLevelsManager.Size = new Size(1233, 703);
            dgvLevelsManager.TabIndex = 1;
            dgvLevelsManager.CellClick += dgvLevelsManager_CellClick;
            // 
            // txtNameEntry
            // 
            txtNameEntry.Location = new Point(31, 167);
            txtNameEntry.Name = "txtNameEntry";
            txtNameEntry.Size = new Size(250, 47);
            txtNameEntry.TabIndex = 2;
            // 
            // txtThemeEntry
            // 
            txtThemeEntry.Location = new Point(31, 291);
            txtThemeEntry.Name = "txtThemeEntry";
            txtThemeEntry.Size = new Size(250, 47);
            txtThemeEntry.TabIndex = 3;
            // 
            // numDifficultyEntry
            // 
            numDifficultyEntry.Location = new Point(31, 430);
            numDifficultyEntry.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numDifficultyEntry.Name = "numDifficultyEntry";
            numDifficultyEntry.Size = new Size(300, 47);
            numDifficultyEntry.TabIndex = 4;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(31, 114);
            lbName.Name = "lbName";
            lbName.Size = new Size(97, 41);
            lbName.TabIndex = 5;
            lbName.Text = "Name";
            // 
            // lbTheme
            // 
            lbTheme.AutoSize = true;
            lbTheme.Location = new Point(31, 235);
            lbTheme.Name = "lbTheme";
            lbTheme.Size = new Size(109, 41);
            lbTheme.TabIndex = 6;
            lbTheme.Text = "Theme";
            // 
            // lbDifficulty
            // 
            lbDifficulty.AutoSize = true;
            lbDifficulty.Location = new Point(31, 367);
            lbDifficulty.Name = "lbDifficulty";
            lbDifficulty.Size = new Size(134, 41);
            lbDifficulty.TabIndex = 7;
            lbDifficulty.Text = "Difficulty";
            // 
            // btnAddLevel
            // 
            btnAddLevel.Location = new Point(12, 651);
            btnAddLevel.Name = "btnAddLevel";
            btnAddLevel.Size = new Size(189, 58);
            btnAddLevel.TabIndex = 8;
            btnAddLevel.Text = "Add Level";
            btnAddLevel.UseVisualStyleBackColor = true;
            btnAddLevel.Click += btnAddLevel_Click;
            // 
            // btnDeleteLevel
            // 
            btnDeleteLevel.Location = new Point(207, 651);
            btnDeleteLevel.Name = "btnDeleteLevel";
            btnDeleteLevel.Size = new Size(189, 58);
            btnDeleteLevel.TabIndex = 9;
            btnDeleteLevel.Text = "Delete Level";
            btnDeleteLevel.UseVisualStyleBackColor = true;
            btnDeleteLevel.Click += btnDeleteLevel_Click;
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.Location = new Point(258, 724);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(0, 41);
            lbMessage.TabIndex = 10;
            // 
            // numEnemyCount
            // 
            numEnemyCount.Location = new Point(31, 571);
            numEnemyCount.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numEnemyCount.Name = "numEnemyCount";
            numEnemyCount.Size = new Size(300, 47);
            numEnemyCount.TabIndex = 11;
            // 
            // lbEnemyCount
            // 
            lbEnemyCount.AutoSize = true;
            lbEnemyCount.Location = new Point(31, 510);
            lbEnemyCount.Name = "lbEnemyCount";
            lbEnemyCount.Size = new Size(196, 41);
            lbEnemyCount.TabIndex = 12;
            lbEnemyCount.Text = "Enemy Count";
            // 
            // btnUpdateLevel
            // 
            btnUpdateLevel.Location = new Point(12, 715);
            btnUpdateLevel.Name = "btnUpdateLevel";
            btnUpdateLevel.Size = new Size(207, 58);
            btnUpdateLevel.TabIndex = 13;
            btnUpdateLevel.Text = "Update Level";
            btnUpdateLevel.UseVisualStyleBackColor = true;
            btnUpdateLevel.Click += btnUpdateLevel_Click;
            // 
            // frmLevels
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1855, 829);
            Controls.Add(btnUpdateLevel);
            Controls.Add(lbEnemyCount);
            Controls.Add(numEnemyCount);
            Controls.Add(lbMessage);
            Controls.Add(btnDeleteLevel);
            Controls.Add(btnAddLevel);
            Controls.Add(lbDifficulty);
            Controls.Add(lbTheme);
            Controls.Add(lbName);
            Controls.Add(numDifficultyEntry);
            Controls.Add(txtThemeEntry);
            Controls.Add(txtNameEntry);
            Controls.Add(dgvLevelsManager);
            Controls.Add(btnReturn);
            Name = "frmLevels";
            Text = "Level Builder Manager - Levels";
            FormClosing += frmLevels_FormClosing;
            Load += frmLevels_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLevelsManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDifficultyEntry).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEnemyCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReturn;
        private DataGridView dgvLevelsManager;
        private TextBox txtNameEntry;
        private TextBox txtThemeEntry;
        private NumericUpDown numDifficultyEntry;
        private Label lbName;
        private Label lbTheme;
        private Label lbDifficulty;
        private Button btnAddLevel;
        private Button btnDeleteLevel;
        private Label lbMessage;
        private NumericUpDown numEnemyCount;
        private Label lbEnemyCount;
        private Button btnUpdateLevel;
    }
}
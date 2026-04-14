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
            ((System.ComponentModel.ISupportInitialize)dgvLevelsManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDifficultyEntry).BeginInit();
            SuspendLayout();
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(35, 50);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(246, 58);
            btnReturn.TabIndex = 0;
            btnReturn.Text = "Return to Menu";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // dgvLevelsManager
            // 
            dgvLevelsManager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLevelsManager.Location = new Point(550, 114);
            dgvLevelsManager.Name = "dgvLevelsManager";
            dgvLevelsManager.RowHeadersWidth = 102;
            dgvLevelsManager.Size = new Size(1080, 703);
            dgvLevelsManager.TabIndex = 1;
            // 
            // txtNameEntry
            // 
            txtNameEntry.Location = new Point(31, 234);
            txtNameEntry.Name = "txtNameEntry";
            txtNameEntry.Size = new Size(250, 47);
            txtNameEntry.TabIndex = 2;
            // 
            // txtThemeEntry
            // 
            txtThemeEntry.Location = new Point(31, 368);
            txtThemeEntry.Name = "txtThemeEntry";
            txtThemeEntry.Size = new Size(250, 47);
            txtThemeEntry.TabIndex = 3;
            // 
            // numDifficultyEntry
            // 
            numDifficultyEntry.Location = new Point(31, 495);
            numDifficultyEntry.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numDifficultyEntry.Name = "numDifficultyEntry";
            numDifficultyEntry.Size = new Size(300, 47);
            numDifficultyEntry.TabIndex = 4;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(35, 179);
            lbName.Name = "lbName";
            lbName.Size = new Size(97, 41);
            lbName.TabIndex = 5;
            lbName.Text = "Name";
            // 
            // lbTheme
            // 
            lbTheme.AutoSize = true;
            lbTheme.Location = new Point(35, 309);
            lbTheme.Name = "lbTheme";
            lbTheme.Size = new Size(109, 41);
            lbTheme.TabIndex = 6;
            lbTheme.Text = "Theme";
            // 
            // lbDifficulty
            // 
            lbDifficulty.AutoSize = true;
            lbDifficulty.Location = new Point(35, 434);
            lbDifficulty.Name = "lbDifficulty";
            lbDifficulty.Size = new Size(134, 41);
            lbDifficulty.TabIndex = 7;
            lbDifficulty.Text = "Difficulty";
            // 
            // btnAddLevel
            // 
            btnAddLevel.Location = new Point(35, 614);
            btnAddLevel.Name = "btnAddLevel";
            btnAddLevel.Size = new Size(189, 58);
            btnAddLevel.TabIndex = 8;
            btnAddLevel.Text = "Add Level";
            btnAddLevel.UseVisualStyleBackColor = true;
            // 
            // btnDeleteLevel
            // 
            btnDeleteLevel.Location = new Point(35, 713);
            btnDeleteLevel.Name = "btnDeleteLevel";
            btnDeleteLevel.Size = new Size(189, 58);
            btnDeleteLevel.TabIndex = 9;
            btnDeleteLevel.Text = "Delete Level";
            btnDeleteLevel.UseVisualStyleBackColor = true;
            // 
            // frmLevels
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1642, 829);
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
            Load += frmLevels_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLevelsManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDifficultyEntry).EndInit();
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
    }
}
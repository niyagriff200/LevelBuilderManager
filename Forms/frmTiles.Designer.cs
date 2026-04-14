namespace LevelBuilderManager
{
    partial class frmTiles
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
            btnDeleteTile = new Button();
            btnAddTile = new Button();
            lbType = new Label();
            lbName = new Label();
            txtTypeEntry = new TextBox();
            txtNameEntry = new TextBox();
            dgvTilesManager = new DataGridView();
            cbCanBeWalkedOn = new CheckBox();
            lbCanBeWalkedOn = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTilesManager).BeginInit();
            SuspendLayout();
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(12, 12);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(240, 58);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Return to Menu";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnDeleteTile
            // 
            btnDeleteTile.Location = new Point(240, 665);
            btnDeleteTile.Name = "btnDeleteTile";
            btnDeleteTile.Size = new Size(189, 58);
            btnDeleteTile.TabIndex = 18;
            btnDeleteTile.Text = "Delete Tile";
            btnDeleteTile.UseVisualStyleBackColor = true;
            // 
            // btnAddTile
            // 
            btnAddTile.Location = new Point(12, 665);
            btnAddTile.Name = "btnAddTile";
            btnAddTile.Size = new Size(189, 58);
            btnAddTile.TabIndex = 17;
            btnAddTile.Text = "Add Tile";
            btnAddTile.UseVisualStyleBackColor = true;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new Point(25, 322);
            lbType.Name = "lbType";
            lbType.Size = new Size(81, 41);
            lbType.TabIndex = 15;
            lbType.Text = "Type";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(25, 140);
            lbName.Name = "lbName";
            lbName.Size = new Size(97, 41);
            lbName.TabIndex = 14;
            lbName.Text = "Name";
            // 
            // txtTypeEntry
            // 
            txtTypeEntry.Location = new Point(25, 400);
            txtTypeEntry.Name = "txtTypeEntry";
            txtTypeEntry.Size = new Size(250, 47);
            txtTypeEntry.TabIndex = 12;
            // 
            // txtNameEntry
            // 
            txtNameEntry.Location = new Point(25, 227);
            txtNameEntry.Name = "txtNameEntry";
            txtNameEntry.Size = new Size(250, 47);
            txtNameEntry.TabIndex = 11;
            // 
            // dgvTilesManager
            // 
            dgvTilesManager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTilesManager.Location = new Point(584, 109);
            dgvTilesManager.Name = "dgvTilesManager";
            dgvTilesManager.RowHeadersWidth = 102;
            dgvTilesManager.Size = new Size(1080, 703);
            dgvTilesManager.TabIndex = 10;
            // 
            // cbCanBeWalkedOn
            // 
            cbCanBeWalkedOn.AutoSize = true;
            cbCanBeWalkedOn.Checked = true;
            cbCanBeWalkedOn.CheckState = CheckState.Checked;
            cbCanBeWalkedOn.Location = new Point(25, 544);
            cbCanBeWalkedOn.Name = "cbCanBeWalkedOn";
            cbCanBeWalkedOn.Size = new Size(112, 45);
            cbCanBeWalkedOn.TabIndex = 19;
            cbCanBeWalkedOn.Text = "True";
            cbCanBeWalkedOn.UseVisualStyleBackColor = true;
            // 
            // lbCanBeWalkedOn
            // 
            lbCanBeWalkedOn.AutoSize = true;
            lbCanBeWalkedOn.Location = new Point(25, 481);
            lbCanBeWalkedOn.Name = "lbCanBeWalkedOn";
            lbCanBeWalkedOn.Size = new Size(264, 41);
            lbCanBeWalkedOn.TabIndex = 20;
            lbCanBeWalkedOn.Text = "Can Be Walked On";
            // 
            // frmTiles
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1676, 880);
            Controls.Add(lbCanBeWalkedOn);
            Controls.Add(cbCanBeWalkedOn);
            Controls.Add(btnDeleteTile);
            Controls.Add(btnAddTile);
            Controls.Add(lbType);
            Controls.Add(lbName);
            Controls.Add(txtTypeEntry);
            Controls.Add(txtNameEntry);
            Controls.Add(dgvTilesManager);
            Controls.Add(btnReturn);
            Name = "frmTiles";
            Text = "Level Builder Manager - Tiles";
            FormClosing += frmTiles_FormClosing;
            Load += frmTiles_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTilesManager).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReturn;
        private Button btnDeleteTile;
        private Button btnAddTile;
        private Label lbType;
        private Label lbName;
        private TextBox txtTypeEntry;
        private TextBox txtNameEntry;
        private DataGridView dgvTilesManager;
        private CheckBox cbCanBeWalkedOn;
        private Label lbCanBeWalkedOn;
    }
}
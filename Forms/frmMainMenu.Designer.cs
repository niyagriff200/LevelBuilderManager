namespace LevelBuilderManager
{
    partial class frmMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTitle = new Label();
            btnManageLevels = new Button();
            btnManageTiles = new Button();
            btnAssignTtoL = new Button();
            btnPerformanceTest = new Button();
            btnML = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Black", 20.1F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(258, 74);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(782, 89);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Level Builder Manager";
            // 
            // btnManageLevels
            // 
            btnManageLevels.Location = new Point(476, 247);
            btnManageLevels.Name = "btnManageLevels";
            btnManageLevels.Size = new Size(310, 58);
            btnManageLevels.TabIndex = 1;
            btnManageLevels.Text = "Manage Levels";
            btnManageLevels.UseVisualStyleBackColor = true;
            btnManageLevels.Click += btnManageLevels_Click;
            // 
            // btnManageTiles
            // 
            btnManageTiles.Location = new Point(476, 356);
            btnManageTiles.Name = "btnManageTiles";
            btnManageTiles.Size = new Size(310, 58);
            btnManageTiles.TabIndex = 2;
            btnManageTiles.Text = "Manage Tiles";
            btnManageTiles.UseVisualStyleBackColor = true;
            btnManageTiles.Click += btnManageTiles_Click;
            // 
            // btnAssignTtoL
            // 
            btnAssignTtoL.Location = new Point(476, 473);
            btnAssignTtoL.Name = "btnAssignTtoL";
            btnAssignTtoL.Size = new Size(310, 58);
            btnAssignTtoL.TabIndex = 3;
            btnAssignTtoL.Text = "Assign Tiles to Levels";
            btnAssignTtoL.UseVisualStyleBackColor = true;
            btnAssignTtoL.Click += btnAssignTtoL_Click;
            // 
            // btnPerformanceTest
            // 
            btnPerformanceTest.Location = new Point(476, 570);
            btnPerformanceTest.Name = "btnPerformanceTest";
            btnPerformanceTest.Size = new Size(310, 58);
            btnPerformanceTest.TabIndex = 4;
            btnPerformanceTest.Text = "Performance Testing";
            btnPerformanceTest.UseVisualStyleBackColor = true;
            btnPerformanceTest.Click += btnPerformanceTest_Click;
            // 
            // btnML
            // 
            btnML.Location = new Point(476, 664);
            btnML.Name = "btnML";
            btnML.Size = new Size(310, 58);
            btnML.TabIndex = 5;
            btnML.Text = "Machine Learning";
            btnML.UseVisualStyleBackColor = true;
            btnML.Click += btnML_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 823);
            Controls.Add(btnML);
            Controls.Add(btnPerformanceTest);
            Controls.Add(btnAssignTtoL);
            Controls.Add(btnManageTiles);
            Controls.Add(btnManageLevels);
            Controls.Add(lbTitle);
            Name = "frmMainMenu";
            Text = "Level Builder Manager - Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Button btnManageLevels;
        private Button btnManageTiles;
        private Button btnAssignTtoL;
        private Button btnPerformanceTest;
        private Button btnML;
    }
}

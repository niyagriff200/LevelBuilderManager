namespace LevelBuilderManager
{
    partial class frmPerformanceTest
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
            btnTestDataTable = new Button();
            btnTestReaderLoad = new Button();
            lbDataTableResult = new Label();
            lbReaderLoadResult = new Label();
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
            // btnTestDataTable
            // 
            btnTestDataTable.Location = new Point(55, 179);
            btnTestDataTable.Name = "btnTestDataTable";
            btnTestDataTable.Size = new Size(300, 58);
            btnTestDataTable.TabIndex = 2;
            btnTestDataTable.Text = "Test Data Table Load";
            btnTestDataTable.UseVisualStyleBackColor = true;
            btnTestDataTable.Click += btnTestDataTable_Click;
            // 
            // btnTestReaderLoad
            // 
            btnTestReaderLoad.Location = new Point(554, 179);
            btnTestReaderLoad.Name = "btnTestReaderLoad";
            btnTestReaderLoad.Size = new Size(300, 58);
            btnTestReaderLoad.TabIndex = 3;
            btnTestReaderLoad.Text = "Test Reader Load";
            btnTestReaderLoad.UseVisualStyleBackColor = true;
            btnTestReaderLoad.Click += btnTestReaderLoad_Click;
            // 
            // lbDataTableResult
            // 
            lbDataTableResult.AutoSize = true;
            lbDataTableResult.Location = new Point(55, 257);
            lbDataTableResult.Name = "lbDataTableResult";
            lbDataTableResult.Size = new Size(0, 41);
            lbDataTableResult.TabIndex = 4;
            // 
            // lbReaderLoadResult
            // 
            lbReaderLoadResult.AutoSize = true;
            lbReaderLoadResult.Location = new Point(554, 257);
            lbReaderLoadResult.Name = "lbReaderLoadResult";
            lbReaderLoadResult.Size = new Size(0, 41);
            lbReaderLoadResult.TabIndex = 5;
            // 
            // frmPerformanceTest
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 443);
            Controls.Add(lbReaderLoadResult);
            Controls.Add(lbDataTableResult);
            Controls.Add(btnTestReaderLoad);
            Controls.Add(btnTestDataTable);
            Controls.Add(btnReturn);
            Name = "frmPerformanceTest";
            Text = "Level Builder Manager - Performance Test";
            FormClosing += frmPerformanceTest_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReturn;
        private Button btnTestDataTable;
        private Button btnTestReaderLoad;
        private Label lbDataTableResult;
        private Label lbReaderLoadResult;
    }
}
namespace LevelBuilderManager.Forms
{
    partial class frmML
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
            btnTrainModel = new Button();
            btnReturn = new Button();
            btnPredict = new Button();
            numEnemies = new NumericUpDown();
            numObstacles = new NumericUpDown();
            lbMessage = new Label();
            lbEnemies = new Label();
            lbObstacles = new Label();
            ((System.ComponentModel.ISupportInitialize)numEnemies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numObstacles).BeginInit();
            SuspendLayout();
            // 
            // btnTrainModel
            // 
            btnTrainModel.Location = new Point(30, 122);
            btnTrainModel.Name = "btnTrainModel";
            btnTrainModel.Size = new Size(188, 58);
            btnTrainModel.TabIndex = 0;
            btnTrainModel.Text = "Train Model";
            btnTrainModel.UseVisualStyleBackColor = true;
            btnTrainModel.Click += btnTrainModel_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(12, 12);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(246, 58);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Return to Menu";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnPredict
            // 
            btnPredict.Location = new Point(30, 494);
            btnPredict.Name = "btnPredict";
            btnPredict.Size = new Size(249, 58);
            btnPredict.TabIndex = 2;
            btnPredict.Text = "Predict Difficulty";
            btnPredict.UseVisualStyleBackColor = true;
            btnPredict.Click += btnPredict_Click;
            // 
            // numEnemies
            // 
            numEnemies.Location = new Point(30, 278);
            numEnemies.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numEnemies.Name = "numEnemies";
            numEnemies.Size = new Size(300, 47);
            numEnemies.TabIndex = 3;
            // 
            // numObstacles
            // 
            numObstacles.Location = new Point(30, 406);
            numObstacles.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numObstacles.Name = "numObstacles";
            numObstacles.Size = new Size(300, 47);
            numObstacles.TabIndex = 4;
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.Location = new Point(418, 350);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(0, 41);
            lbMessage.TabIndex = 5;
            // 
            // lbEnemies
            // 
            lbEnemies.AutoSize = true;
            lbEnemies.Location = new Point(30, 220);
            lbEnemies.Name = "lbEnemies";
            lbEnemies.Size = new Size(128, 41);
            lbEnemies.TabIndex = 6;
            lbEnemies.Text = "Enemies";
            // 
            // lbObstacles
            // 
            lbObstacles.AutoSize = true;
            lbObstacles.Location = new Point(30, 350);
            lbObstacles.Name = "lbObstacles";
            lbObstacles.Size = new Size(147, 41);
            lbObstacles.TabIndex = 7;
            lbObstacles.Text = "Obstacles";
            // 
            // frmML
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 638);
            Controls.Add(lbObstacles);
            Controls.Add(lbEnemies);
            Controls.Add(lbMessage);
            Controls.Add(numObstacles);
            Controls.Add(numEnemies);
            Controls.Add(btnPredict);
            Controls.Add(btnReturn);
            Controls.Add(btnTrainModel);
            Name = "frmML";
            Text = "Level Builder Manager - ML Difficulty";
            FormClosing += frmML_FormClosing;
            ((System.ComponentModel.ISupportInitialize)numEnemies).EndInit();
            ((System.ComponentModel.ISupportInitialize)numObstacles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTrainModel;
        private Button btnReturn;
        private Button btnPredict;
        private NumericUpDown numEnemies;
        private NumericUpDown numObstacles;
        private Label lbMessage;
        private Label lbEnemies;
        private Label lbObstacles;
    }
}
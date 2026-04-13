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
            btnReturn.Click += this.btnReturn_Click;
            // 
            // frmLevels
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 766);
            Controls.Add(btnReturn);
            Name = "frmLevels";
            Text = "Level Builder Manager - Levels";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReturn;
    }
}
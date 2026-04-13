using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LevelBuilderManager
{
    public partial class frmLevels : Form
    {
        //So I can return to the main menu when I close this form
        private frmMainMenu frmOriginal;

        public frmLevels()
        {
            InitializeComponent();
        }

        public frmLevels(frmMainMenu mainMenuObj)
        {
            InitializeComponent();
            frmOriginal = mainMenuObj;
        }

        /*private void frmLevels_FormClosed(object sender, FormClosedEventArgs e)
        {
            //When this form is closed, show the main menu again
            frmOriginal.Show();
        }*/

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //When the return button is clicked, close this form (which will trigger the FormClosed event and show the main menu)
            frmOriginal.Show();
            this.Close();
        }
    }
}

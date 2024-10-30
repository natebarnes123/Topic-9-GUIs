using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9_GUIs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (imgCharacter.Visible)
            {
                imgCharacter.Visible = false;
            }
            else
            {
                imgCharacter.Visible = true;
            }
            lblStatus.Text = "Status: Clicked";
        }

        private void imgCharacter_Click(object sender, EventArgs e)
        {
            
        }

        private void imgUnused_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (btnQuit)
        }
    }   
}

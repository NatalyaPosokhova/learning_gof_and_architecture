using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaWarView
{
    public partial class ButtleShip : Form
    {
        public ButtleShip()
        {
            InitializeComponent();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            //public event EventHandler<EventArgs> OnGameStarted;

        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            
            //MessageBox.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MOVABLECONTROL
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public bool ismd = false;

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void UserControl1_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = false;
        }

        private void UserControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == true)
            {
                Left += e.X;
                Top += e.Y;
            }
        }

        private void UserControl1_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = true;
        }
    }
}

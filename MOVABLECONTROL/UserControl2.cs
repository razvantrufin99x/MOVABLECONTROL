using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace movableControl
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        public bool ismd = false;
        public bool selected = false;
        public Form1 f;

        private void UserControl2_Load(object sender, EventArgs e)
        {
            try
            {
                f = (Form1)ParentForm;
            }
            catch { }
        }

        private void UserControl2_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = false;
        }

        private void UserControl2_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == true)
            {
                Left += e.X;
                Top += e.Y;
                f.updatedimension();
            }
        }

        private void UserControl2_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = true;

        }

        
    }
}

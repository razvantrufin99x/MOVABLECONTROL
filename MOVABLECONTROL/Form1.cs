using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace movableControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         public UserControl2 redimbox = new UserControl2();

         public void updateposition()
         {
             redimbox.Left = userControl11.Left + userControl11.Width + 1;
             redimbox.Top = userControl11.Top + userControl11.Height + 1;

             
         }

         public void updatedimension()
         {
             int w = redimbox.Left - userControl11.Left;
             int h = redimbox.Top - userControl11.Top;
             userControl11.Width =  w;
             userControl11.Height =  h;

         }


        private void Form1_Load(object sender, EventArgs e)
        {
            Controls.Add(redimbox);
            redimbox.Visible = true;
            redimbox.Width = 5;
            redimbox.Height = 5;
            updateposition();
        }

       
    }
}

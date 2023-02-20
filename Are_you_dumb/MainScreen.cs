using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Are_you_dumb
{
    // Main Form
    public partial class MainScreen : Form
    {

        YesScreen yesForm;  // Yes form variable
        int yesCount = 0;  // Yes count variable
        Random r = new Random(2);   // Random variable
        public MainScreen()
        {
            InitializeComponent();
        }
        // Handle yes button click
        private void btnYes_Click(object sender, EventArgs e)
        {
            yesForm = new YesScreen();
            yesCount++;
            yesForm.SetText(yesCount);
            yesForm.ShowDialog();
        }
        // Handle no button click
        private void btnNo_Click(object sender, EventArgs e)
        {
            int x = btnNo.Location.X;
            int y = btnNo.Location.Y;
            int w = btnNo.Width;
            int h = btnNo.Height;
            int maxW = btnContainer.Width;
            int maxH = btnContainer.Height;

            if (x - w < 0)
                x += w;
            else if (x + (2 * w) > maxW)
                x -= w;
            else
            {
                int v = r.Next(1000);
                if (v % 2 == 0)
                    x += w;
                else
                    x -= w;
            }

            if (y - h < 0)
                y += h;
            else if (y + (2 * h) > maxH)
                y -= h;
            else
            {
                int v = r.Next(1000);
                if (v % 2 == 0)
                    y += h;
                else
                    y -= h;
            }
            btnNo.Location = new Point(x, y);
        }
    }
}

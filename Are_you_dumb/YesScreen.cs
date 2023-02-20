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
    // Yes Form
    public partial class YesScreen : Form
    {
        public YesScreen()
        {
            InitializeComponent();
        }
        // Public method to set label text
        public void SetText(int count)
        {
            label1.Text = "I Knew It! : " + count.ToString();
        }
    }
}

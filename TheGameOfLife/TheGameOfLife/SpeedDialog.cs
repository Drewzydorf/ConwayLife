using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZielsdorf_Lab02
{
    public delegate void speedDelegate(int speed);
    public delegate void voidDelegate();


    public partial class SpeedDialog : Form
    {
        public speedDelegate speedChanged = null;
        public voidDelegate closeChecker = null;

        public SpeedDialog()
        {
            InitializeComponent();
        }

        private void TBr_speed_Scroll(object sender, EventArgs e)
        {
            if (speedChanged != null)
                speedChanged.Invoke(TBr_speed.Value);
        }

        private void SpeedDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (closeChecker != null)
                closeChecker.Invoke();
        }
    }
}

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
    public partial class Generator : Form
    {
        public Generator()
        {
            InitializeComponent();
            colour = Color.Orange;
        }

        public int density
        {
            get
            {
                return TBr_density.Value;
            }
            set
            {
                TBr_density.Value = value;
            }
        }

        public Color colour { get; set; }

        private void BTn_colour_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colour = colorDialog.Color;
                LBl_colourPreview.BackColor = colour;
            }
        }
    }
}

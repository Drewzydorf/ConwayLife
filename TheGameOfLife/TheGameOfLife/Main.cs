using System;
using System.Windows.Forms;
using GDIDrawer;

namespace AZielsdorf_Lab02
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            canvas.MouseLeftClick += Life.canvas_MouseLeftClick;
        }

        private SpeedDialog speed = new SpeedDialog();
        Generator genDialog = new Generator();
        public CDrawer canvas = new CDrawer(1000, 800, false);

        private void Main_Load(object sender, EventArgs e)
        {
            canvas.Scale = 10;
            Life.InitalLife(canvas);

            speed.speedChanged = new speedDelegate(CallbackSpeedChanged);
            speed.closeChecker = new voidDelegate(CallbackStop);
        }

        private void CallbackSpeedChanged(int speed)
        {
            lifeTimer.Interval = speed;
        }

        private void BTn_start_Click(object sender, EventArgs e)
        {
            lifeTimer.Enabled = true;

            BTn_cycle.Enabled = false;
            BTn_start.Enabled = false;
            BTn_stop.Enabled = true;

            speed.Show();
        }
        private void BTn_stop_Click(object sender, EventArgs e)
        {
            lifeTimer.Enabled = false;

            BTn_cycle.Enabled = true;
            BTn_start.Enabled = true;
            BTn_stop.Enabled = false;

            speed.Hide();
        }
        private void CallbackStop()
        {
            lifeTimer.Enabled = false;

            BTn_cycle.Enabled = true;
            BTn_start.Enabled = true;
            BTn_stop.Enabled = false;

            speed.Hide();
        }

        private void BTn_clear_Click(object sender, EventArgs e)
        {
            Life.ClearLife(canvas);
            Text = Life.cycleCount.ToString();
        }

        private void BTn_cycle_Click(object sender, EventArgs e)
        {
            Life.CycleLife(canvas);
            Text = Life.cycleCount.ToString();
            Life.DisplayLife(canvas);
        }

        private void lifeTimer_Tick(object sender, EventArgs e)
        {
            Life.CycleLife(canvas);
            Text = Life.cycleCount.ToString();
        }

        private void BTn_generate_Click(object sender, EventArgs e)
        {
            if (genDialog.ShowDialog() == DialogResult.OK)
            {
                Life.ClearLife(canvas);

                Life.genCount = genDialog.density;
                Life.cellColour = genDialog.colour;


                Life.CreateLife();
                Life.DisplayLife(canvas);
                Text = Life.cycleCount.ToString();
            }
        }
    }
}

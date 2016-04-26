namespace AZielsdorf_Lab02
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BTn_cycle = new System.Windows.Forms.Button();
            this.BTn_generate = new System.Windows.Forms.Button();
            this.BTn_start = new System.Windows.Forms.Button();
            this.BTn_stop = new System.Windows.Forms.Button();
            this.BTn_clear = new System.Windows.Forms.Button();
            this.lifeTimer = new System.Windows.Forms.Timer(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // BTn_cycle
            // 
            this.BTn_cycle.Location = new System.Drawing.Point(15, 73);
            this.BTn_cycle.Name = "BTn_cycle";
            this.BTn_cycle.Size = new System.Drawing.Size(72, 23);
            this.BTn_cycle.TabIndex = 0;
            this.BTn_cycle.Text = "Cycle";
            this.BTn_cycle.UseVisualStyleBackColor = true;
            this.BTn_cycle.Click += new System.EventHandler(this.BTn_cycle_Click);
            // 
            // BTn_generate
            // 
            this.BTn_generate.Location = new System.Drawing.Point(12, 12);
            this.BTn_generate.Name = "BTn_generate";
            this.BTn_generate.Size = new System.Drawing.Size(156, 23);
            this.BTn_generate.TabIndex = 1;
            this.BTn_generate.Text = "Generate";
            this.BTn_generate.UseVisualStyleBackColor = true;
            this.BTn_generate.Click += new System.EventHandler(this.BTn_generate_Click);
            // 
            // BTn_start
            // 
            this.BTn_start.Location = new System.Drawing.Point(12, 44);
            this.BTn_start.Name = "BTn_start";
            this.BTn_start.Size = new System.Drawing.Size(75, 23);
            this.BTn_start.TabIndex = 2;
            this.BTn_start.Text = "Start";
            this.BTn_start.UseVisualStyleBackColor = true;
            this.BTn_start.Click += new System.EventHandler(this.BTn_start_Click);
            // 
            // BTn_stop
            // 
            this.BTn_stop.Enabled = false;
            this.BTn_stop.Location = new System.Drawing.Point(93, 44);
            this.BTn_stop.Name = "BTn_stop";
            this.BTn_stop.Size = new System.Drawing.Size(75, 23);
            this.BTn_stop.TabIndex = 3;
            this.BTn_stop.Text = "Stop";
            this.BTn_stop.UseVisualStyleBackColor = true;
            this.BTn_stop.Click += new System.EventHandler(this.BTn_stop_Click);
            // 
            // BTn_clear
            // 
            this.BTn_clear.Location = new System.Drawing.Point(93, 73);
            this.BTn_clear.Name = "BTn_clear";
            this.BTn_clear.Size = new System.Drawing.Size(75, 23);
            this.BTn_clear.TabIndex = 5;
            this.BTn_clear.Text = "Clear";
            this.BTn_clear.UseVisualStyleBackColor = true;
            this.BTn_clear.Click += new System.EventHandler(this.BTn_clear_Click);
            // 
            // lifeTimer
            // 
            this.lifeTimer.Tag = "";
            this.lifeTimer.Tick += new System.EventHandler(this.lifeTimer_Tick);
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 112);
            this.Controls.Add(this.BTn_clear);
            this.Controls.Add(this.BTn_stop);
            this.Controls.Add(this.BTn_start);
            this.Controls.Add(this.BTn_generate);
            this.Controls.Add(this.BTn_cycle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Conway\'s Game of Life";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTn_cycle;
        private System.Windows.Forms.Button BTn_generate;
        private System.Windows.Forms.Button BTn_start;
        private System.Windows.Forms.Button BTn_stop;
        private System.Windows.Forms.Button BTn_clear;
        public System.Windows.Forms.Timer lifeTimer;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}


namespace AZielsdorf_Lab02
{
    partial class SpeedDialog
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
            this.TBr_speed = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.TBr_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // TBr_speed
            // 
            this.TBr_speed.Location = new System.Drawing.Point(12, 12);
            this.TBr_speed.Maximum = 250;
            this.TBr_speed.Minimum = 1;
            this.TBr_speed.Name = "TBr_speed";
            this.TBr_speed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TBr_speed.Size = new System.Drawing.Size(237, 45);
            this.TBr_speed.TabIndex = 0;
            this.TBr_speed.TickFrequency = 10;
            this.TBr_speed.Value = 100;
            this.TBr_speed.Scroll += new System.EventHandler(this.TBr_speed_Scroll);
            // 
            // SpeedDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 62);
            this.Controls.Add(this.TBr_speed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpeedDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Speed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpeedDialog_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.TBr_speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TBr_speed;

    }
}
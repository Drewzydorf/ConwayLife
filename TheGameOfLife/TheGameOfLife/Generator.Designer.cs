namespace AZielsdorf_Lab02
{
    partial class Generator
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
            this.TBr_density = new System.Windows.Forms.TrackBar();
            this.BTn_okay = new System.Windows.Forms.Button();
            this.BTn_cancel = new System.Windows.Forms.Button();
            this.LBl_desnity = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.BTn_colour = new System.Windows.Forms.Button();
            this.LBl_cellColour = new System.Windows.Forms.Label();
            this.LBl_colourPreview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TBr_density)).BeginInit();
            this.SuspendLayout();
            // 
            // TBr_density
            // 
            this.TBr_density.Location = new System.Drawing.Point(12, 34);
            this.TBr_density.Maximum = 4800;
            this.TBr_density.Name = "TBr_density";
            this.TBr_density.Size = new System.Drawing.Size(162, 45);
            this.TBr_density.TabIndex = 1;
            this.TBr_density.TickFrequency = 250;
            this.TBr_density.Value = 1000;
            // 
            // BTn_okay
            // 
            this.BTn_okay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTn_okay.Location = new System.Drawing.Point(221, 85);
            this.BTn_okay.Name = "BTn_okay";
            this.BTn_okay.Size = new System.Drawing.Size(75, 23);
            this.BTn_okay.TabIndex = 2;
            this.BTn_okay.Text = "Okay";
            this.BTn_okay.UseVisualStyleBackColor = true;
            // 
            // BTn_cancel
            // 
            this.BTn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTn_cancel.Location = new System.Drawing.Point(18, 85);
            this.BTn_cancel.Name = "BTn_cancel";
            this.BTn_cancel.Size = new System.Drawing.Size(75, 23);
            this.BTn_cancel.TabIndex = 3;
            this.BTn_cancel.Text = "Cancel";
            this.BTn_cancel.UseVisualStyleBackColor = true;
            // 
            // LBl_desnity
            // 
            this.LBl_desnity.AutoSize = true;
            this.LBl_desnity.Location = new System.Drawing.Point(15, 8);
            this.LBl_desnity.Name = "LBl_desnity";
            this.LBl_desnity.Size = new System.Drawing.Size(65, 13);
            this.LBl_desnity.TabIndex = 4;
            this.LBl_desnity.Text = "Cell Desnity:";
            // 
            // BTn_colour
            // 
            this.BTn_colour.Location = new System.Drawing.Point(188, 56);
            this.BTn_colour.Name = "BTn_colour";
            this.BTn_colour.Size = new System.Drawing.Size(108, 23);
            this.BTn_colour.TabIndex = 5;
            this.BTn_colour.Text = "Pick";
            this.BTn_colour.UseVisualStyleBackColor = true;
            this.BTn_colour.Click += new System.EventHandler(this.BTn_colour_Click);
            // 
            // LBl_cellColour
            // 
            this.LBl_cellColour.AutoSize = true;
            this.LBl_cellColour.Location = new System.Drawing.Point(185, 8);
            this.LBl_cellColour.Name = "LBl_cellColour";
            this.LBl_cellColour.Size = new System.Drawing.Size(60, 13);
            this.LBl_cellColour.TabIndex = 6;
            this.LBl_cellColour.Text = "Cell Colour:";
            // 
            // LBl_colourPreview
            // 
            this.LBl_colourPreview.BackColor = System.Drawing.Color.Orange;
            this.LBl_colourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBl_colourPreview.Location = new System.Drawing.Point(188, 24);
            this.LBl_colourPreview.Name = "LBl_colourPreview";
            this.LBl_colourPreview.Size = new System.Drawing.Size(108, 29);
            this.LBl_colourPreview.TabIndex = 7;
            // 
            // Generator
            // 
            this.AcceptButton = this.BTn_okay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTn_cancel;
            this.ClientSize = new System.Drawing.Size(308, 134);
            this.ControlBox = false;
            this.Controls.Add(this.LBl_colourPreview);
            this.Controls.Add(this.LBl_cellColour);
            this.Controls.Add(this.BTn_colour);
            this.Controls.Add(this.LBl_desnity);
            this.Controls.Add(this.BTn_cancel);
            this.Controls.Add(this.BTn_okay);
            this.Controls.Add(this.TBr_density);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Generator";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generator";
            ((System.ComponentModel.ISupportInitialize)(this.TBr_density)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TBr_density;
        private System.Windows.Forms.Button BTn_okay;
        private System.Windows.Forms.Button BTn_cancel;
        private System.Windows.Forms.Label LBl_desnity;
        private System.Windows.Forms.Button BTn_colour;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label LBl_cellColour;
        private System.Windows.Forms.Label LBl_colourPreview;
    }
}
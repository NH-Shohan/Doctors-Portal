namespace DOCTORS_PORTAL
{
    partial class showAllChambersControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameOfChamber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameOfChamber
            // 
            this.nameOfChamber.AutoSize = true;
            this.nameOfChamber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nameOfChamber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameOfChamber.Location = new System.Drawing.Point(14, 10);
            this.nameOfChamber.Name = "nameOfChamber";
            this.nameOfChamber.Size = new System.Drawing.Size(109, 18);
            this.nameOfChamber.TabIndex = 0;
            this.nameOfChamber.Text = "ChamberName";
            this.nameOfChamber.Click += new System.EventHandler(this.nameOfChamber_Click);
            // 
            // showAllChambersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.Controls.Add(this.nameOfChamber);
            this.Name = "showAllChambersControl";
            this.Size = new System.Drawing.Size(235, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameOfChamber;
    }
}

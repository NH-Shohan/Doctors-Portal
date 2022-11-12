
namespace DOCTORS_PORTAL
{
    partial class userSelectDoctorControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userSelectDoctorControl));
            this.doctorsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.showAllChams = new System.Windows.Forms.FlowLayoutPanel();
            this.showAllDocBtn = new Guna.UI.WinForms.GunaButton();
            this.filterBox = new Guna.UI.WinForms.GunaComboBox();
            this.gunaElipsePanel3 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.showDoctorPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NextDocBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.PreviousDocBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.mainPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.labelCham = new System.Windows.Forms.Label();
            this.gunaElipsePanel1.SuspendLayout();
            this.gunaElipsePanel3.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctorsCount
            // 
            this.doctorsCount.AutoSize = true;
            this.doctorsCount.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.doctorsCount.ForeColor = System.Drawing.Color.White;
            this.doctorsCount.Location = new System.Drawing.Point(146, 3);
            this.doctorsCount.Name = "doctorsCount";
            this.doctorsCount.Size = new System.Drawing.Size(20, 23);
            this.doctorsCount.TabIndex = 17;
            this.doctorsCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "TOTAL DOCTORS:";
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.BackColor = System.Drawing.Color.Transparent;
            this.gunaVScrollBar1.LargeChange = 10;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(267, 52);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.Padding = new System.Windows.Forms.Padding(3);
            this.gunaVScrollBar1.Radius = 5;
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(27)))), ((int)(((byte)(151)))));
            this.gunaVScrollBar1.Size = new System.Drawing.Size(8, 327);
            this.gunaVScrollBar1.TabIndex = 18;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(66)))), ((int)(((byte)(225)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "AVAILABLE CHAMBERS";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.gunaElipsePanel1.Controls.Add(this.showAllChams);
            this.gunaElipsePanel1.Controls.Add(this.showAllDocBtn);
            this.gunaElipsePanel1.Controls.Add(this.gunaVScrollBar1);
            this.gunaElipsePanel1.Controls.Add(this.label2);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(40, 80);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(275, 400);
            this.gunaElipsePanel1.TabIndex = 4;
            // 
            // showAllChams
            // 
            this.showAllChams.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.showAllChams.Location = new System.Drawing.Point(23, 99);
            this.showAllChams.Name = "showAllChams";
            this.showAllChams.Size = new System.Drawing.Size(235, 280);
            this.showAllChams.TabIndex = 26;
            // 
            // showAllDocBtn
            // 
            this.showAllDocBtn.AnimationHoverSpeed = 0.07F;
            this.showAllDocBtn.AnimationSpeed = 0.03F;
            this.showAllDocBtn.BackColor = System.Drawing.Color.Transparent;
            this.showAllDocBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.showAllDocBtn.BorderColor = System.Drawing.Color.Black;
            this.showAllDocBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAllDocBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.showAllDocBtn.FocusedColor = System.Drawing.Color.Empty;
            this.showAllDocBtn.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.showAllDocBtn.ForeColor = System.Drawing.Color.White;
            this.showAllDocBtn.Image = null;
            this.showAllDocBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.showAllDocBtn.Location = new System.Drawing.Point(23, 62);
            this.showAllDocBtn.Name = "showAllDocBtn";
            this.showAllDocBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.showAllDocBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.showAllDocBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.showAllDocBtn.OnHoverImage = null;
            this.showAllDocBtn.OnPressedColor = System.Drawing.Color.Black;
            this.showAllDocBtn.Radius = 10;
            this.showAllDocBtn.Size = new System.Drawing.Size(235, 31);
            this.showAllDocBtn.TabIndex = 25;
            this.showAllDocBtn.Text = "All";
            this.showAllDocBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.showAllDocBtn.Click += new System.EventHandler(this.showAllDocBtn_Click);
            // 
            // filterBox
            // 
            this.filterBox.BackColor = System.Drawing.Color.Transparent;
            this.filterBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(27)))), ((int)(((byte)(151)))));
            this.filterBox.BorderColor = System.Drawing.Color.Silver;
            this.filterBox.BorderSize = 0;
            this.filterBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterBox.FocusedColor = System.Drawing.Color.Empty;
            this.filterBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.filterBox.ForeColor = System.Drawing.Color.White;
            this.filterBox.FormattingEnabled = true;
            this.filterBox.Items.AddRange(new object[] {
            "ALL",
            "Medicine",
            "Child Expert",
            "Radiologist",
            "Cardiologist",
            "Gynecologist",
            "Pediatrician",
            "Oncologist",
            "ENT Specialist",
            "Neurosurgeon",
            "Arthritis, Rheumatism, Pain, Paralysis Specialist",
            "Orthopedics Specialist"});
            this.filterBox.Location = new System.Drawing.Point(9, 8);
            this.filterBox.MaxDropDownItems = 10;
            this.filterBox.Name = "filterBox";
            this.filterBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.filterBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.filterBox.Radius = 5;
            this.filterBox.Size = new System.Drawing.Size(200, 28);
            this.filterBox.StartIndex = 0;
            this.filterBox.TabIndex = 4;
            this.filterBox.Tag = "Filter";
            this.filterBox.TextChanged += new System.EventHandler(this.filterBox_TextChanged);
            // 
            // gunaElipsePanel3
            // 
            this.gunaElipsePanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaElipsePanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.gunaElipsePanel3.Controls.Add(this.labelCham);
            this.gunaElipsePanel3.Controls.Add(this.filterBox);
            this.gunaElipsePanel3.Location = new System.Drawing.Point(40, 20);
            this.gunaElipsePanel3.Name = "gunaElipsePanel3";
            this.gunaElipsePanel3.Radius = 10;
            this.gunaElipsePanel3.Size = new System.Drawing.Size(640, 44);
            this.gunaElipsePanel3.TabIndex = 3;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.gunaElipsePanel2.Controls.Add(this.showDoctorPanel);
            this.gunaElipsePanel2.Controls.Add(this.NextDocBtn);
            this.gunaElipsePanel2.Controls.Add(this.PreviousDocBtn);
            this.gunaElipsePanel2.Controls.Add(this.doctorsCount);
            this.gunaElipsePanel2.Controls.Add(this.label3);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(335, 80);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 10;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(345, 400);
            this.gunaElipsePanel2.TabIndex = 4;
            // 
            // showDoctorPanel
            // 
            this.showDoctorPanel.Location = new System.Drawing.Point(26, 39);
            this.showDoctorPanel.Name = "showDoctorPanel";
            this.showDoctorPanel.Size = new System.Drawing.Size(294, 309);
            this.showDoctorPanel.TabIndex = 20;
            // 
            // NextDocBtn
            // 
            this.NextDocBtn.AnimationHoverSpeed = 0.07F;
            this.NextDocBtn.AnimationSpeed = 0.03F;
            this.NextDocBtn.BackColor = System.Drawing.Color.Transparent;
            this.NextDocBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(17)))), ((int)(((byte)(123)))));
            this.NextDocBtn.BorderColor = System.Drawing.Color.Black;
            this.NextDocBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.NextDocBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.NextDocBtn.CheckedForeColor = System.Drawing.Color.White;
            this.NextDocBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("NextDocBtn.CheckedImage")));
            this.NextDocBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.NextDocBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextDocBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.NextDocBtn.FocusedColor = System.Drawing.Color.Empty;
            this.NextDocBtn.Font = new System.Drawing.Font("Calibri", 10F);
            this.NextDocBtn.ForeColor = System.Drawing.Color.White;
            this.NextDocBtn.Image = null;
            this.NextDocBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NextDocBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.NextDocBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.NextDocBtn.Location = new System.Drawing.Point(172, 359);
            this.NextDocBtn.Name = "NextDocBtn";
            this.NextDocBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.NextDocBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.NextDocBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.NextDocBtn.OnHoverImage = null;
            this.NextDocBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.NextDocBtn.OnPressedColor = System.Drawing.Color.Black;
            this.NextDocBtn.Radius = 10;
            this.NextDocBtn.Size = new System.Drawing.Size(148, 20);
            this.NextDocBtn.TabIndex = 18;
            this.NextDocBtn.Text = "Next";
            this.NextDocBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NextDocBtn.Click += new System.EventHandler(this.gunaAdvenceButton3_Click);
            // 
            // PreviousDocBtn
            // 
            this.PreviousDocBtn.AnimationHoverSpeed = 0.07F;
            this.PreviousDocBtn.AnimationSpeed = 0.03F;
            this.PreviousDocBtn.BackColor = System.Drawing.Color.Transparent;
            this.PreviousDocBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(17)))), ((int)(((byte)(123)))));
            this.PreviousDocBtn.BorderColor = System.Drawing.Color.Black;
            this.PreviousDocBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.PreviousDocBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.PreviousDocBtn.CheckedForeColor = System.Drawing.Color.White;
            this.PreviousDocBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("PreviousDocBtn.CheckedImage")));
            this.PreviousDocBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.PreviousDocBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousDocBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PreviousDocBtn.FocusedColor = System.Drawing.Color.Empty;
            this.PreviousDocBtn.Font = new System.Drawing.Font("Calibri", 10F);
            this.PreviousDocBtn.ForeColor = System.Drawing.Color.White;
            this.PreviousDocBtn.Image = null;
            this.PreviousDocBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PreviousDocBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.PreviousDocBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.PreviousDocBtn.Location = new System.Drawing.Point(26, 359);
            this.PreviousDocBtn.Name = "PreviousDocBtn";
            this.PreviousDocBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.PreviousDocBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PreviousDocBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.PreviousDocBtn.OnHoverImage = null;
            this.PreviousDocBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.PreviousDocBtn.OnPressedColor = System.Drawing.Color.Black;
            this.PreviousDocBtn.Radius = 10;
            this.PreviousDocBtn.Size = new System.Drawing.Size(140, 20);
            this.PreviousDocBtn.TabIndex = 18;
            this.PreviousDocBtn.Text = "Previous";
            this.PreviousDocBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PreviousDocBtn.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.mainPanel.Controls.Add(this.gunaElipsePanel3);
            this.mainPanel.Controls.Add(this.gunaElipsePanel1);
            this.mainPanel.Controls.Add(this.gunaElipsePanel2);
            this.mainPanel.Location = new System.Drawing.Point(-1, -1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Radius = 10;
            this.mainPanel.Size = new System.Drawing.Size(720, 515);
            this.mainPanel.TabIndex = 13;
            // 
            // labelCham
            // 
            this.labelCham.AutoSize = true;
            this.labelCham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCham.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCham.Location = new System.Drawing.Point(292, 12);
            this.labelCham.Name = "labelCham";
            this.labelCham.Size = new System.Drawing.Size(86, 20);
            this.labelCham.TabIndex = 5;
            this.labelCham.Text = "All Doctors";
            // 
            // userSelectDoctorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.mainPanel);
            this.Name = "userSelectDoctorControl";
            this.Size = new System.Drawing.Size(720, 515);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.gunaElipsePanel3.ResumeLayout(false);
            this.gunaElipsePanel3.PerformLayout();
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaAdvenceButton NextDocBtn;
        private System.Windows.Forms.Label doctorsCount;
        private Guna.UI.WinForms.GunaAdvenceButton PreviousDocBtn;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaComboBox filterBox;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel3;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaElipsePanel mainPanel;
        private System.Windows.Forms.FlowLayoutPanel showDoctorPanel;
        private System.Windows.Forms.FlowLayoutPanel showAllChams;
        private Guna.UI.WinForms.GunaButton showAllDocBtn;
        private System.Windows.Forms.Label labelCham;
    }
}

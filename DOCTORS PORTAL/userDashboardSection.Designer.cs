
namespace DOCTORS_PORTAL
{
    partial class userDashboardSection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel3 = new Guna.UI.WinForms.GunaElipsePanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.filterBox = new Guna.UI.WinForms.GunaComboBox();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chamberPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.gunaElipsePanel3.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.mainPanel.Controls.Add(this.gunaElipsePanel3);
            this.mainPanel.Controls.Add(this.gunaElipsePanel2);
            this.mainPanel.Controls.Add(this.gunaElipsePanel1);
            this.mainPanel.Location = new System.Drawing.Point(0, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Radius = 10;
            this.mainPanel.Size = new System.Drawing.Size(720, 513);
            this.mainPanel.TabIndex = 28;
            // 
            // gunaElipsePanel3
            // 
            this.gunaElipsePanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaElipsePanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.gunaElipsePanel3.Controls.Add(this.label3);
            this.gunaElipsePanel3.Controls.Add(this.label2);
            this.gunaElipsePanel3.Controls.Add(this.gunaComboBox1);
            this.gunaElipsePanel3.Controls.Add(this.filterBox);
            this.gunaElipsePanel3.Location = new System.Drawing.Point(40, 89);
            this.gunaElipsePanel3.Name = "gunaElipsePanel3";
            this.gunaElipsePanel3.Radius = 10;
            this.gunaElipsePanel3.Size = new System.Drawing.Size(640, 44);
            this.gunaElipsePanel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(211, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "Total Appointments:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(27)))), ((int)(((byte)(151)))));
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.BorderSize = 0;
            this.gunaComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaComboBox1.DisplayMember = "adjshak";
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Items.AddRange(new object[] {
            "Short",
            "Shohan",
            "Rhyme",
            "Jitu"});
            this.gunaComboBox1.Location = new System.Drawing.Point(471, 8);
            this.gunaComboBox1.MaxDropDownItems = 10;
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 5;
            this.gunaComboBox1.Size = new System.Drawing.Size(160, 28);
            this.gunaComboBox1.StartIndex = 0;
            this.gunaComboBox1.TabIndex = 4;
            this.gunaComboBox1.Tag = "Short";
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
            this.filterBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.filterBox.ForeColor = System.Drawing.Color.White;
            this.filterBox.FormattingEnabled = true;
            this.filterBox.Items.AddRange(new object[] {
            "Filter",
            "Shohan",
            "Jitu",
            "Rhyme"});
            this.filterBox.Location = new System.Drawing.Point(303, 8);
            this.filterBox.MaxDropDownItems = 10;
            this.filterBox.Name = "filterBox";
            this.filterBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.filterBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.filterBox.Radius = 5;
            this.filterBox.Size = new System.Drawing.Size(160, 28);
            this.filterBox.StartIndex = 0;
            this.filterBox.TabIndex = 4;
            this.filterBox.Tag = "";
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.gunaElipsePanel2.Controls.Add(this.gunaDataGridView1);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(40, 150);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 10;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(640, 335);
            this.gunaElipsePanel2.TabIndex = 6;
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 46;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.patientName,
            this.age,
            this.date,
            this.chamberPlace,
            this.paymentStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.White;
            this.gunaDataGridView1.Location = new System.Drawing.Point(20, 18);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 40;
            this.gunaDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(600, 300);
            this.gunaDataGridView1.TabIndex = 1;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 46;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 11F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            // 
            // patientName
            // 
            this.patientName.HeaderText = "Patient Name";
            this.patientName.Name = "patientName";
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // chamberPlace
            // 
            this.chamberPlace.HeaderText = "Chamber Place";
            this.chamberPlace.Name = "chamberPlace";
            // 
            // paymentStatus
            // 
            this.paymentStatus.HeaderText = "Payment Status";
            this.paymentStatus.Name = "paymentStatus";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(173)))), ((int)(((byte)(248)))));
            this.gunaElipsePanel1.Controls.Add(this.pictureBox4);
            this.gunaElipsePanel1.Controls.Add(this.label9);
            this.gunaElipsePanel1.Controls.Add(this.label8);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(40, 15);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(640, 60);
            this.gunaElipsePanel1.TabIndex = 19;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DOCTORS_PORTAL.Properties.Resources.banner;
            this.pictureBox4.Location = new System.Drawing.Point(470, -17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(155, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.label9.Location = new System.Drawing.Point(17, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Doctor\'s Portal";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(7)))), ((int)(((byte)(94)))));
            this.label8.Location = new System.Drawing.Point(16, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 27);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nahim Hossain Shohan";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userDashboardSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(6)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(720, 515);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userDashboardSection";
            this.Text = "userDashboardSection";
            this.mainPanel.ResumeLayout(false);
            this.gunaElipsePanel3.ResumeLayout(false);
            this.gunaElipsePanel3.PerformLayout();
            this.gunaElipsePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel mainPanel;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaComboBox filterBox;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn chamberPlace;
        private System.Windows.Forms.DataGridViewButtonColumn paymentStatus;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}
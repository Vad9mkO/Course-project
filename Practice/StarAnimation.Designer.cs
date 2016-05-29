namespace AstronomicalDirectory
{
    partial class StarAnimation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StarAnimation));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gridView = new System.Windows.Forms.DataGridView();
            this.buttonStop = new System.Windows.Forms.Button();
            this.slowButton = new System.Windows.Forms.Button();
            this.quickButton = new System.Windows.Forms.Button();
            this.speedLabel = new System.Windows.Forms.Label();
            this.star1Label = new System.Windows.Forms.Label();
            this.star2Label = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearButton = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constellationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starMagnitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightAscensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.declensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.starListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AllowUserToResizeColumns = false;
            this.gridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.AutoGenerateColumns = false;
            this.gridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.constellationDataGridViewTextBoxColumn,
            this.starMagnitudeDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.rightAscensionDataGridViewTextBoxColumn,
            this.declensionDataGridViewTextBoxColumn});
            this.gridView.DataSource = this.starBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridView.Enabled = false;
            this.gridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridView.Location = new System.Drawing.Point(758, 0);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridView.Size = new System.Drawing.Size(604, 44);
            this.gridView.TabIndex = 0;
            // 
            // buttonStop
            // 
            this.buttonStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStop.BackgroundImage")));
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStop.FlatAppearance.BorderSize = 3;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.buttonStop.Location = new System.Drawing.Point(12, 9);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(94, 44);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Freeze";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // slowButton
            // 
            this.slowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slowButton.BackgroundImage")));
            this.slowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slowButton.FlatAppearance.BorderSize = 3;
            this.slowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slowButton.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.slowButton.Location = new System.Drawing.Point(112, 9);
            this.slowButton.Name = "slowButton";
            this.slowButton.Size = new System.Drawing.Size(94, 44);
            this.slowButton.TabIndex = 2;
            this.slowButton.Text = "Slow down (x2)";
            this.slowButton.UseVisualStyleBackColor = true;
            this.slowButton.Click += new System.EventHandler(this.slowButton_Click);
            // 
            // quickButton
            // 
            this.quickButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quickButton.BackgroundImage")));
            this.quickButton.FlatAppearance.BorderSize = 3;
            this.quickButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quickButton.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.quickButton.Location = new System.Drawing.Point(212, 9);
            this.quickButton.Name = "quickButton";
            this.quickButton.Size = new System.Drawing.Size(94, 44);
            this.quickButton.TabIndex = 3;
            this.quickButton.Text = "Speed up (x2)";
            this.quickButton.UseVisualStyleBackColor = true;
            this.quickButton.Click += new System.EventHandler(this.quickButton_Click);
            // 
            // speedLabel
            // 
            this.speedLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.speedLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.speedLabel.Image = ((System.Drawing.Image)(resources.GetObject("speedLabel.Image")));
            this.speedLabel.Location = new System.Drawing.Point(312, 18);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(100, 26);
            this.speedLabel.TabIndex = 4;
            this.speedLabel.Text = "Speed rate 1X";
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // star1Label
            // 
            this.star1Label.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.star1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.star1Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.star1Label.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.star1Label.Image = ((System.Drawing.Image)(resources.GetObject("star1Label.Image")));
            this.star1Label.Location = new System.Drawing.Point(1144, 9);
            this.star1Label.Name = "star1Label";
            this.star1Label.Size = new System.Drawing.Size(100, 23);
            this.star1Label.TabIndex = 5;
            this.star1Label.Text = "label1";
            this.star1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // star2Label
            // 
            this.star2Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.star2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.star2Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.star2Label.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.star2Label.Image = ((System.Drawing.Image)(resources.GetObject("star2Label.Image")));
            this.star2Label.Location = new System.Drawing.Point(1250, 9);
            this.star2Label.Name = "star2Label";
            this.star2Label.Size = new System.Drawing.Size(100, 23);
            this.star2Label.TabIndex = 6;
            this.star2Label.Text = "label2";
            this.star2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // distanceLabel
            // 
            this.distanceLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.distanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distanceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.distanceLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.distanceLabel.Image = ((System.Drawing.Image)(resources.GetObject("distanceLabel.Image")));
            this.distanceLabel.Location = new System.Drawing.Point(1144, 41);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(206, 33);
            this.distanceLabel.TabIndex = 7;
            this.distanceLabel.Text = "label3";
            this.distanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearLabel
            // 
            this.yearLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.yearLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.yearLabel.Image = ((System.Drawing.Image)(resources.GetObject("yearLabel.Image")));
            this.yearLabel.Location = new System.Drawing.Point(850, 650);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(83, 45);
            this.yearLabel.TabIndex = 8;
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearButton
            // 
            this.yearButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yearButton.BackgroundImage")));
            this.yearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yearButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.yearButton.FlatAppearance.BorderSize = 3;
            this.yearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearButton.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.yearButton.Location = new System.Drawing.Point(1250, 605);
            this.yearButton.Name = "yearButton";
            this.yearButton.Size = new System.Drawing.Size(100, 31);
            this.yearButton.TabIndex = 9;
            this.yearButton.Text = "Position by year";
            this.yearButton.UseVisualStyleBackColor = true;
            this.yearButton.Click += new System.EventHandler(this.yearButton_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // constellationDataGridViewTextBoxColumn
            // 
            this.constellationDataGridViewTextBoxColumn.DataPropertyName = "Constellation";
            this.constellationDataGridViewTextBoxColumn.HeaderText = "Constellation";
            this.constellationDataGridViewTextBoxColumn.Name = "constellationDataGridViewTextBoxColumn";
            this.constellationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // starMagnitudeDataGridViewTextBoxColumn
            // 
            this.starMagnitudeDataGridViewTextBoxColumn.DataPropertyName = "StarMagnitude";
            this.starMagnitudeDataGridViewTextBoxColumn.HeaderText = "StarMagnitude";
            this.starMagnitudeDataGridViewTextBoxColumn.Name = "starMagnitudeDataGridViewTextBoxColumn";
            this.starMagnitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            this.distanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rightAscensionDataGridViewTextBoxColumn
            // 
            this.rightAscensionDataGridViewTextBoxColumn.DataPropertyName = "RightAscension";
            this.rightAscensionDataGridViewTextBoxColumn.HeaderText = "RightAscension";
            this.rightAscensionDataGridViewTextBoxColumn.Name = "rightAscensionDataGridViewTextBoxColumn";
            this.rightAscensionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // declensionDataGridViewTextBoxColumn
            // 
            this.declensionDataGridViewTextBoxColumn.DataPropertyName = "Declension";
            this.declensionDataGridViewTextBoxColumn.HeaderText = "Declension";
            this.declensionDataGridViewTextBoxColumn.Name = "declensionDataGridViewTextBoxColumn";
            this.declensionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // starBindingSource
            // 
            this.starBindingSource.DataSource = typeof(AstronomicalDirectory.Star);
            // 
            // starListBindingSource
            // 
            this.starListBindingSource.DataSource = typeof(AstronomicalDirectory.StarList);
            // 
            // StarAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.yearButton);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.star2Label);
            this.Controls.Add(this.star1Label);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.quickButton);
            this.Controls.Add(this.slowButton);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.gridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StarAnimation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StarAnimation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StarAnimation_FormClosed);
            this.Load += new System.EventHandler(this.StarAnimation_Load);
            this.Click += new System.EventHandler(this.StarAnimation_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StarAnimation_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constellationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starMagnitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightAscensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn declensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource starListBindingSource;
        private System.Windows.Forms.BindingSource starBindingSource;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button slowButton;
        private System.Windows.Forms.Button quickButton;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label star1Label;
        private System.Windows.Forms.Label star2Label;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Button yearButton;
    }
}
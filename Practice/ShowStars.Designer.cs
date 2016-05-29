namespace AstronomicalDirectory
{
    partial class ShowStars
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowStars));
            this.Cancel = new System.Windows.Forms.Button();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.ColDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRightAscension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDeclension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LongitudeLabel = new System.Windows.Forms.Label();
            this.LongitudeText = new System.Windows.Forms.TextBox();
            this.LatitudeLabel = new System.Windows.Forms.Label();
            this.LatitudeText = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.SupportingGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CConstellation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStarMagnitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRightAscension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDeclension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColConstellation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStarMagnitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupportingGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.LimeGreen;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(323, 217);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(65, 32);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.AutoGenerateColumns = false;
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColConstellation,
            this.ColDistance,
            this.ColStarMagnitude,
            this.ColRightAscension,
            this.ColDeclension});
            this.GridView.DataSource = this.starListBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.GridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.GridView.Location = new System.Drawing.Point(0, 0);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(405, 97);
            this.GridView.TabIndex = 1;
            this.GridView.VirtualMode = true;
            this.GridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellMouseEnter);
            this.GridView.MouseLeave += new System.EventHandler(this.GridView_MouseLeave);
            // 
            // ColDistance
            // 
            this.ColDistance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDistance.DataPropertyName = "Distance";
            this.ColDistance.HeaderText = "Distance";
            this.ColDistance.Name = "ColDistance";
            this.ColDistance.ReadOnly = true;
            // 
            // ColRightAscension
            // 
            this.ColRightAscension.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColRightAscension.DataPropertyName = "RightAscension";
            this.ColRightAscension.HeaderText = "RightAscension";
            this.ColRightAscension.Name = "ColRightAscension";
            this.ColRightAscension.ReadOnly = true;
            // 
            // ColDeclension
            // 
            this.ColDeclension.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDeclension.DataPropertyName = "Declension";
            this.ColDeclension.HeaderText = "Declension";
            this.ColDeclension.Name = "ColDeclension";
            this.ColDeclension.ReadOnly = true;
            // 
            // LongitudeLabel
            // 
            this.LongitudeLabel.AutoSize = true;
            this.LongitudeLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.LongitudeLabel.Location = new System.Drawing.Point(199, 163);
            this.LongitudeLabel.Name = "LongitudeLabel";
            this.LongitudeLabel.Size = new System.Drawing.Size(78, 13);
            this.LongitudeLabel.TabIndex = 2;
            this.LongitudeLabel.Text = "Enter longitude";
            // 
            // LongitudeText
            // 
            this.LongitudeText.Location = new System.Drawing.Point(288, 163);
            this.LongitudeText.Name = "LongitudeText";
            this.LongitudeText.Size = new System.Drawing.Size(100, 20);
            this.LongitudeText.TabIndex = 3;
            // 
            // LatitudeLabel
            // 
            this.LatitudeLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.LatitudeLabel.Location = new System.Drawing.Point(199, 191);
            this.LatitudeLabel.Name = "LatitudeLabel";
            this.LatitudeLabel.Size = new System.Drawing.Size(78, 13);
            this.LatitudeLabel.TabIndex = 4;
            this.LatitudeLabel.Text = "Enter latitude";
            // 
            // LatitudeText
            // 
            this.LatitudeText.Location = new System.Drawing.Point(288, 191);
            this.LatitudeText.Name = "LatitudeText";
            this.LatitudeText.Size = new System.Drawing.Size(100, 20);
            this.LatitudeText.TabIndex = 5;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.LimeGreen;
            this.Search.Location = new System.Drawing.Point(207, 217);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(65, 32);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SupportingGridView
            // 
            this.SupportingGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupportingGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.SupportingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupportingGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CName,
            this.CConstellation,
            this.CStarMagnitude,
            this.CDistance,
            this.CRightAscension,
            this.CDeclension});
            this.SupportingGridView.DataSource = this.starBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SupportingGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.SupportingGridView.Location = new System.Drawing.Point(12, 126);
            this.SupportingGridView.Name = "SupportingGridView";
            this.SupportingGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupportingGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.SupportingGridView.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SupportingGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.SupportingGridView.Size = new System.Drawing.Size(181, 123);
            this.SupportingGridView.TabIndex = 7;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CName
            // 
            this.CName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CName.DataPropertyName = "Name";
            this.CName.HeaderText = "Name";
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            this.CName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CConstellation
            // 
            this.CConstellation.DataPropertyName = "Constellation";
            this.CConstellation.HeaderText = "Constellation";
            this.CConstellation.Name = "CConstellation";
            this.CConstellation.ReadOnly = true;
            this.CConstellation.Width = 70;
            // 
            // CStarMagnitude
            // 
            this.CStarMagnitude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CStarMagnitude.DataPropertyName = "StarMagnitude";
            this.CStarMagnitude.HeaderText = "Star Magnitude";
            this.CStarMagnitude.Name = "CStarMagnitude";
            this.CStarMagnitude.ReadOnly = true;
            // 
            // CDistance
            // 
            this.CDistance.DataPropertyName = "Distance";
            this.CDistance.HeaderText = "Distance";
            this.CDistance.Name = "CDistance";
            this.CDistance.ReadOnly = true;
            this.CDistance.Width = 49;
            // 
            // CRightAscension
            // 
            this.CRightAscension.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CRightAscension.DataPropertyName = "RightAscension";
            this.CRightAscension.HeaderText = "Right Ascension";
            this.CRightAscension.Name = "CRightAscension";
            this.CRightAscension.ReadOnly = true;
            // 
            // CDeclension
            // 
            this.CDeclension.DataPropertyName = "Declension";
            this.CDeclension.HeaderText = "Declension";
            this.CDeclension.Name = "CDeclension";
            this.CDeclension.ReadOnly = true;
            this.CDeclension.Width = 59;
            // 
            // starBindingSource
            // 
            this.starBindingSource.DataSource = typeof(AstronomicalDirectory.Star);
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.DataPropertyName = "Name";
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColConstellation
            // 
            this.ColConstellation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColConstellation.DataPropertyName = "Constellation";
            this.ColConstellation.HeaderText = "Constellation";
            this.ColConstellation.Name = "ColConstellation";
            this.ColConstellation.ReadOnly = true;
            // 
            // ColStarMagnitude
            // 
            this.ColStarMagnitude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColStarMagnitude.DataPropertyName = "StarMagnitude";
            this.ColStarMagnitude.HeaderText = "Star Magnitude";
            this.ColStarMagnitude.Name = "ColStarMagnitude";
            this.ColStarMagnitude.ReadOnly = true;
            // 
            // starListBindingSource
            // 
            this.starListBindingSource.DataSource = typeof(AstronomicalDirectory.StarList);
            // 
            // ShowStars
            // 
            this.AcceptButton = this.Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(405, 261);
            this.Controls.Add(this.SupportingGridView);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.LatitudeText);
            this.Controls.Add(this.LatitudeLabel);
            this.Controls.Add(this.LongitudeText);
            this.Controls.Add(this.LongitudeLabel);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowStars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Stars";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowStars_FormClosed);
            this.Load += new System.EventHandler(this.ShowStars_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowStars_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupportingGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.BindingSource starListBindingSource;
        private System.Windows.Forms.Label LongitudeLabel;
        private System.Windows.Forms.TextBox LongitudeText;
        private System.Windows.Forms.Label LatitudeLabel;
        private System.Windows.Forms.TextBox LatitudeText;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStarMagnitude;
        private System.Windows.Forms.DataGridView SupportingGridView;
        private System.Windows.Forms.BindingSource starBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColConstellation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStarMagnitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRightAscension;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDeclension;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CConstellation;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStarMagnitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRightAscension;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDeclension;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
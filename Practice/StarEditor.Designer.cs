namespace AstronomicalDirectory
{
    partial class StarEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StarEditor));
            this.NameLabel = new System.Windows.Forms.Label();
            this.ConstellationLabel = new System.Windows.Forms.Label();
            this.StarMagnitudeLabel = new System.Windows.Forms.Label();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.RightAscensionLabel = new System.Windows.Forms.Label();
            this.DeclensionLabel = new System.Windows.Forms.Label();
            this.ConstellationText = new System.Windows.Forms.TextBox();
            this.StarMagnitudeText = new System.Windows.Forms.TextBox();
            this.DistanceText = new System.Windows.Forms.TextBox();
            this.RightAscensionText = new System.Windows.Forms.TextBox();
            this.DeclensionText = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.ComboBox();
            this.starListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NewNameLabel = new System.Windows.Forms.Label();
            this.NewNameText = new System.Windows.Forms.TextBox();
            this.AddStar = new System.Windows.Forms.Button();
            this.EditStar = new System.Windows.Forms.Button();
            this.ClearFields = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.DeleteStar = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.CheckedListBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.starListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.NameLabel.Location = new System.Drawing.Point(100, 54);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // ConstellationLabel
            // 
            this.ConstellationLabel.AutoSize = true;
            this.ConstellationLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConstellationLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.ConstellationLabel.Location = new System.Drawing.Point(100, 88);
            this.ConstellationLabel.Name = "ConstellationLabel";
            this.ConstellationLabel.Size = new System.Drawing.Size(67, 13);
            this.ConstellationLabel.TabIndex = 1;
            this.ConstellationLabel.Text = "Constellation";
            // 
            // StarMagnitudeLabel
            // 
            this.StarMagnitudeLabel.AutoSize = true;
            this.StarMagnitudeLabel.BackColor = System.Drawing.Color.Transparent;
            this.StarMagnitudeLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.StarMagnitudeLabel.Location = new System.Drawing.Point(100, 152);
            this.StarMagnitudeLabel.Name = "StarMagnitudeLabel";
            this.StarMagnitudeLabel.Size = new System.Drawing.Size(78, 13);
            this.StarMagnitudeLabel.TabIndex = 2;
            this.StarMagnitudeLabel.Text = "Star magnitude";
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.DistanceLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.DistanceLabel.Location = new System.Drawing.Point(100, 119);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(49, 13);
            this.DistanceLabel.TabIndex = 3;
            this.DistanceLabel.Text = "Distance";
            // 
            // RightAscensionLabel
            // 
            this.RightAscensionLabel.AutoSize = true;
            this.RightAscensionLabel.BackColor = System.Drawing.Color.Transparent;
            this.RightAscensionLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.RightAscensionLabel.Location = new System.Drawing.Point(100, 187);
            this.RightAscensionLabel.Name = "RightAscensionLabel";
            this.RightAscensionLabel.Size = new System.Drawing.Size(83, 13);
            this.RightAscensionLabel.TabIndex = 4;
            this.RightAscensionLabel.Text = "Right ascension";
            // 
            // DeclensionLabel
            // 
            this.DeclensionLabel.AutoSize = true;
            this.DeclensionLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeclensionLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.DeclensionLabel.Location = new System.Drawing.Point(100, 219);
            this.DeclensionLabel.Name = "DeclensionLabel";
            this.DeclensionLabel.Size = new System.Drawing.Size(60, 13);
            this.DeclensionLabel.TabIndex = 5;
            this.DeclensionLabel.Text = "Declension";
            // 
            // ConstellationText
            // 
            this.ConstellationText.Location = new System.Drawing.Point(206, 85);
            this.ConstellationText.Name = "ConstellationText";
            this.ConstellationText.Size = new System.Drawing.Size(131, 20);
            this.ConstellationText.TabIndex = 7;
            // 
            // StarMagnitudeText
            // 
            this.StarMagnitudeText.Location = new System.Drawing.Point(206, 152);
            this.StarMagnitudeText.Name = "StarMagnitudeText";
            this.StarMagnitudeText.Size = new System.Drawing.Size(131, 20);
            this.StarMagnitudeText.TabIndex = 8;
            // 
            // DistanceText
            // 
            this.DistanceText.Location = new System.Drawing.Point(206, 119);
            this.DistanceText.Name = "DistanceText";
            this.DistanceText.Size = new System.Drawing.Size(131, 20);
            this.DistanceText.TabIndex = 9;
            // 
            // RightAscensionText
            // 
            this.RightAscensionText.Location = new System.Drawing.Point(206, 187);
            this.RightAscensionText.Name = "RightAscensionText";
            this.RightAscensionText.Size = new System.Drawing.Size(131, 20);
            this.RightAscensionText.TabIndex = 10;
            // 
            // DeclensionText
            // 
            this.DeclensionText.Location = new System.Drawing.Point(206, 219);
            this.DeclensionText.Name = "DeclensionText";
            this.DeclensionText.Size = new System.Drawing.Size(131, 20);
            this.DeclensionText.TabIndex = 11;
            // 
            // NameBox
            // 
            this.NameBox.DataSource = this.starListBindingSource;
            this.NameBox.DisplayMember = "Name";
            this.NameBox.FormattingEnabled = true;
            this.NameBox.Location = new System.Drawing.Point(206, 51);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(131, 21);
            this.NameBox.TabIndex = 14;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // starListBindingSource
            // 
            this.starListBindingSource.DataSource = typeof(AstronomicalDirectory.StarList);
            // 
            // NewNameLabel
            // 
            this.NewNameLabel.AutoSize = true;
            this.NewNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewNameLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.NewNameLabel.Location = new System.Drawing.Point(100, 22);
            this.NewNameLabel.Name = "NewNameLabel";
            this.NewNameLabel.Size = new System.Drawing.Size(58, 13);
            this.NewNameLabel.TabIndex = 15;
            this.NewNameLabel.Text = "New name";
            // 
            // NewNameText
            // 
            this.NewNameText.Location = new System.Drawing.Point(206, 19);
            this.NewNameText.Name = "NewNameText";
            this.NewNameText.Size = new System.Drawing.Size(131, 20);
            this.NewNameText.TabIndex = 16;
            // 
            // AddStar
            // 
            this.AddStar.Location = new System.Drawing.Point(39, 265);
            this.AddStar.Name = "AddStar";
            this.AddStar.Size = new System.Drawing.Size(75, 23);
            this.AddStar.TabIndex = 17;
            this.AddStar.Text = "Add";
            this.AddStar.UseVisualStyleBackColor = true;
            this.AddStar.Click += new System.EventHandler(this.AddStar_Click);
            // 
            // EditStar
            // 
            this.EditStar.Location = new System.Drawing.Point(145, 265);
            this.EditStar.Name = "EditStar";
            this.EditStar.Size = new System.Drawing.Size(75, 23);
            this.EditStar.TabIndex = 18;
            this.EditStar.Text = "Edit";
            this.EditStar.UseVisualStyleBackColor = true;
            this.EditStar.Click += new System.EventHandler(this.EditStar_Click);
            // 
            // ClearFields
            // 
            this.ClearFields.Location = new System.Drawing.Point(253, 265);
            this.ClearFields.Name = "ClearFields";
            this.ClearFields.Size = new System.Drawing.Size(75, 23);
            this.ClearFields.TabIndex = 19;
            this.ClearFields.Text = "Clear";
            this.ClearFields.UseVisualStyleBackColor = true;
            this.ClearFields.Click += new System.EventHandler(this.ClearFields_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(361, 265);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 20;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // DeleteStar
            // 
            this.DeleteStar.Location = new System.Drawing.Point(361, 219);
            this.DeleteStar.Name = "DeleteStar";
            this.DeleteStar.Size = new System.Drawing.Size(75, 23);
            this.DeleteStar.TabIndex = 21;
            this.DeleteStar.Text = "Delete";
            this.DeleteStar.UseVisualStyleBackColor = true;
            this.DeleteStar.Click += new System.EventHandler(this.DeleteStar_Click);
            // 
            // ListBox
            // 
            this.ListBox.CheckOnClick = true;
            this.ListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.starListBindingSource, "Name", true));
            this.ListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.starListBindingSource, "StarMagnitude", true));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(343, 19);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(116, 94);
            this.ListBox.TabIndex = 22;
            this.ListBox.ThreeDCheckBoxes = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(464, 311);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 23;
            this.pictureBox.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // StarEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(464, 311);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.DeleteStar);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ClearFields);
            this.Controls.Add(this.EditStar);
            this.Controls.Add(this.AddStar);
            this.Controls.Add(this.NewNameText);
            this.Controls.Add(this.NewNameLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.DeclensionText);
            this.Controls.Add(this.RightAscensionText);
            this.Controls.Add(this.DistanceText);
            this.Controls.Add(this.StarMagnitudeText);
            this.Controls.Add(this.ConstellationText);
            this.Controls.Add(this.DeclensionLabel);
            this.Controls.Add(this.RightAscensionLabel);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.StarMagnitudeLabel);
            this.Controls.Add(this.ConstellationLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.pictureBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "StarEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Star Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StarEditor_FormClosed);
            this.Load += new System.EventHandler(this.StarEditor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StarEditor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.starListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ConstellationLabel;
        private System.Windows.Forms.Label StarMagnitudeLabel;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Label RightAscensionLabel;
        private System.Windows.Forms.Label DeclensionLabel;
        private System.Windows.Forms.TextBox ConstellationText;
        private System.Windows.Forms.TextBox StarMagnitudeText;
        private System.Windows.Forms.TextBox DistanceText;
        private System.Windows.Forms.TextBox RightAscensionText;
        private System.Windows.Forms.TextBox DeclensionText;
        private System.Windows.Forms.ComboBox NameBox;
        private System.Windows.Forms.Label NewNameLabel;
        private System.Windows.Forms.TextBox NewNameText;
        private System.Windows.Forms.Button AddStar;
        private System.Windows.Forms.Button EditStar;
        private System.Windows.Forms.Button ClearFields;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button DeleteStar;
        private System.Windows.Forms.BindingSource starListBindingSource;
        private System.Windows.Forms.CheckedListBox ListBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
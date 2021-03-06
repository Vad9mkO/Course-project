﻿namespace AstronomicalDirectory
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNewStar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditStar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDeleteStar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDeleteSingle = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDeleteList = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDeleteDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBrightestStars = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuViewableStars = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuViewableConstellations = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAnimationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constellationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starMagnitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightAscensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.declensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NameLabel = new System.Windows.Forms.Label();
            this.ConstellationLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.ConstellationText = new System.Windows.Forms.TextBox();
            this.StarSearch = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PictureHeaderBox = new System.Windows.Forms.PictureBox();
            this.PictureFooterBox = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureHeaderBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFooterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Yellow;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.editToolStripMenuItem,
            this.showToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(501, 24);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUndo,
            this.MenuRedo,
            this.MenuSave,
            this.MenuExit});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.saveToolStripMenuItem.Text = "File";
            // 
            // MenuUndo
            // 
            this.MenuUndo.Name = "MenuUndo";
            this.MenuUndo.Size = new System.Drawing.Size(103, 22);
            this.MenuUndo.Text = "Undo";
            this.MenuUndo.Click += new System.EventHandler(this.MenuUndo_Click);
            // 
            // MenuRedo
            // 
            this.MenuRedo.Name = "MenuRedo";
            this.MenuRedo.Size = new System.Drawing.Size(103, 22);
            this.MenuRedo.Text = "Redo";
            this.MenuRedo.Click += new System.EventHandler(this.MenuRedo_Click);
            // 
            // MenuSave
            // 
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.Size = new System.Drawing.Size(103, 22);
            this.MenuSave.Text = "Save";
            this.MenuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(103, 22);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNewStar,
            this.MenuEditStar,
            this.MenuDeleteStar});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // MenuNewStar
            // 
            this.MenuNewStar.Name = "MenuNewStar";
            this.MenuNewStar.Size = new System.Drawing.Size(129, 22);
            this.MenuNewStar.Text = "New star";
            this.MenuNewStar.Click += new System.EventHandler(this.MenuNewStar_Click);
            // 
            // MenuEditStar
            // 
            this.MenuEditStar.Name = "MenuEditStar";
            this.MenuEditStar.Size = new System.Drawing.Size(129, 22);
            this.MenuEditStar.Text = "Edit star";
            this.MenuEditStar.Click += new System.EventHandler(this.MenuEditStar_Click);
            // 
            // MenuDeleteStar
            // 
            this.MenuDeleteStar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDeleteSingle,
            this.MenuDeleteList,
            this.MenuDeleteDirectory});
            this.MenuDeleteStar.Name = "MenuDeleteStar";
            this.MenuDeleteStar.Size = new System.Drawing.Size(129, 22);
            this.MenuDeleteStar.Text = "Delete star";
            // 
            // MenuDeleteSingle
            // 
            this.MenuDeleteSingle.Name = "MenuDeleteSingle";
            this.MenuDeleteSingle.Size = new System.Drawing.Size(157, 22);
            this.MenuDeleteSingle.Text = "Delete single";
            this.MenuDeleteSingle.Click += new System.EventHandler(this.MenuDeleteSingle_Click);
            // 
            // MenuDeleteList
            // 
            this.MenuDeleteList.Name = "MenuDeleteList";
            this.MenuDeleteList.Size = new System.Drawing.Size(157, 22);
            this.MenuDeleteList.Text = "Delete list";
            this.MenuDeleteList.Click += new System.EventHandler(this.MenuDeleteList_Click);
            // 
            // MenuDeleteDirectory
            // 
            this.MenuDeleteDirectory.Name = "MenuDeleteDirectory";
            this.MenuDeleteDirectory.Size = new System.Drawing.Size(157, 22);
            this.MenuDeleteDirectory.Text = "Delete directory";
            this.MenuDeleteDirectory.Click += new System.EventHandler(this.MenuDeleteDirectory_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBrightestStars,
            this.MenuViewableStars,
            this.MenuViewableConstellations});
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.showToolStripMenuItem.Text = "Search";
            // 
            // MenuBrightestStars
            // 
            this.MenuBrightestStars.Name = "MenuBrightestStars";
            this.MenuBrightestStars.Size = new System.Drawing.Size(197, 22);
            this.MenuBrightestStars.Text = "The brightest stars";
            this.MenuBrightestStars.Click += new System.EventHandler(this.MenuShowStar_Click);
            // 
            // MenuViewableStars
            // 
            this.MenuViewableStars.Name = "MenuViewableStars";
            this.MenuViewableStars.Size = new System.Drawing.Size(197, 22);
            this.MenuViewableStars.Text = "Viewable stars";
            this.MenuViewableStars.Click += new System.EventHandler(this.MenuViewableStars_Click);
            // 
            // MenuViewableConstellations
            // 
            this.MenuViewableConstellations.Name = "MenuViewableConstellations";
            this.MenuViewableConstellations.Size = new System.Drawing.Size(197, 22);
            this.MenuViewableConstellations.Text = "Viewable constellations";
            this.MenuViewableConstellations.Click += new System.EventHandler(this.MenuViewableConstellations_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAnimationToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.viewToolStripMenuItem.Text = "Show";
            // 
            // showAnimationToolStripMenuItem
            // 
            this.showAnimationToolStripMenuItem.Name = "showAnimationToolStripMenuItem";
            this.showAnimationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showAnimationToolStripMenuItem.Text = "Animation";
            this.showAnimationToolStripMenuItem.Click += new System.EventHandler(this.showAnimationToolStripMenuItem_Click);
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.AutoGenerateColumns = false;
            this.GridView.BackgroundColor = System.Drawing.Color.White;
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.constellationDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.starMagnitudeDataGridViewTextBoxColumn,
            this.rightAscensionDataGridViewTextBoxColumn,
            this.declensionDataGridViewTextBoxColumn});
            this.GridView.DataSource = this.starListBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.GridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GridView.GridColor = System.Drawing.Color.Maroon;
            this.GridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.GridView.Location = new System.Drawing.Point(0, 212);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GridView.RowHeadersVisible = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.GridView.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.GridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(507, 237);
            this.GridView.TabIndex = 4;
            this.GridView.VirtualMode = true;
            this.GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellContentClick);
            this.GridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellContentDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // constellationDataGridViewTextBoxColumn
            // 
            this.constellationDataGridViewTextBoxColumn.DataPropertyName = "Constellation";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.constellationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.constellationDataGridViewTextBoxColumn.HeaderText = "Constellation";
            this.constellationDataGridViewTextBoxColumn.Name = "constellationDataGridViewTextBoxColumn";
            this.constellationDataGridViewTextBoxColumn.ReadOnly = true;
            this.constellationDataGridViewTextBoxColumn.Width = 90;
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.distanceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            this.distanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // starMagnitudeDataGridViewTextBoxColumn
            // 
            this.starMagnitudeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.starMagnitudeDataGridViewTextBoxColumn.DataPropertyName = "StarMagnitude";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.starMagnitudeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.starMagnitudeDataGridViewTextBoxColumn.HeaderText = "Star Magnitude";
            this.starMagnitudeDataGridViewTextBoxColumn.Name = "starMagnitudeDataGridViewTextBoxColumn";
            this.starMagnitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rightAscensionDataGridViewTextBoxColumn
            // 
            this.rightAscensionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rightAscensionDataGridViewTextBoxColumn.DataPropertyName = "RightAscension";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rightAscensionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.rightAscensionDataGridViewTextBoxColumn.HeaderText = "Right Ascension";
            this.rightAscensionDataGridViewTextBoxColumn.Name = "rightAscensionDataGridViewTextBoxColumn";
            this.rightAscensionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // declensionDataGridViewTextBoxColumn
            // 
            this.declensionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.declensionDataGridViewTextBoxColumn.DataPropertyName = "Declension";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.declensionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.declensionDataGridViewTextBoxColumn.HeaderText = "Declension";
            this.declensionDataGridViewTextBoxColumn.Name = "declensionDataGridViewTextBoxColumn";
            this.declensionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // starListBindingSource
            // 
            this.starListBindingSource.DataSource = typeof(AstronomicalDirectory.StarList);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameLabel.ForeColor = System.Drawing.Color.Green;
            this.NameLabel.Location = new System.Drawing.Point(11, 183);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name";
            // 
            // ConstellationLabel
            // 
            this.ConstellationLabel.AutoSize = true;
            this.ConstellationLabel.BackColor = System.Drawing.Color.Black;
            this.ConstellationLabel.ForeColor = System.Drawing.Color.Green;
            this.ConstellationLabel.Location = new System.Drawing.Point(178, 183);
            this.ConstellationLabel.Name = "ConstellationLabel";
            this.ConstellationLabel.Size = new System.Drawing.Size(67, 13);
            this.ConstellationLabel.TabIndex = 6;
            this.ConstellationLabel.Text = "Constellation";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(52, 183);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(98, 20);
            this.NameText.TabIndex = 10;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // ConstellationText
            // 
            this.ConstellationText.Location = new System.Drawing.Point(251, 183);
            this.ConstellationText.Name = "ConstellationText";
            this.ConstellationText.Size = new System.Drawing.Size(98, 20);
            this.ConstellationText.TabIndex = 11;
            // 
            // StarSearch
            // 
            this.StarSearch.BackColor = System.Drawing.Color.Yellow;
            this.StarSearch.Location = new System.Drawing.Point(379, 183);
            this.StarSearch.Name = "StarSearch";
            this.StarSearch.Size = new System.Drawing.Size(52, 23);
            this.StarSearch.TabIndex = 12;
            this.StarSearch.Text = "Search";
            this.StarSearch.UseVisualStyleBackColor = false;
            this.StarSearch.Click += new System.EventHandler(this.StarSearch_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Yellow;
            this.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearButton.Location = new System.Drawing.Point(437, 183);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(52, 23);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PictureHeaderBox
            // 
            this.PictureHeaderBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureHeaderBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureHeaderBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureHeaderBox.Image")));
            this.PictureHeaderBox.Location = new System.Drawing.Point(0, 0);
            this.PictureHeaderBox.Name = "PictureHeaderBox";
            this.PictureHeaderBox.Size = new System.Drawing.Size(501, 212);
            this.PictureHeaderBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureHeaderBox.TabIndex = 14;
            this.PictureHeaderBox.TabStop = false;
            // 
            // PictureFooterBox
            // 
            this.PictureFooterBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PictureFooterBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureFooterBox.Image")));
            this.PictureFooterBox.Location = new System.Drawing.Point(0, 212);
            this.PictureFooterBox.Name = "PictureFooterBox";
            this.PictureFooterBox.Size = new System.Drawing.Size(501, 237);
            this.PictureFooterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureFooterBox.TabIndex = 15;
            this.PictureFooterBox.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AcceptButton = this.StarSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 449);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.StarSearch);
            this.Controls.Add(this.ConstellationText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.ConstellationLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.PictureHeaderBox);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.PictureFooterBox);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astronomical directory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureHeaderBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFooterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuNewStar;
        private System.Windows.Forms.ToolStripMenuItem MenuEditStar;
        private System.Windows.Forms.ToolStripMenuItem MenuDeleteStar;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAnimationToolStripMenuItem;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ConstellationLabel;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox ConstellationText;
        private System.Windows.Forms.Button StarSearch;
        private System.Windows.Forms.Button ClearButton;
        public System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.ToolStripMenuItem MenuUndo;
        private System.Windows.Forms.ToolStripMenuItem MenuRedo;
        private System.Windows.Forms.ToolStripMenuItem MenuDeleteDirectory;
        private System.Windows.Forms.ToolStripMenuItem MenuDeleteSingle;
        private System.Windows.Forms.ToolStripMenuItem MenuDeleteList;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuBrightestStars;
        private System.Windows.Forms.ToolStripMenuItem MenuViewableStars;
        private System.Windows.Forms.ToolStripMenuItem MenuViewableConstellations;
        private System.Windows.Forms.PictureBox PictureHeaderBox;
        private System.Windows.Forms.PictureBox PictureFooterBox;
        private System.Windows.Forms.BindingSource starListBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constellationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starMagnitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightAscensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn declensionDataGridViewTextBoxColumn;
    }
}


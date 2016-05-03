using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstronomicalDirectory
{
    public partial class ShowStars : Form
    {
        private MainForm main { get; set; }
        private bool showVisibleStars = false;
        private bool showVisibleConstellations = false;

        public ShowStars()
        {
            InitializeComponent();
            LongitudeLabel.Visible = false;
            LongitudeText.Visible = false;
            LatitudeLabel.Visible = false;
            LatitudeText.Visible = false;
            Search.Visible = false;
            SupportingGridView.Visible = false;
            SupportingGridView.Size = new Size(305, 123);
            SupportingGridView.Columns["CName"].Visible = false;
            SupportingGridView.Columns["CStarMagnitude"].Visible = false;
            foreach(DataGridViewColumn col in SupportingGridView.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            SupportingGridView.Columns["CConstellation"].Width = 80;
            GridView.Columns["ColConstellation"].Visible = false;
            GridView.Columns["ColDistance"].Visible = false;
            GridView.Columns["ColRightAscension"].Visible = false;
            GridView.Columns["ColDeclension"].Visible = false;
            
            //AcceptButton = DeleteStar;
            //this.ActiveControl = NewNameText;         
        }

        public ShowStars(int value)
        {
            InitializeComponent();
            GridView.Visible = false;
            LongitudeLabel.Location = new Point(194, 12);
            LongitudeText.Location = new Point(288, 12);
            LatitudeLabel.Location = new Point(194, 40);
            LatitudeText.Location = new Point(288, 40);
            SupportingGridView.Location = new Point(100, 70);
            SupportingGridView.Size = new Size(293, 140);
            SupportingGridView.Visible = false;
            SupportingGridView.Columns["CName"].Visible = false;
            GridView.Dock = DockStyle.Left;
            GridView.Size = new Size(90, 261);
            GridView.Columns["ColConstellation"].Visible = false;
            GridView.Columns["ColStarMagnitude"].Visible = false;
            GridView.Columns["ColDistance"].Visible = false;
            GridView.Columns["ColRightAscension"].Visible = false;
            GridView.Columns["ColDeclension"].Visible = false;

            GridView.Columns["ColName"].HeaderText = "Star";
            showVisibleStars = true;
            AcceptButton = Search;
        }

        public ShowStars(string value)
        {
            InitializeComponent();
            GridView.Visible = false;
            LongitudeLabel.Location = new Point(194, 12);
            LongitudeText.Location = new Point(288, 12);
            LatitudeLabel.Location = new Point(194, 40);
            LatitudeText.Location = new Point(288, 40);
            SupportingGridView.Location = new Point(100, 70);
            SupportingGridView.Size = new Size(293, 140);
            SupportingGridView.Visible = false;
            GridView.Dock = DockStyle.Left;
            GridView.Size = new Size(90, 261);
            SupportingGridView.Columns["CConstellation"].Visible = false;
            SupportingGridView.Columns["CName"].HeaderText = "Stars";
            GridView.Columns["ColStarMagnitude"].Visible = false;
            GridView.Columns["ColDistance"].Visible = false;
            GridView.Columns["ColRightAscension"].Visible = false;
            GridView.Columns["ColDeclension"].Visible = false;
            GridView.Columns["ColName"].Visible = false;
            showVisibleConstellations = true;
            AcceptButton = Search;
        }

        private void ShowStars_Load(object sender, EventArgs e)
        {
            main = this.Owner as MainForm;
            if (main.buffer[main.curBufIndex].Count == 0)
            {
                DialogResult result = MessageBox.Show("Impossible to find the brightest stars - dictionaty is empty! Do you want to create you first star?", "Emptiness", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    StarEditor addForm = new StarEditor();
                    addForm.Owner = main;
                    addForm.ShowDialog();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                if(!showVisibleStars && !showVisibleConstellations)
                {
                    GridView.DataSource = main.buffer[main.curBufIndex].SearchBrightest();
                    main.ResizeGridRowHeight(GridView);
                }
            }
        }

        private void ShowStars_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        private void ShowStars_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseForm();
            }
        }

        private void CloseForm()
        {
            main.Show();
            this.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if(IsValid())
            {
                if (showVisibleStars)
                {
                    StarList searchedVisibelStars = main.buffer[main.curBufIndex].SearchVisibleStars(Double.Parse(LongitudeText.Text), Double.Parse(LatitudeText.Text));
                    GridView.DataSource = searchedVisibelStars;
                    if(searchedVisibelStars == null)
                    {
                        GridView.Visible = false;
                    }
                    else
                    { 
                        GridView.Visible = true;
                        main.ResizeGridRowHeight(GridView);
                    }            
                }
                else if (showVisibleConstellations)
                {
                    StarList searchedVisibleConstellations = main.buffer[main.curBufIndex].SearchVisibleConstellations(Double.Parse(LongitudeText.Text), Double.Parse(LatitudeText.Text));
                    GridView.DataSource = searchedVisibleConstellations;
                    if(searchedVisibleConstellations == null)
                    {
                        GridView.Visible = false;
                    }
                    else
                    {
                        GridView.Visible = true;
                        main.ResizeGridRowHeight(GridView);
                    }
                }
            }
            else
            {
                GridView.Visible = false;
            }
        }

        private void GridView_MouseLeave(object sender, EventArgs e)
        {
            SupportingGridView.Visible = false;
        }

        private void GridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            var p = this.GridView.PointToClient(Cursor.Position);
            var info = this.GridView.HitTest(p.X, p.Y);
            if (info.ColumnIndex > -1 && info.RowIndex > -1)
            {
                DataGridViewCellCollection list = GridView.Rows[info.RowIndex].Cells;
                StarList listToShow = new StarList();
                if (showVisibleConstellations)
                {
                    string constName = list[1].Value.ToString();
                    foreach(Star star in  main.buffer[main.curBufIndex])
                    {
                        if(star.Constellation == constName)
                        {
                            listToShow.Add(star);
                        }
                    }
                }
                else
                {             
                    Star starToShow = new Star(list[0].Value.ToString(), list[1].Value.ToString(), Convert.ToDouble(list[2].Value), Convert.ToDouble(list[3].Value), Convert.ToDouble(list[4].Value), Convert.ToDouble(list[5].Value));   
                    listToShow.Add(starToShow);
                }
                SupportingGridView.DataSource = listToShow;
                SupportingGridView.Visible = true;
                main.ResizeGridRowHeight(SupportingGridView);
            }
        }  
        
        private bool IsValid()
        {
            int repository;

            if (LongitudeText.Text.Trim() == "")
            {
                errorProvider.SetError(LongitudeText, "Enter longitude!");
                return false;
            }
            else if (!Int32.TryParse(LongitudeText.Text.Trim(), out repository))
            {
                errorProvider.SetError(LongitudeText, "Enter numerical value!");
                return false;
            }
            else if (Int32.Parse(LongitudeText.Text.Trim()) < 0 || Int32.Parse(LongitudeText.Text.Trim()) > 360)
            {
                errorProvider.SetError(LongitudeText, "Longitude varies from 0 to 360!");
                return false;
            }
            else if (LatitudeText.Text.Trim() == "")
            {
                errorProvider.SetError(LatitudeText, "Enter latitude!");
                return false;
            }
            else if (!Int32.TryParse(LatitudeText.Text.Trim(), out repository))
            {
                errorProvider.SetError(LatitudeText, "Enter numerical value!");
                return false;
            }
            else if (Int32.Parse(LatitudeText.Text.Trim()) < 0 || Int32.Parse(LatitudeText.Text.Trim()) > 360)
            {
                errorProvider.SetError(LatitudeText, "Latitude varies from 0 to 360!");
                return false;
            }
            return true;
        }   
    }
}

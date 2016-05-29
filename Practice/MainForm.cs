using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace AstronomicalDirectory
{
    public partial class MainForm : Form
    {
        //KHARKOV KHARKOV KHARKOV: LONGITUDE - 36,15 , LATITUDE - 50
        internal List<StarList> buffer;
        internal int curBufIndex { get; set; }
        internal string selectedStar;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StarList listFromFile = DataAccess.CreateListFromFile();
            if (listFromFile != null)
            {
                buffer = new List<StarList>() { listFromFile };
                UpdateGridViewAndPicture();//appropriate height of last row is 36 (average height is 22);
            }
            else
            {
                buffer = new List<StarList>() { new StarList() };
            }
            AcceptButton = StarSearch;
            this.ActiveControl = NameText;       
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (curBufIndex > 0)///////////////////////////////////////////////////////////////////////////
            {
                string result = MessageBox.Show(
                    "Do you want to exit the program with saving of the changes?",
                    "Changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button3).ToString();

                switch (result)
                {
                    case "Yes":
                        {
                            DataAccess.WriteToFile(buffer[curBufIndex]);
                            Application.ExitThread();
                        }
                        break;
                    case "No":
                        {
                            Application.ExitThread();
                        }
                        break;
                    case "Cancel":
                        {
                            e.Cancel = true;
                        }
                        break;
                }
            }
        }

        private void StarSearch_Click(object sender, EventArgs e)
        {      
            if (buffer[curBufIndex].Count != 0)
            {
                string name = NameText.Text.Trim();
                string constellation = ConstellationText.Text.Trim();
                if (NameText.Text == "" && ConstellationText.Text == "")
                {
                    GridView.DataSource = buffer[curBufIndex];
                    GridView.Visible = true;
                    errorProvider.SetError(NameText, "Fill out at least one field to start finding!");
                    errorProvider.SetError(ConstellationText, "Fill out at least one field to start finding!");
                }
                else if (ConstellationText.Text == "")
                {
                    StarList toAdd = buffer[curBufIndex].SearchByName(name);
                    if (toAdd == null)
                    {
                        PictureFooterBox.ImageLocation = "C:\\Users\\User\\Documents\\Visual Studio 2015\\Projects\\Forms\\Images\\nothingFound.jpg";
                        GridView.Visible = false;
                    }
                    else
                    {
                        GridView.DataSource = toAdd;
                        GridView.Visible = true;
                    }
                }
                else if (NameText.Text == "")
                {
                    StarList toAdd = buffer[curBufIndex].SearchByConstellation(constellation);
                    if (toAdd == null)
                    {
                        PictureFooterBox.ImageLocation = "C:\\Users\\User\\Documents\\Visual Studio 2015\\Projects\\Forms\\Images\\nothingFound.jpg";
                        GridView.Visible = false;
                    }
                    else
                    {
                        GridView.DataSource = toAdd;
                        GridView.Visible = true;
                    }
                }
                else
                {
                    StarList toAdd = buffer[curBufIndex].SearchMixed(name, constellation);
                    if (toAdd == null)
                    {
                        PictureFooterBox.ImageLocation = "C:\\Users\\User\\Documents\\Visual Studio 2015\\Projects\\Forms\\Images\\nothingFound.jpg";
                        GridView.Visible = false;
                    }
                    else
                    {
                        GridView.DataSource = toAdd;
                        GridView.Visible = true;
                    }
                }
                ResizeGridRowHeight(GridView, GridView.ColumnHeadersHeight + 1);
            }
            else
            {
                DialogResult result = MessageBox.Show("Impossible to search - dictionaty is empty! Do you want to create you first star?", "Emptiness", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    StarEditor addForm = new StarEditor();
                    addForm.Owner = this;
                    addForm.ShowDialog();
                }
            }

        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            if(ConstellationText.Text == "" && NameText.Text == "")
            {
                GridView.Visible = true;
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (NameText.Text == "" && ConstellationText.Text == "")
            {
                MessageBox.Show("Fields are empty!", "Clearising", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                NameText.Text = "";
                ConstellationText.Text = "";
            }
        }

        private void UpdateGridViewAndPicture()
        {
            GridView.DataSource = null;
            GridView.Refresh();
            GridView.DataSource = buffer[curBufIndex];
            GridView.Visible = true;
            ResizeGridRowHeight(GridView, GridView.ColumnHeadersHeight + 1);

            NameText.Text = "";
            ConstellationText.Text = "";

            if (buffer[curBufIndex].Count == 0)
            {
                PictureFooterBox.ImageLocation = @"C:\Users\User\Documents\Visual Studio 2015\Projects\Forms\Images\Animations\empty.gif";
                GridView.Visible = false;

                System.Timers.Timer myTimer = new System.Timers.Timer(2500);
                myTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
                myTimer.AutoReset = false;//only 1 time rises
                myTimer.Start();
            }
            else
            {
                this.PictureFooterBox.Visible = true;
                this.GridView.Visible = true;
                this.Size = new Size(517, 488);
            }
        }

        public void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
            this.PictureFooterBox.Visible = false;
            this.Size = new Size(517, 251);
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            if (curBufIndex > 0)///////////////////////////////////////////////////////////////////////////
            {
                StarList temp = buffer[curBufIndex];
                buffer.Clear();
                buffer.Add(temp);
                curBufIndex = 0;
                if (buffer[curBufIndex].Count == 0)
                {
                    DataAccess.WriteToFile(null);
                }
                else
                {
                    DataAccess.WriteToFile(buffer[0]);
                }
            }
        }

        private void MenuUndo_Click(object sender, EventArgs e)
        {
            if (curBufIndex > 0)//can undo to empty list ///////////////////////////////////////////////////////////////////////////
            {
                curBufIndex--;
                UpdateGridViewAndPicture();
            }

            if (buffer[curBufIndex].Count == 0 && GridView.Visible)
            {
                GridView.Visible = false;
            }
            if (buffer[curBufIndex].Count != 0 && !GridView.Visible)
            {
                GridView.Visible = true;
            }
        }

        private void MenuRedo_Click(object sender, EventArgs e)
        {
            if (curBufIndex < buffer.Count - 1)
            {
                curBufIndex++;
                UpdateGridViewAndPicture();

                if (buffer[curBufIndex].Count == 0 && GridView.Visible)
                {
                    GridView.Visible = false;
                }
                if (buffer[curBufIndex].Count != 0 && !GridView.Visible)
                {
                    GridView.Visible = true;
                }
            }
        }

        private void MenuNewStar_Click(object sender, EventArgs e)
        {
            StarEditor editorForm = new StarEditor();
            editorForm.Owner = this;
            this.Hide();
            editorForm.ShowDialog();

            UpdateGridViewAndPicture();
            //GridView.Rows[GridView.Rows.Count - 2].Height = 22;
            //GridView.Rows[GridView.Rows.Count - 1].Height = 36;
        }

        private void MenuEditStar_Click(object sender, EventArgs e)
        {
            StarEditor editorForm = new StarEditor("hello");
            editorForm.Owner = this;
            this.Hide();
            editorForm.ShowDialog();

            UpdateGridViewAndPicture();
        }

        private void MenuDeleteSingle_Click(object sender, EventArgs e)
        {
            StarEditor editorForm = new StarEditor(228);
            editorForm.Owner = this;
            this.Hide();
            editorForm.ShowDialog();

            UpdateGridViewAndPicture();
        }

        private void MenuDeleteList_Click(object sender, EventArgs e)
        {
            StarEditor editorForm = new StarEditor(228, 322);
            editorForm.Owner = this;
            this.Hide();
            editorForm.ShowDialog();

            UpdateGridViewAndPicture();
        }

        private void MenuDeleteDirectory_Click(object sender, EventArgs e)
        {
            if (buffer[curBufIndex].Count == 0)
            {
                MessageBox.Show("Impossible to delete directory - it is empty!", "Emptiness", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want do delete whole directory?", "Global deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    buffer.Add(new StarList());
                    curBufIndex = buffer.Count - 1;//////////////////////////////////////////////////////////////////////////////////////////////
                    UpdateGridViewAndPicture();
                }
            }
        }

        private void MenuShowStar_Click(object sender, EventArgs e)
        {
            ShowStars showForm = new ShowStars();
            showForm.Owner = this;
            this.Hide();
            showForm.ShowDialog();

            UpdateGridViewAndPicture();
        }

        private void MenuViewableStars_Click(object sender, EventArgs e)
        {
            ShowStars showForm = new ShowStars(228);
            showForm.Owner = this;
            this.Hide();
            showForm.ShowDialog();

            UpdateGridViewAndPicture();
        }

        private void MenuViewableConstellations_Click(object sender, EventArgs e)
        {
            ShowStars showForm = new ShowStars("228");
            showForm.Owner = this;
            this.Hide();
            showForm.ShowDialog();

            UpdateGridViewAndPicture();
        }

        private void showAnimationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StarAnimation showAnimation = new StarAnimation();
            showAnimation.Owner = this;
            this.Hide();
            showAnimation.ShowDialog();
        }

        internal void ResizeGridRowHeight(DataGridView gridView, int headerHeight)//147 height of DGV
        {
            
            int numberRowsAtAll = gridView.Rows.Count;

            if (numberRowsAtAll > 0)
            {
                int heightWithoutHeader = gridView.Height - headerHeight;//22 and 35 is height of header
                int numberRowsVisible = heightWithoutHeader / 22;//visible without scrolling   
                if (numberRowsVisible >= numberRowsAtAll)//number of elements that can fill dgv without scrolling
                {
                    int rowHeight = (heightWithoutHeader) / numberRowsAtAll;
                    int addToLast = heightWithoutHeader - rowHeight * numberRowsAtAll;
                    foreach (DataGridViewRow row in gridView.Rows)
                    {
                        row.Height = rowHeight;
                    }

                    gridView.Rows[numberRowsAtAll - 1].Height += addToLast - 1;
                }
                else
                {
                    int heightOfEmptyString = heightWithoutHeader + 22 * (numberRowsAtAll - numberRowsVisible) - 22 * numberRowsAtAll;
                    gridView.Rows[numberRowsAtAll - 1].Height += heightOfEmptyString - 1;
                }
            }
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var p = this.GridView.PointToClient(Cursor.Position);
            var info = this.GridView.HitTest(p.X, p.Y);

            if (info.RowIndex == -1)//sorting // && info.ColumnIndex >= 0 && info.ColumnIndex <= 5
            {
                string headerCellText = GridView.Columns[info.ColumnIndex].HeaderText;
                buffer[curBufIndex].BufferSort(headerCellText, "ascending");
                UpdateGridViewAndPicture();
            }
            else//we can delete or edit star, selected in gridview
            {
                DataGridViewCellCollection list = GridView.Rows[info.RowIndex].Cells;
                selectedStar = list[0].Value.ToString();
            }
        }

        private void GridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var p = this.GridView.PointToClient(Cursor.Position);
            var info = this.GridView.HitTest(p.X, p.Y);

            if (info.RowIndex == -1)//&& info.ColumnIndex >= 0 && info.ColumnIndex <= 5
            {
                string headerCellText = GridView.Columns[info.ColumnIndex].HeaderText;
                buffer[curBufIndex].BufferSort(headerCellText, "descending");
                UpdateGridViewAndPicture();
            }
            else
            {
                DataGridViewCellCollection list = GridView.Rows[info.RowIndex].Cells;
                selectedStar = list[0].Value.ToString();

                DialogBox dialogBox = new DialogBox();
                dialogBox.Owner = this;
                this.Hide();
                dialogBox.ShowDialog();

                UpdateGridViewAndPicture();
            }
        }

       
    }


}

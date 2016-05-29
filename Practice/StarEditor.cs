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
    public partial class StarEditor : Form
    {
        MainForm main { get; set; }
        bool enableEditing = false;
        bool enableSingleDeliting = false;
        bool enableListDeleting = false;
        private string curConstellation { get; set; }
        private string curStarMagnitude { get; set; }
        private string curDistance { get; set; }
        private string curRightAscension{ get; set; }
        private string curDeclension { get; set; }

        public StarEditor()
        {
            InitializeComponent();
            ListBox.Visible = false;
            NameLabel.Visible = false;
            NameBox.Visible = false;
            DeleteStar.Visible = false;
            NewNameLabel.Location = new Point(100, 54);
            NewNameText.Location = new Point(206, 54);
            AddStar.Location = new Point(50, 265);
            ClearFields.Location = new Point(195, 265);
            Cancel.Location = new Point(339, 265);
            EditStar.Visible = false;
            this.ActiveControl = NewNameText;
            AcceptButton = AddStar;
        }

        public StarEditor(string str)
        {
            InitializeComponent();
            ListBox.Visible = false;
            NewNameText.Visible = false;
            NewNameLabel.Visible = false;
            DeleteStar.Visible = false;
            EditStar.Location = new Point(50, 265);
            ClearFields.Location = new Point(195, 265);
            Cancel.Location = new Point(339, 265);
            AddStar.Visible = false;
            enableEditing = true;
            this.ActiveControl = NameBox;
            AcceptButton = EditStar;
        }

        public StarEditor(int some)
        {
            InitializeComponent();
            NameLabel.Text = "To be deleted";
            ListBox.Visible = false;
            NewNameText.Visible = false;
            ConstellationText.Visible = false;
            StarMagnitudeText.Visible = false;
            DistanceText.Visible = false;
            RightAscensionText.Visible = false;
            DeclensionText.Visible = false;
            NewNameLabel.Visible = false;
            ConstellationLabel.Visible = false;
            StarMagnitudeLabel.Visible = false;
            DistanceLabel.Visible = false;
            RightAscensionLabel.Visible = false;
            DeclensionLabel.Visible = false;
            AddStar.Visible = false;
            EditStar.Visible = false;
            ClearFields.Visible = false;
            enableSingleDeliting = true;
            DeleteStar.Location = new Point(155, 140);
            Cancel.Location = new Point(248, 140);
            NameLabel.Location = new Point(135, 100);
            NameBox.Location = new Point(211, 100);
            Size formSize = new Size(480, 300);
            this.Size = formSize;
            AcceptButton = DeleteStar;
        }

        public StarEditor(int some1, int some2)
        {
            InitializeComponent();
            NameLabel.Text = "To be deleted";
            NewNameText.Visible = false;
            ConstellationText.Visible = false;
            StarMagnitudeText.Visible = false;
            DistanceText.Visible = false;
            RightAscensionText.Visible = false;
            DeclensionText.Visible = false;
            NewNameLabel.Visible = false;
            ConstellationLabel.Visible = false;
            StarMagnitudeLabel.Visible = false;
            DistanceLabel.Visible = false;
            RightAscensionLabel.Visible = false;
            DeclensionLabel.Visible = false;
            AddStar.Visible = false;
            EditStar.Visible = false;
            ClearFields.Visible = false;
            NameBox.Visible = false;
            NameLabel.Visible = false;
            enableListDeleting = true;
            DeleteStar.Location = new Point(155, 220);
            Cancel.Location = new Point(248, 220);
            ListBox.Location = new Point(155, 20);
            ListBox.Size = new Size(167, 185);
            this.Size = new Size(480, 300);
            AcceptButton = DeleteStar;
        }

        private void StarEditor_Load(object sender, EventArgs e)
        {
            main = this.Owner as MainForm;
            if (enableSingleDeliting || enableEditing)
            {
                NameBox.DataSource = main.buffer[main.curBufIndex];                        //write into namebox element fields "name" of buffer first element
                if (main.selectedStar != null)
                {
                    NameBox.Text = main.selectedStar;
                }

                if (enableEditing)//because we cant declare "main" owner in constructor, only in method onload (1.constructor 2.declare owner in mainforn 3. declare owner in "son" form
                {
                    Star star = main.buffer[main.curBufIndex].Retrieve(NameBox.Text);
                    if (star != null) //file isn`t empty
                    {
                        ConstellationText.Text = star.Constellation;             //display other fields of buffer first element
                        StarMagnitudeText.Text = star.StarMagnitude.ToString();
                        DistanceText.Text = star.Distance.ToString();
                        RightAscensionText.Text = star.RightAscension.ToString();
                        DeclensionText.Text = star.Declension.ToString();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Impossible to edit - dictionaty is empty! Do you want to create you first star?", "Emptiness", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if(result == DialogResult.Yes)
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
                }
                else
                {
                    if (main.buffer[main.curBufIndex].Count == 0)
                    {
                        MessageBox.Show("Impossible to delete star - dictionaty is empty!", "Emptiness", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    } 
                }
            }  
            if(enableListDeleting)
            {
                if (main.buffer[main.curBufIndex].Count == 0)
                {
                    MessageBox.Show("Impossible to delete star - dictionaty is empty!", "Emptiness", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    CheckedListBox.ObjectCollection listBox = ListBox.Items;
                    foreach (Star star in main.buffer[main.curBufIndex])
                    {
                        listBox.Add(star.Name);
                    }
                }
            }
        }

        private void StarEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        private void StarEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseForm();
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            Star tempStar = main.buffer[main.curBufIndex].Retrieve(NameBox.Text);
            if(tempStar != null)
            {
                ConstellationText.Text = curConstellation = tempStar.Constellation;
                StarMagnitudeText.Text = curStarMagnitude = tempStar.StarMagnitude.ToString();
                DistanceText.Text = curDistance = tempStar.Distance.ToString();
                RightAscensionText.Text = curRightAscension = tempStar.RightAscension.ToString();
                DeclensionText.Text = curDeclension  = tempStar.Declension.ToString();
            }       
        }

        private void ClearFields_Click(object sender, EventArgs e)
        {
            if (NewNameText.Text == "" && NameBox.Text == "" && ConstellationText.Text == "" && StarMagnitudeText.Text == "" && DistanceText.Text == "" && RightAscensionText.Text == "" && DeclensionText.Text == "")
            {
                MessageBox.Show("Fields are empty!", "Clearising", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                NewNameText.Text = "";
                NameBox.Text = "";
                ConstellationText.Text = "";
                StarMagnitudeText.Text = "";
                DistanceText.Text = "";
                RightAscensionText.Text = "";
                DeclensionText.Text = "";
            }
        }

        private void AddStar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            NameBox.Text = "checked";//box not visible but also is checked for emptiness by IsValid function

            if(IsValid())//validation
            {
                Star star = main.buffer[main.curBufIndex].Retrieve(NewNameText.Text);//checking star for exsistance
                if (star == null)
                {
                    AddToBuffer();
                }
                else
                {
                    MessageBox.Show("The '" + NewNameText.Text + "' star already exists!", 
                        "Existance failure!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void AddToBuffer()
        {
            AddDeployedPart();//method required for version control
          
            StarList newList = main.buffer[main.curBufIndex].CloneList();
            Star starToAdd = new Star(//add new version of star list
                                   NewNameText.Text,
                                   ConstellationText.Text,
                                   Double.Parse(DistanceText.Text),
                                   Double.Parse(StarMagnitudeText.Text),
                                   Double.Parse(RightAscensionText.Text),
                                   Double.Parse(DeclensionText.Text));
            newList.Add(starToAdd);
            main.buffer.Add(newList);//add new version of star list
            main.curBufIndex = main.buffer.Count - 1;
            main.GridView.DataSource = newList;//updating table of stars
            main.GridView.Visible = true;

            MessageBox.Show("Succesfully added " + NewNameText.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void AddDeployedPart()//for situation when we redo several times and make changes (we must track all steps with redo also)
        {
            if (main.curBufIndex < main.buffer.Count - 1)
            {
                for (int i = main.buffer.Count - 2; i >= main.curBufIndex; i--)
                {
                    main.buffer.Add(main.buffer[i].CloneList());
                }
            } 
        }

        private void EditStar_Click(object sender, EventArgs e)
        {
            NewNameText.Text = "checked";// textbox not visible but also is checked for emptiness by IsValid function
 
            if(IsValid())
            {
                AddDeployedPart();

                StarList newList = main.buffer[main.curBufIndex].CloneList();
                Star starToEdit = newList.Retrieve(NameBox.Text);

                curConstellation = ConstellationText.Text;
                curStarMagnitude = StarMagnitudeText.Text;
                curDistance = DistanceText.Text;
                curRightAscension = RightAscensionText.Text;
                curDeclension = DeclensionText.Text;

                starToEdit.Constellation = ConstellationText.Text;
                starToEdit.StarMagnitude = Double.Parse(StarMagnitudeText.Text);
                starToEdit.Distance = Double.Parse(DistanceText.Text);
                starToEdit.RightAscension = Double.Parse(RightAscensionText.Text);
                starToEdit.Declension = Double.Parse(DeclensionText.Text);
                MessageBox.Show("Successfully edited!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                main.buffer.Add(newList);
                main.curBufIndex = main.buffer.Count - 1;
                main.GridView.DataSource = newList;
            }
        }

        private void DeleteStar_Click(object sender, EventArgs e)
        {
            if (enableSingleDeliting)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete '" + NameBox.Text + "' star?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    AddDeployedPart();

                    StarList newList = main.buffer[main.curBufIndex].CloneList();
                    newList.Remove(newList.Retrieve(NameBox.Text));
                    main.buffer.Add(newList);
                    main.curBufIndex = main.buffer.Count - 1;
                    NameBox.DataSource = null;
                    NameBox.Refresh();
                    NameBox.DataSource = newList;
                    NameBox.DisplayMember = "Name";

                    if (newList.Count == 0)
                    {
                        MessageBox.Show("Dictionary is empty!", "Emptiness");
                        CloseForm();
                    }
                }
            }
            else if (enableListDeleting)
            {
                if (ListBox.CheckedItems.Count != 0)
                {
                    string listToDelete = "";
                    foreach (string name in ListBox.CheckedItems)
                    {
                        listToDelete += "'" + name + "'" + ", ";
                    }
                    listToDelete = listToDelete.Substring(0, listToDelete.Length - 2);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete " + listToDelete + " stars?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        AddDeployedPart();

                        StarList newList = main.buffer[main.curBufIndex].CloneList();
                        foreach (string name in ListBox.CheckedItems)
                        {
                            newList.Remove(newList.Retrieve(name));
                        }
                        main.buffer.Add(newList);
                        main.curBufIndex = main.buffer.Count - 1;

                        CheckedListBox.ObjectCollection listBox = ListBox.Items;
                        listBox.Clear(); ;
                        foreach (Star star in newList)
                        {
                            listBox.Add(star.Name);
                        }

                        if (newList.Count == 0)
                        {
                            MessageBox.Show("Dictionary is empty!", "Emptiness");
                            CloseForm();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Choose at least one star to be deleted!", "Nothing marked", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private bool IsValid()
        {
            double repository;

            if (NewNameText.Text == "" || NameBox.Text == "" || ConstellationText.Text == "" || StarMagnitudeText.Text == "" || DistanceText.Text == "" || RightAscensionText.Text == "" || DeclensionText.Text == "")
            {
                MessageBox.Show("Not all fields are filled!", "Failure!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Double.TryParse(DistanceText.Text.Trim(), out repository))
            {
                errorProvider.SetError(DistanceText, "Write a number!");
                return false;
            }
            else if (Double.Parse(DistanceText.Text.Trim()) < 0 || Double.Parse(DistanceText.Text.Trim()) > 45)
            {
                errorProvider.SetError(DistanceText, "Distance varies from 0 to 45 light years!");
                return false;
            }
            else if (!Double.TryParse(StarMagnitudeText.Text.Trim(), out repository))
            {
                errorProvider.SetError(StarMagnitudeText, "Write a number!");
                return false;
            }
            else if (Double.Parse(StarMagnitudeText.Text.Trim()) < -26 || Double.Parse(StarMagnitudeText.Text.Trim()) >= 7)
            {
                errorProvider.SetError(StarMagnitudeText, "Star magnitude varies from -26 to 7 (not included)!");
                return false;
            }
            else if (!Double.TryParse(RightAscensionText.Text.Trim(), out repository))
            {
                errorProvider.SetError(RightAscensionText, "Write a number!");
                return false;
            }
            else if (Double.Parse(RightAscensionText.Text.Trim()) < 0 || Double.Parse(RightAscensionText.Text.Trim()) > 25)
            {
                errorProvider.SetError(RightAscensionText, "Right ascension varies from 0 to 25!");
                return false;
            }
            else if (!Double.TryParse(DeclensionText.Text.Trim(), out repository))
            {
                errorProvider.SetError(DeclensionText, "Write a number!");
                return false;
            }
            else if (Double.Parse(DeclensionText.Text.Trim()) < -80 || Double.Parse(DeclensionText.Text.Trim()) > 80)
            {
                errorProvider.SetError(DeclensionText, "Declension varies from -80 to 80!");
                return false;
            }

            if (enableEditing)//clause only for editor form
            {
                if (curConstellation == ConstellationText.Text.Trim() && curStarMagnitude == StarMagnitudeText.Text.Trim() && curDistance == DistanceText.Text.Trim() && curRightAscension == RightAscensionText.Text.Trim() && curDeclension == DeclensionText.Text.Trim())
                {
                    MessageBox.Show("Change at least one field to edit star properties!", "Editing", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
            }
            
            return true;    
        }

        private void CloseForm()
        {
            main.Show();
            this.Close();
        }

    }
}

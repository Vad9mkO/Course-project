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
    public partial class DialogBox : Form
    {
        MainForm main;

        public DialogBox()
        {
            InitializeComponent();
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {
            main = this.Owner as MainForm;
            MainTextLabel.Text += main.selectedStar;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete '" + main.selectedStar + "' star?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                if (main.curBufIndex < main.buffer.Count - 1)
                {
                    for (int i = main.buffer.Count - 2; i >= main.curBufIndex; i--)
                    {
                        main.buffer.Add(main.buffer[i].CloneList());
                    }
                }

                StarList newList = main.buffer[main.curBufIndex].CloneList();
                newList.Remove(newList.Retrieve(main.selectedStar));
                main.buffer.Add(newList);
                main.curBufIndex = main.buffer.Count - 1;

                if (newList.Count == 0)
                {
                    MessageBox.Show("Dictionary is empty!", "Emptiness");         
                }

                main.Show();
                this.Close();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            StarEditor editorForm = new StarEditor("hello");
            editorForm.Owner = main;
            this.Close();
            editorForm.ShowDialog();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }

        private void DialogBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                main.Show();
            }
        }

        private void DialogBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Show();
            this.Close();
        }
    }
}

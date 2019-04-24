using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Torens_van_Hanoi.Properties;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Torens_van_Hanoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int startY = 286;
        PictureBox selection;
        int[][] jaggedArray3 =
            {
                new int[] { 8, 7, 6, 5, 4, 3, 2, 1 }, // tower 1
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }, // tower 2
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }, // tower 3
            };

        
        private void Toren1_Click(object sender, EventArgs e)
        {
            if (selection != null)
            {
                int tow = whichTower(selection);
                MessageBox.Show("Attempting to move from tower" + tow.ToString() + " to tower1");
                int num = System.Convert.ToInt32(selection.Tag);
                int index = place(num, 0);
                if (index != -1)
                {
                    remove(num, tow);
                    object O = Resources.ResourceManager.GetObject("Ring8");
                    selection.Image = (Image)O;
                    MessageBox.Show("Multiplier = " + index.ToString());
                    MessageBox.Show("Offset = " + (index * 9).ToString());
                    selection.Location = new Point(selection.Location.X, startY - ((index) * 8));
                    if (tow == 1)
                        selection.Location = selection.Location - new Size(200, 0);
                    else if (tow == 2)
                        selection.Location = selection.Location - new Size(400, 0);
                    selection = null;
                }
                else
                {
                    MessageBox.Show("Cannot place!");
                }
            }
        }

        private void Toren2_Click(object sender, EventArgs e)
        {
            if (selection != null)
            {
                int tow = whichTower(selection);
                MessageBox.Show("Attempting to move from tower" + tow.ToString() + " to tower2");
                int num = System.Convert.ToInt32(selection.Tag);
                int index = place(num, 1);
                if (index != -1){
                    remove(num, tow);
                    object O = Resources.ResourceManager.GetObject("Ring8");
                    selection.Image = (Image)O;
                    MessageBox.Show("Offset = " + (index * 9).ToString());
                    selection.Location = new Point(selection.Location.X, startY - (index * 8) );
                    if (tow == 0)
                        selection.Location = selection.Location + new Size(200, 0);
                    else if (tow == 2)
                        selection.Location = selection.Location - new Size(200, 0);
                    selection = null;
                }
                else
                {
                    MessageBox.Show("Cannot place!");
                }
            }
        }
        private void Toren3_Click(object sender, EventArgs e)
        {
            if (selection != null)
            {
                int tow = whichTower(selection);
                MessageBox.Show("Attempting to move from tower" + tow.ToString() + " to tower3");
                int num = System.Convert.ToInt32(selection.Tag);
                int index = place(num, 2);
                if (index != -1)
                {
                    remove(num, tow);
                    object O = Resources.ResourceManager.GetObject("Ring8");
                    selection.Image = (Image)O;
                    MessageBox.Show("Offset = " + (index * 9).ToString());
                    selection.Location = new Point(selection.Location.X, startY - (index * 8));
                    if (tow == 1)
                        selection.Location = selection.Location + new Size(200, 0);
                    else if (tow == 0)
                        selection.Location = selection.Location + new Size(400, 0);
                    selection = null;
                }
                else
                {
                    MessageBox.Show("Cannot place!");
                }
            }
        }

        private int remove(int num, int tow)
        {
            int x = 0;
            for (int i = 0; i < jaggedArray3[tow].Length; i++)
            {
                if (jaggedArray3[tow][i] == num)
                {
                    jaggedArray3[tow][i] = 0;
                    MessageBox.Show("Removed ring" + num.ToString() + " from tower" + tow.ToString());
                    break;
                }
            }
            return x;
        }
        private int place(int num, int tow)
        {
            int index = -1;
            for (int i = 0; i < jaggedArray3[tow].Length; i++)
            {
                if ( (i > 0) && (jaggedArray3[tow][i] == 0) && (jaggedArray3[tow][i-1] > num) )
                {
                    jaggedArray3[tow][i] = num;
                    index = i;
                }
                else if ((i == 0) && (jaggedArray3[tow][i] == 0))
                {
                    jaggedArray3[tow][i] = num;
                    index = i;
                }
            }
            return index;
        }

        private int whichTower(PictureBox pic)
        {
            int num = 0;
            if (pic.Location.X < 200)
                num = 0;
            else if (pic.Location.X < 400)
                num = 1;
            else if (pic.Location.X < 600)
                num = 2;
            return num;
        }

        private void Select(object sender, EventArgs e)
        {
            PictureBox pic = (sender as PictureBox);
            if (pic != selection)
            {
                int num = System.Convert.ToInt32(pic.Tag);
                int tow = whichTower(pic);
                MessageBox.Show("This ring is on tower" + tow.ToString());
                for (int y = 0; y < jaggedArray3[tow].Length; y++)
                {
                    //MessageBox.Show(jaggedArray3[tow][y].ToString());
                    if ((jaggedArray3[tow][y] != 0) && (jaggedArray3[tow][y] < num))
                        return;
                }
                object O = Resources.ResourceManager.GetObject("Ring8select");
                pic.Image = (Image)O;
                selection = pic;
            }
            else
            {
                object O = Resources.ResourceManager.GetObject("Ring8");
                selection.Image = (Image)O;
                selection = null;
            }
        }


    }
}

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
        int moves = 0;
        Boolean solving = false;

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
                int num = System.Convert.ToInt32(selection.Tag);
                int index = place(num, 0);
                if (index != -1)
                {
                    remove(num, tow);
                    object O = Resources.ResourceManager.GetObject("Ring8");
                    selection.Image = (Image)O;
                    selection.Location = new Point(selection.Location.X, startY - ((index) * 8));
                    if (tow == 1)
                        selection.Location = selection.Location - new Size(200, 0);
                    else if (tow == 2)
                        selection.Location = selection.Location - new Size(400, 0);
                    selection = null;
                }
            }
        }

        private void Toren2_Click(object sender, EventArgs e)
        {
            if (selection != null)
            {
                int tow = whichTower(selection);
                int num = System.Convert.ToInt32(selection.Tag);
                int index = place(num, 1);
                if (index != -1){
                    remove(num, tow);
                    object O = Resources.ResourceManager.GetObject("Ring8");
                    selection.Image = (Image)O;
                    selection.Location = new Point(selection.Location.X, startY - (index * 8) );
                    if (tow == 0)
                        selection.Location = selection.Location + new Size(200, 0);
                    else if (tow == 2)
                        selection.Location = selection.Location - new Size(200, 0);
                    selection = null;
                }
            }
        }
        private void Toren3_Click(object sender, EventArgs e)
        {
            if (selection != null)
            {
                int tow = whichTower(selection);
                int num = System.Convert.ToInt32(selection.Tag);
                int index = place(num, 2);
                if (index != -1)
                {
                    remove(num, tow);
                    object O = Resources.ResourceManager.GetObject("Ring8");
                    selection.Image = (Image)O;
                    selection.Location = new Point(selection.Location.X, startY - (index * 8));
                    if (tow == 1)
                        selection.Location = selection.Location + new Size(200, 0);
                    else if (tow == 0)
                        selection.Location = selection.Location + new Size(400, 0);
                    selection = null;
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
                    ///MessageBox.Show("Removed ring" + num.ToString() + " from tower" + tow.ToString());
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
            if (index != -1)
            {
                moves++;
                LabelMovesDisplay.Text = "Moves: " + moves.ToString();
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
            if (solving)
                return;
            PictureBox pic = (sender as PictureBox);
            
            if (pic != selection)
            {
                if (selection != null)
                {
                    object O2 = Resources.ResourceManager.GetObject("Ring8");
                    selection.Image = (Image)O2;
                    selection = null;
                }
                int num = System.Convert.ToInt32(pic.Tag);
                int tow = whichTower(pic);
                ///MessageBox.Show("This ring is on tower" + tow.ToString());
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
        private void reset()
        {
            moves = 0;
            LabelMovesDisplay.Text = "Moves: " + moves.ToString();
            for (int i = 0; i < jaggedArray3.Length; i++)
            {
                for (int y = 0; y < jaggedArray3[i].Length; y++)
                {
                    if (i > 0)
                        jaggedArray3[i][y] = 0;
                    else
                        jaggedArray3[i][y] = (8 - y);
                }
            }
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(PictureBox))
                {
                    PictureBox pic = (PictureBox)c;
                    if (pic.Tag != null)
                    {
                        int num = System.Convert.ToInt32(pic.Tag);
                        object O = Resources.ResourceManager.GetObject("Ring8");
                        pic.Image = (Image)O;
                        int tow = whichTower(pic);
                        num = 8 - num;
                        pic.Location = pic.Location - new Size(200 * tow, 0);
                        pic.Location = new Point(pic.Location.X, startY - (num * 8));
                    }
                }
            }
        }
        private void Btn_ResetGame_Click(object sender, EventArgs e)
        {
            reset();
        }
        public static void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        private void visualise(int num, int from, int to, int index)
        {
            // 0 -> 1
            // 2 -> 0
            PictureBox theRing = null;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(PictureBox))
                {
                    PictureBox pic = (PictureBox)c;
                    if (pic.Tag != null)
                    {
                        int i = System.Convert.ToInt32(pic.Tag);
                        if (num == i)
                        {
                            theRing = pic;
                            break;
                        }
                    }
                }
            }

            int diff = Math.Abs(from - to);
            int offset = 200;
            int moving = diff * offset;
            if (from > to)
                moving = moving * -1;
            //MessageBox.Show("Index = " + index.ToString());
            theRing.Location = new Point(theRing.Location.X, startY - (index * 8));
            theRing.Location = theRing.Location + new Size(moving, 0);
            moves++;
            LabelMovesDisplay.Text = "Moves: " + moves.ToString();
            wait(100);
            //MessageBox.Show("Diff = " + moving.ToString());

        }

        string intToString(int tow)
        {
            string result = "A";
            if (tow == 1)
                result = "B";
            else if (tow == 2)
                result = "C";
            return result;
        }
        void move(int num, int from, int to)
        {
            //Move disk 1 from peg Ato peg B
            string towA = intToString(from);
            string towB = intToString(to);
            int index = 0;
            //MessageBox.Show("Moving ring" + num.ToString() + " from tower " + towA + " to tower " + towB);
            // Remove int from array A
            for (int i = 0; i < jaggedArray3[from].Length; i++)
            {
                if(jaggedArray3[from][i] == num)
                {
                    jaggedArray3[from][i] = 0;
                    break;
                }
            }

            // Add int into array B
            for (int y = 0; y < jaggedArray3[to].Length; y++)
            {
                if (jaggedArray3[to][y] == 0)
                {
                    jaggedArray3[to][y] = num;
                    index = y;
                    break;
                }
            }

            visualise(num,from,to,index);

        }

        void towers(int num, int frompeg, int topeg, int auxpeg)
        {
            if (num == 1)
            {

                //Debug.WriteLine("Move disk 1 from peg " + frompeg + "to peg " + topeg);
                move(1, frompeg, topeg);
                return;
            }
            towers(num - 1, frompeg, auxpeg, topeg);
            move(num, frompeg, topeg);
            //Debug.WriteLine("Move disk " + num.ToString() + " from peg " + frompeg + " to peg " + topeg);
            towers(num - 1, auxpeg, topeg, frompeg);
        }

        private void Btn_Solve_Click(object sender, EventArgs e)
        {
            reset();
            Btn_ResetGame.Enabled = false;
            solving = true;
            Btn_Solve.Text = "Solving..";
            towers(8, 0, 2, 1);
            Btn_Solve.Text = "Solve";
            solving = false;
            Btn_ResetGame.Enabled = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper_3
{
    public partial class Form1 : Form
    {
        int dim = 0;

        int minecount = 0;
        cell[,] Cs = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void initmines()
        {
            Random r = new Random();

            for (int mi = 1; mi <= minecount; mi++)
            {

                int ri = r.Next(dim);
                int ci = r.Next(dim);
                if (Cs[ri, ci].getnum() == -1)
                {
                    mi--;
                    continue;
                }
                Cs[ri, ci].Setnum(-1);
                //Cs[ri, ci].Text = Cs[ri, ci].getnum().ToString();

            }
            for (int ri = 0; ri < dim; ri++)
            {
                for (int ci = 0; ci < dim; ci++)
                {
                    if (Cs[ri, ci].getnum() == -1)
                    {

                        continue;
                    }
                    int minecount = WindowCount(ri, ci);
                   Cs[ri, ci].Setnum(minecount);
                    //Cs[ri, ci].Text = Cs[ri, ci].getnum().ToString();
                }
            }
        }
        int WindowCount(int ri, int ci)
        {
            int count = 0;
            for (int r = ri - 1; r <= ri + 1; r++)
            {

                for (int c = ci - 1; c <= ci + 1; c++)
                {
                    if (r == ri && c == ci || r < 0 || c < 0 || r >= dim || c >= dim)
                    {
                        continue;
                    }
                    if (Cs[r, c].getnum() == -1)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        private void loadcells()
        {
            board.Controls.Clear();
            Cs = new cell[dim, dim];
            int h = board.Height / dim - 7;
            int w = board.Width / dim - 7;
            for (int ri = 0; ri < dim; ri++)
            {
                for (int ci = 0; ci < dim; ci++)
                {

                    cell c = new cell(ri, ci, h, w);
                    c.Click += new System.EventHandler(this.cell_Click);
                    board.Controls.Add(c);
                    Cs[ri, ci] = c;
                }



            }
            initmines();
        }
        void Openrec(int ri, int ci)
        {
            if (Cs[ri, ci].isopen == true)
            {
                return;
            }
            Cs[ri, ci].isopen = true;
            for (int r = ri - 1; r <= ri + 1; r++)
            {
                for (int c = ci - 1; c <= ci + 1; c++)
                {
                    if (r < 0 || r >= dim || c < 0 || c >= dim)
                    {
                        continue;
                    }
                    if (Cs[r, c].isopen == false)
                    {

                        if (Cs[r, c].getnum() != 0)
                        {
                            Cs[r, c].Text = Cs[r, c].getnum().ToString();
                            Cs[r, c].isopen = true;
                        }
                        else if (Cs[r, c].getnum() == 0)
                        {

                            Openrec(r, c);
                        }
                        Cs[r, c].BackColor = Color.Gray;
                    }
                }
            }
        }
        void openall(int r, int c)
        {
            for (int ri = r - 1; ri <= ri + 1; ri++)
            {
                for (int ci = c - 1; ci <= ci + 1; ci++)
                {
                    if ((ri == r && ci == c) || ri < 0 || ri >= dim || ci < 0 || ci >= dim)
                    {
                        continue;
                    }
                    Cs[ri, ci].isopen = true;
                    Cs[ri, ci].Text = Cs[ri, ci].getnum().ToString();

                    Cs[ri, ci].BackColor = Color.Gray;

                }
            }

        }
        void Openite(int ri, int ci)
        {
            if (Cs[ri, ci].isopen == true)
            {
                return;
            }
            Cs[ri, ci].isopen = true;
            for (int r = 0; r < dim; r++)
            {
                for (int c = 0; c < dim; c++)
                {

                    if (Cs[r, c].isopen == false)
                    {

                        if (Cs[r, c].getnum() == 0 || Cs[r, c].isopen == true)
                        {
                            if (surroundingcheck(r, c))
                            {
                                openall(r, c);
                            }


                        }
                        else if (Cs[r, c].getnum() == 0)
                        {


                        }
                        Cs[r, c].BackColor = Color.Gray;
                    }
                }
            }
        }

        bool surroundingcheck(int r, int c)
        {
            for (int ri = r - 1; ri <= ri + 1; ri++)
            {
                for (int ci = c - 1; ci <= ci + 1; ci++)
                {
                    if ((ri == r && ci == c) || ri < 0 || ri >= dim || ci < 0 || ci >= dim)
                    {
                        continue;
                    }
                    if (Cs[ri, ci].isopen == false)
                        return true;


                }
            }
            return false;
        }
        private void cell_Click(object sender, EventArgs e)
        {
            cell c = (cell)sender;
            MouseEventArgs Me = (MouseEventArgs)e;
            if (Me.Button == MouseButtons.Right)
            {
                c.BackColor = Color.Red;
                c.flag = true;
            }

            if (c.flag == true)
            {
                return;
            }
            if (c.flag == true)
            {
                return;
            }
            if (c.getnum() == -1)
            {
                MessageBox.Show("game over");
                start.Text = ":(";
                board.Controls.Clear();
            }
            else if (c.getnum() != 0)
            {
                c.Text = c.getnum().ToString();
            }
            else
            {
                Openrec(c.getri(), c.getci());
                //Openite(c.getri(), c.getci());
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (beginner.Checked)
            {
                dim = 9;
                minecount = 10;
            }
            if (medium.Checked)
            {
                dim = 15;
                minecount = 20;

            }
            if (hard.Checked)
            {
                dim = 25;
                minecount = 30;

            }
            if (dim == 0)
            {
                MessageBox.Show("select level");
                return;
            }
            loadcells();
        }
    }
}

    
   

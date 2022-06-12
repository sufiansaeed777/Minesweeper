using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace minesweeper_3
{
    class cell:Button
    {
        int num = 0;
        public bool isopen = false;
        public bool flag = false;
        int ri, ci;
        public cell(int r, int c, int h, int w)
        {
            this.Height = h;
            this.Width = w;
            this.ri = r;
            this.ci = c;

        }
        public int getri()
        {
            return ri;
        }
        public int getci()
        {
            return ci;
        }
        public void Setnum(int n)
        {
            num = n;
        }
        public int getnum()
        {
            return num;
        }
    }
}
    

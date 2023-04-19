using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Laba_9_OAIP_NEW
{
    abstract public class Figure
    {
        public string Name { get; set; }
        public int x;
        public int y;
        public int w;
        public int h;
        abstract public void Draw();
        abstract public void MoveTo(int x, int y, string Name);
        public void DeleteF(Figure figure, bool flag = true)
        {
            if (flag == true)
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                ShapeContainer.figurelist.Remove(figure);
                this.Clear();
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in ShapeContainer.figurelist)
                {
                    f.Draw();
                }
            }
            else
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                ShapeContainer.figurelist.Remove(figure);
                this.Clear();
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in ShapeContainer.figurelist)
                {
                    f.Draw();
                }
                ShapeContainer.figurelist.Add(figure);
            }
        }
        public void Clear()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.White);
        }
    }
}

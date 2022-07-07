using System;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Castle
    {
        public Image img=new Bitmap(Properties.Resources.Castle);
        public int x;
        public int y;
        public int endurance;//прочность замка

        //создание объекта класса
        public Castle(int x, int y)
        {
            this.x = x;
            this.y = y;
            Random rand = new Random();
            endurance = rand.Next(5000, 50000);
        }

        //вывод замка
        public void Draw(Graphics g)
        {
            g.DrawImage(img, x, y, 100, 100);//прорисовка
        }
    }
}

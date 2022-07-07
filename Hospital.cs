using System.Drawing;

namespace WindowsFormsApp1
{
    class Hospital
    {
        public int x;
        public int y;
        public Image img = new Bitmap(Properties.Resources.Hospital);

        //создание объекта класса
        public Hospital(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //отрисовка одного объекта
        public void Draw (Graphics g)
        {
            g.DrawImage(img, x, y, 100, 90);//прорисовка
        }
    }
}

using System;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Knight
    {
        public int r;//радис шара(графического объекта, являющегося рыцарем)
        public Brush brush;//кисть для закрашивания шара
        public int x;//координата x
        public int y;//координата y
        public int health;//здоровье рыцаря
        public int power;//силы удара
        public int gox = -1;//координата x замка или лечебницы
        public int goy = -1;//координата y замка или лечебницы
        //значения шагов по осям
        public int dx = 1;
        public int dy = 1;

        //создание объекта класса
        public Knight(int x, int y)
        {
            this.x = x;
            this.y = y;
            r = 5;
            Random rand = new Random();
            health = rand.Next(10, 20);
            power = rand.Next(20, 500);
        }

        //законы перемещения рыцаря
        public void Position()
        {
            //при хаотичном движении шара
            //проверяю, выйдет ли объект за пределы возможного пространства
            if (x >= (Form.ActiveForm.Width - 5 * (r + dx)) || x <= 5)
                dx = -dx;
            if (y >= (Form.ActiveForm.Height - 15 * (r + dy)) || y <= 40)
                dy = -dy;
            //строим маршрут к нужной точке, т.е. координате замка или лечебницы
            if (gox != -1 && goy != -1)
            {
                if ((gox < x && dx > 0) || (gox > x && dx < 0))
                    dx = -dx;
                if ((goy < y && dy > 0) || (goy > y && dy < 0))
                    dy = -dy;
            }
            //подсчет новых координат x и y
            x += dx;
            y += dy;
        }

        //перерисовка рыцаря
        public void Move(Graphics g)
        {
            Position();//вычисление новой координаты шара
            if (health > 0) brush = new SolidBrush(Color.Green);
            else brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, x, y, 2 * r, 2 * r);//прорисовка
        }
    }
}

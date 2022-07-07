using System;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        //необходимые переменные
        private int totalTime = 0;
        List<Knight> knights = new List<Knight>{};
        List<Hospital> hospitals = new List<Hospital>{};
        Castle castle;
        Graphics g;
        //радиусы
        public int rKn = 0;//видимости рыцарей
        //переменные с результатами симуляции
        private int castleCounter = 0;
        private int hospitalisationCount = 0;
        private int talksCount = 0;

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            StopButton.Visible = false;
            labelOver.Visible = false;
        }

        
        private void timer_Tick(object sender, EventArgs e)
        {
            totalTime++;
            timerLabel.Text = totalTime.ToString();
            timerLabel.Refresh();
        }

        private void ControlButton_Click(object sender, EventArgs e)
        {
            rKn = trackBarVis.Value;
            Random rnd = new Random();
            int x;
            int y;
            for (int i = 0; i < trackBarKnight.Value; i++)
            {
                x = rnd.Next(40, Form.ActiveForm.Width - 40);
                y = rnd.Next(40, Form.ActiveForm.Height - 40);
                Knight kn = new Knight(x,y);
                knights.Add(kn);
            }
            for (int i = 0; i < trackBarHospital.Value;i++)
            {
                x = rnd.Next(40, Form.ActiveForm.Width - 100);
                y = rnd.Next(40, Form.ActiveForm.Height - 150);
                Hospital h = new Hospital(x, y);
                hospitals.Add(h);
            }
            x = rnd.Next(40, Form.ActiveForm.Width - 100);
            y = rnd.Next(40, Form.ActiveForm.Height - 150);
            castle = new Castle(x, y);
            timerToDraw.Start();
            trackBarKnight.Visible = false;
            ControlButton.Visible = false;
            helpButton.Visible = false;
            knightTextBox.Visible = false;
            labelKn.Visible = false;
            trackBarHospital.Visible = false;
            castleTextBox.Visible = false;
            labelC.Visible = false;
            StopButton.Visible = true;
            trackBarVis.Visible = false;
            textBoxVis.Visible = false;
            labelVis.Visible = false;
            timer.Start();
        }

        //отрисовка нового состояния окна
        private void timerToDraw_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Update();
            Logic();
        }

        //для наглядности - показ текущего кол-ва рыцарей
        private void trackBarKnight_Scroll(object sender, EventArgs e)
        {
            knightTextBox.Text = trackBarKnight.Value.ToString();
        }

        //для наглядности - показ текущего кол-ва лечебниц
        private void trackBarHospital_Scroll(object sender, EventArgs e)
        {
            castleTextBox.Text = trackBarHospital.Value.ToString();
        }

        //логика симуляции
        private void Logic()
        {
            int unhealthy = 0;
            castle.Draw(g);
            foreach (Hospital h in hospitals)
            {
                h.Draw(g);
            }
            double check = 0;
            double tmp = 0;
            foreach (Knight kn in knights)
            {
                int ax = Convert.ToInt32(Math.Sqrt(2) * kn.r) + kn.x;//координата рыцаря по x (центр круга)
                int ay = Convert.ToInt32(Math.Sqrt(2) * kn.r) + kn.y;//координата рыцаря по y (центр круга)

                //если рыцарь здоров
                if (kn.health > 0) 
                {
                    int bx = Convert.ToInt32(Math.Sqrt(2) * 50) + castle.x;//координата центра замка x
                    int by = Convert.ToInt32(Math.Sqrt(2) * 50) + castle.y;//координата центра замка y
                    check = Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2));//смотрим расстояние между центрами точек
                    tmp = rKn + 50*Math.Sqrt(2);

                    //если рыцарь не знает, где замок
                    if ((kn.gox == -1 && kn.goy == -1) && (check <= tmp))
                    {
                        kn.gox = castle.x;
                        kn.goy = castle.y;
                    }

                    //проверка, может ли рыцарь атаковать замок
                    tmp = rKn + 10*Math.Sqrt(2);
                    if (check <= tmp)
                    {
                        castle.endurance = castle.endurance - kn.power;//прочность замка снижается
                        kn.health--;//как и здоровье рыцаря
                    }
                    if (kn.health<=0)
                    {
                        kn.gox = -1;
                        kn.goy = -1;
                    }
                }
                //тогда ему нужно в лечебницу
                else
                {
                    foreach (Hospital h in hospitals)
                    {
                        //точно также ищем центр лечебницы
                        int bx = Convert.ToInt32(Math.Sqrt(2) * 50) + h.x;
                        int by = Convert.ToInt32(Math.Sqrt(2) * 45) + h.y;
                        check = Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2));//проверка расстояния между точками
                        tmp = rKn + Math.Sqrt(Math.Pow(45, 2) + Math.Pow(50, 2));

                        //если рыцарь не знает, где данная лечебница
                        if ((kn.gox == -1 && kn.goy == -1) && (check <= tmp))
                        {
                            kn.gox = h.x;
                            kn.goy = h.y;
                            unhealthy++;
                        }
                        tmp = rKn + 10 * Math.Sqrt(2);
                        if (check <= tmp)
                        {
                            Random rand = new Random();
                            kn.health = rand.Next(10, 20);
                            hospitalisationCount++;
                            unhealthy--;
                        }
                        if (kn.health > 0)
                        {
                            kn.gox = -1;
                            kn.goy = -1;
                        }
                    }
                }
                if(unhealthy==trackBarKnight.Value)
                {
                    timer.Stop();
                    labelEndBef.Visible = true;
                    Over();
                }
                //и прорисовываем рыцаря
                kn.Move(g);
            }
            //создаем новый замок
            if (castle.endurance <= 0)
            {
                castleCounter++;
                Random rand = new Random();
                int x = rand.Next(40, Form.ActiveForm.Width - 100);
                int y = rand.Next(40, Form.ActiveForm.Height - 150);
                castle = new Castle(x, y);
                foreach (Knight kn in knights)
                {
                    kn.gox = -1;
                    kn.goy = -1;
                }
            }
            //связь рыцаря с другими
            foreach (Knight kn in knights)
            {
                int ax = Convert.ToInt32(Math.Sqrt(2) * kn.r) + kn.x;//координата рыцаря по x (центр круга)
                int ay = Convert.ToInt32(Math.Sqrt(2) * kn.r) + kn.y;//координата рыцаря по y (центр круга)
                if (kn.health > 0)
                {
                    foreach (Knight k in knights)
                    {
                        if (k.health > 0)
                        {
                            int bx = Convert.ToInt32(Math.Sqrt(2) * k.r) + k.x;
                            int by = Convert.ToInt32(Math.Sqrt(2) * k.r) + k.y;
                            check = Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2));//проверка расстояния между точками
                            if (check <= tmp)
                            {
                                if (k.gox != -1 && kn.gox == -1)
                                {
                                    kn.gox = k.gox;
                                    kn.goy = k.goy;
                                    talksCount++;
                                }
                                if (kn.gox != -1 && k.gox == -1)
                                {
                                    k.gox = kn.gox;
                                    k.goy = kn.goy;
                                    talksCount++;
                                }
                            }
                        }
                    }
                }
                else
                {
                    foreach (Knight k in knights)
                    {
                        if (k.health < 0)
                        {
                            int bx = Convert.ToInt32(Math.Sqrt(2) * k.r) + k.x;
                            int by = Convert.ToInt32(Math.Sqrt(2) * k.r) + k.y;
                            check = Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2));//проверка расстояния между точками
                            if (check <= tmp)
                            {
                                if (k.gox != -1 && kn.gox == -1) 
                                {
                                    kn.gox = k.gox;
                                    kn.goy = k.goy;
                                    talksCount++;
                                }
                                if (kn.gox != -1 && k.gox == -1) 
                                {
                                    k.gox = kn.gox;
                                    k.goy = kn.goy;
                                    talksCount++;
                                }
                            }
                        }

                    }
                }
                castle.Draw(g);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Over();
        }

        private void Over()
        {
            timerToDraw.Stop();
            StopButton.Visible = false;
            g.Clear(Color.White);
            labelOver.Visible = true;
            labelAuthor.Visible = true;
            timerLabel.Visible = false;
            labelTimer.Visible = false;

            labelKnOv.Visible = true;
            labelCasOver.Visible = true;
            labelHospOv.Visible = true;
            labelTimeOv.Visible = true;
            labelTalk.Visible = true;

            knOv.Visible = true;
            knOv.Text = trackBarKnight.Value.ToString();
            knOv.Refresh();

            casOv.Visible = true;
            casOv.Text = castleCounter.ToString();
            casOv.Refresh();

            hospOv.Visible = true;
            hospOv.Text = hospitalisationCount.ToString();
            hospOv.Refresh();

            timeOv.Visible = true;
            timeOv.Text = totalTime.ToString();
            timeOv.Refresh();

            talkOv.Visible = true;
            talkOv.Text = talksCount.ToString();
            talkOv.Refresh();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.ShowDialog();
        }

        private void trackBarVis_Scroll(object sender, EventArgs e)
        {
            textBoxVis.Text = trackBarVis.Value.ToString();
        }
    }
}
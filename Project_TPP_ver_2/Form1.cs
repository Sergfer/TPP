using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_TPP_ver_2
{
    public partial class Polygons : Form
    {
        public Polygons()
        {
            InitializeComponent();
            DoubleBuffered = true; //Перерисовка через доп буфер для предотвращения мерцания
            Radius.Radius_changing += Radius_changed; //Добавление обработчика события
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        List<Shape> dot_list = new List<Shape>(); //Список всех вершин

        private int dot_type = 0; //Типы вершин
        private int Alg_Type = 0; //Типы алгоритмов отрисовки фигуры

        private Form radius;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (dot_list.Count >= 3)
            {
                if (Alg_Type == 0) //Алгоритм по определению
                {
                    for (int i = 0; i < dot_list.Count; i++)
                    {                                                 //Перебираем все пары вершин из списка
                        for (int g = i + 1; g < dot_list.Count; g++)
                        {
                            var cell_1 = dot_list[i];
                            var cell_2 = dot_list[g];
                            double k = ((double)cell_1.Y - cell_2.Y) / (cell_1.X - cell_2.X); //Получаем коэффициенты для уравнения прямой
                            double b = cell_1.Y - k * cell_1.X;
                            bool a = true;

                            for (int f = 0; f < dot_list.Count; f++)
                            {
                                if (f == i || f == g) //Нам требуется перебрать все точки, кроме тех, через которые мы проводим прямую
                                {
                                    continue;
                                }
                                if (dot_list[f].Y >= dot_list[f].X * k + b) //Условие нестрогое, чтобы можно было поставить вершину на сторону многоугольника
                                {
                                    a = false;
                                    break;
                                }
                            }

                            if (a == false)
                            {
                                a = true;
                                for (int f = 0; f < dot_list.Count; f++)
                                {
                                    if (f == i || f == g)
                                    {
                                        continue;
                                    }
                                    if (dot_list[f].Y <= dot_list[f].X * k + b)
                                    {
                                        a = false;
                                        break;
                                    }
                                }
                            }

                            if (a == true)
                            {
                                dot_list[i].Is_peak = true;
                                dot_list[g].Is_peak = true;
                                e.Graphics.DrawLine(new Pen(Color.Black), cell_1.X, cell_1.Y, cell_2.X, cell_2.Y);
                            }
                        }
                    }
                }

                if (Alg_Type == 1)
                {
                    var roll = new List<Shape>();

                    double Vector_Len(Shape a, Shape b) //Расчет длинны вектора
                    {
                        return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
                    }

                    (double X, double Y) Vector_Coord(Shape fir, Shape sec) //Расчет координат вектора
                    {
                        return (sec.X - fir.X, sec.Y - fir.Y);
                    }

                    double Angle(Shape prev, Shape now, Shape next) //Расчет угла для 3-х веришин
                    {
                        if (now == next)
                            return 0;
                        return Math.Acos((Vector_Coord(now, prev).X * Vector_Coord(now, next).X + Vector_Coord(now, prev).Y * Vector_Coord(now, next).Y) / (Vector_Len(now, prev) * Vector_Len(now, next)));
                    }

                        var dot = dot_list[0]; //Ищем самую левую верхнюю точку
                        foreach (var a in dot_list)
                        {
                            if (a.Y < dot.Y) dot = a;
                            else if (a.Y == dot.Y)
                                if (a.X < dot.X)
                                    dot = a;
                        }

                        dot.Is_peak = true;
                        roll.Add(dot);

                        foreach (var cell in dot_list) //Ищем вершину, которая дает максимальный угол c точкой на левой границе экрана
                        {
                            if (Angle(new Circle(0, roll[0].Y), roll[0], cell) > Angle(new Circle(0, roll[0].Y), roll[0], dot))
                                dot = cell;
                            else if (Angle(new Circle(0, roll[0].Y), roll[0], cell) == Angle(new Circle(0, roll[0].Y), roll[0], dot))
                                if (Vector_Len(roll[0], cell) > Vector_Len(roll[0], dot))
                                    dot = cell;
                        }

                        dot.Is_peak = true;
                        roll.Add(dot);

                    e.Graphics.DrawLine(new Pen(Color.Black), roll[0].X, roll[0].Y, roll[1].X, roll[1].Y);

                        int i = 1;
                        do
                        {
                            var next = roll[i];
                            foreach (var cell in dot_list)
                            {
                                if (Angle(roll[i - 1], roll[i], cell) > Angle(roll[i - 1], roll[i], next))
                                    next = cell;
                                else if (Angle(roll[i - 1], roll[i], cell) == Angle(roll[i - 1], roll[i], next))
                                    if (Vector_Len(roll[i], cell) > Vector_Len(roll[i], next)) //Если углы равны, то берём самую дальнюю из точек
                                        next = cell;
                            }

                            next.Is_peak = true;
                            roll.Add(next);
                            i++;
                            e.Graphics.DrawLine(new Pen(Color.Black), roll[i - 1].X, roll[i - 1].Y, roll[i].X, roll[i].Y);
                        } while (roll[0] != roll[i]);
                }

                for (int f = 0; f < dot_list.Count; f++) //Отрисовка, если на экране многоугольник
                {
                    var point = dot_list[f];
                    if (point.Is_peak == false && point.IsPressed == false)
                    {
                        dot_list.RemoveAt(f);
                        continue;
                    }

                    point.Draw(e.Graphics);
                    point.Is_peak = false;
                }

            }
            else
                foreach (var point in dot_list) //Отрисовка, если на экране нет многоугольика
                {
                    point.Draw(e.Graphics);
                }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {

                case MouseButtons.Right:
                    for (int i = dot_list.Count - 1; i >= 0; i--) //Удаление вершины
                        if (dot_list[i].IsInside(e.X, e.Y))
                        {
                            dot_list.RemoveAt(i);
                            break;
                        }
                    Refresh();
                    break;

                case MouseButtons.Left:
                    for (int i = 0; i < dot_list.Count; i++) //Два цикла, чтобы можно было двигать сразу несколько вершин, если они наложились друг на друга
                    {
                        if(dot_list[i].IsInside(e.X, e.Y))
                        {
                            for (int j = 0; j < dot_list.Count; j++)
                            {
                                if (dot_list[j].IsInside(e.X, e.Y))
                                {
                                    dot_list[j].IsPressed = true;
                                    dot_list[j].Dist = (e.X - dot_list[j].X, e.Y - dot_list[j].Y);
                                }
                            }
                            return;
                        }
                    }      

                    var check = dot_list;

                    switch (dot_type) //Выбираем тип вершины;
                    {
                        case 0:
                            dot_list.Add(new Circle(e.X, e.Y));
                            break;
                        case 1:
                            dot_list.Add(new Square(e.X, e.Y));
                            break;
                        case 2:
                            dot_list.Add(new Triangle(e.X, e.Y));
                            break;
                    }
                    Refresh();

                    if (check.Count == dot_list.Count) //Если количество вершин и сами вершины не именились, то пользователь кликнул по внутренней части многоугольника
                    {
                        bool test = true;
                        for (int i = 0; i < check.Count; i++)
                        {
                            if (check[i] != dot_list[i])
                            {
                                test = false;
                                break;
                            }
                        }

                       if (test == true)
                            foreach (var cell in dot_list) //Все точки становятся активными
                            {
                                cell.IsPressed = true;
                                cell.Dist = (e.X - cell.X, e.Y - cell.Y);
                            }
                    }
                    break;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (var cell in dot_list)
                if (cell.IsPressed)
                    cell.IsPressed = false;
            Refresh();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var cell in dot_list)
                if (cell.IsPressed)
                    (cell.X, cell.Y) = (e.X - cell.Dist.dx, e.Y - cell.Dist.dy);

            Refresh();
        }

        private void КругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dot_type = 0;
            Refresh();
        }

        private void КвдратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dot_type = 1;
            Refresh();
        }

        private void ТреугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dot_type = 2;
            Refresh();
        }

        private void ПоОпределениюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg_Type = 0;
            Refresh();
        }

        private void ДжарвисToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg_Type = 1;
            Refresh();
        }

        private void ПалитраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            Shape.color = colorDialog1.Color;
        }

        private void РадиусToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Radius.Opened == false)
            {
                radius = new Radius(Shape.R);
                radius.Show(); //Показываем созданную форму
            }
            else
            {
                radius.WindowState = FormWindowState.Normal;
                if(radius != null)
                    radius.Activate(); //Активация формы
            }
        }

        private void Radius_changed(int r) //Обработчик события Radius_changing
        {
            Shape.R = r;
            Refresh();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int move;
            for(int i = 0; i < dot_list.Count; i++)
            {
                move = rand.Next(-5, 5);
                dot_list[i].X += move;
                dot_list[i].Y += move;
            }
            Refresh();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            timer1.Start(); //Запуск таймера
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            timer1.Stop(); //Оставновка таймера
        }
    }
}

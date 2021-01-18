using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Project_TPP_ver_2
{
    abstract class Shape
    {
        protected int x;
        protected int y;
        protected static int r;
        public static Color color;
        protected bool isPressed = false;  //Все поля класса-родителя
        protected bool isTop = false;
        protected (int dx, int dy) dist;
        protected bool is_peak = true;

        public int X
        {
            get => x;
            set => x = value;
        }

        public int Y
        {
            get => y;
            set => y = value;
        }

        public static int R
        {
            get => r;
            set => r = value;
        }

        public static Color Color
        {
            get => color;
            set => color = value;
        }

        public bool IsPressed
        {
            get => isPressed;
            set => isPressed = value;
        }

        public (int dx, int dy) Dist
        {
            get => dist;
            set => dist = value;
        }

        public bool Is_peak
        {
            get => is_peak;
            set => is_peak = value;
        }

        static Shape()
        {
            R = 20;
            color = Color.Red;
        }
        protected Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        virtual public bool IsInside(int x, int y) => false; //Методы виртуальные, т к они будут меняться в зависимости от класса-потомка
        virtual public void Draw(Graphics graphics)
        {
        }
    }

    class Triangle : Shape
    {
        public Triangle(int x, int y)
            : base(x, y)
        {
        }

        public override bool IsInside(int x0, int y0)
        {
            double Dis((float x, float y) a, (float x, float y) b) =>
                Math.Sqrt((a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y));

            double Sqr(double s1, double s2, double s3)
            {
                double p = (s1 + s2 + s3) / 2;
                return Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3));
            }

            return Math.Abs(Sqr(Dis((x, y - R), (x0, y0)),
                                Dis((x - R * (float)Math.Sin(1.0472), y + R / 2), (x0, y0)),
                                Dis((x, y - R), (x - R * (float)Math.Sin(1.0472), y + R / 2))) +
                            Sqr(Dis((x, y - R), (x0, y0)),
                                Dis((x + R * (float)Math.Sin(1.0472), y + R / 2), (x0, y0)),
                                Dis((x, y - R), (x + R * (float)Math.Sin(1.0472), y + R / 2))) +
                            Sqr(Dis((x + R * (float)Math.Sin(1.0472), y + R / 2), (x0, y0)),
                                Dis((x - R * (float)Math.Sin(1.0472), y + R / 2), (x0, y0)),
                                Dis((x + R * (float)Math.Sin(1.0472), y + R / 2),
                                    (x - R * (float)Math.Sin(1.0472), y + R / 2))) -
                            Sqr(Dis((x + R * (float)Math.Sin(1.0472), y + R / 2), (x, y - R)),
                                Dis((x - R * (float)Math.Sin(1.0472), y + R / 2), (x, y - R)),
                                Dis((x + R * (float)Math.Sin(1.0472), y + R / 2),
                                    (x - R * (float)Math.Sin(1.0472), y + R / 2)))) < 0.0001;
        }

        public override void Draw(Graphics graphics)
        {
            PointF[] list = new PointF[3];
            list[0] = new PointF(x, y - R);
            list[1] = new PointF(x - R * (float)Math.Sin(1.0472), y + R / 2);
            list[2] = new PointF(x + R * (float)Math.Sin(1.0472), y + R / 2);
            graphics.FillPolygon(new SolidBrush(Shape.color), list);
        }
    }
    class Square : Shape
    {
        public Square(int x, int y)
            : base(x, y)
        {
        }

        public override bool IsInside(int x1, int y1)
        {
            if (x1 <= x + R / Math.Sqrt(2) & x1 >= x - R / Math.Sqrt(2))
                if (y1 <= y + R / Math.Sqrt(2) & y1 >= y - R / Math.Sqrt(2))
                    return true;
            return false;
        }

        public override void Draw(Graphics graphics)
        {
            double len = Math.Sqrt(2 * R * R);
            PointF[] list = new PointF[4];
            list[0] = new PointF((float)(x - len / 2), (float)(y + len / 2));
            list[1] = new PointF((float)(x + len / 2), (float)(y + len / 2));
            list[2] = new PointF((float)(x + len / 2), (float)(y - len / 2));
            list[3] = new PointF((float)(x - len / 2), (float)(y - len / 2));
            graphics.FillPolygon(new SolidBrush(Shape.color), list);
        }
    }
    class Circle : Shape
    {
        public Circle(int x, int y)
            : base(x, y)
        {
        }

        public override bool IsInside(int x1, int y1)
        {
            if (x1 <= x + R & x1 >= x - R)
                if (y1 <= y + R & y1 >= y - R)
                    return true;
            return false;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(new SolidBrush(Shape.color), x - R, y - R, 2 * R, 2 * R);
        }
    }
}

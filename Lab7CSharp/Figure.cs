using System;
using System.Drawing;

namespace Lab7CSharp
{
    // Абстрактний базовий клас Фігура
    public abstract class Figure
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Size { get; set; }
        public Color Color { get; set; }

        public Figure(int x, int y, int size, Color color)
        {
            X = x;
            Y = y;
            Size = size;
            Color = color;
        }

        // Віртуальна функція малювання
        public abstract void Draw(Graphics graphics);

        // Віртуальна функція переміщення
        public virtual void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }

        // Функція для перевірки попадання точки в фігуру
        public virtual bool Contains(int pointX, int pointY)
        {
            return Math.Abs(pointX - X) <= Size && Math.Abs(pointY - Y) <= Size;
        }

        // Функція отримання інформації про фігуру
        public virtual string GetInfo()
        {
            return $"Позиція: ({X}, {Y}), Розмір: {Size}, Колір: {Color.Name}";
        }
    }

    // Похідний клас Шестикутник
    public class Hexagon : Figure
    {
        public Hexagon(int x, int y, int size, Color color) : base(x, y, size, color) { }

        public override void Draw(Graphics graphics)
        {
            using (Brush brush = new SolidBrush(Color))
            using (Pen pen = new Pen(Color.Black, 2))
            {
                // Створюємо точки для шестикутника
                PointF[] points = new PointF[6];
                double angle = Math.PI / 3; // 60 градусів

                for (int i = 0; i < 6; i++)
                {
                    points[i] = new PointF(
                        (float)(X + Size * Math.Cos(i * angle)),
                        (float)(Y + Size * Math.Sin(i * angle))
                    );
                }

                graphics.FillPolygon(brush, points);
                graphics.DrawPolygon(pen, points);
            }
        }

        public override string GetInfo()
        {
            return $"Шестикутник - {base.GetInfo()}";
        }
    }

    // Похідний клас Ромб
    public class Rhombus : Figure
    {
        public Rhombus(int x, int y, int size, Color color) : base(x, y, size, color) { }

        public override void Draw(Graphics graphics)
        {
            using (Brush brush = new SolidBrush(Color))
            using (Pen pen = new Pen(Color.Black, 2))
            {
                // Створюємо точки для ромба
                PointF[] points = new PointF[4]
                {
                    new PointF(X, Y - Size),        // Верх
                    new PointF(X + Size, Y),        // Право
                    new PointF(X, Y + Size),        // Низ
                    new PointF(X - Size, Y)         // Ліво
                };

                graphics.FillPolygon(brush, points);
                graphics.DrawPolygon(pen, points);
            }
        }

        public override string GetInfo()
        {
            return $"Ромб - {base.GetInfo()}";
        }
    }

    // Похідний клас Трикутник
    public class Triangle : Figure
    {
        public Triangle(int x, int y, int size, Color color) : base(x, y, size, color) { }

        public override void Draw(Graphics graphics)
        {
            using (Brush brush = new SolidBrush(Color))
            using (Pen pen = new Pen(Color.Black, 2))
            {
                // Створюємо точки для рівностороннього трикутника
                PointF[] points = new PointF[3]
                {
                    new PointF(X, Y - Size),                    // Верхня точка
                    new PointF(X - Size * 0.866f, Y + Size/2), // Ліва нижня точка
                    new PointF(X + Size * 0.866f, Y + Size/2)  // Права нижня точка
                };

                graphics.FillPolygon(brush, points);
                graphics.DrawPolygon(pen, points);
            }
        }

        public override string GetInfo()
        {
            return $"Трикутник - {base.GetInfo()}";
        }
    }

    // Похідний клас Дуга
    public class Arc : Figure
    {
        public float StartAngle { get; set; }
        public float SweepAngle { get; set; }

        public Arc(int x, int y, int size, Color color, float startAngle = 0, float sweepAngle = 180)
            : base(x, y, size, color)
        {
            StartAngle = startAngle;
            SweepAngle = sweepAngle;
        }

        public override void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(Color, 4))
            {
                // Малюємо дугу
                Rectangle rect = new Rectangle(X - Size, Y - Size, Size * 2, Size * 2);
                graphics.DrawArc(pen, rect, StartAngle, SweepAngle);
            }
        }

        public override string GetInfo()
        {
            return $"Дуга - {base.GetInfo()}, Кут початку: {StartAngle}°, Кут огляду: {SweepAngle}°";
        }
    }
}
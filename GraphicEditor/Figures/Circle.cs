using System;
using System.Drawing;

namespace GraphicEditor.Figures
{
    public class Circle : Figure
    {
        public Circle(Point startPoint, Color stroke, Color fill) : base(startPoint, stroke, fill) { }

        public override void Draw(Graphics g)
        {
            int width = EndPoint.X - StartPoint.X;
            int height = EndPoint.Y - StartPoint.Y;

            // корректируем для отрицательных размеров
            int x = Math.Min(StartPoint.X, EndPoint.X);
            int y = Math.Min(StartPoint.Y, EndPoint.Y);
            int w = Math.Abs(width);
            int h = Math.Abs(height);

            using (Brush brush = new SolidBrush(FillColor))
            {
                g.FillEllipse(brush, x, y, w, h);
            }

            using (Pen pen = new Pen(IsSelected ? Color.Red : StrokeColor, 2))
            {
                g.DrawEllipse(pen, x, y, w, h);
            }
        }

        public override bool Contains(Point point)
        {
            int width = EndPoint.X - StartPoint.X;
            int height = EndPoint.Y - StartPoint.Y;

            int x = Math.Min(StartPoint.X, EndPoint.X);
            int y = Math.Min(StartPoint.Y, EndPoint.Y);
            int w = Math.Abs(width);
            int h = Math.Abs(height);

            if (w == 0 || h == 0) return false;

            double cx = x + w / 2.0;
            double cy = y + h / 2.0;
            double dx = (point.X - cx) / (w / 2.0);
            double dy = (point.Y - cy) / (h / 2.0);
            return dx * dx + dy * dy <= 1.0;
        }

        public override void Move(int deltaX, int deltaY)
        {
            StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
            EndPoint = new Point(EndPoint.X + deltaX, EndPoint.Y + deltaY);
        }
    }
}

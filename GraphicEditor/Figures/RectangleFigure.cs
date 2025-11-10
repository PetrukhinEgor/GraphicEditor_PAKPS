using System;
using System.Drawing;

namespace GraphicEditor.Figures
{
    public class RectangleFigure : Figure
    {
        public RectangleFigure(Point startPoint, Color stroke, Color fill) : base(startPoint, stroke, fill) { }

        public override void Draw(Graphics g)
        {
            int width = EndPoint.X - StartPoint.X;
            int height = EndPoint.Y - StartPoint.Y;

            int x = Math.Min(StartPoint.X, EndPoint.X);
            int y = Math.Min(StartPoint.Y, EndPoint.Y);
            int w = Math.Abs(width);
            int h = Math.Abs(height);

            using (Brush brush = new SolidBrush(FillColor))
            {
                g.FillRectangle(brush, x, y, w, h);
            }

            using (Pen pen = new Pen(IsSelected ? Color.Red : StrokeColor, 2))
            {
                g.DrawRectangle(pen, x, y, w, h);
            }
        }

        public override bool Contains(Point point)
        {
            int x = Math.Min(StartPoint.X, EndPoint.X);
            int y = Math.Min(StartPoint.Y, EndPoint.Y);
            int w = Math.Abs(EndPoint.X - StartPoint.X);
            int h = Math.Abs(EndPoint.Y - StartPoint.Y);

            return point.X >= x && point.X <= x + w && point.Y >= y && point.Y <= y + h;
        }

        public override void Move(int deltaX, int deltaY)
        {
            StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
            EndPoint = new Point(EndPoint.X + deltaX, EndPoint.Y + deltaY);
        }
    }
}

using System.Drawing;

namespace GraphicEditor.Figures
{
    public abstract class Figure
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public bool IsSelected { get; set; }

        // Новые поля для цветов
        public Color StrokeColor { get; set; }
        public Color FillColor { get; set; }

        public Figure(Point startPoint, Color strokeColor, Color fillColor)
        {
            StartPoint = startPoint;
            EndPoint = startPoint;
            IsSelected = false;
            StrokeColor = strokeColor;
            FillColor = fillColor;
        }

        public abstract void Draw(Graphics g);
        public abstract bool Contains(Point point);
        public abstract void Move(int deltaX, int deltaY);
        public abstract Rectangle GetBounds();

    }
}

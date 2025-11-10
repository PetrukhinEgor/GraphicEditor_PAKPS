using GraphicEditor.Figures;
using System;
using System.Drawing;

public class ThickBorderDecorator : FigureDecorator
{
    public int ExtraWidth = 4;

    public ThickBorderDecorator(Figure f) : base(f) { }

    public override void Draw(Graphics g)
    {
        // сначала фигура
        inner.Draw(g);

        // затем жирная рамка
        using (Pen pen = new Pen(Color.DarkBlue, 3 + ExtraWidth))
        {
            g.DrawRectangle(pen,
                Math.Min(inner.StartPoint.X, inner.EndPoint.X),
                Math.Min(inner.StartPoint.Y, inner.EndPoint.Y),
                Math.Abs(inner.StartPoint.X - inner.EndPoint.X),
                Math.Abs(inner.StartPoint.Y - inner.EndPoint.Y)
            );
        }
    }
}

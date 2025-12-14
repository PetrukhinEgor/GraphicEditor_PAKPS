using GraphicEditor.Figures;
using System;
using System.Drawing;

public class ThickBorderDecorator : FigureDecorator
{
    public int ExtraWidth = 4;

    public ThickBorderDecorator(Figure f) : base(f) { }

    public override void Draw(Graphics g)
    {
        inner.Draw(g);

        Rectangle r = inner.GetBounds();

        using (Pen pen = new Pen(Color.DarkBlue, 6))
        {
            if (inner is Circle)
            {
                g.DrawEllipse(pen, r);
            }
            else
            {
                g.DrawRectangle(pen, r);
            }
        }
    }

}

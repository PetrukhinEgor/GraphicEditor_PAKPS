using GraphicEditor.Figures;
using System.Drawing;

public class ShadowDecorator : FigureDecorator
{
    public ShadowDecorator(Figure fig) : base(fig) { }

    public override void Draw(Graphics g)
    {
        // рисуем тень
        using (Brush b = new SolidBrush(Color.FromArgb(80, Color.Black)))
            g.FillRectangle(b, inner.StartPoint.X + 5, inner.StartPoint.Y + 5,
                               inner.EndPoint.X - inner.StartPoint.X,
                               inner.EndPoint.Y - inner.StartPoint.Y);

        // рисуем саму фигуру
        base.Draw(g);
    }
}

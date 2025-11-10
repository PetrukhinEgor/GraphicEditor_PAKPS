using GraphicEditor.Figures;
using System.Drawing;

public abstract class FigureDecorator : Figure
{
    protected Figure inner;

    public FigureDecorator(Figure fig)
        : base(fig.StartPoint, fig.StrokeColor, fig.FillColor)
    {
        inner = fig;
    }

    public override void Draw(Graphics g)
    {
        inner.Draw(g);
    }

    public override bool Contains(Point p)
    {
        return inner.Contains(p);
    }

    public override void Move(int dx, int dy)
    {
        inner.Move(dx, dy);
    }
}

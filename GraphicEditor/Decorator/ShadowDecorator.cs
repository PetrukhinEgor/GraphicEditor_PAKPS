using GraphicEditor.Figures;
using System.Drawing;

public class ShadowDecorator : FigureDecorator
{
    public ShadowDecorator(Figure fig) : base(fig) { }

    public override void Draw(Graphics g)
    {
        Rectangle r = inner.GetBounds();

        if (inner is Circle)
        {
            using (Brush b = new SolidBrush(Color.FromArgb(80, Color.Black)))
                g.FillEllipse(b, r.X + 5, r.Y + 5, r.Width, r.Height);
        }
        else
        {
            using (Brush b = new SolidBrush(Color.FromArgb(80, Color.Black)))
                g.FillRectangle(b, r.X + 5, r.Y + 5, r.Width, r.Height);
        }

        inner.Draw(g);
    }

}

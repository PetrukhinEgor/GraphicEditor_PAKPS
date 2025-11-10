using GraphicEditor.Creators;
using GraphicEditor.Figures;
using System.Drawing;

public class CircleCreator : FigureCreator
{
    public override Figure CreateFigure(Point startPoint, Color stroke, Color fill)
    {
        return new Circle(startPoint, stroke, fill)
        {
            StrokeColor = stroke,
            FillColor = fill
        };
    }
}

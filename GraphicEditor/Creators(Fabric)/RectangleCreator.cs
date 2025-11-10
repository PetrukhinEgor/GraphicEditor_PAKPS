using GraphicEditor.Creators;
using GraphicEditor.Figures;
using System.Drawing;

public class RectangleCreator : FigureCreator
{
    public override Figure CreateFigure(Point startPoint, Color stroke, Color fill)
    {
        return new RectangleFigure(startPoint, stroke, fill)
        {
            StrokeColor = stroke,
            FillColor = fill
        };
    }
}

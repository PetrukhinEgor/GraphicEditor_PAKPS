using GraphicEditor.Figures;
using System.Drawing;

namespace GraphicEditor.Creators
{
    public abstract class FigureCreator
    {
        // Обновлённая сигнатура — теперь передаём цвета
        public abstract Figure CreateFigure(Point startPoint, Color stroke, Color fill);
    }

    public class CircleCreator : FigureCreator
    {
        public override Figure CreateFigure(Point startPoint, Color stroke, Color fill)
        {
            return new GraphicEditor.Figures.Circle(startPoint, stroke, fill);
        }
    }

    public class RectangleCreator : FigureCreator
    {
        public override Figure CreateFigure(Point startPoint, Color stroke, Color fill)
        {
            return new GraphicEditor.Figures.RectangleFigure(startPoint, stroke, fill);
        }
    }
}

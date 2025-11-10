using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GraphicEditor.Figures;
using GraphicEditor.Creators;

namespace GraphicEditor
{
    public partial class Form1 : Form
    {

        private Func<Figure, Figure> decoratorToApply = null;

        private List<Figure> figures = new List<Figure>();
        private Figure currentFigure = null;
        private Figure selectedFigure = null;

        private FigureCreator currentCreator = null;
        private Point lastMousePos;

        private bool isDrawing = false;
        private bool isDragging = false;

        // Цвета по умолчанию (можешь поменять)
        private Color currentStrokeColor = Color.Black;
        private Color currentFillColor = Color.White;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Rectangle_btn_Click(object sender, EventArgs e)
        {
            currentCreator = new RectangleCreator();
        }

        private void Circle_btn_Click(object sender, EventArgs e)
        {
            currentCreator = new CircleCreator();
        }

        private void Move_btn_Click(object sender, EventArgs e)
        {
            currentCreator = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var fig in figures)
                fig.Draw(e.Graphics);

            if (isDrawing && currentFigure != null)
                currentFigure.Draw(e.Graphics);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            // Создаём новую фигуру
            if (currentCreator != null)
            {
                isDrawing = true;
                currentFigure = currentCreator.CreateFigure(
                    e.Location,
                    currentStrokeColor,
                    currentFillColor
                );
            }
            else
            {
                // Снимаем выделение со всех
                foreach (var fig in figures)
                    fig.IsSelected = false;

                // Выбор фигуры
                selectedFigure = null;

                foreach (var fig in figures)
                {
                    if (fig.Contains(e.Location))
                    {
                        selectedFigure = fig;
                        fig.IsSelected = true;
                        isDragging = true;
                        lastMousePos = e.Location;
                        break;
                    }
                }
            }

            panel1.Invalidate();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && currentFigure != null)
            {
                currentFigure.EndPoint = e.Location;
            }
            else if (isDragging && selectedFigure != null)
            {
                int dx = e.X - lastMousePos.X;
                int dy = e.Y - lastMousePos.Y;

                selectedFigure.Move(dx, dy);
                lastMousePos = e.Location;
            }

            panel1.Invalidate();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing && currentFigure != null)
            {
                // если выбран декоратор, применяем
                if (decoratorToApply != null)
                {
                    currentFigure = decoratorToApply(currentFigure);
                    decoratorToApply = null; // сброс, чтобы декоратор применился только один раз
                }

                figures.Add(currentFigure);
                currentFigure = null;
            }


            isDrawing = false;
            isDragging = false;

            panel1.Invalidate();
        }

        private void Shadow_btn_Click(object sender, EventArgs e)
        {
            decoratorToApply = f => new ShadowDecorator(f);
        }

        private void Thick_btn_Click(object sender, EventArgs e)
        {
            decoratorToApply = f => new ThickBorderDecorator(f);
        }
    }
}

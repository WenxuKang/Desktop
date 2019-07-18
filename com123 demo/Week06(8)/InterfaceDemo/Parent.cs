using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface IDrawable
    {
        void Draw(Graphics g);
    }
    interface IWriteable
    {
        void Write(TextWriter writer);
    }
    abstract class Parent : IDrawable
    {
        protected Color Color { get; }
        protected bool Filled { get; }
        protected Rectangle Rectangle { get; }
        public Parent(Color color, bool filled, Rectangle rectangle)
        {
            Color = color;
            Filled = filled;
            Rectangle = rectangle;
        }
        public abstract void Draw(Graphics g);
    }
    class DrawableRectangle : Parent, IWriteable
    {
        public DrawableRectangle(Color color, bool filled, Rectangle rectangle)
            : base(color, filled, rectangle)
        { }
        public override void Draw(Graphics g)
        {
            if (Filled)
            {
                SolidBrush brush = new SolidBrush(Color);
                g.FillRectangle(brush, Rectangle);

            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawRectangle(pen, Rectangle);
            }
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine($"{Color.ToKnownColor()} rectangle {(Filled ? "filled" : "border")} {Rectangle}");
        }

        class DrawableEllipse : Parent, IDrawable
        {
            public DrawableEllipse(Color color, bool filled, Rectangle rectangle) : base(color, filled, rectangle)
            {

            }
            public override void Draw(Graphics g)
            {
                if (Filled)
                {
                    SolidBrush brush = new SolidBrush(Color);
                    g.FillEllipse(brush, Rectangle);

                }
                else
                {
                    Pen pen = new Pen(Color.Black, 3);
                    g.DrawEllipse(pen, Rectangle);
                }

            }
        }
        class DrawableLine : IDrawable, IWriteable
        {
            public Color Color { get; }
            public Point Start { get; }
            public Point End { get; }
            public DrawableLine(Color color, Point start, Point end)
            {
                Color = color;
                Start = start;
                End = end;
            }
            public void Draw(Graphics g)
            {
                Pen pen = new Pen(Color.Black, 3);
                g.DrawLine(pen, Start, End);
            }
            public void Write(TextWriter writer)
            {
                writer.WriteLine($"{Color}{Start} {End}");
            }
        }
        class DrawableBezier : IDrawable, IWriteable
        {
            public Color Color { get; }
            public Point Start { get; }
            public Point First { get; }
            public Point Second { get; }
            public Point End { get; }
            public DrawableBezier(Color color, Point start, Point end, Point first, Point second)
            {
                Color = color;
                Start = start;
                First = first;
                Second = second;
                End = end;
            }
            public void Draw(Graphics g)
            {
                Pen pen = new Pen(Color.Black, 3);
                g.DrawBezier(pen, Start, End, First, Second);
            }
            public void Write(TextWriter writer)
            {
                writer.WriteLine($"{Color}{Start}{First}{Second} {End}");
            }
        }
        class DrawableArc : Parent, IWriteable
        {
            public float start;
            public float end;
            public DrawableArc(Color color, bool filled, Rectangle rectangle, float start, float end) : base(color, filled, rectangle)
            {

            }
            public override void Draw(Graphics g)
            {
                Pen pen = new Pen(Color.Black, 3);
                g.DrawArc(pen, Rectangle, start, end);
                SolidBrush brush = new SolidBrush(Color);
                g.FillPie(brush, Rectangle, start, end);
            }
            public void Write(TextWriter writer)
            {
                writer.WriteLine($"{Color}{Rectangle}{start}{end}");
            }
        }
    }
}
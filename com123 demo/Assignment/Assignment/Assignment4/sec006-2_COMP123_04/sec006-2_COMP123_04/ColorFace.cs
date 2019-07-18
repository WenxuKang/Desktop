using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;


namespace sec006_2_COMP123_04
{
    //interface class
    interface IDrawable
    {
        void Draw(Graphics g);                
    }

    interface IWritable
    {
        void Write(TextWriter writer);
    }  

    //abstrac class
    public abstract class Primitive
    {
        protected Color color;
        protected bool filled;
        protected Rectangle boundingRectangle;

        public Primitive(Color color,bool filled, Rectangle rectangle)
        {
            this.color = color;
            this.filled = filled;
            this.boundingRectangle = rectangle;
        }    
    }

    //derived classes
   public class DrawableRectangle : Primitive,IDrawable,IWritable
   { 
        public DrawableRectangle(Color color, bool filled, Rectangle rectangle) : base(color, filled, rectangle)
        {
            
        }        
                

        public void Draw(Graphics g)
        {
            if (filled == true)
            {
                SolidBrush solidBrush = new SolidBrush(color);
                g.FillRectangle(solidBrush, boundingRectangle);
            }
            else
            {
                Pen pen = new Pen(color);
                g.DrawRectangle(pen, boundingRectangle);
            }
        }
        public void Write(TextWriter writer)
        {                      
            writer.WriteLine($"{color},{filled},{boundingRectangle}");                        
        }

        public double Area()
        {
            double area = boundingRectangle.Height * boundingRectangle.Width;
            return area;
        }
   }

   public class DrawableEllipse:Primitive, IDrawable
   {
        public DrawableEllipse(Color color, bool filled, Rectangle rectangle): base(color, filled, rectangle)
        {

        }
        public void Draw(Graphics g)
        {
            if (filled == true)
            {
                SolidBrush solidBrush = new SolidBrush(color);
                g.FillEllipse(solidBrush,boundingRectangle);
            }
            else
            {
                Pen pen = new Pen(color);
                g.DrawEllipse(pen, boundingRectangle);
            }
        }
        public double Area()
        {
            double area = Math.PI * boundingRectangle.Width * boundingRectangle.Height;
            return area;
        }
   }
    class DrawableLine : IDrawable, IWritable
    {
        protected Color color;
        protected Point lineStart;
        protected Point lineEnd;

        public DrawableLine(Color color, Point start, Point end)
        {
            this.color = color;
            this.lineStart = start;
            this.lineEnd = end;
        }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(color);
            g.DrawLine(pen, lineStart, lineEnd);
        }
        public void Write(TextWriter writer)
        {           
            writer.WriteLine($"{color},{lineStart},{lineEnd}");
        }
    }
    class DrawableBezier : IDrawable, IWritable
    {
        protected Color color;
        protected Point curveStart;
        protected Point controlFirst;
        protected Point controlSecond;
        protected Point curveEnd;

        public DrawableBezier(Color color, Point start, Point first, Point second, Point end)
        {
            this.color = color;
            this.curveStart = start;
            this.controlFirst = first;
            this.controlSecond = second;
            this.curveEnd = end;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(color);
            g.DrawBezier(pen, curveStart, controlFirst, controlSecond, curveEnd);
        }
        public void Write(TextWriter writer)
        {
            writer.WriteLine($"{color},{curveStart},{controlFirst},{controlSecond},{curveEnd}");
        }
    }
    class DrawableArc: Primitive, IDrawable, IWritable
    {
        protected float start;
        protected float end;

        public DrawableArc(Color color, bool filled, Rectangle rectangle, float start, float end) : base(color, filled, rectangle)
        {
            this.start = start;
            this.end = end;
        }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(color);
            g.DrawArc(pen, boundingRectangle, start, end);
        }
        public void Write(TextWriter writer)
        {
            writer.WriteLine($"{color},{filled},{boundingRectangle},{start},{end}");
        }
    }
}

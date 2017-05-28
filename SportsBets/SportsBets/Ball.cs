using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SportsBets
{
    public class Ball
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public Color Color { get; set; }
        public bool ballDirection { get; set; }

        public Ball(Point center, int radius, Color color)
        {
            Center = center;
            Radius = radius;
            Color = color;
            ballDirection = true;
        }

        public void drawBall(Graphics g)
        {
            Pen pen = new Pen(Color, 5);
            g.DrawEllipse(pen, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            pen.Dispose();
        }
    }
}

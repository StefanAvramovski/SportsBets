using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SportsBets
{
    public class BallsDoc
    {
        public List<Ball> Balls;

        public BallsDoc()
        {
            Balls = new List<Ball>();
        }

        public void AddBall(Point point, int radius, Color color)
        {
            Ball ball = new Ball(point, radius, color);
            Balls.Add(ball);
        }

        public void HeightDown(int height)
        {
            foreach (Ball ball in Balls)
            {
                if (ball.ballDirection == true)
                {
                    Point point = new Point(ball.Center.X, ball.Center.Y + 10);
                    ball.Center = point;
                    if (ball.Center.Y > height - 130)
                    {
                        ball.ballDirection = false;
                    }
                }
                else
                {
                    Point point = new Point(ball.Center.X, ball.Center.Y - 10);
                    ball.Center = point;
                    if (ball.Center.Y < 128 - ball.Radius)
                    {
                        ball.ballDirection = true;
                    }
                }
            }
        }

        public void DrawBalls(Graphics g)
        {
            foreach (Ball ball in Balls)
            {
                ball.drawBall(g);
            }
        }
    }
}

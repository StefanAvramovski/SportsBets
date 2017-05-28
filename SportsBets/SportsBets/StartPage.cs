using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SportsBets
{
    public partial class StartPage : Form
    {
        private BallsDoc ballsDoc;
        private Timer timer;
        private Timer timerBalls;
        private int startSize = 5;

        public StartPage()
        {
            InitializeComponent();
            lblAnimacija.Font = new Font("Microsoft Sans Serif", startSize);
            DoubleBuffered = true;
            ballsDoc = new BallsDoc();

            Point point = new Point(50, 128);
            ballsDoc.AddBall(point, 20, Color.Blue);

            Point point1 = new Point(Width - 70, 128);
            ballsDoc.AddBall(point1, 20, Color.Red);

            timerBalls = new Timer();
            timerBalls.Interval = 50;
            timerBalls.Tick += new EventHandler(timer_Tick1);

            timer = new Timer();
            timer.Interval = 300;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs args)
        {
            sizeChange();
            timerBalls.Start();
            Invalidate(true);
        }

        void timer_Tick1(object sender, EventArgs args)
        {
            ballsDoc.HeightDown(Height);
            Invalidate(true);
        }

        public void sizeChange()
        {
            if (lblAnimacija.Font.Size < 40)
            {
                startSize += 5;
                lblAnimacija.Font = new Font("Microsoft Sans Serif", startSize);
                changeColor();
            }
            else
            {
                changeColor();
            }
            
        }

        public void changeColor()
        {
            if (lblAnimacija.ForeColor == Color.Red)
            {
                lblAnimacija.ForeColor = Color.Blue;
            }
            else if (lblAnimacija.ForeColor == Color.Blue)
            {
                lblAnimacija.ForeColor = Color.Red;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewTicket_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void StartPage_Paint(object sender, PaintEventArgs e)
        {
            ballsDoc.DrawBalls(e.Graphics);
        }

        private void btnOpenTicket_Click(object sender, EventArgs e)
        {
            List<Match> empty = new List<Match>();
            TicketsView ticket = new TicketsView("", empty , 0);
            ticket.Show();
        }
    }
}

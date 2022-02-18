using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallsGamesClassLibrary
{
    public class Ball
    {


        private Timer timer;
        protected Form form;
        protected Brush brush = Brushes.Aqua;
        protected float vx = 1f;
        protected float vy = 1f;
        protected int maxVX = 5;
        protected int maxVY = 5;
        protected float centerX = 10f;
        protected float centerY = 10f;
        protected int radius = 10;


        public Ball(Form form)
        {
            this.form = form;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        public Ball(Form form, Brush brush)
        {
            this.form = form;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            this.brush = brush;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void Show()
        {
            
            Draw(brush);
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }



        public int LeftSide()
        {
            return radius;
        }

        public int RightSide()
        {
            return form.ClientSize.Width-radius;
        }

        public int TopSide()
        {
            return radius;
        }

        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }

        public bool IsOnForm()
        {
            if (centerX >= LeftSide() && centerX <= RightSide() && centerY >= TopSide()&& centerY <=DownSide())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsClickedOnBall(int mouseX, int mouseY)
        {
            if (IsOnForm())
            {
                
                if ((Math.Pow(mouseX - centerX, 2) + Math.Pow(mouseY - centerY, 2)) <= Math.Pow(radius, 2))
                {
                    return true;
                }
            }
            return false;
        }

        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;

           
        }

        public void Clear()
        {
            
            var brush = SystemBrushes.Control;
            Draw(brush);
            
        }

        public Brush GetBrush()
        {
            return brush;
        }

        private void Draw( Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new RectangleF(centerX - radius, centerY - radius, 2 * radius, 2 * radius);

            graphics.FillEllipse(brush, rectangle);
        }
    }

}

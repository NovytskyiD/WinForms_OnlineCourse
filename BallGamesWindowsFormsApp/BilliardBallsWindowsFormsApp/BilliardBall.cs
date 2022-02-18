using BallsGamesClassLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BilliardBallsWindowsFormsApp
{
    public class BilliardBall : RandomMoveBall
    {

        public BilliardBall(Form form) : base(form)
        {
            
        }
        public BilliardBall(Form form, Brush brush) : base(form,brush)
        {
            
        }

        public event EventHandler<HitEventArgs> OnHited;

        protected override void Go()
        {
            base.Go();

            if (centerX <= LeftSide())
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (centerX >= RightSide())
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }


            if (centerY <= TopSide() )
            {
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }

            if (centerY >= DownSide())
            {
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Down));
            }
        }

        public bool OnTheLeftSide()
        {
            return centerX + radius < form.ClientSize.Width / 2;

        }

        public bool OnTheRightSide()
        {
            return centerX - radius > form.ClientSize.Width / 2;
        }


    }
}

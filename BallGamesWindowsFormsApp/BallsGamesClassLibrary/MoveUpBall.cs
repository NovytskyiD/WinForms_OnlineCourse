using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BallsGamesClassLibrary
{
    public class MoveUpBall : SaluteBall
    {
        public event EventHandler<TopReachedEventArgs> TopReached;
        public MoveUpBall(Form form, Brush brush) : base(form, (float)random.Next((int)(form.ClientSize.Width * 0.25), (int)(form.ClientSize.Width * 0.75)), (float)form.ClientSize.Height, brush)
        {

            vx = 0;
            vy = -random.Next(maxVY*2, maxVY*3);
        }

        protected override void Go()
        {
            base.Go();

            if (vy>0)
            {
                Stop();
                Clear();
                TopReached?.Invoke(this, new TopReachedEventArgs(centerX, centerY));
            }
        }
    }
}

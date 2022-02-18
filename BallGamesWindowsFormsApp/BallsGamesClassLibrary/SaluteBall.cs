using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallsGamesClassLibrary
{
    public class SaluteBall : RandomMoveBall
    {
        private float g = 0.2f;
        public SaluteBall(Form form,float centerX, float centerY, Brush brush) : base(form)
        {
            radius = 8;
            this.centerX = centerX;
            this.centerY = centerY;
            vy = -Math.Abs(vy);
            this.brush = brush;
        }

        protected override void Go()
        {
            base.Go();
            vy += g;
        }
    }
}

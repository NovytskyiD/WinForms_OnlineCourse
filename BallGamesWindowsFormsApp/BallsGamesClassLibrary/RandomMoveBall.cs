using System.Drawing;
using System.Windows.Forms;

namespace BallsGamesClassLibrary
{
    public class RandomMoveBall : MoveBall
    {
        public RandomMoveBall(Form form) : base(form)
        {
            vx = random.Next(1,maxVX) * random.Next(0, 2) * 2 - 1;
            vy = random.Next(1,maxVY) * random.Next(0, 2) * 2 - 1;
        }

        public RandomMoveBall(Form form, Brush brush) : base(form, brush)
        {
            vx = random.Next(1,maxVX) * random.Next(0, 2) * 2 - 1;
            vy = random.Next(1,maxVY) * random.Next(0, 2) * 2 - 1;
        }
    }
}

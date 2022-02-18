using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsGamesClassLibrary
{
    public class MoveBall : RandomPointBall
    {
        
        public MoveBall(Form form) : base(form)
        {
            
        }

        public MoveBall(Form form, Brush brush) : base(form, brush)
        {

        }


    }
}

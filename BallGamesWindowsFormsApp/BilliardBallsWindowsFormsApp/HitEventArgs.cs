﻿namespace BilliardBallsWindowsFormsApp
{
    public class HitEventArgs
    {
        public Side Side;

        public HitEventArgs(Side side)
        {
            Side = side;
        }
    }
}

﻿namespace BlockDestroyer
{
    /// <summary>
    ///     Class representing exact position in console windows.
    /// </summary>
    internal class ConsolePoint
    {
        public readonly int X;
        public readonly int Y;

        public ConsolePoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
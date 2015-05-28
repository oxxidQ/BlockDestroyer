﻿using System;

namespace BlockDestroyer
{
    internal class BallClass : GameObject
    {
        public Direction Dir { get; set; }

        public BallClass(int xColumn, int yRows, bool exists, Direction dir, char objectChar,
            ConsoleColor color = ConsoleColor.White)
            : base(xColumn, yRows,objectChar, exists, color)
        {
            Dir = dir;
        }
    }

    internal abstract class Direction
    {
    }

    internal class UpRight : Direction
    {
    }

    internal class UpLeft : Direction
    {
    }

    internal class DownRight : Direction
    {
    }

    internal class DownLeft : Direction
    {
    }
}
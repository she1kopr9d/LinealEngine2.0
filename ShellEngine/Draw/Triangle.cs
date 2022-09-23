using System;
using Microsoft.Xna.Framework;

namespace ShellEngine.Draw
{
    public class Triangle
    {
        private Point[] _vertexArray = new Point[3];

        public Triangle(Point p1, Point p2, Point p3)
        {
            _vertexArray[0] = p1;
            _vertexArray[1] = p2;
            _vertexArray[2] = p3;
        }
    }
}


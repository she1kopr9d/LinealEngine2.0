using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ShellEngine
{
    public static class Settings
    {
        public static int WIDTH = 1200;
        public static int HEIGHT = 800;

        public static int HALFWIDTH = 600;
        public static int HALFHEIGHT = 400;

        public static int FPS = 60;

        public static int TILESIZE = 50;

        public static double FOV = Math.PI / 3;
        public static double HALFFOV = FOV / 2;
        public static int NUMRAYS = 1200;
        public static int MAXDEPTH = 800;
        public static double DELTAANGLE = FOV / NUMRAYS;
        public static double DISTANCE = NUMRAYS / (2 * Math.Tan(HALFFOV));
        public static double PROJECTIVECOEF = 1 * DISTANCE * TILESIZE; // 50000
        public static double SCALE = 1;

        public static Point PlayerPosition = new Point(600, 400);
        public static double PlayerAngle = 90;
        public static int PlayerSpeed = 1;
    }
}


using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ShellEngine
{
    public class Player
    {
        public double Angle => _playerAngle;
        public int X => (int)(_x);
        public int Y => (int)(_y);

        private double _x, _y;
        private double _playerAngle;

        public Player()
        {
            _x = Settings.PlayerPosition.X;
            _y = Settings.PlayerPosition.Y;
            _playerAngle = Settings.PlayerAngle;
        }

        public Point Position() => new Point((int)_y, (int)_x);

        public void Movement()
        {
            double sinA = Math.Sin(_playerAngle);
            double cosA = Math.Cos(_playerAngle);

            KeyboardState state = Microsoft.Xna.Framework.Input.Keyboard.GetState();
            if (state.IsKeyDown(Keys.W) == true)
            {
                _x += Settings.PlayerSpeed * cosA;
                _y += Settings.PlayerSpeed * sinA;
            }
            if (state.IsKeyDown(Keys.S) == true)
            {
                _x += -Settings.PlayerSpeed * cosA;
                _y += -Settings.PlayerSpeed * sinA;
            }
            if (state.IsKeyDown(Keys.A) == true)
            {
                _x += Settings.PlayerSpeed * sinA;
                _y += -Settings.PlayerSpeed * cosA;
            }
            if (state.IsKeyDown(Keys.D) == true)
            {
                _x += -Settings.PlayerSpeed * sinA;
                _y += Settings.PlayerSpeed * cosA;
            }
            if (state.IsKeyDown(Keys.Left) == true)
            {
                _playerAngle -= 0.02;
            }
            if (state.IsKeyDown(Keys.Right) == true)
            {
                _playerAngle += 0.02;
            }
        }
    }
}


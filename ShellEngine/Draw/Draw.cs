using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ShellEngine.Draw
{
    public class Draw
    {
        private SpriteBatch _spriteBatch;
        private BasicEffect _effect;
        private Texture2D _rectTexture;

        Matrix projectionMatrix;
        Matrix viewMatrix;

        VertexPositionColor[] triangleVertices;
        VertexBuffer vertexBuffer;

        public Draw(SpriteBatch spriteBatch, Texture2D texture, BasicEffect effect)
        {
            _spriteBatch = spriteBatch;
            _rectTexture = texture;
            _effect = effect;
            effect.VertexColorEnabled = true;

        }

        public void Init(GameWindow window)
        {
            viewMatrix = Matrix.CreateLookAt(new Vector3(0, 0, 20), Vector3.Zero, Vector3.Up);

            projectionMatrix = Matrix.CreatePerspectiveFieldOfView(MathHelper.PiOver4,
                (float)window.ClientBounds.Width / (float)window.ClientBounds.Height,
                1, 100);


            // создаем набор вершин
            triangleVertices = new VertexPositionColor[2];
            triangleVertices[0] = new VertexPositionColor(new Vector3(-10, 1, 0), Color.Red);
            triangleVertices[1] = new VertexPositionColor(new Vector3(1, 100, 0), Color.Red);

            vertexBuffer = new VertexBuffer(_spriteBatch.GraphicsDevice, typeof(VertexPositionColor),
                triangleVertices.Length, BufferUsage.None);
            vertexBuffer.SetData(triangleVertices);
        }

        public void Rect(int x, int y, int sizeX, int sizeY, Color color) =>
            Rect(new Point(x, y), sizeX, sizeY, color);

        public void Rect(Point position, int sizeX, int sizeY, Color color)
        {
            _spriteBatch.Begin();
            Point size = new Point(sizeX, sizeY); // size
            Rectangle rectangle = new Rectangle(position, size);
            _spriteBatch.Draw(_rectTexture, rectangle, color);
            _spriteBatch.End();
        }

        public void Triagle(ShellEngine.Draw.Triangle triangle, Color color)
        {
            /*_spriteBatch.Begin();
            _spriteBatch.(_rectTexture, rectangle, color);
            _spriteBatch.End();*/
        }

        public void Line(int x, int y, Color color)
        {
            _spriteBatch.Draw(_rectTexture, new Vector2(x, y), color);
        }
    }
}
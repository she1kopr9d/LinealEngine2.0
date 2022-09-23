using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ShellEngine.Draw;

namespace ShellEngine;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch spriteBatch;
    private Texture2D rectangleBlock;
    private Player _player = new Player();
    private Draw.Draw _brush;
    private RayCasting _rayCasting;

    


    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;

        _graphics.PreferredBackBufferWidth = Settings.WIDTH;
        _graphics.PreferredBackBufferHeight = Settings.HEIGHT;
        _graphics.SupportedOrientations = DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight;

        
    }

    protected override void Initialize()
    {
        RasterizerState rasterizerState = new RasterizerState();
        rasterizerState.CullMode = CullMode.None;
        GraphicsDevice.RasterizerState = rasterizerState;

        base.Initialize();
    }

    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);
        rectangleBlock = new Texture2D(GraphicsDevice, 1, 1);
        Color xnaColorBorder = new Color(128, 128, 128); // default color gray
        rectangleBlock.SetData(new[] { xnaColorBorder });

        _brush = new Draw.Draw(spriteBatch, rectangleBlock, new BasicEffect(GraphicsDevice));
        _brush.Init(Window);
        _rayCasting = new RayCasting(_brush);

    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        _player.Movement();

        _brush.Rect(_player.Position(), 100, 100, new Color(255, 255, 0));

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);

        //Lineral Engine
        /*_brush.Rect(0, 0, 1200, 400, new Color(0, 120, 200));
        _brush.Rect(0, 400, 1200, 400, new Color(40, 200, 80));
        _rayCasting.Update(_player.X, _player.Y, _player.Angle);*/

        //
        _brush.Line(0, 10, new Color(255, 255, 0));

        base.Draw(gameTime);
    }
}


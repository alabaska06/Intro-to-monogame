using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Intro_to_monogame
{
    public class Game1 : Game
    {
        Texture2D dinoTexture;
        Texture2D monkeyTexture;

        Rectangle stickPos = new Rectangle(150, 200, 200, 250);

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 900; // Sets the width of the window
            _graphics.PreferredBackBufferHeight = 600; // Sets the height of the window
            _graphics.ApplyChanges();

            this.Window.Title = "Alanna's Monogame Project ! :3";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            dinoTexture = Content.Load<Texture2D>("dino");
            monkeyTexture = Content.Load<Texture2D>("monkey");

            // TODO: use this.Content to load your game content here


        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here



            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Sienna);


            _spriteBatch.Begin();
            _spriteBatch.Draw(dinoTexture, new Vector2(300, 150), Color.White);
            _spriteBatch.Draw(monkeyTexture, stickPos, Color.White);
            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
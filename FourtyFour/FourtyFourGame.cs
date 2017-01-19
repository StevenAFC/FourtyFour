using FourtyFour.Screens;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace FourtyFour
{
    public class FourtyFourGame : Game
    {
        private GraphicsDeviceManager _graphics;

        private Screen _currentScreen;

        public FourtyFourGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _currentScreen = new GameScreen(this);
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _currentScreen.Draw(gameTime);

            base.Draw(gameTime);
        }
    }
}

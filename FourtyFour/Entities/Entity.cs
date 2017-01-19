using FourtyFour.Screens;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FourtyFour.Entities
{
    public abstract class Entity : IEntity
    {
        protected Game Game;

        protected Screen Screen;

        protected Entity(Game game, Screen screen)
        {
            Game = game;
            Screen = screen;
        }

        public abstract void Draw(GraphicsDevice graphicsDevice);
    }
}

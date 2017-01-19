using System.Collections.Generic;
using FourtyFour.Common;
using FourtyFour.Entities;
using Microsoft.Xna.Framework;

namespace FourtyFour.Screens
{
    abstract public class Screen
    {
        public List<IEntity> Entities { get; set; }

        public Game Game { get; }

        public Camera Camera { get; set; }

        protected Screen(Game game)
        {
            Game = game;
            Entities = new List<IEntity>();

            Camera = new Camera(MathHelper.Pi / 4, (float)16 / 9, 10f, 700f)
            {
                Position = new Vector3(0, 10, 15)
            };
        }

        public virtual void Draw(GameTime gameTime)
        {
            foreach (var entity in Entities)
            {
                entity.Draw(Game.GraphicsDevice);
            }
        }
    }
}

using FourtyFour.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FourtyFour.Screens
{
    public class GameScreen : Screen
    {
        public GameScreen(Game game) : base(game)
        {
            Entities.Add(new PlayerShip(game, this, Game.Content.Load<Model>("PremCube"), Vector3.Zero));
        }
    }
}

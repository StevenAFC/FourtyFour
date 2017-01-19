using FourtyFour.Common;
using FourtyFour.Screens;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FourtyFour.Entities
{
    public class PlayerShip : Entity
    {
        public Model Model;

        public Vector3 Position;

        public PlayerShip(Game game, Screen screen, Model model, Vector3 position)
            : base(game, screen)
        {
            Model = model;
            Position = position;
        }

        public void Update(GameTime gameTime)
        {

        }

        public override void Draw(GraphicsDevice graphicsDevice)
        {
            foreach (var mesh in Model.Meshes)
            {
                foreach (BasicEffect effect in mesh.Effects)
                {

                    effect.EnableDefaultLighting();
                    effect.PreferPerPixelLighting = true;

                    effect.World = Matrix.CreateTranslation(Position);

                    effect.View = Screen.Camera.View;
                    effect.Projection = Screen.Camera.Projection;
                }

                mesh.Draw();
            }
        }
    }
}

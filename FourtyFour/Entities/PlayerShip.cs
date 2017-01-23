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
                foreach (var effect in mesh.Effects)
                {

                    var be = effect as BasicEffect;
                    if (be == null) continue;

                    be.EnableDefaultLighting();
                    be.PreferPerPixelLighting = true;
                    
                    be.World = Matrix.CreateTranslation(Position);
                    
                    be.View = Screen.Camera.View;
                    be.Projection = Screen.Camera.Projection;
                }

                mesh.Draw();
            }
        }
    }
}

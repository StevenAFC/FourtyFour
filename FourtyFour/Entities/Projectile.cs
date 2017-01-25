using System;
using FourtyFour.Screens;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FourtyFour.Entities
{
    public class Projectile : Entity
    {
        public Model Model;

        public Vector3 Position;

        public Projectile(Game game, Screen screen, Model model, Vector3 position) 
            : base(game, screen)
        {
            Model = model;
            Position = position;
        }

        public override void Draw(GameTime gameTime)
        {
            foreach (var mesh in Model.Meshes)
            {
                foreach (var effect in mesh.Effects)
                {

                    var be = effect as BasicEffect;
                    if (be == null) continue;

                    be.EnableDefaultLighting();
                    be.PreferPerPixelLighting = true;

                    be.World = Matrix.CreateScale(0.2f) * Matrix.CreateTranslation(Position);

                    be.View = Screen.Camera.View;
                    be.Projection = Screen.Camera.Projection;
                }

                mesh.Draw();
            }
        }

        public override void Update(GameTime gameTime)
        {
            Position.Y += (0.02f * gameTime.ElapsedGameTime.Milliseconds);
        }
    }
}

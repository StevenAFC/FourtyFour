using FourtyFour.Input;
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

        public override void Update(GameTime gameTime)
        {
            foreach (var inputEvent in Screen.InputManager.InputEvents)
            {
                if (inputEvent.ActionType == ActionType.PressedLeft) Position.X = Position.X - (0.01f * gameTime.ElapsedGameTime.Milliseconds);
                if (inputEvent.ActionType == ActionType.PressedRight) Position.X = Position.X + (0.01f * gameTime.ElapsedGameTime.Milliseconds);
            }
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
                    
                    be.World = Matrix.CreateTranslation(Position);
                    
                    be.View = Screen.Camera.View;
                    be.Projection = Screen.Camera.Projection;
                }

                mesh.Draw();
            }
        }
    }
}

using System;
using System.Linq;
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

        private float _drag = 0.85f;

        private Vector3 _acceleration = new Vector3(0.2f, 0.05f, 0.2f);

        private Vector3 _maxspeed = new Vector3(0.8f);

        private Vector2 _speed;

        public PlayerShip(Game game, Screen screen, Model model, Vector3 position)
            : base(game, screen)
        {
            Model = model;
            Position = position;
        }

        public override void Update(GameTime gameTime)
        {
            //Movement
            var inputEvents = Screen.InputManager.InputEvents;

            _speed.X *= _drag;
            _speed.Y *= _drag;

            if (inputEvents.Any(x => x.ActionType == ActionType.PressedRight)) _speed.X += _acceleration.X;
            if (inputEvents.Any(x => x.ActionType == ActionType.PressedLeft)) _speed.X -= _acceleration.X;

            if (inputEvents.Any(x => x.ActionType == ActionType.PressedUp)) _speed.Y += _acceleration.Y;
            if (inputEvents.Any(x => x.ActionType == ActionType.PressedDown)) _speed.Y -= _acceleration.Z;

            _speed.X = MathHelper.Clamp(_speed.X, -_maxspeed.X, _maxspeed.X);
            _speed.Y = MathHelper.Clamp(_speed.Y, -_maxspeed.Y, _maxspeed.Z);

            Position.X += _speed.X;
            Position.Y += _speed.Y;

            if (inputEvents.Any(x => x.ActionType == ActionType.Shoot)) Screen.Entities.Add(new Projectile(Game, Screen, Game.Content.Load<Model>("PremCube"), Position));
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

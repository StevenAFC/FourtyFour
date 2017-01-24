using Microsoft.Xna.Framework;

namespace FourtyFour.Entities
{
    public interface IEntity
    {
        void Update(GameTime gameTime);

        void Draw(GameTime gameTime);
    }
}

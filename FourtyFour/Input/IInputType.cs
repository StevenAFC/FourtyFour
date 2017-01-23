using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace FourtyFour.Input
{
    public interface IInputType
    {
        List<InputEvent> Update(GameTime gameTime);
    }
}

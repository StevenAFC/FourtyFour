using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace FourtyFour.Input
{
    public class InputManager
    {
        private List<IInputType> _inputTypes;

        public List<InputEvent> InputEvents;

        public InputManager()
        {
            _inputTypes = new List<IInputType>();

            _inputTypes.Add(new Keyboard());
        }

        public void Update(GameTime gameTime)
        {
            var inputEvents = new List<InputEvent>();

            foreach(var inputType in _inputTypes)
                inputEvents.AddRange(inputType.Update(gameTime));

            InputEvents = inputEvents;
        }
    }
}

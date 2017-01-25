using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace FourtyFour.Input
{
    public class Keyboard : IInputType
    {
        private KeyboardState _currentKeyboardState;
        private KeyboardState _previousKeyboardState;

        public List<InputEvent> Update(GameTime gameTime)
        {
            _currentKeyboardState = Microsoft.Xna.Framework.Input.Keyboard.GetState();
            var inputEvents = new List<InputEvent>();

            if (_currentKeyboardState.IsKeyDown(Keys.A)) inputEvents.Add(new InputEvent(1, ActionType.PressedLeft));
            if (_currentKeyboardState.IsKeyDown(Keys.D)) inputEvents.Add(new InputEvent(1, ActionType.PressedRight));
            if (_currentKeyboardState.IsKeyDown(Keys.W)) inputEvents.Add(new InputEvent(1, ActionType.PressedUp));
            if (_currentKeyboardState.IsKeyDown(Keys.S)) inputEvents.Add(new InputEvent(1, ActionType.PressedDown));
            
            if (_currentKeyboardState.IsKeyDown(Keys.Space)) inputEvents.Add(new InputEvent(1, ActionType.Shoot));

            _previousKeyboardState = _currentKeyboardState;

            return inputEvents;
        }
    }
}

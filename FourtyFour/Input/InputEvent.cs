using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourtyFour.Input
{
    public enum ActionType
    {
        PressedLeft,
        PressedRight
    }

    public class InputEvent
    {
        public int PlayerIndex;

        public ActionType ActionType;

        public InputEvent(int playerIndex, ActionType actionType)
        {
            PlayerIndex = playerIndex;
            ActionType = actionType;
        }
    }
}

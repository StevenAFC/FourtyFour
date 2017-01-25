namespace FourtyFour.Input
{
    public enum ActionType
    {
        PressedLeft,
        PressedRight,
        PressedUp,
        PressedDown,
        Shoot
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

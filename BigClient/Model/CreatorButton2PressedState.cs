namespace BigClient.Model
{
    class CreatorButton2PressedState : CreatorStates
    {
        public override IStateScreens CreateState(ScreensMachine screensMachine)
        {
            return new Button2Pressed(screensMachine);
        }
    }
}

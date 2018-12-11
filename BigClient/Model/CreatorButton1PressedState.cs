namespace BigClient.Model
{
    class CreatorButton1PressedState : CreatorStates
    {
        public override IStateScreens CreateState(ScreensMachine screensMachine)
        {
            return new Button1Pressed(screensMachine);
        }
    }
}

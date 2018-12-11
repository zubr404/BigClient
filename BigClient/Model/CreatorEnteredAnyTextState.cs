namespace BigClient.Model
{
    class CreatorEnteredAnyTextState : CreatorStates
    {
        public override IStateScreens CreateState(ScreensMachine screensMachine)
        {
            return new EnteredAnyText(screensMachine);
        }
    }
}

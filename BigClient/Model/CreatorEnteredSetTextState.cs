namespace BigClient.Model
{
    class CreatorEnteredSetTextState : CreatorStates
    {
        public override IStateScreens CreateState(ScreensMachine screensMachine)
        {
            return new EnteredSetText(screensMachine);
        }
    }
}

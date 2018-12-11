namespace BigClient.Model
{
    class CreatorInitialState : CreatorStates
    {
        public override IStateScreens CreateState(ScreensMachine screensMachine)
        {
            return new InitialState(screensMachine);
        }
    }
}

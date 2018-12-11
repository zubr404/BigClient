namespace BigClient.Model
{
    abstract class CreatorStates
    {
        public abstract IStateScreens CreateState(ScreensMachine screensMachine);
    }
}
